module Transforme.infrastructure.Database

open System
open Transforme.Adapter.DTO
open Transforme.domain.course.course
open TransformeProjeto.Adapter.DTO.Student.Student

// Correto seria criar uma representação de domain em infra mas por motivos técnicos de preguiça, não precisa fazer

let Courses: Course list =
    [ Course(Guid.NewGuid(), "Desenvolvimento de Software", Random.Shared.NextInt64(2550))
      Course(Guid.NewGuid(), "Engenharia de Software", Random.Shared.NextInt64(2550))
      Course(Guid.NewGuid(), "UX / UI", Random.Shared.NextInt64(2550))
      Course(Guid.NewGuid(), "Marketing e Propaganda", Random.Shared.NextInt64(2550))
      Course(Guid.NewGuid(), "Desenvolvedor de Sistemas", Random.Shared.NextInt64(2550)) ]

let Persons: Person list =
    [ Person(Guid.NewGuid(), "Claudinho e Bochecha")
      Person(Guid.NewGuid(), "Henrique Fuzzy")
      Person(Guid.NewGuid(), "Aquele Lá da Silva")
      Person(Guid.NewGuid(), "Não sei o que e o sei que lá")
      Person(Guid.NewGuid(), "Isso sim Pereira Santos") ]

let Students: Student list =
    [ Student(Guid.NewGuid(), Persons[0], Courses[0], obj)
      Student(Guid.NewGuid(), Persons[1], Courses[1], obj)
      Student(Guid.NewGuid(), Persons[2], Courses[2], obj)
      Student(Guid.NewGuid(), Persons[3], Courses[3], obj)
      Student(Guid.NewGuid(), Persons[4], Courses[4], obj) ]
