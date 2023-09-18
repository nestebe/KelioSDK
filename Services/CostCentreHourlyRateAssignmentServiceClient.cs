
//.CostCentreHourlyRateAssignmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class CostCentreHourlyRateAssignmentServiceClient
  {
    private const string service = "CostCentreHourlyRateAssignmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public CostCentreHourlyRateAssignmentServiceClient(
      string username,
      string password,
      string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportCostCentreHourlyRateAssignmentsResponse ExportCostCentreHourlyRateAssignments(
      ExportCostCentreHourlyRateAssignments arg)
    {
      return Client.Post<ExportCostCentreHourlyRateAssignments, ExportCostCentreHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "CostCentreHourlyRateAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportCostCentreHourlyRateAssignmentsResponse> ExportCostCentreHourlyRateAssignmentsAsync(
      ExportCostCentreHourlyRateAssignments arg)
    {
      return Client.PostAsync<ExportCostCentreHourlyRateAssignments, ExportCostCentreHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "CostCentreHourlyRateAssignmentService", arg, this.timeoutSeconds);
    }

    public ExportCostCentreHourlyRateAssignmentsListResponse ExportCostCentreHourlyRateAssignmentsList(
      ExportCostCentreHourlyRateAssignmentsList arg)
    {
      return Client.Post<ExportCostCentreHourlyRateAssignmentsList, ExportCostCentreHourlyRateAssignmentsListResponse>(this.username, this.password, this.baseuri, "CostCentreHourlyRateAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportCostCentreHourlyRateAssignmentsListResponse> ExportCostCentreHourlyRateAssignmentsListAsync(
      ExportCostCentreHourlyRateAssignmentsList arg)
    {
      return Client.PostAsync<ExportCostCentreHourlyRateAssignmentsList, ExportCostCentreHourlyRateAssignmentsListResponse>(this.username, this.password, this.baseuri, "CostCentreHourlyRateAssignmentService", arg, this.timeoutSeconds);
    }

    public ImportCostCentreHourlyRateAssignmentsResponse ImportCostCentreHourlyRateAssignments(
      ImportCostCentreHourlyRateAssignments arg)
    {
      return Client.Post<ImportCostCentreHourlyRateAssignments, ImportCostCentreHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "CostCentreHourlyRateAssignmentService", arg, this.timeoutSeconds);
    }

    public Task<ImportCostCentreHourlyRateAssignmentsResponse> ImportCostCentreHourlyRateAssignmentsAsync(
      ImportCostCentreHourlyRateAssignments arg)
    {
      return Client.PostAsync<ImportCostCentreHourlyRateAssignments, ImportCostCentreHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "CostCentreHourlyRateAssignmentService", arg, this.timeoutSeconds);
    }
  }
}
