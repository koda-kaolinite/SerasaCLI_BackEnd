module Tse_Backend.Infrastructure.Database

open System
open System.IO
open System.Text.Json
open Tse_Backend.Application.Logger
open Tse_Backend.Infrastructure.Models

[<CLIMutable>]
type DbContent =
    { Courses: Course list
      Persons: Person list
      Students: Student list
      SchoolUnities: SchoolUnity list }

let appDataPath =
    Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)

let appFolder = Path.Combine(appDataPath, "Tse")
let _ = Directory.CreateDirectory(appFolder)
let dbPath = Path.Combine(appFolder, "database.json")

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
    debug $"Local database saved in: \"%s{dbPath}\""

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
                error $"Error deserializing the database file: \"%s{ex.Message}\". Creating a new one."
                save ()
        else
            warn "The database file is empty. Creating a new one."
            save ()
    else
        warn "Database file not found. Creating a new one."
        save ()

let getCourses () = courses
let setCourses value = courses <- value

let getPersons () = persons
let setPersons value = persons <- value

let getStudents () = students
let setStudents value = students <- value

let getSchoolUnities () = schoolUnities
let setSchoolUnities value = schoolUnities <- value
