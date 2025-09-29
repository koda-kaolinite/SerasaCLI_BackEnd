package panels

import (
	"TransformeUI/internal/utils/components"
	"fmt"

	tea "github.com/charmbracelet/bubbletea"
	"github.com/charmbracelet/lipgloss"
)

type ActionsPanel struct {
	width, height int
	style         lipgloss.Style
}

func New() ActionsPanel {
	style := lipgloss.NewStyle().
		Border(lipgloss.RoundedBorder()).
		BorderForeground(lipgloss.Color("205")).
		Align(lipgloss.Center, lipgloss.Center)
	return ActionsPanel{
		style: style,
	}
}

func (m ActionsPanel) Update(msg tea.Msg) (ActionsPanel, tea.Cmd) {
	switch msg := msg.(type) {
	case tea.WindowSizeMsg:
		m.width, m.height = components.CalcSettingsPaneSize(msg.Width, msg.Height)
		m.style = m.style.Width(m.width).Height(m.height)
	}
	return m, nil
}

func (m ActionsPanel) View() string {
	return m.style.Render(fmt.Sprintf("Actions/Settings Panel\n%d x %d", m.width, m.height))
}

func (m ActionsPanel) Init() tea.Cmd {
	return nil
}
