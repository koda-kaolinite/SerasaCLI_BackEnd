module Shared.ConsoleUtils

/// Tenta converter uma string para float32. Retorna Some(valor) em caso de sucesso e None em caso de falha.
let convertStringToFloat32 (texto: string) : float32 option =
    match System.Single.TryParse(texto) with
    | (true, value) -> Some value
    | (false, _) -> None

/// Lê uma linha do console e a converte para float32.
let readStringAndConvertToFloat32 () =
    let input = System.Console.ReadLine()
    convertStringToFloat32 input
