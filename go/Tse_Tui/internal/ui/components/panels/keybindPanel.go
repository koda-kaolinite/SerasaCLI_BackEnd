package panels

import (
	"TransformeUI/internal/utils/components"
	"fmt"

	tea "github.com/charmbracelet/bubbletea"
	"github.com/charmbracelet/lipgloss"
)

type KeybindPanel struct {
	width, height int
	style         lipgloss.Style
}

func NewKeybindPanel() KeybindPanel {
	style := lipgloss.NewStyle().
		Border(lipgloss.RoundedBorder()).
		BorderForeground(lipgloss.Color("220")).
		Align(lipgloss.Center, lipgloss.Center)

	return KeybindPanel{
		style: style,
	}
}

func (m KeybindPanel) Update(msg tea.Msg) (KeybindPanel, tea.Cmd) {
	switch msg := msg.(type) {
	case tea.WindowSizeMsg:
		m.width, m.height = components.CalcKeybindPaneSize(msg.Width)
		m.style = m.style.Width(m.width).Height(m.height)
	}
	return m, nil
}

func (m KeybindPanel) View() string {
	return m.style.Render(fmt.Sprintf("Keybind Panel\n%d x %d", m.width, m.height))
}
