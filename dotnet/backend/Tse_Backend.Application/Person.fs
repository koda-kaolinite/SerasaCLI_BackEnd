namespace Tse_Backend.Application

open System
open Tse_Backend.Domain
open Tse_Backend.Application.Logger
open Tse_Backend.Application.Abstractions

type PersonService(repo: IPersonRepository) =
    member _.Create(name: string) : Result<Person, string> =
        try
            info $"Creating new person with name: %s{name}"
            let person = Person.Create(name)
            let createdPerson = repo.add person
            Ok createdPerson
        with ex ->
            Error ex.Message

    member _.FindById(id: Guid) : Result<Person, string> =
        info $"Searching for person with id: %A{id}"

        match repo.getById id with
        | Some person -> Ok person
        | None -> Error $"Person with id %A{id} not found."

    member _.Update(id: Guid, name: string) : Result<Person, string> =
        try
            info $"Updating person with id: %A{id}"
            let person = Person.Create(id, name)
            let updatedPerson = repo.update person
            Ok updatedPerson
        with ex ->
            Error ex.Message

    member _.Delete(id: Guid) : Result<unit, string> =
        try
            info $"Deleting person with id: %A{id}"
            repo.remove id
            Ok()
        with ex ->
            Error ex.Message

    member _.GetAll() : Result<Person list, string> =
        try
            info "Getting all people"
            let people = repo.getAll ()
            Ok people
        with ex ->
            Error ex.Message
