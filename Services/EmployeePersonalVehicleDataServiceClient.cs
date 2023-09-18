
//.EmployeePersonalVehicleDataServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmployeePersonalVehicleDataServiceClient
  {
    private const string service = "EmployeePersonalVehicleDataService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public EmployeePersonalVehicleDataServiceClient(
      string username,
      string password,
      string baseuri, int timeoutSeconds = 60) 
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportEmployeePersonalVehicleDataResponse ExportEmployeePersonalVehicleData(
      ExportEmployeePersonalVehicleData arg)
    {
      return Client.Post<ExportEmployeePersonalVehicleData, ExportEmployeePersonalVehicleDataResponse>(this.username, this.password, this.baseuri, "EmployeePersonalVehicleDataService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeePersonalVehicleDataResponse> ExportEmployeePersonalVehicleDataAsync(
      ExportEmployeePersonalVehicleData arg)
    {
      return Client.PostAsync<ExportEmployeePersonalVehicleData, ExportEmployeePersonalVehicleDataResponse>(this.username, this.password, this.baseuri, "EmployeePersonalVehicleDataService", arg, this.timeoutSeconds);
    }

    public ImportEmployeePersonalVehicleDataResponse ImportEmployeePersonalVehicleData(
      ImportEmployeePersonalVehicleData arg)
    {
      return Client.Post<ImportEmployeePersonalVehicleData, ImportEmployeePersonalVehicleDataResponse>(this.username, this.password, this.baseuri, "EmployeePersonalVehicleDataService", arg, this.timeoutSeconds);
    }

    public Task<ImportEmployeePersonalVehicleDataResponse> ImportEmployeePersonalVehicleDataAsync(
      ImportEmployeePersonalVehicleData arg)
    {
      return Client.PostAsync<ImportEmployeePersonalVehicleData, ImportEmployeePersonalVehicleDataResponse>(this.username, this.password, this.baseuri, "EmployeePersonalVehicleDataService", arg, this.timeoutSeconds);
    }
  }
}
