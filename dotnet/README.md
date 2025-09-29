# .NET Project - Backend & WinForms Frontend

This directory contains the .NET ecosystem for the project, which includes the core backend API and a desktop frontend application.

## Components

### 1. Backend (`/backend`)

The backend is the core of the application, handling all business logic and data persistence.

- **Technology**: A hybrid stack of F# and C#.
- **Architecture**: It follows the principles of **Clean Architecture**, separating concerns into distinct layers:
  - `Tse_Backend.Domain` (C#): Core entities and business rules.
  - `Tse_Backend.Application` (F#): Application logic and use cases.
  - `Tse_Backend.Infrastructure` (F#): Data access, external services, etc.
- **Data Persistence**: Uses JSON files for data storage, as detailed in the architecture documents.

### 2. Windows Forms Frontend (`/frontend/Tse_Forms`)

A desktop application for users who prefer a graphical interface.

- **Technology**: C# and Windows Forms.
- **Functionality**: Provides a user-friendly way to interact with the features offered by the backend.

## How to Run

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version specified in `global.json`)

### Instructions

1.  **Open a terminal** in the `F:\SerasaCLI_BackEnd\dotnet` directory.

2.  **Build the entire solution**:
    ```sh
    dotnet build Tse.sln
    ```

3.  **To run the Backend** (for development or to be consumed by a client):
    ```sh
    dotnet run --project backend/Tse_Backend/Tse_Backend.fsproj
    ```

4.  **To run the Windows Forms Frontend**:
    ```sh
    dotnet run --project frontend/Tse_Forms/Tse_Forms.csproj
    ```

## Architecture

Our architectural decisions are documented in the `/docs` folder. These documents provide insight into the technology stack, patterns, and the reasoning behind them.
