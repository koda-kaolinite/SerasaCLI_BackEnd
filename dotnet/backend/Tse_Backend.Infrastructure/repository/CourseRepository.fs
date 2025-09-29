module Tse_Backend.Infrastructure.CourseRepository

open System
open Tse_Backend.Application.Abstractions
open Tse_Backend.Infrastructure.Database
open Tse_Backend.Infrastructure.Models
open Tse_Backend.Application.Logger

type DomainCourse = Tse_Backend.Domain.Course

// --- Private helper functions ---
let private toInfraCourse (domainCourse: DomainCourse) : Course =
    { Id = domainCourse.Id
      Name = domainCourse.Name
      WorkLoad = domainCourse.WorkLoad }

let private toDomainCourse (infraCourse: Course) : DomainCourse =
    DomainCourse.Create(infraCourse.Id, infraCourse.Name, infraCourse.WorkLoad)

// --- Interface method implementations ---
let private getByIdImpl (id: Guid) : DomainCourse option =
    debug $"Searching for course with id: %A{id}"
    let courseOpt = getCourses () |> List.tryFind (fun (c: Course) -> c.Id = id)

    match courseOpt with
    | Some infraCourse ->
        debug $"Course found with id: %A{id}"
        Some(toDomainCourse infraCourse)
    | None ->
        debug $"Course not found with id: %A{id}"
        None

let private addImpl (course: DomainCourse) : DomainCourse =
    debug $"Adding new course: %A{course}"
    let infraCourse = toInfraCourse course
    setCourses (infraCourse :: getCourses ())
    save ()
    debug "Course added"
    course

let private removeImpl (guid: Guid) : unit =
    debug $"Deleting course with Guid: %A{guid}"
    let allCourses = getCourses ()
    let coursesToKeep = allCourses |> List.filter (fun c -> c.Id <> guid)
    setCourses coursesToKeep
    save ()
    debug "Course Removed"

let private updateImpl (course: DomainCourse) : DomainCourse =
    debug $"Updating course with Guid: %A{course.Id}"
    let allCourses = getCourses ()

    let updatedCourses =
        allCourses
        |> List.map (fun c -> if c.Id = course.Id then toInfraCourse course else c)

    setCourses updatedCourses
    save ()
    debug "Course Updated"
    course

let private getAllImpl () : DomainCourse list =
    debug "Getting all courses"
    getCourses () |> List.map toDomainCourse

// --- Public repository implementation ---
let repository: ICourseRepository =
    { add = addImpl
      getById = getByIdImpl
      update = updateImpl
      remove = removeImpl
      getAll = getAllImpl }
