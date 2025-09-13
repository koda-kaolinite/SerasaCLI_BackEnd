namespace Transforme.Adapter.DTO

open System

type Person(id: Guid, nome: string) =
    member this.Id = id
    member this.Nome = nome

    override this.ToString() =
        $"Person(Id = {this.Id}, Nome = \"{this.Nome}\")"
