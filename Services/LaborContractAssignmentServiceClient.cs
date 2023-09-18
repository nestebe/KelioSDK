
//.LaborContractAssignmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class LaborContractAssignmentServiceClient
  {
    private const string service = "LaborContractAssignmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public LaborContractAssignmentServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportLaborContractAssignmentsResponse ExportLaborContractAssignments(
      ExportLaborContractAssignments arg)
    {
      return Client.Post<ExportLaborContractAssignments, ExportLaborContractAssignmentsResponse>(this.username, this.password, this.baseuri, "LaborContractAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportLaborContractAssignmentsResponse> ExportLaborContractAssignmentsAsync(
      ExportLaborContractAssignments arg)
    {
      return Client.PostAsync<ExportLaborContractAssignments, ExportLaborContractAssignmentsResponse>(this.username, this.password, this.baseuri, "LaborContractAssignmentService", arg, this.timeoutSeconds);
    }

    public DeleteLaborContractAssignmentsResponse DeleteLaborContractAssignments(
      DeleteLaborContractAssignments arg)
    {
      return Client.Post<DeleteLaborContractAssignments, DeleteLaborContractAssignmentsResponse>(this.username, this.password, this.baseuri, "LaborContractAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<DeleteLaborContractAssignmentsResponse> DeleteLaborContractAssignmentsAsync(
      DeleteLaborContractAssignments arg)
    {
      return Client.PostAsync<DeleteLaborContractAssignments, DeleteLaborContractAssignmentsResponse>(this.username, this.password, this.baseuri, "LaborContractAssignmentService", arg, this.timeoutSeconds);
    }

    public ImportLaborContractAssignmentsResponse ImportLaborContractAssignments(
      ImportLaborContractAssignments arg)
    {
      return Client.Post<ImportLaborContractAssignments, ImportLaborContractAssignmentsResponse>(this.username, this.password, this.baseuri, "LaborContractAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ImportLaborContractAssignmentsResponse> ImportLaborContractAssignmentsAsync(
      ImportLaborContractAssignments arg)
    {
      return Client.PostAsync<ImportLaborContractAssignments, ImportLaborContractAssignmentsResponse>(this.username, this.password, this.baseuri, "LaborContractAssignmentService", arg, this.timeoutSeconds);
    }
  }
}
