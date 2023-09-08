
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
    private readonly string baseuri;

    public EmployeePersonalVehicleDataServiceClient(
      string username,
      string password,
      string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportEmployeePersonalVehicleDataResponse ExportEmployeePersonalVehicleData(
      ExportEmployeePersonalVehicleData arg)
    {
      return Client.Post<ExportEmployeePersonalVehicleData, ExportEmployeePersonalVehicleDataResponse>(this.username, this.password, this.baseuri, "EmployeePersonalVehicleDataService", arg);
    }

    public Task<ExportEmployeePersonalVehicleDataResponse> ExportEmployeePersonalVehicleDataAsync(
      ExportEmployeePersonalVehicleData arg)
    {
      return Client.PostAsync<ExportEmployeePersonalVehicleData, ExportEmployeePersonalVehicleDataResponse>(this.username, this.password, this.baseuri, "EmployeePersonalVehicleDataService", arg);
    }

    public ImportEmployeePersonalVehicleDataResponse ImportEmployeePersonalVehicleData(
      ImportEmployeePersonalVehicleData arg)
    {
      return Client.Post<ImportEmployeePersonalVehicleData, ImportEmployeePersonalVehicleDataResponse>(this.username, this.password, this.baseuri, "EmployeePersonalVehicleDataService", arg);
    }

    public Task<ImportEmployeePersonalVehicleDataResponse> ImportEmployeePersonalVehicleDataAsync(
      ImportEmployeePersonalVehicleData arg)
    {
      return Client.PostAsync<ImportEmployeePersonalVehicleData, ImportEmployeePersonalVehicleDataResponse>(this.username, this.password, this.baseuri, "EmployeePersonalVehicleDataService", arg);
    }
  }
}
