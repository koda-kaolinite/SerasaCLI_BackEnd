module Tse_Backend.Infrastructure.PersonRepository

open System
open Tse_Backend.Application.Abstractions
open Tse_Backend.Infrastructure.Database
open Tse_Backend.Infrastructure.Models
open Tse_Backend.Application.Logger

type DomainPerson = Tse_Backend.Domain.Person

// --- Private helper functions ---
let private toInfraPerson (domainPerson: DomainPerson) : Person =
    { Id = domainPerson.Id
      Name = domainPerson.Name }

let private toDomainPerson (infraPerson: Person) : DomainPerson =
    DomainPerson.Create(infraPerson.Id, infraPerson.Name)

// --- Interface method implementations ---
let private getByIdImpl (id: Guid) : DomainPerson option =
    debug $"Searching for person with id: %A{id}"
    let personOpt = getPersons () |> List.tryFind (fun (p: Person) -> p.Id = id)

    match personOpt with
    | Some infraPerson ->
        debug $"Person found with id: %A{id}"
        Some(toDomainPerson infraPerson)
    | None ->
        debug $"Person not found with id: %A{id}"
        None

let private addImpl (person: DomainPerson) : DomainPerson =
    debug $"Adding new person: %A{person}"
    let infraPerson = toInfraPerson person
    setPersons (infraPerson :: getPersons ())
    save ()
    debug "Person added"
    person

let private removeImpl (guid: Guid) : unit =
    debug $"Deleting person with Guid: %A{guid}"
    let allPersons = getPersons ()
    let personsToKeep = allPersons |> List.filter (fun p -> p.Id <> guid)
    setPersons personsToKeep
    save ()
    debug "Person Removed"

let private updateImpl (person: DomainPerson) : DomainPerson =
    debug $"Updating person with Guid: %A{person.Id}"
    let allPersons = getPersons ()

    let updatedPersons =
        allPersons
        |> List.map (fun p -> if p.Id = person.Id then toInfraPerson person else p)

    setPersons updatedPersons
    save ()
    debug "Person Updated"
    person

let private getAllImpl () : DomainPerson list =
    debug "Getting all people"
    getPersons () |> List.map toDomainPerson

// --- Public repository implementation ---
let repository: IPersonRepository =
    { add = addImpl
      getById = getByIdImpl
      update = updateImpl
      remove = removeImpl
      getAll = getAllImpl }
