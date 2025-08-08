module Components.Logo

open Spectre.Console

let myIcon =
    """
[blue]    ██╗██╗       ██████╗ ██████╗  ██████╗ ███████╗███████╗██╗   ██╗███╗   ███╗[/]
[cyan]   ██╔╝╚██╗     ██╔═══██╗██╔══██╗██╔═══██╗██╔════╝██╔════╝██║   ██║████╗ ████║[/]
[fuchsia]  ██╔╝  ╚██╗    ██║   ██║██████╔╝██║   ██║███████╗███████╗██║   ██║██╔████╔██║[/]
[purple] ██╔╝   ██╔╝    ██║   ██║██╔═══╝ ██║   ██║╚════██║╚════██║██║   ██║██║╚██╔╝██║[/]
[blue]██╔╝   ██╔╝     ╚██████╔╝██║     ╚██████╔╝███████║███████║╚██████╔╝██║ ╚═╝ ██║[/]
[cyan]╚═╝    ╚═╝       ╚═════╝ ╚═╝      ╚═════╝ ╚══════╝╚══════╝ ╚═════╝ ╚═╝     ╚═╝[/]
                                                                              
    """

let printLogo () =
    AnsiConsole.Clear()
    AnsiConsole.WriteLine()
    AnsiConsole.WriteLine()
    AnsiConsole.Write(Align.Center(new Markup(myIcon)))
    AnsiConsole.WriteLine()
    AnsiConsole.WriteLine()
    AnsiConsole.Write(Align.Center(new Markup("[yellow]Bem-vindo ao seu App F#[/]")))
    AnsiConsole.WriteLine()
