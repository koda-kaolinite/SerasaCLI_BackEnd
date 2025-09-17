module Transforme.application.Student

open System
open Transforme.domain.course
open Transforme.domain.person
open Transforme.domain.schoolUnity
open Transforme.domain.student
open Transforme.infrastructure
open Transforme.Logger

let Create (id: Guid, person: Person option, course: Course option, schoolUnity: SchoolUnity option) =
    let personName = person |> Option.bind (fun p -> p.Name) |> Option.defaultValue "N/A"
    info $"Criando novo estudante para a pessoa: %s{personName}"
    let student = Student.Create(Guid.NewGuid(), person, course, schoolUnity)
    StudentRepository.add student
    student

let FindById (id: Guid) =
    info $"Buscando estudante com id: %A{id}"
    StudentRepository.getById id