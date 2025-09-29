module Tse_Backend.Infrastructure.models.Course

open System

type Course =
    { Id: Guid
      Name: string
      WorkLoad: UInt16 }
