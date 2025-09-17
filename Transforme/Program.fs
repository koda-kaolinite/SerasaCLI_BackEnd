open Transforme.Logger
open Transforme.application.Person
open Transforme.infrastructure
open Transforme.infrastructure.Database

info "Iniciando Banco de dados local..."

load ()

info
    $"Banco de dados carregado com sucesso. Foi encontrado %d{getCourses().Length} cursos, %d{getPersons().Length} pessoas e %d{getStudents().Length} estudantes."

let person = Create("Cláudio")

info $"Resultado final: {person}"
