module Transforme.domain.course.course

open System

type Course(id: Guid, nome: string, cargaHoraria: int64) =
    member this.Id = id
    member this.Nome = nome
    member this.CargaHoraria = cargaHoraria

    member this.Info() = $"Course(Nome : {this.Nome})"

    member this.Info(isDetailed: bool) =
        if isDetailed then
            $"Course(Nome : \"{this.Nome}\", CargaHoraria : {this.CargaHoraria})"
        else
            null

    override this.ToString() =
        $"Curso: \"{this.Nome}\" (ID: {this.Id}, Carga Horária: {this.CargaHoraria}h)"
