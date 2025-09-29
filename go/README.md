# Go Project - TUI Client

This directory contains the source code for the Text-based User Interface (TUI) client, built in Go.

## Overview

This application serves as a lightweight, terminal-based frontend for the .NET backend. It allows users to interact with the system's functionalities directly from their command line, providing a fast and efficient user experience.

## How to Run

### Prerequisites

- [Go](https://go.dev/doc/install) (check `go.mod` for version)

### Instructions

1.  **Open a terminal** and navigate to the application's directory:
    ```sh
    cd F:\SerasaCLI_BackEnd\go\Tse_Tui
    ```

2.  **Install dependencies**:
    This command ensures all required packages specified in `go.mod` are downloaded.
    ```sh
    go mod tidy
    ```

3.  **Run the application**:
    ```sh
    go run main.go
    ```

## Project Structure

- `main.go`: The entry point for the application.
- `/internal`: Contains the core application logic, separated by concern.
  - `app.go`: Main application struct and logic.
  - `/ui`: All TUI components, styles, and layouts.
  - `/utils`: Helper functions and utilities.
- `go.mod` / `go.sum`: Go module definitions and dependencies.
