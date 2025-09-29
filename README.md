# Serasa CLI Project (Multi-Repo)

Welcome to the Serasa CLI Project repository. This is a monorepo that hosts multiple interconnected projects, each with its own technology and purpose.

## Overview

The goal of this set of projects is to provide a complete solution with a robust backend and different types of clients to interact with it.

## Repository Structure

The repository is organized as follows:

- **`/dotnet`**: Contains the entire .NET ecosystem.
  - **Backend**: A robust API developed with a Clean Architecture approach, using F# and C#.
  - **Desktop Frontend**: A Windows Forms (C#) client application for graphical interaction with the backend.

- **`/go`**: Contains a command-line interface (TUI - Text-based User Interface) client.
  - **TUI Client**: An application in Go that consumes the .NET backend, offering a text-based user experience in the terminal.

## Getting Started

To work with one of the projects, navigate to the corresponding directory (`/dotnet` or `/go`) and follow the instructions in its specific `README.md` file.