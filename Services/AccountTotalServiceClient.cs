
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
    private readonly string baseuri;

    public AccountTotalServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportActualDailyAccountTotalsFromDateToDateForEmployeeListResponse ExportActualDailyAccountTotalsFromDateToDateForEmployeeList(
      ExportActualDailyAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyAccountTotalsFromDateToDateForEmployeeList, ExportActualDailyAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualDailyAccountTotalsFromDateToDateForEmployeeListResponse> ExportActualDailyAccountTotalsFromDateToDateForEmployeeListAsync(
      ExportActualDailyAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyAccountTotalsFromDateToDateForEmployeeList, ExportActualDailyAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualDailyAccountTotalsFromPeriodForEmployeeListResponse ExportActualDailyAccountTotalsFromPeriodForEmployeeList(
      ExportActualDailyAccountTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyAccountTotalsFromPeriodForEmployeeList, ExportActualDailyAccountTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualDailyAccountTotalsFromPeriodForEmployeeListResponse> ExportActualDailyAccountTotalsFromPeriodForEmployeeListAsync(
      ExportActualDailyAccountTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyAccountTotalsFromPeriodForEmployeeList, ExportActualDailyAccountTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeList(
      ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse> ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualPerpetualAccountTotalsListFromDateForEmployeeListResponse ExportActualPerpetualAccountTotalsListFromDateForEmployeeList(
      ExportActualPerpetualAccountTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualAccountTotalsListFromDateForEmployeeList, ExportActualPerpetualAccountTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualPerpetualAccountTotalsListFromDateForEmployeeListResponse> ExportActualPerpetualAccountTotalsListFromDateForEmployeeListAsync(
      ExportActualPerpetualAccountTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualAccountTotalsListFromDateForEmployeeList, ExportActualPerpetualAccountTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeListResponse ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeList(
      ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeListResponse> ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeListAsync(
      ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualAccountTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualPeriodicalAccountTotalsForEmployeeListResponse ExportActualPeriodicalAccountTotalsForEmployeeList(
      ExportActualPeriodicalAccountTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalAccountTotalsForEmployeeList, ExportActualPeriodicalAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualPeriodicalAccountTotalsForEmployeeListResponse> ExportActualPeriodicalAccountTotalsForEmployeeListAsync(
      ExportActualPeriodicalAccountTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalAccountTotalsForEmployeeList, ExportActualPeriodicalAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedPerpetualAccountTotalsListForEmployeeListResponse ExportPlannedPerpetualAccountTotalsListForEmployeeList(
      ExportPlannedPerpetualAccountTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualAccountTotalsListForEmployeeList, ExportPlannedPerpetualAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedPerpetualAccountTotalsListForEmployeeListResponse> ExportPlannedPerpetualAccountTotalsListForEmployeeListAsync(
      ExportPlannedPerpetualAccountTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualAccountTotalsListForEmployeeList, ExportPlannedPerpetualAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualPerpetualAccountTotalsListForEmployeeListResponse ExportActualPerpetualAccountTotalsListForEmployeeList(
      ExportActualPerpetualAccountTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualAccountTotalsListForEmployeeList, ExportActualPerpetualAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualPerpetualAccountTotalsListForEmployeeListResponse> ExportActualPerpetualAccountTotalsListForEmployeeListAsync(
      ExportActualPerpetualAccountTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualAccountTotalsListForEmployeeList, ExportActualPerpetualAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeListResponse ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeList(
      ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeList, ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeListResponse> ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeListAsync(
      ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeList, ExportPlannedPerpetualAccountTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedAccountTotalsFromDateToDateForEmployeeListResponse ExportPlannedAccountTotalsFromDateToDateForEmployeeList(
      ExportPlannedAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedAccountTotalsFromDateToDateForEmployeeList, ExportPlannedAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedAccountTotalsFromDateToDateForEmployeeListResponse> ExportPlannedAccountTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedAccountTotalsFromDateToDateForEmployeeList, ExportPlannedAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualAccountTotalsFromDateToDateForEmployeeListResponse ExportActualAccountTotalsFromDateToDateForEmployeeList(
      ExportActualAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualAccountTotalsFromDateToDateForEmployeeList, ExportActualAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualAccountTotalsFromDateToDateForEmployeeListResponse> ExportActualAccountTotalsFromDateToDateForEmployeeListAsync(
      ExportActualAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualAccountTotalsFromDateToDateForEmployeeList, ExportActualAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeListResponse ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeList(
      ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeList, ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeList, ExportEstimatedDailyAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeListResponse ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeList(
      ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeList, ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeListResponse> ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeList, ExportActualDailyAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedWeeklyAccountTotalsForEmployeeListResponse ExportEstimatedWeeklyAccountTotalsForEmployeeList(
      ExportEstimatedWeeklyAccountTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyAccountTotalsForEmployeeList, ExportEstimatedWeeklyAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyAccountTotalsForEmployeeListResponse> ExportEstimatedWeeklyAccountTotalsForEmployeeListAsync(
      ExportEstimatedWeeklyAccountTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyAccountTotalsForEmployeeList, ExportEstimatedWeeklyAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedWeeklyAccountTotalsForEmployeeListResponse ExportPlannedWeeklyAccountTotalsForEmployeeList(
      ExportPlannedWeeklyAccountTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyAccountTotalsForEmployeeList, ExportPlannedWeeklyAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedWeeklyAccountTotalsForEmployeeListResponse> ExportPlannedWeeklyAccountTotalsForEmployeeListAsync(
      ExportPlannedWeeklyAccountTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyAccountTotalsForEmployeeList, ExportPlannedWeeklyAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualWeeklyAccountTotalsListForEmployeeListResponse ExportActualWeeklyAccountTotalsListForEmployeeList(
      ExportActualWeeklyAccountTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyAccountTotalsListForEmployeeList, ExportActualWeeklyAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualWeeklyAccountTotalsListForEmployeeListResponse> ExportActualWeeklyAccountTotalsListForEmployeeListAsync(
      ExportActualWeeklyAccountTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyAccountTotalsListForEmployeeList, ExportActualWeeklyAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualWeeklyAccountTotalsForEmployeeListResponse ExportActualWeeklyAccountTotalsForEmployeeList(
      ExportActualWeeklyAccountTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyAccountTotalsForEmployeeList, ExportActualWeeklyAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualWeeklyAccountTotalsForEmployeeListResponse> ExportActualWeeklyAccountTotalsForEmployeeListAsync(
      ExportActualWeeklyAccountTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyAccountTotalsForEmployeeList, ExportActualWeeklyAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailyAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeListResponse ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeList(
      ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeList, ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeListResponse> ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeListAsync(
      ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeList, ExportEstimatedDailyAccountTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeListResponse ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeList(
      ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeList, ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeListResponse> ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeList, ExportPlannedDailyAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedDailyAccountTotalsFromPeriodForEmployeeListResponse ExportPlannedDailyAccountTotalsFromPeriodForEmployeeList(
      ExportPlannedDailyAccountTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyAccountTotalsFromPeriodForEmployeeList, ExportPlannedDailyAccountTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedDailyAccountTotalsFromPeriodForEmployeeListResponse> ExportPlannedDailyAccountTotalsFromPeriodForEmployeeListAsync(
      ExportPlannedDailyAccountTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyAccountTotalsFromPeriodForEmployeeList, ExportPlannedDailyAccountTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedPeriodicalAccountTotalsForEmployeeListResponse ExportEstimatedPeriodicalAccountTotalsForEmployeeList(
      ExportEstimatedPeriodicalAccountTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalAccountTotalsForEmployeeList, ExportEstimatedPeriodicalAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalAccountTotalsForEmployeeListResponse> ExportEstimatedPeriodicalAccountTotalsForEmployeeListAsync(
      ExportEstimatedPeriodicalAccountTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalAccountTotalsForEmployeeList, ExportEstimatedPeriodicalAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeList(
      ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeList, ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse> ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeList, ExportActualWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeList(
      ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse> ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualAccountTotalsFromRelativeDatesForEmployeeListResponse ExportActualAccountTotalsFromRelativeDatesForEmployeeList(
      ExportActualAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualAccountTotalsFromRelativeDatesForEmployeeList, ExportActualAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualAccountTotalsFromRelativeDatesForEmployeeListResponse> ExportActualAccountTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualAccountTotalsFromRelativeDatesForEmployeeList, ExportActualAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeList(
      ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklyAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedPeriodicalAccountTotalsForEmployeeListResponse ExportPlannedPeriodicalAccountTotalsForEmployeeList(
      ExportPlannedPeriodicalAccountTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalAccountTotalsForEmployeeList, ExportPlannedPeriodicalAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalAccountTotalsForEmployeeListResponse> ExportPlannedPeriodicalAccountTotalsForEmployeeListAsync(
      ExportPlannedPeriodicalAccountTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalAccountTotalsForEmployeeList, ExportPlannedPeriodicalAccountTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedAccountTotalsFromDateToDateForEmployeeListResponse ExportEstimatedAccountTotalsFromDateToDateForEmployeeList(
      ExportEstimatedAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedAccountTotalsFromDateToDateForEmployeeList, ExportEstimatedAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedAccountTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedAccountTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedAccountTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedAccountTotalsFromDateToDateForEmployeeList, ExportEstimatedAccountTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualPeriodicalAccountTotalsListForEmployeeListResponse ExportActualPeriodicalAccountTotalsListForEmployeeList(
      ExportActualPeriodicalAccountTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalAccountTotalsListForEmployeeList, ExportActualPeriodicalAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualPeriodicalAccountTotalsListForEmployeeListResponse> ExportActualPeriodicalAccountTotalsListForEmployeeListAsync(
      ExportActualPeriodicalAccountTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalAccountTotalsListForEmployeeList, ExportActualPeriodicalAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedPerpetualAccountTotalsListForEmployeeListResponse ExportEstimatedPerpetualAccountTotalsListForEmployeeList(
      ExportEstimatedPerpetualAccountTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualAccountTotalsListForEmployeeList, ExportEstimatedPerpetualAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualAccountTotalsListForEmployeeListResponse> ExportEstimatedPerpetualAccountTotalsListForEmployeeListAsync(
      ExportEstimatedPerpetualAccountTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualAccountTotalsListForEmployeeList, ExportEstimatedPerpetualAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedPeriodicalAccountTotalsListForEmployeeListResponse ExportPlannedPeriodicalAccountTotalsListForEmployeeList(
      ExportPlannedPeriodicalAccountTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalAccountTotalsListForEmployeeList, ExportPlannedPeriodicalAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalAccountTotalsListForEmployeeListResponse> ExportPlannedPeriodicalAccountTotalsListForEmployeeListAsync(
      ExportPlannedPeriodicalAccountTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalAccountTotalsListForEmployeeList, ExportPlannedPeriodicalAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeList(
      ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalAccountTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedAccountTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedAccountTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedAccountTotalsFromRelativeDatesForEmployeeList, ExportPlannedAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedAccountTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedAccountTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedAccountTotalsFromRelativeDatesForEmployeeList, ExportPlannedAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeList, ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeList, ExportEstimatedAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedWeeklyAccountTotalsListForEmployeeListResponse ExportEstimatedWeeklyAccountTotalsListForEmployeeList(
      ExportEstimatedWeeklyAccountTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyAccountTotalsListForEmployeeList, ExportEstimatedWeeklyAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyAccountTotalsListForEmployeeListResponse> ExportEstimatedWeeklyAccountTotalsListForEmployeeListAsync(
      ExportEstimatedWeeklyAccountTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyAccountTotalsListForEmployeeList, ExportEstimatedWeeklyAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedWeeklyAccountTotalsListForEmployeeListResponse ExportPlannedWeeklyAccountTotalsListForEmployeeList(
      ExportPlannedWeeklyAccountTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyAccountTotalsListForEmployeeList, ExportPlannedWeeklyAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedWeeklyAccountTotalsListForEmployeeListResponse> ExportPlannedWeeklyAccountTotalsListForEmployeeListAsync(
      ExportPlannedWeeklyAccountTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyAccountTotalsListForEmployeeList, ExportPlannedWeeklyAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedPeriodicalAccountTotalsListForEmployeeListResponse ExportEstimatedPeriodicalAccountTotalsListForEmployeeList(
      ExportEstimatedPeriodicalAccountTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalAccountTotalsListForEmployeeList, ExportEstimatedPeriodicalAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalAccountTotalsListForEmployeeListResponse> ExportEstimatedPeriodicalAccountTotalsListForEmployeeListAsync(
      ExportEstimatedPeriodicalAccountTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalAccountTotalsListForEmployeeList, ExportEstimatedPeriodicalAccountTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailyAccountTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedPeriodicalAccountTotalsResponse ExportPlannedPeriodicalAccountTotals(
      ExportPlannedPeriodicalAccountTotals arg)
    {
      return Client.Post<ExportPlannedPeriodicalAccountTotals, ExportPlannedPeriodicalAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalAccountTotalsResponse> ExportPlannedPeriodicalAccountTotalsAsync(
      ExportPlannedPeriodicalAccountTotals arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalAccountTotals, ExportPlannedPeriodicalAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedPeriodicalAccountTotalsListResponse ExportPlannedPeriodicalAccountTotalsList(
      ExportPlannedPeriodicalAccountTotalsList arg)
    {
      return Client.Post<ExportPlannedPeriodicalAccountTotalsList, ExportPlannedPeriodicalAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalAccountTotalsListResponse> ExportPlannedPeriodicalAccountTotalsListAsync(
      ExportPlannedPeriodicalAccountTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalAccountTotalsList, ExportPlannedPeriodicalAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedPeriodicalAccountTotalsListFromDateToDateResponse ExportPlannedPeriodicalAccountTotalsListFromDateToDate(
      ExportPlannedPeriodicalAccountTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedPeriodicalAccountTotalsListFromDateToDate, ExportPlannedPeriodicalAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalAccountTotalsListFromDateToDateResponse> ExportPlannedPeriodicalAccountTotalsListFromDateToDateAsync(
      ExportPlannedPeriodicalAccountTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalAccountTotalsListFromDateToDate, ExportPlannedPeriodicalAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedPerpetualAccountTotalsFromRelativeDatesResponse ExportPlannedPerpetualAccountTotalsFromRelativeDates(
      ExportPlannedPerpetualAccountTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedPerpetualAccountTotalsFromRelativeDates, ExportPlannedPerpetualAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedPerpetualAccountTotalsFromRelativeDatesResponse> ExportPlannedPerpetualAccountTotalsFromRelativeDatesAsync(
      ExportPlannedPerpetualAccountTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualAccountTotalsFromRelativeDates, ExportPlannedPerpetualAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedPerpetualAccountTotalsListFromDateResponse ExportPlannedPerpetualAccountTotalsListFromDate(
      ExportPlannedPerpetualAccountTotalsListFromDate arg)
    {
      return Client.Post<ExportPlannedPerpetualAccountTotalsListFromDate, ExportPlannedPerpetualAccountTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedPerpetualAccountTotalsListFromDateResponse> ExportPlannedPerpetualAccountTotalsListFromDateAsync(
      ExportPlannedPerpetualAccountTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualAccountTotalsListFromDate, ExportPlannedPerpetualAccountTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedPerpetualAccountTotalsListResponse ExportPlannedPerpetualAccountTotalsList(
      ExportPlannedPerpetualAccountTotalsList arg)
    {
      return Client.Post<ExportPlannedPerpetualAccountTotalsList, ExportPlannedPerpetualAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedPerpetualAccountTotalsListResponse> ExportPlannedPerpetualAccountTotalsListAsync(
      ExportPlannedPerpetualAccountTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualAccountTotalsList, ExportPlannedPerpetualAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualPeriodicalAccountTotalsListResponse ExportActualPeriodicalAccountTotalsList(
      ExportActualPeriodicalAccountTotalsList arg)
    {
      return Client.Post<ExportActualPeriodicalAccountTotalsList, ExportActualPeriodicalAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualPeriodicalAccountTotalsListResponse> ExportActualPeriodicalAccountTotalsListAsync(
      ExportActualPeriodicalAccountTotalsList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalAccountTotalsList, ExportActualPeriodicalAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualPeriodicalAccountTotalsListFromDateToDateResponse ExportActualPeriodicalAccountTotalsListFromDateToDate(
      ExportActualPeriodicalAccountTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualPeriodicalAccountTotalsListFromDateToDate, ExportActualPeriodicalAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualPeriodicalAccountTotalsListFromDateToDateResponse> ExportActualPeriodicalAccountTotalsListFromDateToDateAsync(
      ExportActualPeriodicalAccountTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualPeriodicalAccountTotalsListFromDateToDate, ExportActualPeriodicalAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualPeriodicalAccountTotalsResponse ExportActualPeriodicalAccountTotals(
      ExportActualPeriodicalAccountTotals arg)
    {
      return Client.Post<ExportActualPeriodicalAccountTotals, ExportActualPeriodicalAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualPeriodicalAccountTotalsResponse> ExportActualPeriodicalAccountTotalsAsync(
      ExportActualPeriodicalAccountTotals arg)
    {
      return Client.PostAsync<ExportActualPeriodicalAccountTotals, ExportActualPeriodicalAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedPerpetualAccountTotalsListResponse ExportEstimatedPerpetualAccountTotalsList(
      ExportEstimatedPerpetualAccountTotalsList arg)
    {
      return Client.Post<ExportEstimatedPerpetualAccountTotalsList, ExportEstimatedPerpetualAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualAccountTotalsListResponse> ExportEstimatedPerpetualAccountTotalsListAsync(
      ExportEstimatedPerpetualAccountTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualAccountTotalsList, ExportEstimatedPerpetualAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedPerpetualAccountTotalsListFromDateResponse ExportEstimatedPerpetualAccountTotalsListFromDate(
      ExportEstimatedPerpetualAccountTotalsListFromDate arg)
    {
      return Client.Post<ExportEstimatedPerpetualAccountTotalsListFromDate, ExportEstimatedPerpetualAccountTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualAccountTotalsListFromDateResponse> ExportEstimatedPerpetualAccountTotalsListFromDateAsync(
      ExportEstimatedPerpetualAccountTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualAccountTotalsListFromDate, ExportEstimatedPerpetualAccountTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedPerpetualAccountTotalsFromRelativeDatesResponse ExportEstimatedPerpetualAccountTotalsFromRelativeDates(
      ExportEstimatedPerpetualAccountTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedPerpetualAccountTotalsFromRelativeDates, ExportEstimatedPerpetualAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualAccountTotalsFromRelativeDatesResponse> ExportEstimatedPerpetualAccountTotalsFromRelativeDatesAsync(
      ExportEstimatedPerpetualAccountTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualAccountTotalsFromRelativeDates, ExportEstimatedPerpetualAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedAccountTotalsFromDateToDateResponse ExportEstimatedAccountTotalsFromDateToDate(
      ExportEstimatedAccountTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedAccountTotalsFromDateToDate, ExportEstimatedAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedAccountTotalsFromDateToDateResponse> ExportEstimatedAccountTotalsFromDateToDateAsync(
      ExportEstimatedAccountTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedAccountTotalsFromDateToDate, ExportEstimatedAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedAccountTotalsFromRelativeDatesResponse ExportEstimatedAccountTotalsFromRelativeDates(
      ExportEstimatedAccountTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedAccountTotalsFromRelativeDates, ExportEstimatedAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedAccountTotalsFromRelativeDatesResponse> ExportEstimatedAccountTotalsFromRelativeDatesAsync(
      ExportEstimatedAccountTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedAccountTotalsFromRelativeDates, ExportEstimatedAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedAccountTotalsFromDateToDateResponse ExportPlannedAccountTotalsFromDateToDate(
      ExportPlannedAccountTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedAccountTotalsFromDateToDate, ExportPlannedAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedAccountTotalsFromDateToDateResponse> ExportPlannedAccountTotalsFromDateToDateAsync(
      ExportPlannedAccountTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedAccountTotalsFromDateToDate, ExportPlannedAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedAccountTotalsFromRelativeDatesResponse ExportPlannedAccountTotalsFromRelativeDates(
      ExportPlannedAccountTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedAccountTotalsFromRelativeDates, ExportPlannedAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedAccountTotalsFromRelativeDatesResponse> ExportPlannedAccountTotalsFromRelativeDatesAsync(
      ExportPlannedAccountTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedAccountTotalsFromRelativeDates, ExportPlannedAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportDailyAccountTotalsResponse ExportDailyAccountTotals(
      ExportDailyAccountTotals arg)
    {
      return Client.Post<ExportDailyAccountTotals, ExportDailyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportDailyAccountTotalsResponse> ExportDailyAccountTotalsAsync(
      ExportDailyAccountTotals arg)
    {
      return Client.PostAsync<ExportDailyAccountTotals, ExportDailyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPeriodicalAccountTotalsResponse ExportPeriodicalAccountTotals(
      ExportPeriodicalAccountTotals arg)
    {
      return Client.Post<ExportPeriodicalAccountTotals, ExportPeriodicalAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPeriodicalAccountTotalsResponse> ExportPeriodicalAccountTotalsAsync(
      ExportPeriodicalAccountTotals arg)
    {
      return Client.PostAsync<ExportPeriodicalAccountTotals, ExportPeriodicalAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPerpetualAccountTotalsResponse ExportPerpetualAccountTotals(
      ExportPerpetualAccountTotals arg)
    {
      return Client.Post<ExportPerpetualAccountTotals, ExportPerpetualAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPerpetualAccountTotalsResponse> ExportPerpetualAccountTotalsAsync(
      ExportPerpetualAccountTotals arg)
    {
      return Client.PostAsync<ExportPerpetualAccountTotals, ExportPerpetualAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedDailyAccountTotalsFromDateToDateResponse ExportEstimatedDailyAccountTotalsFromDateToDate(
      ExportEstimatedDailyAccountTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedDailyAccountTotalsFromDateToDate, ExportEstimatedDailyAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedDailyAccountTotalsFromDateToDateResponse> ExportEstimatedDailyAccountTotalsFromDateToDateAsync(
      ExportEstimatedDailyAccountTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedDailyAccountTotalsFromDateToDate, ExportEstimatedDailyAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedDailyAccountTotalsFromPeriodResponse ExportEstimatedDailyAccountTotalsFromPeriod(
      ExportEstimatedDailyAccountTotalsFromPeriod arg)
    {
      return Client.Post<ExportEstimatedDailyAccountTotalsFromPeriod, ExportEstimatedDailyAccountTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedDailyAccountTotalsFromPeriodResponse> ExportEstimatedDailyAccountTotalsFromPeriodAsync(
      ExportEstimatedDailyAccountTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportEstimatedDailyAccountTotalsFromPeriod, ExportEstimatedDailyAccountTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedDailyAccountTotalsFromRelativeDatesResponse ExportEstimatedDailyAccountTotalsFromRelativeDates(
      ExportEstimatedDailyAccountTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedDailyAccountTotalsFromRelativeDates, ExportEstimatedDailyAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedDailyAccountTotalsFromRelativeDatesResponse> ExportEstimatedDailyAccountTotalsFromRelativeDatesAsync(
      ExportEstimatedDailyAccountTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedDailyAccountTotalsFromRelativeDates, ExportEstimatedDailyAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualWeeklyAccountTotalsListResponse ExportActualWeeklyAccountTotalsList(
      ExportActualWeeklyAccountTotalsList arg)
    {
      return Client.Post<ExportActualWeeklyAccountTotalsList, ExportActualWeeklyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualWeeklyAccountTotalsListResponse> ExportActualWeeklyAccountTotalsListAsync(
      ExportActualWeeklyAccountTotalsList arg)
    {
      return Client.PostAsync<ExportActualWeeklyAccountTotalsList, ExportActualWeeklyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualWeeklyAccountTotalsListFromDateToDateResponse ExportActualWeeklyAccountTotalsListFromDateToDate(
      ExportActualWeeklyAccountTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualWeeklyAccountTotalsListFromDateToDate, ExportActualWeeklyAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualWeeklyAccountTotalsListFromDateToDateResponse> ExportActualWeeklyAccountTotalsListFromDateToDateAsync(
      ExportActualWeeklyAccountTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualWeeklyAccountTotalsListFromDateToDate, ExportActualWeeklyAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualWeeklyAccountTotalsResponse ExportActualWeeklyAccountTotals(
      ExportActualWeeklyAccountTotals arg)
    {
      return Client.Post<ExportActualWeeklyAccountTotals, ExportActualWeeklyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualWeeklyAccountTotalsResponse> ExportActualWeeklyAccountTotalsAsync(
      ExportActualWeeklyAccountTotals arg)
    {
      return Client.PostAsync<ExportActualWeeklyAccountTotals, ExportActualWeeklyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedDailyAccountTotalsFromPeriodResponse ExportPlannedDailyAccountTotalsFromPeriod(
      ExportPlannedDailyAccountTotalsFromPeriod arg)
    {
      return Client.Post<ExportPlannedDailyAccountTotalsFromPeriod, ExportPlannedDailyAccountTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedDailyAccountTotalsFromPeriodResponse> ExportPlannedDailyAccountTotalsFromPeriodAsync(
      ExportPlannedDailyAccountTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportPlannedDailyAccountTotalsFromPeriod, ExportPlannedDailyAccountTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedDailyAccountTotalsFromRelativeDatesResponse ExportPlannedDailyAccountTotalsFromRelativeDates(
      ExportPlannedDailyAccountTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedDailyAccountTotalsFromRelativeDates, ExportPlannedDailyAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedDailyAccountTotalsFromRelativeDatesResponse> ExportPlannedDailyAccountTotalsFromRelativeDatesAsync(
      ExportPlannedDailyAccountTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedDailyAccountTotalsFromRelativeDates, ExportPlannedDailyAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedDailyAccountTotalsFromDateToDateResponse ExportPlannedDailyAccountTotalsFromDateToDate(
      ExportPlannedDailyAccountTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedDailyAccountTotalsFromDateToDate, ExportPlannedDailyAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedDailyAccountTotalsFromDateToDateResponse> ExportPlannedDailyAccountTotalsFromDateToDateAsync(
      ExportPlannedDailyAccountTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedDailyAccountTotalsFromDateToDate, ExportPlannedDailyAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualDailyAccountTotalsFromPeriodResponse ExportActualDailyAccountTotalsFromPeriod(
      ExportActualDailyAccountTotalsFromPeriod arg)
    {
      return Client.Post<ExportActualDailyAccountTotalsFromPeriod, ExportActualDailyAccountTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualDailyAccountTotalsFromPeriodResponse> ExportActualDailyAccountTotalsFromPeriodAsync(
      ExportActualDailyAccountTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportActualDailyAccountTotalsFromPeriod, ExportActualDailyAccountTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualDailyAccountTotalsFromDateToDateResponse ExportActualDailyAccountTotalsFromDateToDate(
      ExportActualDailyAccountTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualDailyAccountTotalsFromDateToDate, ExportActualDailyAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualDailyAccountTotalsFromDateToDateResponse> ExportActualDailyAccountTotalsFromDateToDateAsync(
      ExportActualDailyAccountTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualDailyAccountTotalsFromDateToDate, ExportActualDailyAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualDailyAccountTotalsFromRelativeDatesResponse ExportActualDailyAccountTotalsFromRelativeDates(
      ExportActualDailyAccountTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualDailyAccountTotalsFromRelativeDates, ExportActualDailyAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualDailyAccountTotalsFromRelativeDatesResponse> ExportActualDailyAccountTotalsFromRelativeDatesAsync(
      ExportActualDailyAccountTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualDailyAccountTotalsFromRelativeDates, ExportActualDailyAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedWeeklyAccountTotalsResponse ExportPlannedWeeklyAccountTotals(
      ExportPlannedWeeklyAccountTotals arg)
    {
      return Client.Post<ExportPlannedWeeklyAccountTotals, ExportPlannedWeeklyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedWeeklyAccountTotalsResponse> ExportPlannedWeeklyAccountTotalsAsync(
      ExportPlannedWeeklyAccountTotals arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyAccountTotals, ExportPlannedWeeklyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedWeeklyAccountTotalsListFromDateToDateResponse ExportPlannedWeeklyAccountTotalsListFromDateToDate(
      ExportPlannedWeeklyAccountTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedWeeklyAccountTotalsListFromDateToDate, ExportPlannedWeeklyAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedWeeklyAccountTotalsListFromDateToDateResponse> ExportPlannedWeeklyAccountTotalsListFromDateToDateAsync(
      ExportPlannedWeeklyAccountTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyAccountTotalsListFromDateToDate, ExportPlannedWeeklyAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPlannedWeeklyAccountTotalsListResponse ExportPlannedWeeklyAccountTotalsList(
      ExportPlannedWeeklyAccountTotalsList arg)
    {
      return Client.Post<ExportPlannedWeeklyAccountTotalsList, ExportPlannedWeeklyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPlannedWeeklyAccountTotalsListResponse> ExportPlannedWeeklyAccountTotalsListAsync(
      ExportPlannedWeeklyAccountTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyAccountTotalsList, ExportPlannedWeeklyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedPeriodicalAccountTotalsListResponse ExportEstimatedPeriodicalAccountTotalsList(
      ExportEstimatedPeriodicalAccountTotalsList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalAccountTotalsList, ExportEstimatedPeriodicalAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalAccountTotalsListResponse> ExportEstimatedPeriodicalAccountTotalsListAsync(
      ExportEstimatedPeriodicalAccountTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalAccountTotalsList, ExportEstimatedPeriodicalAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedPeriodicalAccountTotalsListFromDateToDateResponse ExportEstimatedPeriodicalAccountTotalsListFromDateToDate(
      ExportEstimatedPeriodicalAccountTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedPeriodicalAccountTotalsListFromDateToDate, ExportEstimatedPeriodicalAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalAccountTotalsListFromDateToDateResponse> ExportEstimatedPeriodicalAccountTotalsListFromDateToDateAsync(
      ExportEstimatedPeriodicalAccountTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalAccountTotalsListFromDateToDate, ExportEstimatedPeriodicalAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedPeriodicalAccountTotalsResponse ExportEstimatedPeriodicalAccountTotals(
      ExportEstimatedPeriodicalAccountTotals arg)
    {
      return Client.Post<ExportEstimatedPeriodicalAccountTotals, ExportEstimatedPeriodicalAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalAccountTotalsResponse> ExportEstimatedPeriodicalAccountTotalsAsync(
      ExportEstimatedPeriodicalAccountTotals arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalAccountTotals, ExportEstimatedPeriodicalAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedWeeklyAccountTotalsListResponse ExportEstimatedWeeklyAccountTotalsList(
      ExportEstimatedWeeklyAccountTotalsList arg)
    {
      return Client.Post<ExportEstimatedWeeklyAccountTotalsList, ExportEstimatedWeeklyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyAccountTotalsListResponse> ExportEstimatedWeeklyAccountTotalsListAsync(
      ExportEstimatedWeeklyAccountTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyAccountTotalsList, ExportEstimatedWeeklyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedWeeklyAccountTotalsResponse ExportEstimatedWeeklyAccountTotals(
      ExportEstimatedWeeklyAccountTotals arg)
    {
      return Client.Post<ExportEstimatedWeeklyAccountTotals, ExportEstimatedWeeklyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyAccountTotalsResponse> ExportEstimatedWeeklyAccountTotalsAsync(
      ExportEstimatedWeeklyAccountTotals arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyAccountTotals, ExportEstimatedWeeklyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportEstimatedWeeklyAccountTotalsListFromDateToDateResponse ExportEstimatedWeeklyAccountTotalsListFromDateToDate(
      ExportEstimatedWeeklyAccountTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedWeeklyAccountTotalsListFromDateToDate, ExportEstimatedWeeklyAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyAccountTotalsListFromDateToDateResponse> ExportEstimatedWeeklyAccountTotalsListFromDateToDateAsync(
      ExportEstimatedWeeklyAccountTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyAccountTotalsListFromDateToDate, ExportEstimatedWeeklyAccountTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualAccountTotalsFromDateToDateResponse ExportActualAccountTotalsFromDateToDate(
      ExportActualAccountTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualAccountTotalsFromDateToDate, ExportActualAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualAccountTotalsFromDateToDateResponse> ExportActualAccountTotalsFromDateToDateAsync(
      ExportActualAccountTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualAccountTotalsFromDateToDate, ExportActualAccountTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualAccountTotalsFromRelativeDatesResponse ExportActualAccountTotalsFromRelativeDates(
      ExportActualAccountTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualAccountTotalsFromRelativeDates, ExportActualAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualAccountTotalsFromRelativeDatesResponse> ExportActualAccountTotalsFromRelativeDatesAsync(
      ExportActualAccountTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualAccountTotalsFromRelativeDates, ExportActualAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualPerpetualAccountTotalsListFromDateResponse ExportActualPerpetualAccountTotalsListFromDate(
      ExportActualPerpetualAccountTotalsListFromDate arg)
    {
      return Client.Post<ExportActualPerpetualAccountTotalsListFromDate, ExportActualPerpetualAccountTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualPerpetualAccountTotalsListFromDateResponse> ExportActualPerpetualAccountTotalsListFromDateAsync(
      ExportActualPerpetualAccountTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportActualPerpetualAccountTotalsListFromDate, ExportActualPerpetualAccountTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualPerpetualAccountTotalsListResponse ExportActualPerpetualAccountTotalsList(
      ExportActualPerpetualAccountTotalsList arg)
    {
      return Client.Post<ExportActualPerpetualAccountTotalsList, ExportActualPerpetualAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualPerpetualAccountTotalsListResponse> ExportActualPerpetualAccountTotalsListAsync(
      ExportActualPerpetualAccountTotalsList arg)
    {
      return Client.PostAsync<ExportActualPerpetualAccountTotalsList, ExportActualPerpetualAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportActualPerpetualAccountTotalsFromRelativeDatesResponse ExportActualPerpetualAccountTotalsFromRelativeDates(
      ExportActualPerpetualAccountTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualPerpetualAccountTotalsFromRelativeDates, ExportActualPerpetualAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportActualPerpetualAccountTotalsFromRelativeDatesResponse> ExportActualPerpetualAccountTotalsFromRelativeDatesAsync(
      ExportActualPerpetualAccountTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualPerpetualAccountTotalsFromRelativeDates, ExportActualPerpetualAccountTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportWeeklyAccountTotalsListResponse ExportWeeklyAccountTotalsList(
      ExportWeeklyAccountTotalsList arg)
    {
      return Client.Post<ExportWeeklyAccountTotalsList, ExportWeeklyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportWeeklyAccountTotalsListResponse> ExportWeeklyAccountTotalsListAsync(
      ExportWeeklyAccountTotalsList arg)
    {
      return Client.PostAsync<ExportWeeklyAccountTotalsList, ExportWeeklyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportDailyAccountTotalsListResponse ExportDailyAccountTotalsList(
      ExportDailyAccountTotalsList arg)
    {
      return Client.Post<ExportDailyAccountTotalsList, ExportDailyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportDailyAccountTotalsListResponse> ExportDailyAccountTotalsListAsync(
      ExportDailyAccountTotalsList arg)
    {
      return Client.PostAsync<ExportDailyAccountTotalsList, ExportDailyAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPerpetualAccountTotalsListResponse ExportPerpetualAccountTotalsList(
      ExportPerpetualAccountTotalsList arg)
    {
      return Client.Post<ExportPerpetualAccountTotalsList, ExportPerpetualAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPerpetualAccountTotalsListResponse> ExportPerpetualAccountTotalsListAsync(
      ExportPerpetualAccountTotalsList arg)
    {
      return Client.PostAsync<ExportPerpetualAccountTotalsList, ExportPerpetualAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportWeeklyAccountTotalsResponse ExportWeeklyAccountTotals(
      ExportWeeklyAccountTotals arg)
    {
      return Client.Post<ExportWeeklyAccountTotals, ExportWeeklyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportWeeklyAccountTotalsResponse> ExportWeeklyAccountTotalsAsync(
      ExportWeeklyAccountTotals arg)
    {
      return Client.PostAsync<ExportWeeklyAccountTotals, ExportWeeklyAccountTotalsResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public ExportPeriodicalAccountTotalsListResponse ExportPeriodicalAccountTotalsList(
      ExportPeriodicalAccountTotalsList arg)
    {
      return Client.Post<ExportPeriodicalAccountTotalsList, ExportPeriodicalAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }

    public Task<ExportPeriodicalAccountTotalsListResponse> ExportPeriodicalAccountTotalsListAsync(
      ExportPeriodicalAccountTotalsList arg)
    {
      return Client.PostAsync<ExportPeriodicalAccountTotalsList, ExportPeriodicalAccountTotalsListResponse>(this.username, this.password, this.baseuri, "AccountTotalService", arg);
    }
  }
}
