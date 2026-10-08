# ESBot - An AI-powered learning assistant

## Table of Contents
- [ESBot - An AI-powered learning assistant](#esbot---an-ai-powered-learning-assistant)
  - [Table of Contents](#table-of-contents)
  - [Description](#description)
  - [Documentation](#documentation)
  - [Setup](#setup)
  - [Structure](#structure)
  - [Issue and label conventions](#issue-and-label-conventions)


## Description

Students often study alone and get stuck: they want a short explanation, an example, or a tiny quiz, and they want to come back later without losing the thread. Generic chat tools dump unstructured text and forget context. ESBot is a course-scoped learning assistant that runs a guided session instead of an open-ended chat dump.

## Documentation

- [Application](docs/app.md)
- [Team](docs/team.md)
- [Technology Stack](docs/spec/tech-stack.md)

## Setup

### Prerequisites
Before you begin, ensure you have the following installed on your machine:
* [.NET 8.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) (Required for ASP.NET Core and Blazor)
* [Docker Desktop](https://www.docker.com/products/docker-desktop/) (Required for PostgreSQL and Testcontainers)
* An IDE such as [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### 1. Clone the repository
Clone the repository to your local machine and navigate into the project directory:
```bash
git clone https://github.com/ReonDev/ESBot.git
cd ESBot
```

### 2. Start the Database
We use PostgreSQL running in a Docker container for our data persistence. To start the database in the background, run:
```bash
docker-compose up -d
```

### 3. Setup Configuration
- Open appsettings.Development.json in the backend project.
- Ensure the database connection string points to your local PostgreSQL Docker instance.
- Configure the API keys for the AI model if you are not using a local model.

### 4. Build and Run the Application
Navigate to the main startup project directory (where the Blazor/ASP.NET Core .csproj is located) and start the application:
```bash
dotnet run
```

### 5. Running Tests
To run our comprehensive test suite (xUnit, Testcontainers, Playwright), navigate to the solution root and execute:
```bash
dotnet test
```

## Structure

```text
ESBot/
├── docs/
│   ├── spec/
│   │   └── tech-stack.md    # Specifications & tech stack overview
│   ├── app.md               # Application details & features
│   └── team.md              # Team workflow and processes
├── .gitignore               # Ignored build files and secrets
├── LICENSE                  # MIT License
└── README.md                # Project documentation
```


## Issue and label conventions

We will use diffrent labels based on the Task that needs to be done and assign them to Team members
- bug: Discovered Bug in the Project with reproduce step
- feature: new Feature that need to be added
- docs: Documentation Task
- exercise-N: To Document to which Exercise/ Milestone the Task belongs. 
