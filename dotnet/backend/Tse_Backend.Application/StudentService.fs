namespace Tse_Backend.Application

open System
open Tse_Backend.Domain
open Tse_Backend.Application.Logger
open Tse_Backend.Application.Abstractions

type StudentService(studentRepo: IStudentRepository, personRepo: IPersonRepository) =

    member _.Create(name: string, course: Course option, schoolUnity: SchoolUnity option) : Result<Student, string> =
        try
            info $"Creating new student with name: %s{name}"
            let person = Person.Create(name)
            let savedPerson = personRepo.add person

            // Convert F# option to C# nullable reference type
            let courseObj = course |> Option.toObj
            let schoolUnityObj = schoolUnity |> Option.toObj

            let student = Student.Create(savedPerson, courseObj, schoolUnityObj)
            let createdStudent = studentRepo.add student
            Ok createdStudent
        with ex ->
            Error ex.Message

    member _.FindById(id: Guid) : Result<Student, string> =
        info $"Searching for student with id: %A{id}"

        match studentRepo.getById id with
        | Some student -> Ok student
        | None -> Error $"Student with id %A{id} not found."

    member _.Update
        (id: Guid, name: string, course: Course option, schoolUnity: SchoolUnity option)
        : Result<Student, string> =
        try
            info $"Updating student with id: %A{id}"

            match studentRepo.getById id with
            | Some existingStudent ->
                // Create a new Person with the updated name
                let updatedPerson = Person.Create(existingStudent.Person.Id, name)
                personRepo.update updatedPerson |> ignore

                // Create a new Student with the updated information
                let courseObj = course |> Option.toObj
                let schoolUnityObj = schoolUnity |> Option.toObj
                let updatedStudent = Student.Create(existingStudent.Id, updatedPerson, courseObj, schoolUnityObj)

                let finalStudent = studentRepo.update updatedStudent
                Ok finalStudent
            | None ->
                Error $"Student with id %A{id} not found."
        with ex ->
            Error ex.Message

    member _.Delete(id: Guid) : Result<unit, string> =
        try
            info $"Deleting student with id: %A{id}"
            studentRepo.remove id
            // Also delete the corresponding person
            personRepo.remove id
            Ok()
        with ex ->
            Error ex.Message

    member _.GetAll() : Result<Student list, string> =
        try
            info "Getting all students"
            let students = studentRepo.getAll ()
            Ok students
        with ex ->
            Error ex.Message
