<div align="center">
  <img src="[https://ibb.co/Bj92gtj](https://ibb.co/Bj92gtj)?text=Eventek" alt="Eventek Logo" width="320" height="150">
  <h1 style="color: #333; font-size: 3em; margin-bottom: 0;">Eventek</h1>
  <p style="font-style: italic; color: #666;">Event Management System powered by .NET Aspire</p>
</div>

<hr style="border: 0; height: 1px; background: #333; background-image: linear-gradient(to right, #ccc, #333, #ccc);">

<h2 style="color: #0366d6;">?? Features</h2>

<ul style="list-style-type: none; padding-left: 0;">
  <li>? Microservices Architecture</li>
  <li>? .NET Aspire Integration</li>
  <li>? Event Management</li>
  <li>? Artist Profiles</li>
  <li>? Ticket Sales</li>
  <li>? User Authentication</li>
  <li>? Location Mapping</li>
  <li>? Location Concurrency</li>
  <li>? Nearest Events </li>
</ul>

<h2 style="color: #0366d6;">?? Project Structure</h2>

<pre style="background-color: #f6f8fa; padding: 16px; border-radius: 6px; overflow: auto;">
src/
+-- Orchestration/
¦   +-- Eventek.AppHost
¦   +-- Eventek.ServiceDefaults
+-- BuildingBlocks/
+-- Services/
¦   +-- EventManagement/
¦   +-- ArtistManagement/
¦   +-- UserManagement/
¦   +-- TicketManagement/
¦   +-- LocationMapping/
+-- WebApp/
tests/
+-- UnitTests/
+-- IntegrationTests/
+-- FunctionalTests/
</pre>

<h2 style="color: #0366d6;">?? Getting Started</h2>

<ol>
  <li>Ensure you have .NET 8 SDK installed with the Aspire workload</li>
  <li>Clone the repository:
    <pre style="background-color: #f6f8fa; padding: 8px; border-radius: 4px;">git clone https://github.com/yourusername/eventek.git</pre>
  </li>
  <li>Navigate to the project directory:
    <pre style="background-color: #f6f8fa; padding: 8px; border-radius: 4px;">cd eventek</pre>
  </li>
  <li>Run the application:
    <pre style="background-color: #f6f8fa; padding: 8px; border-radius: 4px;">dotnet run --project src/Orchestration/Eventek.AppHost</pre>
  </li>
</ol>

<h2 style="color: #0366d6;">?? Development</h2>

<p>To develop individual services, run:</p>

<pre style="background-color: #f6f8fa; padding: 16px; border-radius: 6px;">dotnet run --project src/Services/EventManagement/Eventek.EventManagement.Api</pre>

<h2 style="color: #0366d6;">?? Deployment</h2>

<p>Build and publish Docker containers:</p>

<pre style="background-color: #f6f8fa; padding: 16px; border-radius: 6px;">dotnet publish src/Orchestration/Eventek.AppHost</pre>

<h2 style="color: #0366d6;">?? Running Tests</h2>

<p>Run all tests:</p>

<pre style="background-color: #f6f8fa; padding: 16px; border-radius: 6px;">dotnet test</pre>

<p>Run tests for a specific service:</p>

<pre style="background-color: #f6f8fa; padding: 16px; border-radius: 6px;">dotnet test tests/UnitTests/Eventek.EventManagement.UnitTests</pre>

<h2 style="color: #0366d6;">?? Contributing</h2>

<p>Please read <a href="CONTRIBUTING.md">CONTRIBUTING.md</a> for details on our code of conduct and the process for submitting pull requests.</p>

<h2 style="color: #0366d6;">?? License</h2>

<p>This project is licensed under the MIT License - see the <a href="LICENSE.md">LICENSE.md</a> file for details.</p>

<hr style="border: 0; height: 1px; background: #333; background-image: linear-gradient(to right, #ccc, #333, #ccc);">

<div align="center">
  <p style="font-style: italic; color: #666;">Built with ?? using .NET Aspire</p>
</div>
