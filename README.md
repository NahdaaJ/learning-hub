# 🧠 Learning Hub 🧠
A repo to contain all my learning materials and notes. Even after I complete my learning plan, I would like to continue storing my notes and practice code in here.


## **1. Advanced C# 🌸**

**Goal**: Write clean, idiomatic, modular C# code that uses core .NET capabilities

### Concepts:

- [ ] **OOP Best Practices**: abstract classes, interfaces, inheritance, polymorphism
- [ ] **Generics**: type safety with generic methods, classes, and collections
- [ ] **Delegates**: function pointers in C#, multicast delegates
- [ ] **Events**: publisher-subscriber pattern (esp. for UI or async programming)
- [ ] **Lambda Expressions**: anonymous functions (`x => x + 1`)
- [ ] **LINQ**:
  - [ ] Basic: `Where()`, `Select()`, `FirstOrDefault()`, `Any()`, `All()`
  - [ ] Intermediate: `GroupBy()`, `Join()`, `OrderBy()`, `Aggregate()`
  - [ ] Advanced: combining with `IQueryable`, deferred execution
- [ ] **Nullable types**, null-coalescing operators, pattern matching (`is`, `switch`)
- [ ] **Async/Await**: Understand the `Task` model, `ConfigureAwait(false)`, exception handling

### Practice Project:

- [ ] A file parser/processor (e.g. CSV analyzer with LINQ)
- [ ] Use events to notify progress, lambdas to filter data

---

## **2. Software Engineering Fundamentals 🌸**

**Goal**: Build foundational CS knowledge like someone with a degree

### Part A: Data Structures & Algorithms

- [ ] Arrays, Linked Lists, HashTables/Dictionaries
- [ ] Stacks, Queues, PriorityQueues
- [ ] Trees, Binary Search Trees
- [ ] Sorting (Quick, Merge, Bubble), Searching
- [ ] Big-O analysis: Time vs Space complexity

**Tools**:

- [ ] Visualizing tools: VisuAlgo, Leetcode Explore

**Depth**:

- [ ] Understand how and when to use these
- [ ] Solve ~40 easy, ~10 medium Leetcode problems

### Part B: Design Patterns + Principles

- [ ] **SOLID Principles**:
  - [ ] Single Responsibility
  - [ ] Open-Closed
  - [ ] Liskov Substitution
  - [ ] Interface Segregation
  - [ ] Dependency Inversion
- [ ] **Design Patterns** (Pick ~8 to learn well):
  - [ ] Creational: Factory, Singleton
  - [ ] Structural: Adapter, Decorator
  - [ ] Behavioral: Strategy, Observer, Command
  - [ ] MVC, MVVM for UI/web

**Depth**:

- [ ] Know trade-offs and use-cases
- [ ] Apply 3–4 patterns in a real backend project

---

## **3. API Creation & Consumption 🌸**

**Goal**: Build robust, RESTful APIs and know how to consume them in a frontend

### Topics:

- [ ] REST principles: statelessness, resource modeling
- [ ] ASP.NET Web API (minimal API or MVC-based)
  - [ ] Controllers, Services, Repositories
  - [ ] Routing & HTTP verbs (GET, POST, PUT, DELETE)
  - [ ] Dependency Injection in ASP.NET
  - [ ] AutoMapper for DTOs
  - [ ] Model validation using `DataAnnotations`
  - [ ] Exception handling middleware
- [ ] Versioning, pagination, filtering
- [ ] Swagger/OpenAPI for documentation
- [ ] Unit testing APIs (xUnit/NUnit + Moq)

### Depth:

- [ ] Build at least 2 small APIs fully yourself
- [ ] Be comfortable debugging, extending, and documenting them

---

## **4. Frontend Integration + Fullstack Deployment 🌸**

**Goal**: Link backend APIs with a frontend (Angular/React), then deploy it

### Frontend:

- [ ] Angular (if sticking with it) or consider React
- [ ] Consume API using fetch or Axios
- [ ] Form handling, state updates, error handling

### Deployment:

- [ ] Vercel/Netlify for frontend
- [ ] Azure App Services, Render.com or Railway for backend
- [ ] CORS handling between frontend & backend
- [ ] .env secrets & basic security best practices

### Depth:

- [ ] Learn enough to push production-ready apps live
- [ ] Don’t deep-dive into frameworks unless needed

---

## **5. Docker 🌸**

**Goal**: Be able to containerize apps for dev and basic deploy scenarios

### Topics:

- [ ] Dockerfile (base image, copying, build steps)
- [ ] `docker build`, `docker run`, `docker ps`, `docker logs`
- [ ] Exposing ports, volume mounts, environment variables
- [ ] Docker Compose for multi-service apps (e.g. frontend + backend + db)

### Depth:

- [ ] Understand image layering
- [ ] Build + run containers locally
- [ ] Don’t need to know Kubernetes

---

## **6. CI/CD Pipelines 🌸**

**Goal**: Understand automation basics and contribute to pipeline configs

### Topics:

- [ ] GitHub Actions basics:
  - [ ] Triggers: `push`, `pull_request`, `workflow_dispatch`
  - [ ] Steps: checkout, build, test, deploy
  - [ ] Secrets and environment variables
- [ ] Azure DevOps/YAML pipelines (read & edit only)

### Depth:

- [ ] Know how to modify pipeline steps
- [ ] Automate testing & deployment of your apps

---

## **7. Terraform + DevOps 🌸**

**Goal**: Understand “Infrastructure as Code” and cloud environments conceptually

### Topics:

- [ ] What Terraform is, when it’s used
- [ ] Providers, resources, outputs, variables
- [ ] State files, backends (S3)
- [ ] Common resources:
  - [ ] Azure Resource Group, App Service
  - [ ] AWS EC2, VPC, S3 (if learning AWS)
- [ ] CI/CD connection to provision infra + deploy

### Depth:

- [ ] Know enough to read & write simple Terraform scripts
- [ ] Understand what your DevOps team is doing

---

## **8. Authentication & Multi-device Support 🌸**

**Goal**: Add user login and user data persistence

### Topics:

- [ ] ASP.NET Identity or roll your own JWT-based auth
- [ ] JWT structure: header, payload, signature
- [ ] Token expiration & refresh
- [ ] Middleware for auth validation
- [ ] Storing user data in DB, access control

### Depth:

- [ ] Build at least one app with login
- [ ] Understand how user claims/roles work

---

## **9. System Design & Intermediate DSA 🌸**

**Goal**: Be able to reason about scalable systems

### System Design:

- [ ] Vertical vs horizontal scaling
- [ ] Load balancers, database sharding, caching (Redis)
- [ ] Microservices vs monolith
- [ ] Basic cloud architecture (e.g. Frontend > API > DB)

### DSA:

- [ ] Binary search, sliding window, recursion, backtracking
- [ ] ~15–20 Medium Leetcode problems

---

## **10. Final Projects + AI Integration 🌸**

**Goal**: Build fullstack, production-level apps + integrate AI

### Project: Habit Tracker or Note App

- [ ] User login + habit entries
- [ ] Progress over time, calendar view
- [ ] LLM-powered: generate motivational messages, suggest habits

### AI Integration:

- [ ] OpenAI API (ChatGPT, GPT-4)
- [ ] Use prompts to:
  - [ ] Summarize user input
  - [ ] Suggest names, goals
  - [ ] Provide chatbot-like feedback
