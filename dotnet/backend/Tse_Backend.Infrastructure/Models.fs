module Tse_Backend.Infrastructure.Models

open System

type Course =
    { Id: Guid
      Name: string
      WorkLoad: UInt16 }

type Person = { Id: Guid; Name: string }

type SchoolUnity = { Id: Guid; Name: string }

type Student =
    { Id: Guid
      PersonId: Guid
      CourseId: Guid option
      SchoolUnityId: Guid option }
