# How to Use the Command-Line Interface (CLI)

> **WARNING:** Currently, the code that parses command-line arguments is disabled in the `Program.fs` file. The documentation below describes the **planned** functionality and serves as a guide for future development. To test the business logic, you must invoke the services manually in the code.

This document describes how to use the console application to interact with the system, detailing the arguments for
each command.

## Command Structure

All commands follow the base structure:

```shell
dotnet run --project backend/Tse_Backend/ -- [ENTITY] [COMMAND] [ARGUMENTS]
```

---

## Commands by Entity

### Course

| Command   | Arguments                                                    | Description                  |
|:----------|:-------------------------------------------------------------|:-----------------------------|
| `create`  | `--name <string>` (Required)<br>`--duration <uint16>` (Required) | Creates a new course.        |
| `get`     | `--id <Guid>` (Required)                                     | Fetches a course by its ID.  |
| `get-all` | (none)                                                       | Lists all courses.           |
| `delete`  | `--id <Guid>` (Required)                                     | Deletes a course by its ID.  |

*Creation example:*
`... course create --name "Systems Analysis" --duration 300`

### Person

| Command   | Arguments                 | Description                   |
|:----------|:--------------------------|:------------------------------|
| `create`  | `--name <string>` (Required) | Creates a new person.         |
| `get`     | `--id <Guid>` (Required)  | Fetches a person by their ID. |
| `get-all` | (none)                    | Lists all people.             |
| `delete`  | `--id <Guid>` (Required)  | Deletes a person by their ID. |

*Creation example:*
`... person create --name "Carlos da Silva"`

### School Unity

*(Note: The logic for these commands needs to be added to the `match` in `Program.fs`)*

| Command   | Arguments                 | Description                     |
|:----------|:--------------------------|:--------------------------------|
| `create`  | `--name <string>` (Required) | Creates a new school unity.     |
| `get`     | `--id <Guid>` (Required)  | Fetches a school unity by its ID. |
| `get-all` | (none)                    | Lists all school unities.       |
| `delete`  | `--id <Guid>` (Required)  | Deletes a school unity by its ID. |

### Student

*(Note: The logic for these commands needs to be added to the `match` in `Program.fs`)*

| Command   | Arguments                                                                                               | Description                                                                |
|:----------|:--------------------------------------------------------------------------------------------------------|:---------------------------------------------------------------------------|
| `create`  | `--name <string>` (Required)<br>`--course-id <Guid>` (Optional)<br>`--school-unity-id <Guid>` (Optional) | Creates a new student, optionally associating them with a course and unity. |
| `get`     | `--id <Guid>` (Required)                                                                              | Fetches a student.                                                         |
| `get-all` | (none)                                                                                                  | Lists all students.                                                        |
| `delete`  | `--id <Guid>` (Required)                                                                              | Deletes a student.                                                         |

*Creation example:*
`... student create --name "Ana" --course-id "f47ac10b-58cc-4372-a567-0e02b2c3d479"`
