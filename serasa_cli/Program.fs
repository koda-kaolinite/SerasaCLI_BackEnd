open Argu

// --- Definição dos Comandos da CLI ---
// TODO: Defina aqui os comandos que seu backend vai aceitar.
type ArgumentosCLI =
    | ComandoA of parametro: string
    | ComandoB of valorNumerico: int
    | ComandoC

    interface IArgParserTemplate with
        member s.Usage =
            match s with
            | ComandoA _ -> "Descrição para o Comando A."
            | ComandoB _ -> "Descrição para o Comando B."
            | ComandoC -> "Descrição para o Comando C."

// --- Funções de Lógica de Negócio ---
// Cada comando agora tem sua própria função.
// Elas retornam uma string (o JSON de sucesso) ou lançam uma exceção em caso de erro.

let executarComandoA (param: string) : string =
    eprintfn "LÓGICA: Executando ComandoA com parâmetro: %s" param
    // TODO: Implementar a lógica real aqui.
    // Se a lógica for bem-sucedida, retorne o JSON de sucesso.
    "{\"status\":\"ok_comando_a\"}"

let executarComandoB (valor: int) : string =
    eprintfn "LÓGICA: Executando ComandoB com valor: %d" valor
    // TODO: Implementar a lógica real aqui.
    // Exemplo de como sinalizar um erro de negócio:
    // if valor < 0 then failwith "O valor não pode ser negativo."
    "{\"status\":\"ok_comando_b\"}"

let executarComandoC () : string =
    eprintfn "LÓGICA: Executando ComandoC."
    // TODO: Implementar a lógica real aqui.
    "{\"status\":\"ok_comando_c\"}"


// --- Ponto de Entrada Otimizado ---

[<EntryPoint>]
let main argv =
    // A função 'main' agora é apenas uma coordenadora.
    try
        // 1. Parseia os argumentos
        let parser = ArgumentParser.Create<ArgumentosCLI>(programName = "backend.exe")
        let resultadoParse = parser.Parse(argv)

        // 2. Chama a função de lógica apropriada
        let respostaJson =
            match resultadoParse.GetAllResults() with
            | [ ComandoA param ] -> executarComandoA param
            | [ ComandoB valor ] -> executarComandoB valor
            | [ ComandoC ] -> executarComandoC ()
            | _ ->
                // Este caso lida com situações inesperadas.
                failwith "Comando inválido ou não fornecido."

        // 3. Imprime a resposta de sucesso
        printfn "%s" respostaJson

        // 4. Retorna o código de sucesso
        0

    with ex ->
        // Se qualquer parte acima falhar (parsing ou lógica de negócio),
        // a exceção é capturada aqui.
        eprintfn "ERRO: %s" ex.Message

        // TODO: Gerar uma resposta JSON de erro e imprimir em stderr.
        // Exemplo: eprintfn "{\"success\":false, \"error\":\"%s\"}" ex.Message

        // Retorna o código de erro
        1
