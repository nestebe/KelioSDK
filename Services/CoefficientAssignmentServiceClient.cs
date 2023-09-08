
//.CoefficientAssignmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class CoefficientAssignmentServiceClient
  {
    private const string service = "CoefficientAssignmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public CoefficientAssignmentServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportCoefficientAssignmentsResponse ImportCoefficientAssignments(
      ImportCoefficientAssignments arg)
    {
      return Client.Post<ImportCoefficientAssignments, ImportCoefficientAssignmentsResponse>(this.username, this.password, this.baseuri, "CoefficientAssignmentService", arg);
    }

    public Task<ImportCoefficientAssignmentsResponse> ImportCoefficientAssignmentsAsync(
      ImportCoefficientAssignments arg)
    {
      return Client.PostAsync<ImportCoefficientAssignments, ImportCoefficientAssignmentsResponse>(this.username, this.password, this.baseuri, "CoefficientAssignmentService", arg);
    }

    public ExportCoefficientAssignmentsListResponse ExportCoefficientAssignmentsList(
      ExportCoefficientAssignmentsList arg)
    {
      return Client.Post<ExportCoefficientAssignmentsList, ExportCoefficientAssignmentsListResponse>(this.username, this.password, this.baseuri, "CoefficientAssignmentService", arg);
    }

    public Task<ExportCoefficientAssignmentsListResponse> ExportCoefficientAssignmentsListAsync(
      ExportCoefficientAssignmentsList arg)
    {
      return Client.PostAsync<ExportCoefficientAssignmentsList, ExportCoefficientAssignmentsListResponse>(this.username, this.password, this.baseuri, "CoefficientAssignmentService", arg);
    }

    public ExportCoefficientAssignmentsResponse ExportCoefficientAssignments(
      ExportCoefficientAssignments arg)
    {
      return Client.Post<ExportCoefficientAssignments, ExportCoefficientAssignmentsResponse>(this.username, this.password, this.baseuri, "CoefficientAssignmentService", arg);
    }

    public Task<ExportCoefficientAssignmentsResponse> ExportCoefficientAssignmentsAsync(
      ExportCoefficientAssignments arg)
    {
      return Client.PostAsync<ExportCoefficientAssignments, ExportCoefficientAssignmentsResponse>(this.username, this.password, this.baseuri, "CoefficientAssignmentService", arg);
    }
  }
}
