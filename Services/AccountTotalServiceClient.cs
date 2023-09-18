
//.AccountTotalServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class AccountTotalServiceClient
  {
    private const string service = "AccountTotalService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public AccountTotalServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportActualDailyAccountTotalsFromDateToDateForEmployeeListResponse ExportActualDailyAccountTotalsFromDateToDateForEmployeeList(
      ExportActualDailyAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyAccountTotalsFromDateToDateForEmployeeList, ExportActualDailyAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyAccountTotalsFromDateToDateForEmployeeListResponse> ExportActualDailyAccountTotalsFromDateToDateForEmployeeListAsync(
      ExportActualDailyAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyAccountTotalsFromDateToDateForEmployeeList, ExportActualDailyAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyAccountTotalsFromPeriodForEmployeeListResponse ExportActualDailyAccountTotalsFromPeriodForEmployeeList(
      ExportActualDailyAccountTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyAccountTotalsFromPeriodForEmployeeList, ExportActualDailyAccountTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyAccountTotalsFromPeriodForEmployeeListResponse> ExportActualDailyAccountTotalsFromPeriodForEmployeeListAsync(
      ExportActualDailyAccountTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyAccountTotalsFromPeriodForEmployeeList, ExportActualDailyAccountTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeList(
      ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse> ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualAccountTotalsListFromDateForEmployeeListResponse ExportActualPerpetualAccountTotalsListFromDateForEmployeeList(
      ExportActualPerpetualAccountTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualAccountTotalsListFromDateForEmployeeList, ExportActualPerpetualAccountTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualAccountTotalsListFromDateForEmployeeListResponse> ExportActualPerpetualAccountTotalsListFromDateForEmployeeListAsync(
      ExportActualPerpetualAccountTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualAccountTotalsListFromDateForEmployeeList, ExportActualPerpetualAccountTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeListResponse ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeList(
      ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeListResponse> ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeListAsync(
      ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalAccountTotalsForEmployeeListResponse ExportActualPeriodicalAccountTotalsForEmployeeList(
      ExportActualPeriodicalAccountTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalAccountTotalsForEmployeeList, ExportActualPeriodicalAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalAccountTotalsForEmployeeListResponse> ExportActualPeriodicalAccountTotalsForEmployeeListAsync(
      ExportActualPeriodicalAccountTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalAccountTotalsForEmployeeList, ExportActualPeriodicalAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualAccountTotalsListForEmployeeListResponse ExportPlannedPerpetualAccountTotalsListForEmployeeList(
      ExportPlannedPerpetualAccountTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualAccountTotalsListForEmployeeList, ExportPlannedPerpetualAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualAccountTotalsListForEmployeeListResponse> ExportPlannedPerpetualAccountTotalsListForEmployeeListAsync(
      ExportPlannedPerpetualAccountTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualAccountTotalsListForEmployeeList, ExportPlannedPerpetualAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualAccountTotalsListForEmployeeListResponse ExportActualPerpetualAccountTotalsListForEmployeeList(
      ExportActualPerpetualAccountTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualAccountTotalsListForEmployeeList, ExportActualPerpetualAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualAccountTotalsListForEmployeeListResponse> ExportActualPerpetualAccountTotalsListForEmployeeListAsync(
      ExportActualPerpetualAccountTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualAccountTotalsListForEmployeeList, ExportActualPerpetualAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeListResponse ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeList(
      ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeList, ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeListResponse> ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeListAsync(
      ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeList, ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedAccountTotalsFromDateToDateForEmployeeListResponse ExportPlannedAccountTotalsFromDateToDateForEmployeeList(
      ExportPlannedAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedAccountTotalsFromDateToDateForEmployeeList, ExportPlannedAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedAccountTotalsFromDateToDateForEmployeeListResponse> ExportPlannedAccountTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedAccountTotalsFromDateToDateForEmployeeList, ExportPlannedAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualAccountTotalsFromDateToDateForEmployeeListResponse ExportActualAccountTotalsFromDateToDateForEmployeeList(
      ExportActualAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualAccountTotalsFromDateToDateForEmployeeList, ExportActualAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualAccountTotalsFromDateToDateForEmployeeListResponse> ExportActualAccountTotalsFromDateToDateForEmployeeListAsync(
      ExportActualAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualAccountTotalsFromDateToDateForEmployeeList, ExportActualAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeListResponse ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeList(
      ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeList, ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeList, ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeListResponse ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeList(
      ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeList, ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeListResponse> ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeList, ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyAccountTotalsForEmployeeListResponse ExportEstimatedWeeklyAccountTotalsForEmployeeList(
      ExportEstimatedWeeklyAccountTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyAccountTotalsForEmployeeList, ExportEstimatedWeeklyAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyAccountTotalsForEmployeeListResponse> ExportEstimatedWeeklyAccountTotalsForEmployeeListAsync(
      ExportEstimatedWeeklyAccountTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyAccountTotalsForEmployeeList, ExportEstimatedWeeklyAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyAccountTotalsForEmployeeListResponse ExportPlannedWeeklyAccountTotalsForEmployeeList(
      ExportPlannedWeeklyAccountTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyAccountTotalsForEmployeeList, ExportPlannedWeeklyAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyAccountTotalsForEmployeeListResponse> ExportPlannedWeeklyAccountTotalsForEmployeeListAsync(
      ExportPlannedWeeklyAccountTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyAccountTotalsForEmployeeList, ExportPlannedWeeklyAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyAccountTotalsListForEmployeeListResponse ExportActualWeeklyAccountTotalsListForEmployeeList(
      ExportActualWeeklyAccountTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyAccountTotalsListForEmployeeList, ExportActualWeeklyAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyAccountTotalsListForEmployeeListResponse> ExportActualWeeklyAccountTotalsListForEmployeeListAsync(
      ExportActualWeeklyAccountTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyAccountTotalsListForEmployeeList, ExportActualWeeklyAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyAccountTotalsForEmployeeListResponse ExportActualWeeklyAccountTotalsForEmployeeList(
      ExportActualWeeklyAccountTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyAccountTotalsForEmployeeList, ExportActualWeeklyAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyAccountTotalsForEmployeeListResponse> ExportActualWeeklyAccountTotalsForEmployeeListAsync(
      ExportActualWeeklyAccountTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyAccountTotalsForEmployeeList, ExportActualWeeklyAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeListResponse ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeList(
      ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeList, ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeListResponse> ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeListAsync(
      ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeList, ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeListResponse ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeList(
      ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeList, ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeListResponse> ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeList, ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyAccountTotalsFromPeriodForEmployeeListResponse ExportPlannedDailyAccountTotalsFromPeriodForEmployeeList(
      ExportPlannedDailyAccountTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyAccountTotalsFromPeriodForEmployeeList, ExportPlannedDailyAccountTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyAccountTotalsFromPeriodForEmployeeListResponse> ExportPlannedDailyAccountTotalsFromPeriodForEmployeeListAsync(
      ExportPlannedDailyAccountTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyAccountTotalsFromPeriodForEmployeeList, ExportPlannedDailyAccountTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalAccountTotalsForEmployeeListResponse ExportEstimatedPeriodicalAccountTotalsForEmployeeList(
      ExportEstimatedPeriodicalAccountTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalAccountTotalsForEmployeeList, ExportEstimatedPeriodicalAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalAccountTotalsForEmployeeListResponse> ExportEstimatedPeriodicalAccountTotalsForEmployeeListAsync(
      ExportEstimatedPeriodicalAccountTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalAccountTotalsForEmployeeList, ExportEstimatedPeriodicalAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeList(
      ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeList, ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse> ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeList, ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeList(
      ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse> ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualAccountTotalsFromRelativeDatesForEmployeeListResponse ExportActualAccountTotalsFromRelativeDatesForEmployeeList(
      ExportActualAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualAccountTotalsFromRelativeDatesForEmployeeList, ExportActualAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualAccountTotalsFromRelativeDatesForEmployeeListResponse> ExportActualAccountTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualAccountTotalsFromRelativeDatesForEmployeeList, ExportActualAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeList(
      ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalAccountTotalsForEmployeeListResponse ExportPlannedPeriodicalAccountTotalsForEmployeeList(
      ExportPlannedPeriodicalAccountTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalAccountTotalsForEmployeeList, ExportPlannedPeriodicalAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalAccountTotalsForEmployeeListResponse> ExportPlannedPeriodicalAccountTotalsForEmployeeListAsync(
      ExportPlannedPeriodicalAccountTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalAccountTotalsForEmployeeList, ExportPlannedPeriodicalAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedAccountTotalsFromDateToDateForEmployeeListResponse ExportEstimatedAccountTotalsFromDateToDateForEmployeeList(
      ExportEstimatedAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedAccountTotalsFromDateToDateForEmployeeList, ExportEstimatedAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedAccountTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedAccountTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedAccountTotalsFromDateToDateForEmployeeList, ExportEstimatedAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalAccountTotalsListForEmployeeListResponse ExportActualPeriodicalAccountTotalsListForEmployeeList(
      ExportActualPeriodicalAccountTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalAccountTotalsListForEmployeeList, ExportActualPeriodicalAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalAccountTotalsListForEmployeeListResponse> ExportActualPeriodicalAccountTotalsListForEmployeeListAsync(
      ExportActualPeriodicalAccountTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalAccountTotalsListForEmployeeList, ExportActualPeriodicalAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualAccountTotalsListForEmployeeListResponse ExportEstimatedPerpetualAccountTotalsListForEmployeeList(
      ExportEstimatedPerpetualAccountTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualAccountTotalsListForEmployeeList, ExportEstimatedPerpetualAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualAccountTotalsListForEmployeeListResponse> ExportEstimatedPerpetualAccountTotalsListForEmployeeListAsync(
      ExportEstimatedPerpetualAccountTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualAccountTotalsListForEmployeeList, ExportEstimatedPerpetualAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalAccountTotalsListForEmployeeListResponse ExportPlannedPeriodicalAccountTotalsListForEmployeeList(
      ExportPlannedPeriodicalAccountTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalAccountTotalsListForEmployeeList, ExportPlannedPeriodicalAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalAccountTotalsListForEmployeeListResponse> ExportPlannedPeriodicalAccountTotalsListForEmployeeListAsync(
      ExportPlannedPeriodicalAccountTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalAccountTotalsListForEmployeeList, ExportPlannedPeriodicalAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeList(
      ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedAccountTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedAccountTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedAccountTotalsFromRelativeDatesForEmployeeList, ExportPlannedAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedAccountTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedAccountTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedAccountTotalsFromRelativeDatesForEmployeeList, ExportPlannedAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeList, ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeList, ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyAccountTotalsListForEmployeeListResponse ExportEstimatedWeeklyAccountTotalsListForEmployeeList(
      ExportEstimatedWeeklyAccountTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyAccountTotalsListForEmployeeList, ExportEstimatedWeeklyAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyAccountTotalsListForEmployeeListResponse> ExportEstimatedWeeklyAccountTotalsListForEmployeeListAsync(
      ExportEstimatedWeeklyAccountTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyAccountTotalsListForEmployeeList, ExportEstimatedWeeklyAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyAccountTotalsListForEmployeeListResponse ExportPlannedWeeklyAccountTotalsListForEmployeeList(
      ExportPlannedWeeklyAccountTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyAccountTotalsListForEmployeeList, ExportPlannedWeeklyAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyAccountTotalsListForEmployeeListResponse> ExportPlannedWeeklyAccountTotalsListForEmployeeListAsync(
      ExportPlannedWeeklyAccountTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyAccountTotalsListForEmployeeList, ExportPlannedWeeklyAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalAccountTotalsListForEmployeeListResponse ExportEstimatedPeriodicalAccountTotalsListForEmployeeList(
      ExportEstimatedPeriodicalAccountTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalAccountTotalsListForEmployeeList, ExportEstimatedPeriodicalAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalAccountTotalsListForEmployeeListResponse> ExportEstimatedPeriodicalAccountTotalsListForEmployeeListAsync(
      ExportEstimatedPeriodicalAccountTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalAccountTotalsListForEmployeeList, ExportEstimatedPeriodicalAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalAccountTotalsResponse ExportPlannedPeriodicalAccountTotals(
      ExportPlannedPeriodicalAccountTotals arg)
    {
      return Client.Post<ExportPlannedPeriodicalAccountTotals, ExportPlannedPeriodicalAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalAccountTotalsResponse> ExportPlannedPeriodicalAccountTotalsAsync(
      ExportPlannedPeriodicalAccountTotals arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalAccountTotals, ExportPlannedPeriodicalAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalAccountTotalsListResponse ExportPlannedPeriodicalAccountTotalsList(
      ExportPlannedPeriodicalAccountTotalsList arg)
    {
      return Client.Post<ExportPlannedPeriodicalAccountTotalsList, ExportPlannedPeriodicalAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalAccountTotalsListResponse> ExportPlannedPeriodicalAccountTotalsListAsync(
      ExportPlannedPeriodicalAccountTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalAccountTotalsList, ExportPlannedPeriodicalAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalAccountTotalsListFromDateToDateResponse ExportPlannedPeriodicalAccountTotalsListFromDateToDate(
      ExportPlannedPeriodicalAccountTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedPeriodicalAccountTotalsListFromDateToDate, ExportPlannedPeriodicalAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalAccountTotalsListFromDateToDateResponse> ExportPlannedPeriodicalAccountTotalsListFromDateToDateAsync(
      ExportPlannedPeriodicalAccountTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalAccountTotalsListFromDateToDate, ExportPlannedPeriodicalAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualAccountTotalsFromRelativeDatesResponse ExportPlannedPerpetualAccountTotalsFromRelativeDates(
      ExportPlannedPerpetualAccountTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedPerpetualAccountTotalsFromRelativeDates, ExportPlannedPerpetualAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualAccountTotalsFromRelativeDatesResponse> ExportPlannedPerpetualAccountTotalsFromRelativeDatesAsync(
      ExportPlannedPerpetualAccountTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualAccountTotalsFromRelativeDates, ExportPlannedPerpetualAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualAccountTotalsListFromDateResponse ExportPlannedPerpetualAccountTotalsListFromDate(
      ExportPlannedPerpetualAccountTotalsListFromDate arg)
    {
      return Client.Post<ExportPlannedPerpetualAccountTotalsListFromDate, ExportPlannedPerpetualAccountTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualAccountTotalsListFromDateResponse> ExportPlannedPerpetualAccountTotalsListFromDateAsync(
      ExportPlannedPerpetualAccountTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualAccountTotalsListFromDate, ExportPlannedPerpetualAccountTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualAccountTotalsListResponse ExportPlannedPerpetualAccountTotalsList(
      ExportPlannedPerpetualAccountTotalsList arg)
    {
      return Client.Post<ExportPlannedPerpetualAccountTotalsList, ExportPlannedPerpetualAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualAccountTotalsListResponse> ExportPlannedPerpetualAccountTotalsListAsync(
      ExportPlannedPerpetualAccountTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualAccountTotalsList, ExportPlannedPerpetualAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalAccountTotalsListResponse ExportActualPeriodicalAccountTotalsList(
      ExportActualPeriodicalAccountTotalsList arg)
    {
      return Client.Post<ExportActualPeriodicalAccountTotalsList, ExportActualPeriodicalAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalAccountTotalsListResponse> ExportActualPeriodicalAccountTotalsListAsync(
      ExportActualPeriodicalAccountTotalsList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalAccountTotalsList, ExportActualPeriodicalAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalAccountTotalsListFromDateToDateResponse ExportActualPeriodicalAccountTotalsListFromDateToDate(
      ExportActualPeriodicalAccountTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualPeriodicalAccountTotalsListFromDateToDate, ExportActualPeriodicalAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalAccountTotalsListFromDateToDateResponse> ExportActualPeriodicalAccountTotalsListFromDateToDateAsync(
      ExportActualPeriodicalAccountTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualPeriodicalAccountTotalsListFromDateToDate, ExportActualPeriodicalAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalAccountTotalsResponse ExportActualPeriodicalAccountTotals(
      ExportActualPeriodicalAccountTotals arg)
    {
      return Client.Post<ExportActualPeriodicalAccountTotals, ExportActualPeriodicalAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalAccountTotalsResponse> ExportActualPeriodicalAccountTotalsAsync(
      ExportActualPeriodicalAccountTotals arg)
    {
      return Client.PostAsync<ExportActualPeriodicalAccountTotals, ExportActualPeriodicalAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualAccountTotalsListResponse ExportEstimatedPerpetualAccountTotalsList(
      ExportEstimatedPerpetualAccountTotalsList arg)
    {
      return Client.Post<ExportEstimatedPerpetualAccountTotalsList, ExportEstimatedPerpetualAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualAccountTotalsListResponse> ExportEstimatedPerpetualAccountTotalsListAsync(
      ExportEstimatedPerpetualAccountTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualAccountTotalsList, ExportEstimatedPerpetualAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualAccountTotalsListFromDateResponse ExportEstimatedPerpetualAccountTotalsListFromDate(
      ExportEstimatedPerpetualAccountTotalsListFromDate arg)
    {
      return Client.Post<ExportEstimatedPerpetualAccountTotalsListFromDate, ExportEstimatedPerpetualAccountTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualAccountTotalsListFromDateResponse> ExportEstimatedPerpetualAccountTotalsListFromDateAsync(
      ExportEstimatedPerpetualAccountTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualAccountTotalsListFromDate, ExportEstimatedPerpetualAccountTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualAccountTotalsFromRelativeDatesResponse ExportEstimatedPerpetualAccountTotalsFromRelativeDates(
      ExportEstimatedPerpetualAccountTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedPerpetualAccountTotalsFromRelativeDates, ExportEstimatedPerpetualAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualAccountTotalsFromRelativeDatesResponse> ExportEstimatedPerpetualAccountTotalsFromRelativeDatesAsync(
      ExportEstimatedPerpetualAccountTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualAccountTotalsFromRelativeDates, ExportEstimatedPerpetualAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedAccountTotalsFromDateToDateResponse ExportEstimatedAccountTotalsFromDateToDate(
      ExportEstimatedAccountTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedAccountTotalsFromDateToDate, ExportEstimatedAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedAccountTotalsFromDateToDateResponse> ExportEstimatedAccountTotalsFromDateToDateAsync(
      ExportEstimatedAccountTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedAccountTotalsFromDateToDate, ExportEstimatedAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedAccountTotalsFromRelativeDatesResponse ExportEstimatedAccountTotalsFromRelativeDates(
      ExportEstimatedAccountTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedAccountTotalsFromRelativeDates, ExportEstimatedAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedAccountTotalsFromRelativeDatesResponse> ExportEstimatedAccountTotalsFromRelativeDatesAsync(
      ExportEstimatedAccountTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedAccountTotalsFromRelativeDates, ExportEstimatedAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedAccountTotalsFromDateToDateResponse ExportPlannedAccountTotalsFromDateToDate(
      ExportPlannedAccountTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedAccountTotalsFromDateToDate, ExportPlannedAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedAccountTotalsFromDateToDateResponse> ExportPlannedAccountTotalsFromDateToDateAsync(
      ExportPlannedAccountTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedAccountTotalsFromDateToDate, ExportPlannedAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedAccountTotalsFromRelativeDatesResponse ExportPlannedAccountTotalsFromRelativeDates(
      ExportPlannedAccountTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedAccountTotalsFromRelativeDates, ExportPlannedAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedAccountTotalsFromRelativeDatesResponse> ExportPlannedAccountTotalsFromRelativeDatesAsync(
      ExportPlannedAccountTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedAccountTotalsFromRelativeDates, ExportPlannedAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportDailyAccountTotalsResponse ExportDailyAccountTotals(
      ExportDailyAccountTotals arg)
    {
      return Client.Post<ExportDailyAccountTotals, ExportDailyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportDailyAccountTotalsResponse> ExportDailyAccountTotalsAsync(
      ExportDailyAccountTotals arg)
    {
      return Client.PostAsync<ExportDailyAccountTotals, ExportDailyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPeriodicalAccountTotalsResponse ExportPeriodicalAccountTotals(
      ExportPeriodicalAccountTotals arg)
    {
      return Client.Post<ExportPeriodicalAccountTotals, ExportPeriodicalAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPeriodicalAccountTotalsResponse> ExportPeriodicalAccountTotalsAsync(
      ExportPeriodicalAccountTotals arg)
    {
      return Client.PostAsync<ExportPeriodicalAccountTotals, ExportPeriodicalAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPerpetualAccountTotalsResponse ExportPerpetualAccountTotals(
      ExportPerpetualAccountTotals arg)
    {
      return Client.Post<ExportPerpetualAccountTotals, ExportPerpetualAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPerpetualAccountTotalsResponse> ExportPerpetualAccountTotalsAsync(
      ExportPerpetualAccountTotals arg)
    {
      return Client.PostAsync<ExportPerpetualAccountTotals, ExportPerpetualAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyAccountTotalsFromDateToDateResponse ExportEstimatedDailyAccountTotalsFromDateToDate(
      ExportEstimatedDailyAccountTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedDailyAccountTotalsFromDateToDate, ExportEstimatedDailyAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyAccountTotalsFromDateToDateResponse> ExportEstimatedDailyAccountTotalsFromDateToDateAsync(
      ExportEstimatedDailyAccountTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedDailyAccountTotalsFromDateToDate, ExportEstimatedDailyAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyAccountTotalsFromPeriodResponse ExportEstimatedDailyAccountTotalsFromPeriod(
      ExportEstimatedDailyAccountTotalsFromPeriod arg)
    {
      return Client.Post<ExportEstimatedDailyAccountTotalsFromPeriod, ExportEstimatedDailyAccountTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyAccountTotalsFromPeriodResponse> ExportEstimatedDailyAccountTotalsFromPeriodAsync(
      ExportEstimatedDailyAccountTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportEstimatedDailyAccountTotalsFromPeriod, ExportEstimatedDailyAccountTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyAccountTotalsFromRelativeDatesResponse ExportEstimatedDailyAccountTotalsFromRelativeDates(
      ExportEstimatedDailyAccountTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedDailyAccountTotalsFromRelativeDates, ExportEstimatedDailyAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyAccountTotalsFromRelativeDatesResponse> ExportEstimatedDailyAccountTotalsFromRelativeDatesAsync(
      ExportEstimatedDailyAccountTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedDailyAccountTotalsFromRelativeDates, ExportEstimatedDailyAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyAccountTotalsListResponse ExportActualWeeklyAccountTotalsList(
      ExportActualWeeklyAccountTotalsList arg)
    {
      return Client.Post<ExportActualWeeklyAccountTotalsList, ExportActualWeeklyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyAccountTotalsListResponse> ExportActualWeeklyAccountTotalsListAsync(
      ExportActualWeeklyAccountTotalsList arg)
    {
      return Client.PostAsync<ExportActualWeeklyAccountTotalsList, ExportActualWeeklyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyAccountTotalsListFromDateToDateResponse ExportActualWeeklyAccountTotalsListFromDateToDate(
      ExportActualWeeklyAccountTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualWeeklyAccountTotalsListFromDateToDate, ExportActualWeeklyAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyAccountTotalsListFromDateToDateResponse> ExportActualWeeklyAccountTotalsListFromDateToDateAsync(
      ExportActualWeeklyAccountTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualWeeklyAccountTotalsListFromDateToDate, ExportActualWeeklyAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyAccountTotalsResponse ExportActualWeeklyAccountTotals(
      ExportActualWeeklyAccountTotals arg)
    {
      return Client.Post<ExportActualWeeklyAccountTotals, ExportActualWeeklyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyAccountTotalsResponse> ExportActualWeeklyAccountTotalsAsync(
      ExportActualWeeklyAccountTotals arg)
    {
      return Client.PostAsync<ExportActualWeeklyAccountTotals, ExportActualWeeklyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyAccountTotalsFromPeriodResponse ExportPlannedDailyAccountTotalsFromPeriod(
      ExportPlannedDailyAccountTotalsFromPeriod arg)
    {
      return Client.Post<ExportPlannedDailyAccountTotalsFromPeriod, ExportPlannedDailyAccountTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyAccountTotalsFromPeriodResponse> ExportPlannedDailyAccountTotalsFromPeriodAsync(
      ExportPlannedDailyAccountTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportPlannedDailyAccountTotalsFromPeriod, ExportPlannedDailyAccountTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyAccountTotalsFromRelativeDatesResponse ExportPlannedDailyAccountTotalsFromRelativeDates(
      ExportPlannedDailyAccountTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedDailyAccountTotalsFromRelativeDates, ExportPlannedDailyAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyAccountTotalsFromRelativeDatesResponse> ExportPlannedDailyAccountTotalsFromRelativeDatesAsync(
      ExportPlannedDailyAccountTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedDailyAccountTotalsFromRelativeDates, ExportPlannedDailyAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyAccountTotalsFromDateToDateResponse ExportPlannedDailyAccountTotalsFromDateToDate(
      ExportPlannedDailyAccountTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedDailyAccountTotalsFromDateToDate, ExportPlannedDailyAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyAccountTotalsFromDateToDateResponse> ExportPlannedDailyAccountTotalsFromDateToDateAsync(
      ExportPlannedDailyAccountTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedDailyAccountTotalsFromDateToDate, ExportPlannedDailyAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyAccountTotalsFromPeriodResponse ExportActualDailyAccountTotalsFromPeriod(
      ExportActualDailyAccountTotalsFromPeriod arg)
    {
      return Client.Post<ExportActualDailyAccountTotalsFromPeriod, ExportActualDailyAccountTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyAccountTotalsFromPeriodResponse> ExportActualDailyAccountTotalsFromPeriodAsync(
      ExportActualDailyAccountTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportActualDailyAccountTotalsFromPeriod, ExportActualDailyAccountTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyAccountTotalsFromDateToDateResponse ExportActualDailyAccountTotalsFromDateToDate(
      ExportActualDailyAccountTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualDailyAccountTotalsFromDateToDate, ExportActualDailyAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyAccountTotalsFromDateToDateResponse> ExportActualDailyAccountTotalsFromDateToDateAsync(
      ExportActualDailyAccountTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualDailyAccountTotalsFromDateToDate, ExportActualDailyAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyAccountTotalsFromRelativeDatesResponse ExportActualDailyAccountTotalsFromRelativeDates(
      ExportActualDailyAccountTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualDailyAccountTotalsFromRelativeDates, ExportActualDailyAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyAccountTotalsFromRelativeDatesResponse> ExportActualDailyAccountTotalsFromRelativeDatesAsync(
      ExportActualDailyAccountTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualDailyAccountTotalsFromRelativeDates, ExportActualDailyAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyAccountTotalsResponse ExportPlannedWeeklyAccountTotals(
      ExportPlannedWeeklyAccountTotals arg)
    {
      return Client.Post<ExportPlannedWeeklyAccountTotals, ExportPlannedWeeklyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyAccountTotalsResponse> ExportPlannedWeeklyAccountTotalsAsync(
      ExportPlannedWeeklyAccountTotals arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyAccountTotals, ExportPlannedWeeklyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyAccountTotalsListFromDateToDateResponse ExportPlannedWeeklyAccountTotalsListFromDateToDate(
      ExportPlannedWeeklyAccountTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedWeeklyAccountTotalsListFromDateToDate, ExportPlannedWeeklyAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyAccountTotalsListFromDateToDateResponse> ExportPlannedWeeklyAccountTotalsListFromDateToDateAsync(
      ExportPlannedWeeklyAccountTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyAccountTotalsListFromDateToDate, ExportPlannedWeeklyAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyAccountTotalsListResponse ExportPlannedWeeklyAccountTotalsList(
      ExportPlannedWeeklyAccountTotalsList arg)
    {
      return Client.Post<ExportPlannedWeeklyAccountTotalsList, ExportPlannedWeeklyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyAccountTotalsListResponse> ExportPlannedWeeklyAccountTotalsListAsync(
      ExportPlannedWeeklyAccountTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyAccountTotalsList, ExportPlannedWeeklyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalAccountTotalsListResponse ExportEstimatedPeriodicalAccountTotalsList(
      ExportEstimatedPeriodicalAccountTotalsList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalAccountTotalsList, ExportEstimatedPeriodicalAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalAccountTotalsListResponse> ExportEstimatedPeriodicalAccountTotalsListAsync(
      ExportEstimatedPeriodicalAccountTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalAccountTotalsList, ExportEstimatedPeriodicalAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalAccountTotalsListFromDateToDateResponse ExportEstimatedPeriodicalAccountTotalsListFromDateToDate(
      ExportEstimatedPeriodicalAccountTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedPeriodicalAccountTotalsListFromDateToDate, ExportEstimatedPeriodicalAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalAccountTotalsListFromDateToDateResponse> ExportEstimatedPeriodicalAccountTotalsListFromDateToDateAsync(
      ExportEstimatedPeriodicalAccountTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalAccountTotalsListFromDateToDate, ExportEstimatedPeriodicalAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalAccountTotalsResponse ExportEstimatedPeriodicalAccountTotals(
      ExportEstimatedPeriodicalAccountTotals arg)
    {
      return Client.Post<ExportEstimatedPeriodicalAccountTotals, ExportEstimatedPeriodicalAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalAccountTotalsResponse> ExportEstimatedPeriodicalAccountTotalsAsync(
      ExportEstimatedPeriodicalAccountTotals arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalAccountTotals, ExportEstimatedPeriodicalAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyAccountTotalsListResponse ExportEstimatedWeeklyAccountTotalsList(
      ExportEstimatedWeeklyAccountTotalsList arg)
    {
      return Client.Post<ExportEstimatedWeeklyAccountTotalsList, ExportEstimatedWeeklyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyAccountTotalsListResponse> ExportEstimatedWeeklyAccountTotalsListAsync(
      ExportEstimatedWeeklyAccountTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyAccountTotalsList, ExportEstimatedWeeklyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyAccountTotalsResponse ExportEstimatedWeeklyAccountTotals(
      ExportEstimatedWeeklyAccountTotals arg)
    {
      return Client.Post<ExportEstimatedWeeklyAccountTotals, ExportEstimatedWeeklyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyAccountTotalsResponse> ExportEstimatedWeeklyAccountTotalsAsync(
      ExportEstimatedWeeklyAccountTotals arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyAccountTotals, ExportEstimatedWeeklyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyAccountTotalsListFromDateToDateResponse ExportEstimatedWeeklyAccountTotalsListFromDateToDate(
      ExportEstimatedWeeklyAccountTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedWeeklyAccountTotalsListFromDateToDate, ExportEstimatedWeeklyAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyAccountTotalsListFromDateToDateResponse> ExportEstimatedWeeklyAccountTotalsListFromDateToDateAsync(
      ExportEstimatedWeeklyAccountTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyAccountTotalsListFromDateToDate, ExportEstimatedWeeklyAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualAccountTotalsFromDateToDateResponse ExportActualAccountTotalsFromDateToDate(
      ExportActualAccountTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualAccountTotalsFromDateToDate, ExportActualAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualAccountTotalsFromDateToDateResponse> ExportActualAccountTotalsFromDateToDateAsync(
      ExportActualAccountTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualAccountTotalsFromDateToDate, ExportActualAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualAccountTotalsFromRelativeDatesResponse ExportActualAccountTotalsFromRelativeDates(
      ExportActualAccountTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualAccountTotalsFromRelativeDates, ExportActualAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualAccountTotalsFromRelativeDatesResponse> ExportActualAccountTotalsFromRelativeDatesAsync(
      ExportActualAccountTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualAccountTotalsFromRelativeDates, ExportActualAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualAccountTotalsListFromDateResponse ExportActualPerpetualAccountTotalsListFromDate(
      ExportActualPerpetualAccountTotalsListFromDate arg)
    {
      return Client.Post<ExportActualPerpetualAccountTotalsListFromDate, ExportActualPerpetualAccountTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualAccountTotalsListFromDateResponse> ExportActualPerpetualAccountTotalsListFromDateAsync(
      ExportActualPerpetualAccountTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportActualPerpetualAccountTotalsListFromDate, ExportActualPerpetualAccountTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualAccountTotalsListResponse ExportActualPerpetualAccountTotalsList(
      ExportActualPerpetualAccountTotalsList arg)
    {
      return Client.Post<ExportActualPerpetualAccountTotalsList, ExportActualPerpetualAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualAccountTotalsListResponse> ExportActualPerpetualAccountTotalsListAsync(
      ExportActualPerpetualAccountTotalsList arg)
    {
      return Client.PostAsync<ExportActualPerpetualAccountTotalsList, ExportActualPerpetualAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualAccountTotalsFromRelativeDatesResponse ExportActualPerpetualAccountTotalsFromRelativeDates(
      ExportActualPerpetualAccountTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualPerpetualAccountTotalsFromRelativeDates, ExportActualPerpetualAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualAccountTotalsFromRelativeDatesResponse> ExportActualPerpetualAccountTotalsFromRelativeDatesAsync(
      ExportActualPerpetualAccountTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualPerpetualAccountTotalsFromRelativeDates, ExportActualPerpetualAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportWeeklyAccountTotalsListResponse ExportWeeklyAccountTotalsList(
      ExportWeeklyAccountTotalsList arg)
    {
      return Client.Post<ExportWeeklyAccountTotalsList, ExportWeeklyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportWeeklyAccountTotalsListResponse> ExportWeeklyAccountTotalsListAsync(
      ExportWeeklyAccountTotalsList arg)
    {
      return Client.PostAsync<ExportWeeklyAccountTotalsList, ExportWeeklyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportDailyAccountTotalsListResponse ExportDailyAccountTotalsList(
      ExportDailyAccountTotalsList arg)
    {
      return Client.Post<ExportDailyAccountTotalsList, ExportDailyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportDailyAccountTotalsListResponse> ExportDailyAccountTotalsListAsync(
      ExportDailyAccountTotalsList arg)
    {
      return Client.PostAsync<ExportDailyAccountTotalsList, ExportDailyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPerpetualAccountTotalsListResponse ExportPerpetualAccountTotalsList(
      ExportPerpetualAccountTotalsList arg)
    {
      return Client.Post<ExportPerpetualAccountTotalsList, ExportPerpetualAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPerpetualAccountTotalsListResponse> ExportPerpetualAccountTotalsListAsync(
      ExportPerpetualAccountTotalsList arg)
    {
      return Client.PostAsync<ExportPerpetualAccountTotalsList, ExportPerpetualAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportWeeklyAccountTotalsResponse ExportWeeklyAccountTotals(
      ExportWeeklyAccountTotals arg)
    {
      return Client.Post<ExportWeeklyAccountTotals, ExportWeeklyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportWeeklyAccountTotalsResponse> ExportWeeklyAccountTotalsAsync(
      ExportWeeklyAccountTotals arg)
    {
      return Client.PostAsync<ExportWeeklyAccountTotals, ExportWeeklyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public ExportPeriodicalAccountTotalsListResponse ExportPeriodicalAccountTotalsList(
      ExportPeriodicalAccountTotalsList arg)
    {
      return Client.Post<ExportPeriodicalAccountTotalsList, ExportPeriodicalAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPeriodicalAccountTotalsListResponse> ExportPeriodicalAccountTotalsListAsync(
      ExportPeriodicalAccountTotalsList arg)
    {
      return Client.PostAsync<ExportPeriodicalAccountTotalsList, ExportPeriodicalAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg, this.timeoutSeconds);
    }
  }
}
