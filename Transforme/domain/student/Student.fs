module TransformeProjeto.Adapter.DTO.Student.Student

open System
open Transforme.Adapter.DTO
open Transforme.domain.course.course

type Student(id: Guid, person: Person, course: Course, schoolUnity: obj) =
    member this.Id: Guid = id
    member this.Person: Person = person
    member this.Course: Course = course
    member this.SchoolUnity: obj = schoolUnity

    override this.ToString() =
        $"Matrícula [{this.Id}] | Aluno: {this.Person} | Curso: {this.Course} | Unidade: {this.SchoolUnity}"
