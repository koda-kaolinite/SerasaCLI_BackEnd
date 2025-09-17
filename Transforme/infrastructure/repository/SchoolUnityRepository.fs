module Transforme.infrastructure.SchoolUnityRepository

open System
open Transforme.domain.schoolUnity
open Transforme.infrastructure.Database
open Transforme.Logger

let getById (id: Guid) : SchoolUnity option =
    debug $"Buscando unidade escolar com id: %A{id}"
    let schoolUnityOpt = getSchoolUnities() |> List.tryFind (fun su -> su.Id = Some id)
    match schoolUnityOpt with
    | Some _ -> debug $"Unidade escolar encontrada com id: %A{id}"
    | None -> debug $"Unidade escolar não encontrada com id: %A{id}"
    schoolUnityOpt

let add (schoolUnity: SchoolUnity) =
    debug $"Adicionando nova unidade escolar: %A{schoolUnity}"
    setSchoolUnities(schoolUnity :: getSchoolUnities())
    save()
