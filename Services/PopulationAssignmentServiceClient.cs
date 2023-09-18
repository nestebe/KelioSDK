
//.PopulationAssignmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class PopulationAssignmentServiceClient
  {
    private const string service = "PopulationAssignmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public PopulationAssignmentServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public DeletePopulationAssignmentsResponse DeletePopulationAssignments(
      DeletePopulationAssignments arg)
    {
      return Client.Post<DeletePopulationAssignments, DeletePopulationAssignmentsResponse>(this.username, this.password, this.baseuri, "PopulationAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<DeletePopulationAssignmentsResponse> DeletePopulationAssignmentsAsync(
      DeletePopulationAssignments arg)
    {
      return Client.PostAsync<DeletePopulationAssignments, DeletePopulationAssignmentsResponse>(this.username, this.password, this.baseuri, "PopulationAssignmentService", arg, this.timeoutSeconds);
    }

    public ImportPopulationAssignmentsResponse ImportPopulationAssignments(
      ImportPopulationAssignments arg)
    {
      return Client.Post<ImportPopulationAssignments, ImportPopulationAssignmentsResponse>(this.username, this.password, this.baseuri, "PopulationAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ImportPopulationAssignmentsResponse> ImportPopulationAssignmentsAsync(
      ImportPopulationAssignments arg)
    {
      return Client.PostAsync<ImportPopulationAssignments, ImportPopulationAssignmentsResponse>(this.username, this.password, this.baseuri, "PopulationAssignmentService", arg, this.timeoutSeconds);
    }
  }
}
