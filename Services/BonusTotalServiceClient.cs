
//.BonusTotalServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class BonusTotalServiceClient
  {
    private const string service = "BonusTotalService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public BonusTotalServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportActualDailyBonusTotalsFromDateToDateForEmployeeListResponse ExportActualDailyBonusTotalsFromDateToDateForEmployeeList(
      ExportActualDailyBonusTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyBonusTotalsFromDateToDateForEmployeeList, ExportActualDailyBonusTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualDailyBonusTotalsFromDateToDateForEmployeeListResponse> ExportActualDailyBonusTotalsFromDateToDateForEmployeeListAsync(
      ExportActualDailyBonusTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyBonusTotalsFromDateToDateForEmployeeList, ExportActualDailyBonusTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualDailyBonusTotalsFromPeriodForEmployeeListResponse ExportActualDailyBonusTotalsFromPeriodForEmployeeList(
      ExportActualDailyBonusTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyBonusTotalsFromPeriodForEmployeeList, ExportActualDailyBonusTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualDailyBonusTotalsFromPeriodForEmployeeListResponse> ExportActualDailyBonusTotalsFromPeriodForEmployeeListAsync(
      ExportActualDailyBonusTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyBonusTotalsFromPeriodForEmployeeList, ExportActualDailyBonusTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualPeriodicalBonusTotalsListFromDateToDateForEmployeeListResponse ExportActualPeriodicalBonusTotalsListFromDateToDateForEmployeeList(
      ExportActualPeriodicalBonusTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalBonusTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalBonusTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualPeriodicalBonusTotalsListFromDateToDateForEmployeeListResponse> ExportActualPeriodicalBonusTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualPeriodicalBonusTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalBonusTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalBonusTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualPerpetualBonusTotalsListFromDateForEmployeeListResponse ExportActualPerpetualBonusTotalsListFromDateForEmployeeList(
      ExportActualPerpetualBonusTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualBonusTotalsListFromDateForEmployeeList, ExportActualPerpetualBonusTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualPerpetualBonusTotalsListFromDateForEmployeeListResponse> ExportActualPerpetualBonusTotalsListFromDateForEmployeeListAsync(
      ExportActualPerpetualBonusTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualBonusTotalsListFromDateForEmployeeList, ExportActualPerpetualBonusTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedPerpetualBonusTotalsListFromDateForEmployeeListResponse ExportEstimatedPerpetualBonusTotalsListFromDateForEmployeeList(
      ExportEstimatedPerpetualBonusTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualBonusTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualBonusTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualBonusTotalsListFromDateForEmployeeListResponse> ExportEstimatedPerpetualBonusTotalsListFromDateForEmployeeListAsync(
      ExportEstimatedPerpetualBonusTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualBonusTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualBonusTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualPeriodicalBonusTotalsForEmployeeListResponse ExportActualPeriodicalBonusTotalsForEmployeeList(
      ExportActualPeriodicalBonusTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalBonusTotalsForEmployeeList, ExportActualPeriodicalBonusTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualPeriodicalBonusTotalsForEmployeeListResponse> ExportActualPeriodicalBonusTotalsForEmployeeListAsync(
      ExportActualPeriodicalBonusTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalBonusTotalsForEmployeeList, ExportActualPeriodicalBonusTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedPerpetualBonusTotalsListForEmployeeListResponse ExportPlannedPerpetualBonusTotalsListForEmployeeList(
      ExportPlannedPerpetualBonusTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualBonusTotalsListForEmployeeList, ExportPlannedPerpetualBonusTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedPerpetualBonusTotalsListForEmployeeListResponse> ExportPlannedPerpetualBonusTotalsListForEmployeeListAsync(
      ExportPlannedPerpetualBonusTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualBonusTotalsListForEmployeeList, ExportPlannedPerpetualBonusTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualPerpetualBonusTotalsListForEmployeeListResponse ExportActualPerpetualBonusTotalsListForEmployeeList(
      ExportActualPerpetualBonusTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualBonusTotalsListForEmployeeList, ExportActualPerpetualBonusTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualPerpetualBonusTotalsListForEmployeeListResponse> ExportActualPerpetualBonusTotalsListForEmployeeListAsync(
      ExportActualPerpetualBonusTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualBonusTotalsListForEmployeeList, ExportActualPerpetualBonusTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedPerpetualBonusTotalsListFromDateForEmployeeListResponse ExportPlannedPerpetualBonusTotalsListFromDateForEmployeeList(
      ExportPlannedPerpetualBonusTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualBonusTotalsListFromDateForEmployeeList, ExportPlannedPerpetualBonusTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedPerpetualBonusTotalsListFromDateForEmployeeListResponse> ExportPlannedPerpetualBonusTotalsListFromDateForEmployeeListAsync(
      ExportPlannedPerpetualBonusTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualBonusTotalsListFromDateForEmployeeList, ExportPlannedPerpetualBonusTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedBonusTotalsFromDateToDateForEmployeeListResponse ExportPlannedBonusTotalsFromDateToDateForEmployeeList(
      ExportPlannedBonusTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedBonusTotalsFromDateToDateForEmployeeList, ExportPlannedBonusTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedBonusTotalsFromDateToDateForEmployeeListResponse> ExportPlannedBonusTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedBonusTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedBonusTotalsFromDateToDateForEmployeeList, ExportPlannedBonusTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualBonusTotalsFromDateToDateForEmployeeListResponse ExportActualBonusTotalsFromDateToDateForEmployeeList(
      ExportActualBonusTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualBonusTotalsFromDateToDateForEmployeeList, ExportActualBonusTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualBonusTotalsFromDateToDateForEmployeeListResponse> ExportActualBonusTotalsFromDateToDateForEmployeeListAsync(
      ExportActualBonusTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualBonusTotalsFromDateToDateForEmployeeList, ExportActualBonusTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedDailyBonusTotalsFromDateToDateForEmployeeListResponse ExportEstimatedDailyBonusTotalsFromDateToDateForEmployeeList(
      ExportEstimatedDailyBonusTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyBonusTotalsFromDateToDateForEmployeeList, ExportEstimatedDailyBonusTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedDailyBonusTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedDailyBonusTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedDailyBonusTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyBonusTotalsFromDateToDateForEmployeeList, ExportEstimatedDailyBonusTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualDailyBonusTotalsFromRelativeDatesForEmployeeListResponse ExportActualDailyBonusTotalsFromRelativeDatesForEmployeeList(
      ExportActualDailyBonusTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyBonusTotalsFromRelativeDatesForEmployeeList, ExportActualDailyBonusTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualDailyBonusTotalsFromRelativeDatesForEmployeeListResponse> ExportActualDailyBonusTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualDailyBonusTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyBonusTotalsFromRelativeDatesForEmployeeList, ExportActualDailyBonusTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedWeeklyBonusTotalsForEmployeeListResponse ExportEstimatedWeeklyBonusTotalsForEmployeeList(
      ExportEstimatedWeeklyBonusTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyBonusTotalsForEmployeeList, ExportEstimatedWeeklyBonusTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyBonusTotalsForEmployeeListResponse> ExportEstimatedWeeklyBonusTotalsForEmployeeListAsync(
      ExportEstimatedWeeklyBonusTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyBonusTotalsForEmployeeList, ExportEstimatedWeeklyBonusTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedWeeklyBonusTotalsForEmployeeListResponse ExportPlannedWeeklyBonusTotalsForEmployeeList(
      ExportPlannedWeeklyBonusTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyBonusTotalsForEmployeeList, ExportPlannedWeeklyBonusTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedWeeklyBonusTotalsForEmployeeListResponse> ExportPlannedWeeklyBonusTotalsForEmployeeListAsync(
      ExportPlannedWeeklyBonusTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyBonusTotalsForEmployeeList, ExportPlannedWeeklyBonusTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualWeeklyBonusTotalsListForEmployeeListResponse ExportActualWeeklyBonusTotalsListForEmployeeList(
      ExportActualWeeklyBonusTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyBonusTotalsListForEmployeeList, ExportActualWeeklyBonusTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualWeeklyBonusTotalsListForEmployeeListResponse> ExportActualWeeklyBonusTotalsListForEmployeeListAsync(
      ExportActualWeeklyBonusTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyBonusTotalsListForEmployeeList, ExportActualWeeklyBonusTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualWeeklyBonusTotalsForEmployeeListResponse ExportActualWeeklyBonusTotalsForEmployeeList(
      ExportActualWeeklyBonusTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyBonusTotalsForEmployeeList, ExportActualWeeklyBonusTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualWeeklyBonusTotalsForEmployeeListResponse> ExportActualWeeklyBonusTotalsForEmployeeListAsync(
      ExportActualWeeklyBonusTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyBonusTotalsForEmployeeList, ExportActualWeeklyBonusTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedDailyBonusTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedDailyBonusTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedDailyBonusTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyBonusTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailyBonusTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedDailyBonusTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedDailyBonusTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedDailyBonusTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyBonusTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailyBonusTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedDailyBonusTotalsFromPeriodForEmployeeListResponse ExportEstimatedDailyBonusTotalsFromPeriodForEmployeeList(
      ExportEstimatedDailyBonusTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyBonusTotalsFromPeriodForEmployeeList, ExportEstimatedDailyBonusTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedDailyBonusTotalsFromPeriodForEmployeeListResponse> ExportEstimatedDailyBonusTotalsFromPeriodForEmployeeListAsync(
      ExportEstimatedDailyBonusTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyBonusTotalsFromPeriodForEmployeeList, ExportEstimatedDailyBonusTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedDailyBonusTotalsFromDateToDateForEmployeeListResponse ExportPlannedDailyBonusTotalsFromDateToDateForEmployeeList(
      ExportPlannedDailyBonusTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyBonusTotalsFromDateToDateForEmployeeList, ExportPlannedDailyBonusTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedDailyBonusTotalsFromDateToDateForEmployeeListResponse> ExportPlannedDailyBonusTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedDailyBonusTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyBonusTotalsFromDateToDateForEmployeeList, ExportPlannedDailyBonusTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedDailyBonusTotalsFromPeriodForEmployeeListResponse ExportPlannedDailyBonusTotalsFromPeriodForEmployeeList(
      ExportPlannedDailyBonusTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyBonusTotalsFromPeriodForEmployeeList, ExportPlannedDailyBonusTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedDailyBonusTotalsFromPeriodForEmployeeListResponse> ExportPlannedDailyBonusTotalsFromPeriodForEmployeeListAsync(
      ExportPlannedDailyBonusTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyBonusTotalsFromPeriodForEmployeeList, ExportPlannedDailyBonusTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedPeriodicalBonusTotalsForEmployeeListResponse ExportEstimatedPeriodicalBonusTotalsForEmployeeList(
      ExportEstimatedPeriodicalBonusTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalBonusTotalsForEmployeeList, ExportEstimatedPeriodicalBonusTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalBonusTotalsForEmployeeListResponse> ExportEstimatedPeriodicalBonusTotalsForEmployeeListAsync(
      ExportEstimatedPeriodicalBonusTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalBonusTotalsForEmployeeList, ExportEstimatedPeriodicalBonusTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualWeeklyBonusTotalsListFromDateToDateForEmployeeListResponse ExportActualWeeklyBonusTotalsListFromDateToDateForEmployeeList(
      ExportActualWeeklyBonusTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyBonusTotalsListFromDateToDateForEmployeeList, ExportActualWeeklyBonusTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualWeeklyBonusTotalsListFromDateToDateForEmployeeListResponse> ExportActualWeeklyBonusTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualWeeklyBonusTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyBonusTotalsListFromDateToDateForEmployeeList, ExportActualWeeklyBonusTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualPerpetualBonusTotalsFromRelativeDatesForEmployeeListResponse ExportActualPerpetualBonusTotalsFromRelativeDatesForEmployeeList(
      ExportActualPerpetualBonusTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualBonusTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualBonusTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualPerpetualBonusTotalsFromRelativeDatesForEmployeeListResponse> ExportActualPerpetualBonusTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualPerpetualBonusTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualBonusTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualBonusTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualBonusTotalsFromRelativeDatesForEmployeeListResponse ExportActualBonusTotalsFromRelativeDatesForEmployeeList(
      ExportActualBonusTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualBonusTotalsFromRelativeDatesForEmployeeList, ExportActualBonusTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualBonusTotalsFromRelativeDatesForEmployeeListResponse> ExportActualBonusTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualBonusTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualBonusTotalsFromRelativeDatesForEmployeeList, ExportActualBonusTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedWeeklyBonusTotalsListFromDateToDateForEmployeeListResponse ExportPlannedWeeklyBonusTotalsListFromDateToDateForEmployeeList(
      ExportPlannedWeeklyBonusTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyBonusTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklyBonusTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedWeeklyBonusTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedWeeklyBonusTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedWeeklyBonusTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyBonusTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklyBonusTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedPerpetualBonusTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedPerpetualBonusTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedPerpetualBonusTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualBonusTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualBonusTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedPerpetualBonusTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedPerpetualBonusTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedPerpetualBonusTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualBonusTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualBonusTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedWeeklyBonusTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedWeeklyBonusTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedWeeklyBonusTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyBonusTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklyBonusTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyBonusTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedWeeklyBonusTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedWeeklyBonusTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyBonusTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklyBonusTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedPeriodicalBonusTotalsForEmployeeListResponse ExportPlannedPeriodicalBonusTotalsForEmployeeList(
      ExportPlannedPeriodicalBonusTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalBonusTotalsForEmployeeList, ExportPlannedPeriodicalBonusTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalBonusTotalsForEmployeeListResponse> ExportPlannedPeriodicalBonusTotalsForEmployeeListAsync(
      ExportPlannedPeriodicalBonusTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalBonusTotalsForEmployeeList, ExportPlannedPeriodicalBonusTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedBonusTotalsFromDateToDateForEmployeeListResponse ExportEstimatedBonusTotalsFromDateToDateForEmployeeList(
      ExportEstimatedBonusTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedBonusTotalsFromDateToDateForEmployeeList, ExportEstimatedBonusTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedBonusTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedBonusTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedBonusTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedBonusTotalsFromDateToDateForEmployeeList, ExportEstimatedBonusTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedPeriodicalBonusTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedPeriodicalBonusTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedPeriodicalBonusTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalBonusTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalBonusTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalBonusTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedPeriodicalBonusTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedPeriodicalBonusTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalBonusTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalBonusTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualPeriodicalBonusTotalsListForEmployeeListResponse ExportActualPeriodicalBonusTotalsListForEmployeeList(
      ExportActualPeriodicalBonusTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalBonusTotalsListForEmployeeList, ExportActualPeriodicalBonusTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualPeriodicalBonusTotalsListForEmployeeListResponse> ExportActualPeriodicalBonusTotalsListForEmployeeListAsync(
      ExportActualPeriodicalBonusTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalBonusTotalsListForEmployeeList, ExportActualPeriodicalBonusTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedPerpetualBonusTotalsListForEmployeeListResponse ExportEstimatedPerpetualBonusTotalsListForEmployeeList(
      ExportEstimatedPerpetualBonusTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualBonusTotalsListForEmployeeList, ExportEstimatedPerpetualBonusTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualBonusTotalsListForEmployeeListResponse> ExportEstimatedPerpetualBonusTotalsListForEmployeeListAsync(
      ExportEstimatedPerpetualBonusTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualBonusTotalsListForEmployeeList, ExportEstimatedPerpetualBonusTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedPeriodicalBonusTotalsListForEmployeeListResponse ExportPlannedPeriodicalBonusTotalsListForEmployeeList(
      ExportPlannedPeriodicalBonusTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalBonusTotalsListForEmployeeList, ExportPlannedPeriodicalBonusTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalBonusTotalsListForEmployeeListResponse> ExportPlannedPeriodicalBonusTotalsListForEmployeeListAsync(
      ExportPlannedPeriodicalBonusTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalBonusTotalsListForEmployeeList, ExportPlannedPeriodicalBonusTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedPeriodicalBonusTotalsListFromDateToDateForEmployeeListResponse ExportPlannedPeriodicalBonusTotalsListFromDateToDateForEmployeeList(
      ExportPlannedPeriodicalBonusTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalBonusTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalBonusTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalBonusTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedPeriodicalBonusTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedPeriodicalBonusTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalBonusTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalBonusTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedBonusTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedBonusTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedBonusTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedBonusTotalsFromRelativeDatesForEmployeeList, ExportPlannedBonusTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedBonusTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedBonusTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedBonusTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedBonusTotalsFromRelativeDatesForEmployeeList, ExportPlannedBonusTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedBonusTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedBonusTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedBonusTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedBonusTotalsFromRelativeDatesForEmployeeList, ExportEstimatedBonusTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedBonusTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedBonusTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedBonusTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedBonusTotalsFromRelativeDatesForEmployeeList, ExportEstimatedBonusTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedWeeklyBonusTotalsListForEmployeeListResponse ExportEstimatedWeeklyBonusTotalsListForEmployeeList(
      ExportEstimatedWeeklyBonusTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyBonusTotalsListForEmployeeList, ExportEstimatedWeeklyBonusTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyBonusTotalsListForEmployeeListResponse> ExportEstimatedWeeklyBonusTotalsListForEmployeeListAsync(
      ExportEstimatedWeeklyBonusTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyBonusTotalsListForEmployeeList, ExportEstimatedWeeklyBonusTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedWeeklyBonusTotalsListForEmployeeListResponse ExportPlannedWeeklyBonusTotalsListForEmployeeList(
      ExportPlannedWeeklyBonusTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyBonusTotalsListForEmployeeList, ExportPlannedWeeklyBonusTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedWeeklyBonusTotalsListForEmployeeListResponse> ExportPlannedWeeklyBonusTotalsListForEmployeeListAsync(
      ExportPlannedWeeklyBonusTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyBonusTotalsListForEmployeeList, ExportPlannedWeeklyBonusTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedPerpetualBonusTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedPerpetualBonusTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedPerpetualBonusTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualBonusTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualBonusTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualBonusTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedPerpetualBonusTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedPerpetualBonusTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualBonusTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualBonusTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedPeriodicalBonusTotalsListForEmployeeListResponse ExportEstimatedPeriodicalBonusTotalsListForEmployeeList(
      ExportEstimatedPeriodicalBonusTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalBonusTotalsListForEmployeeList, ExportEstimatedPeriodicalBonusTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalBonusTotalsListForEmployeeListResponse> ExportEstimatedPeriodicalBonusTotalsListForEmployeeListAsync(
      ExportEstimatedPeriodicalBonusTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalBonusTotalsListForEmployeeList, ExportEstimatedPeriodicalBonusTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedDailyBonusTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedDailyBonusTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedDailyBonusTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyBonusTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailyBonusTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedDailyBonusTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedDailyBonusTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedDailyBonusTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyBonusTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailyBonusTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedPeriodicalBonusTotalsResponse ExportPlannedPeriodicalBonusTotals(
      ExportPlannedPeriodicalBonusTotals arg)
    {
      return Client.Post<ExportPlannedPeriodicalBonusTotals, ExportPlannedPeriodicalBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalBonusTotalsResponse> ExportPlannedPeriodicalBonusTotalsAsync(
      ExportPlannedPeriodicalBonusTotals arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalBonusTotals, ExportPlannedPeriodicalBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedPeriodicalBonusTotalsListResponse ExportPlannedPeriodicalBonusTotalsList(
      ExportPlannedPeriodicalBonusTotalsList arg)
    {
      return Client.Post<ExportPlannedPeriodicalBonusTotalsList, ExportPlannedPeriodicalBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalBonusTotalsListResponse> ExportPlannedPeriodicalBonusTotalsListAsync(
      ExportPlannedPeriodicalBonusTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalBonusTotalsList, ExportPlannedPeriodicalBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedPeriodicalBonusTotalsListFromDateToDateResponse ExportPlannedPeriodicalBonusTotalsListFromDateToDate(
      ExportPlannedPeriodicalBonusTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedPeriodicalBonusTotalsListFromDateToDate, ExportPlannedPeriodicalBonusTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedPeriodicalBonusTotalsListFromDateToDateResponse> ExportPlannedPeriodicalBonusTotalsListFromDateToDateAsync(
      ExportPlannedPeriodicalBonusTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalBonusTotalsListFromDateToDate, ExportPlannedPeriodicalBonusTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedPerpetualBonusTotalsFromRelativeDatesResponse ExportPlannedPerpetualBonusTotalsFromRelativeDates(
      ExportPlannedPerpetualBonusTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedPerpetualBonusTotalsFromRelativeDates, ExportPlannedPerpetualBonusTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedPerpetualBonusTotalsFromRelativeDatesResponse> ExportPlannedPerpetualBonusTotalsFromRelativeDatesAsync(
      ExportPlannedPerpetualBonusTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualBonusTotalsFromRelativeDates, ExportPlannedPerpetualBonusTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedPerpetualBonusTotalsListFromDateResponse ExportPlannedPerpetualBonusTotalsListFromDate(
      ExportPlannedPerpetualBonusTotalsListFromDate arg)
    {
      return Client.Post<ExportPlannedPerpetualBonusTotalsListFromDate, ExportPlannedPerpetualBonusTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedPerpetualBonusTotalsListFromDateResponse> ExportPlannedPerpetualBonusTotalsListFromDateAsync(
      ExportPlannedPerpetualBonusTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualBonusTotalsListFromDate, ExportPlannedPerpetualBonusTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedPerpetualBonusTotalsListResponse ExportPlannedPerpetualBonusTotalsList(
      ExportPlannedPerpetualBonusTotalsList arg)
    {
      return Client.Post<ExportPlannedPerpetualBonusTotalsList, ExportPlannedPerpetualBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedPerpetualBonusTotalsListResponse> ExportPlannedPerpetualBonusTotalsListAsync(
      ExportPlannedPerpetualBonusTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualBonusTotalsList, ExportPlannedPerpetualBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualPeriodicalBonusTotalsListResponse ExportActualPeriodicalBonusTotalsList(
      ExportActualPeriodicalBonusTotalsList arg)
    {
      return Client.Post<ExportActualPeriodicalBonusTotalsList, ExportActualPeriodicalBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualPeriodicalBonusTotalsListResponse> ExportActualPeriodicalBonusTotalsListAsync(
      ExportActualPeriodicalBonusTotalsList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalBonusTotalsList, ExportActualPeriodicalBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualPeriodicalBonusTotalsListFromDateToDateResponse ExportActualPeriodicalBonusTotalsListFromDateToDate(
      ExportActualPeriodicalBonusTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualPeriodicalBonusTotalsListFromDateToDate, ExportActualPeriodicalBonusTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualPeriodicalBonusTotalsListFromDateToDateResponse> ExportActualPeriodicalBonusTotalsListFromDateToDateAsync(
      ExportActualPeriodicalBonusTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualPeriodicalBonusTotalsListFromDateToDate, ExportActualPeriodicalBonusTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualPeriodicalBonusTotalsResponse ExportActualPeriodicalBonusTotals(
      ExportActualPeriodicalBonusTotals arg)
    {
      return Client.Post<ExportActualPeriodicalBonusTotals, ExportActualPeriodicalBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualPeriodicalBonusTotalsResponse> ExportActualPeriodicalBonusTotalsAsync(
      ExportActualPeriodicalBonusTotals arg)
    {
      return Client.PostAsync<ExportActualPeriodicalBonusTotals, ExportActualPeriodicalBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedPerpetualBonusTotalsListResponse ExportEstimatedPerpetualBonusTotalsList(
      ExportEstimatedPerpetualBonusTotalsList arg)
    {
      return Client.Post<ExportEstimatedPerpetualBonusTotalsList, ExportEstimatedPerpetualBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualBonusTotalsListResponse> ExportEstimatedPerpetualBonusTotalsListAsync(
      ExportEstimatedPerpetualBonusTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualBonusTotalsList, ExportEstimatedPerpetualBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedPerpetualBonusTotalsListFromDateResponse ExportEstimatedPerpetualBonusTotalsListFromDate(
      ExportEstimatedPerpetualBonusTotalsListFromDate arg)
    {
      return Client.Post<ExportEstimatedPerpetualBonusTotalsListFromDate, ExportEstimatedPerpetualBonusTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualBonusTotalsListFromDateResponse> ExportEstimatedPerpetualBonusTotalsListFromDateAsync(
      ExportEstimatedPerpetualBonusTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualBonusTotalsListFromDate, ExportEstimatedPerpetualBonusTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedPerpetualBonusTotalsFromRelativeDatesResponse ExportEstimatedPerpetualBonusTotalsFromRelativeDates(
      ExportEstimatedPerpetualBonusTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedPerpetualBonusTotalsFromRelativeDates, ExportEstimatedPerpetualBonusTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedPerpetualBonusTotalsFromRelativeDatesResponse> ExportEstimatedPerpetualBonusTotalsFromRelativeDatesAsync(
      ExportEstimatedPerpetualBonusTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualBonusTotalsFromRelativeDates, ExportEstimatedPerpetualBonusTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedBonusTotalsFromDateToDateResponse ExportEstimatedBonusTotalsFromDateToDate(
      ExportEstimatedBonusTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedBonusTotalsFromDateToDate, ExportEstimatedBonusTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedBonusTotalsFromDateToDateResponse> ExportEstimatedBonusTotalsFromDateToDateAsync(
      ExportEstimatedBonusTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedBonusTotalsFromDateToDate, ExportEstimatedBonusTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedBonusTotalsFromRelativeDatesResponse ExportEstimatedBonusTotalsFromRelativeDates(
      ExportEstimatedBonusTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedBonusTotalsFromRelativeDates, ExportEstimatedBonusTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedBonusTotalsFromRelativeDatesResponse> ExportEstimatedBonusTotalsFromRelativeDatesAsync(
      ExportEstimatedBonusTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedBonusTotalsFromRelativeDates, ExportEstimatedBonusTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedBonusTotalsFromDateToDateResponse ExportPlannedBonusTotalsFromDateToDate(
      ExportPlannedBonusTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedBonusTotalsFromDateToDate, ExportPlannedBonusTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedBonusTotalsFromDateToDateResponse> ExportPlannedBonusTotalsFromDateToDateAsync(
      ExportPlannedBonusTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedBonusTotalsFromDateToDate, ExportPlannedBonusTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedBonusTotalsFromRelativeDatesResponse ExportPlannedBonusTotalsFromRelativeDates(
      ExportPlannedBonusTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedBonusTotalsFromRelativeDates, ExportPlannedBonusTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedBonusTotalsFromRelativeDatesResponse> ExportPlannedBonusTotalsFromRelativeDatesAsync(
      ExportPlannedBonusTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedBonusTotalsFromRelativeDates, ExportPlannedBonusTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportDailyBonusTotalsResponse ExportDailyBonusTotals(
      ExportDailyBonusTotals arg)
    {
      return Client.Post<ExportDailyBonusTotals, ExportDailyBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportDailyBonusTotalsResponse> ExportDailyBonusTotalsAsync(
      ExportDailyBonusTotals arg)
    {
      return Client.PostAsync<ExportDailyBonusTotals, ExportDailyBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPeriodicalBonusTotalsResponse ExportPeriodicalBonusTotals(
      ExportPeriodicalBonusTotals arg)
    {
      return Client.Post<ExportPeriodicalBonusTotals, ExportPeriodicalBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPeriodicalBonusTotalsResponse> ExportPeriodicalBonusTotalsAsync(
      ExportPeriodicalBonusTotals arg)
    {
      return Client.PostAsync<ExportPeriodicalBonusTotals, ExportPeriodicalBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPerpetualBonusTotalsResponse ExportPerpetualBonusTotals(
      ExportPerpetualBonusTotals arg)
    {
      return Client.Post<ExportPerpetualBonusTotals, ExportPerpetualBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPerpetualBonusTotalsResponse> ExportPerpetualBonusTotalsAsync(
      ExportPerpetualBonusTotals arg)
    {
      return Client.PostAsync<ExportPerpetualBonusTotals, ExportPerpetualBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedDailyBonusTotalsFromDateToDateResponse ExportEstimatedDailyBonusTotalsFromDateToDate(
      ExportEstimatedDailyBonusTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedDailyBonusTotalsFromDateToDate, ExportEstimatedDailyBonusTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedDailyBonusTotalsFromDateToDateResponse> ExportEstimatedDailyBonusTotalsFromDateToDateAsync(
      ExportEstimatedDailyBonusTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedDailyBonusTotalsFromDateToDate, ExportEstimatedDailyBonusTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedDailyBonusTotalsFromPeriodResponse ExportEstimatedDailyBonusTotalsFromPeriod(
      ExportEstimatedDailyBonusTotalsFromPeriod arg)
    {
      return Client.Post<ExportEstimatedDailyBonusTotalsFromPeriod, ExportEstimatedDailyBonusTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedDailyBonusTotalsFromPeriodResponse> ExportEstimatedDailyBonusTotalsFromPeriodAsync(
      ExportEstimatedDailyBonusTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportEstimatedDailyBonusTotalsFromPeriod, ExportEstimatedDailyBonusTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedDailyBonusTotalsFromRelativeDatesResponse ExportEstimatedDailyBonusTotalsFromRelativeDates(
      ExportEstimatedDailyBonusTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedDailyBonusTotalsFromRelativeDates, ExportEstimatedDailyBonusTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedDailyBonusTotalsFromRelativeDatesResponse> ExportEstimatedDailyBonusTotalsFromRelativeDatesAsync(
      ExportEstimatedDailyBonusTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedDailyBonusTotalsFromRelativeDates, ExportEstimatedDailyBonusTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualWeeklyBonusTotalsListResponse ExportActualWeeklyBonusTotalsList(
      ExportActualWeeklyBonusTotalsList arg)
    {
      return Client.Post<ExportActualWeeklyBonusTotalsList, ExportActualWeeklyBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualWeeklyBonusTotalsListResponse> ExportActualWeeklyBonusTotalsListAsync(
      ExportActualWeeklyBonusTotalsList arg)
    {
      return Client.PostAsync<ExportActualWeeklyBonusTotalsList, ExportActualWeeklyBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualWeeklyBonusTotalsListFromDateToDateResponse ExportActualWeeklyBonusTotalsListFromDateToDate(
      ExportActualWeeklyBonusTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualWeeklyBonusTotalsListFromDateToDate, ExportActualWeeklyBonusTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualWeeklyBonusTotalsListFromDateToDateResponse> ExportActualWeeklyBonusTotalsListFromDateToDateAsync(
      ExportActualWeeklyBonusTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualWeeklyBonusTotalsListFromDateToDate, ExportActualWeeklyBonusTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualWeeklyBonusTotalsResponse ExportActualWeeklyBonusTotals(
      ExportActualWeeklyBonusTotals arg)
    {
      return Client.Post<ExportActualWeeklyBonusTotals, ExportActualWeeklyBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualWeeklyBonusTotalsResponse> ExportActualWeeklyBonusTotalsAsync(
      ExportActualWeeklyBonusTotals arg)
    {
      return Client.PostAsync<ExportActualWeeklyBonusTotals, ExportActualWeeklyBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedDailyBonusTotalsFromPeriodResponse ExportPlannedDailyBonusTotalsFromPeriod(
      ExportPlannedDailyBonusTotalsFromPeriod arg)
    {
      return Client.Post<ExportPlannedDailyBonusTotalsFromPeriod, ExportPlannedDailyBonusTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedDailyBonusTotalsFromPeriodResponse> ExportPlannedDailyBonusTotalsFromPeriodAsync(
      ExportPlannedDailyBonusTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportPlannedDailyBonusTotalsFromPeriod, ExportPlannedDailyBonusTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedDailyBonusTotalsFromRelativeDatesResponse ExportPlannedDailyBonusTotalsFromRelativeDates(
      ExportPlannedDailyBonusTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedDailyBonusTotalsFromRelativeDates, ExportPlannedDailyBonusTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedDailyBonusTotalsFromRelativeDatesResponse> ExportPlannedDailyBonusTotalsFromRelativeDatesAsync(
      ExportPlannedDailyBonusTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedDailyBonusTotalsFromRelativeDates, ExportPlannedDailyBonusTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedDailyBonusTotalsFromDateToDateResponse ExportPlannedDailyBonusTotalsFromDateToDate(
      ExportPlannedDailyBonusTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedDailyBonusTotalsFromDateToDate, ExportPlannedDailyBonusTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedDailyBonusTotalsFromDateToDateResponse> ExportPlannedDailyBonusTotalsFromDateToDateAsync(
      ExportPlannedDailyBonusTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedDailyBonusTotalsFromDateToDate, ExportPlannedDailyBonusTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualDailyBonusTotalsFromPeriodResponse ExportActualDailyBonusTotalsFromPeriod(
      ExportActualDailyBonusTotalsFromPeriod arg)
    {
      return Client.Post<ExportActualDailyBonusTotalsFromPeriod, ExportActualDailyBonusTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualDailyBonusTotalsFromPeriodResponse> ExportActualDailyBonusTotalsFromPeriodAsync(
      ExportActualDailyBonusTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportActualDailyBonusTotalsFromPeriod, ExportActualDailyBonusTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualDailyBonusTotalsFromDateToDateResponse ExportActualDailyBonusTotalsFromDateToDate(
      ExportActualDailyBonusTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualDailyBonusTotalsFromDateToDate, ExportActualDailyBonusTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualDailyBonusTotalsFromDateToDateResponse> ExportActualDailyBonusTotalsFromDateToDateAsync(
      ExportActualDailyBonusTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualDailyBonusTotalsFromDateToDate, ExportActualDailyBonusTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualDailyBonusTotalsFromRelativeDatesResponse ExportActualDailyBonusTotalsFromRelativeDates(
      ExportActualDailyBonusTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualDailyBonusTotalsFromRelativeDates, ExportActualDailyBonusTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualDailyBonusTotalsFromRelativeDatesResponse> ExportActualDailyBonusTotalsFromRelativeDatesAsync(
      ExportActualDailyBonusTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualDailyBonusTotalsFromRelativeDates, ExportActualDailyBonusTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedWeeklyBonusTotalsResponse ExportPlannedWeeklyBonusTotals(
      ExportPlannedWeeklyBonusTotals arg)
    {
      return Client.Post<ExportPlannedWeeklyBonusTotals, ExportPlannedWeeklyBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedWeeklyBonusTotalsResponse> ExportPlannedWeeklyBonusTotalsAsync(
      ExportPlannedWeeklyBonusTotals arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyBonusTotals, ExportPlannedWeeklyBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedWeeklyBonusTotalsListFromDateToDateResponse ExportPlannedWeeklyBonusTotalsListFromDateToDate(
      ExportPlannedWeeklyBonusTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedWeeklyBonusTotalsListFromDateToDate, ExportPlannedWeeklyBonusTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedWeeklyBonusTotalsListFromDateToDateResponse> ExportPlannedWeeklyBonusTotalsListFromDateToDateAsync(
      ExportPlannedWeeklyBonusTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyBonusTotalsListFromDateToDate, ExportPlannedWeeklyBonusTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPlannedWeeklyBonusTotalsListResponse ExportPlannedWeeklyBonusTotalsList(
      ExportPlannedWeeklyBonusTotalsList arg)
    {
      return Client.Post<ExportPlannedWeeklyBonusTotalsList, ExportPlannedWeeklyBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPlannedWeeklyBonusTotalsListResponse> ExportPlannedWeeklyBonusTotalsListAsync(
      ExportPlannedWeeklyBonusTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyBonusTotalsList, ExportPlannedWeeklyBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedPeriodicalBonusTotalsListResponse ExportEstimatedPeriodicalBonusTotalsList(
      ExportEstimatedPeriodicalBonusTotalsList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalBonusTotalsList, ExportEstimatedPeriodicalBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalBonusTotalsListResponse> ExportEstimatedPeriodicalBonusTotalsListAsync(
      ExportEstimatedPeriodicalBonusTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalBonusTotalsList, ExportEstimatedPeriodicalBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedPeriodicalBonusTotalsListFromDateToDateResponse ExportEstimatedPeriodicalBonusTotalsListFromDateToDate(
      ExportEstimatedPeriodicalBonusTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedPeriodicalBonusTotalsListFromDateToDate, ExportEstimatedPeriodicalBonusTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalBonusTotalsListFromDateToDateResponse> ExportEstimatedPeriodicalBonusTotalsListFromDateToDateAsync(
      ExportEstimatedPeriodicalBonusTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalBonusTotalsListFromDateToDate, ExportEstimatedPeriodicalBonusTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedPeriodicalBonusTotalsResponse ExportEstimatedPeriodicalBonusTotals(
      ExportEstimatedPeriodicalBonusTotals arg)
    {
      return Client.Post<ExportEstimatedPeriodicalBonusTotals, ExportEstimatedPeriodicalBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedPeriodicalBonusTotalsResponse> ExportEstimatedPeriodicalBonusTotalsAsync(
      ExportEstimatedPeriodicalBonusTotals arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalBonusTotals, ExportEstimatedPeriodicalBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedWeeklyBonusTotalsListResponse ExportEstimatedWeeklyBonusTotalsList(
      ExportEstimatedWeeklyBonusTotalsList arg)
    {
      return Client.Post<ExportEstimatedWeeklyBonusTotalsList, ExportEstimatedWeeklyBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyBonusTotalsListResponse> ExportEstimatedWeeklyBonusTotalsListAsync(
      ExportEstimatedWeeklyBonusTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyBonusTotalsList, ExportEstimatedWeeklyBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedWeeklyBonusTotalsResponse ExportEstimatedWeeklyBonusTotals(
      ExportEstimatedWeeklyBonusTotals arg)
    {
      return Client.Post<ExportEstimatedWeeklyBonusTotals, ExportEstimatedWeeklyBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyBonusTotalsResponse> ExportEstimatedWeeklyBonusTotalsAsync(
      ExportEstimatedWeeklyBonusTotals arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyBonusTotals, ExportEstimatedWeeklyBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportEstimatedWeeklyBonusTotalsListFromDateToDateResponse ExportEstimatedWeeklyBonusTotalsListFromDateToDate(
      ExportEstimatedWeeklyBonusTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedWeeklyBonusTotalsListFromDateToDate, ExportEstimatedWeeklyBonusTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportEstimatedWeeklyBonusTotalsListFromDateToDateResponse> ExportEstimatedWeeklyBonusTotalsListFromDateToDateAsync(
      ExportEstimatedWeeklyBonusTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyBonusTotalsListFromDateToDate, ExportEstimatedWeeklyBonusTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualBonusTotalsFromDateToDateResponse ExportActualBonusTotalsFromDateToDate(
      ExportActualBonusTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualBonusTotalsFromDateToDate, ExportActualBonusTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualBonusTotalsFromDateToDateResponse> ExportActualBonusTotalsFromDateToDateAsync(
      ExportActualBonusTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualBonusTotalsFromDateToDate, ExportActualBonusTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualBonusTotalsFromRelativeDatesResponse ExportActualBonusTotalsFromRelativeDates(
      ExportActualBonusTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualBonusTotalsFromRelativeDates, ExportActualBonusTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualBonusTotalsFromRelativeDatesResponse> ExportActualBonusTotalsFromRelativeDatesAsync(
      ExportActualBonusTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualBonusTotalsFromRelativeDates, ExportActualBonusTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualPerpetualBonusTotalsListFromDateResponse ExportActualPerpetualBonusTotalsListFromDate(
      ExportActualPerpetualBonusTotalsListFromDate arg)
    {
      return Client.Post<ExportActualPerpetualBonusTotalsListFromDate, ExportActualPerpetualBonusTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualPerpetualBonusTotalsListFromDateResponse> ExportActualPerpetualBonusTotalsListFromDateAsync(
      ExportActualPerpetualBonusTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportActualPerpetualBonusTotalsListFromDate, ExportActualPerpetualBonusTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualPerpetualBonusTotalsListResponse ExportActualPerpetualBonusTotalsList(
      ExportActualPerpetualBonusTotalsList arg)
    {
      return Client.Post<ExportActualPerpetualBonusTotalsList, ExportActualPerpetualBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualPerpetualBonusTotalsListResponse> ExportActualPerpetualBonusTotalsListAsync(
      ExportActualPerpetualBonusTotalsList arg)
    {
      return Client.PostAsync<ExportActualPerpetualBonusTotalsList, ExportActualPerpetualBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportActualPerpetualBonusTotalsFromRelativeDatesResponse ExportActualPerpetualBonusTotalsFromRelativeDates(
      ExportActualPerpetualBonusTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualPerpetualBonusTotalsFromRelativeDates, ExportActualPerpetualBonusTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportActualPerpetualBonusTotalsFromRelativeDatesResponse> ExportActualPerpetualBonusTotalsFromRelativeDatesAsync(
      ExportActualPerpetualBonusTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualPerpetualBonusTotalsFromRelativeDates, ExportActualPerpetualBonusTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportWeeklyBonusTotalsListResponse ExportWeeklyBonusTotalsList(
      ExportWeeklyBonusTotalsList arg)
    {
      return Client.Post<ExportWeeklyBonusTotalsList, ExportWeeklyBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportWeeklyBonusTotalsListResponse> ExportWeeklyBonusTotalsListAsync(
      ExportWeeklyBonusTotalsList arg)
    {
      return Client.PostAsync<ExportWeeklyBonusTotalsList, ExportWeeklyBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportDailyBonusTotalsListResponse ExportDailyBonusTotalsList(
      ExportDailyBonusTotalsList arg)
    {
      return Client.Post<ExportDailyBonusTotalsList, ExportDailyBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportDailyBonusTotalsListResponse> ExportDailyBonusTotalsListAsync(
      ExportDailyBonusTotalsList arg)
    {
      return Client.PostAsync<ExportDailyBonusTotalsList, ExportDailyBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPerpetualBonusTotalsListResponse ExportPerpetualBonusTotalsList(
      ExportPerpetualBonusTotalsList arg)
    {
      return Client.Post<ExportPerpetualBonusTotalsList, ExportPerpetualBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPerpetualBonusTotalsListResponse> ExportPerpetualBonusTotalsListAsync(
      ExportPerpetualBonusTotalsList arg)
    {
      return Client.PostAsync<ExportPerpetualBonusTotalsList, ExportPerpetualBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportWeeklyBonusTotalsResponse ExportWeeklyBonusTotals(
      ExportWeeklyBonusTotals arg)
    {
      return Client.Post<ExportWeeklyBonusTotals, ExportWeeklyBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportWeeklyBonusTotalsResponse> ExportWeeklyBonusTotalsAsync(
      ExportWeeklyBonusTotals arg)
    {
      return Client.PostAsync<ExportWeeklyBonusTotals, ExportWeeklyBonusTotalsResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public ExportPeriodicalBonusTotalsListResponse ExportPeriodicalBonusTotalsList(
      ExportPeriodicalBonusTotalsList arg)
    {
      return Client.Post<ExportPeriodicalBonusTotalsList, ExportPeriodicalBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }

    public Task<ExportPeriodicalBonusTotalsListResponse> ExportPeriodicalBonusTotalsListAsync(
      ExportPeriodicalBonusTotalsList arg)
    {
      return Client.PostAsync<ExportPeriodicalBonusTotalsList, ExportPeriodicalBonusTotalsListResponse>(this.username, this.password, this.baseuri, "BonusTotalService", arg);
    }
  }
}
