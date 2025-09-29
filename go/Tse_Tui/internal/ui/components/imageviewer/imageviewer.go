package imageviewer

import (
	"TransformeUI/internal/utils"
	"image/color"

	"github.com/charmbracelet/bubbles/key"
	tea "github.com/charmbracelet/bubbletea"
	"github.com/charmbracelet/lipgloss"
	"github.com/eliukblau/pixterm/pkg/ansimage"
)

type Model struct {
	width, height int
	imagePath     string
	imageString   string // Armazenamos a imagem renderizada como string
	err           error
	keys          utils.KeyMap
}

func New(path string) Model {
	return Model{
		imagePath: path,
		keys:      utils.New(),
	}
}

func (m *Model) SetSize(width, height int) {
	m.width = width
	m.height = height
}

func (m Model) Init() tea.Cmd { return nil }

func (m *Model) Update(msg tea.Msg) (Model, tea.Cmd) {
	switch msg := msg.(type) {
	case tea.WindowSizeMsg:
		if m.width != msg.Width || m.height != msg.Height { // Only re-render if size actually changed
			m.width = msg.Width
			m.height = msg.Height
			m.renderImage()
		}
	case tea.KeyMsg:
		if key.Matches(msg, m.keys.Back) {
			return *m, func() tea.Msg { return utils.BackMsg{} }
		}
	}
	return *m, nil
}

// renderImage é uma função auxiliar para gerar a string da imagem.
func (m *Model) renderImage() {
	if m.width == 0 || m.imagePath == "" {
		return
	}

	// Use the height provided by the parent directly.
	// The parent is responsible for subtracting the help menu height.
	imageHeight := m.height

	scaledHeight := imageHeight * 2

	img, err := ansimage.NewScaledFromFile(
		m.imagePath,
		scaledHeight,
		m.width,
		color.Black,
		ansimage.ScaleModeFit,
		ansimage.NoDithering,
	)
	if err != nil {
		m.err = err
		return
	}

	m.imageString = img.Render()
	m.err = nil
}

func (m Model) View() string {
	if m.width == 0 {
		return "Carregando..."
	}

	if m.err != nil {
		return lipgloss.Place(m.width, m.height, lipgloss.Center, lipgloss.Center,
			"Erro ao carregar imagem: "+m.err.Error())
	}

	if m.imageString == "" {
		// Trigger initial render
		return "Renderizando imagem..."
	}

	return lipgloss.Place(m.width, m.height, lipgloss.Center, lipgloss.Center, m.imageString)
}
