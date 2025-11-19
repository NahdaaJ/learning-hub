# Learning Hub 🌸
A repo to contain all my learning materials and notes. Even after I complete my learning plan, I would like to continue storing my notes and practice code in here.

## ✅ **PHASE 1 — FOUNDATIONS**

### **Months 1–3**

Goal: Advanced C#, fundamentals, build small full-stack app.

## **📌 Month 1 — Advanced C#, LINQ, Lambdas, Async**

### **WEEK 1 — Deepen C# language mastery**

- [ ]  Review OOP pillars briefly (inheritance, polymorphism, abstraction, encapsulation)
- [ ]  Understand *when* to use interfaces vs abstract classes
- [ ]  Learn C# **Delegates**
- [ ]  Learn **Events** (publisher/subscriber pattern)
- [ ]  Learn **Lambda expressions**
- [ ]  Write 3 small console examples to solidify each concept
- [ ]  Update GitHub with a folder called `csharp-fundamentals-practice`

### **WEEK 2 — LINQ**

- [ ]  Learn LINQ method syntax (Select, Where, First, Any, All, GroupBy)
- [ ]  Learn LINQ query syntax
- [ ]  Practise by:
    - [ ]  Creating a list of objects (e.g., Pokémon / Products)
    - [ ]  Filtering, searching, grouping
    - [ ]  Mapping from one type → another
- [ ]  Build 1 mini-exercise: “LINQ Mini Queries Playground”
- [ ]  Push to GitHub

### **WEEK 3 — Async & Await**

- [ ]  Understand what async/await actually does
- [ ]  Learn Tasks vs Threads (high-level)
- [ ]  Write 3 examples:
    - [ ]  Await network call
    - [ ]  Parallel tasks
    - [ ]  Cancelling a token
- [ ]  Add `AsyncPlayground` repo to GitHub

### **WEEK 4 — Consolidation + Mini Project**

- [ ]  Revisit weak points
- [ ]  Create a **Console App** using everything learned:
    - [ ]  Use LINQ
    - [ ]  Async calls
    - [ ]  Events
    - [ ]  Delegates
- [ ]  Push polished code → GitHub
- [ ]  Write a short README on what you learned

<br/>

## 📌 **Month 2 — Data Structures, Algorithms, Design Patterns, SQL Deepening**

### **WEEK 1 — Data Structures**

- [ ]  Arrays & Lists
- [ ]  Dictionaries / HashMaps
- [ ]  Stacks
- [ ]  Queues
- [ ]  Big O basics
- [ ]  Practice on LeetCode (Easy ONLY):
    - [ ]  Two Sum
    - [ ]  Valid Parentheses
    - [ ]  Merge Two Lists
    - [ ]  Maximum Subarray

### **WEEK 2 — Algorithms**

- [ ]  Sorting (bubble, insertion, mergesort, quicksort — know conceptually)
- [ ]  Searching (linear vs binary)
- [ ]  Learn recursion basics
- [ ]  LeetCode practice (Easy):
    - [ ]  Binary Search
    - [ ]  Best Time to Buy/Sell Stock
    - [ ]  Contains Duplicate
- [ ]  Add `algorithms-practice` folder to GitHub

### **WEEK 3 — Design Patterns**

- [ ]  Singleton
- [ ]  Factory
- [ ]  Strategy
- [ ]  Observer
- [ ]  Repository Pattern (very relevant to .NET)
- [ ]  Build 5 tiny C# examples demonstrating each
- [ ]  Push to GitHub with a README

### **WEEK 4 — SQL + API Theory**

- [ ]  Review SQL joins (INNER, LEFT, RIGHT)
- [ ]  Learn indexing basics (clustered vs non-clustered)
- [ ]  Learn transactions and ACID
- [ ]  Learn basics of API design (endpoints, verbs, status codes, routing)
- [ ]  Watch one video on REST architecture
- [ ]  Prep DB schema for Month 3 project

<br/>

## 📌 **Month 3 — Build Your First Full-Stack App**

Goal: Make a CRUD app, connect API ↔ SQL ↔ Front-End

### **WEEK 1 — ASP.NET Web API Setup**

- [ ]  Create new .NET Web API project
- [ ]  Make controllers folder
- [ ]  Make services folder
- [ ]  Make models folder
- [ ]  Add connection string to local SQL
- [ ]  Build 1 endpoint (GET)
- [ ]  Test using Postman

### **WEEK 2 — Full CRUD + Database**

- [ ]  Create SQL tables
- [ ]  Create Repository pattern
- [ ]  Implement CRUD:
    - [ ]  GET all
    - [ ]  GET by ID
    - [ ]  POST
    - [ ]  PUT
    - [ ]  DELETE
- [ ]  Add error handling and JSON responses

### **WEEK 3 — Front-End (Angular or React)**

- [ ]  Create new front-end project
- [ ]  Create components/pages
- [ ]  Add service to call your API
- [ ]  Display data on page
- [ ]  Add create/update/delete UI
- [ ]  Add loading UI

### **WEEK 4 — Testing + Polish**

- [ ]  Add unit tests for services (xUnit or NUnit)
- [ ]  Add a README with architecture summary
- [ ]  Host repo on GitHub
- [ ]  Add screenshots to README
- [ ]  Demo to yourself (and to me if you want)

<br/>

## ✅ **PHASE 2 — REAL-WORLD SKILLS**

### **Months 4–6**

Focus: Deployment, cloud, DevOps, pipelines, Docker, improved front-end, advanced API.

## 📌 **Month 4 — API Mastery + Front-End Improvements**

### **WEEK 1 — Advanced API Concepts**

- [ ]  Learn DTOs
- [ ]  Learn validation (FluentValidation)
- [ ]  Learn logging (Serilog)
- [ ]  Add logging to your API
- [ ]  Add global exception handling

