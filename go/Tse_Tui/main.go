package main

import (
	"TransformeUI/internal"
	"fmt"
	"os"

	tea "github.com/charmbracelet/bubbletea"
)

func main() {
	m := internal.New()

	p := tea.NewProgram(m, tea.WithAltScreen())

	if _, err := p.Run(); err != nil {
		fmt.Println("Ocorreu um erro ao executar o programa:", err)
		os.Exit(1)
	}
}

// Todo: Quando entrar na tela de mais informações, conseguir apagar o texto escrito.
// Todo: Criar um Menu mais atraente.
// Todo: Criar a opção de cadastrar Aluno.
// Todo: Criar a opção de cadastrar Curso.
// Todo: Criar a opção de cadastrar Unidade de ensino.
// Todo: Criar um formulário para Cadastrar Aluno.
// Todo: Criar um formulário para Cadastrar Curso.
// Todo: Criar um formulário para Cadastrar Unidade de ensino.
// Todo: Criar uma Tela para navegar entre os dados.
// Todo: Na tela Sobre, ele só retorna se apertar ESC.
// Todo: Criar uma verificação se o user quer sair do APP.
// Todo: Criar algo para informar qual janela é a selecionada para os comandos ir para ela (permite repetição de tecla, com a ação indo para a janela em foco.
// Todo: Definir um Min Size e Max size, e caso bata o max size ele deve realizar uma quebra de linha.
// Todo:
// Todo:
// Todo:
