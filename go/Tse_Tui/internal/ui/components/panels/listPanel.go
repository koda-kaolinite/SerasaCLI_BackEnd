package panels

import (
	"TransformeUI/internal/utils/components"
	"fmt"

	tea "github.com/charmbracelet/bubbletea"
	"github.com/charmbracelet/lipgloss"
)

type ListPanel struct {
	width, height int
	style         lipgloss.Style
}

func NewListPanel() ListPanel {
	style := lipgloss.NewStyle().
		Border(lipgloss.RoundedBorder()).
		BorderForeground(lipgloss.Color("69")).
		Align(lipgloss.Center, lipgloss.Center)

	return ListPanel{
		style: style,
	}
}

func (m ListPanel) Update(msg tea.Msg) (ListPanel, tea.Cmd) {
	switch msg := msg.(type) {
	case tea.WindowSizeMsg:
		m.width, m.height = components.CalcListPaneSize(msg.Width, msg.Height, 1)
		m.style = m.style.Width(m.width).Height(m.height)
	}
	return m, nil
}

func (m ListPanel) View() string {
	return m.style.Render(fmt.Sprintf("List Panel\n%d x %d", m.width, m.height))
}
