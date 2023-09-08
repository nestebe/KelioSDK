
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
    private readonly string baseuri;

    public LaborContractAssignmentServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportLaborContractAssignmentsResponse ExportLaborContractAssignments(
      ExportLaborContractAssignments arg)
    {
      return Client.Post<ExportLaborContractAssignments, ExportLaborContractAssignmentsResponse>(this.username, this.password, this.baseuri, "LaborContractAssignmentService", arg);
    }

    public Task<ExportLaborContractAssignmentsResponse> ExportLaborContractAssignmentsAsync(
      ExportLaborContractAssignments arg)
    {
      return Client.PostAsync<ExportLaborContractAssignments, ExportLaborContractAssignmentsResponse>(this.username, this.password, this.baseuri, "LaborContractAssignmentService", arg);
    }

    public DeleteLaborContractAssignmentsResponse DeleteLaborContractAssignments(
      DeleteLaborContractAssignments arg)
    {
      return Client.Post<DeleteLaborContractAssignments, DeleteLaborContractAssignmentsResponse>(this.username, this.password, this.baseuri, "LaborContractAssignmentService", arg);
    }

    public Task<DeleteLaborContractAssignmentsResponse> DeleteLaborContractAssignmentsAsync(
      DeleteLaborContractAssignments arg)
    {
      return Client.PostAsync<DeleteLaborContractAssignments, DeleteLaborContractAssignmentsResponse>(this.username, this.password, this.baseuri, "LaborContractAssignmentService", arg);
    }

    public ImportLaborContractAssignmentsResponse ImportLaborContractAssignments(
      ImportLaborContractAssignments arg)
    {
      return Client.Post<ImportLaborContractAssignments, ImportLaborContractAssignmentsResponse>(this.username, this.password, this.baseuri, "LaborContractAssignmentService", arg);
    }

    public Task<ImportLaborContractAssignmentsResponse> ImportLaborContractAssignmentsAsync(
      ImportLaborContractAssignments arg)
    {
      return Client.PostAsync<ImportLaborContractAssignments, ImportLaborContractAssignmentsResponse>(this.username, this.password, this.baseuri, "LaborContractAssignmentService", arg);
    }
  }
}
