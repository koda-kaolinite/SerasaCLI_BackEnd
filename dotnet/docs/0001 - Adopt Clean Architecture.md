## **Title: 0001 - Adopt Clean Architecture**

**Date:** 2025-09-29

**Status:** `Accepted`

---

### **Context**

The project requires a clear separation of concerns to ensure maintainability, testability, and independence from external frameworks and technologies. We need an architectural pattern that isolates the core business logic from infrastructure details like databases, UI, and external services.

---

### **Decision**

We will adopt the Clean Architecture pattern. The backend will be structured into three main projects, representing the distinct layers:

1. **`Tse_Backend.Domain` (C#):** The innermost layer, containing the core business entities and rules. It has no dependencies on any other layer.
2. **`Tse_Backend.Application` (F#):** This layer orchestrates the use cases of the application. It defines abstractions (interfaces) for repositories and contains the application-specific business logic. It depends only on the Domain layer.
3. **`Tse_Backend.Infrastructure` (F#):** The outermost layer, responsible for implementing the abstractions defined in the Application layer. This includes database access, logging, and other interactions with external systems. It depends on the Application and Domain layers.

Dependencies will always point inwards, from Infrastructure to Application, and from Application to Domain.

---

### **Consequences**

- **High Testability:** Business logic in the Domain and Application layers can be tested without external dependencies like a database.
- **Improved Maintainability:** The clear separation of concerns makes the codebase easier to understand, modify, and extend.
- **Technology Independence:** The core logic is decoupled from the database implementation (currently a JSON file), allowing it to be swapped out with minimal impact on the rest of the application.
- **Steeper Learning Curve:** Developers unfamiliar with Clean Architecture may need some time to understand the structure and dependency rule.
