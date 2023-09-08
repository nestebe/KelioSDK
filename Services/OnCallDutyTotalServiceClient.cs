
//.OnCallDutyTotalServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class OnCallDutyTotalServiceClient
  {
    private const string service = "OnCallDutyTotalService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public OnCallDutyTotalServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportActualDailyOnCallDutyTotalsFromDateToDateForEmployeeListResponse ExportActualDailyOnCallDutyTotalsFromDateToDateForEmployeeList(
      ExportActualDailyOnCallDutyTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyOnCallDutyTotalsFromDateToDateForEmployeeList, ExportActualDailyOnCallDutyTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualDailyOnCallDutyTotalsFromDateToDateForEmployeeListResponse> ExportActualDailyOnCallDutyTotalsFromDateToDateForEmployeeListAsync(
      ExportActualDailyOnCallDutyTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyOnCallDutyTotalsFromDateToDateForEmployeeList, ExportActualDailyOnCallDutyTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualDailyOnCallDutyTotalsFromPeriodForEmployeeListResponse ExportActualDailyOnCallDutyTotalsFromPeriodForEmployeeList(
      ExportActualDailyOnCallDutyTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyOnCallDutyTotalsFromPeriodForEmployeeList, ExportActualDailyOnCallDutyTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualDailyOnCallDutyTotalsFromPeriodForEmployeeListResponse> ExportActualDailyOnCallDutyTotalsFromPeriodForEmployeeListAsync(
      ExportActualDailyOnCallDutyTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyOnCallDutyTotalsFromPeriodForEmployeeList, ExportActualDailyOnCallDutyTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeListResponse ExportActualPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeList(
      ExportActualPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeListResponse> ExportActualPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualPerpetualOnCallDutyTotalsListFromDateForEmployeeListResponse ExportActualPerpetualOnCallDutyTotalsListFromDateForEmployeeList(
      ExportActualPerpetualOnCallDutyTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualOnCallDutyTotalsListFromDateForEmployeeList, ExportActualPerpetualOnCallDutyTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualPerpetualOnCallDutyTotalsListFromDateForEmployeeListResponse> ExportActualPerpetualOnCallDutyTotalsListFromDateForEmployeeListAsync(
      ExportActualPerpetualOnCallDutyTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualOnCallDutyTotalsListFromDateForEmployeeList, ExportActualPerpetualOnCallDutyTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedPerpetualOnCallDutyTotalsListFromDateForEmployeeListResponse ExportEstimatedPerpetualOnCallDutyTotalsListFromDateForEmployeeList(
      ExportEstimatedPerpetualOnCallDutyTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualOnCallDutyTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualOnCallDutyTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualOnCallDutyTotalsListFromDateForEmployeeListResponse> ExportEstimatedPerpetualOnCallDutyTotalsListFromDateForEmployeeListAsync(
      ExportEstimatedPerpetualOnCallDutyTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualOnCallDutyTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualOnCallDutyTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualPeriodicalOnCallDutyTotalsForEmployeeListResponse ExportActualPeriodicalOnCallDutyTotalsForEmployeeList(
      ExportActualPeriodicalOnCallDutyTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalOnCallDutyTotalsForEmployeeList, ExportActualPeriodicalOnCallDutyTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualPeriodicalOnCallDutyTotalsForEmployeeListResponse> ExportActualPeriodicalOnCallDutyTotalsForEmployeeListAsync(
      ExportActualPeriodicalOnCallDutyTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalOnCallDutyTotalsForEmployeeList, ExportActualPeriodicalOnCallDutyTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedPerpetualOnCallDutyTotalsListForEmployeeListResponse ExportPlannedPerpetualOnCallDutyTotalsListForEmployeeList(
      ExportPlannedPerpetualOnCallDutyTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualOnCallDutyTotalsListForEmployeeList, ExportPlannedPerpetualOnCallDutyTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedPerpetualOnCallDutyTotalsListForEmployeeListResponse> ExportPlannedPerpetualOnCallDutyTotalsListForEmployeeListAsync(
      ExportPlannedPerpetualOnCallDutyTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualOnCallDutyTotalsListForEmployeeList, ExportPlannedPerpetualOnCallDutyTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualPerpetualOnCallDutyTotalsListForEmployeeListResponse ExportActualPerpetualOnCallDutyTotalsListForEmployeeList(
      ExportActualPerpetualOnCallDutyTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualOnCallDutyTotalsListForEmployeeList, ExportActualPerpetualOnCallDutyTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualPerpetualOnCallDutyTotalsListForEmployeeListResponse> ExportActualPerpetualOnCallDutyTotalsListForEmployeeListAsync(
      ExportActualPerpetualOnCallDutyTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualOnCallDutyTotalsListForEmployeeList, ExportActualPerpetualOnCallDutyTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedPerpetualOnCallDutyTotalsListFromDateForEmployeeListResponse ExportPlannedPerpetualOnCallDutyTotalsListFromDateForEmployeeList(
      ExportPlannedPerpetualOnCallDutyTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualOnCallDutyTotalsListFromDateForEmployeeList, ExportPlannedPerpetualOnCallDutyTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedPerpetualOnCallDutyTotalsListFromDateForEmployeeListResponse> ExportPlannedPerpetualOnCallDutyTotalsListFromDateForEmployeeListAsync(
      ExportPlannedPerpetualOnCallDutyTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualOnCallDutyTotalsListFromDateForEmployeeList, ExportPlannedPerpetualOnCallDutyTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedOnCallDutyTotalsFromDateToDateForEmployeeListResponse ExportPlannedOnCallDutyTotalsFromDateToDateForEmployeeList(
      ExportPlannedOnCallDutyTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedOnCallDutyTotalsFromDateToDateForEmployeeList, ExportPlannedOnCallDutyTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedOnCallDutyTotalsFromDateToDateForEmployeeListResponse> ExportPlannedOnCallDutyTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedOnCallDutyTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedOnCallDutyTotalsFromDateToDateForEmployeeList, ExportPlannedOnCallDutyTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualOnCallDutyTotalsFromDateToDateForEmployeeListResponse ExportActualOnCallDutyTotalsFromDateToDateForEmployeeList(
      ExportActualOnCallDutyTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualOnCallDutyTotalsFromDateToDateForEmployeeList, ExportActualOnCallDutyTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualOnCallDutyTotalsFromDateToDateForEmployeeListResponse> ExportActualOnCallDutyTotalsFromDateToDateForEmployeeListAsync(
      ExportActualOnCallDutyTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualOnCallDutyTotalsFromDateToDateForEmployeeList, ExportActualOnCallDutyTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedDailyOnCallDutyTotalsFromDateToDateForEmployeeListResponse ExportEstimatedDailyOnCallDutyTotalsFromDateToDateForEmployeeList(
      ExportEstimatedDailyOnCallDutyTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyOnCallDutyTotalsFromDateToDateForEmployeeList, ExportEstimatedDailyOnCallDutyTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedDailyOnCallDutyTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedDailyOnCallDutyTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedDailyOnCallDutyTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyOnCallDutyTotalsFromDateToDateForEmployeeList, ExportEstimatedDailyOnCallDutyTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualDailyOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse ExportActualDailyOnCallDutyTotalsFromRelativeDatesForEmployeeList(
      ExportActualDailyOnCallDutyTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyOnCallDutyTotalsFromRelativeDatesForEmployeeList, ExportActualDailyOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualDailyOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse> ExportActualDailyOnCallDutyTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualDailyOnCallDutyTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyOnCallDutyTotalsFromRelativeDatesForEmployeeList, ExportActualDailyOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedWeeklyOnCallDutyTotalsForEmployeeListResponse ExportEstimatedWeeklyOnCallDutyTotalsForEmployeeList(
      ExportEstimatedWeeklyOnCallDutyTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyOnCallDutyTotalsForEmployeeList, ExportEstimatedWeeklyOnCallDutyTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyOnCallDutyTotalsForEmployeeListResponse> ExportEstimatedWeeklyOnCallDutyTotalsForEmployeeListAsync(
      ExportEstimatedWeeklyOnCallDutyTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyOnCallDutyTotalsForEmployeeList, ExportEstimatedWeeklyOnCallDutyTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedWeeklyOnCallDutyTotalsForEmployeeListResponse ExportPlannedWeeklyOnCallDutyTotalsForEmployeeList(
      ExportPlannedWeeklyOnCallDutyTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyOnCallDutyTotalsForEmployeeList, ExportPlannedWeeklyOnCallDutyTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedWeeklyOnCallDutyTotalsForEmployeeListResponse> ExportPlannedWeeklyOnCallDutyTotalsForEmployeeListAsync(
      ExportPlannedWeeklyOnCallDutyTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyOnCallDutyTotalsForEmployeeList, ExportPlannedWeeklyOnCallDutyTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualWeeklyOnCallDutyTotalsListForEmployeeListResponse ExportActualWeeklyOnCallDutyTotalsListForEmployeeList(
      ExportActualWeeklyOnCallDutyTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyOnCallDutyTotalsListForEmployeeList, ExportActualWeeklyOnCallDutyTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualWeeklyOnCallDutyTotalsListForEmployeeListResponse> ExportActualWeeklyOnCallDutyTotalsListForEmployeeListAsync(
      ExportActualWeeklyOnCallDutyTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyOnCallDutyTotalsListForEmployeeList, ExportActualWeeklyOnCallDutyTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualWeeklyOnCallDutyTotalsForEmployeeListResponse ExportActualWeeklyOnCallDutyTotalsForEmployeeList(
      ExportActualWeeklyOnCallDutyTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyOnCallDutyTotalsForEmployeeList, ExportActualWeeklyOnCallDutyTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualWeeklyOnCallDutyTotalsForEmployeeListResponse> ExportActualWeeklyOnCallDutyTotalsForEmployeeListAsync(
      ExportActualWeeklyOnCallDutyTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyOnCallDutyTotalsForEmployeeList, ExportActualWeeklyOnCallDutyTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedDailyOnCallDutyTotalsFromPeriodForEmployeeListResponse ExportEstimatedDailyOnCallDutyTotalsFromPeriodForEmployeeList(
      ExportEstimatedDailyOnCallDutyTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyOnCallDutyTotalsFromPeriodForEmployeeList, ExportEstimatedDailyOnCallDutyTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedDailyOnCallDutyTotalsFromPeriodForEmployeeListResponse> ExportEstimatedDailyOnCallDutyTotalsFromPeriodForEmployeeListAsync(
      ExportEstimatedDailyOnCallDutyTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyOnCallDutyTotalsFromPeriodForEmployeeList, ExportEstimatedDailyOnCallDutyTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedDailyOnCallDutyTotalsFromDateToDateForEmployeeListResponse ExportPlannedDailyOnCallDutyTotalsFromDateToDateForEmployeeList(
      ExportPlannedDailyOnCallDutyTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyOnCallDutyTotalsFromDateToDateForEmployeeList, ExportPlannedDailyOnCallDutyTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedDailyOnCallDutyTotalsFromDateToDateForEmployeeListResponse> ExportPlannedDailyOnCallDutyTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedDailyOnCallDutyTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyOnCallDutyTotalsFromDateToDateForEmployeeList, ExportPlannedDailyOnCallDutyTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedDailyOnCallDutyTotalsFromPeriodForEmployeeListResponse ExportPlannedDailyOnCallDutyTotalsFromPeriodForEmployeeList(
      ExportPlannedDailyOnCallDutyTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyOnCallDutyTotalsFromPeriodForEmployeeList, ExportPlannedDailyOnCallDutyTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedDailyOnCallDutyTotalsFromPeriodForEmployeeListResponse> ExportPlannedDailyOnCallDutyTotalsFromPeriodForEmployeeListAsync(
      ExportPlannedDailyOnCallDutyTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyOnCallDutyTotalsFromPeriodForEmployeeList, ExportPlannedDailyOnCallDutyTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedPeriodicalOnCallDutyTotalsForEmployeeListResponse ExportEstimatedPeriodicalOnCallDutyTotalsForEmployeeList(
      ExportEstimatedPeriodicalOnCallDutyTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalOnCallDutyTotalsForEmployeeList, ExportEstimatedPeriodicalOnCallDutyTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalOnCallDutyTotalsForEmployeeListResponse> ExportEstimatedPeriodicalOnCallDutyTotalsForEmployeeListAsync(
      ExportEstimatedPeriodicalOnCallDutyTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalOnCallDutyTotalsForEmployeeList, ExportEstimatedPeriodicalOnCallDutyTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeListResponse ExportActualWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeList(
      ExportActualWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeList, ExportActualWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeListResponse> ExportActualWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeList, ExportActualWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse ExportActualPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeList(
      ExportActualPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse> ExportActualPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse ExportActualOnCallDutyTotalsFromRelativeDatesForEmployeeList(
      ExportActualOnCallDutyTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualOnCallDutyTotalsFromRelativeDatesForEmployeeList, ExportActualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse> ExportActualOnCallDutyTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualOnCallDutyTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualOnCallDutyTotalsFromRelativeDatesForEmployeeList, ExportActualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeListResponse ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeList(
      ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedPeriodicalOnCallDutyTotalsForEmployeeListResponse ExportPlannedPeriodicalOnCallDutyTotalsForEmployeeList(
      ExportPlannedPeriodicalOnCallDutyTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalOnCallDutyTotalsForEmployeeList, ExportPlannedPeriodicalOnCallDutyTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalOnCallDutyTotalsForEmployeeListResponse> ExportPlannedPeriodicalOnCallDutyTotalsForEmployeeListAsync(
      ExportPlannedPeriodicalOnCallDutyTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalOnCallDutyTotalsForEmployeeList, ExportPlannedPeriodicalOnCallDutyTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedOnCallDutyTotalsFromDateToDateForEmployeeListResponse ExportEstimatedOnCallDutyTotalsFromDateToDateForEmployeeList(
      ExportEstimatedOnCallDutyTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedOnCallDutyTotalsFromDateToDateForEmployeeList, ExportEstimatedOnCallDutyTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedOnCallDutyTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedOnCallDutyTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedOnCallDutyTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedOnCallDutyTotalsFromDateToDateForEmployeeList, ExportEstimatedOnCallDutyTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualPeriodicalOnCallDutyTotalsListForEmployeeListResponse ExportActualPeriodicalOnCallDutyTotalsListForEmployeeList(
      ExportActualPeriodicalOnCallDutyTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalOnCallDutyTotalsListForEmployeeList, ExportActualPeriodicalOnCallDutyTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualPeriodicalOnCallDutyTotalsListForEmployeeListResponse> ExportActualPeriodicalOnCallDutyTotalsListForEmployeeListAsync(
      ExportActualPeriodicalOnCallDutyTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalOnCallDutyTotalsListForEmployeeList, ExportActualPeriodicalOnCallDutyTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedPerpetualOnCallDutyTotalsListForEmployeeListResponse ExportEstimatedPerpetualOnCallDutyTotalsListForEmployeeList(
      ExportEstimatedPerpetualOnCallDutyTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualOnCallDutyTotalsListForEmployeeList, ExportEstimatedPerpetualOnCallDutyTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualOnCallDutyTotalsListForEmployeeListResponse> ExportEstimatedPerpetualOnCallDutyTotalsListForEmployeeListAsync(
      ExportEstimatedPerpetualOnCallDutyTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualOnCallDutyTotalsListForEmployeeList, ExportEstimatedPerpetualOnCallDutyTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedPeriodicalOnCallDutyTotalsListForEmployeeListResponse ExportPlannedPeriodicalOnCallDutyTotalsListForEmployeeList(
      ExportPlannedPeriodicalOnCallDutyTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalOnCallDutyTotalsListForEmployeeList, ExportPlannedPeriodicalOnCallDutyTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalOnCallDutyTotalsListForEmployeeListResponse> ExportPlannedPeriodicalOnCallDutyTotalsListForEmployeeListAsync(
      ExportPlannedPeriodicalOnCallDutyTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalOnCallDutyTotalsListForEmployeeList, ExportPlannedPeriodicalOnCallDutyTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeListResponse ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeList(
      ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedOnCallDutyTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedOnCallDutyTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedOnCallDutyTotalsFromRelativeDatesForEmployeeList, ExportPlannedOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedOnCallDutyTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedOnCallDutyTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedOnCallDutyTotalsFromRelativeDatesForEmployeeList, ExportPlannedOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedOnCallDutyTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedOnCallDutyTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedOnCallDutyTotalsFromRelativeDatesForEmployeeList, ExportEstimatedOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedOnCallDutyTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedOnCallDutyTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedOnCallDutyTotalsFromRelativeDatesForEmployeeList, ExportEstimatedOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedWeeklyOnCallDutyTotalsListForEmployeeListResponse ExportEstimatedWeeklyOnCallDutyTotalsListForEmployeeList(
      ExportEstimatedWeeklyOnCallDutyTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyOnCallDutyTotalsListForEmployeeList, ExportEstimatedWeeklyOnCallDutyTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyOnCallDutyTotalsListForEmployeeListResponse> ExportEstimatedWeeklyOnCallDutyTotalsListForEmployeeListAsync(
      ExportEstimatedWeeklyOnCallDutyTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyOnCallDutyTotalsListForEmployeeList, ExportEstimatedWeeklyOnCallDutyTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedWeeklyOnCallDutyTotalsListForEmployeeListResponse ExportPlannedWeeklyOnCallDutyTotalsListForEmployeeList(
      ExportPlannedWeeklyOnCallDutyTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyOnCallDutyTotalsListForEmployeeList, ExportPlannedWeeklyOnCallDutyTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedWeeklyOnCallDutyTotalsListForEmployeeListResponse> ExportPlannedWeeklyOnCallDutyTotalsListForEmployeeListAsync(
      ExportPlannedWeeklyOnCallDutyTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyOnCallDutyTotalsListForEmployeeList, ExportPlannedWeeklyOnCallDutyTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedPeriodicalOnCallDutyTotalsListForEmployeeListResponse ExportEstimatedPeriodicalOnCallDutyTotalsListForEmployeeList(
      ExportEstimatedPeriodicalOnCallDutyTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalOnCallDutyTotalsListForEmployeeList, ExportEstimatedPeriodicalOnCallDutyTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalOnCallDutyTotalsListForEmployeeListResponse> ExportEstimatedPeriodicalOnCallDutyTotalsListForEmployeeListAsync(
      ExportEstimatedPeriodicalOnCallDutyTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalOnCallDutyTotalsListForEmployeeList, ExportEstimatedPeriodicalOnCallDutyTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailyOnCallDutyTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedPeriodicalOnCallDutyTotalsResponse ExportPlannedPeriodicalOnCallDutyTotals(
      ExportPlannedPeriodicalOnCallDutyTotals arg)
    {
      return Client.Post<ExportPlannedPeriodicalOnCallDutyTotals, ExportPlannedPeriodicalOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalOnCallDutyTotalsResponse> ExportPlannedPeriodicalOnCallDutyTotalsAsync(
      ExportPlannedPeriodicalOnCallDutyTotals arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalOnCallDutyTotals, ExportPlannedPeriodicalOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedPeriodicalOnCallDutyTotalsListResponse ExportPlannedPeriodicalOnCallDutyTotalsList(
      ExportPlannedPeriodicalOnCallDutyTotalsList arg)
    {
      return Client.Post<ExportPlannedPeriodicalOnCallDutyTotalsList, ExportPlannedPeriodicalOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalOnCallDutyTotalsListResponse> ExportPlannedPeriodicalOnCallDutyTotalsListAsync(
      ExportPlannedPeriodicalOnCallDutyTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalOnCallDutyTotalsList, ExportPlannedPeriodicalOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDateResponse ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDate(
      ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDate, ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDateResponse> ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDateAsync(
      ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDate, ExportPlannedPeriodicalOnCallDutyTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDatesResponse ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDates(
      ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDates, ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDatesResponse> ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDatesAsync(
      ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDates, ExportPlannedPerpetualOnCallDutyTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedPerpetualOnCallDutyTotalsListFromDateResponse ExportPlannedPerpetualOnCallDutyTotalsListFromDate(
      ExportPlannedPerpetualOnCallDutyTotalsListFromDate arg)
    {
      return Client.Post<ExportPlannedPerpetualOnCallDutyTotalsListFromDate, ExportPlannedPerpetualOnCallDutyTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedPerpetualOnCallDutyTotalsListFromDateResponse> ExportPlannedPerpetualOnCallDutyTotalsListFromDateAsync(
      ExportPlannedPerpetualOnCallDutyTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualOnCallDutyTotalsListFromDate, ExportPlannedPerpetualOnCallDutyTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedPerpetualOnCallDutyTotalsListResponse ExportPlannedPerpetualOnCallDutyTotalsList(
      ExportPlannedPerpetualOnCallDutyTotalsList arg)
    {
      return Client.Post<ExportPlannedPerpetualOnCallDutyTotalsList, ExportPlannedPerpetualOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedPerpetualOnCallDutyTotalsListResponse> ExportPlannedPerpetualOnCallDutyTotalsListAsync(
      ExportPlannedPerpetualOnCallDutyTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualOnCallDutyTotalsList, ExportPlannedPerpetualOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualPeriodicalOnCallDutyTotalsListResponse ExportActualPeriodicalOnCallDutyTotalsList(
      ExportActualPeriodicalOnCallDutyTotalsList arg)
    {
      return Client.Post<ExportActualPeriodicalOnCallDutyTotalsList, ExportActualPeriodicalOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualPeriodicalOnCallDutyTotalsListResponse> ExportActualPeriodicalOnCallDutyTotalsListAsync(
      ExportActualPeriodicalOnCallDutyTotalsList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalOnCallDutyTotalsList, ExportActualPeriodicalOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualPeriodicalOnCallDutyTotalsListFromDateToDateResponse ExportActualPeriodicalOnCallDutyTotalsListFromDateToDate(
      ExportActualPeriodicalOnCallDutyTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualPeriodicalOnCallDutyTotalsListFromDateToDate, ExportActualPeriodicalOnCallDutyTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualPeriodicalOnCallDutyTotalsListFromDateToDateResponse> ExportActualPeriodicalOnCallDutyTotalsListFromDateToDateAsync(
      ExportActualPeriodicalOnCallDutyTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualPeriodicalOnCallDutyTotalsListFromDateToDate, ExportActualPeriodicalOnCallDutyTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualPeriodicalOnCallDutyTotalsResponse ExportActualPeriodicalOnCallDutyTotals(
      ExportActualPeriodicalOnCallDutyTotals arg)
    {
      return Client.Post<ExportActualPeriodicalOnCallDutyTotals, ExportActualPeriodicalOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualPeriodicalOnCallDutyTotalsResponse> ExportActualPeriodicalOnCallDutyTotalsAsync(
      ExportActualPeriodicalOnCallDutyTotals arg)
    {
      return Client.PostAsync<ExportActualPeriodicalOnCallDutyTotals, ExportActualPeriodicalOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedPerpetualOnCallDutyTotalsListResponse ExportEstimatedPerpetualOnCallDutyTotalsList(
      ExportEstimatedPerpetualOnCallDutyTotalsList arg)
    {
      return Client.Post<ExportEstimatedPerpetualOnCallDutyTotalsList, ExportEstimatedPerpetualOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualOnCallDutyTotalsListResponse> ExportEstimatedPerpetualOnCallDutyTotalsListAsync(
      ExportEstimatedPerpetualOnCallDutyTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualOnCallDutyTotalsList, ExportEstimatedPerpetualOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedPerpetualOnCallDutyTotalsListFromDateResponse ExportEstimatedPerpetualOnCallDutyTotalsListFromDate(
      ExportEstimatedPerpetualOnCallDutyTotalsListFromDate arg)
    {
      return Client.Post<ExportEstimatedPerpetualOnCallDutyTotalsListFromDate, ExportEstimatedPerpetualOnCallDutyTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualOnCallDutyTotalsListFromDateResponse> ExportEstimatedPerpetualOnCallDutyTotalsListFromDateAsync(
      ExportEstimatedPerpetualOnCallDutyTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualOnCallDutyTotalsListFromDate, ExportEstimatedPerpetualOnCallDutyTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDatesResponse ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDates(
      ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDates, ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDatesResponse> ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDatesAsync(
      ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDates, ExportEstimatedPerpetualOnCallDutyTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedOnCallDutyTotalsFromDateToDateResponse ExportEstimatedOnCallDutyTotalsFromDateToDate(
      ExportEstimatedOnCallDutyTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedOnCallDutyTotalsFromDateToDate, ExportEstimatedOnCallDutyTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedOnCallDutyTotalsFromDateToDateResponse> ExportEstimatedOnCallDutyTotalsFromDateToDateAsync(
      ExportEstimatedOnCallDutyTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedOnCallDutyTotalsFromDateToDate, ExportEstimatedOnCallDutyTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedOnCallDutyTotalsFromRelativeDatesResponse ExportEstimatedOnCallDutyTotalsFromRelativeDates(
      ExportEstimatedOnCallDutyTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedOnCallDutyTotalsFromRelativeDates, ExportEstimatedOnCallDutyTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedOnCallDutyTotalsFromRelativeDatesResponse> ExportEstimatedOnCallDutyTotalsFromRelativeDatesAsync(
      ExportEstimatedOnCallDutyTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedOnCallDutyTotalsFromRelativeDates, ExportEstimatedOnCallDutyTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedOnCallDutyTotalsFromDateToDateResponse ExportPlannedOnCallDutyTotalsFromDateToDate(
      ExportPlannedOnCallDutyTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedOnCallDutyTotalsFromDateToDate, ExportPlannedOnCallDutyTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedOnCallDutyTotalsFromDateToDateResponse> ExportPlannedOnCallDutyTotalsFromDateToDateAsync(
      ExportPlannedOnCallDutyTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedOnCallDutyTotalsFromDateToDate, ExportPlannedOnCallDutyTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedOnCallDutyTotalsFromRelativeDatesResponse ExportPlannedOnCallDutyTotalsFromRelativeDates(
      ExportPlannedOnCallDutyTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedOnCallDutyTotalsFromRelativeDates, ExportPlannedOnCallDutyTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedOnCallDutyTotalsFromRelativeDatesResponse> ExportPlannedOnCallDutyTotalsFromRelativeDatesAsync(
      ExportPlannedOnCallDutyTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedOnCallDutyTotalsFromRelativeDates, ExportPlannedOnCallDutyTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportDailyOnCallDutyTotalsResponse ExportDailyOnCallDutyTotals(
      ExportDailyOnCallDutyTotals arg)
    {
      return Client.Post<ExportDailyOnCallDutyTotals, ExportDailyOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportDailyOnCallDutyTotalsResponse> ExportDailyOnCallDutyTotalsAsync(
      ExportDailyOnCallDutyTotals arg)
    {
      return Client.PostAsync<ExportDailyOnCallDutyTotals, ExportDailyOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPeriodicalOnCallDutyTotalsResponse ExportPeriodicalOnCallDutyTotals(
      ExportPeriodicalOnCallDutyTotals arg)
    {
      return Client.Post<ExportPeriodicalOnCallDutyTotals, ExportPeriodicalOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPeriodicalOnCallDutyTotalsResponse> ExportPeriodicalOnCallDutyTotalsAsync(
      ExportPeriodicalOnCallDutyTotals arg)
    {
      return Client.PostAsync<ExportPeriodicalOnCallDutyTotals, ExportPeriodicalOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPerpetualOnCallDutyTotalsResponse ExportPerpetualOnCallDutyTotals(
      ExportPerpetualOnCallDutyTotals arg)
    {
      return Client.Post<ExportPerpetualOnCallDutyTotals, ExportPerpetualOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPerpetualOnCallDutyTotalsResponse> ExportPerpetualOnCallDutyTotalsAsync(
      ExportPerpetualOnCallDutyTotals arg)
    {
      return Client.PostAsync<ExportPerpetualOnCallDutyTotals, ExportPerpetualOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedDailyOnCallDutyTotalsFromDateToDateResponse ExportEstimatedDailyOnCallDutyTotalsFromDateToDate(
      ExportEstimatedDailyOnCallDutyTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedDailyOnCallDutyTotalsFromDateToDate, ExportEstimatedDailyOnCallDutyTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedDailyOnCallDutyTotalsFromDateToDateResponse> ExportEstimatedDailyOnCallDutyTotalsFromDateToDateAsync(
      ExportEstimatedDailyOnCallDutyTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedDailyOnCallDutyTotalsFromDateToDate, ExportEstimatedDailyOnCallDutyTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedDailyOnCallDutyTotalsFromPeriodResponse ExportEstimatedDailyOnCallDutyTotalsFromPeriod(
      ExportEstimatedDailyOnCallDutyTotalsFromPeriod arg)
    {
      return Client.Post<ExportEstimatedDailyOnCallDutyTotalsFromPeriod, ExportEstimatedDailyOnCallDutyTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedDailyOnCallDutyTotalsFromPeriodResponse> ExportEstimatedDailyOnCallDutyTotalsFromPeriodAsync(
      ExportEstimatedDailyOnCallDutyTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportEstimatedDailyOnCallDutyTotalsFromPeriod, ExportEstimatedDailyOnCallDutyTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedDailyOnCallDutyTotalsFromRelativeDatesResponse ExportEstimatedDailyOnCallDutyTotalsFromRelativeDates(
      ExportEstimatedDailyOnCallDutyTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedDailyOnCallDutyTotalsFromRelativeDates, ExportEstimatedDailyOnCallDutyTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedDailyOnCallDutyTotalsFromRelativeDatesResponse> ExportEstimatedDailyOnCallDutyTotalsFromRelativeDatesAsync(
      ExportEstimatedDailyOnCallDutyTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedDailyOnCallDutyTotalsFromRelativeDates, ExportEstimatedDailyOnCallDutyTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualWeeklyOnCallDutyTotalsListResponse ExportActualWeeklyOnCallDutyTotalsList(
      ExportActualWeeklyOnCallDutyTotalsList arg)
    {
      return Client.Post<ExportActualWeeklyOnCallDutyTotalsList, ExportActualWeeklyOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualWeeklyOnCallDutyTotalsListResponse> ExportActualWeeklyOnCallDutyTotalsListAsync(
      ExportActualWeeklyOnCallDutyTotalsList arg)
    {
      return Client.PostAsync<ExportActualWeeklyOnCallDutyTotalsList, ExportActualWeeklyOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualWeeklyOnCallDutyTotalsListFromDateToDateResponse ExportActualWeeklyOnCallDutyTotalsListFromDateToDate(
      ExportActualWeeklyOnCallDutyTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualWeeklyOnCallDutyTotalsListFromDateToDate, ExportActualWeeklyOnCallDutyTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualWeeklyOnCallDutyTotalsListFromDateToDateResponse> ExportActualWeeklyOnCallDutyTotalsListFromDateToDateAsync(
      ExportActualWeeklyOnCallDutyTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualWeeklyOnCallDutyTotalsListFromDateToDate, ExportActualWeeklyOnCallDutyTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualWeeklyOnCallDutyTotalsResponse ExportActualWeeklyOnCallDutyTotals(
      ExportActualWeeklyOnCallDutyTotals arg)
    {
      return Client.Post<ExportActualWeeklyOnCallDutyTotals, ExportActualWeeklyOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualWeeklyOnCallDutyTotalsResponse> ExportActualWeeklyOnCallDutyTotalsAsync(
      ExportActualWeeklyOnCallDutyTotals arg)
    {
      return Client.PostAsync<ExportActualWeeklyOnCallDutyTotals, ExportActualWeeklyOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedDailyOnCallDutyTotalsFromPeriodResponse ExportPlannedDailyOnCallDutyTotalsFromPeriod(
      ExportPlannedDailyOnCallDutyTotalsFromPeriod arg)
    {
      return Client.Post<ExportPlannedDailyOnCallDutyTotalsFromPeriod, ExportPlannedDailyOnCallDutyTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedDailyOnCallDutyTotalsFromPeriodResponse> ExportPlannedDailyOnCallDutyTotalsFromPeriodAsync(
      ExportPlannedDailyOnCallDutyTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportPlannedDailyOnCallDutyTotalsFromPeriod, ExportPlannedDailyOnCallDutyTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedDailyOnCallDutyTotalsFromRelativeDatesResponse ExportPlannedDailyOnCallDutyTotalsFromRelativeDates(
      ExportPlannedDailyOnCallDutyTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedDailyOnCallDutyTotalsFromRelativeDates, ExportPlannedDailyOnCallDutyTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedDailyOnCallDutyTotalsFromRelativeDatesResponse> ExportPlannedDailyOnCallDutyTotalsFromRelativeDatesAsync(
      ExportPlannedDailyOnCallDutyTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedDailyOnCallDutyTotalsFromRelativeDates, ExportPlannedDailyOnCallDutyTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedDailyOnCallDutyTotalsFromDateToDateResponse ExportPlannedDailyOnCallDutyTotalsFromDateToDate(
      ExportPlannedDailyOnCallDutyTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedDailyOnCallDutyTotalsFromDateToDate, ExportPlannedDailyOnCallDutyTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedDailyOnCallDutyTotalsFromDateToDateResponse> ExportPlannedDailyOnCallDutyTotalsFromDateToDateAsync(
      ExportPlannedDailyOnCallDutyTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedDailyOnCallDutyTotalsFromDateToDate, ExportPlannedDailyOnCallDutyTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualDailyOnCallDutyTotalsFromPeriodResponse ExportActualDailyOnCallDutyTotalsFromPeriod(
      ExportActualDailyOnCallDutyTotalsFromPeriod arg)
    {
      return Client.Post<ExportActualDailyOnCallDutyTotalsFromPeriod, ExportActualDailyOnCallDutyTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualDailyOnCallDutyTotalsFromPeriodResponse> ExportActualDailyOnCallDutyTotalsFromPeriodAsync(
      ExportActualDailyOnCallDutyTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportActualDailyOnCallDutyTotalsFromPeriod, ExportActualDailyOnCallDutyTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualDailyOnCallDutyTotalsFromDateToDateResponse ExportActualDailyOnCallDutyTotalsFromDateToDate(
      ExportActualDailyOnCallDutyTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualDailyOnCallDutyTotalsFromDateToDate, ExportActualDailyOnCallDutyTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualDailyOnCallDutyTotalsFromDateToDateResponse> ExportActualDailyOnCallDutyTotalsFromDateToDateAsync(
      ExportActualDailyOnCallDutyTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualDailyOnCallDutyTotalsFromDateToDate, ExportActualDailyOnCallDutyTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualDailyOnCallDutyTotalsFromRelativeDatesResponse ExportActualDailyOnCallDutyTotalsFromRelativeDates(
      ExportActualDailyOnCallDutyTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualDailyOnCallDutyTotalsFromRelativeDates, ExportActualDailyOnCallDutyTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualDailyOnCallDutyTotalsFromRelativeDatesResponse> ExportActualDailyOnCallDutyTotalsFromRelativeDatesAsync(
      ExportActualDailyOnCallDutyTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualDailyOnCallDutyTotalsFromRelativeDates, ExportActualDailyOnCallDutyTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedWeeklyOnCallDutyTotalsResponse ExportPlannedWeeklyOnCallDutyTotals(
      ExportPlannedWeeklyOnCallDutyTotals arg)
    {
      return Client.Post<ExportPlannedWeeklyOnCallDutyTotals, ExportPlannedWeeklyOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedWeeklyOnCallDutyTotalsResponse> ExportPlannedWeeklyOnCallDutyTotalsAsync(
      ExportPlannedWeeklyOnCallDutyTotals arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyOnCallDutyTotals, ExportPlannedWeeklyOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDateResponse ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDate(
      ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDate, ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDateResponse> ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDateAsync(
      ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDate, ExportPlannedWeeklyOnCallDutyTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPlannedWeeklyOnCallDutyTotalsListResponse ExportPlannedWeeklyOnCallDutyTotalsList(
      ExportPlannedWeeklyOnCallDutyTotalsList arg)
    {
      return Client.Post<ExportPlannedWeeklyOnCallDutyTotalsList, ExportPlannedWeeklyOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPlannedWeeklyOnCallDutyTotalsListResponse> ExportPlannedWeeklyOnCallDutyTotalsListAsync(
      ExportPlannedWeeklyOnCallDutyTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyOnCallDutyTotalsList, ExportPlannedWeeklyOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedPeriodicalOnCallDutyTotalsListResponse ExportEstimatedPeriodicalOnCallDutyTotalsList(
      ExportEstimatedPeriodicalOnCallDutyTotalsList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalOnCallDutyTotalsList, ExportEstimatedPeriodicalOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalOnCallDutyTotalsListResponse> ExportEstimatedPeriodicalOnCallDutyTotalsListAsync(
      ExportEstimatedPeriodicalOnCallDutyTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalOnCallDutyTotalsList, ExportEstimatedPeriodicalOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDateResponse ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDate(
      ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDate, ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDateResponse> ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDateAsync(
      ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDate, ExportEstimatedPeriodicalOnCallDutyTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedPeriodicalOnCallDutyTotalsResponse ExportEstimatedPeriodicalOnCallDutyTotals(
      ExportEstimatedPeriodicalOnCallDutyTotals arg)
    {
      return Client.Post<ExportEstimatedPeriodicalOnCallDutyTotals, ExportEstimatedPeriodicalOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalOnCallDutyTotalsResponse> ExportEstimatedPeriodicalOnCallDutyTotalsAsync(
      ExportEstimatedPeriodicalOnCallDutyTotals arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalOnCallDutyTotals, ExportEstimatedPeriodicalOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedWeeklyOnCallDutyTotalsListResponse ExportEstimatedWeeklyOnCallDutyTotalsList(
      ExportEstimatedWeeklyOnCallDutyTotalsList arg)
    {
      return Client.Post<ExportEstimatedWeeklyOnCallDutyTotalsList, ExportEstimatedWeeklyOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyOnCallDutyTotalsListResponse> ExportEstimatedWeeklyOnCallDutyTotalsListAsync(
      ExportEstimatedWeeklyOnCallDutyTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyOnCallDutyTotalsList, ExportEstimatedWeeklyOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedWeeklyOnCallDutyTotalsResponse ExportEstimatedWeeklyOnCallDutyTotals(
      ExportEstimatedWeeklyOnCallDutyTotals arg)
    {
      return Client.Post<ExportEstimatedWeeklyOnCallDutyTotals, ExportEstimatedWeeklyOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyOnCallDutyTotalsResponse> ExportEstimatedWeeklyOnCallDutyTotalsAsync(
      ExportEstimatedWeeklyOnCallDutyTotals arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyOnCallDutyTotals, ExportEstimatedWeeklyOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDateResponse ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDate(
      ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDate, ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDateResponse> ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDateAsync(
      ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDate, ExportEstimatedWeeklyOnCallDutyTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualOnCallDutyTotalsFromDateToDateResponse ExportActualOnCallDutyTotalsFromDateToDate(
      ExportActualOnCallDutyTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualOnCallDutyTotalsFromDateToDate, ExportActualOnCallDutyTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualOnCallDutyTotalsFromDateToDateResponse> ExportActualOnCallDutyTotalsFromDateToDateAsync(
      ExportActualOnCallDutyTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualOnCallDutyTotalsFromDateToDate, ExportActualOnCallDutyTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualOnCallDutyTotalsFromRelativeDatesResponse ExportActualOnCallDutyTotalsFromRelativeDates(
      ExportActualOnCallDutyTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualOnCallDutyTotalsFromRelativeDates, ExportActualOnCallDutyTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualOnCallDutyTotalsFromRelativeDatesResponse> ExportActualOnCallDutyTotalsFromRelativeDatesAsync(
      ExportActualOnCallDutyTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualOnCallDutyTotalsFromRelativeDates, ExportActualOnCallDutyTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualPerpetualOnCallDutyTotalsListFromDateResponse ExportActualPerpetualOnCallDutyTotalsListFromDate(
      ExportActualPerpetualOnCallDutyTotalsListFromDate arg)
    {
      return Client.Post<ExportActualPerpetualOnCallDutyTotalsListFromDate, ExportActualPerpetualOnCallDutyTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualPerpetualOnCallDutyTotalsListFromDateResponse> ExportActualPerpetualOnCallDutyTotalsListFromDateAsync(
      ExportActualPerpetualOnCallDutyTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportActualPerpetualOnCallDutyTotalsListFromDate, ExportActualPerpetualOnCallDutyTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualPerpetualOnCallDutyTotalsListResponse ExportActualPerpetualOnCallDutyTotalsList(
      ExportActualPerpetualOnCallDutyTotalsList arg)
    {
      return Client.Post<ExportActualPerpetualOnCallDutyTotalsList, ExportActualPerpetualOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualPerpetualOnCallDutyTotalsListResponse> ExportActualPerpetualOnCallDutyTotalsListAsync(
      ExportActualPerpetualOnCallDutyTotalsList arg)
    {
      return Client.PostAsync<ExportActualPerpetualOnCallDutyTotalsList, ExportActualPerpetualOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportActualPerpetualOnCallDutyTotalsFromRelativeDatesResponse ExportActualPerpetualOnCallDutyTotalsFromRelativeDates(
      ExportActualPerpetualOnCallDutyTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualPerpetualOnCallDutyTotalsFromRelativeDates, ExportActualPerpetualOnCallDutyTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportActualPerpetualOnCallDutyTotalsFromRelativeDatesResponse> ExportActualPerpetualOnCallDutyTotalsFromRelativeDatesAsync(
      ExportActualPerpetualOnCallDutyTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualPerpetualOnCallDutyTotalsFromRelativeDates, ExportActualPerpetualOnCallDutyTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportWeeklyOnCallDutyTotalsListResponse ExportWeeklyOnCallDutyTotalsList(
      ExportWeeklyOnCallDutyTotalsList arg)
    {
      return Client.Post<ExportWeeklyOnCallDutyTotalsList, ExportWeeklyOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportWeeklyOnCallDutyTotalsListResponse> ExportWeeklyOnCallDutyTotalsListAsync(
      ExportWeeklyOnCallDutyTotalsList arg)
    {
      return Client.PostAsync<ExportWeeklyOnCallDutyTotalsList, ExportWeeklyOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportDailyOnCallDutyTotalsListResponse ExportDailyOnCallDutyTotalsList(
      ExportDailyOnCallDutyTotalsList arg)
    {
      return Client.Post<ExportDailyOnCallDutyTotalsList, ExportDailyOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportDailyOnCallDutyTotalsListResponse> ExportDailyOnCallDutyTotalsListAsync(
      ExportDailyOnCallDutyTotalsList arg)
    {
      return Client.PostAsync<ExportDailyOnCallDutyTotalsList, ExportDailyOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPerpetualOnCallDutyTotalsListResponse ExportPerpetualOnCallDutyTotalsList(
      ExportPerpetualOnCallDutyTotalsList arg)
    {
      return Client.Post<ExportPerpetualOnCallDutyTotalsList, ExportPerpetualOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPerpetualOnCallDutyTotalsListResponse> ExportPerpetualOnCallDutyTotalsListAsync(
      ExportPerpetualOnCallDutyTotalsList arg)
    {
      return Client.PostAsync<ExportPerpetualOnCallDutyTotalsList, ExportPerpetualOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportWeeklyOnCallDutyTotalsResponse ExportWeeklyOnCallDutyTotals(
      ExportWeeklyOnCallDutyTotals arg)
    {
      return Client.Post<ExportWeeklyOnCallDutyTotals, ExportWeeklyOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportWeeklyOnCallDutyTotalsResponse> ExportWeeklyOnCallDutyTotalsAsync(
      ExportWeeklyOnCallDutyTotals arg)
    {
      return Client.PostAsync<ExportWeeklyOnCallDutyTotals, ExportWeeklyOnCallDutyTotalsResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public ExportPeriodicalOnCallDutyTotalsListResponse ExportPeriodicalOnCallDutyTotalsList(
      ExportPeriodicalOnCallDutyTotalsList arg)
    {
      return Client.Post<ExportPeriodicalOnCallDutyTotalsList, ExportPeriodicalOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }

    public Task<ExportPeriodicalOnCallDutyTotalsListResponse> ExportPeriodicalOnCallDutyTotalsListAsync(
      ExportPeriodicalOnCallDutyTotalsList arg)
    {
      return Client.PostAsync<ExportPeriodicalOnCallDutyTotalsList, ExportPeriodicalOnCallDutyTotalsListResponse>(this.username, this.password, this.baseuri, "OnCallDutyTotalService", arg);
    }
  }
}