### **WEEK 2 — Authentication Basics**

- [ ]  Learn JWT authentication
- [ ]  Add registration/login endpoint
- [ ]  Secure CRUD endpoints
- [ ]  Add “role” or “user id” linking

### **WEEK 3 — Improve Front-End**

- [ ]  Add router with multiple pages
- [ ]  Add forms with validation
- [ ]  Add state management (Redux / NgRx optional)
- [ ]  Add dark mode (fits your aesthetic)

### **WEEK 4 — API + Front-End Integration**

- [ ]  Connect login system
- [ ]  Store token in secure storage
- [ ]  Update UI based on login state
- [ ]  Make pretty UI (dark feminine vibes 💀✨)

<br/>

## 📌 **Month 5 — Docker + DevOps Basics + Cloud**

### **WEEK 1 — Docker**

- [ ]  Install Docker Desktop
- [ ]  Write Dockerfile for your API
- [ ]  Write Dockerfile for front-end
- [ ]  Create docker-compose.yml
- [ ]  Run both locally with one command
- [ ]  Push Docker images to Docker Hub (optional)

### **WEEK 2 — GitHub Actions / Pipelines**

- [ ]  Create `.github/workflows/ci.yml`
- [ ]  Add steps:
    - [ ]  Build
    - [ ]  Run tests
    - [ ]  Build Docker image
- [ ]  Auto-run on push to `main`

### **WEEK 3 — Cloud Basics (Azure recommended for .NET)**

- [ ]  Create Azure account
- [ ]  Learn:
    - [ ]  App Service
    - [ ]  Azure SQL
    - [ ]  Storage account
- [ ]  Deploy API to Azure App Service
- [ ]  Deploy front-end to Azure Static Web App or App Service

### **WEEK 4 — CI/CD + Deployment**

- [ ]  Add deployment steps to GitHub Actions
- [ ]  Test that pushing code automatically deploys
- [ ]  Write README with “Live Demo” link

<br/>

## 📌 **Month 6 — Full Deployment Project**

Goal: Your second major portfolio project (cross-device notes app)

### **WEEK 1 — Requirements + Architecture**

- [ ]  Write feature list
- [ ]  Draw architecture diagram
- [ ]  Plan database schema
- [ ]  Set up new GitHub repo

### **WEEK 2 — Back-End Build**

- [ ]  Build API skeleton
- [ ]  Implement authentication
- [ ]  Implement CRUD for notes
- [ ]  Add tags/search/filter
- [ ]  Integrate SQL
- [ ]  Add logging + validation

### **WEEK 3 — Front-End Build**

- [ ]  Build login/signup pages
- [ ]  Build notes dashboard
- [ ]  Build editor page
- [ ]  Add dark theme
- [ ]  Add responsive mode (mobile friendly)

### **WEEK 4 — Deploy + Polish**

- [ ]  Dockerize
- [ ]  CI/CD pipeline
- [ ]  Deploy to Azure
- [ ]  Write README
- [ ]  Add screenshots & demo video

<br/>

## ✅ **PHASE 3 — SPECIALISATION + AI**

### **Months 7–9**

## 📌 **Month 7 — System Design, Software Engineering Mastery**

### **WEEK 1**

- [ ]  Caching (Redis basics)
- [ ]  Load balancing concepts
- [ ]  Monolith vs microservices

### **WEEK 2**

- [ ]  Messaging queues (RabbitMQ / Azure Service Bus)
- [ ]  Event-driven architecture basics
- [ ]  CAP theorem (just high-level)

### **WEEK 3 — System Design Practice**

Study how to design:

- [ ]  URL shortener
- [ ]  Chat app
- [ ]  Rate limiter
- [ ]  E-commerce inventory system

### **WEEK 4 — DS/Algo Refresh**

LeetCode Easy/Medium:

- [ ]  2 Mediums this week
- [ ]  5 Easies
- [ ]  Focus on Trees + Graph basics

<br/>

## 📌 **Month 8 — AI/LLM Integration + Microservices**

### **WEEK 1 — LLM Basics**

- [ ]  Learn what embeddings are
- [ ]  Learn how to call OpenAI API from C#
- [ ]  Learn prompt engineering basics

### **WEEK 2 — Build AI Microservice**

- [ ]  Create C# API project solely for AI tasks
- [ ]  Add endpoint: `/summarise`
- [ ]  Add consumption from main API

### **WEEK 3 — Integrate AI Into Notes App**

- [ ]  Add “Summarise note” button
- [ ]  Add “Rewrite note professionally” option
- [ ]  Add “Tag suggestion” using AI

### **WEEK 4 — Deploy Microservice**

- [ ]  Dockerise AI service
- [ ]  Add to docker-compose
- [ ]  Deploy AI service to cloud
- [ ]  Add logs + error handling

<br/>

## 📌 **Month 9 — Final Major Project**

Goal: Scalable, cloud-ready, AI-enhanced app.

### Tasks:

- [ ]  Plan project features
- [ ]  Architecture diagram
- [ ]  Multi-service backend
- [ ]  Front-end polish
- [ ]  CI/CD for multiple services
- [ ]  Observability (logs, metrics, health checks)
- [ ]  Production deployment
- [ ]  Amazing README + screenshots
- [ ]  Add to portfolio site

<br/>

## ✅ **PHASE 4 — CONSOLIDATION**

### **Months 10–12**

## 📌 **Month 10 — Refactor, Polish, Documentation**

- [ ]  Refactor old projects
- [ ]  Improve folder structures
- [ ]  Add missing tests
- [ ]  Add proper error middleware everywhere
- [ ]  Document everything in READMEs
- [ ]  Create architecture diagrams for each
- [ ]  Add GitHub issues & roadmap (looks professional)
