package logo

//
//import (
//	"opossumm/internal/ui/styles"
//	"opossumm/internal/utils"
//	"strings"
//
//	tea "github.com/charmbracelet/bubbletea"
//)
//
//type Model struct {
//	colors styles.ColorPalette
//}
//
//func New() Model {
//	return Model{
//		colors: styles.DefaultColors(),
//	}
//}
//
//func (m Model) Init() tea.Cmd {
//	return nil
//}
//
//func (m Model) Update(msg tea.Msg) (Model, tea.Cmd) {
//	return m, nil
//}
//
//func (m Model) View() string {
//	logoBlock := strings.Join([]string{
//		"    ██╗██╗       ██████╗ ██████╗  ██████╗ ███████╗███████╗██╗   ██╗███╗   ███╗███╗   ███╗     ██████╗██╗     ██╗",
//		"   ██╔╝╚██╗     ██╔═══██╗██╔══██╗██╔═══██╗██╔════╝██╔════╝██║   ██║████╗ ████║████╗ ████║    ██╔════╝██║     ██║",
//		"  ██╔╝  ╚██╗    ██║   ██║██████╔╝██║   ██║███████╗███████╗██║   ██║██╔████╔██║██╔████╔██║    ██║     ██║     ██║",
//		" ██╔╝   ██╔╝    ██║   ██║██╔═══╝ ██║   ██║╚════██║╚════██║██║   ██║██║╚██╔╝██║██║╚██╔╝██║    ██║     ██║     ██║",
//		"██╔╝   ██╔╝     ╚██████╔╝██║     ╚██████╔╝███████║███████║╚██████╔╝██║ ╚═╝ ██║██║ ╚═╝ ██║    ╚██████╗███████╗██║",
//		"╚═╝    ╚═╝       ╚═════╝ ╚═╝      ╚═════╝ ╚══════╝╚══════╝ ╚═════╝ ╚═╝     ╚═╝╚═╝     ╚═╝     ╚═════╝╚══════╝╚═╝",
//		"                                                                                                                ",
//	}, "\n")
//
//	styledLogo := utils.GradientText(logoBlock, m.colors.GradientPurple, m.colors.GradientTeal, m.colors.GradientOrange)
//
//	return styledLogo
//}
