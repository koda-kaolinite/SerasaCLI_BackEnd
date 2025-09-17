module Transforme.application.Course

open System
open Transforme.domain.course
open Transforme.infrastructure
open Transforme.Logger

let Create (id: Guid, name: string, workLoad: int64) =
    info $"Criando novo curso com nome: %s{name}"
    let course = Course.Create(id, name, workLoad)
    CourseRepository.add course
    course

let FindById (id: Guid) =
    info $"Buscando curso com id: %A{id}"
    CourseRepository.getById id
