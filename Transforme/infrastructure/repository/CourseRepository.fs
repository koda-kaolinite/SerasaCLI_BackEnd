module Transforme.infrastructure.CourseRepository

open System
open Transforme.domain.course
open Transforme.infrastructure.Database
open Transforme.Logger

let getById (id: Guid) : Course option =
    debug $"Buscando curso com id: %A{id}"
    let courseOpt = getCourses () |> List.tryFind (fun c -> c.Id = Some id)
    match courseOpt with
    | Some _ -> debug $"Curso encontrado com id: %A{id}"
    | None -> debug $"Curso não encontrado com id: %A{id}"
    courseOpt

let add (course: Course) =
    debug $"Adicionando novo curso: %A{course}"
    setCourses (course :: getCourses ())
    save ()