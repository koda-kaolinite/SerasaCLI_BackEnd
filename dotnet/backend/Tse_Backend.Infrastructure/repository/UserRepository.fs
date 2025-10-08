module Tse_Backend.Infrastructure.UserRepository

open System
open Tse_Backend.Application.Abstractions
open Tse_Backend.Infrastructure.Database
open Tse_Backend.Infrastructure.Models
open Tse_Backend.Application.Logger

type DomainUser = Tse_Backend.Domain.User
type DomainPerson = Tse_Backend.Domain.Person

// --- Private helper functions ---
let private toInfraUser (domainUser: DomainUser) : User =
    { Id = domainUser.Id
      PersonId = domainUser.Person.Id
      Username = domainUser.Username
      Email = domainUser.Email
      Password = domainUser.Password }

let private toDomainUser (infraUser: User) (person: DomainPerson) : DomainUser =
    DomainUser.Create(infraUser.Id, person, infraUser.Username, infraUser.Email, infraUser.Password)

let private findPersonById (personId: Guid) : DomainPerson option =
    let personOpt = getPersons () |> List.tryFind (fun (p: Person) -> p.Id = personId)
    match personOpt with
    | Some infraPerson -> Some(DomainPerson.Create(infraPerson.Id, infraPerson.Name))
    | None -> None

// --- Interface method implementations ---
let private getByIdImpl (id: Guid) : DomainUser option =
    debug $"Searching for user with id: %A{id}"
    let userOpt = getUsers () |> List.tryFind (fun (u: User) -> u.Id = id)

    match userOpt with
    | Some infraUser ->
        match findPersonById infraUser.PersonId with
        | Some person ->
            debug $"User found with id: %A{id}"
            Some(toDomainUser infraUser person)
        | None ->
            debug $"Person not found for user with id: %A{id}"
            None
    | None ->
        debug $"User not found with id: %A{id}"
        None

let private addImpl (user: DomainUser) : DomainUser =
    debug $"Adding new user: %A{user}"
    let infraUser = toInfraUser user
    setUsers (infraUser :: getUsers ())
    save ()
    debug "User added"
    user

let private removeImpl (guid: Guid) : unit =
    debug $"Deleting user with Guid: %A{guid}"
    let allUsers = getUsers ()
    let usersToKeep = allUsers |> List.filter (fun u -> u.Id <> guid)
    setUsers usersToKeep
    save ()
    debug "User Removed"

let private updateImpl (user: DomainUser) : DomainUser =
    debug $"Updating user with Guid: %A{user.Id}"
    let allUsers = getUsers ()

    let updatedUsers =
        allUsers
        |> List.map (fun u -> if u.Id = user.Id then toInfraUser user else u)

    setUsers updatedUsers
    save ()
    debug "User Updated"
    user

let private getAllImpl () : DomainUser list =
    debug "Getting all users"
    getUsers ()
    |> List.choose (fun infraUser ->
        match findPersonById infraUser.PersonId with
        | Some person -> Some(toDomainUser infraUser person)
        | None -> None)

// --- Public repository implementation ---
let repository: IUserRepository =
    { add = addImpl
      getById = getByIdImpl
      update = updateImpl
      remove = removeImpl
      getAll = getAllImpl }