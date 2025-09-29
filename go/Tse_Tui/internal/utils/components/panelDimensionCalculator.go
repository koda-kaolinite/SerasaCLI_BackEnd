package components

import "math"

// Defaults
const (
	DefaultTerminalWidth  = 120
	DefaultTerminalHeight = 80

	DefaultElementsPadding = 2
)

// Panes
const (
	KeybindPaneHeight     = 1
	KeybindPanePadding    = 3
	KeybindPaneMarginTop  = 0
	StatusBarPaneHeight   = 5
	EditModeUiElementsSum = 4

	InfoPaneMarginRight = 1
	SidePaneLeftPadding = 5

	// A 'counterweight' is a sum of other elements' margins and paggings
	// The counterweight needs to be subtracted when calculating pane sizes
	// in order to properly align elements
	SettingsPaneHeightCounterweight = 3
	ListPaneHeightCounterweight     = 4
	InfoPaneVisualModeCounterweight = 1
)

// UI elements
const (
	ListRightShiftedItemPadding    = -2
	TextSelectorMaxWidthCorrection = 6
	InputContainerDelta            = 5

	ListItemMarginLeft  = 2
	ListItemPaddingLeft = 2

	WidthMinScalingLimit  = 120
	HeightMinScalingLimit = 46

	ListItemTrimThreshold  = 10
	ListItemTrimCharAmount = 14
)

func twoThirds(reference int) int {
	return int(math.Round(float64(reference) * (2.0 / 3.0)))
}

func oneThird(reference int) int {
	return int(math.Round(float64(reference) / 3.0))
}

func ensureNonNegative(number int) int {
	if number < 0 {
		return 0
	}
	return number
}

// KeybindPane is at the bottom
func CalcKeybindPaneSize(tw int) (w, h int) {
	return tw - KeybindPanePadding, KeybindPaneHeight
}

// InfoPane is the main content view
func CalcInfoPaneSize(tw, th int) (w, h int) {

	var (
		paneWidth  int
		paneHeight int
	)

	paneHeight = th - 6
	paneWidth = twoThirds(tw)

	return paneWidth, paneHeight
}

// SettingsPane is part of the sidebar
func CalcSettingsPaneSize(tw, th int) (w, h int) {
	_, infoPaneHeight := CalcInfoPaneSize(tw, th)
	settingsPaneWidth := oneThird(tw) - SidePaneLeftPadding
	settingsPaneHeight := oneThird(infoPaneHeight) - SettingsPaneHeightCounterweight

	settingsPaneWidth = ensureNonNegative(settingsPaneWidth)
	settingsPaneHeight = ensureNonNegative(settingsPaneHeight)

	if tw < WidthMinScalingLimit {
		return 0, settingsPaneHeight
	}
	return settingsPaneWidth, settingsPaneHeight
}

// ListPane is part of the sidebar
func CalcListPaneSize(tw, th int, offSet int) (w, h int) {
	_, infoPaneHeight := CalcInfoPaneSize(tw, th)
	sessionsPaneWidth := oneThird(tw) - SidePaneLeftPadding
	sessionsPaneHeight := twoThirds(infoPaneHeight) + offSet

	sessionsPaneWidth = ensureNonNegative(sessionsPaneWidth)
	sessionsPaneHeight = ensureNonNegative(sessionsPaneHeight)

	if tw < WidthMinScalingLimit {
		return 0, sessionsPaneHeight
	}
	return sessionsPaneWidth, sessionsPaneHeight
}
