module Transforme.infrastructure.Database

open System
open System.IO
open System.Text.Json
open Transforme.domain.course
open Transforme.domain.person
open Transforme.domain.student
open Transforme.domain.schoolUnity
open Transforme.Logger

[<CLIMutable>]
type DbContent =
    { Courses: Course list
      Persons: Person list
      Students: Student list
      SchoolUnities: SchoolUnity list }

let dbPath = "database.json"
let mutable courses: Course list = []
let mutable persons: Person list = []
let mutable students: Student list = []
let mutable schoolUnities: SchoolUnity list = []

let save () =
    let content =
        { Courses = courses
          Persons = persons
          Students = students
          SchoolUnities = schoolUnities }

    let options = JsonSerializerOptions(WriteIndented = true)
    let json = JsonSerializer.Serialize(content, options)
    File.WriteAllText(dbPath, json)
    debug $"Banco de dados local salvo em: \"%s{dbPath}\""

let load () =
    if File.Exists dbPath then
        let json = File.ReadAllText dbPath

        if not (String.IsNullOrWhiteSpace(json)) then
            try
                let options = JsonSerializerOptions()
                let content = JsonSerializer.Deserialize<DbContent>(json, options)
                courses <- content.Courses
                persons <- content.Persons
                students <- content.Students
                schoolUnities <- content.SchoolUnities
            with ex ->
                error $"Erro deserializando o arquivo do banco de dados: \"%s{ex.Message}\". Criando um novo."
                save ()
        else
            warn "O arquivo de banco de dados está vazio. Criando um novo."
            save ()
    else
        warn "Arquivo do banco de dados não encontrado. Criando um novo."
        save ()

let getCourses () = courses
let setCourses value = courses <- value

let getPersons () = persons
let setPersons value = persons <- value

let getStudents () = students
let setStudents value = students <- value

let getSchoolUnities () = schoolUnities
let setSchoolUnities value = schoolUnities <- value
