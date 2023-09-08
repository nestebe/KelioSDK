# KelioSDK

KelioSDK is a robust C# library designed to simplify interactions with Kelio Web Services. Whether you're building an integration for time and attendance management, access control, or HR processes, this SDK provides a programmatic interface to access various functionalities and data models in the Kelio system.



### Installation

```bash
Install-Package KelioSDK 

dotnet add package KelioSDK 
```



### Usage

```c#

//Get all employees
LightEmployeeServiceClient empService = new LightEmployeeServiceClient("login", "password", "https://your-api-url.cm/open/services");

var allEmployees = empService.ExportLightEmployees(new ExportLightEmployees { GroupFilter = null, PopulationFilter = null })?.ExportedLightEmployees;

//Get absences by date
AbsenceFileServiceClient absenceFileServiceClient = new AbsenceFileServiceClient("login", "password", "https://your-api-url.cm/open/services");

//define your startDate, endDate
var absenceList = absenceFileServiceClient.ExportAbsenceFiles(new KelioSDK.Services.ExportAbsenceFiles { StartDate = startDate, EndDate = endDate });






```



