
//.OvertimeHourTotalServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class OvertimeHourTotalServiceClient
  {
    private const string service = "OvertimeHourTotalService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public OvertimeHourTotalServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportActualDailyOvertimeHourTotalsFromDateToDateForEmployeeListResponse ExportActualDailyOvertimeHourTotalsFromDateToDateForEmployeeList(
      ExportActualDailyOvertimeHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyOvertimeHourTotalsFromDateToDateForEmployeeList, ExportActualDailyOvertimeHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualDailyOvertimeHourTotalsFromDateToDateForEmployeeListResponse> ExportActualDailyOvertimeHourTotalsFromDateToDateForEmployeeListAsync(
      ExportActualDailyOvertimeHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyOvertimeHourTotalsFromDateToDateForEmployeeList, ExportActualDailyOvertimeHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualDailyOvertimeHourTotalsFromPeriodForEmployeeListResponse ExportActualDailyOvertimeHourTotalsFromPeriodForEmployeeList(
      ExportActualDailyOvertimeHourTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyOvertimeHourTotalsFromPeriodForEmployeeList, ExportActualDailyOvertimeHourTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualDailyOvertimeHourTotalsFromPeriodForEmployeeListResponse> ExportActualDailyOvertimeHourTotalsFromPeriodForEmployeeListAsync(
      ExportActualDailyOvertimeHourTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyOvertimeHourTotalsFromPeriodForEmployeeList, ExportActualDailyOvertimeHourTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeListResponse ExportActualPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeList(
      ExportActualPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeListResponse> ExportActualPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualPerpetualOvertimeHourTotalsListFromDateForEmployeeListResponse ExportActualPerpetualOvertimeHourTotalsListFromDateForEmployeeList(
      ExportActualPerpetualOvertimeHourTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualOvertimeHourTotalsListFromDateForEmployeeList, ExportActualPerpetualOvertimeHourTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualPerpetualOvertimeHourTotalsListFromDateForEmployeeListResponse> ExportActualPerpetualOvertimeHourTotalsListFromDateForEmployeeListAsync(
      ExportActualPerpetualOvertimeHourTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualOvertimeHourTotalsListFromDateForEmployeeList, ExportActualPerpetualOvertimeHourTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedPerpetualOvertimeHourTotalsListFromDateForEmployeeListResponse ExportEstimatedPerpetualOvertimeHourTotalsListFromDateForEmployeeList(
      ExportEstimatedPerpetualOvertimeHourTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualOvertimeHourTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualOvertimeHourTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualOvertimeHourTotalsListFromDateForEmployeeListResponse> ExportEstimatedPerpetualOvertimeHourTotalsListFromDateForEmployeeListAsync(
      ExportEstimatedPerpetualOvertimeHourTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualOvertimeHourTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualOvertimeHourTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualPeriodicalOvertimeHourTotalsForEmployeeListResponse ExportActualPeriodicalOvertimeHourTotalsForEmployeeList(
      ExportActualPeriodicalOvertimeHourTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalOvertimeHourTotalsForEmployeeList, ExportActualPeriodicalOvertimeHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualPeriodicalOvertimeHourTotalsForEmployeeListResponse> ExportActualPeriodicalOvertimeHourTotalsForEmployeeListAsync(
      ExportActualPeriodicalOvertimeHourTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalOvertimeHourTotalsForEmployeeList, ExportActualPeriodicalOvertimeHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedPerpetualOvertimeHourTotalsListForEmployeeListResponse ExportPlannedPerpetualOvertimeHourTotalsListForEmployeeList(
      ExportPlannedPerpetualOvertimeHourTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualOvertimeHourTotalsListForEmployeeList, ExportPlannedPerpetualOvertimeHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedPerpetualOvertimeHourTotalsListForEmployeeListResponse> ExportPlannedPerpetualOvertimeHourTotalsListForEmployeeListAsync(
      ExportPlannedPerpetualOvertimeHourTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualOvertimeHourTotalsListForEmployeeList, ExportPlannedPerpetualOvertimeHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualPerpetualOvertimeHourTotalsListForEmployeeListResponse ExportActualPerpetualOvertimeHourTotalsListForEmployeeList(
      ExportActualPerpetualOvertimeHourTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualOvertimeHourTotalsListForEmployeeList, ExportActualPerpetualOvertimeHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualPerpetualOvertimeHourTotalsListForEmployeeListResponse> ExportActualPerpetualOvertimeHourTotalsListForEmployeeListAsync(
      ExportActualPerpetualOvertimeHourTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualOvertimeHourTotalsListForEmployeeList, ExportActualPerpetualOvertimeHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedPerpetualOvertimeHourTotalsListFromDateForEmployeeListResponse ExportPlannedPerpetualOvertimeHourTotalsListFromDateForEmployeeList(
      ExportPlannedPerpetualOvertimeHourTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualOvertimeHourTotalsListFromDateForEmployeeList, ExportPlannedPerpetualOvertimeHourTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedPerpetualOvertimeHourTotalsListFromDateForEmployeeListResponse> ExportPlannedPerpetualOvertimeHourTotalsListFromDateForEmployeeListAsync(
      ExportPlannedPerpetualOvertimeHourTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualOvertimeHourTotalsListFromDateForEmployeeList, ExportPlannedPerpetualOvertimeHourTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedOvertimeHourTotalsFromDateToDateForEmployeeListResponse ExportPlannedOvertimeHourTotalsFromDateToDateForEmployeeList(
      ExportPlannedOvertimeHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedOvertimeHourTotalsFromDateToDateForEmployeeList, ExportPlannedOvertimeHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedOvertimeHourTotalsFromDateToDateForEmployeeListResponse> ExportPlannedOvertimeHourTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedOvertimeHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedOvertimeHourTotalsFromDateToDateForEmployeeList, ExportPlannedOvertimeHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualOvertimeHourTotalsFromDateToDateForEmployeeListResponse ExportActualOvertimeHourTotalsFromDateToDateForEmployeeList(
      ExportActualOvertimeHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualOvertimeHourTotalsFromDateToDateForEmployeeList, ExportActualOvertimeHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualOvertimeHourTotalsFromDateToDateForEmployeeListResponse> ExportActualOvertimeHourTotalsFromDateToDateForEmployeeListAsync(
      ExportActualOvertimeHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualOvertimeHourTotalsFromDateToDateForEmployeeList, ExportActualOvertimeHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedDailyOvertimeHourTotalsFromDateToDateForEmployeeListResponse ExportEstimatedDailyOvertimeHourTotalsFromDateToDateForEmployeeList(
      ExportEstimatedDailyOvertimeHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyOvertimeHourTotalsFromDateToDateForEmployeeList, ExportEstimatedDailyOvertimeHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedDailyOvertimeHourTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedDailyOvertimeHourTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedDailyOvertimeHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyOvertimeHourTotalsFromDateToDateForEmployeeList, ExportEstimatedDailyOvertimeHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualDailyOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse ExportActualDailyOvertimeHourTotalsFromRelativeDatesForEmployeeList(
      ExportActualDailyOvertimeHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyOvertimeHourTotalsFromRelativeDatesForEmployeeList, ExportActualDailyOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualDailyOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse> ExportActualDailyOvertimeHourTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualDailyOvertimeHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyOvertimeHourTotalsFromRelativeDatesForEmployeeList, ExportActualDailyOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedWeeklyOvertimeHourTotalsForEmployeeListResponse ExportEstimatedWeeklyOvertimeHourTotalsForEmployeeList(
      ExportEstimatedWeeklyOvertimeHourTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyOvertimeHourTotalsForEmployeeList, ExportEstimatedWeeklyOvertimeHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyOvertimeHourTotalsForEmployeeListResponse> ExportEstimatedWeeklyOvertimeHourTotalsForEmployeeListAsync(
      ExportEstimatedWeeklyOvertimeHourTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyOvertimeHourTotalsForEmployeeList, ExportEstimatedWeeklyOvertimeHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedWeeklyOvertimeHourTotalsForEmployeeListResponse ExportPlannedWeeklyOvertimeHourTotalsForEmployeeList(
      ExportPlannedWeeklyOvertimeHourTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyOvertimeHourTotalsForEmployeeList, ExportPlannedWeeklyOvertimeHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedWeeklyOvertimeHourTotalsForEmployeeListResponse> ExportPlannedWeeklyOvertimeHourTotalsForEmployeeListAsync(
      ExportPlannedWeeklyOvertimeHourTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyOvertimeHourTotalsForEmployeeList, ExportPlannedWeeklyOvertimeHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualWeeklyOvertimeHourTotalsListForEmployeeListResponse ExportActualWeeklyOvertimeHourTotalsListForEmployeeList(
      ExportActualWeeklyOvertimeHourTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyOvertimeHourTotalsListForEmployeeList, ExportActualWeeklyOvertimeHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualWeeklyOvertimeHourTotalsListForEmployeeListResponse> ExportActualWeeklyOvertimeHourTotalsListForEmployeeListAsync(
      ExportActualWeeklyOvertimeHourTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyOvertimeHourTotalsListForEmployeeList, ExportActualWeeklyOvertimeHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualWeeklyOvertimeHourTotalsForEmployeeListResponse ExportActualWeeklyOvertimeHourTotalsForEmployeeList(
      ExportActualWeeklyOvertimeHourTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyOvertimeHourTotalsForEmployeeList, ExportActualWeeklyOvertimeHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualWeeklyOvertimeHourTotalsForEmployeeListResponse> ExportActualWeeklyOvertimeHourTotalsForEmployeeListAsync(
      ExportActualWeeklyOvertimeHourTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyOvertimeHourTotalsForEmployeeList, ExportActualWeeklyOvertimeHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedDailyOvertimeHourTotalsFromPeriodForEmployeeListResponse ExportEstimatedDailyOvertimeHourTotalsFromPeriodForEmployeeList(
      ExportEstimatedDailyOvertimeHourTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyOvertimeHourTotalsFromPeriodForEmployeeList, ExportEstimatedDailyOvertimeHourTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedDailyOvertimeHourTotalsFromPeriodForEmployeeListResponse> ExportEstimatedDailyOvertimeHourTotalsFromPeriodForEmployeeListAsync(
      ExportEstimatedDailyOvertimeHourTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyOvertimeHourTotalsFromPeriodForEmployeeList, ExportEstimatedDailyOvertimeHourTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedDailyOvertimeHourTotalsFromDateToDateForEmployeeListResponse ExportPlannedDailyOvertimeHourTotalsFromDateToDateForEmployeeList(
      ExportPlannedDailyOvertimeHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyOvertimeHourTotalsFromDateToDateForEmployeeList, ExportPlannedDailyOvertimeHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedDailyOvertimeHourTotalsFromDateToDateForEmployeeListResponse> ExportPlannedDailyOvertimeHourTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedDailyOvertimeHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyOvertimeHourTotalsFromDateToDateForEmployeeList, ExportPlannedDailyOvertimeHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedDailyOvertimeHourTotalsFromPeriodForEmployeeListResponse ExportPlannedDailyOvertimeHourTotalsFromPeriodForEmployeeList(
      ExportPlannedDailyOvertimeHourTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyOvertimeHourTotalsFromPeriodForEmployeeList, ExportPlannedDailyOvertimeHourTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedDailyOvertimeHourTotalsFromPeriodForEmployeeListResponse> ExportPlannedDailyOvertimeHourTotalsFromPeriodForEmployeeListAsync(
      ExportPlannedDailyOvertimeHourTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyOvertimeHourTotalsFromPeriodForEmployeeList, ExportPlannedDailyOvertimeHourTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedPeriodicalOvertimeHourTotalsForEmployeeListResponse ExportEstimatedPeriodicalOvertimeHourTotalsForEmployeeList(
      ExportEstimatedPeriodicalOvertimeHourTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalOvertimeHourTotalsForEmployeeList, ExportEstimatedPeriodicalOvertimeHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalOvertimeHourTotalsForEmployeeListResponse> ExportEstimatedPeriodicalOvertimeHourTotalsForEmployeeListAsync(
      ExportEstimatedPeriodicalOvertimeHourTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalOvertimeHourTotalsForEmployeeList, ExportEstimatedPeriodicalOvertimeHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeListResponse ExportActualWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeList(
      ExportActualWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeList, ExportActualWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeListResponse> ExportActualWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeList, ExportActualWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse ExportActualPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeList(
      ExportActualPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse> ExportActualPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse ExportActualOvertimeHourTotalsFromRelativeDatesForEmployeeList(
      ExportActualOvertimeHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualOvertimeHourTotalsFromRelativeDatesForEmployeeList, ExportActualOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse> ExportActualOvertimeHourTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualOvertimeHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualOvertimeHourTotalsFromRelativeDatesForEmployeeList, ExportActualOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeListResponse ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeList(
      ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedPeriodicalOvertimeHourTotalsForEmployeeListResponse ExportPlannedPeriodicalOvertimeHourTotalsForEmployeeList(
      ExportPlannedPeriodicalOvertimeHourTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalOvertimeHourTotalsForEmployeeList, ExportPlannedPeriodicalOvertimeHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalOvertimeHourTotalsForEmployeeListResponse> ExportPlannedPeriodicalOvertimeHourTotalsForEmployeeListAsync(
      ExportPlannedPeriodicalOvertimeHourTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalOvertimeHourTotalsForEmployeeList, ExportPlannedPeriodicalOvertimeHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedOvertimeHourTotalsFromDateToDateForEmployeeListResponse ExportEstimatedOvertimeHourTotalsFromDateToDateForEmployeeList(
      ExportEstimatedOvertimeHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedOvertimeHourTotalsFromDateToDateForEmployeeList, ExportEstimatedOvertimeHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedOvertimeHourTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedOvertimeHourTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedOvertimeHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedOvertimeHourTotalsFromDateToDateForEmployeeList, ExportEstimatedOvertimeHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualPeriodicalOvertimeHourTotalsListForEmployeeListResponse ExportActualPeriodicalOvertimeHourTotalsListForEmployeeList(
      ExportActualPeriodicalOvertimeHourTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalOvertimeHourTotalsListForEmployeeList, ExportActualPeriodicalOvertimeHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualPeriodicalOvertimeHourTotalsListForEmployeeListResponse> ExportActualPeriodicalOvertimeHourTotalsListForEmployeeListAsync(
      ExportActualPeriodicalOvertimeHourTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalOvertimeHourTotalsListForEmployeeList, ExportActualPeriodicalOvertimeHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedPerpetualOvertimeHourTotalsListForEmployeeListResponse ExportEstimatedPerpetualOvertimeHourTotalsListForEmployeeList(
      ExportEstimatedPerpetualOvertimeHourTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualOvertimeHourTotalsListForEmployeeList, ExportEstimatedPerpetualOvertimeHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualOvertimeHourTotalsListForEmployeeListResponse> ExportEstimatedPerpetualOvertimeHourTotalsListForEmployeeListAsync(
      ExportEstimatedPerpetualOvertimeHourTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualOvertimeHourTotalsListForEmployeeList, ExportEstimatedPerpetualOvertimeHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedPeriodicalOvertimeHourTotalsListForEmployeeListResponse ExportPlannedPeriodicalOvertimeHourTotalsListForEmployeeList(
      ExportPlannedPeriodicalOvertimeHourTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalOvertimeHourTotalsListForEmployeeList, ExportPlannedPeriodicalOvertimeHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalOvertimeHourTotalsListForEmployeeListResponse> ExportPlannedPeriodicalOvertimeHourTotalsListForEmployeeListAsync(
      ExportPlannedPeriodicalOvertimeHourTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalOvertimeHourTotalsListForEmployeeList, ExportPlannedPeriodicalOvertimeHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeListResponse ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeList(
      ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedOvertimeHourTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedOvertimeHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedOvertimeHourTotalsFromRelativeDatesForEmployeeList, ExportPlannedOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedOvertimeHourTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedOvertimeHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedOvertimeHourTotalsFromRelativeDatesForEmployeeList, ExportPlannedOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedOvertimeHourTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedOvertimeHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedOvertimeHourTotalsFromRelativeDatesForEmployeeList, ExportEstimatedOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedOvertimeHourTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedOvertimeHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedOvertimeHourTotalsFromRelativeDatesForEmployeeList, ExportEstimatedOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedWeeklyOvertimeHourTotalsListForEmployeeListResponse ExportEstimatedWeeklyOvertimeHourTotalsListForEmployeeList(
      ExportEstimatedWeeklyOvertimeHourTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyOvertimeHourTotalsListForEmployeeList, ExportEstimatedWeeklyOvertimeHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyOvertimeHourTotalsListForEmployeeListResponse> ExportEstimatedWeeklyOvertimeHourTotalsListForEmployeeListAsync(
      ExportEstimatedWeeklyOvertimeHourTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyOvertimeHourTotalsListForEmployeeList, ExportEstimatedWeeklyOvertimeHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedWeeklyOvertimeHourTotalsListForEmployeeListResponse ExportPlannedWeeklyOvertimeHourTotalsListForEmployeeList(
      ExportPlannedWeeklyOvertimeHourTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyOvertimeHourTotalsListForEmployeeList, ExportPlannedWeeklyOvertimeHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedWeeklyOvertimeHourTotalsListForEmployeeListResponse> ExportPlannedWeeklyOvertimeHourTotalsListForEmployeeListAsync(
      ExportPlannedWeeklyOvertimeHourTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyOvertimeHourTotalsListForEmployeeList, ExportPlannedWeeklyOvertimeHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedPeriodicalOvertimeHourTotalsListForEmployeeListResponse ExportEstimatedPeriodicalOvertimeHourTotalsListForEmployeeList(
      ExportEstimatedPeriodicalOvertimeHourTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalOvertimeHourTotalsListForEmployeeList, ExportEstimatedPeriodicalOvertimeHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalOvertimeHourTotalsListForEmployeeListResponse> ExportEstimatedPeriodicalOvertimeHourTotalsListForEmployeeListAsync(
      ExportEstimatedPeriodicalOvertimeHourTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalOvertimeHourTotalsListForEmployeeList, ExportEstimatedPeriodicalOvertimeHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailyOvertimeHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportCyclicalOvertimeHourTotalsListResponse ExportCyclicalOvertimeHourTotalsList(
      ExportCyclicalOvertimeHourTotalsList arg)
    {
      return Client.Post<ExportCyclicalOvertimeHourTotalsList, ExportCyclicalOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportCyclicalOvertimeHourTotalsListResponse> ExportCyclicalOvertimeHourTotalsListAsync(
      ExportCyclicalOvertimeHourTotalsList arg)
    {
      return Client.PostAsync<ExportCyclicalOvertimeHourTotalsList, ExportCyclicalOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedPeriodicalOvertimeHourTotalsListResponse ExportPlannedPeriodicalOvertimeHourTotalsList(
      ExportPlannedPeriodicalOvertimeHourTotalsList arg)
    {
      return Client.Post<ExportPlannedPeriodicalOvertimeHourTotalsList, ExportPlannedPeriodicalOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalOvertimeHourTotalsListResponse> ExportPlannedPeriodicalOvertimeHourTotalsListAsync(
      ExportPlannedPeriodicalOvertimeHourTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalOvertimeHourTotalsList, ExportPlannedPeriodicalOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDateResponse ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDate(
      ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDate, ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDateResponse> ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDateAsync(
      ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDate, ExportPlannedPeriodicalOvertimeHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedPeriodicalOvertimeHourTotalsResponse ExportPlannedPeriodicalOvertimeHourTotals(
      ExportPlannedPeriodicalOvertimeHourTotals arg)
    {
      return Client.Post<ExportPlannedPeriodicalOvertimeHourTotals, ExportPlannedPeriodicalOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalOvertimeHourTotalsResponse> ExportPlannedPeriodicalOvertimeHourTotalsAsync(
      ExportPlannedPeriodicalOvertimeHourTotals arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalOvertimeHourTotals, ExportPlannedPeriodicalOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDatesResponse ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDates(
      ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDates, ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDatesResponse> ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDatesAsync(
      ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDates, ExportPlannedPerpetualOvertimeHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedPerpetualOvertimeHourTotalsListResponse ExportPlannedPerpetualOvertimeHourTotalsList(
      ExportPlannedPerpetualOvertimeHourTotalsList arg)
    {
      return Client.Post<ExportPlannedPerpetualOvertimeHourTotalsList, ExportPlannedPerpetualOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedPerpetualOvertimeHourTotalsListResponse> ExportPlannedPerpetualOvertimeHourTotalsListAsync(
      ExportPlannedPerpetualOvertimeHourTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualOvertimeHourTotalsList, ExportPlannedPerpetualOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedPerpetualOvertimeHourTotalsListFromDateResponse ExportPlannedPerpetualOvertimeHourTotalsListFromDate(
      ExportPlannedPerpetualOvertimeHourTotalsListFromDate arg)
    {
      return Client.Post<ExportPlannedPerpetualOvertimeHourTotalsListFromDate, ExportPlannedPerpetualOvertimeHourTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedPerpetualOvertimeHourTotalsListFromDateResponse> ExportPlannedPerpetualOvertimeHourTotalsListFromDateAsync(
      ExportPlannedPerpetualOvertimeHourTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualOvertimeHourTotalsListFromDate, ExportPlannedPerpetualOvertimeHourTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualPeriodicalOvertimeHourTotalsResponse ExportActualPeriodicalOvertimeHourTotals(
      ExportActualPeriodicalOvertimeHourTotals arg)
    {
      return Client.Post<ExportActualPeriodicalOvertimeHourTotals, ExportActualPeriodicalOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualPeriodicalOvertimeHourTotalsResponse> ExportActualPeriodicalOvertimeHourTotalsAsync(
      ExportActualPeriodicalOvertimeHourTotals arg)
    {
      return Client.PostAsync<ExportActualPeriodicalOvertimeHourTotals, ExportActualPeriodicalOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualPeriodicalOvertimeHourTotalsListResponse ExportActualPeriodicalOvertimeHourTotalsList(
      ExportActualPeriodicalOvertimeHourTotalsList arg)
    {
      return Client.Post<ExportActualPeriodicalOvertimeHourTotalsList, ExportActualPeriodicalOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualPeriodicalOvertimeHourTotalsListResponse> ExportActualPeriodicalOvertimeHourTotalsListAsync(
      ExportActualPeriodicalOvertimeHourTotalsList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalOvertimeHourTotalsList, ExportActualPeriodicalOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualPeriodicalOvertimeHourTotalsListFromDateToDateResponse ExportActualPeriodicalOvertimeHourTotalsListFromDateToDate(
      ExportActualPeriodicalOvertimeHourTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualPeriodicalOvertimeHourTotalsListFromDateToDate, ExportActualPeriodicalOvertimeHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualPeriodicalOvertimeHourTotalsListFromDateToDateResponse> ExportActualPeriodicalOvertimeHourTotalsListFromDateToDateAsync(
      ExportActualPeriodicalOvertimeHourTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualPeriodicalOvertimeHourTotalsListFromDateToDate, ExportActualPeriodicalOvertimeHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedPerpetualOvertimeHourTotalsListResponse ExportEstimatedPerpetualOvertimeHourTotalsList(
      ExportEstimatedPerpetualOvertimeHourTotalsList arg)
    {
      return Client.Post<ExportEstimatedPerpetualOvertimeHourTotalsList, ExportEstimatedPerpetualOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualOvertimeHourTotalsListResponse> ExportEstimatedPerpetualOvertimeHourTotalsListAsync(
      ExportEstimatedPerpetualOvertimeHourTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualOvertimeHourTotalsList, ExportEstimatedPerpetualOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedPerpetualOvertimeHourTotalsListFromDateResponse ExportEstimatedPerpetualOvertimeHourTotalsListFromDate(
      ExportEstimatedPerpetualOvertimeHourTotalsListFromDate arg)
    {
      return Client.Post<ExportEstimatedPerpetualOvertimeHourTotalsListFromDate, ExportEstimatedPerpetualOvertimeHourTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualOvertimeHourTotalsListFromDateResponse> ExportEstimatedPerpetualOvertimeHourTotalsListFromDateAsync(
      ExportEstimatedPerpetualOvertimeHourTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualOvertimeHourTotalsListFromDate, ExportEstimatedPerpetualOvertimeHourTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDatesResponse ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDates(
      ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDates, ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDatesResponse> ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDatesAsync(
      ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDates, ExportEstimatedPerpetualOvertimeHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedOvertimeHourTotalsFromRelativeDatesResponse ExportEstimatedOvertimeHourTotalsFromRelativeDates(
      ExportEstimatedOvertimeHourTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedOvertimeHourTotalsFromRelativeDates, ExportEstimatedOvertimeHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedOvertimeHourTotalsFromRelativeDatesResponse> ExportEstimatedOvertimeHourTotalsFromRelativeDatesAsync(
      ExportEstimatedOvertimeHourTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedOvertimeHourTotalsFromRelativeDates, ExportEstimatedOvertimeHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedOvertimeHourTotalsFromDateToDateResponse ExportEstimatedOvertimeHourTotalsFromDateToDate(
      ExportEstimatedOvertimeHourTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedOvertimeHourTotalsFromDateToDate, ExportEstimatedOvertimeHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedOvertimeHourTotalsFromDateToDateResponse> ExportEstimatedOvertimeHourTotalsFromDateToDateAsync(
      ExportEstimatedOvertimeHourTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedOvertimeHourTotalsFromDateToDate, ExportEstimatedOvertimeHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedOvertimeHourTotalsFromDateToDateResponse ExportPlannedOvertimeHourTotalsFromDateToDate(
      ExportPlannedOvertimeHourTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedOvertimeHourTotalsFromDateToDate, ExportPlannedOvertimeHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedOvertimeHourTotalsFromDateToDateResponse> ExportPlannedOvertimeHourTotalsFromDateToDateAsync(
      ExportPlannedOvertimeHourTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedOvertimeHourTotalsFromDateToDate, ExportPlannedOvertimeHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedOvertimeHourTotalsFromRelativeDatesResponse ExportPlannedOvertimeHourTotalsFromRelativeDates(
      ExportPlannedOvertimeHourTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedOvertimeHourTotalsFromRelativeDates, ExportPlannedOvertimeHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedOvertimeHourTotalsFromRelativeDatesResponse> ExportPlannedOvertimeHourTotalsFromRelativeDatesAsync(
      ExportPlannedOvertimeHourTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedOvertimeHourTotalsFromRelativeDates, ExportPlannedOvertimeHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportDailyOvertimeHourTotalsResponse ExportDailyOvertimeHourTotals(
      ExportDailyOvertimeHourTotals arg)
    {
      return Client.Post<ExportDailyOvertimeHourTotals, ExportDailyOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportDailyOvertimeHourTotalsResponse> ExportDailyOvertimeHourTotalsAsync(
      ExportDailyOvertimeHourTotals arg)
    {
      return Client.PostAsync<ExportDailyOvertimeHourTotals, ExportDailyOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportCyclicalOvertimeHourTotalsResponse ExportCyclicalOvertimeHourTotals(
      ExportCyclicalOvertimeHourTotals arg)
    {
      return Client.Post<ExportCyclicalOvertimeHourTotals, ExportCyclicalOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportCyclicalOvertimeHourTotalsResponse> ExportCyclicalOvertimeHourTotalsAsync(
      ExportCyclicalOvertimeHourTotals arg)
    {
      return Client.PostAsync<ExportCyclicalOvertimeHourTotals, ExportCyclicalOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPeriodicalOvertimeHourTotalsResponse ExportPeriodicalOvertimeHourTotals(
      ExportPeriodicalOvertimeHourTotals arg)
    {
      return Client.Post<ExportPeriodicalOvertimeHourTotals, ExportPeriodicalOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPeriodicalOvertimeHourTotalsResponse> ExportPeriodicalOvertimeHourTotalsAsync(
      ExportPeriodicalOvertimeHourTotals arg)
    {
      return Client.PostAsync<ExportPeriodicalOvertimeHourTotals, ExportPeriodicalOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPerpetualOvertimeHourTotalsResponse ExportPerpetualOvertimeHourTotals(
      ExportPerpetualOvertimeHourTotals arg)
    {
      return Client.Post<ExportPerpetualOvertimeHourTotals, ExportPerpetualOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPerpetualOvertimeHourTotalsResponse> ExportPerpetualOvertimeHourTotalsAsync(
      ExportPerpetualOvertimeHourTotals arg)
    {
      return Client.PostAsync<ExportPerpetualOvertimeHourTotals, ExportPerpetualOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedDailyOvertimeHourTotalsFromDateToDateResponse ExportEstimatedDailyOvertimeHourTotalsFromDateToDate(
      ExportEstimatedDailyOvertimeHourTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedDailyOvertimeHourTotalsFromDateToDate, ExportEstimatedDailyOvertimeHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedDailyOvertimeHourTotalsFromDateToDateResponse> ExportEstimatedDailyOvertimeHourTotalsFromDateToDateAsync(
      ExportEstimatedDailyOvertimeHourTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedDailyOvertimeHourTotalsFromDateToDate, ExportEstimatedDailyOvertimeHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedDailyOvertimeHourTotalsFromPeriodResponse ExportEstimatedDailyOvertimeHourTotalsFromPeriod(
      ExportEstimatedDailyOvertimeHourTotalsFromPeriod arg)
    {
      return Client.Post<ExportEstimatedDailyOvertimeHourTotalsFromPeriod, ExportEstimatedDailyOvertimeHourTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedDailyOvertimeHourTotalsFromPeriodResponse> ExportEstimatedDailyOvertimeHourTotalsFromPeriodAsync(
      ExportEstimatedDailyOvertimeHourTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportEstimatedDailyOvertimeHourTotalsFromPeriod, ExportEstimatedDailyOvertimeHourTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedDailyOvertimeHourTotalsFromRelativeDatesResponse ExportEstimatedDailyOvertimeHourTotalsFromRelativeDates(
      ExportEstimatedDailyOvertimeHourTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedDailyOvertimeHourTotalsFromRelativeDates, ExportEstimatedDailyOvertimeHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedDailyOvertimeHourTotalsFromRelativeDatesResponse> ExportEstimatedDailyOvertimeHourTotalsFromRelativeDatesAsync(
      ExportEstimatedDailyOvertimeHourTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedDailyOvertimeHourTotalsFromRelativeDates, ExportEstimatedDailyOvertimeHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualWeeklyOvertimeHourTotalsListResponse ExportActualWeeklyOvertimeHourTotalsList(
      ExportActualWeeklyOvertimeHourTotalsList arg)
    {
      return Client.Post<ExportActualWeeklyOvertimeHourTotalsList, ExportActualWeeklyOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualWeeklyOvertimeHourTotalsListResponse> ExportActualWeeklyOvertimeHourTotalsListAsync(
      ExportActualWeeklyOvertimeHourTotalsList arg)
    {
      return Client.PostAsync<ExportActualWeeklyOvertimeHourTotalsList, ExportActualWeeklyOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualWeeklyOvertimeHourTotalsListFromDateToDateResponse ExportActualWeeklyOvertimeHourTotalsListFromDateToDate(
      ExportActualWeeklyOvertimeHourTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualWeeklyOvertimeHourTotalsListFromDateToDate, ExportActualWeeklyOvertimeHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualWeeklyOvertimeHourTotalsListFromDateToDateResponse> ExportActualWeeklyOvertimeHourTotalsListFromDateToDateAsync(
      ExportActualWeeklyOvertimeHourTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualWeeklyOvertimeHourTotalsListFromDateToDate, ExportActualWeeklyOvertimeHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualWeeklyOvertimeHourTotalsResponse ExportActualWeeklyOvertimeHourTotals(
      ExportActualWeeklyOvertimeHourTotals arg)
    {
      return Client.Post<ExportActualWeeklyOvertimeHourTotals, ExportActualWeeklyOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualWeeklyOvertimeHourTotalsResponse> ExportActualWeeklyOvertimeHourTotalsAsync(
      ExportActualWeeklyOvertimeHourTotals arg)
    {
      return Client.PostAsync<ExportActualWeeklyOvertimeHourTotals, ExportActualWeeklyOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedDailyOvertimeHourTotalsFromPeriodResponse ExportPlannedDailyOvertimeHourTotalsFromPeriod(
      ExportPlannedDailyOvertimeHourTotalsFromPeriod arg)
    {
      return Client.Post<ExportPlannedDailyOvertimeHourTotalsFromPeriod, ExportPlannedDailyOvertimeHourTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedDailyOvertimeHourTotalsFromPeriodResponse> ExportPlannedDailyOvertimeHourTotalsFromPeriodAsync(
      ExportPlannedDailyOvertimeHourTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportPlannedDailyOvertimeHourTotalsFromPeriod, ExportPlannedDailyOvertimeHourTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedDailyOvertimeHourTotalsFromRelativeDatesResponse ExportPlannedDailyOvertimeHourTotalsFromRelativeDates(
      ExportPlannedDailyOvertimeHourTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedDailyOvertimeHourTotalsFromRelativeDates, ExportPlannedDailyOvertimeHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedDailyOvertimeHourTotalsFromRelativeDatesResponse> ExportPlannedDailyOvertimeHourTotalsFromRelativeDatesAsync(
      ExportPlannedDailyOvertimeHourTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedDailyOvertimeHourTotalsFromRelativeDates, ExportPlannedDailyOvertimeHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedDailyOvertimeHourTotalsFromDateToDateResponse ExportPlannedDailyOvertimeHourTotalsFromDateToDate(
      ExportPlannedDailyOvertimeHourTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedDailyOvertimeHourTotalsFromDateToDate, ExportPlannedDailyOvertimeHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedDailyOvertimeHourTotalsFromDateToDateResponse> ExportPlannedDailyOvertimeHourTotalsFromDateToDateAsync(
      ExportPlannedDailyOvertimeHourTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedDailyOvertimeHourTotalsFromDateToDate, ExportPlannedDailyOvertimeHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualDailyOvertimeHourTotalsFromPeriodResponse ExportActualDailyOvertimeHourTotalsFromPeriod(
      ExportActualDailyOvertimeHourTotalsFromPeriod arg)
    {
      return Client.Post<ExportActualDailyOvertimeHourTotalsFromPeriod, ExportActualDailyOvertimeHourTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualDailyOvertimeHourTotalsFromPeriodResponse> ExportActualDailyOvertimeHourTotalsFromPeriodAsync(
      ExportActualDailyOvertimeHourTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportActualDailyOvertimeHourTotalsFromPeriod, ExportActualDailyOvertimeHourTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualDailyOvertimeHourTotalsFromDateToDateResponse ExportActualDailyOvertimeHourTotalsFromDateToDate(
      ExportActualDailyOvertimeHourTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualDailyOvertimeHourTotalsFromDateToDate, ExportActualDailyOvertimeHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualDailyOvertimeHourTotalsFromDateToDateResponse> ExportActualDailyOvertimeHourTotalsFromDateToDateAsync(
      ExportActualDailyOvertimeHourTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualDailyOvertimeHourTotalsFromDateToDate, ExportActualDailyOvertimeHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualDailyOvertimeHourTotalsFromRelativeDatesResponse ExportActualDailyOvertimeHourTotalsFromRelativeDates(
      ExportActualDailyOvertimeHourTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualDailyOvertimeHourTotalsFromRelativeDates, ExportActualDailyOvertimeHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualDailyOvertimeHourTotalsFromRelativeDatesResponse> ExportActualDailyOvertimeHourTotalsFromRelativeDatesAsync(
      ExportActualDailyOvertimeHourTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualDailyOvertimeHourTotalsFromRelativeDates, ExportActualDailyOvertimeHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedWeeklyOvertimeHourTotalsResponse ExportPlannedWeeklyOvertimeHourTotals(
      ExportPlannedWeeklyOvertimeHourTotals arg)
    {
      return Client.Post<ExportPlannedWeeklyOvertimeHourTotals, ExportPlannedWeeklyOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedWeeklyOvertimeHourTotalsResponse> ExportPlannedWeeklyOvertimeHourTotalsAsync(
      ExportPlannedWeeklyOvertimeHourTotals arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyOvertimeHourTotals, ExportPlannedWeeklyOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDateResponse ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDate(
      ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDate, ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDateResponse> ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDateAsync(
      ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDate, ExportPlannedWeeklyOvertimeHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPlannedWeeklyOvertimeHourTotalsListResponse ExportPlannedWeeklyOvertimeHourTotalsList(
      ExportPlannedWeeklyOvertimeHourTotalsList arg)
    {
      return Client.Post<ExportPlannedWeeklyOvertimeHourTotalsList, ExportPlannedWeeklyOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPlannedWeeklyOvertimeHourTotalsListResponse> ExportPlannedWeeklyOvertimeHourTotalsListAsync(
      ExportPlannedWeeklyOvertimeHourTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyOvertimeHourTotalsList, ExportPlannedWeeklyOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedPeriodicalOvertimeHourTotalsListResponse ExportEstimatedPeriodicalOvertimeHourTotalsList(
      ExportEstimatedPeriodicalOvertimeHourTotalsList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalOvertimeHourTotalsList, ExportEstimatedPeriodicalOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalOvertimeHourTotalsListResponse> ExportEstimatedPeriodicalOvertimeHourTotalsListAsync(
      ExportEstimatedPeriodicalOvertimeHourTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalOvertimeHourTotalsList, ExportEstimatedPeriodicalOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDateResponse ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDate(
      ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDate, ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDateResponse> ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDateAsync(
      ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDate, ExportEstimatedPeriodicalOvertimeHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedPeriodicalOvertimeHourTotalsResponse ExportEstimatedPeriodicalOvertimeHourTotals(
      ExportEstimatedPeriodicalOvertimeHourTotals arg)
    {
      return Client.Post<ExportEstimatedPeriodicalOvertimeHourTotals, ExportEstimatedPeriodicalOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalOvertimeHourTotalsResponse> ExportEstimatedPeriodicalOvertimeHourTotalsAsync(
      ExportEstimatedPeriodicalOvertimeHourTotals arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalOvertimeHourTotals, ExportEstimatedPeriodicalOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedWeeklyOvertimeHourTotalsListResponse ExportEstimatedWeeklyOvertimeHourTotalsList(
      ExportEstimatedWeeklyOvertimeHourTotalsList arg)
    {
      return Client.Post<ExportEstimatedWeeklyOvertimeHourTotalsList, ExportEstimatedWeeklyOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyOvertimeHourTotalsListResponse> ExportEstimatedWeeklyOvertimeHourTotalsListAsync(
      ExportEstimatedWeeklyOvertimeHourTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyOvertimeHourTotalsList, ExportEstimatedWeeklyOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedWeeklyOvertimeHourTotalsResponse ExportEstimatedWeeklyOvertimeHourTotals(
      ExportEstimatedWeeklyOvertimeHourTotals arg)
    {
      return Client.Post<ExportEstimatedWeeklyOvertimeHourTotals, ExportEstimatedWeeklyOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyOvertimeHourTotalsResponse> ExportEstimatedWeeklyOvertimeHourTotalsAsync(
      ExportEstimatedWeeklyOvertimeHourTotals arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyOvertimeHourTotals, ExportEstimatedWeeklyOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDateResponse ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDate(
      ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDate, ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDateResponse> ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDateAsync(
      ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDate, ExportEstimatedWeeklyOvertimeHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualOvertimeHourTotalsFromRelativeDatesResponse ExportActualOvertimeHourTotalsFromRelativeDates(
      ExportActualOvertimeHourTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualOvertimeHourTotalsFromRelativeDates, ExportActualOvertimeHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualOvertimeHourTotalsFromRelativeDatesResponse> ExportActualOvertimeHourTotalsFromRelativeDatesAsync(
      ExportActualOvertimeHourTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualOvertimeHourTotalsFromRelativeDates, ExportActualOvertimeHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualOvertimeHourTotalsFromDateToDateResponse ExportActualOvertimeHourTotalsFromDateToDate(
      ExportActualOvertimeHourTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualOvertimeHourTotalsFromDateToDate, ExportActualOvertimeHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualOvertimeHourTotalsFromDateToDateResponse> ExportActualOvertimeHourTotalsFromDateToDateAsync(
      ExportActualOvertimeHourTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualOvertimeHourTotalsFromDateToDate, ExportActualOvertimeHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualPerpetualOvertimeHourTotalsListResponse ExportActualPerpetualOvertimeHourTotalsList(
      ExportActualPerpetualOvertimeHourTotalsList arg)
    {
      return Client.Post<ExportActualPerpetualOvertimeHourTotalsList, ExportActualPerpetualOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualPerpetualOvertimeHourTotalsListResponse> ExportActualPerpetualOvertimeHourTotalsListAsync(
      ExportActualPerpetualOvertimeHourTotalsList arg)
    {
      return Client.PostAsync<ExportActualPerpetualOvertimeHourTotalsList, ExportActualPerpetualOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualPerpetualOvertimeHourTotalsListFromDateResponse ExportActualPerpetualOvertimeHourTotalsListFromDate(
      ExportActualPerpetualOvertimeHourTotalsListFromDate arg)
    {
      return Client.Post<ExportActualPerpetualOvertimeHourTotalsListFromDate, ExportActualPerpetualOvertimeHourTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualPerpetualOvertimeHourTotalsListFromDateResponse> ExportActualPerpetualOvertimeHourTotalsListFromDateAsync(
      ExportActualPerpetualOvertimeHourTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportActualPerpetualOvertimeHourTotalsListFromDate, ExportActualPerpetualOvertimeHourTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportActualPerpetualOvertimeHourTotalsFromRelativeDatesResponse ExportActualPerpetualOvertimeHourTotalsFromRelativeDates(
      ExportActualPerpetualOvertimeHourTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualPerpetualOvertimeHourTotalsFromRelativeDates, ExportActualPerpetualOvertimeHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportActualPerpetualOvertimeHourTotalsFromRelativeDatesResponse> ExportActualPerpetualOvertimeHourTotalsFromRelativeDatesAsync(
      ExportActualPerpetualOvertimeHourTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualPerpetualOvertimeHourTotalsFromRelativeDates, ExportActualPerpetualOvertimeHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportWeeklyOvertimeHourTotalsListResponse ExportWeeklyOvertimeHourTotalsList(
      ExportWeeklyOvertimeHourTotalsList arg)
    {
      return Client.Post<ExportWeeklyOvertimeHourTotalsList, ExportWeeklyOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportWeeklyOvertimeHourTotalsListResponse> ExportWeeklyOvertimeHourTotalsListAsync(
      ExportWeeklyOvertimeHourTotalsList arg)
    {
      return Client.PostAsync<ExportWeeklyOvertimeHourTotalsList, ExportWeeklyOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportDailyOvertimeHourTotalsListResponse ExportDailyOvertimeHourTotalsList(
      ExportDailyOvertimeHourTotalsList arg)
    {
      return Client.Post<ExportDailyOvertimeHourTotalsList, ExportDailyOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportDailyOvertimeHourTotalsListResponse> ExportDailyOvertimeHourTotalsListAsync(
      ExportDailyOvertimeHourTotalsList arg)
    {
      return Client.PostAsync<ExportDailyOvertimeHourTotalsList, ExportDailyOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPerpetualOvertimeHourTotalsListResponse ExportPerpetualOvertimeHourTotalsList(
      ExportPerpetualOvertimeHourTotalsList arg)
    {
      return Client.Post<ExportPerpetualOvertimeHourTotalsList, ExportPerpetualOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPerpetualOvertimeHourTotalsListResponse> ExportPerpetualOvertimeHourTotalsListAsync(
      ExportPerpetualOvertimeHourTotalsList arg)
    {
      return Client.PostAsync<ExportPerpetualOvertimeHourTotalsList, ExportPerpetualOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportWeeklyOvertimeHourTotalsResponse ExportWeeklyOvertimeHourTotals(
      ExportWeeklyOvertimeHourTotals arg)
    {
      return Client.Post<ExportWeeklyOvertimeHourTotals, ExportWeeklyOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportWeeklyOvertimeHourTotalsResponse> ExportWeeklyOvertimeHourTotalsAsync(
      ExportWeeklyOvertimeHourTotals arg)
    {
      return Client.PostAsync<ExportWeeklyOvertimeHourTotals, ExportWeeklyOvertimeHourTotalsResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public ExportPeriodicalOvertimeHourTotalsListResponse ExportPeriodicalOvertimeHourTotalsList(
      ExportPeriodicalOvertimeHourTotalsList arg)
    {
      return Client.Post<ExportPeriodicalOvertimeHourTotalsList, ExportPeriodicalOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }

    public Task<ExportPeriodicalOvertimeHourTotalsListResponse> ExportPeriodicalOvertimeHourTotalsListAsync(
      ExportPeriodicalOvertimeHourTotalsList arg)
    {
      return Client.PostAsync<ExportPeriodicalOvertimeHourTotalsList, ExportPeriodicalOvertimeHourTotalsListResponse>(this.username, this.password, this.baseuri, "OvertimeHourTotalService", arg);
    }
  }
}
