module Transforme.infrastructure.StudentRepository

open System
open Transforme.infrastructure.Database
open Transforme.domain.student
open Transforme.Logger

let getById (id: Guid) : Student option =
    debug $"Buscando estudante com id: %A{id}"
    let studentOpt = getStudents () |> List.tryFind (fun s -> s.Id = id)
    match studentOpt with
    | Some _ -> debug $"Estudante encontrado com id: %A{id}"
    | None -> debug $"Estudante não encontrado com id: %A{id}"
    studentOpt

let add (student: Student) =
    debug $"Adicionando novo estudante: %A{student}"
    setStudents (student :: getStudents ())
    save ()