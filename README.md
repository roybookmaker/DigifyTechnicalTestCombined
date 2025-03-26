# Digify Technical Test Combined

This repository contains the combined solution for the Digify Technical Test, including both the Web API and Web Application components.

## Project Structure

- **DatabaseMigrationFiles** : Contains the .sql Query to create the database AND the registration table.
- **Digify Technical Test Documentation** : Contains screenshots from testing the projects.
- **DigifyTechnicalTestWebAPI**: The backend Web API project.
- **DigifyTechnicalTestWebAPP**: The frontend Web Application project.
- **PublishedProject**: Contains the published versions of both the Web API and Web Application.
- **DigifyTechnicalTestCombined.sln**: The Visual Studio solution file that combines both projects.

## Getting Started

To set up and run the projects locally, follow the steps below.

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) or any compatible IDE

### Setup

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/roybookmaker/DigifyTechnicalTestCombined.git
   ```
2. **Navigate to the Project Directory**:
   ```bash
   cd DigifyTechnicalTestCombined
   ```

### Running the Program

Both API and Web APP already contained into 1 Solution.

0. **Make sure the `RegistrationsQuery.sql` in DatabaseMigrationFiles is executed on SQL Server and the `localdb` database + `Registration` table is created**
1. **Navigate to the Solution Directory**
2. **Open the Solution `DigifyTechnicalTestCombined.sln` using Visual Studio**
3. **Make sure the Launch Profile set to `DigifyStartup`**
4. **Press Start**

Windows will launch the service, Swagger Page, and the Web App page.

### Worth Mentioning

Currently, testing through Swagger is not possible due to the requirement to set IDENTITY_INSERT to OFF. Changing this setting could introduce security risks and is considered bad practice.
