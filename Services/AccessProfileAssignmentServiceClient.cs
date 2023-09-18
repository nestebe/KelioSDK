
//.AccessProfileAssignmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class AccessProfileAssignmentServiceClient
  {
    private const string service = "AccessProfileAssignmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public AccessProfileAssignmentServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportAccessProfileAssignmentsResponse ImportAccessProfileAssignments(
      ImportAccessProfileAssignments arg)
    {
      return Client.Post<ImportAccessProfileAssignments, ImportAccessProfileAssignmentsResponse>(this.username, this.password, this.baseuri, "AccessProfileAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ImportAccessProfileAssignmentsResponse> ImportAccessProfileAssignmentsAsync(
      ImportAccessProfileAssignments arg)
    {
      return Client.PostAsync<ImportAccessProfileAssignments, ImportAccessProfileAssignmentsResponse>(this.username, this.password, this.baseuri, "AccessProfileAssignmentService", arg, this.timeoutSeconds);
    }

    public ExportAccessProfileAssignmentsResponse ExportAccessProfileAssignments(
      ExportAccessProfileAssignments arg)
    {
      return Client.Post<ExportAccessProfileAssignments, ExportAccessProfileAssignmentsResponse>(this.username, this.password, this.baseuri, "AccessProfileAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportAccessProfileAssignmentsResponse> ExportAccessProfileAssignmentsAsync(
      ExportAccessProfileAssignments arg)
    {
      return Client.PostAsync<ExportAccessProfileAssignments, ExportAccessProfileAssignmentsResponse>(this.username, this.password, this.baseuri, "AccessProfileAssignmentService", arg, this.timeoutSeconds);
    }

    public ExportAccessProfileAssignmentsListResponse ExportAccessProfileAssignmentsList(
      ExportAccessProfileAssignmentsList arg)
    {
      return Client.Post<ExportAccessProfileAssignmentsList, ExportAccessProfileAssignmentsListResponse>(this.username, this.password, this.baseuri, "AccessProfileAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportAccessProfileAssignmentsListResponse> ExportAccessProfileAssignmentsListAsync(
      ExportAccessProfileAssignmentsList arg)
    {
      return Client.PostAsync<ExportAccessProfileAssignmentsList, ExportAccessProfileAssignmentsListResponse>(this.username, this.password, this.baseuri, "AccessProfileAssignmentService", arg, this.timeoutSeconds);
    }
  }
}
