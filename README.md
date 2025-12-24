# C# Prerequisites for Vantaca NextGen Repository

This document outlines the essential knowledge and skills an intern needs to effectively work with the Vantaca NextGeneration codebase.

## Table of Contents
1. [C# Fundamentals](#c-fundamentals)
2. [.NET 8 Features](#net-8-features)
3. [Entity Framework Core](#entity-framework-core)
4. [LINQ (Language Integrated Query)](#linq-language-integrated-query)
5. [Asynchronous Programming](#asynchronous-programming)
6. [Dependency Injection](#dependency-injection)
7. [REST API Development](#rest-api-development)
8. [Testing](#testing)
9. [Azure Functions](#azure-functions)
10. [Architecture Patterns](#architecture-patterns)
11. [Recommended Learning Resources](#recommended-learning-resources)

---

## C# Fundamentals

### Core Concepts
- **Object-Oriented Programming (OOP)**
  - Classes, objects, inheritance, polymorphism, encapsulation
  - Access modifiers (public, private, protected, internal)
  - Constructors and destructors
  - Static members

- **Data Types**
  - Value types (int, bool, struct, enum)
  - Reference types (class, string, array)
  - Nullable types (`int?`, `string?`)
  - Type conversion and casting

- **Control Flow**
  - If/else statements
  - Switch expressions
  - Loops (for, foreach, while, do-while)
  - Exception handling (try/catch/finally)

- **Collections**
  - Arrays
  - Lists (`List<T>`)
  - Dictionaries (`Dictionary<TKey, TValue>`)
  - IEnumerable and IQueryable interfaces
  - When to use each collection type

- **Properties and Methods**
  - Auto-properties
  - Property initializers
  - Method overloading
  - Extension methods

### Modern C# Features (C# 8.0+)
- **Nullable Reference Types**
  - Understanding `?` operator
  - Null-conditional operators (`?.`, `??`)
  - Null-coalescing assignment (`??=`)

- **Pattern Matching**
  - Switch expressions
  - Type patterns
  - Property patterns

- **Records**
  - Record types vs classes
  - Immutability
  - `with` expressions for creating modified copies
  - Primary constructors for records

- **Init-only Properties**
  - `{ get; init; }` syntax
  - `required` keyword

---

## .NET 8 Features

### Essential .NET Concepts
- **Project Structure**
  - `.csproj` files
  - Solution files (`.sln`)
  - Namespaces and using directives
  - File-scoped namespaces

- **Primary Constructors** (C# 12 / .NET 8)
  - Constructor syntax in class declaration
  - Dependency injection with primary constructors
  - Example from codebase:
    ```csharp
    public class PortalUserService(VantacaContext context) : IPortalUserService
    {
        // _context is automatically available
    }
    ```

- **Implicit Usings**
  - Understanding `ImplicitUsings` in .csproj
  - Common namespaces automatically imported

- **Target Framework**
  - Understanding `net8.0` target framework
  - Framework-specific APIs

---

## Entity Framework Core

### Core Concepts
- **DbContext**
  - Understanding DbContext lifecycle
  - DbSet properties
  - Configuration and setup

- **LINQ to Entities**
  - Querying databases with LINQ
  - Deferred execution
  - IQueryable vs IEnumerable
  - When queries execute (materialization)

- **Async Methods**
  - `ToListAsync()`, `FirstOrDefaultAsync()`, `CountAsync()`
  - `SaveChangesAsync()`
  - Always use async methods for database operations

- **Query Syntax**
  - Query syntax (`from...where...select`)
  - Method syntax (`.Where()`, `.Select()`, `.Join()`)
  - Mixing both syntaxes

- **Joins**
  - Inner joins
  - Left joins (using `DefaultIfEmpty()`)
  - Multiple joins in a single query

- **Filtering and Projection**
  - `Where()` clauses
  - `Select()` for projection
  - Anonymous types and DTOs

- **Grouping and Aggregation**
  - `GroupBy()`
  - `Count()`, `Sum()`, `Max()`, `Min()`, `Average()`
  - `Distinct()`

### Common Patterns in This Codebase
```csharp
// Example from HomeOwnerQueries.cs
var query = await
(
    from h in _context.Homeowners 
    let f = filteredHomeownerList.FirstOrDefault(fh => h.Hoid == fh.Hoid)
    where h.InActive == null && f != null
    select new IqHomeOwner
    {
        HomeOwnerId = h.Hoid,
        FirstName = h.FirstName, 
        LastName = h.LastName,
        // ...
    }).ToListAsync();
```

---

## LINQ (Language Integrated Query)

### Query Syntax
- `from`, `where`, `select`, `join`, `group`, `orderby`
- `let` keyword for intermediate variables
- Multiple `from` clauses (SelectMany)

### Method Syntax
- **Filtering**: `Where()`, `OfType()`
- **Projection**: `Select()`, `SelectMany()`
- **Ordering**: `OrderBy()`, `OrderByDescending()`, `ThenBy()`
- **Grouping**: `GroupBy()`
- **Joining**: `Join()`, `GroupJoin()`
- **Aggregation**: `Count()`, `Sum()`, `Average()`, `Min()`, `Max()`, `Aggregate()`
- **Element Operations**: `First()`, `FirstOrDefault()`, `Single()`, `Last()`, `Any()`, `All()`
- **Set Operations**: `Distinct()`, `Union()`, `Intersect()`, `Except()`, `Concat()`
- **Partitioning**: `Take()`, `Skip()`, `TakeWhile()`, `SkipWhile()`

### Important Concepts
- **Deferred Execution**: Queries don't execute until enumerated
- **Immediate Execution**: Methods like `ToList()`, `ToArray()`, `Count()` execute immediately
- **Query vs Method Syntax**: Both are valid, choose based on readability
- **Composability**: Chain multiple LINQ operations

---

## Asynchronous Programming

### Core Concepts
- **async/await Keywords**
  - `async` method modifier
  - `await` keyword
  - Task and Task<T> return types

- **Best Practices**
  - Always use `async`/`await` for I/O operations
  - Never use `.Result` or `.Wait()` on async methods
  - Use `ConfigureAwait(false)` in library code (optional in ASP.NET Core)
  - Async all the way - don't mix sync and async

- **Common Patterns**
  ```csharp
  public async Task<SomeResponse> GetData()
  {
      var result = await _context.SomeEntity
          .Where(x => x.IsActive)
          .ToListAsync();
      return result;
  }
  ```

- **Exception Handling**
  - Exceptions in async methods
  - AggregateException

---

## Dependency Injection

### Core Concepts
- **Dependency Injection (DI) Container**
  - Service registration
  - Service lifetime (Singleton, Scoped, Transient)
  - Constructor injection

- **Primary Constructor Pattern** (Used in this codebase)
  ```csharp
  public class PortalUserService(VantacaContext context) : IPortalUserService
  {
      // context is automatically available as a field
  }
  ```

- **Interface-Based Design**
  - Programming to interfaces
  - Service interfaces (e.g., `IPortalUserService`)
  - Mocking for testing

- **Service Registration**
  - `AddScoped()`, `AddSingleton()`, `AddTransient()`
  - Understanding when to use each lifetime

---

## REST API Development

### ASP.NET Core Web API
- **Controllers**
  - ControllerBase class
  - Route attributes (`[Route]`, `[HttpGet]`, `[HttpPost]`, etc.)
  - Action methods and return types

- **HTTP Methods**
  - GET, POST, PUT, PATCH, DELETE
  - When to use each method
  - Idempotency and safety

- **Request/Response Models**
  - DTOs (Data Transfer Objects)
  - Using records for DTOs
  - Model binding (`[FromBody]`, `[FromQuery]`, `[FromRoute]`)

- **Status Codes**
  - 200 OK, 201 Created, 204 No Content
  - 400 Bad Request, 401 Unauthorized, 404 Not Found
  - 500 Internal Server Error

- **Authorization**
  - `[Authorize]` attribute
  - JWT tokens
  - Role-based and policy-based authorization

- **Swagger/OpenAPI**
  - API documentation
  - `[SwaggerOperation]` and `[SwaggerResponse]` attributes

### Example from Codebase
```csharp
[Route("api/[controller]")]
[ApiController]
[Authorize]
public class PortalUserController(
    IPortalUserService portalUserService
) : ControllerBase
{
    [HttpGet]
    [SwaggerOperation(Summary = "Gets portal user statistics")]
    public async Task<IActionResult> GetStatistics([FromQuery] PortalUserMetricsRequest request)
    {
        var result = await portalUserService.GetPortalUserOverviewStatistics(options);
        return Ok(result);
    }
}
```

---

## Testing

### Testing Framework
- **NUnit** (used in this codebase)
  - Test attributes: `[Test]`, `[TestCase]`, `[SetUp]`, `[TearDown]`
  - Assertions: `Assert.AreEqual()`, `Assert.IsTrue()`, `Assert.IsNotNull()`, etc.

- **Mocking**
  - Moq framework
  - Setting up mocks
  - Verifying method calls

- **Test Structure**
  - Arrange-Act-Assert pattern
  - Test naming conventions
  - Unit vs Integration tests

- **Test Data**
  - Creating test data
  - Using test databases or in-memory databases

---

## Azure Functions

### Function Types
- **HTTP Triggers**
  - Creating HTTP endpoints
  - Request/response handling

- **Timer Triggers**
  - Scheduled functions
  - Cron expressions

- **Queue Triggers**
  - Azure Storage Queues
  - Message processing

- **Blob Triggers**
  - File processing
  - Blob storage integration

### Basic Structure
```csharp
[FunctionName("FunctionName")]
public async Task Run([HttpTrigger(AuthorizationLevel.Function, "post")] HttpRequest req)
{
    // Function logic
}
```

---

## Architecture Patterns

### Clean Architecture
- **Separation of Concerns**
  - Services layer (business logic)
  - Contracts layer (interfaces and DTOs)
  - API layer (controllers)
  - Data layer (EF Core models)

### Domain-Driven Design (DDD)
- **Domain Organization**
  - Code organized by business domain
  - Domain-specific contracts and services

### Repository Pattern
- **Data Access**
  - DbContext as repository
  - Query objects
  - Service layer abstraction

### Dependency Injection Patterns
- **Service Registration**
  - Interface-based services
  - Constructor injection
  - Primary constructors

---

## Recommended Learning Resources

### Official Microsoft Documentation
1. **C# Fundamentals**
   - [C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
   - [C# Programming Guide](https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/)
   - [C# Language Reference](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/)

2. **.NET 8**
   - [.NET 8 Documentation](https://learn.microsoft.com/en-us/dotnet/core/whats-new/dotnet-8)
   - [What's New in C# 12](https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12)

3. **Entity Framework Core**
   - [EF Core Documentation](https://learn.microsoft.com/en-us/ef/core/)
   - [EF Core Getting Started](https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app)
   - [LINQ to Entities](https://learn.microsoft.com/en-us/ef/core/querying/)

4. **ASP.NET Core**
   - [ASP.NET Core Documentation](https://learn.microsoft.com/en-us/aspnet/core/)
   - [Web API Tutorial](https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api)

5. **Azure Functions**
   - [Azure Functions Documentation](https://learn.microsoft.com/en-us/azure/azure-functions/)

### Online Courses
- **Microsoft Learn**
  - [C# Learning Path](https://learn.microsoft.com/en-us/training/paths/csharp-first-steps/)
  - [.NET Learning Path](https://learn.microsoft.com/en-us/training/paths/build-dotnet-applications-csharp/)

- **Pluralsight** (if available)
  - C# Fundamentals
  - Entity Framework Core
  - ASP.NET Core Web API

### Practice Projects
1. **Simple CRUD API**
   - Create a Web API with Entity Framework Core
   - Implement GET, POST, PUT, DELETE endpoints
   - Use async/await throughout

2. **LINQ Practice**
   - Write complex queries using both query and method syntax
   - Practice joins, grouping, and aggregation

3. **Dependency Injection**
   - Create a service with interface
   - Register and inject the service
   - Write unit tests with mocking

### Codebase-Specific Learning
1. **Read Existing Code**
   - Start with simple services in `Services/` directory
   - Review API controllers in `Api/` directory
   - Study query classes like `HomeOwnerQueries.cs`

2. **Follow the Patterns**
   - Use primary constructors for services
   - Use records for DTOs
   - Follow the naming conventions
   - Use file-scoped namespaces

3. **Review Style Guides**
   - `STYLE_GUIDE.md` in the repository
   - `Chronicles/dotnet-style-guide.md`
   - Microsoft's C# Coding Conventions

---

## Learning Path Recommendation

### Week 1: C# Fundamentals
- Basic syntax, OOP concepts
- Collections and LINQ basics
- Exception handling

### Week 2: .NET 8 & Modern C# Features
- Primary constructors
- Records and init-only properties
- Nullable reference types
- Pattern matching

### Week 3: Entity Framework Core
- DbContext and DbSet
- LINQ queries (query and method syntax)
- Async database operations
- Joins and grouping

### Week 4: ASP.NET Core Web API
- Controllers and routing
- HTTP methods and status codes
- Request/response models
- Dependency injection

### Week 5: Advanced Topics
- Complex LINQ queries
- Testing with NUnit and Moq
- Azure Functions basics
- Architecture patterns

### Week 6: Codebase Familiarization
- Explore the repository structure
- Read existing code
- Understand domain models
- Practice with small tasks

---

## Key Takeaways

1. **Always use async/await** for database operations and I/O
2. **Use primary constructors** for dependency injection in services
3. **Use records** for DTOs and data transfer objects
4. **Prefer LINQ query syntax** for complex queries (as seen in codebase)
5. **Follow the repository structure** - Services for logic, Contracts for interfaces
6. **Write tests** for new functionality
7. **Read existing code** to understand patterns and conventions

---

## Questions to Self-Assess

Before starting work on the codebase, you should be able to:

- [ ] Write a class with primary constructor and dependency injection
- [ ] Create a LINQ query using both query and method syntax
- [ ] Write an async method that queries a database
- [ ] Create a REST API controller with GET and POST endpoints
- [ ] Write a unit test using NUnit and Moq
- [ ] Understand the difference between IQueryable and IEnumerable
- [ ] Explain when to use records vs classes
- [ ] Write a complex LINQ query with joins and grouping
- [ ] Understand service lifetimes in dependency injection
- [ ] Read and understand existing code in the repository

---

## Getting Help

- Review existing code in the repository for examples
- Check the `Chronicles/` directory for architectural decisions
- Review `STYLE_GUIDE.md` for coding conventions
- Ask questions during code reviews
- Pair program with experienced developers

Good luck with your learning journey! 🚀

