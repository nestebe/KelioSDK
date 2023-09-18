
//.HourlyContractAssignmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class HourlyContractAssignmentServiceClient
  {
    private const string service = "HourlyContractAssignmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public HourlyContractAssignmentServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public DeletedHourlyContractAssignmentsResponse DeletedHourlyContractAssignments(
      DeletedHourlyContractAssignments arg)
    {
      return Client.Post<DeletedHourlyContractAssignments, DeletedHourlyContractAssignmentsResponse>(this.username, this.password, this.baseuri, "HourlyContractAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<DeletedHourlyContractAssignmentsResponse> DeletedHourlyContractAssignmentsAsync(
      DeletedHourlyContractAssignments arg)
    {
      return Client.PostAsync<DeletedHourlyContractAssignments, DeletedHourlyContractAssignmentsResponse>(this.username, this.password, this.baseuri, "HourlyContractAssignmentService", arg, this.timeoutSeconds);
    }

    public ExportHourlyContractAssignmentsResponse ExportHourlyContractAssignments(
      ExportHourlyContractAssignments arg)
    {
      return Client.Post<ExportHourlyContractAssignments, ExportHourlyContractAssignmentsResponse>(this.username, this.password, this.baseuri, "HourlyContractAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportHourlyContractAssignmentsResponse> ExportHourlyContractAssignmentsAsync(
      ExportHourlyContractAssignments arg)
    {
      return Client.PostAsync<ExportHourlyContractAssignments, ExportHourlyContractAssignmentsResponse>(this.username, this.password, this.baseuri, "HourlyContractAssignmentService", arg, this.timeoutSeconds);
    }

    public ImportHourlyContractAssignmentsResponse ImportHourlyContractAssignments(
      ImportHourlyContractAssignments arg)
    {
      return Client.Post<ImportHourlyContractAssignments, ImportHourlyContractAssignmentsResponse>(this.username, this.password, this.baseuri, "HourlyContractAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ImportHourlyContractAssignmentsResponse> ImportHourlyContractAssignmentsAsync(
      ImportHourlyContractAssignments arg)
    {
      return Client.PostAsync<ImportHourlyContractAssignments, ImportHourlyContractAssignmentsResponse>(this.username, this.password, this.baseuri, "HourlyContractAssignmentService", arg, this.timeoutSeconds);
    }
  }
}
