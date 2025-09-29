package panels

import (
	"TransformeUI/internal/utils/components"
	"fmt"

	tea "github.com/charmbracelet/bubbletea"
	"github.com/charmbracelet/lipgloss"
)

type InfoPanel struct {
	width, height int
	style         lipgloss.Style
}

func NewInfoPanel() InfoPanel {
	style := lipgloss.NewStyle().
		Border(lipgloss.RoundedBorder()).
		BorderForeground(lipgloss.Color("63")).
		Align(lipgloss.Center, lipgloss.Center)

	return InfoPanel{
		style: style,
	}
}

func (m InfoPanel) Update(msg tea.Msg) (InfoPanel, tea.Cmd) {
	switch msg := msg.(type) {
	case tea.WindowSizeMsg:
		m.width, m.height = components.CalcInfoPaneSize(msg.Width, msg.Height)
		m.style = m.style.Width(m.width).Height(m.height)
	}
	return m, nil
}

func (m InfoPanel) View() string {
	return m.style.Render(fmt.Sprintf("Info Panel\n%d x %d", m.width, m.height))
}
