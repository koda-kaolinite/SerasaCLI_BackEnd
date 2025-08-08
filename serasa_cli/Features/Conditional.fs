module Features.Conditional

// Função auxiliar para ler uma string do console e converter para float
let readStringAndConvertToFloat32 () : float32 option =
    let input = System.Console.ReadLine()
    match System.Single.TryParse(input) with
    | (true, value) -> Some value
    | (false, _) -> None

let run () =
    printfn "--- Condicional If-Else ---"
    printfn "Escreva o primeiro número:"
    let n1_option = readStringAndConvertToFloat32 ()

    printfn "Escreva o segundo número:"
    let n2_option = readStringAndConvertToFloat32 ()

    match (n1_option, n2_option) with
    | (Some n1_val, Some n2_val) ->
        if n1_val > n2_val then
            printfn $"O número %.2f{n1_val} é maior que %.2f{n2_val}"
        elif n1_val < n2_val then
            printfn $"O número %.2f{n2_val} é maior que %.2f{n1_val}"
        else
            printfn "Os números são iguais."
    | _ -> printfn "Entrada inválida. Por favor, digite apenas números válidos."

    printfn "
Pressione Enter para voltar ao menu..."
    System.Console.ReadLine() |> ignore