# ESBot - An AI-powered learning assistant

## Table of Contents
- [ESBot - An AI-powered learning assistant](#esbot---an-ai-powered-learning-assistant)
  - [Table of Contents](#table-of-contents)
  - [Description](#description)
  - [Documentation](#documentation)
  - [Setup](#setup)
  - [Structure](#structure)
  - [Issue and label conventions](#issue-and-label-conventions)
  - [Change note](#change-note)


## Description

Students often study alone and get stuck: they want a short explanation, an example, or a tiny quiz, and they want to come back later without losing the thread. Generic chat tools dump unstructured text and forget context. ESBot is a course-scoped learning assistant that runs a guided session instead of an open-ended chat dump.

## Documentation

- [Application](docs/app.md)
- [Team](docs/team.md)
- [Technology Stack](docs/spec/tech-stack.md)

## Setup

TODO



## Structure

```text
ESBot/
├── ESBot/                         # ASP.NET Core and Blazor application
│   ├── Components/               # Blazor frontend components, pages, and layouts
│   ├── Controllers/              # HTTP API controllers, when API endpoints are needed
│   ├── Data/                     # Entity Framework Core context and repositories
│   ├── Migrations/               # Entity Framework Core database migrations
│   ├── Models/                   # Domain models and data entities
│   ├── Services/                 # Business logic and integrations
│   ├── wwwroot/                  # Static frontend assets
│   ├── Program.cs                # Application startup and dependency injection
│   ├── appsettings.json          # Application configuration
│   └── ESBot.csproj              # Application project file
├── tests/
│   ├── ESBot.UnitTests/          # Unit tests
│   ├── ESBot.IntegrationTests/   # Integration tests
│   └── ESBot.E2ETests/           # Playwright end-to-end UI tests
├── docs/
│   ├── spec/
│   │   └── tech-stack.md         # Specifications and technology stack
│   ├── app.md                    # Application details and features
│   └── team.md                   # Team workflow and processes
├── docker-compose.yml            # PostgreSQL and pgAdmin containers
├── ESBot.sln                     # .NET solution containing all projects
├── .gitignore                    # Ignored build files and secrets
├── LICENSE                       # MIT License
└── README.md                     # Project documentation
```

The `ESBot` project contains both the Blazor frontend and the ASP.NET Core backend
because the application uses Blazor Interactive Server. The responsibilities are
separated by folder: UI code belongs in `Components`, while backend code belongs
in `Controllers`, `Data`, `Models`, and `Services`. The test projects remain
separate under `tests`.


## Issue and label conventions

We will use diffrent labels based on the Task that needs to be done and assign them to Team members
- bug: Discovered Bug in the Project with reproduce step
- feature: new Feature that need to be added
- docs: Documentation Task
- exercise-N: To Document to which Exercise/ Milestone the Task belongs. 

## Change note

- **Changed by:** GitHub Copilot
- **Timestamp:** 2026-10-10 01:02:07 +02:00
- **Change:** Added a detailed description of the backend, frontend and test folder structure.
