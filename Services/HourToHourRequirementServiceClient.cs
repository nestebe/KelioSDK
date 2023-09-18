
//.HourToHourRequirementServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class HourToHourRequirementServiceClient
  {
    private const string service = "HourToHourRequirementService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public HourToHourRequirementServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportHourToHourRequirementsFromRelativeDatesResponse ExportHourToHourRequirementsFromRelativeDates(
      ExportHourToHourRequirementsFromRelativeDates arg)
    {
      return Client.Post<ExportHourToHourRequirementsFromRelativeDates, ExportHourToHourRequirementsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "HourToHourRequirementService", arg, this.timeoutSeconds);
    }

    public Task<ExportHourToHourRequirementsFromRelativeDatesResponse> ExportHourToHourRequirementsFromRelativeDatesAsync(
      ExportHourToHourRequirementsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportHourToHourRequirementsFromRelativeDates, ExportHourToHourRequirementsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "HourToHourRequirementService", arg, this.timeoutSeconds);
    }

    public ExportHourToHourRequirementsFromDateToDateResponse ExportHourToHourRequirementsFromDateToDate(
      ExportHourToHourRequirementsFromDateToDate arg)
    {
      return Client.Post<ExportHourToHourRequirementsFromDateToDate, ExportHourToHourRequirementsFromDateToDateResponse>(this.username, this.password, this.baseuri, "HourToHourRequirementService", arg, this.timeoutSeconds);
    }

    public Task<ExportHourToHourRequirementsFromDateToDateResponse> ExportHourToHourRequirementsFromDateToDateAsync(
      ExportHourToHourRequirementsFromDateToDate arg)
    {
      return Client.PostAsync<ExportHourToHourRequirementsFromDateToDate, ExportHourToHourRequirementsFromDateToDateResponse>(this.username, this.password, this.baseuri, "HourToHourRequirementService", arg, this.timeoutSeconds);
    }

    public ExportHourToHourRequirementsResponse ExportHourToHourRequirements(
      ExportHourToHourRequirements arg)
    {
      return Client.Post<ExportHourToHourRequirements, ExportHourToHourRequirementsResponse>(this.username, this.password, this.baseuri, "HourToHourRequirementService", arg, this.timeoutSeconds);
    }

    public Task<ExportHourToHourRequirementsResponse> ExportHourToHourRequirementsAsync(
      ExportHourToHourRequirements arg)
    {
      return Client.PostAsync<ExportHourToHourRequirements, ExportHourToHourRequirementsResponse>(this.username, this.password, this.baseuri, "HourToHourRequirementService", arg, this.timeoutSeconds);
    }

    public ImportHourToHourRequirementsResponse ImportHourToHourRequirements(
      ImportHourToHourRequirements arg)
    {
      return Client.Post<ImportHourToHourRequirements, ImportHourToHourRequirementsResponse>(this.username, this.password, this.baseuri, "HourToHourRequirementService", arg, this.timeoutSeconds);
    }

    public Task<ImportHourToHourRequirementsResponse> ImportHourToHourRequirementsAsync(
      ImportHourToHourRequirements arg)
    {
      return Client.PostAsync<ImportHourToHourRequirements, ImportHourToHourRequirementsResponse>(this.username, this.password, this.baseuri, "HourToHourRequirementService", arg, this.timeoutSeconds);
    }

    public DeleteHourToHourRequirementsResponse DeleteHourToHourRequirements(
      DeleteHourToHourRequirements arg)
    {
      return Client.Post<DeleteHourToHourRequirements, DeleteHourToHourRequirementsResponse>(this.username, this.password, this.baseuri, "HourToHourRequirementService", arg, this.timeoutSeconds);
    }

    public Task<DeleteHourToHourRequirementsResponse> DeleteHourToHourRequirementsAsync(
      DeleteHourToHourRequirements arg)
    {
      return Client.PostAsync<DeleteHourToHourRequirements, DeleteHourToHourRequirementsResponse>(this.username, this.password, this.baseuri, "HourToHourRequirementService", arg, this.timeoutSeconds);
    }
  }
}
