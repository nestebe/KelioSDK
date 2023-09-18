
//.ClockingServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class ClockingServiceClient
  {
    private const string service = "ClockingService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public ClockingServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportCalculatedClockingsOnlyResponse ExportCalculatedClockingsOnly(
      ExportCalculatedClockingsOnly arg)
    {
      return Client.Post<ExportCalculatedClockingsOnly, ExportCalculatedClockingsOnlyResponse>(this.username, this.password, this.baseuri, "ClockingService", arg, this.timeoutSeconds);
    }

    public Task<ExportCalculatedClockingsOnlyResponse> ExportCalculatedClockingsOnlyAsync(
      ExportCalculatedClockingsOnly arg)
    {
      return Client.PostAsync<ExportCalculatedClockingsOnly, ExportCalculatedClockingsOnlyResponse>(this.username, this.password, this.baseuri, "ClockingService", arg, this.timeoutSeconds);
    }

    public DeletePhysicalClockingsResponse DeletePhysicalClockings(
      DeletePhysicalClockings arg)
    {
      return Client.Post<DeletePhysicalClockings, DeletePhysicalClockingsResponse>(this.username, this.password, this.baseuri, "ClockingService", arg, this.timeoutSeconds);
    }

    public Task<DeletePhysicalClockingsResponse> DeletePhysicalClockingsAsync(
      DeletePhysicalClockings arg)
    {
      return Client.PostAsync<DeletePhysicalClockings, DeletePhysicalClockingsResponse>(this.username, this.password, this.baseuri, "ClockingService", arg, this.timeoutSeconds);
    }

    public ImportPhysicalClockingsResponse ImportPhysicalClockings(
      ImportPhysicalClockings arg)
    {
      return Client.Post<ImportPhysicalClockings, ImportPhysicalClockingsResponse>(this.username, this.password, this.baseuri, "ClockingService", arg, this.timeoutSeconds);
    }

    public Task<ImportPhysicalClockingsResponse> ImportPhysicalClockingsAsync(
      ImportPhysicalClockings arg)
    {
      return Client.PostAsync<ImportPhysicalClockings, ImportPhysicalClockingsResponse>(this.username, this.password, this.baseuri, "ClockingService", arg, this.timeoutSeconds);
    }

    public ExportClockingsResponse ExportClockings(ExportClockings arg)
    {
      return Client.Post<ExportClockings, ExportClockingsResponse>(this.username, this.password, this.baseuri, "ClockingService", arg, this.timeoutSeconds);
    }

    public Task<ExportClockingsResponse> ExportClockingsAsync(
      ExportClockings arg)
    {
      return Client.PostAsync<ExportClockings, ExportClockingsResponse>(this.username, this.password, this.baseuri, "ClockingService", arg, this.timeoutSeconds);
    }

    public ExportClockingsByDateForEmployeeListResponse ExportClockingsByDateForEmployeeList(
      ExportClockingsByDateForEmployeeList arg)
    {
      return Client.Post<ExportClockingsByDateForEmployeeList, ExportClockingsByDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "ClockingService", arg, this.timeoutSeconds);
    }

    public Task<ExportClockingsByDateForEmployeeListResponse> ExportClockingsByDateForEmployeeListAsync(
      ExportClockingsByDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportClockingsByDateForEmployeeList, ExportClockingsByDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "ClockingService", arg, this.timeoutSeconds);
    }

    public ExportClockingsByDateResponse ExportClockingsByDate(
      ExportClockingsByDate arg)
    {
      return Client.Post<ExportClockingsByDate, ExportClockingsByDateResponse>(this.username, this.password, this.baseuri, "ClockingService", arg, this.timeoutSeconds);
    }

    public Task<ExportClockingsByDateResponse> ExportClockingsByDateAsync(
      ExportClockingsByDate arg)
    {
      return Client.PostAsync<ExportClockingsByDate, ExportClockingsByDateResponse>(this.username, this.password, this.baseuri, "ClockingService", arg, this.timeoutSeconds);
    }

    public ImportClockingsResponse ImportClockings(ImportClockings arg)
    {
      return Client.Post<ImportClockings, ImportClockingsResponse>(this.username, this.password, this.baseuri, "ClockingService", arg, this.timeoutSeconds);
    }

    public Task<ImportClockingsResponse> ImportClockingsAsync(
      ImportClockings arg)
    {
      return Client.PostAsync<ImportClockings, ImportClockingsResponse>(this.username, this.password, this.baseuri, "ClockingService", arg, this.timeoutSeconds);
    }
  }
}
