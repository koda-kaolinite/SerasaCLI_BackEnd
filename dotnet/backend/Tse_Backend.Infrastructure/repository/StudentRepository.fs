module Tse_Backend.Infrastructure.StudentRepository

open System
open Tse_Backend.Application.Abstractions
open Tse_Backend.Infrastructure.Database
open Tse_Backend.Infrastructure.Models
open Tse_Backend.Application.Logger

type DomainStudent = Tse_Backend.Domain.Student

// The createRepository function is the factory for our repository.
// It takes dependencies as arguments.
let createRepository (personRepo: IPersonRepository) (courseRepo: ICourseRepository) (schoolUnityRepo: ISchoolUnityRepository) : IStudentRepository =

    // --- Private helper functions ---
    // These are now defined inside the factory function so they can access the injected repositories.
    let toInfraStudent (domainStudent: DomainStudent) : Student =
        { Id = domainStudent.Id
          PersonId = domainStudent.Person.Id
          CourseId = Option.ofObj domainStudent.Course |> Option.map (fun c -> c.Id)
          SchoolUnityId = Option.ofObj domainStudent.SchoolUnity |> Option.map (fun su -> su.Id) }

    let toDomainStudent (infraStudent: Student) : DomainStudent =
        let person =
            match personRepo.getById infraStudent.PersonId with
            | Some p -> p
            | None -> failwith $"Data inconsistency: Person with id {infraStudent.PersonId} not found for student {infraStudent.Id}"

        let course = infraStudent.CourseId |> Option.bind courseRepo.getById |> Option.toObj

        let schoolUnity =
            infraStudent.SchoolUnityId
            |> Option.bind schoolUnityRepo.getById
            |> Option.toObj

        DomainStudent.Create(infraStudent.Id, person, course, schoolUnity)

    // --- Interface method implementations ---
    let getByIdImpl (id: Guid) : DomainStudent option =
        debug $"Searching for student with id: %A{id}"
        let studentOpt = getStudents () |> List.tryFind (fun (s: Student) -> s.Id = id)

        studentOpt |> Option.map toDomainStudent

    let addImpl (student: DomainStudent) : DomainStudent =
        debug $"Adding new student: %A{student}"
        let infraStudent = toInfraStudent student
        setStudents (infraStudent :: getStudents ())
        save ()
        debug "Student added"
        student

    let removeImpl (guid: Guid) : unit =
        debug $"Deleting student with Guid: %A{guid}"
        let allStudents = getStudents ()
        let studentsToKeep = allStudents |> List.filter (fun (s: Student) -> s.Id <> guid)

        setStudents studentsToKeep
        save ()
        debug "Student Removed"

    let updateImpl (student: DomainStudent) : DomainStudent =
        debug $"Updating student with Guid: %A{student.Id}"
        let allStudents = getStudents ()

        let updatedStudents =
            allStudents
            |> List.map (fun s -> if s.Id = student.Id then toInfraStudent student else s)

        setStudents updatedStudents
        save ()
        debug "Student Updated"
        student

    let convertToDomainImpl (infraStudents: obj list) : DomainStudent list =
        infraStudents |> Seq.cast<Student> |> List.ofSeq |> List.map toDomainStudent

    let getAllImpl () : DomainStudent list =
        debug "Getting all students"
        getStudents () |> List.map toDomainStudent

    // --- Public repository implementation ---
    // The factory returns a record matching the interface shape.
    { add = addImpl
      getById = getByIdImpl
      update = updateImpl
      remove = removeImpl
      getAll = getAllImpl
      convertToDomain = convertToDomainImpl }
