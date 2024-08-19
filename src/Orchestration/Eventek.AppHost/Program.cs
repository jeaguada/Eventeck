
var builder = DistributedApplication.CreateBuilder(args);

var apiGateway = builder.AddProject<Projects.Eventek_ApiGateway>("apigateway");

builder.AddProject<Projects.Eventek_ArtistManagement_Api>("artistmanagement").WithReference(apiGateway);

builder.AddProject<Projects.Eventek_EventManagement_Api>("eventmanagement").WithReference(apiGateway);

builder.AddProject<Projects.Eventek_LocationMapping_Api>("locationmapping").WithReference(apiGateway);

builder.AddProject<Projects.Eventek_TicketManagement_Api>("ticketmanagement").WithReference(apiGateway);

builder.AddProject<Projects.Eventek_UserManagement_Api>("usermanagement").WithReference(apiGateway);

builder.AddProject<Projects.Eventek_WebApp>("webapp");

builder.Build().Run();
