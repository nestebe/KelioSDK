
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
    private readonly string baseuri;

    public PopulationAssignmentServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public DeletePopulationAssignmentsResponse DeletePopulationAssignments(
      DeletePopulationAssignments arg)
    {
      return Client.Post<DeletePopulationAssignments, DeletePopulationAssignmentsResponse>(this.username, this.password, this.baseuri, "PopulationAssignmentService", arg);
    }

    public Task<DeletePopulationAssignmentsResponse> DeletePopulationAssignmentsAsync(
      DeletePopulationAssignments arg)
    {
      return Client.PostAsync<DeletePopulationAssignments, DeletePopulationAssignmentsResponse>(this.username, this.password, this.baseuri, "PopulationAssignmentService", arg);
    }

    public ImportPopulationAssignmentsResponse ImportPopulationAssignments(
      ImportPopulationAssignments arg)
    {
      return Client.Post<ImportPopulationAssignments, ImportPopulationAssignmentsResponse>(this.username, this.password, this.baseuri, "PopulationAssignmentService", arg);
    }

    public Task<ImportPopulationAssignmentsResponse> ImportPopulationAssignmentsAsync(
      ImportPopulationAssignments arg)
    {
      return Client.PostAsync<ImportPopulationAssignments, ImportPopulationAssignmentsResponse>(this.username, this.password, this.baseuri, "PopulationAssignmentService", arg);
    }
  }
}
