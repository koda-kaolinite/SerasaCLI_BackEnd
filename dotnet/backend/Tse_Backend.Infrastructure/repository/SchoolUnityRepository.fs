module Tse_Backend.Infrastructure.SchoolUnityRepository

open System
open Tse_Backend.Application.Abstractions
open Tse_Backend.Infrastructure.Database
open Tse_Backend.Infrastructure.Models
open Tse_Backend.Application.Logger

type DomainSchoolUnity = Tse_Backend.Domain.SchoolUnity

// --- Private helper functions ---
let private toInfraSchoolUnity (domainSchoolUnity: DomainSchoolUnity) : SchoolUnity =
    { Id = domainSchoolUnity.Id
      Name = domainSchoolUnity.Name }

let private toDomainSchoolUnity (infraSchoolUnity: SchoolUnity) : DomainSchoolUnity =
    DomainSchoolUnity.Create(infraSchoolUnity.Id, infraSchoolUnity.Name)

// --- Interface method implementations ---
let private getByIdImpl (id: Guid) : DomainSchoolUnity option =
    debug $"Searching for school unity with id: %A{id}"

    let schoolUnityOpt =
        getSchoolUnities () |> List.tryFind (fun (su: SchoolUnity) -> su.Id = id)

    match schoolUnityOpt with
    | Some infraSchoolUnity ->
        debug $"School unity found with id: %A{id}"
        Some(toDomainSchoolUnity infraSchoolUnity)
    | None ->
        debug $"School unity not found with id: %A{id}"
        None

let private addImpl (schoolUnity: DomainSchoolUnity) : DomainSchoolUnity =
    debug $"Adding new school unity: %A{schoolUnity}"
    let infraSchoolUnity = toInfraSchoolUnity schoolUnity
    setSchoolUnities (infraSchoolUnity :: getSchoolUnities ())
    save ()
    debug "School Unity added"
    schoolUnity

let private removeImpl (guid: Guid) : unit =
    debug $"Deleting school unity with Guid: %A{guid}"
    let allSchoolUnities = getSchoolUnities ()
    let schoolUnitiesToKeep = allSchoolUnities |> List.filter (fun su -> su.Id <> guid)
    setSchoolUnities schoolUnitiesToKeep
    save ()
    debug "School Unity Removed"

let private updateImpl (schoolUnity: DomainSchoolUnity) : DomainSchoolUnity =
    debug $"Updating school unity with Guid: %A{schoolUnity.Id}"
    let allSchoolUnities = getSchoolUnities ()

    let updatedSchoolUnities =
        allSchoolUnities
        |> List.map (fun su ->
            if su.Id = schoolUnity.Id then
                toInfraSchoolUnity schoolUnity
            else
                su)

    setSchoolUnities updatedSchoolUnities
    save ()
    debug "School Unity Updated"
    schoolUnity

let private getAllImpl () : DomainSchoolUnity list =
    debug "Getting all school unities"
    getSchoolUnities () |> List.map toDomainSchoolUnity

// --- Public repository implementation ---
let repository: ISchoolUnityRepository =
    { add = addImpl
      getById = getByIdImpl
      update = updateImpl
      remove = removeImpl
      getAll = getAllImpl }
