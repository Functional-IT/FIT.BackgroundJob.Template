# F# Background Job Template

An opinionated F# Windows Background job Template

### Configuration

* **global.json** pinned to .NET 8
* **VS Code** settings to hide inlay hints by default
* **.gitignore** with common F# settings

### Pre-installed dotnet tools

* **Fantomas v6** pre-configured with `.editorconfig`
* **Paket v8** with the following dependencies:
  * FSharp.Core
  * FSToolkit.ErrorHandling

## To create a new project from the template

```bash
dotnet new FIT.Backgroundjob -o MyBackgroundjob
```

will give you a folder structure as follows:

```
.config
    dotnet-tools.json
.paket
    Paket.Restore.targets
.vscode
    settings.json
FIT.BackgroundJob.fsproj
Model.fs
BackgroundJob.fs
Program.fs
Readme.md
FIT.BackgroundJob.sln
.editorconfig
.gitignore
.gitattributes
.fantomasignore
appsettings.json
global.json
paket.dependencies
paket.references
paket.lock

```

```bash
dotnet tool restore
dotnet run
# or use visual studio, visual studio code or Rider
```

### Adding a package

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
