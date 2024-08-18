var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.Eventek_ApiGateway>("eventek-apigateway");

builder.AddProject<Projects.Eventek_ArtistManagement_Api>("eventek-artistmanagement-api");

builder.AddProject<Projects.Eventek_EventManagement_Api>("eventek-eventmanagement-api");

builder.AddProject<Projects.Eventek_LocationMapping_Api>("eventek-locationmapping-api");

builder.AddProject<Projects.Eventek_TicketManagement_Api>("eventek-ticketmanagement-api");

builder.AddProject<Projects.Eventek_UserManagement_Api>("eventek-usermanagement-api");

builder.AddProject<Projects.Eventek_WebApp>("eventek-webapp");

builder.Build().Run();
