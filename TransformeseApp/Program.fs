module TransformeseApp

open System
open Spectre.Console
open Components

// A sua arte ASCII está perfeita aqui.
Logo.printLogo ()

// Função para desenhar o menu principal
let showMenu () =
    printfn "===================================================="
    printfn "             MENU DE EXEMPLOS F#                  "
    printfn "===================================================="
    printfn "1- Condicional if-else"
    // ... (outras opções)
    printfn "0- Sair"
    printfn "===================================================="
    printfn "\nEscolha uma opção."

// Função para pausar e esperar o usuário pressionar Enter
let pressEnterToContinue () =
    printfn "\nPressione Enter para continuar..."
    Console.ReadLine() |> ignore

// O loop principal que gerencia a aplicação
let rec mainLoop () =
    Logo.printLogo () // Mostra o logo e o cabeçalho a cada iteração
    showMenu () // Mostra as opções do menu

    let userSelection = Console.ReadLine()

    match userSelection with
    | "1" ->
        // Simula a execução de uma funcionalidade
        AnsiConsole.MarkupLine("[green]Executando a lógica do if-else...[/]")
        pressEnterToContinue () // Pausa para o usuário ver o resultado
    | "0" -> AnsiConsole.MarkupLine("[red]Saindo...[/]")
    | _ ->
        AnsiConsole.MarkupLine("[bold red]Opção Inválida.[/]")
        pressEnterToContinue () // Pausa para o usuário ver a mensagem de erro

    // Continua o loop apenas se a opção não for para sair
    if userSelection <> "0" then
        mainLoop ()

[<EntryPoint>]
let main argv =
    // 1. Mostra o cabeçalho pela primeira vez
    Logo.printLogo ()

    // 2. Adiciona a pausa que você pediu aqui!
    pressEnterToContinue ()

    // 3. Inicia o loop principal do menu
    mainLoop ()

    printfn "O programa terminou. Pressione Enter para fechar."
    Console.ReadLine() |> ignore // <--- ADICIONE ESTA LINHA

    0 // Retorna código de sucesso
