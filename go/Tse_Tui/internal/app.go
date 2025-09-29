package internal

import (
	"TransformeUI/internal/ui/components/panels"
	"TransformeUI/internal/utils"

	"github.com/charmbracelet/bubbles/key"
	tea "github.com/charmbracelet/bubbletea"
	"github.com/charmbracelet/lipgloss"
)

type App struct {
	terminalWidth,
	terminalHeight int
	actionsPanel panels.ActionsPanel
	infoPanel    panels.InfoPanel
	listPanel    panels.ListPanel
	keybindPanel panels.KeybindPanel
	keys         utils.KeyMap
}

func New() App {
	return App{
		keys:         utils.New(),
		actionsPanel: panels.New(),
		infoPanel:    panels.NewInfoPanel(),
		listPanel:    panels.NewListPanel(),
		keybindPanel: panels.NewKeybindPanel(),
	}
}

func (m App) Init() tea.Cmd {
	return nil
}

func (m App) Update(msg tea.Msg) (tea.Model, tea.Cmd) {
	var cmds []tea.Cmd

	switch msg := msg.(type) {

	case tea.WindowSizeMsg:
		m.terminalWidth = msg.Width
		m.terminalHeight = msg.Height

		var actionsCmd, infoCmd, listCmd, keybindCmd tea.Cmd
		m.actionsPanel, actionsCmd = m.actionsPanel.Update(msg)
		m.infoPanel, infoCmd = m.infoPanel.Update(msg)
		m.listPanel, listCmd = m.listPanel.Update(msg)
		m.keybindPanel, keybindCmd = m.keybindPanel.Update(msg)

		cmds = append(cmds, actionsCmd, infoCmd, listCmd, keybindCmd)
		return m, tea.Batch(cmds...)

	case tea.KeyMsg:
		return m.keyHandler(msg)
	}
	return m, tea.Batch(cmds...)
}

func (m App) View() string {
	if m.terminalWidth == 0 {
		return "Initializing..."
	}

	sideBar := lipgloss.JoinVertical(
		lipgloss.Left,
		m.actionsPanel.View(),
		m.listPanel.View(),
	)

	mainAndSide := lipgloss.JoinHorizontal(
		lipgloss.Top,
		m.infoPanel.View(),
		sideBar,
	)

	finalLayout := lipgloss.JoinVertical(
		lipgloss.Left,
		mainAndSide,
		m.keybindPanel.View(),
	)

	return finalLayout
}

func (m App) keyHandler(msg tea.KeyMsg) (tea.Model, tea.Cmd) {
	switch {
	case key.Matches(msg, m.keys.Quit):
		return m, tea.Quit
	}
	return m, nil
}
