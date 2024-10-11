# Contribution guideline

## Working with the template

There's a `Template.sln` solution file in the root of this repository that references build and the backgroundjob fsproj

To test your changes simply navigate to `Content\default` and invoke the corresponding CLI commands from these directories (see `Content\default\README.md`).

## Testing template bundle

To build whole template invoke `dotnet run --project Build.fsproj` - default target is `Install`, which will build the template and invoke `dotnet new -i <<repo-path>>/nupkg/FIT.BackgroundJob.Template.<<version>>.nupkg`

You can now test the local build of template using `dotnet new FIT.Backgroundjob`

## Known issues

* In case `dotnet new -i` fails for some reason, try uninstalling previously installed version first: `dotnet new -u FIT.Backgroundjob.Template`

## Release

1. Run `dotnet run --project Build.fsproj -- release`
