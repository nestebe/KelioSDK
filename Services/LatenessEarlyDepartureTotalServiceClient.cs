
//.LatenessEarlyDepartureTotalServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class LatenessEarlyDepartureTotalServiceClient
  {
    private const string service = "LatenessEarlyDepartureTotalService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public LatenessEarlyDepartureTotalServiceClient(
      string username,
      string password,
      string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList(
      ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList, ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse> ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListAsync(
      ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList, ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeListResponse ExportActualDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeList(
      ExportActualDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeList, ExportActualDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeListResponse> ExportActualDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeListAsync(
      ExportActualDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeList, ExportActualDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList(
      ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse> ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeListResponse ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeList(
      ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeList, ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeListResponse> ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeListAsync(
      ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeList, ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeListResponse ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeList(
      ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeListResponse> ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeListAsync(
      ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalLatenessEarlyDepartureTotalsForEmployeeListResponse ExportActualPeriodicalLatenessEarlyDepartureTotalsForEmployeeList(
      ExportActualPeriodicalLatenessEarlyDepartureTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalLatenessEarlyDepartureTotalsForEmployeeList, ExportActualPeriodicalLatenessEarlyDepartureTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalLatenessEarlyDepartureTotalsForEmployeeListResponse> ExportActualPeriodicalLatenessEarlyDepartureTotalsForEmployeeListAsync(
      ExportActualPeriodicalLatenessEarlyDepartureTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalLatenessEarlyDepartureTotalsForEmployeeList, ExportActualPeriodicalLatenessEarlyDepartureTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualLatenessEarlyDepartureTotalsListForEmployeeListResponse ExportPlannedPerpetualLatenessEarlyDepartureTotalsListForEmployeeList(
      ExportPlannedPerpetualLatenessEarlyDepartureTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualLatenessEarlyDepartureTotalsListForEmployeeList, ExportPlannedPerpetualLatenessEarlyDepartureTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualLatenessEarlyDepartureTotalsListForEmployeeListResponse> ExportPlannedPerpetualLatenessEarlyDepartureTotalsListForEmployeeListAsync(
      ExportPlannedPerpetualLatenessEarlyDepartureTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualLatenessEarlyDepartureTotalsListForEmployeeList, ExportPlannedPerpetualLatenessEarlyDepartureTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualLatenessEarlyDepartureTotalsListForEmployeeListResponse ExportActualPerpetualLatenessEarlyDepartureTotalsListForEmployeeList(
      ExportActualPerpetualLatenessEarlyDepartureTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualLatenessEarlyDepartureTotalsListForEmployeeList, ExportActualPerpetualLatenessEarlyDepartureTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualLatenessEarlyDepartureTotalsListForEmployeeListResponse> ExportActualPerpetualLatenessEarlyDepartureTotalsListForEmployeeListAsync(
      ExportActualPerpetualLatenessEarlyDepartureTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualLatenessEarlyDepartureTotalsListForEmployeeList, ExportActualPerpetualLatenessEarlyDepartureTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeListResponse ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeList(
      ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeList, ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeListResponse> ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeListAsync(
      ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeList, ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse ExportPlannedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList(
      ExportPlannedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList, ExportPlannedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse> ExportPlannedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList, ExportPlannedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse ExportActualLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList(
      ExportActualLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList, ExportActualLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse> ExportActualLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListAsync(
      ExportActualLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList, ExportActualLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList(
      ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList, ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList, ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList(
      ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList, ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse> ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList, ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyLatenessEarlyDepartureTotalsForEmployeeListResponse ExportEstimatedWeeklyLatenessEarlyDepartureTotalsForEmployeeList(
      ExportEstimatedWeeklyLatenessEarlyDepartureTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyLatenessEarlyDepartureTotalsForEmployeeList, ExportEstimatedWeeklyLatenessEarlyDepartureTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyLatenessEarlyDepartureTotalsForEmployeeListResponse> ExportEstimatedWeeklyLatenessEarlyDepartureTotalsForEmployeeListAsync(
      ExportEstimatedWeeklyLatenessEarlyDepartureTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyLatenessEarlyDepartureTotalsForEmployeeList, ExportEstimatedWeeklyLatenessEarlyDepartureTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyLatenessEarlyDepartureTotalsForEmployeeListResponse ExportPlannedWeeklyLatenessEarlyDepartureTotalsForEmployeeList(
      ExportPlannedWeeklyLatenessEarlyDepartureTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyLatenessEarlyDepartureTotalsForEmployeeList, ExportPlannedWeeklyLatenessEarlyDepartureTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyLatenessEarlyDepartureTotalsForEmployeeListResponse> ExportPlannedWeeklyLatenessEarlyDepartureTotalsForEmployeeListAsync(
      ExportPlannedWeeklyLatenessEarlyDepartureTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyLatenessEarlyDepartureTotalsForEmployeeList, ExportPlannedWeeklyLatenessEarlyDepartureTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyLatenessEarlyDepartureTotalsListForEmployeeListResponse ExportActualWeeklyLatenessEarlyDepartureTotalsListForEmployeeList(
      ExportActualWeeklyLatenessEarlyDepartureTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyLatenessEarlyDepartureTotalsListForEmployeeList, ExportActualWeeklyLatenessEarlyDepartureTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyLatenessEarlyDepartureTotalsListForEmployeeListResponse> ExportActualWeeklyLatenessEarlyDepartureTotalsListForEmployeeListAsync(
      ExportActualWeeklyLatenessEarlyDepartureTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyLatenessEarlyDepartureTotalsListForEmployeeList, ExportActualWeeklyLatenessEarlyDepartureTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyLatenessEarlyDepartureTotalsForEmployeeListResponse ExportActualWeeklyLatenessEarlyDepartureTotalsForEmployeeList(
      ExportActualWeeklyLatenessEarlyDepartureTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyLatenessEarlyDepartureTotalsForEmployeeList, ExportActualWeeklyLatenessEarlyDepartureTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyLatenessEarlyDepartureTotalsForEmployeeListResponse> ExportActualWeeklyLatenessEarlyDepartureTotalsForEmployeeListAsync(
      ExportActualWeeklyLatenessEarlyDepartureTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyLatenessEarlyDepartureTotalsForEmployeeList, ExportActualWeeklyLatenessEarlyDepartureTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeListResponse ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeList(
      ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeList, ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeListResponse> ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeListAsync(
      ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeList, ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList(
      ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList, ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse> ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList, ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeListResponse ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeList(
      ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeList, ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeListResponse> ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeListAsync(
      ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeList, ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsForEmployeeListResponse ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsForEmployeeList(
      ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsForEmployeeList, ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsForEmployeeListResponse> ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsForEmployeeListAsync(
      ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsForEmployeeList, ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList(
      ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList, ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse> ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList, ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList(
      ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse> ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse ExportActualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList(
      ExportActualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList, ExportActualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse> ExportActualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList, ExportActualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList(
      ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalLatenessEarlyDepartureTotalsForEmployeeListResponse ExportPlannedPeriodicalLatenessEarlyDepartureTotalsForEmployeeList(
      ExportPlannedPeriodicalLatenessEarlyDepartureTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalLatenessEarlyDepartureTotalsForEmployeeList, ExportPlannedPeriodicalLatenessEarlyDepartureTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalLatenessEarlyDepartureTotalsForEmployeeListResponse> ExportPlannedPeriodicalLatenessEarlyDepartureTotalsForEmployeeListAsync(
      ExportPlannedPeriodicalLatenessEarlyDepartureTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalLatenessEarlyDepartureTotalsForEmployeeList, ExportPlannedPeriodicalLatenessEarlyDepartureTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList(
      ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList, ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeList, ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalLatenessEarlyDepartureTotalsListForEmployeeListResponse ExportActualPeriodicalLatenessEarlyDepartureTotalsListForEmployeeList(
      ExportActualPeriodicalLatenessEarlyDepartureTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalLatenessEarlyDepartureTotalsListForEmployeeList, ExportActualPeriodicalLatenessEarlyDepartureTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalLatenessEarlyDepartureTotalsListForEmployeeListResponse> ExportActualPeriodicalLatenessEarlyDepartureTotalsListForEmployeeListAsync(
      ExportActualPeriodicalLatenessEarlyDepartureTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalLatenessEarlyDepartureTotalsListForEmployeeList, ExportActualPeriodicalLatenessEarlyDepartureTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListForEmployeeListResponse ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListForEmployeeList(
      ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListForEmployeeList, ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListForEmployeeListResponse> ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListForEmployeeListAsync(
      ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListForEmployeeList, ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeListResponse ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeList(
      ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeList, ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeListResponse> ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeListAsync(
      ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeList, ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList(
      ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList, ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList, ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList, ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList, ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListForEmployeeListResponse ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListForEmployeeList(
      ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListForEmployeeList, ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListForEmployeeListResponse> ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListForEmployeeListAsync(
      ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListForEmployeeList, ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyLatenessEarlyDepartureTotalsListForEmployeeListResponse ExportPlannedWeeklyLatenessEarlyDepartureTotalsListForEmployeeList(
      ExportPlannedWeeklyLatenessEarlyDepartureTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyLatenessEarlyDepartureTotalsListForEmployeeList, ExportPlannedWeeklyLatenessEarlyDepartureTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyLatenessEarlyDepartureTotalsListForEmployeeListResponse> ExportPlannedWeeklyLatenessEarlyDepartureTotalsListForEmployeeListAsync(
      ExportPlannedWeeklyLatenessEarlyDepartureTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyLatenessEarlyDepartureTotalsListForEmployeeList, ExportPlannedWeeklyLatenessEarlyDepartureTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeListResponse ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeList(
      ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeList, ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeListResponse> ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeListAsync(
      ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeList, ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalLatenessEarlyDepartureTotalsResponse ExportPlannedPeriodicalLatenessEarlyDepartureTotals(
      ExportPlannedPeriodicalLatenessEarlyDepartureTotals arg)
    {
      return Client.Post<ExportPlannedPeriodicalLatenessEarlyDepartureTotals, ExportPlannedPeriodicalLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalLatenessEarlyDepartureTotalsResponse> ExportPlannedPeriodicalLatenessEarlyDepartureTotalsAsync(
      ExportPlannedPeriodicalLatenessEarlyDepartureTotals arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalLatenessEarlyDepartureTotals, ExportPlannedPeriodicalLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListResponse ExportPlannedPeriodicalLatenessEarlyDepartureTotalsList(
      ExportPlannedPeriodicalLatenessEarlyDepartureTotalsList arg)
    {
      return Client.Post<ExportPlannedPeriodicalLatenessEarlyDepartureTotalsList, ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListResponse> ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListAsync(
      ExportPlannedPeriodicalLatenessEarlyDepartureTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalLatenessEarlyDepartureTotalsList, ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateResponse ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDate(
      ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDate, ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateResponse> ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateAsync(
      ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDate, ExportPlannedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesResponse ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDates(
      ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDates, ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesResponse> ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesAsync(
      ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDates, ExportPlannedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDateResponse ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDate(
      ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDate arg)
    {
      return Client.Post<ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDate, ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDateResponse> ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDateAsync(
      ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDate, ExportPlannedPerpetualLatenessEarlyDepartureTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualLatenessEarlyDepartureTotalsListResponse ExportPlannedPerpetualLatenessEarlyDepartureTotalsList(
      ExportPlannedPerpetualLatenessEarlyDepartureTotalsList arg)
    {
      return Client.Post<ExportPlannedPerpetualLatenessEarlyDepartureTotalsList, ExportPlannedPerpetualLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualLatenessEarlyDepartureTotalsListResponse> ExportPlannedPerpetualLatenessEarlyDepartureTotalsListAsync(
      ExportPlannedPerpetualLatenessEarlyDepartureTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualLatenessEarlyDepartureTotalsList, ExportPlannedPerpetualLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalLatenessEarlyDepartureTotalsListResponse ExportActualPeriodicalLatenessEarlyDepartureTotalsList(
      ExportActualPeriodicalLatenessEarlyDepartureTotalsList arg)
    {
      return Client.Post<ExportActualPeriodicalLatenessEarlyDepartureTotalsList, ExportActualPeriodicalLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalLatenessEarlyDepartureTotalsListResponse> ExportActualPeriodicalLatenessEarlyDepartureTotalsListAsync(
      ExportActualPeriodicalLatenessEarlyDepartureTotalsList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalLatenessEarlyDepartureTotalsList, ExportActualPeriodicalLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateResponse ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDate(
      ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDate, ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateResponse> ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateAsync(
      ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDate, ExportActualPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalLatenessEarlyDepartureTotalsResponse ExportActualPeriodicalLatenessEarlyDepartureTotals(
      ExportActualPeriodicalLatenessEarlyDepartureTotals arg)
    {
      return Client.Post<ExportActualPeriodicalLatenessEarlyDepartureTotals, ExportActualPeriodicalLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalLatenessEarlyDepartureTotalsResponse> ExportActualPeriodicalLatenessEarlyDepartureTotalsAsync(
      ExportActualPeriodicalLatenessEarlyDepartureTotals arg)
    {
      return Client.PostAsync<ExportActualPeriodicalLatenessEarlyDepartureTotals, ExportActualPeriodicalLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListResponse ExportEstimatedPerpetualLatenessEarlyDepartureTotalsList(
      ExportEstimatedPerpetualLatenessEarlyDepartureTotalsList arg)
    {
      return Client.Post<ExportEstimatedPerpetualLatenessEarlyDepartureTotalsList, ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListResponse> ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListAsync(
      ExportEstimatedPerpetualLatenessEarlyDepartureTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualLatenessEarlyDepartureTotalsList, ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDateResponse ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDate(
      ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDate arg)
    {
      return Client.Post<ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDate, ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDateResponse> ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDateAsync(
      ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDate, ExportEstimatedPerpetualLatenessEarlyDepartureTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesResponse ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDates(
      ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDates, ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesResponse> ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesAsync(
      ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDates, ExportEstimatedPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDateResponse ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDate(
      ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDate, ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDateResponse> ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDateAsync(
      ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDate, ExportEstimatedLatenessEarlyDepartureTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDatesResponse ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDates(
      ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDates, ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDatesResponse> ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDatesAsync(
      ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDates, ExportEstimatedLatenessEarlyDepartureTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedLatenessEarlyDepartureTotalsFromDateToDateResponse ExportPlannedLatenessEarlyDepartureTotalsFromDateToDate(
      ExportPlannedLatenessEarlyDepartureTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedLatenessEarlyDepartureTotalsFromDateToDate, ExportPlannedLatenessEarlyDepartureTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedLatenessEarlyDepartureTotalsFromDateToDateResponse> ExportPlannedLatenessEarlyDepartureTotalsFromDateToDateAsync(
      ExportPlannedLatenessEarlyDepartureTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedLatenessEarlyDepartureTotalsFromDateToDate, ExportPlannedLatenessEarlyDepartureTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDatesResponse ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDates(
      ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDates, ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDatesResponse> ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDatesAsync(
      ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDates, ExportPlannedLatenessEarlyDepartureTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportDailyLatenessEarlyDepartureTotalsResponse ExportDailyLatenessEarlyDepartureTotals(
      ExportDailyLatenessEarlyDepartureTotals arg)
    {
      return Client.Post<ExportDailyLatenessEarlyDepartureTotals, ExportDailyLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportDailyLatenessEarlyDepartureTotalsResponse> ExportDailyLatenessEarlyDepartureTotalsAsync(
      ExportDailyLatenessEarlyDepartureTotals arg)
    {
      return Client.PostAsync<ExportDailyLatenessEarlyDepartureTotals, ExportDailyLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPeriodicalLatenessEarlyDepartureTotalsResponse ExportPeriodicalLatenessEarlyDepartureTotals(
      ExportPeriodicalLatenessEarlyDepartureTotals arg)
    {
      return Client.Post<ExportPeriodicalLatenessEarlyDepartureTotals, ExportPeriodicalLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPeriodicalLatenessEarlyDepartureTotalsResponse> ExportPeriodicalLatenessEarlyDepartureTotalsAsync(
      ExportPeriodicalLatenessEarlyDepartureTotals arg)
    {
      return Client.PostAsync<ExportPeriodicalLatenessEarlyDepartureTotals, ExportPeriodicalLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPerpetualLatenessEarlyDepartureTotalsResponse ExportPerpetualLatenessEarlyDepartureTotals(
      ExportPerpetualLatenessEarlyDepartureTotals arg)
    {
      return Client.Post<ExportPerpetualLatenessEarlyDepartureTotals, ExportPerpetualLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPerpetualLatenessEarlyDepartureTotalsResponse> ExportPerpetualLatenessEarlyDepartureTotalsAsync(
      ExportPerpetualLatenessEarlyDepartureTotals arg)
    {
      return Client.PostAsync<ExportPerpetualLatenessEarlyDepartureTotals, ExportPerpetualLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDateResponse ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDate(
      ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDate, ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDateResponse> ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDateAsync(
      ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDate, ExportEstimatedDailyLatenessEarlyDepartureTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriodResponse ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriod(
      ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriod arg)
    {
      return Client.Post<ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriod, ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriodResponse> ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriodAsync(
      ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriod, ExportEstimatedDailyLatenessEarlyDepartureTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDatesResponse ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDates(
      ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDates, ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDatesResponse> ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDatesAsync(
      ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDates, ExportEstimatedDailyLatenessEarlyDepartureTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyLatenessEarlyDepartureTotalsListResponse ExportActualWeeklyLatenessEarlyDepartureTotalsList(
      ExportActualWeeklyLatenessEarlyDepartureTotalsList arg)
    {
      return Client.Post<ExportActualWeeklyLatenessEarlyDepartureTotalsList, ExportActualWeeklyLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyLatenessEarlyDepartureTotalsListResponse> ExportActualWeeklyLatenessEarlyDepartureTotalsListAsync(
      ExportActualWeeklyLatenessEarlyDepartureTotalsList arg)
    {
      return Client.PostAsync<ExportActualWeeklyLatenessEarlyDepartureTotalsList, ExportActualWeeklyLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDateResponse ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDate(
      ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDate, ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDateResponse> ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDateAsync(
      ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDate, ExportActualWeeklyLatenessEarlyDepartureTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyLatenessEarlyDepartureTotalsResponse ExportActualWeeklyLatenessEarlyDepartureTotals(
      ExportActualWeeklyLatenessEarlyDepartureTotals arg)
    {
      return Client.Post<ExportActualWeeklyLatenessEarlyDepartureTotals, ExportActualWeeklyLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyLatenessEarlyDepartureTotalsResponse> ExportActualWeeklyLatenessEarlyDepartureTotalsAsync(
      ExportActualWeeklyLatenessEarlyDepartureTotals arg)
    {
      return Client.PostAsync<ExportActualWeeklyLatenessEarlyDepartureTotals, ExportActualWeeklyLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriodResponse ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriod(
      ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriod arg)
    {
      return Client.Post<ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriod, ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriodResponse> ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriodAsync(
      ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriod, ExportPlannedDailyLatenessEarlyDepartureTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDatesResponse ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDates(
      ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDates, ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDatesResponse> ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDatesAsync(
      ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDates, ExportPlannedDailyLatenessEarlyDepartureTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDateResponse ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDate(
      ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDate, ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDateResponse> ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDateAsync(
      ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDate, ExportPlannedDailyLatenessEarlyDepartureTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyLatenessEarlyDepartureTotalsFromPeriodResponse ExportActualDailyLatenessEarlyDepartureTotalsFromPeriod(
      ExportActualDailyLatenessEarlyDepartureTotalsFromPeriod arg)
    {
      return Client.Post<ExportActualDailyLatenessEarlyDepartureTotalsFromPeriod, ExportActualDailyLatenessEarlyDepartureTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyLatenessEarlyDepartureTotalsFromPeriodResponse> ExportActualDailyLatenessEarlyDepartureTotalsFromPeriodAsync(
      ExportActualDailyLatenessEarlyDepartureTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportActualDailyLatenessEarlyDepartureTotalsFromPeriod, ExportActualDailyLatenessEarlyDepartureTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDateResponse ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDate(
      ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDate, ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDateResponse> ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDateAsync(
      ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDate, ExportActualDailyLatenessEarlyDepartureTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDatesResponse ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDates(
      ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDates, ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDatesResponse> ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDatesAsync(
      ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDates, ExportActualDailyLatenessEarlyDepartureTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyLatenessEarlyDepartureTotalsResponse ExportPlannedWeeklyLatenessEarlyDepartureTotals(
      ExportPlannedWeeklyLatenessEarlyDepartureTotals arg)
    {
      return Client.Post<ExportPlannedWeeklyLatenessEarlyDepartureTotals, ExportPlannedWeeklyLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyLatenessEarlyDepartureTotalsResponse> ExportPlannedWeeklyLatenessEarlyDepartureTotalsAsync(
      ExportPlannedWeeklyLatenessEarlyDepartureTotals arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyLatenessEarlyDepartureTotals, ExportPlannedWeeklyLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateResponse ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDate(
      ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDate, ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateResponse> ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateAsync(
      ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDate, ExportPlannedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyLatenessEarlyDepartureTotalsListResponse ExportPlannedWeeklyLatenessEarlyDepartureTotalsList(
      ExportPlannedWeeklyLatenessEarlyDepartureTotalsList arg)
    {
      return Client.Post<ExportPlannedWeeklyLatenessEarlyDepartureTotalsList, ExportPlannedWeeklyLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyLatenessEarlyDepartureTotalsListResponse> ExportPlannedWeeklyLatenessEarlyDepartureTotalsListAsync(
      ExportPlannedWeeklyLatenessEarlyDepartureTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyLatenessEarlyDepartureTotalsList, ExportPlannedWeeklyLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListResponse ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsList(
      ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsList, ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListResponse> ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListAsync(
      ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsList, ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateResponse ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDate(
      ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDate, ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateResponse> ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateAsync(
      ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDate, ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsResponse ExportEstimatedPeriodicalLatenessEarlyDepartureTotals(
      ExportEstimatedPeriodicalLatenessEarlyDepartureTotals arg)
    {
      return Client.Post<ExportEstimatedPeriodicalLatenessEarlyDepartureTotals, ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsResponse> ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsAsync(
      ExportEstimatedPeriodicalLatenessEarlyDepartureTotals arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalLatenessEarlyDepartureTotals, ExportEstimatedPeriodicalLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListResponse ExportEstimatedWeeklyLatenessEarlyDepartureTotalsList(
      ExportEstimatedWeeklyLatenessEarlyDepartureTotalsList arg)
    {
      return Client.Post<ExportEstimatedWeeklyLatenessEarlyDepartureTotalsList, ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListResponse> ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListAsync(
      ExportEstimatedWeeklyLatenessEarlyDepartureTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyLatenessEarlyDepartureTotalsList, ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyLatenessEarlyDepartureTotalsResponse ExportEstimatedWeeklyLatenessEarlyDepartureTotals(
      ExportEstimatedWeeklyLatenessEarlyDepartureTotals arg)
    {
      return Client.Post<ExportEstimatedWeeklyLatenessEarlyDepartureTotals, ExportEstimatedWeeklyLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyLatenessEarlyDepartureTotalsResponse> ExportEstimatedWeeklyLatenessEarlyDepartureTotalsAsync(
      ExportEstimatedWeeklyLatenessEarlyDepartureTotals arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyLatenessEarlyDepartureTotals, ExportEstimatedWeeklyLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateResponse ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDate(
      ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDate, ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateResponse> ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateAsync(
      ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDate, ExportEstimatedWeeklyLatenessEarlyDepartureTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualLatenessEarlyDepartureTotalsFromDateToDateResponse ExportActualLatenessEarlyDepartureTotalsFromDateToDate(
      ExportActualLatenessEarlyDepartureTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualLatenessEarlyDepartureTotalsFromDateToDate, ExportActualLatenessEarlyDepartureTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualLatenessEarlyDepartureTotalsFromDateToDateResponse> ExportActualLatenessEarlyDepartureTotalsFromDateToDateAsync(
      ExportActualLatenessEarlyDepartureTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualLatenessEarlyDepartureTotalsFromDateToDate, ExportActualLatenessEarlyDepartureTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualLatenessEarlyDepartureTotalsFromRelativeDatesResponse ExportActualLatenessEarlyDepartureTotalsFromRelativeDates(
      ExportActualLatenessEarlyDepartureTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualLatenessEarlyDepartureTotalsFromRelativeDates, ExportActualLatenessEarlyDepartureTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualLatenessEarlyDepartureTotalsFromRelativeDatesResponse> ExportActualLatenessEarlyDepartureTotalsFromRelativeDatesAsync(
      ExportActualLatenessEarlyDepartureTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualLatenessEarlyDepartureTotalsFromRelativeDates, ExportActualLatenessEarlyDepartureTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDateResponse ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDate(
      ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDate arg)
    {
      return Client.Post<ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDate, ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDateResponse> ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDateAsync(
      ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDate, ExportActualPerpetualLatenessEarlyDepartureTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualLatenessEarlyDepartureTotalsListResponse ExportActualPerpetualLatenessEarlyDepartureTotalsList(
      ExportActualPerpetualLatenessEarlyDepartureTotalsList arg)
    {
      return Client.Post<ExportActualPerpetualLatenessEarlyDepartureTotalsList, ExportActualPerpetualLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualLatenessEarlyDepartureTotalsListResponse> ExportActualPerpetualLatenessEarlyDepartureTotalsListAsync(
      ExportActualPerpetualLatenessEarlyDepartureTotalsList arg)
    {
      return Client.PostAsync<ExportActualPerpetualLatenessEarlyDepartureTotalsList, ExportActualPerpetualLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesResponse ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDates(
      ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDates, ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesResponse> ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesAsync(
      ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDates, ExportActualPerpetualLatenessEarlyDepartureTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportWeeklyLatenessEarlyDepartureTotalsListResponse ExportWeeklyLatenessEarlyDepartureTotalsList(
      ExportWeeklyLatenessEarlyDepartureTotalsList arg)
    {
      return Client.Post<ExportWeeklyLatenessEarlyDepartureTotalsList, ExportWeeklyLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportWeeklyLatenessEarlyDepartureTotalsListResponse> ExportWeeklyLatenessEarlyDepartureTotalsListAsync(
      ExportWeeklyLatenessEarlyDepartureTotalsList arg)
    {
      return Client.PostAsync<ExportWeeklyLatenessEarlyDepartureTotalsList, ExportWeeklyLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportDailyLatenessEarlyDepartureTotalsListResponse ExportDailyLatenessEarlyDepartureTotalsList(
      ExportDailyLatenessEarlyDepartureTotalsList arg)
    {
      return Client.Post<ExportDailyLatenessEarlyDepartureTotalsList, ExportDailyLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportDailyLatenessEarlyDepartureTotalsListResponse> ExportDailyLatenessEarlyDepartureTotalsListAsync(
      ExportDailyLatenessEarlyDepartureTotalsList arg)
    {
      return Client.PostAsync<ExportDailyLatenessEarlyDepartureTotalsList, ExportDailyLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPerpetualLatenessEarlyDepartureTotalsListResponse ExportPerpetualLatenessEarlyDepartureTotalsList(
      ExportPerpetualLatenessEarlyDepartureTotalsList arg)
    {
      return Client.Post<ExportPerpetualLatenessEarlyDepartureTotalsList, ExportPerpetualLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPerpetualLatenessEarlyDepartureTotalsListResponse> ExportPerpetualLatenessEarlyDepartureTotalsListAsync(
      ExportPerpetualLatenessEarlyDepartureTotalsList arg)
    {
      return Client.PostAsync<ExportPerpetualLatenessEarlyDepartureTotalsList, ExportPerpetualLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportWeeklyLatenessEarlyDepartureTotalsResponse ExportWeeklyLatenessEarlyDepartureTotals(
      ExportWeeklyLatenessEarlyDepartureTotals arg)
    {
      return Client.Post<ExportWeeklyLatenessEarlyDepartureTotals, ExportWeeklyLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportWeeklyLatenessEarlyDepartureTotalsResponse> ExportWeeklyLatenessEarlyDepartureTotalsAsync(
      ExportWeeklyLatenessEarlyDepartureTotals arg)
    {
      return Client.PostAsync<ExportWeeklyLatenessEarlyDepartureTotals, ExportWeeklyLatenessEarlyDepartureTotalsResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public ExportPeriodicalLatenessEarlyDepartureTotalsListResponse ExportPeriodicalLatenessEarlyDepartureTotalsList(
      ExportPeriodicalLatenessEarlyDepartureTotalsList arg)
    {
      return Client.Post<ExportPeriodicalLatenessEarlyDepartureTotalsList, ExportPeriodicalLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPeriodicalLatenessEarlyDepartureTotalsListResponse> ExportPeriodicalLatenessEarlyDepartureTotalsListAsync(
      ExportPeriodicalLatenessEarlyDepartureTotalsList arg)
    {
      return Client.PostAsync<ExportPeriodicalLatenessEarlyDepartureTotalsList, ExportPeriodicalLatenessEarlyDepartureTotalsListResponse>(this.username, this.password, this.baseuri, "LatenessEarlyDepartureTotalService", arg, this.timeoutSeconds);
    }
  }
}
