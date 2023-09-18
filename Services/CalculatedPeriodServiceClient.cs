
//.CalculatedPeriodServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class CalculatedPeriodServiceClient
  {
    private const string service = "CalculatedPeriodService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public CalculatedPeriodServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportPeriodicalCalculatedPeriodFromPeriodForEmployeeListResponse ExportPeriodicalCalculatedPeriodFromPeriodForEmployeeList(
      ExportPeriodicalCalculatedPeriodFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportPeriodicalCalculatedPeriodFromPeriodForEmployeeList, ExportPeriodicalCalculatedPeriodFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public Task<ExportPeriodicalCalculatedPeriodFromPeriodForEmployeeListResponse> ExportPeriodicalCalculatedPeriodFromPeriodForEmployeeListAsync(
      ExportPeriodicalCalculatedPeriodFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportPeriodicalCalculatedPeriodFromPeriodForEmployeeList, ExportPeriodicalCalculatedPeriodFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public ExportWeeklyCalculatedPeriodFromPeriodForEmployeeListResponse ExportWeeklyCalculatedPeriodFromPeriodForEmployeeList(
      ExportWeeklyCalculatedPeriodFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportWeeklyCalculatedPeriodFromPeriodForEmployeeList, ExportWeeklyCalculatedPeriodFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public Task<ExportWeeklyCalculatedPeriodFromPeriodForEmployeeListResponse> ExportWeeklyCalculatedPeriodFromPeriodForEmployeeListAsync(
      ExportWeeklyCalculatedPeriodFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportWeeklyCalculatedPeriodFromPeriodForEmployeeList, ExportWeeklyCalculatedPeriodFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public ExportPeriodicalCalculatedPeriodResponse ExportPeriodicalCalculatedPeriod(
      ExportPeriodicalCalculatedPeriod arg)
    {
      return Client.Post<ExportPeriodicalCalculatedPeriod, ExportPeriodicalCalculatedPeriodResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public Task<ExportPeriodicalCalculatedPeriodResponse> ExportPeriodicalCalculatedPeriodAsync(
      ExportPeriodicalCalculatedPeriod arg)
    {
      return Client.PostAsync<ExportPeriodicalCalculatedPeriod, ExportPeriodicalCalculatedPeriodResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public ExportPeriodicalCalculatedPeriodsResponse ExportPeriodicalCalculatedPeriods(
      ExportPeriodicalCalculatedPeriods arg)
    {
      return Client.Post<ExportPeriodicalCalculatedPeriods, ExportPeriodicalCalculatedPeriodsResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public Task<ExportPeriodicalCalculatedPeriodsResponse> ExportPeriodicalCalculatedPeriodsAsync(
      ExportPeriodicalCalculatedPeriods arg)
    {
      return Client.PostAsync<ExportPeriodicalCalculatedPeriods, ExportPeriodicalCalculatedPeriodsResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public ExportPeriodicalCalculatedPeriodListResponse ExportPeriodicalCalculatedPeriodList(
      ExportPeriodicalCalculatedPeriodList arg)
    {
      return Client.Post<ExportPeriodicalCalculatedPeriodList, ExportPeriodicalCalculatedPeriodListResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public Task<ExportPeriodicalCalculatedPeriodListResponse> ExportPeriodicalCalculatedPeriodListAsync(
      ExportPeriodicalCalculatedPeriodList arg)
    {
      return Client.PostAsync<ExportPeriodicalCalculatedPeriodList, ExportPeriodicalCalculatedPeriodListResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public ExportWeeklyCalculatedPeriodsResponse ExportWeeklyCalculatedPeriods(
      ExportWeeklyCalculatedPeriods arg)
    {
      return Client.Post<ExportWeeklyCalculatedPeriods, ExportWeeklyCalculatedPeriodsResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public Task<ExportWeeklyCalculatedPeriodsResponse> ExportWeeklyCalculatedPeriodsAsync(
      ExportWeeklyCalculatedPeriods arg)
    {
      return Client.PostAsync<ExportWeeklyCalculatedPeriods, ExportWeeklyCalculatedPeriodsResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public ExportWeeklyCalculatedPeriodResponse ExportWeeklyCalculatedPeriod(
      ExportWeeklyCalculatedPeriod arg)
    {
      return Client.Post<ExportWeeklyCalculatedPeriod, ExportWeeklyCalculatedPeriodResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public Task<ExportWeeklyCalculatedPeriodResponse> ExportWeeklyCalculatedPeriodAsync(
      ExportWeeklyCalculatedPeriod arg)
    {
      return Client.PostAsync<ExportWeeklyCalculatedPeriod, ExportWeeklyCalculatedPeriodResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public ExportWeeklyCalculatedPeriodListResponse ExportWeeklyCalculatedPeriodList(
      ExportWeeklyCalculatedPeriodList arg)
    {
      return Client.Post<ExportWeeklyCalculatedPeriodList, ExportWeeklyCalculatedPeriodListResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public Task<ExportWeeklyCalculatedPeriodListResponse> ExportWeeklyCalculatedPeriodListAsync(
      ExportWeeklyCalculatedPeriodList arg)
    {
      return Client.PostAsync<ExportWeeklyCalculatedPeriodList, ExportWeeklyCalculatedPeriodListResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public ExportPeriodicalCalculatedPeriodFromRelativeDatesForEmployeeListResponse ExportPeriodicalCalculatedPeriodFromRelativeDatesForEmployeeList(
      ExportPeriodicalCalculatedPeriodFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPeriodicalCalculatedPeriodFromRelativeDatesForEmployeeList, ExportPeriodicalCalculatedPeriodFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public Task<ExportPeriodicalCalculatedPeriodFromRelativeDatesForEmployeeListResponse> ExportPeriodicalCalculatedPeriodFromRelativeDatesForEmployeeListAsync(
      ExportPeriodicalCalculatedPeriodFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPeriodicalCalculatedPeriodFromRelativeDatesForEmployeeList, ExportPeriodicalCalculatedPeriodFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public ExportWeeklyCalculatedPeriodFromRelativeDatesForEmployeeListResponse ExportWeeklyCalculatedPeriodFromRelativeDatesForEmployeeList(
      ExportWeeklyCalculatedPeriodFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportWeeklyCalculatedPeriodFromRelativeDatesForEmployeeList, ExportWeeklyCalculatedPeriodFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }

    public Task<ExportWeeklyCalculatedPeriodFromRelativeDatesForEmployeeListResponse> ExportWeeklyCalculatedPeriodFromRelativeDatesForEmployeeListAsync(
      ExportWeeklyCalculatedPeriodFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportWeeklyCalculatedPeriodFromRelativeDatesForEmployeeList, ExportWeeklyCalculatedPeriodFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "CalculatedPeriodService", arg, this.timeoutSeconds);
    }
  }
}
