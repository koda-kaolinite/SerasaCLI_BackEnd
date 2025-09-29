# **Backend Architecture Overview**

This document provides an overview of the backend architecture for the Tse project, designed as a command-line interface (CLI) application for managing educational entities.

## **1. Architectural Pattern: Clean Architecture**

The project adopts the principles of **Clean Architecture**. This approach organizes code into concentric layers with the fundamental rule that dependencies can only point inwards. This ensures that the core business logic is independent of implementation details like databases, frameworks, or user interfaces.

The project layers are:

- **`Tse_Backend.Domain` (Inner Layer):** Contains the core business entities (`Person`, `Course`, `Student`, `SchoolUnity`). This layer is the heart of the application and has no external dependencies.

- **`Tse_Backend.Application` (Intermediate Layer):** Orchestrates the application's use cases (e.g., `CreatePerson`, `FindCourseById`). It defines abstractions (interfaces) for external dependencies, such as data repositories (`IPersonRepository`).

- **`Tse_Backend.Infrastructure` (Outer Layer):** Implements the abstractions defined in the Application layer. It is responsible for database access (currently a JSON file), logging, and other interactions with the "outside world".

*(For more details, see ADR: `0001 - Adopt Clean Architecture.md`)*

## **2. Technology Stack**

The backend uses a combination of C# and F#:

- **C#** is used in the **Domain** layer to define entities as `records`, providing a clean syntax for immutable data objects.
- **F#** is used in the **Application** and **Infrastructure** layers. The functional nature of F# is ideal for implementing business logic and data transformations robustly and with fewer side effects.

*(For more details, see ADR: `0002 - Hybrid CSharp and FSharp Technology Stack.md`)*

## **3. Data Persistence**

For simplicity, the application uses a **JSON file (`database.json`)** as its database. This file is stored in the user's local application data directory.

The infrastructure layer reads this file on startup and saves it again after every write operation. This approach is suitable for a single-user, small-scale application but is not recommended for scenarios with multiple users or large data volumes.

*(For more details, see ADR: `0003 - JSON File for Data Persistence.md`)*

## **4. Execution Flow (Example: Creating a Person)**

1. The user runs the command via CLI: `... person create --name "New Person"`.
2. `Program.fs` (the entry point) interprets the command.
3. It invokes the `PersonService` from the **Application** layer.
4. The `PersonService` creates a `Person` entity from the **Domain** layer.
5. The service then calls the `add` method of the `IPersonRepository` implementation, which is in the **Infrastructure** layer.
6. The repository implementation adds the new person object to the in-memory list and calls the `save` function to persist the updated list to the `database.json` file.
7. The result (success or error) is returned to the user interface (the console).

