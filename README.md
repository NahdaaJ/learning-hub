# Learning Hub 🐼
A repo to contain all my learning materials and notes. Even after I complete my learning plan, I would like to continue storing my notes and practice code in here.

<pre> Currently Learning: Layered Architecture 🩶 </pre>

## 🖤 PHASE 1 — CORE SOFTWARE ENGINEERING THINKING ✅

> Goal: Understand *why* code is structured the way it is

### ☑️ Object-Oriented Design (Conceptual, not syntax)

- [x]  What problems OOP is meant to solve
- [x]  Encapsulation (real meaning, not “private fields”)
- [x]  Abstraction vs implementation
- [x]  Inheritance as a **last resort**
- [x]  Composition as a default
- [x]  When OOP breaks down / isn’t ideal
- [x]  Polymorphism

---

### ☑️ SOLID (as decision-making tools)

- [x]  Single Responsibility → how responsibilities actually creep
- [x]  Open/Closed → extending without modifying
- [x]  Liskov → recognising broken inheritance
- [x]  Interface Segregation → fat vs thin interfaces
- [x]  Dependency Inversion → policy vs detail

👉 Focus: *spotting violations in real code*

---

### ☑️ Coupling, Cohesion & Change

- [x]  What tightly coupled code feels like to work with
- [x]  What “high cohesion” looks like in practice
- [x]  Localising change
- [x]  Designing for change vs over-engineering

---

## 🖤 PHASE 2 — ARCHITECTURE FUNDAMENTALS (VERY IMPORTANT)

> Goal: Be able to explain and reason about system structure
> 

### ◼️ Layered Architecture

- [ ]  Presentation vs Application vs Domain vs Infrastructure
- [ ]  What logic belongs where
- [ ]  Common layering mistakes
- [ ]  “Anemic domain” vs rich domain (conceptually)

---

### ◼️ Clean Architecture (high-level only)

- [ ]  Dependency direction
- [ ]  Business rules vs frameworks
- [ ]  What “independent of UI/database” actually means
- [ ]  Why this matters long-term

---

### ◼️ Boundaries & Contracts

- [ ]  What is a boundary?
- [ ]  DTOs vs domain models (conceptual)
- [ ]  Why mapping exists
- [ ]  What *not* to leak across boundaries

---

## 🖤 PHASE 3 — WEB & DISTRIBUTED SYSTEM CONCEPTS

> Goal: Understand how systems talk to each other
> 

### ◼️ HTTP & APIs (Conceptual)

- [ ]  What REST is *trying* to achieve
- [ ]  Idempotency
- [ ]  Statelessness
- [ ]  Why status codes matter
- [ ]  Versioning APIs
- [ ]  Backwards compatibility

---

### ◼️ Data Flow & Failure

- [ ]  Request lifecycle (client → server → DB → back)
- [ ]  Where failures happen
- [ ]  Partial failure
- [ ]  Retries (when *not* to retry)
- [ ]  Timeouts

---

### ◼️ Authentication & Authorisation (Conceptual)

- [ ]  Identity vs access
- [ ]  Tokens vs sessions
- [ ]  Why JWTs exist
- [ ]  Trust boundaries
- [ ]  Common auth mistakes

---

## 🖤 PHASE 4 — DATA & STATE (MENTAL MODELS)

> Goal: Stop treating databases as magic storage boxes
> 

### ◼️ Data Modelling

- [ ]  What a “good” table design feels like
- [ ]  Normalisation vs denormalisation
- [ ]  Referential integrity
- [ ]  Modelling relationships (1-1, 1-many, many-many)

---

### ◼️ Consistency & Transactions

- [ ]  What a transaction guarantees
- [ ]  When transactions hurt performance
- [ ]  Race conditions
- [ ]  Concurrency issues (high level)

---

### ◼️ ORMs (Conceptual)

- [ ]  What ORMs abstract away
- [ ]  What they *don’t*
- [ ]  N+1 problem (why it happens)
- [ ]  When to drop to raw SQL

---

## 🖤 PHASE 5 — QUALITY, RISK & CHANGE

> Goal: Be trusted to modify existing systems
> 

### ◼️ Testing Philosophy

- [ ]  What tests are actually for
- [ ]  Unit vs integration vs end-to-end (trade-offs)
- [ ]  Testing behaviour vs implementation
- [ ]  What *not* to test

---

### ◼️ Debugging & Observability

- [ ]  Logs vs metrics vs traces (conceptual)
- [ ]  How engineers debug production issues
- [ ]  Why reproducibility matters
- [ ]  Reading logs like a story

---

## 🖤 PHASE 6 — DELIVERY & REALITY

> Goal: Understand how code becomes software
> 

### ◼️ Environments & Deployment

- [ ]  Local vs staging vs production
- [ ]  Configuration vs code
- [ ]  Why “works on my machine” happens
- [ ]  Rollbacks (conceptual)

---

### ◼️ DevOps (Conceptual)

- [ ]  What CI/CD is solving
- [ ]  Why automation matters
- [ ]  Build → test → deploy pipeline mentally
- [ ]  Risks in deployment

---

## 🖤 PHASE 7 — AI IN CONTEXT (THE RIGHT WAY)

> Goal: Use AI *without losing engineering skill*
> 

### ◼️ AI as an Engineering Tool

- [ ]  Where AI helps (boilerplate, exploration)
- [ ]  Where AI is dangerous (design, security, edge cases)
- [ ]  Reviewing AI code critically
- [ ]  Maintaining system ownership