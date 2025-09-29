module Tse_Backend.Application.Logger

open System

let private log (level: string) (format: Printf.StringFormat<'T, unit>) =
    let timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Printf.kprintf (fun s -> printfn $"[%s{timestamp}] [%s{level}] %s{s}") format

let info format = log "info" format
let warn format = log "warn" format
let error format = log "error" format
let debug format = log "debug" format
