namespace Transforme.domain.course

open System

type Course() =
    let mutable _name: string option = None
    let mutable _workLoad: int64 option = None
    member val Id: Guid option = None with get, set

    member this.Nome
        with get (): string option = _name
        and set (value) =
            match value with
            | Some str when String.IsNullOrWhiteSpace(str) ->
                invalidArg (nameof value) "O nome do curso não pode ser nulo ou vazio."
            | _ -> _name <- value

    member this.CargaHoraria
        with get (): int64 option = _workLoad
        and set (value) =
            match value with
            | Some carga when carga < 0L -> invalidArg (nameof value) "A carga horária não pode ser negativa."
            | _ -> _workLoad <- value

    static member Create(id: Guid, nome: string, cargaHoraria: int64) =
        let course = Course()
        course.Id <- Some id
        course.Nome <- Some nome
        course.CargaHoraria <- Some cargaHoraria
        course

    static member Info(course: Course) =
        let nomeStr =
            match course.Nome with
            | Some n -> n
            | None -> "N/A"

        $"Course(Nome : {nomeStr})"

    static member Info(course: Course, isDetailed: bool) =
        if isDetailed then
            let nomeStr =
                match course.Nome with
                | Some n -> n
                | None -> "N/A"

            let cargaStr =
                match course.CargaHoraria with
                | Some c -> c.ToString()
                | None -> "N/A"

            $"Course(Nome : \"{nomeStr}\", CargaHoraria : {cargaStr})"
        else
            null

    override this.ToString() =
        let idStr =
            match this.Id with
            | Some g -> g.ToString("D")
            | None -> "N/A"

        let nameStr =
            match this.Nome with
            | Some n -> n
            | None -> "N/A"

        let workLoadStr =
            match this.CargaHoraria with
            | Some wl -> $"{wl}h"
            | None -> "N/A"

        $"Curso: \"{nameStr}\" (ID: {idStr}, Carga Horária: {workLoadStr})"
