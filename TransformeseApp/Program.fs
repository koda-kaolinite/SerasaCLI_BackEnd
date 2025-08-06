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
printfn "\n Escolha uma opção."

let UserSelection = System.Console.ReadLine()

let convertStringToFloat32 (texto: string) : float32 option =
    match System.Single.TryParse(texto) with
    | (true, value) -> Some value

    | (false, _) -> None // Retornamos 'None' para sinalizar a falha

let readStringAndConvertToFloat32 () =
    let v = System.Console.ReadLine()
    convertStringToFloat32 v

let condicional () =
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

let opcaoInvalida () = printfn "Opção Inválida"

match UserSelection with
| "1" -> condicional ()
| _ -> opcaoInvalida ()
