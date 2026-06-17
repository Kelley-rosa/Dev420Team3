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
- Run these commands one at a time:
    - Install-Package MongoDB.Driver
    - Install-Package Newtonsoft.Json
    - Install-Package EntityFramework
    - Install-Package Microsoft.AspNet.SignalR.Client

### 3.Connection Strings

All connection strings are in `App.config`. 

The default values are:
- **MongoDB**: `mongodb://localhost:27017/HospitalDB`
- **SQL Server**: `Data Source=YOUR_SERVER_NAME\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True`

Each team member needs to update the SQL Server connection string with their own server name.