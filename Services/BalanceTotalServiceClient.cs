
//.BalanceTotalServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class BalanceTotalServiceClient
  {
    private const string service = "BalanceTotalService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public BalanceTotalServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportActualDailyBalanceTotalsFromDateToDateForEmployeeListResponse ExportActualDailyBalanceTotalsFromDateToDateForEmployeeList(
      ExportActualDailyBalanceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyBalanceTotalsFromDateToDateForEmployeeList, ExportActualDailyBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyBalanceTotalsFromDateToDateForEmployeeListResponse> ExportActualDailyBalanceTotalsFromDateToDateForEmployeeListAsync(
      ExportActualDailyBalanceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyBalanceTotalsFromDateToDateForEmployeeList, ExportActualDailyBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyBalanceTotalsFromPeriodForEmployeeListResponse ExportActualDailyBalanceTotalsFromPeriodForEmployeeList(
      ExportActualDailyBalanceTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyBalanceTotalsFromPeriodForEmployeeList, ExportActualDailyBalanceTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyBalanceTotalsFromPeriodForEmployeeListResponse> ExportActualDailyBalanceTotalsFromPeriodForEmployeeListAsync(
      ExportActualDailyBalanceTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyBalanceTotalsFromPeriodForEmployeeList, ExportActualDailyBalanceTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalBalanceTotalsListFromDateToDateForEmployeeListResponse ExportActualPeriodicalBalanceTotalsListFromDateToDateForEmployeeList(
      ExportActualPeriodicalBalanceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalBalanceTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalBalanceTotalsListFromDateToDateForEmployeeListResponse> ExportActualPeriodicalBalanceTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualPeriodicalBalanceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalBalanceTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualBalanceTotalsListFromDateForEmployeeListResponse ExportActualPerpetualBalanceTotalsListFromDateForEmployeeList(
      ExportActualPerpetualBalanceTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualBalanceTotalsListFromDateForEmployeeList, ExportActualPerpetualBalanceTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualBalanceTotalsListFromDateForEmployeeListResponse> ExportActualPerpetualBalanceTotalsListFromDateForEmployeeListAsync(
      ExportActualPerpetualBalanceTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualBalanceTotalsListFromDateForEmployeeList, ExportActualPerpetualBalanceTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualBalanceTotalsListFromDateForEmployeeListResponse ExportEstimatedPerpetualBalanceTotalsListFromDateForEmployeeList(
      ExportEstimatedPerpetualBalanceTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualBalanceTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualBalanceTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualBalanceTotalsListFromDateForEmployeeListResponse> ExportEstimatedPerpetualBalanceTotalsListFromDateForEmployeeListAsync(
      ExportEstimatedPerpetualBalanceTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualBalanceTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualBalanceTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalBalanceTotalsForEmployeeListResponse ExportActualPeriodicalBalanceTotalsForEmployeeList(
      ExportActualPeriodicalBalanceTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalBalanceTotalsForEmployeeList, ExportActualPeriodicalBalanceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalBalanceTotalsForEmployeeListResponse> ExportActualPeriodicalBalanceTotalsForEmployeeListAsync(
      ExportActualPeriodicalBalanceTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalBalanceTotalsForEmployeeList, ExportActualPeriodicalBalanceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualBalanceTotalsListForEmployeeListResponse ExportPlannedPerpetualBalanceTotalsListForEmployeeList(
      ExportPlannedPerpetualBalanceTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualBalanceTotalsListForEmployeeList, ExportPlannedPerpetualBalanceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualBalanceTotalsListForEmployeeListResponse> ExportPlannedPerpetualBalanceTotalsListForEmployeeListAsync(
      ExportPlannedPerpetualBalanceTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualBalanceTotalsListForEmployeeList, ExportPlannedPerpetualBalanceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualBalanceTotalsListForEmployeeListResponse ExportActualPerpetualBalanceTotalsListForEmployeeList(
      ExportActualPerpetualBalanceTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualBalanceTotalsListForEmployeeList, ExportActualPerpetualBalanceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualBalanceTotalsListForEmployeeListResponse> ExportActualPerpetualBalanceTotalsListForEmployeeListAsync(
      ExportActualPerpetualBalanceTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualBalanceTotalsListForEmployeeList, ExportActualPerpetualBalanceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualBalanceTotalsListFromDateForEmployeeListResponse ExportPlannedPerpetualBalanceTotalsListFromDateForEmployeeList(
      ExportPlannedPerpetualBalanceTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualBalanceTotalsListFromDateForEmployeeList, ExportPlannedPerpetualBalanceTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualBalanceTotalsListFromDateForEmployeeListResponse> ExportPlannedPerpetualBalanceTotalsListFromDateForEmployeeListAsync(
      ExportPlannedPerpetualBalanceTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualBalanceTotalsListFromDateForEmployeeList, ExportPlannedPerpetualBalanceTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedBalanceTotalsFromDateToDateForEmployeeListResponse ExportPlannedBalanceTotalsFromDateToDateForEmployeeList(
      ExportPlannedBalanceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedBalanceTotalsFromDateToDateForEmployeeList, ExportPlannedBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedBalanceTotalsFromDateToDateForEmployeeListResponse> ExportPlannedBalanceTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedBalanceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedBalanceTotalsFromDateToDateForEmployeeList, ExportPlannedBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualBalanceTotalsFromDateToDateForEmployeeListResponse ExportActualBalanceTotalsFromDateToDateForEmployeeList(
      ExportActualBalanceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualBalanceTotalsFromDateToDateForEmployeeList, ExportActualBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualBalanceTotalsFromDateToDateForEmployeeListResponse> ExportActualBalanceTotalsFromDateToDateForEmployeeListAsync(
      ExportActualBalanceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualBalanceTotalsFromDateToDateForEmployeeList, ExportActualBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyBalanceTotalsFromDateToDateForEmployeeListResponse ExportEstimatedDailyBalanceTotalsFromDateToDateForEmployeeList(
      ExportEstimatedDailyBalanceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyBalanceTotalsFromDateToDateForEmployeeList, ExportEstimatedDailyBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyBalanceTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedDailyBalanceTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedDailyBalanceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyBalanceTotalsFromDateToDateForEmployeeList, ExportEstimatedDailyBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyBalanceTotalsFromRelativeDatesForEmployeeListResponse ExportActualDailyBalanceTotalsFromRelativeDatesForEmployeeList(
      ExportActualDailyBalanceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyBalanceTotalsFromRelativeDatesForEmployeeList, ExportActualDailyBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyBalanceTotalsFromRelativeDatesForEmployeeListResponse> ExportActualDailyBalanceTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualDailyBalanceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyBalanceTotalsFromRelativeDatesForEmployeeList, ExportActualDailyBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyBalanceTotalsForEmployeeListResponse ExportEstimatedWeeklyBalanceTotalsForEmployeeList(
      ExportEstimatedWeeklyBalanceTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyBalanceTotalsForEmployeeList, ExportEstimatedWeeklyBalanceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyBalanceTotalsForEmployeeListResponse> ExportEstimatedWeeklyBalanceTotalsForEmployeeListAsync(
      ExportEstimatedWeeklyBalanceTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyBalanceTotalsForEmployeeList, ExportEstimatedWeeklyBalanceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyBalanceTotalsForEmployeeListResponse ExportPlannedWeeklyBalanceTotalsForEmployeeList(
      ExportPlannedWeeklyBalanceTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyBalanceTotalsForEmployeeList, ExportPlannedWeeklyBalanceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyBalanceTotalsForEmployeeListResponse> ExportPlannedWeeklyBalanceTotalsForEmployeeListAsync(
      ExportPlannedWeeklyBalanceTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyBalanceTotalsForEmployeeList, ExportPlannedWeeklyBalanceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyBalanceTotalsListForEmployeeListResponse ExportActualWeeklyBalanceTotalsListForEmployeeList(
      ExportActualWeeklyBalanceTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyBalanceTotalsListForEmployeeList, ExportActualWeeklyBalanceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyBalanceTotalsListForEmployeeListResponse> ExportActualWeeklyBalanceTotalsListForEmployeeListAsync(
      ExportActualWeeklyBalanceTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyBalanceTotalsListForEmployeeList, ExportActualWeeklyBalanceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyBalanceTotalsForEmployeeListResponse ExportActualWeeklyBalanceTotalsForEmployeeList(
      ExportActualWeeklyBalanceTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyBalanceTotalsForEmployeeList, ExportActualWeeklyBalanceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyBalanceTotalsForEmployeeListResponse> ExportActualWeeklyBalanceTotalsForEmployeeListAsync(
      ExportActualWeeklyBalanceTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyBalanceTotalsForEmployeeList, ExportActualWeeklyBalanceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyBalanceTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedDailyBalanceTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedDailyBalanceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyBalanceTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailyBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyBalanceTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedDailyBalanceTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedDailyBalanceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyBalanceTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailyBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyBalanceTotalsFromPeriodForEmployeeListResponse ExportEstimatedDailyBalanceTotalsFromPeriodForEmployeeList(
      ExportEstimatedDailyBalanceTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyBalanceTotalsFromPeriodForEmployeeList, ExportEstimatedDailyBalanceTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyBalanceTotalsFromPeriodForEmployeeListResponse> ExportEstimatedDailyBalanceTotalsFromPeriodForEmployeeListAsync(
      ExportEstimatedDailyBalanceTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyBalanceTotalsFromPeriodForEmployeeList, ExportEstimatedDailyBalanceTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyBalanceTotalsFromDateToDateForEmployeeListResponse ExportPlannedDailyBalanceTotalsFromDateToDateForEmployeeList(
      ExportPlannedDailyBalanceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyBalanceTotalsFromDateToDateForEmployeeList, ExportPlannedDailyBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyBalanceTotalsFromDateToDateForEmployeeListResponse> ExportPlannedDailyBalanceTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedDailyBalanceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyBalanceTotalsFromDateToDateForEmployeeList, ExportPlannedDailyBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyBalanceTotalsFromPeriodForEmployeeListResponse ExportPlannedDailyBalanceTotalsFromPeriodForEmployeeList(
      ExportPlannedDailyBalanceTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyBalanceTotalsFromPeriodForEmployeeList, ExportPlannedDailyBalanceTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyBalanceTotalsFromPeriodForEmployeeListResponse> ExportPlannedDailyBalanceTotalsFromPeriodForEmployeeListAsync(
      ExportPlannedDailyBalanceTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyBalanceTotalsFromPeriodForEmployeeList, ExportPlannedDailyBalanceTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalBalanceTotalsForEmployeeListResponse ExportEstimatedPeriodicalBalanceTotalsForEmployeeList(
      ExportEstimatedPeriodicalBalanceTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalBalanceTotalsForEmployeeList, ExportEstimatedPeriodicalBalanceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalBalanceTotalsForEmployeeListResponse> ExportEstimatedPeriodicalBalanceTotalsForEmployeeListAsync(
      ExportEstimatedPeriodicalBalanceTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalBalanceTotalsForEmployeeList, ExportEstimatedPeriodicalBalanceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyBalanceTotalsListFromDateToDateForEmployeeListResponse ExportActualWeeklyBalanceTotalsListFromDateToDateForEmployeeList(
      ExportActualWeeklyBalanceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyBalanceTotalsListFromDateToDateForEmployeeList, ExportActualWeeklyBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyBalanceTotalsListFromDateToDateForEmployeeListResponse> ExportActualWeeklyBalanceTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualWeeklyBalanceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyBalanceTotalsListFromDateToDateForEmployeeList, ExportActualWeeklyBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualBalanceTotalsFromRelativeDatesForEmployeeListResponse ExportActualPerpetualBalanceTotalsFromRelativeDatesForEmployeeList(
      ExportActualPerpetualBalanceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualBalanceTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualBalanceTotalsFromRelativeDatesForEmployeeListResponse> ExportActualPerpetualBalanceTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualPerpetualBalanceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualBalanceTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualBalanceTotalsFromRelativeDatesForEmployeeListResponse ExportActualBalanceTotalsFromRelativeDatesForEmployeeList(
      ExportActualBalanceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualBalanceTotalsFromRelativeDatesForEmployeeList, ExportActualBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualBalanceTotalsFromRelativeDatesForEmployeeListResponse> ExportActualBalanceTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualBalanceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualBalanceTotalsFromRelativeDatesForEmployeeList, ExportActualBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyBalanceTotalsListFromDateToDateForEmployeeListResponse ExportPlannedWeeklyBalanceTotalsListFromDateToDateForEmployeeList(
      ExportPlannedWeeklyBalanceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyBalanceTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklyBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyBalanceTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedWeeklyBalanceTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedWeeklyBalanceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyBalanceTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklyBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualBalanceTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedPerpetualBalanceTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedPerpetualBalanceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualBalanceTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualBalanceTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedPerpetualBalanceTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedPerpetualBalanceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualBalanceTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyBalanceTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedWeeklyBalanceTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedWeeklyBalanceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyBalanceTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklyBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyBalanceTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedWeeklyBalanceTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedWeeklyBalanceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyBalanceTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklyBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalBalanceTotalsForEmployeeListResponse ExportPlannedPeriodicalBalanceTotalsForEmployeeList(
      ExportPlannedPeriodicalBalanceTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalBalanceTotalsForEmployeeList, ExportPlannedPeriodicalBalanceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalBalanceTotalsForEmployeeListResponse> ExportPlannedPeriodicalBalanceTotalsForEmployeeListAsync(
      ExportPlannedPeriodicalBalanceTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalBalanceTotalsForEmployeeList, ExportPlannedPeriodicalBalanceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedBalanceTotalsFromDateToDateForEmployeeListResponse ExportEstimatedBalanceTotalsFromDateToDateForEmployeeList(
      ExportEstimatedBalanceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedBalanceTotalsFromDateToDateForEmployeeList, ExportEstimatedBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedBalanceTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedBalanceTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedBalanceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedBalanceTotalsFromDateToDateForEmployeeList, ExportEstimatedBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalBalanceTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedPeriodicalBalanceTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedPeriodicalBalanceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalBalanceTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalBalanceTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedPeriodicalBalanceTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedPeriodicalBalanceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalBalanceTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalBalanceTotalsListForEmployeeListResponse ExportActualPeriodicalBalanceTotalsListForEmployeeList(
      ExportActualPeriodicalBalanceTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalBalanceTotalsListForEmployeeList, ExportActualPeriodicalBalanceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalBalanceTotalsListForEmployeeListResponse> ExportActualPeriodicalBalanceTotalsListForEmployeeListAsync(
      ExportActualPeriodicalBalanceTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalBalanceTotalsListForEmployeeList, ExportActualPeriodicalBalanceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualBalanceTotalsListForEmployeeListResponse ExportEstimatedPerpetualBalanceTotalsListForEmployeeList(
      ExportEstimatedPerpetualBalanceTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualBalanceTotalsListForEmployeeList, ExportEstimatedPerpetualBalanceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualBalanceTotalsListForEmployeeListResponse> ExportEstimatedPerpetualBalanceTotalsListForEmployeeListAsync(
      ExportEstimatedPerpetualBalanceTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualBalanceTotalsListForEmployeeList, ExportEstimatedPerpetualBalanceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalBalanceTotalsListForEmployeeListResponse ExportPlannedPeriodicalBalanceTotalsListForEmployeeList(
      ExportPlannedPeriodicalBalanceTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalBalanceTotalsListForEmployeeList, ExportPlannedPeriodicalBalanceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalBalanceTotalsListForEmployeeListResponse> ExportPlannedPeriodicalBalanceTotalsListForEmployeeListAsync(
      ExportPlannedPeriodicalBalanceTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalBalanceTotalsListForEmployeeList, ExportPlannedPeriodicalBalanceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalBalanceTotalsListFromDateToDateForEmployeeListResponse ExportPlannedPeriodicalBalanceTotalsListFromDateToDateForEmployeeList(
      ExportPlannedPeriodicalBalanceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalBalanceTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalBalanceTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedPeriodicalBalanceTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedPeriodicalBalanceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalBalanceTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedBalanceTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedBalanceTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedBalanceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedBalanceTotalsFromRelativeDatesForEmployeeList, ExportPlannedBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedBalanceTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedBalanceTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedBalanceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedBalanceTotalsFromRelativeDatesForEmployeeList, ExportPlannedBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedBalanceTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedBalanceTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedBalanceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedBalanceTotalsFromRelativeDatesForEmployeeList, ExportEstimatedBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedBalanceTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedBalanceTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedBalanceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedBalanceTotalsFromRelativeDatesForEmployeeList, ExportEstimatedBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyBalanceTotalsListForEmployeeListResponse ExportEstimatedWeeklyBalanceTotalsListForEmployeeList(
      ExportEstimatedWeeklyBalanceTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyBalanceTotalsListForEmployeeList, ExportEstimatedWeeklyBalanceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyBalanceTotalsListForEmployeeListResponse> ExportEstimatedWeeklyBalanceTotalsListForEmployeeListAsync(
      ExportEstimatedWeeklyBalanceTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyBalanceTotalsListForEmployeeList, ExportEstimatedWeeklyBalanceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyBalanceTotalsListForEmployeeListResponse ExportPlannedWeeklyBalanceTotalsListForEmployeeList(
      ExportPlannedWeeklyBalanceTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyBalanceTotalsListForEmployeeList, ExportPlannedWeeklyBalanceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyBalanceTotalsListForEmployeeListResponse> ExportPlannedWeeklyBalanceTotalsListForEmployeeListAsync(
      ExportPlannedWeeklyBalanceTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyBalanceTotalsListForEmployeeList, ExportPlannedWeeklyBalanceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualBalanceTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedPerpetualBalanceTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedPerpetualBalanceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualBalanceTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualBalanceTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedPerpetualBalanceTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedPerpetualBalanceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualBalanceTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalBalanceTotalsListForEmployeeListResponse ExportEstimatedPeriodicalBalanceTotalsListForEmployeeList(
      ExportEstimatedPeriodicalBalanceTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalBalanceTotalsListForEmployeeList, ExportEstimatedPeriodicalBalanceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalBalanceTotalsListForEmployeeListResponse> ExportEstimatedPeriodicalBalanceTotalsListForEmployeeListAsync(
      ExportEstimatedPeriodicalBalanceTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalBalanceTotalsListForEmployeeList, ExportEstimatedPeriodicalBalanceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyBalanceTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedDailyBalanceTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedDailyBalanceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyBalanceTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailyBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyBalanceTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedDailyBalanceTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedDailyBalanceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyBalanceTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailyBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalBalanceTotalsResponse ExportPlannedPeriodicalBalanceTotals(
      ExportPlannedPeriodicalBalanceTotals arg)
    {
      return Client.Post<ExportPlannedPeriodicalBalanceTotals, ExportPlannedPeriodicalBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalBalanceTotalsResponse> ExportPlannedPeriodicalBalanceTotalsAsync(
      ExportPlannedPeriodicalBalanceTotals arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalBalanceTotals, ExportPlannedPeriodicalBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalBalanceTotalsListResponse ExportPlannedPeriodicalBalanceTotalsList(
      ExportPlannedPeriodicalBalanceTotalsList arg)
    {
      return Client.Post<ExportPlannedPeriodicalBalanceTotalsList, ExportPlannedPeriodicalBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalBalanceTotalsListResponse> ExportPlannedPeriodicalBalanceTotalsListAsync(
      ExportPlannedPeriodicalBalanceTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalBalanceTotalsList, ExportPlannedPeriodicalBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalBalanceTotalsListFromDateToDateResponse ExportPlannedPeriodicalBalanceTotalsListFromDateToDate(
      ExportPlannedPeriodicalBalanceTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedPeriodicalBalanceTotalsListFromDateToDate, ExportPlannedPeriodicalBalanceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalBalanceTotalsListFromDateToDateResponse> ExportPlannedPeriodicalBalanceTotalsListFromDateToDateAsync(
      ExportPlannedPeriodicalBalanceTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalBalanceTotalsListFromDateToDate, ExportPlannedPeriodicalBalanceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualBalanceTotalsFromRelativeDatesResponse ExportPlannedPerpetualBalanceTotalsFromRelativeDates(
      ExportPlannedPerpetualBalanceTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedPerpetualBalanceTotalsFromRelativeDates, ExportPlannedPerpetualBalanceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualBalanceTotalsFromRelativeDatesResponse> ExportPlannedPerpetualBalanceTotalsFromRelativeDatesAsync(
      ExportPlannedPerpetualBalanceTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualBalanceTotalsFromRelativeDates, ExportPlannedPerpetualBalanceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualBalanceTotalsListFromDateResponse ExportPlannedPerpetualBalanceTotalsListFromDate(
      ExportPlannedPerpetualBalanceTotalsListFromDate arg)
    {
      return Client.Post<ExportPlannedPerpetualBalanceTotalsListFromDate, ExportPlannedPerpetualBalanceTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualBalanceTotalsListFromDateResponse> ExportPlannedPerpetualBalanceTotalsListFromDateAsync(
      ExportPlannedPerpetualBalanceTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualBalanceTotalsListFromDate, ExportPlannedPerpetualBalanceTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualBalanceTotalsListResponse ExportPlannedPerpetualBalanceTotalsList(
      ExportPlannedPerpetualBalanceTotalsList arg)
    {
      return Client.Post<ExportPlannedPerpetualBalanceTotalsList, ExportPlannedPerpetualBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualBalanceTotalsListResponse> ExportPlannedPerpetualBalanceTotalsListAsync(
      ExportPlannedPerpetualBalanceTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualBalanceTotalsList, ExportPlannedPerpetualBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalBalanceTotalsListResponse ExportActualPeriodicalBalanceTotalsList(
      ExportActualPeriodicalBalanceTotalsList arg)
    {
      return Client.Post<ExportActualPeriodicalBalanceTotalsList, ExportActualPeriodicalBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalBalanceTotalsListResponse> ExportActualPeriodicalBalanceTotalsListAsync(
      ExportActualPeriodicalBalanceTotalsList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalBalanceTotalsList, ExportActualPeriodicalBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalBalanceTotalsListFromDateToDateResponse ExportActualPeriodicalBalanceTotalsListFromDateToDate(
      ExportActualPeriodicalBalanceTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualPeriodicalBalanceTotalsListFromDateToDate, ExportActualPeriodicalBalanceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalBalanceTotalsListFromDateToDateResponse> ExportActualPeriodicalBalanceTotalsListFromDateToDateAsync(
      ExportActualPeriodicalBalanceTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualPeriodicalBalanceTotalsListFromDateToDate, ExportActualPeriodicalBalanceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalBalanceTotalsResponse ExportActualPeriodicalBalanceTotals(
      ExportActualPeriodicalBalanceTotals arg)
    {
      return Client.Post<ExportActualPeriodicalBalanceTotals, ExportActualPeriodicalBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalBalanceTotalsResponse> ExportActualPeriodicalBalanceTotalsAsync(
      ExportActualPeriodicalBalanceTotals arg)
    {
      return Client.PostAsync<ExportActualPeriodicalBalanceTotals, ExportActualPeriodicalBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualBalanceTotalsListResponse ExportEstimatedPerpetualBalanceTotalsList(
      ExportEstimatedPerpetualBalanceTotalsList arg)
    {
      return Client.Post<ExportEstimatedPerpetualBalanceTotalsList, ExportEstimatedPerpetualBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualBalanceTotalsListResponse> ExportEstimatedPerpetualBalanceTotalsListAsync(
      ExportEstimatedPerpetualBalanceTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualBalanceTotalsList, ExportEstimatedPerpetualBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualBalanceTotalsListFromDateResponse ExportEstimatedPerpetualBalanceTotalsListFromDate(
      ExportEstimatedPerpetualBalanceTotalsListFromDate arg)
    {
      return Client.Post<ExportEstimatedPerpetualBalanceTotalsListFromDate, ExportEstimatedPerpetualBalanceTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualBalanceTotalsListFromDateResponse> ExportEstimatedPerpetualBalanceTotalsListFromDateAsync(
      ExportEstimatedPerpetualBalanceTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualBalanceTotalsListFromDate, ExportEstimatedPerpetualBalanceTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualBalanceTotalsFromRelativeDatesResponse ExportEstimatedPerpetualBalanceTotalsFromRelativeDates(
      ExportEstimatedPerpetualBalanceTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedPerpetualBalanceTotalsFromRelativeDates, ExportEstimatedPerpetualBalanceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualBalanceTotalsFromRelativeDatesResponse> ExportEstimatedPerpetualBalanceTotalsFromRelativeDatesAsync(
      ExportEstimatedPerpetualBalanceTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualBalanceTotalsFromRelativeDates, ExportEstimatedPerpetualBalanceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedBalanceTotalsFromDateToDateResponse ExportEstimatedBalanceTotalsFromDateToDate(
      ExportEstimatedBalanceTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedBalanceTotalsFromDateToDate, ExportEstimatedBalanceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedBalanceTotalsFromDateToDateResponse> ExportEstimatedBalanceTotalsFromDateToDateAsync(
      ExportEstimatedBalanceTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedBalanceTotalsFromDateToDate, ExportEstimatedBalanceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedBalanceTotalsFromRelativeDatesResponse ExportEstimatedBalanceTotalsFromRelativeDates(
      ExportEstimatedBalanceTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedBalanceTotalsFromRelativeDates, ExportEstimatedBalanceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedBalanceTotalsFromRelativeDatesResponse> ExportEstimatedBalanceTotalsFromRelativeDatesAsync(
      ExportEstimatedBalanceTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedBalanceTotalsFromRelativeDates, ExportEstimatedBalanceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedBalanceTotalsFromDateToDateResponse ExportPlannedBalanceTotalsFromDateToDate(
      ExportPlannedBalanceTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedBalanceTotalsFromDateToDate, ExportPlannedBalanceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedBalanceTotalsFromDateToDateResponse> ExportPlannedBalanceTotalsFromDateToDateAsync(
      ExportPlannedBalanceTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedBalanceTotalsFromDateToDate, ExportPlannedBalanceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedBalanceTotalsFromRelativeDatesResponse ExportPlannedBalanceTotalsFromRelativeDates(
      ExportPlannedBalanceTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedBalanceTotalsFromRelativeDates, ExportPlannedBalanceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedBalanceTotalsFromRelativeDatesResponse> ExportPlannedBalanceTotalsFromRelativeDatesAsync(
      ExportPlannedBalanceTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedBalanceTotalsFromRelativeDates, ExportPlannedBalanceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportDailyBalanceTotalsResponse ExportDailyBalanceTotals(
      ExportDailyBalanceTotals arg)
    {
      return Client.Post<ExportDailyBalanceTotals, ExportDailyBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportDailyBalanceTotalsResponse> ExportDailyBalanceTotalsAsync(
      ExportDailyBalanceTotals arg)
    {
      return Client.PostAsync<ExportDailyBalanceTotals, ExportDailyBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPeriodicalBalanceTotalsResponse ExportPeriodicalBalanceTotals(
      ExportPeriodicalBalanceTotals arg)
    {
      return Client.Post<ExportPeriodicalBalanceTotals, ExportPeriodicalBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPeriodicalBalanceTotalsResponse> ExportPeriodicalBalanceTotalsAsync(
      ExportPeriodicalBalanceTotals arg)
    {
      return Client.PostAsync<ExportPeriodicalBalanceTotals, ExportPeriodicalBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPerpetualBalanceTotalsResponse ExportPerpetualBalanceTotals(
      ExportPerpetualBalanceTotals arg)
    {
      return Client.Post<ExportPerpetualBalanceTotals, ExportPerpetualBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPerpetualBalanceTotalsResponse> ExportPerpetualBalanceTotalsAsync(
      ExportPerpetualBalanceTotals arg)
    {
      return Client.PostAsync<ExportPerpetualBalanceTotals, ExportPerpetualBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyBalanceTotalsFromDateToDateResponse ExportEstimatedDailyBalanceTotalsFromDateToDate(
      ExportEstimatedDailyBalanceTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedDailyBalanceTotalsFromDateToDate, ExportEstimatedDailyBalanceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyBalanceTotalsFromDateToDateResponse> ExportEstimatedDailyBalanceTotalsFromDateToDateAsync(
      ExportEstimatedDailyBalanceTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedDailyBalanceTotalsFromDateToDate, ExportEstimatedDailyBalanceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyBalanceTotalsFromPeriodResponse ExportEstimatedDailyBalanceTotalsFromPeriod(
      ExportEstimatedDailyBalanceTotalsFromPeriod arg)
    {
      return Client.Post<ExportEstimatedDailyBalanceTotalsFromPeriod, ExportEstimatedDailyBalanceTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyBalanceTotalsFromPeriodResponse> ExportEstimatedDailyBalanceTotalsFromPeriodAsync(
      ExportEstimatedDailyBalanceTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportEstimatedDailyBalanceTotalsFromPeriod, ExportEstimatedDailyBalanceTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyBalanceTotalsFromRelativeDatesResponse ExportEstimatedDailyBalanceTotalsFromRelativeDates(
      ExportEstimatedDailyBalanceTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedDailyBalanceTotalsFromRelativeDates, ExportEstimatedDailyBalanceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyBalanceTotalsFromRelativeDatesResponse> ExportEstimatedDailyBalanceTotalsFromRelativeDatesAsync(
      ExportEstimatedDailyBalanceTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedDailyBalanceTotalsFromRelativeDates, ExportEstimatedDailyBalanceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyBalanceTotalsListResponse ExportActualWeeklyBalanceTotalsList(
      ExportActualWeeklyBalanceTotalsList arg)
    {
      return Client.Post<ExportActualWeeklyBalanceTotalsList, ExportActualWeeklyBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyBalanceTotalsListResponse> ExportActualWeeklyBalanceTotalsListAsync(
      ExportActualWeeklyBalanceTotalsList arg)
    {
      return Client.PostAsync<ExportActualWeeklyBalanceTotalsList, ExportActualWeeklyBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyBalanceTotalsListFromDateToDateResponse ExportActualWeeklyBalanceTotalsListFromDateToDate(
      ExportActualWeeklyBalanceTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualWeeklyBalanceTotalsListFromDateToDate, ExportActualWeeklyBalanceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyBalanceTotalsListFromDateToDateResponse> ExportActualWeeklyBalanceTotalsListFromDateToDateAsync(
      ExportActualWeeklyBalanceTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualWeeklyBalanceTotalsListFromDateToDate, ExportActualWeeklyBalanceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyBalanceTotalsResponse ExportActualWeeklyBalanceTotals(
      ExportActualWeeklyBalanceTotals arg)
    {
      return Client.Post<ExportActualWeeklyBalanceTotals, ExportActualWeeklyBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyBalanceTotalsResponse> ExportActualWeeklyBalanceTotalsAsync(
      ExportActualWeeklyBalanceTotals arg)
    {
      return Client.PostAsync<ExportActualWeeklyBalanceTotals, ExportActualWeeklyBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyBalanceTotalsFromPeriodResponse ExportPlannedDailyBalanceTotalsFromPeriod(
      ExportPlannedDailyBalanceTotalsFromPeriod arg)
    {
      return Client.Post<ExportPlannedDailyBalanceTotalsFromPeriod, ExportPlannedDailyBalanceTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyBalanceTotalsFromPeriodResponse> ExportPlannedDailyBalanceTotalsFromPeriodAsync(
      ExportPlannedDailyBalanceTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportPlannedDailyBalanceTotalsFromPeriod, ExportPlannedDailyBalanceTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyBalanceTotalsFromRelativeDatesResponse ExportPlannedDailyBalanceTotalsFromRelativeDates(
      ExportPlannedDailyBalanceTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedDailyBalanceTotalsFromRelativeDates, ExportPlannedDailyBalanceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyBalanceTotalsFromRelativeDatesResponse> ExportPlannedDailyBalanceTotalsFromRelativeDatesAsync(
      ExportPlannedDailyBalanceTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedDailyBalanceTotalsFromRelativeDates, ExportPlannedDailyBalanceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyBalanceTotalsFromDateToDateResponse ExportPlannedDailyBalanceTotalsFromDateToDate(
      ExportPlannedDailyBalanceTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedDailyBalanceTotalsFromDateToDate, ExportPlannedDailyBalanceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyBalanceTotalsFromDateToDateResponse> ExportPlannedDailyBalanceTotalsFromDateToDateAsync(
      ExportPlannedDailyBalanceTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedDailyBalanceTotalsFromDateToDate, ExportPlannedDailyBalanceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyBalanceTotalsFromPeriodResponse ExportActualDailyBalanceTotalsFromPeriod(
      ExportActualDailyBalanceTotalsFromPeriod arg)
    {
      return Client.Post<ExportActualDailyBalanceTotalsFromPeriod, ExportActualDailyBalanceTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyBalanceTotalsFromPeriodResponse> ExportActualDailyBalanceTotalsFromPeriodAsync(
      ExportActualDailyBalanceTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportActualDailyBalanceTotalsFromPeriod, ExportActualDailyBalanceTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyBalanceTotalsFromDateToDateResponse ExportActualDailyBalanceTotalsFromDateToDate(
      ExportActualDailyBalanceTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualDailyBalanceTotalsFromDateToDate, ExportActualDailyBalanceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyBalanceTotalsFromDateToDateResponse> ExportActualDailyBalanceTotalsFromDateToDateAsync(
      ExportActualDailyBalanceTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualDailyBalanceTotalsFromDateToDate, ExportActualDailyBalanceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyBalanceTotalsFromRelativeDatesResponse ExportActualDailyBalanceTotalsFromRelativeDates(
      ExportActualDailyBalanceTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualDailyBalanceTotalsFromRelativeDates, ExportActualDailyBalanceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyBalanceTotalsFromRelativeDatesResponse> ExportActualDailyBalanceTotalsFromRelativeDatesAsync(
      ExportActualDailyBalanceTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualDailyBalanceTotalsFromRelativeDates, ExportActualDailyBalanceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyBalanceTotalsResponse ExportPlannedWeeklyBalanceTotals(
      ExportPlannedWeeklyBalanceTotals arg)
    {
      return Client.Post<ExportPlannedWeeklyBalanceTotals, ExportPlannedWeeklyBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyBalanceTotalsResponse> ExportPlannedWeeklyBalanceTotalsAsync(
      ExportPlannedWeeklyBalanceTotals arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyBalanceTotals, ExportPlannedWeeklyBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyBalanceTotalsListFromDateToDateResponse ExportPlannedWeeklyBalanceTotalsListFromDateToDate(
      ExportPlannedWeeklyBalanceTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedWeeklyBalanceTotalsListFromDateToDate, ExportPlannedWeeklyBalanceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyBalanceTotalsListFromDateToDateResponse> ExportPlannedWeeklyBalanceTotalsListFromDateToDateAsync(
      ExportPlannedWeeklyBalanceTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyBalanceTotalsListFromDateToDate, ExportPlannedWeeklyBalanceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyBalanceTotalsListResponse ExportPlannedWeeklyBalanceTotalsList(
      ExportPlannedWeeklyBalanceTotalsList arg)
    {
      return Client.Post<ExportPlannedWeeklyBalanceTotalsList, ExportPlannedWeeklyBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyBalanceTotalsListResponse> ExportPlannedWeeklyBalanceTotalsListAsync(
      ExportPlannedWeeklyBalanceTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyBalanceTotalsList, ExportPlannedWeeklyBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalBalanceTotalsListResponse ExportEstimatedPeriodicalBalanceTotalsList(
      ExportEstimatedPeriodicalBalanceTotalsList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalBalanceTotalsList, ExportEstimatedPeriodicalBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalBalanceTotalsListResponse> ExportEstimatedPeriodicalBalanceTotalsListAsync(
      ExportEstimatedPeriodicalBalanceTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalBalanceTotalsList, ExportEstimatedPeriodicalBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalBalanceTotalsListFromDateToDateResponse ExportEstimatedPeriodicalBalanceTotalsListFromDateToDate(
      ExportEstimatedPeriodicalBalanceTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedPeriodicalBalanceTotalsListFromDateToDate, ExportEstimatedPeriodicalBalanceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalBalanceTotalsListFromDateToDateResponse> ExportEstimatedPeriodicalBalanceTotalsListFromDateToDateAsync(
      ExportEstimatedPeriodicalBalanceTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalBalanceTotalsListFromDateToDate, ExportEstimatedPeriodicalBalanceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalBalanceTotalsResponse ExportEstimatedPeriodicalBalanceTotals(
      ExportEstimatedPeriodicalBalanceTotals arg)
    {
      return Client.Post<ExportEstimatedPeriodicalBalanceTotals, ExportEstimatedPeriodicalBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalBalanceTotalsResponse> ExportEstimatedPeriodicalBalanceTotalsAsync(
      ExportEstimatedPeriodicalBalanceTotals arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalBalanceTotals, ExportEstimatedPeriodicalBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyBalanceTotalsListResponse ExportEstimatedWeeklyBalanceTotalsList(
      ExportEstimatedWeeklyBalanceTotalsList arg)
    {
      return Client.Post<ExportEstimatedWeeklyBalanceTotalsList, ExportEstimatedWeeklyBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyBalanceTotalsListResponse> ExportEstimatedWeeklyBalanceTotalsListAsync(
      ExportEstimatedWeeklyBalanceTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyBalanceTotalsList, ExportEstimatedWeeklyBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyBalanceTotalsResponse ExportEstimatedWeeklyBalanceTotals(
      ExportEstimatedWeeklyBalanceTotals arg)
    {
      return Client.Post<ExportEstimatedWeeklyBalanceTotals, ExportEstimatedWeeklyBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyBalanceTotalsResponse> ExportEstimatedWeeklyBalanceTotalsAsync(
      ExportEstimatedWeeklyBalanceTotals arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyBalanceTotals, ExportEstimatedWeeklyBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyBalanceTotalsListFromDateToDateResponse ExportEstimatedWeeklyBalanceTotalsListFromDateToDate(
      ExportEstimatedWeeklyBalanceTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedWeeklyBalanceTotalsListFromDateToDate, ExportEstimatedWeeklyBalanceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyBalanceTotalsListFromDateToDateResponse> ExportEstimatedWeeklyBalanceTotalsListFromDateToDateAsync(
      ExportEstimatedWeeklyBalanceTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyBalanceTotalsListFromDateToDate, ExportEstimatedWeeklyBalanceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualBalanceTotalsFromDateToDateResponse ExportActualBalanceTotalsFromDateToDate(
      ExportActualBalanceTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualBalanceTotalsFromDateToDate, ExportActualBalanceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualBalanceTotalsFromDateToDateResponse> ExportActualBalanceTotalsFromDateToDateAsync(
      ExportActualBalanceTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualBalanceTotalsFromDateToDate, ExportActualBalanceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualBalanceTotalsFromRelativeDatesResponse ExportActualBalanceTotalsFromRelativeDates(
      ExportActualBalanceTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualBalanceTotalsFromRelativeDates, ExportActualBalanceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualBalanceTotalsFromRelativeDatesResponse> ExportActualBalanceTotalsFromRelativeDatesAsync(
      ExportActualBalanceTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualBalanceTotalsFromRelativeDates, ExportActualBalanceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualBalanceTotalsListFromDateResponse ExportActualPerpetualBalanceTotalsListFromDate(
      ExportActualPerpetualBalanceTotalsListFromDate arg)
    {
      return Client.Post<ExportActualPerpetualBalanceTotalsListFromDate, ExportActualPerpetualBalanceTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualBalanceTotalsListFromDateResponse> ExportActualPerpetualBalanceTotalsListFromDateAsync(
      ExportActualPerpetualBalanceTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportActualPerpetualBalanceTotalsListFromDate, ExportActualPerpetualBalanceTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualBalanceTotalsListResponse ExportActualPerpetualBalanceTotalsList(
      ExportActualPerpetualBalanceTotalsList arg)
    {
      return Client.Post<ExportActualPerpetualBalanceTotalsList, ExportActualPerpetualBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualBalanceTotalsListResponse> ExportActualPerpetualBalanceTotalsListAsync(
      ExportActualPerpetualBalanceTotalsList arg)
    {
      return Client.PostAsync<ExportActualPerpetualBalanceTotalsList, ExportActualPerpetualBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualBalanceTotalsFromRelativeDatesResponse ExportActualPerpetualBalanceTotalsFromRelativeDates(
      ExportActualPerpetualBalanceTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualPerpetualBalanceTotalsFromRelativeDates, ExportActualPerpetualBalanceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualBalanceTotalsFromRelativeDatesResponse> ExportActualPerpetualBalanceTotalsFromRelativeDatesAsync(
      ExportActualPerpetualBalanceTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualPerpetualBalanceTotalsFromRelativeDates, ExportActualPerpetualBalanceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportWeeklyBalanceTotalsListResponse ExportWeeklyBalanceTotalsList(
      ExportWeeklyBalanceTotalsList arg)
    {
      return Client.Post<ExportWeeklyBalanceTotalsList, ExportWeeklyBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportWeeklyBalanceTotalsListResponse> ExportWeeklyBalanceTotalsListAsync(
      ExportWeeklyBalanceTotalsList arg)
    {
      return Client.PostAsync<ExportWeeklyBalanceTotalsList, ExportWeeklyBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportDailyBalanceTotalsListResponse ExportDailyBalanceTotalsList(
      ExportDailyBalanceTotalsList arg)
    {
      return Client.Post<ExportDailyBalanceTotalsList, ExportDailyBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportDailyBalanceTotalsListResponse> ExportDailyBalanceTotalsListAsync(
      ExportDailyBalanceTotalsList arg)
    {
      return Client.PostAsync<ExportDailyBalanceTotalsList, ExportDailyBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPerpetualBalanceTotalsListResponse ExportPerpetualBalanceTotalsList(
      ExportPerpetualBalanceTotalsList arg)
    {
      return Client.Post<ExportPerpetualBalanceTotalsList, ExportPerpetualBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPerpetualBalanceTotalsListResponse> ExportPerpetualBalanceTotalsListAsync(
      ExportPerpetualBalanceTotalsList arg)
    {
      return Client.PostAsync<ExportPerpetualBalanceTotalsList, ExportPerpetualBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportWeeklyBalanceTotalsResponse ExportWeeklyBalanceTotals(
      ExportWeeklyBalanceTotals arg)
    {
      return Client.Post<ExportWeeklyBalanceTotals, ExportWeeklyBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportWeeklyBalanceTotalsResponse> ExportWeeklyBalanceTotalsAsync(
      ExportWeeklyBalanceTotals arg)
    {
      return Client.PostAsync<ExportWeeklyBalanceTotals, ExportWeeklyBalanceTotalsResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPeriodicalBalanceTotalsListResponse ExportPeriodicalBalanceTotalsList(
      ExportPeriodicalBalanceTotalsList arg)
    {
      return Client.Post<ExportPeriodicalBalanceTotalsList, ExportPeriodicalBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPeriodicalBalanceTotalsListResponse> ExportPeriodicalBalanceTotalsListAsync(
      ExportPeriodicalBalanceTotalsList arg)
    {
      return Client.PostAsync<ExportPeriodicalBalanceTotalsList, ExportPeriodicalBalanceTotalsListResponse>(this.username, this.password, this.baseuri, "BalanceTotalService", arg, this.timeoutSeconds);
    }
  }
}
