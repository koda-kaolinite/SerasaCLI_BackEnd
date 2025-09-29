## **Title: 0003 - JSON File for Data Persistence**

**Date:** 2025-09-29

**Status:** `Accepted`

---

### **Context**

The application requires a simple and lightweight mechanism for data storage. For the initial version, we do not need the complexity, overhead, or setup of a full-fledged database system (like SQL Server or PostgreSQL). The data volume is expected to be small, and the application will be run locally.

---

### **Decision**

We will use a single JSON file (`database.json`) as the data store for the application. The file will be located in the user's local application data directory (`%APPDATA%\Tse`).

The `Tse_Backend.Infrastructure.Database` module in F# will be responsible for:

- Reading the entire JSON file into memory on application startup.
- Caching the data in mutable lists (`courses`, `persons`, etc.).
- Serializing the in-memory data and writing it back to the `database.json` file after every operation that modifies data (create, update, delete).

This approach provides a simple, zero-configuration persistence layer.

---

### **Consequences**

- **Simplicity:** No external database dependency is required. The application is self-contained.
- **Portability:** The `database.json` file can be easily backed up, edited manually (for debugging), or moved between systems.
- **Performance Risk:** Reading and writing the entire database on every modification can lead to performance issues as the data volume grows.
- **No Transactional Integrity:** This approach does not support atomic transactions. If the application crashes mid-write, the database file could become corrupted.
- **Not Suitable for Concurrent Access:** This implementation is not safe for concurrent use. It is only suitable for a single-user, single-process application like a CLI.
- **Future Migration:** If the application's needs grow, this persistence layer will need to be replaced with a more robust database system. However, thanks to the Clean Architecture, this change would be isolated to the Infrastructure layer.
