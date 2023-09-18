
//.AbsenceTotalServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class AbsenceTotalServiceClient
  {
    private const string service = "AbsenceTotalService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public AbsenceTotalServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportActualDailyAbsenceTotalsFromDateToDateForEmployeeListResponse ExportActualDailyAbsenceTotalsFromDateToDateForEmployeeList(
      ExportActualDailyAbsenceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyAbsenceTotalsFromDateToDateForEmployeeList, ExportActualDailyAbsenceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyAbsenceTotalsFromDateToDateForEmployeeListResponse> ExportActualDailyAbsenceTotalsFromDateToDateForEmployeeListAsync(
      ExportActualDailyAbsenceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyAbsenceTotalsFromDateToDateForEmployeeList, ExportActualDailyAbsenceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyAbsenceTotalsFromPeriodForEmployeeListResponse ExportActualDailyAbsenceTotalsFromPeriodForEmployeeList(
      ExportActualDailyAbsenceTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyAbsenceTotalsFromPeriodForEmployeeList, ExportActualDailyAbsenceTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyAbsenceTotalsFromPeriodForEmployeeListResponse> ExportActualDailyAbsenceTotalsFromPeriodForEmployeeListAsync(
      ExportActualDailyAbsenceTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyAbsenceTotalsFromPeriodForEmployeeList, ExportActualDailyAbsenceTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListResponse ExportActualPeriodicalAbsenceTotalsListFromDateToDateForEmployeeList(
      ExportActualPeriodicalAbsenceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalAbsenceTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListResponse> ExportActualPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualPeriodicalAbsenceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalAbsenceTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualAbsenceTotalsListFromDateForEmployeeListResponse ExportActualPerpetualAbsenceTotalsListFromDateForEmployeeList(
      ExportActualPerpetualAbsenceTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualAbsenceTotalsListFromDateForEmployeeList, ExportActualPerpetualAbsenceTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualAbsenceTotalsListFromDateForEmployeeListResponse> ExportActualPerpetualAbsenceTotalsListFromDateForEmployeeListAsync(
      ExportActualPerpetualAbsenceTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualAbsenceTotalsListFromDateForEmployeeList, ExportActualPerpetualAbsenceTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualAbsenceTotalsListFromDateForEmployeeListResponse ExportEstimatedPerpetualAbsenceTotalsListFromDateForEmployeeList(
      ExportEstimatedPerpetualAbsenceTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualAbsenceTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualAbsenceTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualAbsenceTotalsListFromDateForEmployeeListResponse> ExportEstimatedPerpetualAbsenceTotalsListFromDateForEmployeeListAsync(
      ExportEstimatedPerpetualAbsenceTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualAbsenceTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualAbsenceTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalAbsenceTotalsForEmployeeListResponse ExportActualPeriodicalAbsenceTotalsForEmployeeList(
      ExportActualPeriodicalAbsenceTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalAbsenceTotalsForEmployeeList, ExportActualPeriodicalAbsenceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalAbsenceTotalsForEmployeeListResponse> ExportActualPeriodicalAbsenceTotalsForEmployeeListAsync(
      ExportActualPeriodicalAbsenceTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalAbsenceTotalsForEmployeeList, ExportActualPeriodicalAbsenceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualAbsenceTotalsListForEmployeeListResponse ExportPlannedPerpetualAbsenceTotalsListForEmployeeList(
      ExportPlannedPerpetualAbsenceTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualAbsenceTotalsListForEmployeeList, ExportPlannedPerpetualAbsenceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualAbsenceTotalsListForEmployeeListResponse> ExportPlannedPerpetualAbsenceTotalsListForEmployeeListAsync(
      ExportPlannedPerpetualAbsenceTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualAbsenceTotalsListForEmployeeList, ExportPlannedPerpetualAbsenceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualAbsenceTotalsListForEmployeeListResponse ExportActualPerpetualAbsenceTotalsListForEmployeeList(
      ExportActualPerpetualAbsenceTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualAbsenceTotalsListForEmployeeList, ExportActualPerpetualAbsenceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualAbsenceTotalsListForEmployeeListResponse> ExportActualPerpetualAbsenceTotalsListForEmployeeListAsync(
      ExportActualPerpetualAbsenceTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualAbsenceTotalsListForEmployeeList, ExportActualPerpetualAbsenceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualAbsenceTotalsListFromDateForEmployeeListResponse ExportPlannedPerpetualAbsenceTotalsListFromDateForEmployeeList(
      ExportPlannedPerpetualAbsenceTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualAbsenceTotalsListFromDateForEmployeeList, ExportPlannedPerpetualAbsenceTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualAbsenceTotalsListFromDateForEmployeeListResponse> ExportPlannedPerpetualAbsenceTotalsListFromDateForEmployeeListAsync(
      ExportPlannedPerpetualAbsenceTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualAbsenceTotalsListFromDateForEmployeeList, ExportPlannedPerpetualAbsenceTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedAbsenceTotalsFromDateToDateForEmployeeListResponse ExportPlannedAbsenceTotalsFromDateToDateForEmployeeList(
      ExportPlannedAbsenceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedAbsenceTotalsFromDateToDateForEmployeeList, ExportPlannedAbsenceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedAbsenceTotalsFromDateToDateForEmployeeListResponse> ExportPlannedAbsenceTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedAbsenceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedAbsenceTotalsFromDateToDateForEmployeeList, ExportPlannedAbsenceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualAbsenceTotalsFromDateToDateForEmployeeListResponse ExportActualAbsenceTotalsFromDateToDateForEmployeeList(
      ExportActualAbsenceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualAbsenceTotalsFromDateToDateForEmployeeList, ExportActualAbsenceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualAbsenceTotalsFromDateToDateForEmployeeListResponse> ExportActualAbsenceTotalsFromDateToDateForEmployeeListAsync(
      ExportActualAbsenceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualAbsenceTotalsFromDateToDateForEmployeeList, ExportActualAbsenceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyAbsenceTotalsFromDateToDateForEmployeeListResponse ExportEstimatedDailyAbsenceTotalsFromDateToDateForEmployeeList(
      ExportEstimatedDailyAbsenceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyAbsenceTotalsFromDateToDateForEmployeeList, ExportEstimatedDailyAbsenceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyAbsenceTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedDailyAbsenceTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedDailyAbsenceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyAbsenceTotalsFromDateToDateForEmployeeList, ExportEstimatedDailyAbsenceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyAbsenceTotalsFromRelativeDatesForEmployeeListResponse ExportActualDailyAbsenceTotalsFromRelativeDatesForEmployeeList(
      ExportActualDailyAbsenceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyAbsenceTotalsFromRelativeDatesForEmployeeList, ExportActualDailyAbsenceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyAbsenceTotalsFromRelativeDatesForEmployeeListResponse> ExportActualDailyAbsenceTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualDailyAbsenceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyAbsenceTotalsFromRelativeDatesForEmployeeList, ExportActualDailyAbsenceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyAbsenceTotalsForEmployeeListResponse ExportEstimatedWeeklyAbsenceTotalsForEmployeeList(
      ExportEstimatedWeeklyAbsenceTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyAbsenceTotalsForEmployeeList, ExportEstimatedWeeklyAbsenceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyAbsenceTotalsForEmployeeListResponse> ExportEstimatedWeeklyAbsenceTotalsForEmployeeListAsync(
      ExportEstimatedWeeklyAbsenceTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyAbsenceTotalsForEmployeeList, ExportEstimatedWeeklyAbsenceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyAbsenceTotalsForEmployeeListResponse ExportPlannedWeeklyAbsenceTotalsForEmployeeList(
      ExportPlannedWeeklyAbsenceTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyAbsenceTotalsForEmployeeList, ExportPlannedWeeklyAbsenceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyAbsenceTotalsForEmployeeListResponse> ExportPlannedWeeklyAbsenceTotalsForEmployeeListAsync(
      ExportPlannedWeeklyAbsenceTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyAbsenceTotalsForEmployeeList, ExportPlannedWeeklyAbsenceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyAbsenceTotalsListForEmployeeListResponse ExportActualWeeklyAbsenceTotalsListForEmployeeList(
      ExportActualWeeklyAbsenceTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyAbsenceTotalsListForEmployeeList, ExportActualWeeklyAbsenceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyAbsenceTotalsListForEmployeeListResponse> ExportActualWeeklyAbsenceTotalsListForEmployeeListAsync(
      ExportActualWeeklyAbsenceTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyAbsenceTotalsListForEmployeeList, ExportActualWeeklyAbsenceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyAbsenceTotalsForEmployeeListResponse ExportActualWeeklyAbsenceTotalsForEmployeeList(
      ExportActualWeeklyAbsenceTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyAbsenceTotalsForEmployeeList, ExportActualWeeklyAbsenceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyAbsenceTotalsForEmployeeListResponse> ExportActualWeeklyAbsenceTotalsForEmployeeListAsync(
      ExportActualWeeklyAbsenceTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyAbsenceTotalsForEmployeeList, ExportActualWeeklyAbsenceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyAbsenceTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedDailyAbsenceTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedDailyAbsenceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyAbsenceTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailyAbsenceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyAbsenceTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedDailyAbsenceTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedDailyAbsenceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyAbsenceTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailyAbsenceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyAbsenceTotalsFromPeriodForEmployeeListResponse ExportEstimatedDailyAbsenceTotalsFromPeriodForEmployeeList(
      ExportEstimatedDailyAbsenceTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyAbsenceTotalsFromPeriodForEmployeeList, ExportEstimatedDailyAbsenceTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyAbsenceTotalsFromPeriodForEmployeeListResponse> ExportEstimatedDailyAbsenceTotalsFromPeriodForEmployeeListAsync(
      ExportEstimatedDailyAbsenceTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyAbsenceTotalsFromPeriodForEmployeeList, ExportEstimatedDailyAbsenceTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyAbsenceTotalsFromDateToDateForEmployeeListResponse ExportPlannedDailyAbsenceTotalsFromDateToDateForEmployeeList(
      ExportPlannedDailyAbsenceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyAbsenceTotalsFromDateToDateForEmployeeList, ExportPlannedDailyAbsenceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyAbsenceTotalsFromDateToDateForEmployeeListResponse> ExportPlannedDailyAbsenceTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedDailyAbsenceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyAbsenceTotalsFromDateToDateForEmployeeList, ExportPlannedDailyAbsenceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyAbsenceTotalsFromPeriodForEmployeeListResponse ExportPlannedDailyAbsenceTotalsFromPeriodForEmployeeList(
      ExportPlannedDailyAbsenceTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyAbsenceTotalsFromPeriodForEmployeeList, ExportPlannedDailyAbsenceTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyAbsenceTotalsFromPeriodForEmployeeListResponse> ExportPlannedDailyAbsenceTotalsFromPeriodForEmployeeListAsync(
      ExportPlannedDailyAbsenceTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyAbsenceTotalsFromPeriodForEmployeeList, ExportPlannedDailyAbsenceTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalAbsenceTotalsForEmployeeListResponse ExportEstimatedPeriodicalAbsenceTotalsForEmployeeList(
      ExportEstimatedPeriodicalAbsenceTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalAbsenceTotalsForEmployeeList, ExportEstimatedPeriodicalAbsenceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalAbsenceTotalsForEmployeeListResponse> ExportEstimatedPeriodicalAbsenceTotalsForEmployeeListAsync(
      ExportEstimatedPeriodicalAbsenceTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalAbsenceTotalsForEmployeeList, ExportEstimatedPeriodicalAbsenceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyAbsenceTotalsListFromDateToDateForEmployeeListResponse ExportActualWeeklyAbsenceTotalsListFromDateToDateForEmployeeList(
      ExportActualWeeklyAbsenceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyAbsenceTotalsListFromDateToDateForEmployeeList, ExportActualWeeklyAbsenceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyAbsenceTotalsListFromDateToDateForEmployeeListResponse> ExportActualWeeklyAbsenceTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualWeeklyAbsenceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyAbsenceTotalsListFromDateToDateForEmployeeList, ExportActualWeeklyAbsenceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualAbsenceTotalsFromRelativeDatesForEmployeeListResponse ExportActualPerpetualAbsenceTotalsFromRelativeDatesForEmployeeList(
      ExportActualPerpetualAbsenceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualAbsenceTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualAbsenceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualAbsenceTotalsFromRelativeDatesForEmployeeListResponse> ExportActualPerpetualAbsenceTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualPerpetualAbsenceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualAbsenceTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualAbsenceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualAbsenceTotalsFromRelativeDatesForEmployeeListResponse ExportActualAbsenceTotalsFromRelativeDatesForEmployeeList(
      ExportActualAbsenceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualAbsenceTotalsFromRelativeDatesForEmployeeList, ExportActualAbsenceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualAbsenceTotalsFromRelativeDatesForEmployeeListResponse> ExportActualAbsenceTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualAbsenceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualAbsenceTotalsFromRelativeDatesForEmployeeList, ExportActualAbsenceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyAbsenceTotalsListFromDateToDateForEmployeeListResponse ExportPlannedWeeklyAbsenceTotalsListFromDateToDateForEmployeeList(
      ExportPlannedWeeklyAbsenceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyAbsenceTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklyAbsenceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyAbsenceTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedWeeklyAbsenceTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedWeeklyAbsenceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyAbsenceTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklyAbsenceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyAbsenceTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedWeeklyAbsenceTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedWeeklyAbsenceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyAbsenceTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklyAbsenceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyAbsenceTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedWeeklyAbsenceTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedWeeklyAbsenceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyAbsenceTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklyAbsenceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalAbsenceTotalsForEmployeeListResponse ExportPlannedPeriodicalAbsenceTotalsForEmployeeList(
      ExportPlannedPeriodicalAbsenceTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalAbsenceTotalsForEmployeeList, ExportPlannedPeriodicalAbsenceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalAbsenceTotalsForEmployeeListResponse> ExportPlannedPeriodicalAbsenceTotalsForEmployeeListAsync(
      ExportPlannedPeriodicalAbsenceTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalAbsenceTotalsForEmployeeList, ExportPlannedPeriodicalAbsenceTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedAbsenceTotalsFromDateToDateForEmployeeListResponse ExportEstimatedAbsenceTotalsFromDateToDateForEmployeeList(
      ExportEstimatedAbsenceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedAbsenceTotalsFromDateToDateForEmployeeList, ExportEstimatedAbsenceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedAbsenceTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedAbsenceTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedAbsenceTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedAbsenceTotalsFromDateToDateForEmployeeList, ExportEstimatedAbsenceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalAbsenceTotalsListForEmployeeListResponse ExportActualPeriodicalAbsenceTotalsListForEmployeeList(
      ExportActualPeriodicalAbsenceTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalAbsenceTotalsListForEmployeeList, ExportActualPeriodicalAbsenceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalAbsenceTotalsListForEmployeeListResponse> ExportActualPeriodicalAbsenceTotalsListForEmployeeListAsync(
      ExportActualPeriodicalAbsenceTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalAbsenceTotalsListForEmployeeList, ExportActualPeriodicalAbsenceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualAbsenceTotalsListForEmployeeListResponse ExportEstimatedPerpetualAbsenceTotalsListForEmployeeList(
      ExportEstimatedPerpetualAbsenceTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualAbsenceTotalsListForEmployeeList, ExportEstimatedPerpetualAbsenceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualAbsenceTotalsListForEmployeeListResponse> ExportEstimatedPerpetualAbsenceTotalsListForEmployeeListAsync(
      ExportEstimatedPerpetualAbsenceTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualAbsenceTotalsListForEmployeeList, ExportEstimatedPerpetualAbsenceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalAbsenceTotalsListForEmployeeListResponse ExportPlannedPeriodicalAbsenceTotalsListForEmployeeList(
      ExportPlannedPeriodicalAbsenceTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalAbsenceTotalsListForEmployeeList, ExportPlannedPeriodicalAbsenceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalAbsenceTotalsListForEmployeeListResponse> ExportPlannedPeriodicalAbsenceTotalsListForEmployeeListAsync(
      ExportPlannedPeriodicalAbsenceTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalAbsenceTotalsListForEmployeeList, ExportPlannedPeriodicalAbsenceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListResponse ExportPlannedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeList(
      ExportPlannedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalAbsenceTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedAbsenceTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedAbsenceTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedAbsenceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedAbsenceTotalsFromRelativeDatesForEmployeeList, ExportPlannedAbsenceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedAbsenceTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedAbsenceTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedAbsenceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedAbsenceTotalsFromRelativeDatesForEmployeeList, ExportPlannedAbsenceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedAbsenceTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedAbsenceTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedAbsenceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedAbsenceTotalsFromRelativeDatesForEmployeeList, ExportEstimatedAbsenceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedAbsenceTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedAbsenceTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedAbsenceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedAbsenceTotalsFromRelativeDatesForEmployeeList, ExportEstimatedAbsenceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyAbsenceTotalsListForEmployeeListResponse ExportEstimatedWeeklyAbsenceTotalsListForEmployeeList(
      ExportEstimatedWeeklyAbsenceTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyAbsenceTotalsListForEmployeeList, ExportEstimatedWeeklyAbsenceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyAbsenceTotalsListForEmployeeListResponse> ExportEstimatedWeeklyAbsenceTotalsListForEmployeeListAsync(
      ExportEstimatedWeeklyAbsenceTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyAbsenceTotalsListForEmployeeList, ExportEstimatedWeeklyAbsenceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyAbsenceTotalsListForEmployeeListResponse ExportPlannedWeeklyAbsenceTotalsListForEmployeeList(
      ExportPlannedWeeklyAbsenceTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyAbsenceTotalsListForEmployeeList, ExportPlannedWeeklyAbsenceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyAbsenceTotalsListForEmployeeListResponse> ExportPlannedWeeklyAbsenceTotalsListForEmployeeListAsync(
      ExportPlannedWeeklyAbsenceTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyAbsenceTotalsListForEmployeeList, ExportPlannedWeeklyAbsenceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualAbsenceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalAbsenceTotalsListForEmployeeListResponse ExportEstimatedPeriodicalAbsenceTotalsListForEmployeeList(
      ExportEstimatedPeriodicalAbsenceTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalAbsenceTotalsListForEmployeeList, ExportEstimatedPeriodicalAbsenceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalAbsenceTotalsListForEmployeeListResponse> ExportEstimatedPeriodicalAbsenceTotalsListForEmployeeListAsync(
      ExportEstimatedPeriodicalAbsenceTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalAbsenceTotalsListForEmployeeList, ExportEstimatedPeriodicalAbsenceTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyAbsenceTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedDailyAbsenceTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedDailyAbsenceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyAbsenceTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailyAbsenceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyAbsenceTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedDailyAbsenceTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedDailyAbsenceTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyAbsenceTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailyAbsenceTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalAbsenceTotalsResponse ExportPlannedPeriodicalAbsenceTotals(
      ExportPlannedPeriodicalAbsenceTotals arg)
    {
      return Client.Post<ExportPlannedPeriodicalAbsenceTotals, ExportPlannedPeriodicalAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalAbsenceTotalsResponse> ExportPlannedPeriodicalAbsenceTotalsAsync(
      ExportPlannedPeriodicalAbsenceTotals arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalAbsenceTotals, ExportPlannedPeriodicalAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalAbsenceTotalsListResponse ExportPlannedPeriodicalAbsenceTotalsList(
      ExportPlannedPeriodicalAbsenceTotalsList arg)
    {
      return Client.Post<ExportPlannedPeriodicalAbsenceTotalsList, ExportPlannedPeriodicalAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalAbsenceTotalsListResponse> ExportPlannedPeriodicalAbsenceTotalsListAsync(
      ExportPlannedPeriodicalAbsenceTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalAbsenceTotalsList, ExportPlannedPeriodicalAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalAbsenceTotalsListFromDateToDateResponse ExportPlannedPeriodicalAbsenceTotalsListFromDateToDate(
      ExportPlannedPeriodicalAbsenceTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedPeriodicalAbsenceTotalsListFromDateToDate, ExportPlannedPeriodicalAbsenceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalAbsenceTotalsListFromDateToDateResponse> ExportPlannedPeriodicalAbsenceTotalsListFromDateToDateAsync(
      ExportPlannedPeriodicalAbsenceTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalAbsenceTotalsListFromDateToDate, ExportPlannedPeriodicalAbsenceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualAbsenceTotalsFromRelativeDatesResponse ExportPlannedPerpetualAbsenceTotalsFromRelativeDates(
      ExportPlannedPerpetualAbsenceTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedPerpetualAbsenceTotalsFromRelativeDates, ExportPlannedPerpetualAbsenceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualAbsenceTotalsFromRelativeDatesResponse> ExportPlannedPerpetualAbsenceTotalsFromRelativeDatesAsync(
      ExportPlannedPerpetualAbsenceTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualAbsenceTotalsFromRelativeDates, ExportPlannedPerpetualAbsenceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualAbsenceTotalsListFromDateResponse ExportPlannedPerpetualAbsenceTotalsListFromDate(
      ExportPlannedPerpetualAbsenceTotalsListFromDate arg)
    {
      return Client.Post<ExportPlannedPerpetualAbsenceTotalsListFromDate, ExportPlannedPerpetualAbsenceTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualAbsenceTotalsListFromDateResponse> ExportPlannedPerpetualAbsenceTotalsListFromDateAsync(
      ExportPlannedPerpetualAbsenceTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualAbsenceTotalsListFromDate, ExportPlannedPerpetualAbsenceTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualAbsenceTotalsListResponse ExportPlannedPerpetualAbsenceTotalsList(
      ExportPlannedPerpetualAbsenceTotalsList arg)
    {
      return Client.Post<ExportPlannedPerpetualAbsenceTotalsList, ExportPlannedPerpetualAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualAbsenceTotalsListResponse> ExportPlannedPerpetualAbsenceTotalsListAsync(
      ExportPlannedPerpetualAbsenceTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualAbsenceTotalsList, ExportPlannedPerpetualAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalAbsenceTotalsListResponse ExportActualPeriodicalAbsenceTotalsList(
      ExportActualPeriodicalAbsenceTotalsList arg)
    {
      return Client.Post<ExportActualPeriodicalAbsenceTotalsList, ExportActualPeriodicalAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalAbsenceTotalsListResponse> ExportActualPeriodicalAbsenceTotalsListAsync(
      ExportActualPeriodicalAbsenceTotalsList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalAbsenceTotalsList, ExportActualPeriodicalAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalAbsenceTotalsListFromDateToDateResponse ExportActualPeriodicalAbsenceTotalsListFromDateToDate(
      ExportActualPeriodicalAbsenceTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualPeriodicalAbsenceTotalsListFromDateToDate, ExportActualPeriodicalAbsenceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalAbsenceTotalsListFromDateToDateResponse> ExportActualPeriodicalAbsenceTotalsListFromDateToDateAsync(
      ExportActualPeriodicalAbsenceTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualPeriodicalAbsenceTotalsListFromDateToDate, ExportActualPeriodicalAbsenceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalAbsenceTotalsResponse ExportActualPeriodicalAbsenceTotals(
      ExportActualPeriodicalAbsenceTotals arg)
    {
      return Client.Post<ExportActualPeriodicalAbsenceTotals, ExportActualPeriodicalAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalAbsenceTotalsResponse> ExportActualPeriodicalAbsenceTotalsAsync(
      ExportActualPeriodicalAbsenceTotals arg)
    {
      return Client.PostAsync<ExportActualPeriodicalAbsenceTotals, ExportActualPeriodicalAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualAbsenceTotalsListResponse ExportEstimatedPerpetualAbsenceTotalsList(
      ExportEstimatedPerpetualAbsenceTotalsList arg)
    {
      return Client.Post<ExportEstimatedPerpetualAbsenceTotalsList, ExportEstimatedPerpetualAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualAbsenceTotalsListResponse> ExportEstimatedPerpetualAbsenceTotalsListAsync(
      ExportEstimatedPerpetualAbsenceTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualAbsenceTotalsList, ExportEstimatedPerpetualAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualAbsenceTotalsListFromDateResponse ExportEstimatedPerpetualAbsenceTotalsListFromDate(
      ExportEstimatedPerpetualAbsenceTotalsListFromDate arg)
    {
      return Client.Post<ExportEstimatedPerpetualAbsenceTotalsListFromDate, ExportEstimatedPerpetualAbsenceTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualAbsenceTotalsListFromDateResponse> ExportEstimatedPerpetualAbsenceTotalsListFromDateAsync(
      ExportEstimatedPerpetualAbsenceTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualAbsenceTotalsListFromDate, ExportEstimatedPerpetualAbsenceTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualAbsenceTotalsFromRelativeDatesResponse ExportEstimatedPerpetualAbsenceTotalsFromRelativeDates(
      ExportEstimatedPerpetualAbsenceTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedPerpetualAbsenceTotalsFromRelativeDates, ExportEstimatedPerpetualAbsenceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualAbsenceTotalsFromRelativeDatesResponse> ExportEstimatedPerpetualAbsenceTotalsFromRelativeDatesAsync(
      ExportEstimatedPerpetualAbsenceTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualAbsenceTotalsFromRelativeDates, ExportEstimatedPerpetualAbsenceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedAbsenceTotalsFromDateToDateResponse ExportEstimatedAbsenceTotalsFromDateToDate(
      ExportEstimatedAbsenceTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedAbsenceTotalsFromDateToDate, ExportEstimatedAbsenceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedAbsenceTotalsFromDateToDateResponse> ExportEstimatedAbsenceTotalsFromDateToDateAsync(
      ExportEstimatedAbsenceTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedAbsenceTotalsFromDateToDate, ExportEstimatedAbsenceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedAbsenceTotalsFromRelativeDatesResponse ExportEstimatedAbsenceTotalsFromRelativeDates(
      ExportEstimatedAbsenceTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedAbsenceTotalsFromRelativeDates, ExportEstimatedAbsenceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedAbsenceTotalsFromRelativeDatesResponse> ExportEstimatedAbsenceTotalsFromRelativeDatesAsync(
      ExportEstimatedAbsenceTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedAbsenceTotalsFromRelativeDates, ExportEstimatedAbsenceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedAbsenceTotalsFromDateToDateResponse ExportPlannedAbsenceTotalsFromDateToDate(
      ExportPlannedAbsenceTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedAbsenceTotalsFromDateToDate, ExportPlannedAbsenceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedAbsenceTotalsFromDateToDateResponse> ExportPlannedAbsenceTotalsFromDateToDateAsync(
      ExportPlannedAbsenceTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedAbsenceTotalsFromDateToDate, ExportPlannedAbsenceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedAbsenceTotalsFromRelativeDatesResponse ExportPlannedAbsenceTotalsFromRelativeDates(
      ExportPlannedAbsenceTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedAbsenceTotalsFromRelativeDates, ExportPlannedAbsenceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedAbsenceTotalsFromRelativeDatesResponse> ExportPlannedAbsenceTotalsFromRelativeDatesAsync(
      ExportPlannedAbsenceTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedAbsenceTotalsFromRelativeDates, ExportPlannedAbsenceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportDailyAbsenceTotalsResponse ExportDailyAbsenceTotals(
      ExportDailyAbsenceTotals arg)
    {
      return Client.Post<ExportDailyAbsenceTotals, ExportDailyAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportDailyAbsenceTotalsResponse> ExportDailyAbsenceTotalsAsync(
      ExportDailyAbsenceTotals arg)
    {
      return Client.PostAsync<ExportDailyAbsenceTotals, ExportDailyAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPeriodicalAbsenceTotalsResponse ExportPeriodicalAbsenceTotals(
      ExportPeriodicalAbsenceTotals arg)
    {
      return Client.Post<ExportPeriodicalAbsenceTotals, ExportPeriodicalAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPeriodicalAbsenceTotalsResponse> ExportPeriodicalAbsenceTotalsAsync(
      ExportPeriodicalAbsenceTotals arg)
    {
      return Client.PostAsync<ExportPeriodicalAbsenceTotals, ExportPeriodicalAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPerpetualAbsenceTotalsResponse ExportPerpetualAbsenceTotals(
      ExportPerpetualAbsenceTotals arg)
    {
      return Client.Post<ExportPerpetualAbsenceTotals, ExportPerpetualAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPerpetualAbsenceTotalsResponse> ExportPerpetualAbsenceTotalsAsync(
      ExportPerpetualAbsenceTotals arg)
    {
      return Client.PostAsync<ExportPerpetualAbsenceTotals, ExportPerpetualAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyAbsenceTotalsFromDateToDateResponse ExportEstimatedDailyAbsenceTotalsFromDateToDate(
      ExportEstimatedDailyAbsenceTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedDailyAbsenceTotalsFromDateToDate, ExportEstimatedDailyAbsenceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyAbsenceTotalsFromDateToDateResponse> ExportEstimatedDailyAbsenceTotalsFromDateToDateAsync(
      ExportEstimatedDailyAbsenceTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedDailyAbsenceTotalsFromDateToDate, ExportEstimatedDailyAbsenceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyAbsenceTotalsFromPeriodResponse ExportEstimatedDailyAbsenceTotalsFromPeriod(
      ExportEstimatedDailyAbsenceTotalsFromPeriod arg)
    {
      return Client.Post<ExportEstimatedDailyAbsenceTotalsFromPeriod, ExportEstimatedDailyAbsenceTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyAbsenceTotalsFromPeriodResponse> ExportEstimatedDailyAbsenceTotalsFromPeriodAsync(
      ExportEstimatedDailyAbsenceTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportEstimatedDailyAbsenceTotalsFromPeriod, ExportEstimatedDailyAbsenceTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyAbsenceTotalsFromRelativeDatesResponse ExportEstimatedDailyAbsenceTotalsFromRelativeDates(
      ExportEstimatedDailyAbsenceTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedDailyAbsenceTotalsFromRelativeDates, ExportEstimatedDailyAbsenceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyAbsenceTotalsFromRelativeDatesResponse> ExportEstimatedDailyAbsenceTotalsFromRelativeDatesAsync(
      ExportEstimatedDailyAbsenceTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedDailyAbsenceTotalsFromRelativeDates, ExportEstimatedDailyAbsenceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyAbsenceTotalsListResponse ExportActualWeeklyAbsenceTotalsList(
      ExportActualWeeklyAbsenceTotalsList arg)
    {
      return Client.Post<ExportActualWeeklyAbsenceTotalsList, ExportActualWeeklyAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyAbsenceTotalsListResponse> ExportActualWeeklyAbsenceTotalsListAsync(
      ExportActualWeeklyAbsenceTotalsList arg)
    {
      return Client.PostAsync<ExportActualWeeklyAbsenceTotalsList, ExportActualWeeklyAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyAbsenceTotalsListFromDateToDateResponse ExportActualWeeklyAbsenceTotalsListFromDateToDate(
      ExportActualWeeklyAbsenceTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualWeeklyAbsenceTotalsListFromDateToDate, ExportActualWeeklyAbsenceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyAbsenceTotalsListFromDateToDateResponse> ExportActualWeeklyAbsenceTotalsListFromDateToDateAsync(
      ExportActualWeeklyAbsenceTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualWeeklyAbsenceTotalsListFromDateToDate, ExportActualWeeklyAbsenceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyAbsenceTotalsResponse ExportActualWeeklyAbsenceTotals(
      ExportActualWeeklyAbsenceTotals arg)
    {
      return Client.Post<ExportActualWeeklyAbsenceTotals, ExportActualWeeklyAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyAbsenceTotalsResponse> ExportActualWeeklyAbsenceTotalsAsync(
      ExportActualWeeklyAbsenceTotals arg)
    {
      return Client.PostAsync<ExportActualWeeklyAbsenceTotals, ExportActualWeeklyAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyAbsenceTotalsFromPeriodResponse ExportPlannedDailyAbsenceTotalsFromPeriod(
      ExportPlannedDailyAbsenceTotalsFromPeriod arg)
    {
      return Client.Post<ExportPlannedDailyAbsenceTotalsFromPeriod, ExportPlannedDailyAbsenceTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyAbsenceTotalsFromPeriodResponse> ExportPlannedDailyAbsenceTotalsFromPeriodAsync(
      ExportPlannedDailyAbsenceTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportPlannedDailyAbsenceTotalsFromPeriod, ExportPlannedDailyAbsenceTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyAbsenceTotalsFromRelativeDatesResponse ExportPlannedDailyAbsenceTotalsFromRelativeDates(
      ExportPlannedDailyAbsenceTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedDailyAbsenceTotalsFromRelativeDates, ExportPlannedDailyAbsenceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyAbsenceTotalsFromRelativeDatesResponse> ExportPlannedDailyAbsenceTotalsFromRelativeDatesAsync(
      ExportPlannedDailyAbsenceTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedDailyAbsenceTotalsFromRelativeDates, ExportPlannedDailyAbsenceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyAbsenceTotalsFromDateToDateResponse ExportPlannedDailyAbsenceTotalsFromDateToDate(
      ExportPlannedDailyAbsenceTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedDailyAbsenceTotalsFromDateToDate, ExportPlannedDailyAbsenceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyAbsenceTotalsFromDateToDateResponse> ExportPlannedDailyAbsenceTotalsFromDateToDateAsync(
      ExportPlannedDailyAbsenceTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedDailyAbsenceTotalsFromDateToDate, ExportPlannedDailyAbsenceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyAbsenceTotalsFromPeriodResponse ExportActualDailyAbsenceTotalsFromPeriod(
      ExportActualDailyAbsenceTotalsFromPeriod arg)
    {
      return Client.Post<ExportActualDailyAbsenceTotalsFromPeriod, ExportActualDailyAbsenceTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyAbsenceTotalsFromPeriodResponse> ExportActualDailyAbsenceTotalsFromPeriodAsync(
      ExportActualDailyAbsenceTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportActualDailyAbsenceTotalsFromPeriod, ExportActualDailyAbsenceTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyAbsenceTotalsFromDateToDateResponse ExportActualDailyAbsenceTotalsFromDateToDate(
      ExportActualDailyAbsenceTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualDailyAbsenceTotalsFromDateToDate, ExportActualDailyAbsenceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyAbsenceTotalsFromDateToDateResponse> ExportActualDailyAbsenceTotalsFromDateToDateAsync(
      ExportActualDailyAbsenceTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualDailyAbsenceTotalsFromDateToDate, ExportActualDailyAbsenceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyAbsenceTotalsFromRelativeDatesResponse ExportActualDailyAbsenceTotalsFromRelativeDates(
      ExportActualDailyAbsenceTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualDailyAbsenceTotalsFromRelativeDates, ExportActualDailyAbsenceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyAbsenceTotalsFromRelativeDatesResponse> ExportActualDailyAbsenceTotalsFromRelativeDatesAsync(
      ExportActualDailyAbsenceTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualDailyAbsenceTotalsFromRelativeDates, ExportActualDailyAbsenceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyAbsenceTotalsResponse ExportPlannedWeeklyAbsenceTotals(
      ExportPlannedWeeklyAbsenceTotals arg)
    {
      return Client.Post<ExportPlannedWeeklyAbsenceTotals, ExportPlannedWeeklyAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyAbsenceTotalsResponse> ExportPlannedWeeklyAbsenceTotalsAsync(
      ExportPlannedWeeklyAbsenceTotals arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyAbsenceTotals, ExportPlannedWeeklyAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyAbsenceTotalsListFromDateToDateResponse ExportPlannedWeeklyAbsenceTotalsListFromDateToDate(
      ExportPlannedWeeklyAbsenceTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedWeeklyAbsenceTotalsListFromDateToDate, ExportPlannedWeeklyAbsenceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyAbsenceTotalsListFromDateToDateResponse> ExportPlannedWeeklyAbsenceTotalsListFromDateToDateAsync(
      ExportPlannedWeeklyAbsenceTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyAbsenceTotalsListFromDateToDate, ExportPlannedWeeklyAbsenceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyAbsenceTotalsListResponse ExportPlannedWeeklyAbsenceTotalsList(
      ExportPlannedWeeklyAbsenceTotalsList arg)
    {
      return Client.Post<ExportPlannedWeeklyAbsenceTotalsList, ExportPlannedWeeklyAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyAbsenceTotalsListResponse> ExportPlannedWeeklyAbsenceTotalsListAsync(
      ExportPlannedWeeklyAbsenceTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyAbsenceTotalsList, ExportPlannedWeeklyAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalAbsenceTotalsListResponse ExportEstimatedPeriodicalAbsenceTotalsList(
      ExportEstimatedPeriodicalAbsenceTotalsList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalAbsenceTotalsList, ExportEstimatedPeriodicalAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalAbsenceTotalsListResponse> ExportEstimatedPeriodicalAbsenceTotalsListAsync(
      ExportEstimatedPeriodicalAbsenceTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalAbsenceTotalsList, ExportEstimatedPeriodicalAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDateResponse ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDate(
      ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDate, ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDateResponse> ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDateAsync(
      ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDate, ExportEstimatedPeriodicalAbsenceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalAbsenceTotalsResponse ExportEstimatedPeriodicalAbsenceTotals(
      ExportEstimatedPeriodicalAbsenceTotals arg)
    {
      return Client.Post<ExportEstimatedPeriodicalAbsenceTotals, ExportEstimatedPeriodicalAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalAbsenceTotalsResponse> ExportEstimatedPeriodicalAbsenceTotalsAsync(
      ExportEstimatedPeriodicalAbsenceTotals arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalAbsenceTotals, ExportEstimatedPeriodicalAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyAbsenceTotalsListResponse ExportEstimatedWeeklyAbsenceTotalsList(
      ExportEstimatedWeeklyAbsenceTotalsList arg)
    {
      return Client.Post<ExportEstimatedWeeklyAbsenceTotalsList, ExportEstimatedWeeklyAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyAbsenceTotalsListResponse> ExportEstimatedWeeklyAbsenceTotalsListAsync(
      ExportEstimatedWeeklyAbsenceTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyAbsenceTotalsList, ExportEstimatedWeeklyAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyAbsenceTotalsResponse ExportEstimatedWeeklyAbsenceTotals(
      ExportEstimatedWeeklyAbsenceTotals arg)
    {
      return Client.Post<ExportEstimatedWeeklyAbsenceTotals, ExportEstimatedWeeklyAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyAbsenceTotalsResponse> ExportEstimatedWeeklyAbsenceTotalsAsync(
      ExportEstimatedWeeklyAbsenceTotals arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyAbsenceTotals, ExportEstimatedWeeklyAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyAbsenceTotalsListFromDateToDateResponse ExportEstimatedWeeklyAbsenceTotalsListFromDateToDate(
      ExportEstimatedWeeklyAbsenceTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedWeeklyAbsenceTotalsListFromDateToDate, ExportEstimatedWeeklyAbsenceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyAbsenceTotalsListFromDateToDateResponse> ExportEstimatedWeeklyAbsenceTotalsListFromDateToDateAsync(
      ExportEstimatedWeeklyAbsenceTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyAbsenceTotalsListFromDateToDate, ExportEstimatedWeeklyAbsenceTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualAbsenceTotalsFromDateToDateResponse ExportActualAbsenceTotalsFromDateToDate(
      ExportActualAbsenceTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualAbsenceTotalsFromDateToDate, ExportActualAbsenceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualAbsenceTotalsFromDateToDateResponse> ExportActualAbsenceTotalsFromDateToDateAsync(
      ExportActualAbsenceTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualAbsenceTotalsFromDateToDate, ExportActualAbsenceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualAbsenceTotalsFromRelativeDatesResponse ExportActualAbsenceTotalsFromRelativeDates(
      ExportActualAbsenceTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualAbsenceTotalsFromRelativeDates, ExportActualAbsenceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualAbsenceTotalsFromRelativeDatesResponse> ExportActualAbsenceTotalsFromRelativeDatesAsync(
      ExportActualAbsenceTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualAbsenceTotalsFromRelativeDates, ExportActualAbsenceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualAbsenceTotalsListFromDateResponse ExportActualPerpetualAbsenceTotalsListFromDate(
      ExportActualPerpetualAbsenceTotalsListFromDate arg)
    {
      return Client.Post<ExportActualPerpetualAbsenceTotalsListFromDate, ExportActualPerpetualAbsenceTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualAbsenceTotalsListFromDateResponse> ExportActualPerpetualAbsenceTotalsListFromDateAsync(
      ExportActualPerpetualAbsenceTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportActualPerpetualAbsenceTotalsListFromDate, ExportActualPerpetualAbsenceTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualAbsenceTotalsListResponse ExportActualPerpetualAbsenceTotalsList(
      ExportActualPerpetualAbsenceTotalsList arg)
    {
      return Client.Post<ExportActualPerpetualAbsenceTotalsList, ExportActualPerpetualAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualAbsenceTotalsListResponse> ExportActualPerpetualAbsenceTotalsListAsync(
      ExportActualPerpetualAbsenceTotalsList arg)
    {
      return Client.PostAsync<ExportActualPerpetualAbsenceTotalsList, ExportActualPerpetualAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualAbsenceTotalsFromRelativeDatesResponse ExportActualPerpetualAbsenceTotalsFromRelativeDates(
      ExportActualPerpetualAbsenceTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualPerpetualAbsenceTotalsFromRelativeDates, ExportActualPerpetualAbsenceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualAbsenceTotalsFromRelativeDatesResponse> ExportActualPerpetualAbsenceTotalsFromRelativeDatesAsync(
      ExportActualPerpetualAbsenceTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualPerpetualAbsenceTotalsFromRelativeDates, ExportActualPerpetualAbsenceTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportWeeklyAbsenceTotalsListResponse ExportWeeklyAbsenceTotalsList(
      ExportWeeklyAbsenceTotalsList arg)
    {
      return Client.Post<ExportWeeklyAbsenceTotalsList, ExportWeeklyAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportWeeklyAbsenceTotalsListResponse> ExportWeeklyAbsenceTotalsListAsync(
      ExportWeeklyAbsenceTotalsList arg)
    {
      return Client.PostAsync<ExportWeeklyAbsenceTotalsList, ExportWeeklyAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportDailyAbsenceTotalsListResponse ExportDailyAbsenceTotalsList(
      ExportDailyAbsenceTotalsList arg)
    {
      return Client.Post<ExportDailyAbsenceTotalsList, ExportDailyAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportDailyAbsenceTotalsListResponse> ExportDailyAbsenceTotalsListAsync(
      ExportDailyAbsenceTotalsList arg)
    {
      return Client.PostAsync<ExportDailyAbsenceTotalsList, ExportDailyAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPerpetualAbsenceTotalsListResponse ExportPerpetualAbsenceTotalsList(
      ExportPerpetualAbsenceTotalsList arg)
    {
      return Client.Post<ExportPerpetualAbsenceTotalsList, ExportPerpetualAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPerpetualAbsenceTotalsListResponse> ExportPerpetualAbsenceTotalsListAsync(
      ExportPerpetualAbsenceTotalsList arg)
    {
      return Client.PostAsync<ExportPerpetualAbsenceTotalsList, ExportPerpetualAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportWeeklyAbsenceTotalsResponse ExportWeeklyAbsenceTotals(
      ExportWeeklyAbsenceTotals arg)
    {
      return Client.Post<ExportWeeklyAbsenceTotals, ExportWeeklyAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportWeeklyAbsenceTotalsResponse> ExportWeeklyAbsenceTotalsAsync(
      ExportWeeklyAbsenceTotals arg)
    {
      return Client.PostAsync<ExportWeeklyAbsenceTotals, ExportWeeklyAbsenceTotalsResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public ExportPeriodicalAbsenceTotalsListResponse ExportPeriodicalAbsenceTotalsList(
      ExportPeriodicalAbsenceTotalsList arg)
    {
      return Client.Post<ExportPeriodicalAbsenceTotalsList, ExportPeriodicalAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPeriodicalAbsenceTotalsListResponse> ExportPeriodicalAbsenceTotalsListAsync(
      ExportPeriodicalAbsenceTotalsList arg)
    {
      return Client.PostAsync<ExportPeriodicalAbsenceTotalsList, ExportPeriodicalAbsenceTotalsListResponse>(this.username, this.password, this.baseuri, "AbsenceTotalService", arg, this.timeoutSeconds);
    }
  }
}
