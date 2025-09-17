namespace Transforme.domain.schoolUnity

open System

type SchoolUnity() =
    let mutable _name: string option = None
    member val Id: Guid option = None with get, set

    member this.Name
        with get (): string option = _name
        and set (value) =
            match value with
            | Some str when String.IsNullOrWhiteSpace(str) ->
                invalidArg (nameof value) "Unidade escolar não pode ser nulo."
            | _ -> _name <- value

    static member Create(id: Guid, name: string) =
        let schoolUnity = SchoolUnity()

        schoolUnity.Id <- Some id
        schoolUnity.Name <- Some name
        schoolUnity

    override this.ToString() =
        let idStr =
            match this.Id with
            | Some guid -> guid.ToString("D")
            | None -> "N/A"

        let nameStr =
            match this.Name with
            | Some nome -> nome
            | None -> "N/A"

        $"SchoolUnity(Id = {idStr}, Nome = \"{nameStr}\")"
