using HIRD.Service;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddHostedService<GrpcServer>();
    })
    .Build();

await host.RunAsync();
