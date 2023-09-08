
//.SpecialHourTotalServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class SpecialHourTotalServiceClient
  {
    private const string service = "SpecialHourTotalService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public SpecialHourTotalServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportActualDailySpecialHourTotalsFromDateToDateForEmployeeListResponse ExportActualDailySpecialHourTotalsFromDateToDateForEmployeeList(
      ExportActualDailySpecialHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualDailySpecialHourTotalsFromDateToDateForEmployeeList, ExportActualDailySpecialHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualDailySpecialHourTotalsFromDateToDateForEmployeeListResponse> ExportActualDailySpecialHourTotalsFromDateToDateForEmployeeListAsync(
      ExportActualDailySpecialHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailySpecialHourTotalsFromDateToDateForEmployeeList, ExportActualDailySpecialHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualDailySpecialHourTotalsFromPeriodForEmployeeListResponse ExportActualDailySpecialHourTotalsFromPeriodForEmployeeList(
      ExportActualDailySpecialHourTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportActualDailySpecialHourTotalsFromPeriodForEmployeeList, ExportActualDailySpecialHourTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualDailySpecialHourTotalsFromPeriodForEmployeeListResponse> ExportActualDailySpecialHourTotalsFromPeriodForEmployeeListAsync(
      ExportActualDailySpecialHourTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailySpecialHourTotalsFromPeriodForEmployeeList, ExportActualDailySpecialHourTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeListResponse ExportActualPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeList(
      ExportActualPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeListResponse> ExportActualPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualPerpetualSpecialHourTotalsListFromDateForEmployeeListResponse ExportActualPerpetualSpecialHourTotalsListFromDateForEmployeeList(
      ExportActualPerpetualSpecialHourTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualSpecialHourTotalsListFromDateForEmployeeList, ExportActualPerpetualSpecialHourTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualPerpetualSpecialHourTotalsListFromDateForEmployeeListResponse> ExportActualPerpetualSpecialHourTotalsListFromDateForEmployeeListAsync(
      ExportActualPerpetualSpecialHourTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualSpecialHourTotalsListFromDateForEmployeeList, ExportActualPerpetualSpecialHourTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedPerpetualSpecialHourTotalsListFromDateForEmployeeListResponse ExportEstimatedPerpetualSpecialHourTotalsListFromDateForEmployeeList(
      ExportEstimatedPerpetualSpecialHourTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualSpecialHourTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualSpecialHourTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualSpecialHourTotalsListFromDateForEmployeeListResponse> ExportEstimatedPerpetualSpecialHourTotalsListFromDateForEmployeeListAsync(
      ExportEstimatedPerpetualSpecialHourTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualSpecialHourTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualSpecialHourTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualPeriodicalSpecialHourTotalsForEmployeeListResponse ExportActualPeriodicalSpecialHourTotalsForEmployeeList(
      ExportActualPeriodicalSpecialHourTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalSpecialHourTotalsForEmployeeList, ExportActualPeriodicalSpecialHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualPeriodicalSpecialHourTotalsForEmployeeListResponse> ExportActualPeriodicalSpecialHourTotalsForEmployeeListAsync(
      ExportActualPeriodicalSpecialHourTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalSpecialHourTotalsForEmployeeList, ExportActualPeriodicalSpecialHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedPerpetualSpecialHourTotalsListForEmployeeListResponse ExportPlannedPerpetualSpecialHourTotalsListForEmployeeList(
      ExportPlannedPerpetualSpecialHourTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualSpecialHourTotalsListForEmployeeList, ExportPlannedPerpetualSpecialHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedPerpetualSpecialHourTotalsListForEmployeeListResponse> ExportPlannedPerpetualSpecialHourTotalsListForEmployeeListAsync(
      ExportPlannedPerpetualSpecialHourTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualSpecialHourTotalsListForEmployeeList, ExportPlannedPerpetualSpecialHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualPerpetualSpecialHourTotalsListForEmployeeListResponse ExportActualPerpetualSpecialHourTotalsListForEmployeeList(
      ExportActualPerpetualSpecialHourTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualSpecialHourTotalsListForEmployeeList, ExportActualPerpetualSpecialHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualPerpetualSpecialHourTotalsListForEmployeeListResponse> ExportActualPerpetualSpecialHourTotalsListForEmployeeListAsync(
      ExportActualPerpetualSpecialHourTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualSpecialHourTotalsListForEmployeeList, ExportActualPerpetualSpecialHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedPerpetualSpecialHourTotalsListFromDateForEmployeeListResponse ExportPlannedPerpetualSpecialHourTotalsListFromDateForEmployeeList(
      ExportPlannedPerpetualSpecialHourTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualSpecialHourTotalsListFromDateForEmployeeList, ExportPlannedPerpetualSpecialHourTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedPerpetualSpecialHourTotalsListFromDateForEmployeeListResponse> ExportPlannedPerpetualSpecialHourTotalsListFromDateForEmployeeListAsync(
      ExportPlannedPerpetualSpecialHourTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualSpecialHourTotalsListFromDateForEmployeeList, ExportPlannedPerpetualSpecialHourTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedSpecialHourTotalsFromDateToDateForEmployeeListResponse ExportPlannedSpecialHourTotalsFromDateToDateForEmployeeList(
      ExportPlannedSpecialHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedSpecialHourTotalsFromDateToDateForEmployeeList, ExportPlannedSpecialHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedSpecialHourTotalsFromDateToDateForEmployeeListResponse> ExportPlannedSpecialHourTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedSpecialHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedSpecialHourTotalsFromDateToDateForEmployeeList, ExportPlannedSpecialHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualSpecialHourTotalsFromDateToDateForEmployeeListResponse ExportActualSpecialHourTotalsFromDateToDateForEmployeeList(
      ExportActualSpecialHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualSpecialHourTotalsFromDateToDateForEmployeeList, ExportActualSpecialHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualSpecialHourTotalsFromDateToDateForEmployeeListResponse> ExportActualSpecialHourTotalsFromDateToDateForEmployeeListAsync(
      ExportActualSpecialHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualSpecialHourTotalsFromDateToDateForEmployeeList, ExportActualSpecialHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedDailySpecialHourTotalsFromDateToDateForEmployeeListResponse ExportEstimatedDailySpecialHourTotalsFromDateToDateForEmployeeList(
      ExportEstimatedDailySpecialHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailySpecialHourTotalsFromDateToDateForEmployeeList, ExportEstimatedDailySpecialHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedDailySpecialHourTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedDailySpecialHourTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedDailySpecialHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailySpecialHourTotalsFromDateToDateForEmployeeList, ExportEstimatedDailySpecialHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualDailySpecialHourTotalsFromRelativeDatesForEmployeeListResponse ExportActualDailySpecialHourTotalsFromRelativeDatesForEmployeeList(
      ExportActualDailySpecialHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualDailySpecialHourTotalsFromRelativeDatesForEmployeeList, ExportActualDailySpecialHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualDailySpecialHourTotalsFromRelativeDatesForEmployeeListResponse> ExportActualDailySpecialHourTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualDailySpecialHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailySpecialHourTotalsFromRelativeDatesForEmployeeList, ExportActualDailySpecialHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedWeeklySpecialHourTotalsForEmployeeListResponse ExportEstimatedWeeklySpecialHourTotalsForEmployeeList(
      ExportEstimatedWeeklySpecialHourTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklySpecialHourTotalsForEmployeeList, ExportEstimatedWeeklySpecialHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedWeeklySpecialHourTotalsForEmployeeListResponse> ExportEstimatedWeeklySpecialHourTotalsForEmployeeListAsync(
      ExportEstimatedWeeklySpecialHourTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklySpecialHourTotalsForEmployeeList, ExportEstimatedWeeklySpecialHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedWeeklySpecialHourTotalsForEmployeeListResponse ExportPlannedWeeklySpecialHourTotalsForEmployeeList(
      ExportPlannedWeeklySpecialHourTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklySpecialHourTotalsForEmployeeList, ExportPlannedWeeklySpecialHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedWeeklySpecialHourTotalsForEmployeeListResponse> ExportPlannedWeeklySpecialHourTotalsForEmployeeListAsync(
      ExportPlannedWeeklySpecialHourTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklySpecialHourTotalsForEmployeeList, ExportPlannedWeeklySpecialHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualWeeklySpecialHourTotalsListForEmployeeListResponse ExportActualWeeklySpecialHourTotalsListForEmployeeList(
      ExportActualWeeklySpecialHourTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklySpecialHourTotalsListForEmployeeList, ExportActualWeeklySpecialHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualWeeklySpecialHourTotalsListForEmployeeListResponse> ExportActualWeeklySpecialHourTotalsListForEmployeeListAsync(
      ExportActualWeeklySpecialHourTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklySpecialHourTotalsListForEmployeeList, ExportActualWeeklySpecialHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualWeeklySpecialHourTotalsForEmployeeListResponse ExportActualWeeklySpecialHourTotalsForEmployeeList(
      ExportActualWeeklySpecialHourTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklySpecialHourTotalsForEmployeeList, ExportActualWeeklySpecialHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualWeeklySpecialHourTotalsForEmployeeListResponse> ExportActualWeeklySpecialHourTotalsForEmployeeListAsync(
      ExportActualWeeklySpecialHourTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklySpecialHourTotalsForEmployeeList, ExportActualWeeklySpecialHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedDailySpecialHourTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedDailySpecialHourTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedDailySpecialHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailySpecialHourTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailySpecialHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedDailySpecialHourTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedDailySpecialHourTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedDailySpecialHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailySpecialHourTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailySpecialHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedDailySpecialHourTotalsFromPeriodForEmployeeListResponse ExportEstimatedDailySpecialHourTotalsFromPeriodForEmployeeList(
      ExportEstimatedDailySpecialHourTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailySpecialHourTotalsFromPeriodForEmployeeList, ExportEstimatedDailySpecialHourTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedDailySpecialHourTotalsFromPeriodForEmployeeListResponse> ExportEstimatedDailySpecialHourTotalsFromPeriodForEmployeeListAsync(
      ExportEstimatedDailySpecialHourTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailySpecialHourTotalsFromPeriodForEmployeeList, ExportEstimatedDailySpecialHourTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedDailySpecialHourTotalsFromDateToDateForEmployeeListResponse ExportPlannedDailySpecialHourTotalsFromDateToDateForEmployeeList(
      ExportPlannedDailySpecialHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailySpecialHourTotalsFromDateToDateForEmployeeList, ExportPlannedDailySpecialHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedDailySpecialHourTotalsFromDateToDateForEmployeeListResponse> ExportPlannedDailySpecialHourTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedDailySpecialHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailySpecialHourTotalsFromDateToDateForEmployeeList, ExportPlannedDailySpecialHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedDailySpecialHourTotalsFromPeriodForEmployeeListResponse ExportPlannedDailySpecialHourTotalsFromPeriodForEmployeeList(
      ExportPlannedDailySpecialHourTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailySpecialHourTotalsFromPeriodForEmployeeList, ExportPlannedDailySpecialHourTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedDailySpecialHourTotalsFromPeriodForEmployeeListResponse> ExportPlannedDailySpecialHourTotalsFromPeriodForEmployeeListAsync(
      ExportPlannedDailySpecialHourTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailySpecialHourTotalsFromPeriodForEmployeeList, ExportPlannedDailySpecialHourTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedPeriodicalSpecialHourTotalsForEmployeeListResponse ExportEstimatedPeriodicalSpecialHourTotalsForEmployeeList(
      ExportEstimatedPeriodicalSpecialHourTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalSpecialHourTotalsForEmployeeList, ExportEstimatedPeriodicalSpecialHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalSpecialHourTotalsForEmployeeListResponse> ExportEstimatedPeriodicalSpecialHourTotalsForEmployeeListAsync(
      ExportEstimatedPeriodicalSpecialHourTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalSpecialHourTotalsForEmployeeList, ExportEstimatedPeriodicalSpecialHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualWeeklySpecialHourTotalsListFromDateToDateForEmployeeListResponse ExportActualWeeklySpecialHourTotalsListFromDateToDateForEmployeeList(
      ExportActualWeeklySpecialHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklySpecialHourTotalsListFromDateToDateForEmployeeList, ExportActualWeeklySpecialHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualWeeklySpecialHourTotalsListFromDateToDateForEmployeeListResponse> ExportActualWeeklySpecialHourTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualWeeklySpecialHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklySpecialHourTotalsListFromDateToDateForEmployeeList, ExportActualWeeklySpecialHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeListResponse ExportActualPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeList(
      ExportActualPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeListResponse> ExportActualPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualSpecialHourTotalsFromRelativeDatesForEmployeeListResponse ExportActualSpecialHourTotalsFromRelativeDatesForEmployeeList(
      ExportActualSpecialHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualSpecialHourTotalsFromRelativeDatesForEmployeeList, ExportActualSpecialHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualSpecialHourTotalsFromRelativeDatesForEmployeeListResponse> ExportActualSpecialHourTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualSpecialHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualSpecialHourTotalsFromRelativeDatesForEmployeeList, ExportActualSpecialHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedWeeklySpecialHourTotalsListFromDateToDateForEmployeeListResponse ExportPlannedWeeklySpecialHourTotalsListFromDateToDateForEmployeeList(
      ExportPlannedWeeklySpecialHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklySpecialHourTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklySpecialHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedWeeklySpecialHourTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedWeeklySpecialHourTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedWeeklySpecialHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklySpecialHourTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklySpecialHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedWeeklySpecialHourTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedWeeklySpecialHourTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedWeeklySpecialHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklySpecialHourTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklySpecialHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedWeeklySpecialHourTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedWeeklySpecialHourTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedWeeklySpecialHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklySpecialHourTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklySpecialHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedPeriodicalSpecialHourTotalsForEmployeeListResponse ExportPlannedPeriodicalSpecialHourTotalsForEmployeeList(
      ExportPlannedPeriodicalSpecialHourTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalSpecialHourTotalsForEmployeeList, ExportPlannedPeriodicalSpecialHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalSpecialHourTotalsForEmployeeListResponse> ExportPlannedPeriodicalSpecialHourTotalsForEmployeeListAsync(
      ExportPlannedPeriodicalSpecialHourTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalSpecialHourTotalsForEmployeeList, ExportPlannedPeriodicalSpecialHourTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedSpecialHourTotalsFromDateToDateForEmployeeListResponse ExportEstimatedSpecialHourTotalsFromDateToDateForEmployeeList(
      ExportEstimatedSpecialHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedSpecialHourTotalsFromDateToDateForEmployeeList, ExportEstimatedSpecialHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedSpecialHourTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedSpecialHourTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedSpecialHourTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedSpecialHourTotalsFromDateToDateForEmployeeList, ExportEstimatedSpecialHourTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualPeriodicalSpecialHourTotalsListForEmployeeListResponse ExportActualPeriodicalSpecialHourTotalsListForEmployeeList(
      ExportActualPeriodicalSpecialHourTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalSpecialHourTotalsListForEmployeeList, ExportActualPeriodicalSpecialHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualPeriodicalSpecialHourTotalsListForEmployeeListResponse> ExportActualPeriodicalSpecialHourTotalsListForEmployeeListAsync(
      ExportActualPeriodicalSpecialHourTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalSpecialHourTotalsListForEmployeeList, ExportActualPeriodicalSpecialHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedPerpetualSpecialHourTotalsListForEmployeeListResponse ExportEstimatedPerpetualSpecialHourTotalsListForEmployeeList(
      ExportEstimatedPerpetualSpecialHourTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualSpecialHourTotalsListForEmployeeList, ExportEstimatedPerpetualSpecialHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualSpecialHourTotalsListForEmployeeListResponse> ExportEstimatedPerpetualSpecialHourTotalsListForEmployeeListAsync(
      ExportEstimatedPerpetualSpecialHourTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualSpecialHourTotalsListForEmployeeList, ExportEstimatedPerpetualSpecialHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedPeriodicalSpecialHourTotalsListForEmployeeListResponse ExportPlannedPeriodicalSpecialHourTotalsListForEmployeeList(
      ExportPlannedPeriodicalSpecialHourTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalSpecialHourTotalsListForEmployeeList, ExportPlannedPeriodicalSpecialHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalSpecialHourTotalsListForEmployeeListResponse> ExportPlannedPeriodicalSpecialHourTotalsListForEmployeeListAsync(
      ExportPlannedPeriodicalSpecialHourTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalSpecialHourTotalsListForEmployeeList, ExportPlannedPeriodicalSpecialHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeListResponse ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeList(
      ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedSpecialHourTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedSpecialHourTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedSpecialHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedSpecialHourTotalsFromRelativeDatesForEmployeeList, ExportPlannedSpecialHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedSpecialHourTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedSpecialHourTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedSpecialHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedSpecialHourTotalsFromRelativeDatesForEmployeeList, ExportPlannedSpecialHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedSpecialHourTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedSpecialHourTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedSpecialHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedSpecialHourTotalsFromRelativeDatesForEmployeeList, ExportEstimatedSpecialHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedSpecialHourTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedSpecialHourTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedSpecialHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedSpecialHourTotalsFromRelativeDatesForEmployeeList, ExportEstimatedSpecialHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedWeeklySpecialHourTotalsListForEmployeeListResponse ExportEstimatedWeeklySpecialHourTotalsListForEmployeeList(
      ExportEstimatedWeeklySpecialHourTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklySpecialHourTotalsListForEmployeeList, ExportEstimatedWeeklySpecialHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedWeeklySpecialHourTotalsListForEmployeeListResponse> ExportEstimatedWeeklySpecialHourTotalsListForEmployeeListAsync(
      ExportEstimatedWeeklySpecialHourTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklySpecialHourTotalsListForEmployeeList, ExportEstimatedWeeklySpecialHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedWeeklySpecialHourTotalsListForEmployeeListResponse ExportPlannedWeeklySpecialHourTotalsListForEmployeeList(
      ExportPlannedWeeklySpecialHourTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklySpecialHourTotalsListForEmployeeList, ExportPlannedWeeklySpecialHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedWeeklySpecialHourTotalsListForEmployeeListResponse> ExportPlannedWeeklySpecialHourTotalsListForEmployeeListAsync(
      ExportPlannedWeeklySpecialHourTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklySpecialHourTotalsListForEmployeeList, ExportPlannedWeeklySpecialHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedPeriodicalSpecialHourTotalsListForEmployeeListResponse ExportEstimatedPeriodicalSpecialHourTotalsListForEmployeeList(
      ExportEstimatedPeriodicalSpecialHourTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalSpecialHourTotalsListForEmployeeList, ExportEstimatedPeriodicalSpecialHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalSpecialHourTotalsListForEmployeeListResponse> ExportEstimatedPeriodicalSpecialHourTotalsListForEmployeeListAsync(
      ExportEstimatedPeriodicalSpecialHourTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalSpecialHourTotalsListForEmployeeList, ExportEstimatedPeriodicalSpecialHourTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedDailySpecialHourTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedDailySpecialHourTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedDailySpecialHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailySpecialHourTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailySpecialHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedDailySpecialHourTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedDailySpecialHourTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedDailySpecialHourTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailySpecialHourTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailySpecialHourTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedPeriodicalSpecialHourTotalsResponse ExportPlannedPeriodicalSpecialHourTotals(
      ExportPlannedPeriodicalSpecialHourTotals arg)
    {
      return Client.Post<ExportPlannedPeriodicalSpecialHourTotals, ExportPlannedPeriodicalSpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalSpecialHourTotalsResponse> ExportPlannedPeriodicalSpecialHourTotalsAsync(
      ExportPlannedPeriodicalSpecialHourTotals arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalSpecialHourTotals, ExportPlannedPeriodicalSpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedPeriodicalSpecialHourTotalsListResponse ExportPlannedPeriodicalSpecialHourTotalsList(
      ExportPlannedPeriodicalSpecialHourTotalsList arg)
    {
      return Client.Post<ExportPlannedPeriodicalSpecialHourTotalsList, ExportPlannedPeriodicalSpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalSpecialHourTotalsListResponse> ExportPlannedPeriodicalSpecialHourTotalsListAsync(
      ExportPlannedPeriodicalSpecialHourTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalSpecialHourTotalsList, ExportPlannedPeriodicalSpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDateResponse ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDate(
      ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDate, ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDateResponse> ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDateAsync(
      ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDate, ExportPlannedPeriodicalSpecialHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedPerpetualSpecialHourTotalsFromRelativeDatesResponse ExportPlannedPerpetualSpecialHourTotalsFromRelativeDates(
      ExportPlannedPerpetualSpecialHourTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedPerpetualSpecialHourTotalsFromRelativeDates, ExportPlannedPerpetualSpecialHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedPerpetualSpecialHourTotalsFromRelativeDatesResponse> ExportPlannedPerpetualSpecialHourTotalsFromRelativeDatesAsync(
      ExportPlannedPerpetualSpecialHourTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualSpecialHourTotalsFromRelativeDates, ExportPlannedPerpetualSpecialHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedPerpetualSpecialHourTotalsListFromDateResponse ExportPlannedPerpetualSpecialHourTotalsListFromDate(
      ExportPlannedPerpetualSpecialHourTotalsListFromDate arg)
    {
      return Client.Post<ExportPlannedPerpetualSpecialHourTotalsListFromDate, ExportPlannedPerpetualSpecialHourTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedPerpetualSpecialHourTotalsListFromDateResponse> ExportPlannedPerpetualSpecialHourTotalsListFromDateAsync(
      ExportPlannedPerpetualSpecialHourTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualSpecialHourTotalsListFromDate, ExportPlannedPerpetualSpecialHourTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedPerpetualSpecialHourTotalsListResponse ExportPlannedPerpetualSpecialHourTotalsList(
      ExportPlannedPerpetualSpecialHourTotalsList arg)
    {
      return Client.Post<ExportPlannedPerpetualSpecialHourTotalsList, ExportPlannedPerpetualSpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedPerpetualSpecialHourTotalsListResponse> ExportPlannedPerpetualSpecialHourTotalsListAsync(
      ExportPlannedPerpetualSpecialHourTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualSpecialHourTotalsList, ExportPlannedPerpetualSpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualPeriodicalSpecialHourTotalsListResponse ExportActualPeriodicalSpecialHourTotalsList(
      ExportActualPeriodicalSpecialHourTotalsList arg)
    {
      return Client.Post<ExportActualPeriodicalSpecialHourTotalsList, ExportActualPeriodicalSpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualPeriodicalSpecialHourTotalsListResponse> ExportActualPeriodicalSpecialHourTotalsListAsync(
      ExportActualPeriodicalSpecialHourTotalsList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalSpecialHourTotalsList, ExportActualPeriodicalSpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualPeriodicalSpecialHourTotalsListFromDateToDateResponse ExportActualPeriodicalSpecialHourTotalsListFromDateToDate(
      ExportActualPeriodicalSpecialHourTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualPeriodicalSpecialHourTotalsListFromDateToDate, ExportActualPeriodicalSpecialHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualPeriodicalSpecialHourTotalsListFromDateToDateResponse> ExportActualPeriodicalSpecialHourTotalsListFromDateToDateAsync(
      ExportActualPeriodicalSpecialHourTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualPeriodicalSpecialHourTotalsListFromDateToDate, ExportActualPeriodicalSpecialHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualPeriodicalSpecialHourTotalsResponse ExportActualPeriodicalSpecialHourTotals(
      ExportActualPeriodicalSpecialHourTotals arg)
    {
      return Client.Post<ExportActualPeriodicalSpecialHourTotals, ExportActualPeriodicalSpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualPeriodicalSpecialHourTotalsResponse> ExportActualPeriodicalSpecialHourTotalsAsync(
      ExportActualPeriodicalSpecialHourTotals arg)
    {
      return Client.PostAsync<ExportActualPeriodicalSpecialHourTotals, ExportActualPeriodicalSpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedPerpetualSpecialHourTotalsListResponse ExportEstimatedPerpetualSpecialHourTotalsList(
      ExportEstimatedPerpetualSpecialHourTotalsList arg)
    {
      return Client.Post<ExportEstimatedPerpetualSpecialHourTotalsList, ExportEstimatedPerpetualSpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualSpecialHourTotalsListResponse> ExportEstimatedPerpetualSpecialHourTotalsListAsync(
      ExportEstimatedPerpetualSpecialHourTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualSpecialHourTotalsList, ExportEstimatedPerpetualSpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedPerpetualSpecialHourTotalsListFromDateResponse ExportEstimatedPerpetualSpecialHourTotalsListFromDate(
      ExportEstimatedPerpetualSpecialHourTotalsListFromDate arg)
    {
      return Client.Post<ExportEstimatedPerpetualSpecialHourTotalsListFromDate, ExportEstimatedPerpetualSpecialHourTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualSpecialHourTotalsListFromDateResponse> ExportEstimatedPerpetualSpecialHourTotalsListFromDateAsync(
      ExportEstimatedPerpetualSpecialHourTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualSpecialHourTotalsListFromDate, ExportEstimatedPerpetualSpecialHourTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDatesResponse ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDates(
      ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDates, ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDatesResponse> ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDatesAsync(
      ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDates, ExportEstimatedPerpetualSpecialHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedSpecialHourTotalsFromDateToDateResponse ExportEstimatedSpecialHourTotalsFromDateToDate(
      ExportEstimatedSpecialHourTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedSpecialHourTotalsFromDateToDate, ExportEstimatedSpecialHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedSpecialHourTotalsFromDateToDateResponse> ExportEstimatedSpecialHourTotalsFromDateToDateAsync(
      ExportEstimatedSpecialHourTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedSpecialHourTotalsFromDateToDate, ExportEstimatedSpecialHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedSpecialHourTotalsFromRelativeDatesResponse ExportEstimatedSpecialHourTotalsFromRelativeDates(
      ExportEstimatedSpecialHourTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedSpecialHourTotalsFromRelativeDates, ExportEstimatedSpecialHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedSpecialHourTotalsFromRelativeDatesResponse> ExportEstimatedSpecialHourTotalsFromRelativeDatesAsync(
      ExportEstimatedSpecialHourTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedSpecialHourTotalsFromRelativeDates, ExportEstimatedSpecialHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedSpecialHourTotalsFromDateToDateResponse ExportPlannedSpecialHourTotalsFromDateToDate(
      ExportPlannedSpecialHourTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedSpecialHourTotalsFromDateToDate, ExportPlannedSpecialHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedSpecialHourTotalsFromDateToDateResponse> ExportPlannedSpecialHourTotalsFromDateToDateAsync(
      ExportPlannedSpecialHourTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedSpecialHourTotalsFromDateToDate, ExportPlannedSpecialHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedSpecialHourTotalsFromRelativeDatesResponse ExportPlannedSpecialHourTotalsFromRelativeDates(
      ExportPlannedSpecialHourTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedSpecialHourTotalsFromRelativeDates, ExportPlannedSpecialHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedSpecialHourTotalsFromRelativeDatesResponse> ExportPlannedSpecialHourTotalsFromRelativeDatesAsync(
      ExportPlannedSpecialHourTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedSpecialHourTotalsFromRelativeDates, ExportPlannedSpecialHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportDailySpecialHourTotalsResponse ExportDailySpecialHourTotals(
      ExportDailySpecialHourTotals arg)
    {
      return Client.Post<ExportDailySpecialHourTotals, ExportDailySpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportDailySpecialHourTotalsResponse> ExportDailySpecialHourTotalsAsync(
      ExportDailySpecialHourTotals arg)
    {
      return Client.PostAsync<ExportDailySpecialHourTotals, ExportDailySpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPeriodicalSpecialHourTotalsResponse ExportPeriodicalSpecialHourTotals(
      ExportPeriodicalSpecialHourTotals arg)
    {
      return Client.Post<ExportPeriodicalSpecialHourTotals, ExportPeriodicalSpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPeriodicalSpecialHourTotalsResponse> ExportPeriodicalSpecialHourTotalsAsync(
      ExportPeriodicalSpecialHourTotals arg)
    {
      return Client.PostAsync<ExportPeriodicalSpecialHourTotals, ExportPeriodicalSpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPerpetualSpecialHourTotalsResponse ExportPerpetualSpecialHourTotals(
      ExportPerpetualSpecialHourTotals arg)
    {
      return Client.Post<ExportPerpetualSpecialHourTotals, ExportPerpetualSpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPerpetualSpecialHourTotalsResponse> ExportPerpetualSpecialHourTotalsAsync(
      ExportPerpetualSpecialHourTotals arg)
    {
      return Client.PostAsync<ExportPerpetualSpecialHourTotals, ExportPerpetualSpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedDailySpecialHourTotalsFromDateToDateResponse ExportEstimatedDailySpecialHourTotalsFromDateToDate(
      ExportEstimatedDailySpecialHourTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedDailySpecialHourTotalsFromDateToDate, ExportEstimatedDailySpecialHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedDailySpecialHourTotalsFromDateToDateResponse> ExportEstimatedDailySpecialHourTotalsFromDateToDateAsync(
      ExportEstimatedDailySpecialHourTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedDailySpecialHourTotalsFromDateToDate, ExportEstimatedDailySpecialHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedDailySpecialHourTotalsFromPeriodResponse ExportEstimatedDailySpecialHourTotalsFromPeriod(
      ExportEstimatedDailySpecialHourTotalsFromPeriod arg)
    {
      return Client.Post<ExportEstimatedDailySpecialHourTotalsFromPeriod, ExportEstimatedDailySpecialHourTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedDailySpecialHourTotalsFromPeriodResponse> ExportEstimatedDailySpecialHourTotalsFromPeriodAsync(
      ExportEstimatedDailySpecialHourTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportEstimatedDailySpecialHourTotalsFromPeriod, ExportEstimatedDailySpecialHourTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedDailySpecialHourTotalsFromRelativeDatesResponse ExportEstimatedDailySpecialHourTotalsFromRelativeDates(
      ExportEstimatedDailySpecialHourTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedDailySpecialHourTotalsFromRelativeDates, ExportEstimatedDailySpecialHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedDailySpecialHourTotalsFromRelativeDatesResponse> ExportEstimatedDailySpecialHourTotalsFromRelativeDatesAsync(
      ExportEstimatedDailySpecialHourTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedDailySpecialHourTotalsFromRelativeDates, ExportEstimatedDailySpecialHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualWeeklySpecialHourTotalsListResponse ExportActualWeeklySpecialHourTotalsList(
      ExportActualWeeklySpecialHourTotalsList arg)
    {
      return Client.Post<ExportActualWeeklySpecialHourTotalsList, ExportActualWeeklySpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualWeeklySpecialHourTotalsListResponse> ExportActualWeeklySpecialHourTotalsListAsync(
      ExportActualWeeklySpecialHourTotalsList arg)
    {
      return Client.PostAsync<ExportActualWeeklySpecialHourTotalsList, ExportActualWeeklySpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualWeeklySpecialHourTotalsListFromDateToDateResponse ExportActualWeeklySpecialHourTotalsListFromDateToDate(
      ExportActualWeeklySpecialHourTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualWeeklySpecialHourTotalsListFromDateToDate, ExportActualWeeklySpecialHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualWeeklySpecialHourTotalsListFromDateToDateResponse> ExportActualWeeklySpecialHourTotalsListFromDateToDateAsync(
      ExportActualWeeklySpecialHourTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualWeeklySpecialHourTotalsListFromDateToDate, ExportActualWeeklySpecialHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualWeeklySpecialHourTotalsResponse ExportActualWeeklySpecialHourTotals(
      ExportActualWeeklySpecialHourTotals arg)
    {
      return Client.Post<ExportActualWeeklySpecialHourTotals, ExportActualWeeklySpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualWeeklySpecialHourTotalsResponse> ExportActualWeeklySpecialHourTotalsAsync(
      ExportActualWeeklySpecialHourTotals arg)
    {
      return Client.PostAsync<ExportActualWeeklySpecialHourTotals, ExportActualWeeklySpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedDailySpecialHourTotalsFromPeriodResponse ExportPlannedDailySpecialHourTotalsFromPeriod(
      ExportPlannedDailySpecialHourTotalsFromPeriod arg)
    {
      return Client.Post<ExportPlannedDailySpecialHourTotalsFromPeriod, ExportPlannedDailySpecialHourTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedDailySpecialHourTotalsFromPeriodResponse> ExportPlannedDailySpecialHourTotalsFromPeriodAsync(
      ExportPlannedDailySpecialHourTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportPlannedDailySpecialHourTotalsFromPeriod, ExportPlannedDailySpecialHourTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedDailySpecialHourTotalsFromRelativeDatesResponse ExportPlannedDailySpecialHourTotalsFromRelativeDates(
      ExportPlannedDailySpecialHourTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedDailySpecialHourTotalsFromRelativeDates, ExportPlannedDailySpecialHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedDailySpecialHourTotalsFromRelativeDatesResponse> ExportPlannedDailySpecialHourTotalsFromRelativeDatesAsync(
      ExportPlannedDailySpecialHourTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedDailySpecialHourTotalsFromRelativeDates, ExportPlannedDailySpecialHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedDailySpecialHourTotalsFromDateToDateResponse ExportPlannedDailySpecialHourTotalsFromDateToDate(
      ExportPlannedDailySpecialHourTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedDailySpecialHourTotalsFromDateToDate, ExportPlannedDailySpecialHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedDailySpecialHourTotalsFromDateToDateResponse> ExportPlannedDailySpecialHourTotalsFromDateToDateAsync(
      ExportPlannedDailySpecialHourTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedDailySpecialHourTotalsFromDateToDate, ExportPlannedDailySpecialHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualDailySpecialHourTotalsFromPeriodResponse ExportActualDailySpecialHourTotalsFromPeriod(
      ExportActualDailySpecialHourTotalsFromPeriod arg)
    {
      return Client.Post<ExportActualDailySpecialHourTotalsFromPeriod, ExportActualDailySpecialHourTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualDailySpecialHourTotalsFromPeriodResponse> ExportActualDailySpecialHourTotalsFromPeriodAsync(
      ExportActualDailySpecialHourTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportActualDailySpecialHourTotalsFromPeriod, ExportActualDailySpecialHourTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualDailySpecialHourTotalsFromDateToDateResponse ExportActualDailySpecialHourTotalsFromDateToDate(
      ExportActualDailySpecialHourTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualDailySpecialHourTotalsFromDateToDate, ExportActualDailySpecialHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualDailySpecialHourTotalsFromDateToDateResponse> ExportActualDailySpecialHourTotalsFromDateToDateAsync(
      ExportActualDailySpecialHourTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualDailySpecialHourTotalsFromDateToDate, ExportActualDailySpecialHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualDailySpecialHourTotalsFromRelativeDatesResponse ExportActualDailySpecialHourTotalsFromRelativeDates(
      ExportActualDailySpecialHourTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualDailySpecialHourTotalsFromRelativeDates, ExportActualDailySpecialHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualDailySpecialHourTotalsFromRelativeDatesResponse> ExportActualDailySpecialHourTotalsFromRelativeDatesAsync(
      ExportActualDailySpecialHourTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualDailySpecialHourTotalsFromRelativeDates, ExportActualDailySpecialHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedWeeklySpecialHourTotalsResponse ExportPlannedWeeklySpecialHourTotals(
      ExportPlannedWeeklySpecialHourTotals arg)
    {
      return Client.Post<ExportPlannedWeeklySpecialHourTotals, ExportPlannedWeeklySpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedWeeklySpecialHourTotalsResponse> ExportPlannedWeeklySpecialHourTotalsAsync(
      ExportPlannedWeeklySpecialHourTotals arg)
    {
      return Client.PostAsync<ExportPlannedWeeklySpecialHourTotals, ExportPlannedWeeklySpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedWeeklySpecialHourTotalsListFromDateToDateResponse ExportPlannedWeeklySpecialHourTotalsListFromDateToDate(
      ExportPlannedWeeklySpecialHourTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedWeeklySpecialHourTotalsListFromDateToDate, ExportPlannedWeeklySpecialHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedWeeklySpecialHourTotalsListFromDateToDateResponse> ExportPlannedWeeklySpecialHourTotalsListFromDateToDateAsync(
      ExportPlannedWeeklySpecialHourTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedWeeklySpecialHourTotalsListFromDateToDate, ExportPlannedWeeklySpecialHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPlannedWeeklySpecialHourTotalsListResponse ExportPlannedWeeklySpecialHourTotalsList(
      ExportPlannedWeeklySpecialHourTotalsList arg)
    {
      return Client.Post<ExportPlannedWeeklySpecialHourTotalsList, ExportPlannedWeeklySpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPlannedWeeklySpecialHourTotalsListResponse> ExportPlannedWeeklySpecialHourTotalsListAsync(
      ExportPlannedWeeklySpecialHourTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklySpecialHourTotalsList, ExportPlannedWeeklySpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedPeriodicalSpecialHourTotalsListResponse ExportEstimatedPeriodicalSpecialHourTotalsList(
      ExportEstimatedPeriodicalSpecialHourTotalsList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalSpecialHourTotalsList, ExportEstimatedPeriodicalSpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalSpecialHourTotalsListResponse> ExportEstimatedPeriodicalSpecialHourTotalsListAsync(
      ExportEstimatedPeriodicalSpecialHourTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalSpecialHourTotalsList, ExportEstimatedPeriodicalSpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDateResponse ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDate(
      ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDate, ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDateResponse> ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDateAsync(
      ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDate, ExportEstimatedPeriodicalSpecialHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedPeriodicalSpecialHourTotalsResponse ExportEstimatedPeriodicalSpecialHourTotals(
      ExportEstimatedPeriodicalSpecialHourTotals arg)
    {
      return Client.Post<ExportEstimatedPeriodicalSpecialHourTotals, ExportEstimatedPeriodicalSpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalSpecialHourTotalsResponse> ExportEstimatedPeriodicalSpecialHourTotalsAsync(
      ExportEstimatedPeriodicalSpecialHourTotals arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalSpecialHourTotals, ExportEstimatedPeriodicalSpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedWeeklySpecialHourTotalsListResponse ExportEstimatedWeeklySpecialHourTotalsList(
      ExportEstimatedWeeklySpecialHourTotalsList arg)
    {
      return Client.Post<ExportEstimatedWeeklySpecialHourTotalsList, ExportEstimatedWeeklySpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedWeeklySpecialHourTotalsListResponse> ExportEstimatedWeeklySpecialHourTotalsListAsync(
      ExportEstimatedWeeklySpecialHourTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklySpecialHourTotalsList, ExportEstimatedWeeklySpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedWeeklySpecialHourTotalsResponse ExportEstimatedWeeklySpecialHourTotals(
      ExportEstimatedWeeklySpecialHourTotals arg)
    {
      return Client.Post<ExportEstimatedWeeklySpecialHourTotals, ExportEstimatedWeeklySpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedWeeklySpecialHourTotalsResponse> ExportEstimatedWeeklySpecialHourTotalsAsync(
      ExportEstimatedWeeklySpecialHourTotals arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklySpecialHourTotals, ExportEstimatedWeeklySpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportEstimatedWeeklySpecialHourTotalsListFromDateToDateResponse ExportEstimatedWeeklySpecialHourTotalsListFromDateToDate(
      ExportEstimatedWeeklySpecialHourTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedWeeklySpecialHourTotalsListFromDateToDate, ExportEstimatedWeeklySpecialHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportEstimatedWeeklySpecialHourTotalsListFromDateToDateResponse> ExportEstimatedWeeklySpecialHourTotalsListFromDateToDateAsync(
      ExportEstimatedWeeklySpecialHourTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklySpecialHourTotalsListFromDateToDate, ExportEstimatedWeeklySpecialHourTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualSpecialHourTotalsFromDateToDateResponse ExportActualSpecialHourTotalsFromDateToDate(
      ExportActualSpecialHourTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualSpecialHourTotalsFromDateToDate, ExportActualSpecialHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualSpecialHourTotalsFromDateToDateResponse> ExportActualSpecialHourTotalsFromDateToDateAsync(
      ExportActualSpecialHourTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualSpecialHourTotalsFromDateToDate, ExportActualSpecialHourTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualSpecialHourTotalsFromRelativeDatesResponse ExportActualSpecialHourTotalsFromRelativeDates(
      ExportActualSpecialHourTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualSpecialHourTotalsFromRelativeDates, ExportActualSpecialHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualSpecialHourTotalsFromRelativeDatesResponse> ExportActualSpecialHourTotalsFromRelativeDatesAsync(
      ExportActualSpecialHourTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualSpecialHourTotalsFromRelativeDates, ExportActualSpecialHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualPerpetualSpecialHourTotalsListFromDateResponse ExportActualPerpetualSpecialHourTotalsListFromDate(
      ExportActualPerpetualSpecialHourTotalsListFromDate arg)
    {
      return Client.Post<ExportActualPerpetualSpecialHourTotalsListFromDate, ExportActualPerpetualSpecialHourTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualPerpetualSpecialHourTotalsListFromDateResponse> ExportActualPerpetualSpecialHourTotalsListFromDateAsync(
      ExportActualPerpetualSpecialHourTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportActualPerpetualSpecialHourTotalsListFromDate, ExportActualPerpetualSpecialHourTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualPerpetualSpecialHourTotalsListResponse ExportActualPerpetualSpecialHourTotalsList(
      ExportActualPerpetualSpecialHourTotalsList arg)
    {
      return Client.Post<ExportActualPerpetualSpecialHourTotalsList, ExportActualPerpetualSpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualPerpetualSpecialHourTotalsListResponse> ExportActualPerpetualSpecialHourTotalsListAsync(
      ExportActualPerpetualSpecialHourTotalsList arg)
    {
      return Client.PostAsync<ExportActualPerpetualSpecialHourTotalsList, ExportActualPerpetualSpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportActualPerpetualSpecialHourTotalsFromRelativeDatesResponse ExportActualPerpetualSpecialHourTotalsFromRelativeDates(
      ExportActualPerpetualSpecialHourTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualPerpetualSpecialHourTotalsFromRelativeDates, ExportActualPerpetualSpecialHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportActualPerpetualSpecialHourTotalsFromRelativeDatesResponse> ExportActualPerpetualSpecialHourTotalsFromRelativeDatesAsync(
      ExportActualPerpetualSpecialHourTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualPerpetualSpecialHourTotalsFromRelativeDates, ExportActualPerpetualSpecialHourTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportWeeklySpecialHourTotalsListResponse ExportWeeklySpecialHourTotalsList(
      ExportWeeklySpecialHourTotalsList arg)
    {
      return Client.Post<ExportWeeklySpecialHourTotalsList, ExportWeeklySpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportWeeklySpecialHourTotalsListResponse> ExportWeeklySpecialHourTotalsListAsync(
      ExportWeeklySpecialHourTotalsList arg)
    {
      return Client.PostAsync<ExportWeeklySpecialHourTotalsList, ExportWeeklySpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportDailySpecialHourTotalsListResponse ExportDailySpecialHourTotalsList(
      ExportDailySpecialHourTotalsList arg)
    {
      return Client.Post<ExportDailySpecialHourTotalsList, ExportDailySpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportDailySpecialHourTotalsListResponse> ExportDailySpecialHourTotalsListAsync(
      ExportDailySpecialHourTotalsList arg)
    {
      return Client.PostAsync<ExportDailySpecialHourTotalsList, ExportDailySpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPerpetualSpecialHourTotalsListResponse ExportPerpetualSpecialHourTotalsList(
      ExportPerpetualSpecialHourTotalsList arg)
    {
      return Client.Post<ExportPerpetualSpecialHourTotalsList, ExportPerpetualSpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPerpetualSpecialHourTotalsListResponse> ExportPerpetualSpecialHourTotalsListAsync(
      ExportPerpetualSpecialHourTotalsList arg)
    {
      return Client.PostAsync<ExportPerpetualSpecialHourTotalsList, ExportPerpetualSpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportWeeklySpecialHourTotalsResponse ExportWeeklySpecialHourTotals(
      ExportWeeklySpecialHourTotals arg)
    {
      return Client.Post<ExportWeeklySpecialHourTotals, ExportWeeklySpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportWeeklySpecialHourTotalsResponse> ExportWeeklySpecialHourTotalsAsync(
      ExportWeeklySpecialHourTotals arg)
    {
      return Client.PostAsync<ExportWeeklySpecialHourTotals, ExportWeeklySpecialHourTotalsResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public ExportPeriodicalSpecialHourTotalsListResponse ExportPeriodicalSpecialHourTotalsList(
      ExportPeriodicalSpecialHourTotalsList arg)
    {
      return Client.Post<ExportPeriodicalSpecialHourTotalsList, ExportPeriodicalSpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }

    public Task<ExportPeriodicalSpecialHourTotalsListResponse> ExportPeriodicalSpecialHourTotalsListAsync(
      ExportPeriodicalSpecialHourTotalsList arg)
    {
      return Client.PostAsync<ExportPeriodicalSpecialHourTotalsList, ExportPeriodicalSpecialHourTotalsListResponse>(this.username, this.password, this.baseuri, "SpecialHourTotalService", arg);
    }
  }
}
