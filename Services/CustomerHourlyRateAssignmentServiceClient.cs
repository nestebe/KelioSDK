
//.CustomerHourlyRateAssignmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class CustomerHourlyRateAssignmentServiceClient
  {
    private const string service = "CustomerHourlyRateAssignmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public CustomerHourlyRateAssignmentServiceClient(
      string username,
      string password,
      string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportCustomerHourlyRateAssignmentsListResponse ExportCustomerHourlyRateAssignmentsList(
      ExportCustomerHourlyRateAssignmentsList arg)
    {
      return Client.Post<ExportCustomerHourlyRateAssignmentsList, ExportCustomerHourlyRateAssignmentsListResponse>(this.username, this.password, this.baseuri, "CustomerHourlyRateAssignmentService", arg);
    }

    public Task<ExportCustomerHourlyRateAssignmentsListResponse> ExportCustomerHourlyRateAssignmentsListAsync(
      ExportCustomerHourlyRateAssignmentsList arg)
    {
      return Client.PostAsync<ExportCustomerHourlyRateAssignmentsList, ExportCustomerHourlyRateAssignmentsListResponse>(this.username, this.password, this.baseuri, "CustomerHourlyRateAssignmentService", arg);
    }

    public ImportCustomerHourlyRateAssignmentsResponse ImportCustomerHourlyRateAssignments(
      ImportCustomerHourlyRateAssignments arg)
    {
      return Client.Post<ImportCustomerHourlyRateAssignments, ImportCustomerHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "CustomerHourlyRateAssignmentService", arg);
    }

    public Task<ImportCustomerHourlyRateAssignmentsResponse> ImportCustomerHourlyRateAssignmentsAsync(
      ImportCustomerHourlyRateAssignments arg)
    {
      return Client.PostAsync<ImportCustomerHourlyRateAssignments, ImportCustomerHourlyRateAssignmentsResponse>(this.username, this.password, this.baseuri, "CustomerHourlyRateAssignmentService", arg);
    }
  }
}
