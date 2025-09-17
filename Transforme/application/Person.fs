module Transforme.application.Person

open System
open Transforme.domain.person
open Transforme.infrastructure
open Transforme.Logger

let Create (name: string) =
    info $"Criando nova pessoa com nome: %s{name}"
    let person = Person.Create(Guid.NewGuid(), name)
    PersonRepository.add person
    person

let FindById (id: Guid) =
    info $"Buscando pessoa com id: %A{id}"
    PersonRepository.getById id
