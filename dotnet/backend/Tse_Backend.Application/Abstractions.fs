module Tse_Backend.Application.Abstractions

open System
open Tse_Backend.Domain

// Definition of the Result type for functional error handling
type Result<'TSuccess, 'TError> =
    | Ok of 'TSuccess
    | Error of 'TError

    member this.Item =
        match this with
        | Ok value -> value
        | Error _ -> invalidOp "Cannot access Item on an Error."

    member this.ErrorItem =
        match this with
        | Error value -> value
        | Ok _ -> invalidOp "Cannot access ErrorItem on an Ok."

// Abstraction for Person Repository
type IPersonRepository =
    { add: Person -> Person
      getById: Guid -> Person option
      update: Person -> Person
      remove: Guid -> unit
      getAll: unit -> Person list }

// Abstraction for SchoolUnity Repository
type ISchoolUnityRepository =
    { add: SchoolUnity -> SchoolUnity
      getById: Guid -> SchoolUnity option
      update: SchoolUnity -> SchoolUnity
      remove: Guid -> unit
      getAll: unit -> SchoolUnity list }

// Abstraction for Course Repository
type ICourseRepository =
    { add: Course -> Course
      getById: Guid -> Course option
      update: Course -> Course
      remove: Guid -> unit
      getAll: unit -> Course list }

// Abstraction for Student Repository
type IStudentRepository =
    { add: Student -> Student
      getById: Guid -> Student option
      update: Student -> Student
      remove: Guid -> unit
      getAll: unit -> Student list
      convertToDomain: obj list -> Student list }
