## **Title: 0002 - Hybrid C# and F# Technology Stack**

**Date:** 2025-09-29

**Status:** `Accepted`

---

### **Context**

The project requires a technology stack that is robust, modern, and leverages the strengths of different programming paradigms. We need to choose languages that are well-suited for defining business entities and implementing functional business logic.

---

### **Decision**

We will use a hybrid approach, combining C# and F# for different layers of the application:

- **`Tse_Backend.Domain` (C#):** The domain entities are implemented as C# `record` types. This choice provides a simple, clean syntax for defining immutable data structures that primarily hold state with minimal behavior.

- **`Tse_Backend.Application` & `Tse_Backend.Infrastructure` (F#):** The application logic, repository implementations, and the main application entry point are written in F#. This leverages F#'s strengths in functional programming, including immutability by default, powerful type inference, and constructs like the `Result` type, which are ideal for creating robust, side-effect-free business logic and data transformation pipelines.

---

### **Consequences**

- **Best of Both Worlds:** The solution benefits from the simplicity of C# for data representation and the robustness and expressiveness of F# for business logic and data handling.
- **Improved Correctness:** F#'s functional-first approach helps reduce bugs related to mutable state and side effects in the application and infrastructure layers.
- **Interoperability:** As both are .NET languages, C# and F# have seamless interoperability.
- **Developer Skillset:** The team needs to be comfortable with both C# and F#, or be willing to learn. The mix of paradigms might be challenging for developers accustomed to only one of them.
