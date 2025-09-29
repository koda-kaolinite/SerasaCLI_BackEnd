module Tse_Backend.Infrastructure.models.Student

open System

type Student =
    { Id: Guid
      PersonId: Guid
      CourseId: Guid option
      SchoolUnityId: Guid option }
