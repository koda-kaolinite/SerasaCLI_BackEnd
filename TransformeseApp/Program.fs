module TransformeseApp

open System

// Função principal do programa
let rec mainLoop () =
    Console.Clear() // Limpa o console para uma melhor visualização
    printfn "===================================================="
    printfn "             MENU DE EXEMPLOS F#                  "
    printfn "===================================================="
    printfn "1- Condicional if-else"
    printfn "2- Enquanto while"
    printfn "3- Faça-enquanto do-while"
    printfn "4- Para for"
    printfn "5- Vetores arrays"
    printfn "6- Para-cada for-each"
    printfn "7- Faça-enquanto do-while"
    printfn "8- Matriz arrays[][]"
    printfn "9- Funções functions"
    printfn "0- Sair"
    printfn "===================================================="
    printfn "\nEscolha uma opção."

    let userSelection = Console.ReadLine()

    match userSelection with
    | "1" -> Features.Conditional.run ()
    // | "2" -> Features.Loops.runWhile () // Exemplo para o futuro
    | "0" -> printfn "Saindo..."
    | _ ->
        printfn "Opção Inválida. Pressione Enter para tentar novamente."
        Console.ReadLine() |> ignore

    // Se a opção não for "0", continua o loop
    if userSelection <> "0" then
        mainLoop ()

[<EntryPoint>]
let main argv =
    mainLoop ()
    0 // Código de saída
