module Transforme.infrastructure.PersonRepository

open System
open Transforme.domain.person
open Transforme.infrastructure.Database
open Transforme.Logger

let getById (id: Guid) : Person option =
    debug $"Buscando pessoa com id: %A{id}"
    let personOpt = getPersons () |> List.tryFind (fun p -> p.Id = Some id)
    match personOpt with
    | Some _ -> debug $"Pessoa encontrada com id: %A{id}"
    | None -> debug $"Pessoa não encontrada com id: %A{id}"
    personOpt

let add (person: Person) =
    debug $"Adicionando nova pessoa: %A{person}"
    setPersons (person :: getPersons ())
    save ()