# How to Start a Project

## Step 0 - Define product in 10 lines.
 - What is the app?
 - Who is it for?
 - What ar teh top 3 user actions?
 - What data is stored?

## Step 1 - List your core features (use cases)
These become your **application features**. You’re basically building a checklist of “things the system does”.

Example use cases:
 - Create transaction
 - Edit transaction
 - Delete transaction
 - List transactions
 - Get monthly summary
 - Create category

## Step 2 - Identify the main data objects (domain nouns)
These become your **domain entities**.

Examples:
 - Transaction
 - Category
 - Budget

## Step 3 - Write the business rules
Even if they are simple.

Example:
 - Transaction amount cannot be 0.
 - Category name cannot be empty.
 - Date cannot be in the future.

## Step 4 - Sketch the database tables (simple)
Just a rough table title and the expected columns.

For example: 
- Transactions - Id, Amount, Date, CategoryId, Note
- Categories - Id, Name

## Step 5 - Design API endpoints
Map your use cases to endpoints.

- POST /transactions
- GET /transactions?month=2026-02

## Step 6 - Build vertically
Pick ONE use case, and build it through every layer.