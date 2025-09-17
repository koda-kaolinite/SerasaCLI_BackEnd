namespace Transforme.domain.student

open System
open Transforme.domain.person
open Transforme.domain.course
open Transforme.domain.schoolUnity

type Student() =
    member val Id: Guid = Guid.Empty with get, set
    member val Person: Person option = None with get, set
    member val Course: Course option = None with get, set
    member val SchoolUnity: SchoolUnity option = None with get, set

    static member Create(id: Guid, person: Person option, course: Course option, schoolUnity: SchoolUnity option) =
        let student = Student()
        student.Id <- id

        match person with
        | Some _ -> student.Person <- person
        | None -> invalidArg (nameof person) "Pessoa não pode ser nulo."


        student.Course <- course
        student.SchoolUnity <- schoolUnity
        student

    override this.ToString() =
        let schoolUnityStr =
            match this.SchoolUnity with
            | Some su -> su.ToString()
            | None -> "N/A"

        $"Matrícula [{this.Id}] | Aluno: {this.Person} | Curso: {this.Course} | Unidade: {schoolUnityStr}"
