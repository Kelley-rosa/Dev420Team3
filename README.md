# Dev420Team3
Hospital Management System Final Project

### Responsibilities
- Person 1 - Login, Registration, Patient Management, Analytics
- Person 2 - Appointments, Dashboard, SignalR Hub
- Person 3 - Inventory, Chat

## Getting Started

### 1. Set Up the SQL Server Database
1. Open SQL Server Management Studio (SSMS)
2. Open the `HospitalDBSetup.sql` file in the root of the repo
3. Click **Execute**
4. This will create the `HospitalDB`

### 2. Restore NuGet Packages
Visual Studio should prompt you to restore packages automatically. If it doesn't:
- Go to **Tools > NuGet Package Manager > Package Manager Console**
- For the `HospitalManagementSystem` project (make sure it's selected in the Package Manager Console dropdown):
    - Install-Package MongoDB.Driver
    - Install-Package Newtonsoft.Json
    - Install-Package EntityFramework
    - Install-Package Microsoft.AspNet.SignalR.Client
- For the `HospitalSignalRServer` project (select it in the Package Manager Console dropdown before running these):
    - Install-Package Microsoft.AspNet.SignalR
    - Install-Package Microsoft.Owin.Hosting
    - Install-Package Microsoft.Owin.Cors

### 3.Connection Strings

All connection strings are in `App.config`. 

The default values are:
- **MongoDB**: `mongodb://localhost:27017/HospitalDB`
- **SQL Server**: `Data Source=YOUR_SERVER_NAME\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True`

Each team member needs to update the SQL Server connection string with their own server name.

### 4. Run the SignalR Server Alongside the App

The project has two parts: the Windows Forms app and the SignalR server. Both need to run together.

1. Open `HospitalManagementSystem.sln`, both projects should load in Solution Explorer
2. Right click the **Solution** at the top
3. Click **Configure Startup Projects**
4. Choose **Multiple startup projects**
5. Set both `HospitalManagementSystem` and `HospitalSignalRServer` to **Start**
6. Click OK

Now pressing F5 will launch both the server and the app together.