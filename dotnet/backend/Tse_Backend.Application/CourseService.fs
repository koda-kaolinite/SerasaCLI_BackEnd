namespace Tse_Backend.Application

open System
open Tse_Backend.Domain
open Tse_Backend.Application.Logger
open Tse_Backend.Application.Abstractions

type CourseService(repo: ICourseRepository) =
    member _.Create(name: string, duration: uint16) : Result<Course, string> =
        try
            info $"Creating new course with name: %s{name}"
            let course = Course.Create(name, duration)
            let createdCourse = repo.add course
            Ok createdCourse
        with ex ->
            Error ex.Message

    member _.FindById(id: Guid) : Result<Course, string> =
        info $"Searching for course with id: %A{id}"

        match repo.getById id with
        | Some course -> Ok course
        | None -> Error $"Course with id %A{id} not found."

    member _.Update(id: Guid, name: string, duration: uint16) : Result<Course, string> =
        try
            info $"Updating course with id: %A{id}"
            let course = Course.Create(id, name, duration)
            let updatedCourse = repo.update course
            Ok updatedCourse
        with ex ->
            Error ex.Message

    member _.Delete(id: Guid) : Result<unit, string> =
        try
            info $"Deleting course with id: %A{id}"
            repo.remove id
            Ok()
        with ex ->
            Error ex.Message

    member _.GetAll() : Result<Course list, string> =
        try
            info "Getting all courses"
            let courses = repo.getAll ()
            Ok courses
        with ex ->
            Error ex.Message
