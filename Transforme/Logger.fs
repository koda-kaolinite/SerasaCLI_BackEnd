module Transforme.Logger

let info (format: Printf.StringFormat<'T, unit>) =
    Printf.kprintf (fun s -> printfn $"[info] %s{s}") format

let warn (format: Printf.StringFormat<'T, unit>) =
    Printf.kprintf (fun s -> printfn $"[warn] %s{s}") format

let error (format: Printf.StringFormat<'T, unit>) =
    Printf.kprintf (fun s -> printfn $"[error] %s{s}") format

let debug (format: Printf.StringFormat<'T, unit>) =
    Printf.kprintf (fun s -> printfn $"[debug] %s{s}") format
