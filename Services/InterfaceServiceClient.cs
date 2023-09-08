
//.InterfaceServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class InterfaceServiceClient
  {
    private const string service = "InterfaceService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public InterfaceServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportInterfacesResponse ExportInterfaces(ExportInterfaces arg)
    {
      return Client.Post<ExportInterfaces, ExportInterfacesResponse>(this.username, this.password, this.baseuri, "InterfaceService", arg);
    }

    public Task<ExportInterfacesResponse> ExportInterfacesAsync(
      ExportInterfaces arg)
    {
      return Client.PostAsync<ExportInterfaces, ExportInterfacesResponse>(this.username, this.password, this.baseuri, "InterfaceService", arg);
    }

    public ExportInterfacesListResponse ExportInterfacesList(
      ExportInterfacesList arg)
    {
      return Client.Post<ExportInterfacesList, ExportInterfacesListResponse>(this.username, this.password, this.baseuri, "InterfaceService", arg);
    }

    public Task<ExportInterfacesListResponse> ExportInterfacesListAsync(
      ExportInterfacesList arg)
    {
      return Client.PostAsync<ExportInterfacesList, ExportInterfacesListResponse>(this.username, this.password, this.baseuri, "InterfaceService", arg);
    }

    public ExecuteInstancesResponse ExecuteInstances(ExecuteInstances arg)
    {
      return Client.Post<ExecuteInstances, ExecuteInstancesResponse>(this.username, this.password, this.baseuri, "InterfaceService", arg);
    }

    public Task<ExecuteInstancesResponse> ExecuteInstancesAsync(
      ExecuteInstances arg)
    {
      return Client.PostAsync<ExecuteInstances, ExecuteInstancesResponse>(this.username, this.password, this.baseuri, "InterfaceService", arg);
    }

    public ExportInterfacesParametersResponse ExportInterfacesParameters(
      ExportInterfacesParameters arg)
    {
      return Client.Post<ExportInterfacesParameters, ExportInterfacesParametersResponse>(this.username, this.password, this.baseuri, "InterfaceService", arg);
    }

    public Task<ExportInterfacesParametersResponse> ExportInterfacesParametersAsync(
      ExportInterfacesParameters arg)
    {
      return Client.PostAsync<ExportInterfacesParameters, ExportInterfacesParametersResponse>(this.username, this.password, this.baseuri, "InterfaceService", arg);
    }
  }
}
