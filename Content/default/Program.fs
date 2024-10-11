module InventoryService.Program

open BackgroundJob.Services
open Microsoft.Extensions.Configuration
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting
open Serilog
open Microsoft.Extensions.Logging
open BackgroundJob
open Models

let (!) f = f |> ignore

[<EntryPoint>]
let main argv =

    let configureServices (hCtx: HostBuilderContext) (services: IServiceCollection) =
        let appS = hCtx.Configuration.GetSection("AppSettings").Get<Appsettings>()
        ! services.AddSingleton(appS)

        let log =
            LoggerConfiguration().ReadFrom.Configuration(hCtx.Configuration).CreateLogger()


        !services.AddLogging(fun cfg -> !cfg.ClearProviders().AddSerilog(log))

        ! services.AddSingleton<Serilog.ILogger>(log)
        ! services.AddHostedService<BackgroundJob>()

    let configureAppConfig (hCtx: HostBuilderContext) (cfgBuilder: IConfigurationBuilder) =
        ! cfgBuilder.AddJsonFile("appsettings.json", optional = false)

        // if hCtx.HostingEnvironment.IsDevelopment() then
        //     ! cfgBuilder.AddUserSecrets("BackgroundJob")

        ! cfgBuilder.Build()

    async {

        Host
            .CreateDefaultBuilder(argv)
            .UseWindowsService()
            .ConfigureAppConfiguration(configureAppConfig)
            .ConfigureServices(configureServices)
        |> fun host -> host.Build().Run()
    }
    |> Async.RunSynchronously

    0
