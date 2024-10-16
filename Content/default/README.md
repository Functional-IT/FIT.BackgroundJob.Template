# F# Background Job Template

An opinionated F# Windows Background job Template

## Configuration

* **global.json** pinned to .NET 8
* **VS Code** settings to hide inlay hints by default
* **.gitignore** with common F# settings

## Pre-installed dotnet tools

* **Fantomas v6** pre-configured with `.editorconfig`
* **Paket v8** with the following dependencies:
  * FSharp.Core
  * FSToolkit.ErrorHandling

* log to console and event log via Serilog are pre-configured

To run the application

```bash
dotnet tool restore

# if queue does not exists in event log the nrun this command as administrator, otherwise it will fail
# if queue does exists, normal permissions are sufficient
dotnet run
# or use visual studio, visual studio code or Rider
```

## Adding a package

```bash
dotnet paket add <package name>
```

### Removing a package

```bash
dotnet paket remove <package name>
```

### Safely updating all dependencies

```bash
dotnet paket update --keep-major
```

## Installing Service

```bash
sc.exe create "FIT Background Job" binpath= "dotnet C:\Path\To\Fit.BackgroundJob.dll"
sc.exe start "FIT Background Job"
```
