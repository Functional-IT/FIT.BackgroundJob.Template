module BackgroundJob.Services

open System.Threading.Tasks
open Microsoft.Extensions.Hosting
open BackgroundJob
open Models

type BackgroundJob(_logger: Serilog.ILogger, settings: Appsettings) =

    inherit BackgroundService()

    override this.ExecuteAsync stoppingToken = task {
        // let logMessage = logMessage _logger

        _logger.Information("starting BackgroundJob")

        while not stoppingToken.IsCancellationRequested do
            try
                //TODO: Implement the logic here
                let date = System.DateTime.Now
                _logger.Information $"Working away. {date}"

            with e ->
                // wait additional time since we know something is going wrong
                do! Task.Delay(5 * 1000 * 5)

            do! Task.Delay(settings.DelayInSec * 1000)

        _logger.Information "BackgroundJob ended."
    }


    override this.StopAsync stoppingToken = task { _logger.Information "BackgroundJob was stopped." }
