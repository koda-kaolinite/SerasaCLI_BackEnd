module Transforme.application.SchoolUnity

open System
open Transforme.domain.schoolUnity
open Transforme.infrastructure
open Transforme.Logger

let Create (id: Guid, name: string) =
    info $"Criando nova unidade escolar com nome: %s{name}"
    let schoolUnity = SchoolUnity.Create(id, name)
    SchoolUnityRepository.add schoolUnity
    schoolUnity

let FindById (id: Guid) =
    info $"Buscando unidade escolar com id: %A{id}"
    SchoolUnityRepository.getById id
