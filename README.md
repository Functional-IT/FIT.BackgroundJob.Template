# FIT F# Background Job

An opinionated F# Windows Background job Template

### Configuration

* **global.json** pinned to .NET 8
* **VS Code** settings to hide inlay hints by default
* **.gitignore** with common F# settings
* **src/FIT.Background** folder structure

### Pre-installed dotnet tools

* **Fantomas v6** pre-configured with `.editorconfig`
* **Paket v8** with the following dependencies:
  * FSharp.Core
  * FSToolkit.ErrorHandling

## To execute the template

```bash
dotnet new fit-backgroundjob -o MyBackgroundjob
```

will give you a folder structure as follows:

```
.config
    dotnet-tools.json
.paket
    Paket.Restore.targets
.vscode
    settings.json
src
    FIT.BackgroundJob
        FIT.BackgroundJob.fsproj
        paket.references

        Readme.md
FIT.BackgroundJob.sln
.editorconfig
.gitignore
global.json
paket.dependencies
paket.lock
```

```bash
dotnet tool restore
cd src/FIT.BackgroundJob
dotnet run
# or use visual studio, visual studio code or Rider
```

### Adding a package

```bash
cd src/FIT.BackgroundJob
dotnet paket add <package name>
```

### Removing a package

```bash
cd src/FIT.BackgroundJob
dotnet paket remove <package name>
```

### Safely updating all dependencies

```bash
dotnet paket update --keep-major
```
