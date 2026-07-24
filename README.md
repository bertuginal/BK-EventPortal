<h2 align="center">Gather Event API & Ticketing Engine 🎫🚀</h2>
<h3 align="center">Event Portal - Techcareer .Net Core Domination Bootcamp Final Project</h3>

A structured, full-stack event ticketing platform and RESTful API engineered utilizing C# and the .NET Core ecosystem. The application strictly implements N-Tier Architecture patterns to decouple database migrations, business validation rules, and responsive presentation layers. Developed as the Final Graduation Project for the **Techcareer .NET Core Domination Bootcamp**.

---

## 🗂️ Architectural Layering & Features

* **N-Tier Architecture**: Divided domain workflows into three highly specialized logical boundaries:
  * `EventPortal.DAL`: Data Access Layer managing entities, database context models, and MSSQL migrations.
  * `EventPortal.BLL`: Business Logic Layer enforcing system evaluation rules and service mappings.
  * `EventPortal.UI`: User Interface layer rendering dynamic data structures seamlessly.
* **Ticketing Lifecycle Management**: Modeled full relational schemas enabling platform users to process event listings, verify remaining capacities, and trigger simulated ticket acquisitions.
* **Responsive Client Integration**: Developed clean client views using Bootstrap to consume internal REST endpoints and display formatted datagrids.

## 🛠️ Tech Stack & Specifications

* **Language**: C#
* **Framework**: .NET Core (Web API & MVC principles)
* **Architecture**: N-Tier (Layered) Architecture
* **Database Management**: MSSQL (Microsoft SQL Server)
* **Front-End Styling**: Bootstrap, HTML5, CSS3

## 🚀 Quick Start & Local Run

To clone the application assets and initialize the .NET compiler locally, process the following sequence:

1. Clone this event portal workspace repository:
   ```bash
   git clone https://github.com
   ```
2. Navigate into the primary solution directory:
   ```bash
   cd gather-event-api
   ```
3. Update your connection strings in the local application configuration profiles to target your MSSQL instance.
4. Restore project dependencies and fire up the host web server:
   ```bash
   dotnet restore
   dotnet run --project EventPortal.UI
   ```

## 📬 Contact & Support

For architecture mapping, clean code evaluations, or database schema discussions:

📧 **Email:** bertuginal@yahoo.com

ℹ️ **LinkedIn:** [in/bertuginal](https://www.linkedin.com/in/bertuginal/)


