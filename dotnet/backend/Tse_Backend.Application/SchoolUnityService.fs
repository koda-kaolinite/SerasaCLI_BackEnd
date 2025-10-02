namespace Tse_Backend.Application

open System
open Tse_Backend.Domain
open Tse_Backend.Application.Logger
open Tse_Backend.Application.Abstractions

type SchoolUnityService(repo: ISchoolUnityRepository) =
    member _.Create(name: string) : Result<SchoolUnity, string> =
        try
            info $"Creating new school unity with name: %s{name}"
            let schoolUnity = SchoolUnity.Create(name)
            let createdSchoolUnity = repo.add schoolUnity
            Ok createdSchoolUnity
        with ex ->
            Error ex.Message

    member _.FindById(id: Guid) : Result<SchoolUnity, string> =
        info $"Searching for school unity with id: %A{id}"

        match repo.getById id with
        | Some schoolUnity -> Ok schoolUnity
        | None -> Error $"School unity with id %A{id} not found."

    member _.Update(id: Guid, name: string) : Result<SchoolUnity, string> =
        try
            info $"Updating school unity with id: %A{id}"
            let schoolUnity = SchoolUnity.Create(id, name)
            let updatedSchoolUnity = repo.update schoolUnity
            Ok updatedSchoolUnity
        with ex ->
            Error ex.Message

    member _.Delete(id: Guid) : Result<unit, string> =
        try
            info $"Deleting school unity with id: %A{id}"
            repo.remove id
            Ok()
        with ex ->
            Error ex.Message

    member _.GetAll() : Result<SchoolUnity list, string> =
        try
            info "Getting all school unities"
            let schoolUnities = repo.getAll ()
            Ok schoolUnities
        with ex ->
            Error ex.Message
