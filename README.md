# Task Manager - Backend API

This repository contains the backend API for the enterprise Task Manager application. It is built with .NET 8, ASP.NET Core Web API, Entity Framework Core, and utilizes PostgreSQL for data storage.

## Tech Stack

- **Framework:** .NET 8
- **ORM:** Entity Framework Core
- **Database:** PostgreSQL (Containerized via Docker)

## Prerequisites

Before you begin, ensure you have the following installed:

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Docker Desktop](https://www.docker.com/products/docker-desktop) (for running the database)

## Getting Started

Follow these steps to set up and run the project locally.

### 1. Clone the Repository

```bash
git clone https://github.com/YOUR_USERNAME/TaskManager-Backend.git
cd TaskManager-Backend
```

### 2. Configure Environment Variables

For security purposes, database credentials are managed via environment variables.

- Locate the `.env.example` file in the root directory.
- Create a copy of it and rename it to `.env`.
- Open the `.env` file and set your desired database password:

```env
POSTGRES_PASSWORD=your_secure_password_here
```

### 3. Start the Database (Docker)

Spin up the PostgreSQL database container using Docker Compose:

```bash
docker-compose up -d
```

> **Note:** This starts a PostgreSQL instance on port `5433` with the database name `TaskManagerDb`, user `admin`, and the password you defined in your `.env` file.

### 4. Apply Database Migrations

Update the database schema using Entity Framework Core tools:

```bash
dotnet ef database update
```

### 5. Run the Application

Start the API server:

```bash
dotnet run
```

The API will be available locally at `https://localhost:7152` (or the port specified in your `launchSettings.json`).

## 🎨 Frontend Integration

The user interface for this application is maintained in a separate repository. To run the full stack, please clone the frontend project as well:

[TaskManager-Frontend Repository](https://github.com/Erenvdmn/TaskManager-Frontend)
