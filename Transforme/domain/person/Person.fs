namespace Transforme.domain.person

open System

type Person() =
    let mutable _privateName: string option = None
    member val Id: Guid option = None with get, set

    member this.Name
        with get (): string option = _privateName
        and set (value) =
            match value with
            | Some str when String.IsNullOrWhiteSpace(str) ->
                invalidArg (nameof value) "O Nome da pessoa não pode ser nulo."
            | _ -> _privateName <- value

    static member Create(id: Guid, name: string) =
        let person = Person()

        person.Id <- Some id
        person.Name <- Some name
        person

    override this.ToString() =
        let idStr =
            match this.Id with
            | Some guid -> guid.ToString("D")
            | None -> "N/A"

        let nameStr =
            match this.Name with
            | Some nome -> nome
            | None -> "N/A"

        $"Person(Id = {idStr}, Nome = \"{nameStr}\")"
