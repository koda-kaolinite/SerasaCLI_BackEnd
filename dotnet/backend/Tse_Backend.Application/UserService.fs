namespace Tse_Backend.Application

open System
open Tse_Backend.Domain
open Tse_Backend.Application.Logger
open Tse_Backend.Application.Abstractions

type UserService(userRepo: IUserRepository, personRepo: IPersonRepository) =
    member _.Create(personId: Guid, username: string, email: string, password: string) : Result<User, string> =
        try
            info $"Creating new user for person with id: %A{personId}"
            match personRepo.getById personId with
            | Some person ->
                let user = User.Create(person, username, email, password)
                let createdUser = userRepo.add user
                Ok createdUser
            | None -> Error $"Person with id %A{personId} not found."
        with ex ->
            Error ex.Message

    member _.FindById(id: Guid) : Result<User, string> =
        info $"Searching for user with id: %A{id}"

        match userRepo.getById id with
        | Some user -> Ok user
        | None -> Error $"User with id %A{id} not found."

    member _.Update(id: Guid, personId: Guid, username: string, email: string, password: string) : Result<User, string> =
        try
            info $"Updating user with id: %A{id}"
            match personRepo.getById personId with
            | Some person ->
                let user = User.Create(id, person, username, email, password)
                let updatedUser = userRepo.update user
                Ok updatedUser
            | None -> Error $"Person with id %A{personId} not found."
        with ex ->
            Error ex.Message

    member _.Delete(id: Guid) : Result<unit, string> =
        try
            info $"Deleting user with id: %A{id}"
            userRepo.remove id
            Ok()
        with ex ->
            Error ex.Message

    member _.GetAll() : Result<User list, string> =
        try
            info "Getting all users"
            let users = userRepo.getAll ()
            Ok users
        with ex ->
            Error ex.Message
