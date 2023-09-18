
//.GenericTotalServiceClient




using KelioSDK.Services;
using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class GenericTotalServiceClient
  {
    private const string service = "GenericTotalService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public GenericTotalServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportActualDailyGenericTotalsFromDateToDateForEmployeeListResponse ExportActualDailyGenericTotalsFromDateToDateForEmployeeList(
      ExportActualDailyGenericTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyGenericTotalsFromDateToDateForEmployeeList, ExportActualDailyGenericTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyGenericTotalsFromDateToDateForEmployeeListResponse> ExportActualDailyGenericTotalsFromDateToDateForEmployeeListAsync(
      ExportActualDailyGenericTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyGenericTotalsFromDateToDateForEmployeeList, ExportActualDailyGenericTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyGenericTotalsFromPeriodForEmployeeListResponse ExportActualDailyGenericTotalsFromPeriodForEmployeeList(
      ExportActualDailyGenericTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyGenericTotalsFromPeriodForEmployeeList, ExportActualDailyGenericTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyGenericTotalsFromPeriodForEmployeeListResponse> ExportActualDailyGenericTotalsFromPeriodForEmployeeListAsync(
      ExportActualDailyGenericTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyGenericTotalsFromPeriodForEmployeeList, ExportActualDailyGenericTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalGenericTotalsListFromDateToDateForEmployeeListResponse ExportActualPeriodicalGenericTotalsListFromDateToDateForEmployeeList(
      ExportActualPeriodicalGenericTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalGenericTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalGenericTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalGenericTotalsListFromDateToDateForEmployeeListResponse> ExportActualPeriodicalGenericTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualPeriodicalGenericTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalGenericTotalsListFromDateToDateForEmployeeList, ExportActualPeriodicalGenericTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualGenericTotalsListFromDateForEmployeeListResponse ExportActualPerpetualGenericTotalsListFromDateForEmployeeList(
      ExportActualPerpetualGenericTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualGenericTotalsListFromDateForEmployeeList, ExportActualPerpetualGenericTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualGenericTotalsListFromDateForEmployeeListResponse> ExportActualPerpetualGenericTotalsListFromDateForEmployeeListAsync(
      ExportActualPerpetualGenericTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualGenericTotalsListFromDateForEmployeeList, ExportActualPerpetualGenericTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualGenericTotalsListFromDateForEmployeeListResponse ExportEstimatedPerpetualGenericTotalsListFromDateForEmployeeList(
      ExportEstimatedPerpetualGenericTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualGenericTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualGenericTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualGenericTotalsListFromDateForEmployeeListResponse> ExportEstimatedPerpetualGenericTotalsListFromDateForEmployeeListAsync(
      ExportEstimatedPerpetualGenericTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualGenericTotalsListFromDateForEmployeeList, ExportEstimatedPerpetualGenericTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalGenericTotalsForEmployeeListResponse ExportActualPeriodicalGenericTotalsForEmployeeList(
      ExportActualPeriodicalGenericTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalGenericTotalsForEmployeeList, ExportActualPeriodicalGenericTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalGenericTotalsForEmployeeListResponse> ExportActualPeriodicalGenericTotalsForEmployeeListAsync(
      ExportActualPeriodicalGenericTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalGenericTotalsForEmployeeList, ExportActualPeriodicalGenericTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualGenericTotalsListForEmployeeListResponse ExportPlannedPerpetualGenericTotalsListForEmployeeList(
      ExportPlannedPerpetualGenericTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualGenericTotalsListForEmployeeList, ExportPlannedPerpetualGenericTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualGenericTotalsListForEmployeeListResponse> ExportPlannedPerpetualGenericTotalsListForEmployeeListAsync(
      ExportPlannedPerpetualGenericTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualGenericTotalsListForEmployeeList, ExportPlannedPerpetualGenericTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualGenericTotalsListForEmployeeListResponse ExportActualPerpetualGenericTotalsListForEmployeeList(
      ExportActualPerpetualGenericTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualGenericTotalsListForEmployeeList, ExportActualPerpetualGenericTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualGenericTotalsListForEmployeeListResponse> ExportActualPerpetualGenericTotalsListForEmployeeListAsync(
      ExportActualPerpetualGenericTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualGenericTotalsListForEmployeeList, ExportActualPerpetualGenericTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualGenericTotalsListFromDateForEmployeeListResponse ExportPlannedPerpetualGenericTotalsListFromDateForEmployeeList(
      ExportPlannedPerpetualGenericTotalsListFromDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualGenericTotalsListFromDateForEmployeeList, ExportPlannedPerpetualGenericTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualGenericTotalsListFromDateForEmployeeListResponse> ExportPlannedPerpetualGenericTotalsListFromDateForEmployeeListAsync(
      ExportPlannedPerpetualGenericTotalsListFromDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualGenericTotalsListFromDateForEmployeeList, ExportPlannedPerpetualGenericTotalsListFromDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedGenericTotalsFromDateToDateForEmployeeListResponse ExportPlannedGenericTotalsFromDateToDateForEmployeeList(
      ExportPlannedGenericTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedGenericTotalsFromDateToDateForEmployeeList, ExportPlannedGenericTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedGenericTotalsFromDateToDateForEmployeeListResponse> ExportPlannedGenericTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedGenericTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedGenericTotalsFromDateToDateForEmployeeList, ExportPlannedGenericTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualGenericTotalsFromDateToDateForEmployeeListResponse ExportActualGenericTotalsFromDateToDateForEmployeeList(
      ExportActualGenericTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualGenericTotalsFromDateToDateForEmployeeList, ExportActualGenericTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualGenericTotalsFromDateToDateForEmployeeListResponse> ExportActualGenericTotalsFromDateToDateForEmployeeListAsync(
      ExportActualGenericTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualGenericTotalsFromDateToDateForEmployeeList, ExportActualGenericTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyGenericTotalsFromDateToDateForEmployeeListResponse ExportEstimatedDailyGenericTotalsFromDateToDateForEmployeeList(
      ExportEstimatedDailyGenericTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyGenericTotalsFromDateToDateForEmployeeList, ExportEstimatedDailyGenericTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyGenericTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedDailyGenericTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedDailyGenericTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyGenericTotalsFromDateToDateForEmployeeList, ExportEstimatedDailyGenericTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyGenericTotalsFromRelativeDatesForEmployeeListResponse ExportActualDailyGenericTotalsFromRelativeDatesForEmployeeList(
      ExportActualDailyGenericTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualDailyGenericTotalsFromRelativeDatesForEmployeeList, ExportActualDailyGenericTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyGenericTotalsFromRelativeDatesForEmployeeListResponse> ExportActualDailyGenericTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualDailyGenericTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualDailyGenericTotalsFromRelativeDatesForEmployeeList, ExportActualDailyGenericTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyGenericTotalsForEmployeeListResponse ExportEstimatedWeeklyGenericTotalsForEmployeeList(
      ExportEstimatedWeeklyGenericTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyGenericTotalsForEmployeeList, ExportEstimatedWeeklyGenericTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyGenericTotalsForEmployeeListResponse> ExportEstimatedWeeklyGenericTotalsForEmployeeListAsync(
      ExportEstimatedWeeklyGenericTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyGenericTotalsForEmployeeList, ExportEstimatedWeeklyGenericTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyGenericTotalsForEmployeeListResponse ExportPlannedWeeklyGenericTotalsForEmployeeList(
      ExportPlannedWeeklyGenericTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyGenericTotalsForEmployeeList, ExportPlannedWeeklyGenericTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyGenericTotalsForEmployeeListResponse> ExportPlannedWeeklyGenericTotalsForEmployeeListAsync(
      ExportPlannedWeeklyGenericTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyGenericTotalsForEmployeeList, ExportPlannedWeeklyGenericTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyGenericTotalsListForEmployeeListResponse ExportActualWeeklyGenericTotalsListForEmployeeList(
      ExportActualWeeklyGenericTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyGenericTotalsListForEmployeeList, ExportActualWeeklyGenericTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyGenericTotalsListForEmployeeListResponse> ExportActualWeeklyGenericTotalsListForEmployeeListAsync(
      ExportActualWeeklyGenericTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyGenericTotalsListForEmployeeList, ExportActualWeeklyGenericTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyGenericTotalsForEmployeeListResponse ExportActualWeeklyGenericTotalsForEmployeeList(
      ExportActualWeeklyGenericTotalsForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyGenericTotalsForEmployeeList, ExportActualWeeklyGenericTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyGenericTotalsForEmployeeListResponse> ExportActualWeeklyGenericTotalsForEmployeeListAsync(
      ExportActualWeeklyGenericTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyGenericTotalsForEmployeeList, ExportActualWeeklyGenericTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyGenericTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedDailyGenericTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedDailyGenericTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyGenericTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailyGenericTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyGenericTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedDailyGenericTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedDailyGenericTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyGenericTotalsFromRelativeDatesForEmployeeList, ExportPlannedDailyGenericTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyGenericTotalsFromPeriodForEmployeeListResponse ExportEstimatedDailyGenericTotalsFromPeriodForEmployeeList(
      ExportEstimatedDailyGenericTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyGenericTotalsFromPeriodForEmployeeList, ExportEstimatedDailyGenericTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyGenericTotalsFromPeriodForEmployeeListResponse> ExportEstimatedDailyGenericTotalsFromPeriodForEmployeeListAsync(
      ExportEstimatedDailyGenericTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyGenericTotalsFromPeriodForEmployeeList, ExportEstimatedDailyGenericTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyGenericTotalsFromDateToDateForEmployeeListResponse ExportPlannedDailyGenericTotalsFromDateToDateForEmployeeList(
      ExportPlannedDailyGenericTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyGenericTotalsFromDateToDateForEmployeeList, ExportPlannedDailyGenericTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyGenericTotalsFromDateToDateForEmployeeListResponse> ExportPlannedDailyGenericTotalsFromDateToDateForEmployeeListAsync(
      ExportPlannedDailyGenericTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyGenericTotalsFromDateToDateForEmployeeList, ExportPlannedDailyGenericTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyGenericTotalsFromPeriodForEmployeeListResponse ExportPlannedDailyGenericTotalsFromPeriodForEmployeeList(
      ExportPlannedDailyGenericTotalsFromPeriodForEmployeeList arg)
    {
      return Client.Post<ExportPlannedDailyGenericTotalsFromPeriodForEmployeeList, ExportPlannedDailyGenericTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyGenericTotalsFromPeriodForEmployeeListResponse> ExportPlannedDailyGenericTotalsFromPeriodForEmployeeListAsync(
      ExportPlannedDailyGenericTotalsFromPeriodForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedDailyGenericTotalsFromPeriodForEmployeeList, ExportPlannedDailyGenericTotalsFromPeriodForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalGenericTotalsForEmployeeListResponse ExportEstimatedPeriodicalGenericTotalsForEmployeeList(
      ExportEstimatedPeriodicalGenericTotalsForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalGenericTotalsForEmployeeList, ExportEstimatedPeriodicalGenericTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalGenericTotalsForEmployeeListResponse> ExportEstimatedPeriodicalGenericTotalsForEmployeeListAsync(
      ExportEstimatedPeriodicalGenericTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalGenericTotalsForEmployeeList, ExportEstimatedPeriodicalGenericTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyGenericTotalsListFromDateToDateForEmployeeListResponse ExportActualWeeklyGenericTotalsListFromDateToDateForEmployeeList(
      ExportActualWeeklyGenericTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportActualWeeklyGenericTotalsListFromDateToDateForEmployeeList, ExportActualWeeklyGenericTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyGenericTotalsListFromDateToDateForEmployeeListResponse> ExportActualWeeklyGenericTotalsListFromDateToDateForEmployeeListAsync(
      ExportActualWeeklyGenericTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualWeeklyGenericTotalsListFromDateToDateForEmployeeList, ExportActualWeeklyGenericTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualGenericTotalsFromRelativeDatesForEmployeeListResponse ExportActualPerpetualGenericTotalsFromRelativeDatesForEmployeeList(
      ExportActualPerpetualGenericTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualPerpetualGenericTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualGenericTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualGenericTotalsFromRelativeDatesForEmployeeListResponse> ExportActualPerpetualGenericTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualPerpetualGenericTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPerpetualGenericTotalsFromRelativeDatesForEmployeeList, ExportActualPerpetualGenericTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualGenericTotalsFromRelativeDatesForEmployeeListResponse ExportActualGenericTotalsFromRelativeDatesForEmployeeList(
      ExportActualGenericTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportActualGenericTotalsFromRelativeDatesForEmployeeList, ExportActualGenericTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualGenericTotalsFromRelativeDatesForEmployeeListResponse> ExportActualGenericTotalsFromRelativeDatesForEmployeeListAsync(
      ExportActualGenericTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualGenericTotalsFromRelativeDatesForEmployeeList, ExportActualGenericTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyGenericTotalsListFromDateToDateForEmployeeListResponse ExportPlannedWeeklyGenericTotalsListFromDateToDateForEmployeeList(
      ExportPlannedWeeklyGenericTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyGenericTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklyGenericTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyGenericTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedWeeklyGenericTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedWeeklyGenericTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyGenericTotalsListFromDateToDateForEmployeeList, ExportPlannedWeeklyGenericTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualGenericTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedPerpetualGenericTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedPerpetualGenericTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPerpetualGenericTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualGenericTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualGenericTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedPerpetualGenericTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedPerpetualGenericTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualGenericTotalsFromRelativeDatesForEmployeeList, ExportPlannedPerpetualGenericTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyGenericTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedWeeklyGenericTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedWeeklyGenericTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyGenericTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklyGenericTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyGenericTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedWeeklyGenericTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedWeeklyGenericTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyGenericTotalsListFromDateToDateForEmployeeList, ExportEstimatedWeeklyGenericTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalGenericTotalsForEmployeeListResponse ExportPlannedPeriodicalGenericTotalsForEmployeeList(
      ExportPlannedPeriodicalGenericTotalsForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalGenericTotalsForEmployeeList, ExportPlannedPeriodicalGenericTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalGenericTotalsForEmployeeListResponse> ExportPlannedPeriodicalGenericTotalsForEmployeeListAsync(
      ExportPlannedPeriodicalGenericTotalsForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalGenericTotalsForEmployeeList, ExportPlannedPeriodicalGenericTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedGenericTotalsFromDateToDateForEmployeeListResponse ExportEstimatedGenericTotalsFromDateToDateForEmployeeList(
      ExportEstimatedGenericTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedGenericTotalsFromDateToDateForEmployeeList, ExportEstimatedGenericTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedGenericTotalsFromDateToDateForEmployeeListResponse> ExportEstimatedGenericTotalsFromDateToDateForEmployeeListAsync(
      ExportEstimatedGenericTotalsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedGenericTotalsFromDateToDateForEmployeeList, ExportEstimatedGenericTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalGenericTotalsListFromDateToDateForEmployeeListResponse ExportEstimatedPeriodicalGenericTotalsListFromDateToDateForEmployeeList(
      ExportEstimatedPeriodicalGenericTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalGenericTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalGenericTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalGenericTotalsListFromDateToDateForEmployeeListResponse> ExportEstimatedPeriodicalGenericTotalsListFromDateToDateForEmployeeListAsync(
      ExportEstimatedPeriodicalGenericTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalGenericTotalsListFromDateToDateForEmployeeList, ExportEstimatedPeriodicalGenericTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalGenericTotalsListForEmployeeListResponse ExportActualPeriodicalGenericTotalsListForEmployeeList(
      ExportActualPeriodicalGenericTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportActualPeriodicalGenericTotalsListForEmployeeList, ExportActualPeriodicalGenericTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalGenericTotalsListForEmployeeListResponse> ExportActualPeriodicalGenericTotalsListForEmployeeListAsync(
      ExportActualPeriodicalGenericTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalGenericTotalsListForEmployeeList, ExportActualPeriodicalGenericTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualGenericTotalsListForEmployeeListResponse ExportEstimatedPerpetualGenericTotalsListForEmployeeList(
      ExportEstimatedPerpetualGenericTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualGenericTotalsListForEmployeeList, ExportEstimatedPerpetualGenericTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualGenericTotalsListForEmployeeListResponse> ExportEstimatedPerpetualGenericTotalsListForEmployeeListAsync(
      ExportEstimatedPerpetualGenericTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualGenericTotalsListForEmployeeList, ExportEstimatedPerpetualGenericTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalGenericTotalsListForEmployeeListResponse ExportPlannedPeriodicalGenericTotalsListForEmployeeList(
      ExportPlannedPeriodicalGenericTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalGenericTotalsListForEmployeeList, ExportPlannedPeriodicalGenericTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalGenericTotalsListForEmployeeListResponse> ExportPlannedPeriodicalGenericTotalsListForEmployeeListAsync(
      ExportPlannedPeriodicalGenericTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalGenericTotalsListForEmployeeList, ExportPlannedPeriodicalGenericTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalGenericTotalsListFromDateToDateForEmployeeListResponse ExportPlannedPeriodicalGenericTotalsListFromDateToDateForEmployeeList(
      ExportPlannedPeriodicalGenericTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportPlannedPeriodicalGenericTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalGenericTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalGenericTotalsListFromDateToDateForEmployeeListResponse> ExportPlannedPeriodicalGenericTotalsListFromDateToDateForEmployeeListAsync(
      ExportPlannedPeriodicalGenericTotalsListFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalGenericTotalsListFromDateToDateForEmployeeList, ExportPlannedPeriodicalGenericTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedGenericTotalsFromRelativeDatesForEmployeeListResponse ExportPlannedGenericTotalsFromRelativeDatesForEmployeeList(
      ExportPlannedGenericTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportPlannedGenericTotalsFromRelativeDatesForEmployeeList, ExportPlannedGenericTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedGenericTotalsFromRelativeDatesForEmployeeListResponse> ExportPlannedGenericTotalsFromRelativeDatesForEmployeeListAsync(
      ExportPlannedGenericTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedGenericTotalsFromRelativeDatesForEmployeeList, ExportPlannedGenericTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedGenericTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedGenericTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedGenericTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedGenericTotalsFromRelativeDatesForEmployeeList, ExportEstimatedGenericTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedGenericTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedGenericTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedGenericTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedGenericTotalsFromRelativeDatesForEmployeeList, ExportEstimatedGenericTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyGenericTotalsListForEmployeeListResponse ExportEstimatedWeeklyGenericTotalsListForEmployeeList(
      ExportEstimatedWeeklyGenericTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedWeeklyGenericTotalsListForEmployeeList, ExportEstimatedWeeklyGenericTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyGenericTotalsListForEmployeeListResponse> ExportEstimatedWeeklyGenericTotalsListForEmployeeListAsync(
      ExportEstimatedWeeklyGenericTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyGenericTotalsListForEmployeeList, ExportEstimatedWeeklyGenericTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyGenericTotalsListForEmployeeListResponse ExportPlannedWeeklyGenericTotalsListForEmployeeList(
      ExportPlannedWeeklyGenericTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportPlannedWeeklyGenericTotalsListForEmployeeList, ExportPlannedWeeklyGenericTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyGenericTotalsListForEmployeeListResponse> ExportPlannedWeeklyGenericTotalsListForEmployeeListAsync(
      ExportPlannedWeeklyGenericTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyGenericTotalsListForEmployeeList, ExportPlannedWeeklyGenericTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualGenericTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedPerpetualGenericTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedPerpetualGenericTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPerpetualGenericTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualGenericTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualGenericTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedPerpetualGenericTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedPerpetualGenericTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualGenericTotalsFromRelativeDatesForEmployeeList, ExportEstimatedPerpetualGenericTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalGenericTotalsListForEmployeeListResponse ExportEstimatedPeriodicalGenericTotalsListForEmployeeList(
      ExportEstimatedPeriodicalGenericTotalsListForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalGenericTotalsListForEmployeeList, ExportEstimatedPeriodicalGenericTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalGenericTotalsListForEmployeeListResponse> ExportEstimatedPeriodicalGenericTotalsListForEmployeeListAsync(
      ExportEstimatedPeriodicalGenericTotalsListForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalGenericTotalsListForEmployeeList, ExportEstimatedPeriodicalGenericTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyGenericTotalsFromRelativeDatesForEmployeeListResponse ExportEstimatedDailyGenericTotalsFromRelativeDatesForEmployeeList(
      ExportEstimatedDailyGenericTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportEstimatedDailyGenericTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailyGenericTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyGenericTotalsFromRelativeDatesForEmployeeListResponse> ExportEstimatedDailyGenericTotalsFromRelativeDatesForEmployeeListAsync(
      ExportEstimatedDailyGenericTotalsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportEstimatedDailyGenericTotalsFromRelativeDatesForEmployeeList, ExportEstimatedDailyGenericTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalGenericTotalsResponse ExportPlannedPeriodicalGenericTotals(
      ExportPlannedPeriodicalGenericTotals arg)
    {
      return Client.Post<ExportPlannedPeriodicalGenericTotals, ExportPlannedPeriodicalGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalGenericTotalsResponse> ExportPlannedPeriodicalGenericTotalsAsync(
      ExportPlannedPeriodicalGenericTotals arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalGenericTotals, ExportPlannedPeriodicalGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalGenericTotalsListResponse ExportPlannedPeriodicalGenericTotalsList(
      ExportPlannedPeriodicalGenericTotalsList arg)
    {
      return Client.Post<ExportPlannedPeriodicalGenericTotalsList, ExportPlannedPeriodicalGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalGenericTotalsListResponse> ExportPlannedPeriodicalGenericTotalsListAsync(
      ExportPlannedPeriodicalGenericTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalGenericTotalsList, ExportPlannedPeriodicalGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPeriodicalGenericTotalsListFromDateToDateResponse ExportPlannedPeriodicalGenericTotalsListFromDateToDate(
      ExportPlannedPeriodicalGenericTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedPeriodicalGenericTotalsListFromDateToDate, ExportPlannedPeriodicalGenericTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPeriodicalGenericTotalsListFromDateToDateResponse> ExportPlannedPeriodicalGenericTotalsListFromDateToDateAsync(
      ExportPlannedPeriodicalGenericTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedPeriodicalGenericTotalsListFromDateToDate, ExportPlannedPeriodicalGenericTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualGenericTotalsFromRelativeDatesResponse ExportPlannedPerpetualGenericTotalsFromRelativeDates(
      ExportPlannedPerpetualGenericTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedPerpetualGenericTotalsFromRelativeDates, ExportPlannedPerpetualGenericTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualGenericTotalsFromRelativeDatesResponse> ExportPlannedPerpetualGenericTotalsFromRelativeDatesAsync(
      ExportPlannedPerpetualGenericTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualGenericTotalsFromRelativeDates, ExportPlannedPerpetualGenericTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualGenericTotalsListFromDateResponse ExportPlannedPerpetualGenericTotalsListFromDate(
      ExportPlannedPerpetualGenericTotalsListFromDate arg)
    {
      return Client.Post<ExportPlannedPerpetualGenericTotalsListFromDate, ExportPlannedPerpetualGenericTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualGenericTotalsListFromDateResponse> ExportPlannedPerpetualGenericTotalsListFromDateAsync(
      ExportPlannedPerpetualGenericTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualGenericTotalsListFromDate, ExportPlannedPerpetualGenericTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedPerpetualGenericTotalsListResponse ExportPlannedPerpetualGenericTotalsList(
      ExportPlannedPerpetualGenericTotalsList arg)
    {
      return Client.Post<ExportPlannedPerpetualGenericTotalsList, ExportPlannedPerpetualGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedPerpetualGenericTotalsListResponse> ExportPlannedPerpetualGenericTotalsListAsync(
      ExportPlannedPerpetualGenericTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedPerpetualGenericTotalsList, ExportPlannedPerpetualGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalGenericTotalsListResponse ExportActualPeriodicalGenericTotalsList(
      ExportActualPeriodicalGenericTotalsList arg)
    {
      return Client.Post<ExportActualPeriodicalGenericTotalsList, ExportActualPeriodicalGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalGenericTotalsListResponse> ExportActualPeriodicalGenericTotalsListAsync(
      ExportActualPeriodicalGenericTotalsList arg)
    {
      return Client.PostAsync<ExportActualPeriodicalGenericTotalsList, ExportActualPeriodicalGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalGenericTotalsListFromDateToDateResponse ExportActualPeriodicalGenericTotalsListFromDateToDate(
      ExportActualPeriodicalGenericTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualPeriodicalGenericTotalsListFromDateToDate, ExportActualPeriodicalGenericTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalGenericTotalsListFromDateToDateResponse> ExportActualPeriodicalGenericTotalsListFromDateToDateAsync(
      ExportActualPeriodicalGenericTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualPeriodicalGenericTotalsListFromDateToDate, ExportActualPeriodicalGenericTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPeriodicalGenericTotalsResponse ExportActualPeriodicalGenericTotals(
      ExportActualPeriodicalGenericTotals arg)
    {
      return Client.Post<ExportActualPeriodicalGenericTotals, ExportActualPeriodicalGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPeriodicalGenericTotalsResponse> ExportActualPeriodicalGenericTotalsAsync(
      ExportActualPeriodicalGenericTotals arg)
    {
      return Client.PostAsync<ExportActualPeriodicalGenericTotals, ExportActualPeriodicalGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualGenericTotalsListResponse ExportEstimatedPerpetualGenericTotalsList(
      ExportEstimatedPerpetualGenericTotalsList arg)
    {
      return Client.Post<ExportEstimatedPerpetualGenericTotalsList, ExportEstimatedPerpetualGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualGenericTotalsListResponse> ExportEstimatedPerpetualGenericTotalsListAsync(
      ExportEstimatedPerpetualGenericTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualGenericTotalsList, ExportEstimatedPerpetualGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualGenericTotalsListFromDateResponse ExportEstimatedPerpetualGenericTotalsListFromDate(
      ExportEstimatedPerpetualGenericTotalsListFromDate arg)
    {
      return Client.Post<ExportEstimatedPerpetualGenericTotalsListFromDate, ExportEstimatedPerpetualGenericTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualGenericTotalsListFromDateResponse> ExportEstimatedPerpetualGenericTotalsListFromDateAsync(
      ExportEstimatedPerpetualGenericTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualGenericTotalsListFromDate, ExportEstimatedPerpetualGenericTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPerpetualGenericTotalsFromRelativeDatesResponse ExportEstimatedPerpetualGenericTotalsFromRelativeDates(
      ExportEstimatedPerpetualGenericTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedPerpetualGenericTotalsFromRelativeDates, ExportEstimatedPerpetualGenericTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPerpetualGenericTotalsFromRelativeDatesResponse> ExportEstimatedPerpetualGenericTotalsFromRelativeDatesAsync(
      ExportEstimatedPerpetualGenericTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedPerpetualGenericTotalsFromRelativeDates, ExportEstimatedPerpetualGenericTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedGenericTotalsFromDateToDateResponse ExportEstimatedGenericTotalsFromDateToDate(
      ExportEstimatedGenericTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedGenericTotalsFromDateToDate, ExportEstimatedGenericTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedGenericTotalsFromDateToDateResponse> ExportEstimatedGenericTotalsFromDateToDateAsync(
      ExportEstimatedGenericTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedGenericTotalsFromDateToDate, ExportEstimatedGenericTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedGenericTotalsFromRelativeDatesResponse ExportEstimatedGenericTotalsFromRelativeDates(
      ExportEstimatedGenericTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedGenericTotalsFromRelativeDates, ExportEstimatedGenericTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedGenericTotalsFromRelativeDatesResponse> ExportEstimatedGenericTotalsFromRelativeDatesAsync(
      ExportEstimatedGenericTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedGenericTotalsFromRelativeDates, ExportEstimatedGenericTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedGenericTotalsFromDateToDateResponse ExportPlannedGenericTotalsFromDateToDate(
      ExportPlannedGenericTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedGenericTotalsFromDateToDate, ExportPlannedGenericTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedGenericTotalsFromDateToDateResponse> ExportPlannedGenericTotalsFromDateToDateAsync(
      ExportPlannedGenericTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedGenericTotalsFromDateToDate, ExportPlannedGenericTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedGenericTotalsFromRelativeDatesResponse ExportPlannedGenericTotalsFromRelativeDates(
      ExportPlannedGenericTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedGenericTotalsFromRelativeDates, ExportPlannedGenericTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedGenericTotalsFromRelativeDatesResponse> ExportPlannedGenericTotalsFromRelativeDatesAsync(
      ExportPlannedGenericTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedGenericTotalsFromRelativeDates, ExportPlannedGenericTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportDailyGenericTotalsResponse ExportDailyGenericTotals(
      ExportDailyGenericTotals arg)
    {
      return Client.Post<ExportDailyGenericTotals, ExportDailyGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportDailyGenericTotalsResponse> ExportDailyGenericTotalsAsync(
      ExportDailyGenericTotals arg)
    {
      return Client.PostAsync<ExportDailyGenericTotals, ExportDailyGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPeriodicalGenericTotalsResponse ExportPeriodicalGenericTotals(
      ExportPeriodicalGenericTotals arg)
    {
      return Client.Post<ExportPeriodicalGenericTotals, ExportPeriodicalGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPeriodicalGenericTotalsResponse> ExportPeriodicalGenericTotalsAsync(
      ExportPeriodicalGenericTotals arg)
    {
      return Client.PostAsync<ExportPeriodicalGenericTotals, ExportPeriodicalGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPerpetualGenericTotalsResponse ExportPerpetualGenericTotals(
      ExportPerpetualGenericTotals arg)
    {
      return Client.Post<ExportPerpetualGenericTotals, ExportPerpetualGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPerpetualGenericTotalsResponse> ExportPerpetualGenericTotalsAsync(
      ExportPerpetualGenericTotals arg)
    {
      return Client.PostAsync<ExportPerpetualGenericTotals, ExportPerpetualGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyGenericTotalsFromDateToDateResponse ExportEstimatedDailyGenericTotalsFromDateToDate(
      ExportEstimatedDailyGenericTotalsFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedDailyGenericTotalsFromDateToDate, ExportEstimatedDailyGenericTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyGenericTotalsFromDateToDateResponse> ExportEstimatedDailyGenericTotalsFromDateToDateAsync(
      ExportEstimatedDailyGenericTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedDailyGenericTotalsFromDateToDate, ExportEstimatedDailyGenericTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyGenericTotalsFromPeriodResponse ExportEstimatedDailyGenericTotalsFromPeriod(
      ExportEstimatedDailyGenericTotalsFromPeriod arg)
    {
      return Client.Post<ExportEstimatedDailyGenericTotalsFromPeriod, ExportEstimatedDailyGenericTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyGenericTotalsFromPeriodResponse> ExportEstimatedDailyGenericTotalsFromPeriodAsync(
      ExportEstimatedDailyGenericTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportEstimatedDailyGenericTotalsFromPeriod, ExportEstimatedDailyGenericTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedDailyGenericTotalsFromRelativeDatesResponse ExportEstimatedDailyGenericTotalsFromRelativeDates(
      ExportEstimatedDailyGenericTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportEstimatedDailyGenericTotalsFromRelativeDates, ExportEstimatedDailyGenericTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedDailyGenericTotalsFromRelativeDatesResponse> ExportEstimatedDailyGenericTotalsFromRelativeDatesAsync(
      ExportEstimatedDailyGenericTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportEstimatedDailyGenericTotalsFromRelativeDates, ExportEstimatedDailyGenericTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyGenericTotalsListResponse ExportActualWeeklyGenericTotalsList(
      ExportActualWeeklyGenericTotalsList arg)
    {
      return Client.Post<ExportActualWeeklyGenericTotalsList, ExportActualWeeklyGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyGenericTotalsListResponse> ExportActualWeeklyGenericTotalsListAsync(
      ExportActualWeeklyGenericTotalsList arg)
    {
      return Client.PostAsync<ExportActualWeeklyGenericTotalsList, ExportActualWeeklyGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyGenericTotalsListFromDateToDateResponse ExportActualWeeklyGenericTotalsListFromDateToDate(
      ExportActualWeeklyGenericTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportActualWeeklyGenericTotalsListFromDateToDate, ExportActualWeeklyGenericTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyGenericTotalsListFromDateToDateResponse> ExportActualWeeklyGenericTotalsListFromDateToDateAsync(
      ExportActualWeeklyGenericTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualWeeklyGenericTotalsListFromDateToDate, ExportActualWeeklyGenericTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualWeeklyGenericTotalsResponse ExportActualWeeklyGenericTotals(
      ExportActualWeeklyGenericTotals arg)
    {
      return Client.Post<ExportActualWeeklyGenericTotals, ExportActualWeeklyGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualWeeklyGenericTotalsResponse> ExportActualWeeklyGenericTotalsAsync(
      ExportActualWeeklyGenericTotals arg)
    {
      return Client.PostAsync<ExportActualWeeklyGenericTotals, ExportActualWeeklyGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyGenericTotalsFromPeriodResponse ExportPlannedDailyGenericTotalsFromPeriod(
      ExportPlannedDailyGenericTotalsFromPeriod arg)
    {
      return Client.Post<ExportPlannedDailyGenericTotalsFromPeriod, ExportPlannedDailyGenericTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyGenericTotalsFromPeriodResponse> ExportPlannedDailyGenericTotalsFromPeriodAsync(
      ExportPlannedDailyGenericTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportPlannedDailyGenericTotalsFromPeriod, ExportPlannedDailyGenericTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyGenericTotalsFromRelativeDatesResponse ExportPlannedDailyGenericTotalsFromRelativeDates(
      ExportPlannedDailyGenericTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportPlannedDailyGenericTotalsFromRelativeDates, ExportPlannedDailyGenericTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyGenericTotalsFromRelativeDatesResponse> ExportPlannedDailyGenericTotalsFromRelativeDatesAsync(
      ExportPlannedDailyGenericTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportPlannedDailyGenericTotalsFromRelativeDates, ExportPlannedDailyGenericTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedDailyGenericTotalsFromDateToDateResponse ExportPlannedDailyGenericTotalsFromDateToDate(
      ExportPlannedDailyGenericTotalsFromDateToDate arg)
    {
      return Client.Post<ExportPlannedDailyGenericTotalsFromDateToDate, ExportPlannedDailyGenericTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedDailyGenericTotalsFromDateToDateResponse> ExportPlannedDailyGenericTotalsFromDateToDateAsync(
      ExportPlannedDailyGenericTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedDailyGenericTotalsFromDateToDate, ExportPlannedDailyGenericTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyGenericTotalsFromPeriodResponse ExportActualDailyGenericTotalsFromPeriod(
      ExportActualDailyGenericTotalsFromPeriod arg)
    {
      return Client.Post<ExportActualDailyGenericTotalsFromPeriod, ExportActualDailyGenericTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyGenericTotalsFromPeriodResponse> ExportActualDailyGenericTotalsFromPeriodAsync(
      ExportActualDailyGenericTotalsFromPeriod arg)
    {
      return Client.PostAsync<ExportActualDailyGenericTotalsFromPeriod, ExportActualDailyGenericTotalsFromPeriodResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyGenericTotalsFromDateToDateResponse ExportActualDailyGenericTotalsFromDateToDate(
      ExportActualDailyGenericTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualDailyGenericTotalsFromDateToDate, ExportActualDailyGenericTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyGenericTotalsFromDateToDateResponse> ExportActualDailyGenericTotalsFromDateToDateAsync(
      ExportActualDailyGenericTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualDailyGenericTotalsFromDateToDate, ExportActualDailyGenericTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualDailyGenericTotalsFromRelativeDatesResponse ExportActualDailyGenericTotalsFromRelativeDates(
      ExportActualDailyGenericTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualDailyGenericTotalsFromRelativeDates, ExportActualDailyGenericTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualDailyGenericTotalsFromRelativeDatesResponse> ExportActualDailyGenericTotalsFromRelativeDatesAsync(
      ExportActualDailyGenericTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualDailyGenericTotalsFromRelativeDates, ExportActualDailyGenericTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyGenericTotalsResponse ExportPlannedWeeklyGenericTotals(
      ExportPlannedWeeklyGenericTotals arg)
    {
      return Client.Post<ExportPlannedWeeklyGenericTotals, ExportPlannedWeeklyGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyGenericTotalsResponse> ExportPlannedWeeklyGenericTotalsAsync(
      ExportPlannedWeeklyGenericTotals arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyGenericTotals, ExportPlannedWeeklyGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyGenericTotalsListFromDateToDateResponse ExportPlannedWeeklyGenericTotalsListFromDateToDate(
      ExportPlannedWeeklyGenericTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportPlannedWeeklyGenericTotalsListFromDateToDate, ExportPlannedWeeklyGenericTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyGenericTotalsListFromDateToDateResponse> ExportPlannedWeeklyGenericTotalsListFromDateToDateAsync(
      ExportPlannedWeeklyGenericTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyGenericTotalsListFromDateToDate, ExportPlannedWeeklyGenericTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPlannedWeeklyGenericTotalsListResponse ExportPlannedWeeklyGenericTotalsList(
      ExportPlannedWeeklyGenericTotalsList arg)
    {
      return Client.Post<ExportPlannedWeeklyGenericTotalsList, ExportPlannedWeeklyGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPlannedWeeklyGenericTotalsListResponse> ExportPlannedWeeklyGenericTotalsListAsync(
      ExportPlannedWeeklyGenericTotalsList arg)
    {
      return Client.PostAsync<ExportPlannedWeeklyGenericTotalsList, ExportPlannedWeeklyGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalGenericTotalsListResponse ExportEstimatedPeriodicalGenericTotalsList(
      ExportEstimatedPeriodicalGenericTotalsList arg)
    {
      return Client.Post<ExportEstimatedPeriodicalGenericTotalsList, ExportEstimatedPeriodicalGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalGenericTotalsListResponse> ExportEstimatedPeriodicalGenericTotalsListAsync(
      ExportEstimatedPeriodicalGenericTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalGenericTotalsList, ExportEstimatedPeriodicalGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalGenericTotalsListFromDateToDateResponse ExportEstimatedPeriodicalGenericTotalsListFromDateToDate(
      ExportEstimatedPeriodicalGenericTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedPeriodicalGenericTotalsListFromDateToDate, ExportEstimatedPeriodicalGenericTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalGenericTotalsListFromDateToDateResponse> ExportEstimatedPeriodicalGenericTotalsListFromDateToDateAsync(
      ExportEstimatedPeriodicalGenericTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalGenericTotalsListFromDateToDate, ExportEstimatedPeriodicalGenericTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedPeriodicalGenericTotalsResponse ExportEstimatedPeriodicalGenericTotals(
      ExportEstimatedPeriodicalGenericTotals arg)
    {
      return Client.Post<ExportEstimatedPeriodicalGenericTotals, ExportEstimatedPeriodicalGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedPeriodicalGenericTotalsResponse> ExportEstimatedPeriodicalGenericTotalsAsync(
      ExportEstimatedPeriodicalGenericTotals arg)
    {
      return Client.PostAsync<ExportEstimatedPeriodicalGenericTotals, ExportEstimatedPeriodicalGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyGenericTotalsListResponse ExportEstimatedWeeklyGenericTotalsList(
      ExportEstimatedWeeklyGenericTotalsList arg)
    {
      return Client.Post<ExportEstimatedWeeklyGenericTotalsList, ExportEstimatedWeeklyGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyGenericTotalsListResponse> ExportEstimatedWeeklyGenericTotalsListAsync(
      ExportEstimatedWeeklyGenericTotalsList arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyGenericTotalsList, ExportEstimatedWeeklyGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyGenericTotalsResponse ExportEstimatedWeeklyGenericTotals(
      ExportEstimatedWeeklyGenericTotals arg)
    {
      return Client.Post<ExportEstimatedWeeklyGenericTotals, ExportEstimatedWeeklyGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyGenericTotalsResponse> ExportEstimatedWeeklyGenericTotalsAsync(
      ExportEstimatedWeeklyGenericTotals arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyGenericTotals, ExportEstimatedWeeklyGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportEstimatedWeeklyGenericTotalsListFromDateToDateResponse ExportEstimatedWeeklyGenericTotalsListFromDateToDate(
      ExportEstimatedWeeklyGenericTotalsListFromDateToDate arg)
    {
      return Client.Post<ExportEstimatedWeeklyGenericTotalsListFromDateToDate, ExportEstimatedWeeklyGenericTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportEstimatedWeeklyGenericTotalsListFromDateToDateResponse> ExportEstimatedWeeklyGenericTotalsListFromDateToDateAsync(
      ExportEstimatedWeeklyGenericTotalsListFromDateToDate arg)
    {
      return Client.PostAsync<ExportEstimatedWeeklyGenericTotalsListFromDateToDate, ExportEstimatedWeeklyGenericTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualGenericTotalsFromDateToDateResponse ExportActualGenericTotalsFromDateToDate(
      ExportActualGenericTotalsFromDateToDate arg)
    {
      return Client.Post<ExportActualGenericTotalsFromDateToDate, ExportActualGenericTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualGenericTotalsFromDateToDateResponse> ExportActualGenericTotalsFromDateToDateAsync(
      ExportActualGenericTotalsFromDateToDate arg)
    {
      return Client.PostAsync<ExportActualGenericTotalsFromDateToDate, ExportActualGenericTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualGenericTotalsFromRelativeDatesResponse ExportActualGenericTotalsFromRelativeDates(
      ExportActualGenericTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualGenericTotalsFromRelativeDates, ExportActualGenericTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualGenericTotalsFromRelativeDatesResponse> ExportActualGenericTotalsFromRelativeDatesAsync(
      ExportActualGenericTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualGenericTotalsFromRelativeDates, ExportActualGenericTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualGenericTotalsListFromDateResponse ExportActualPerpetualGenericTotalsListFromDate(
      ExportActualPerpetualGenericTotalsListFromDate arg)
    {
      return Client.Post<ExportActualPerpetualGenericTotalsListFromDate, ExportActualPerpetualGenericTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualGenericTotalsListFromDateResponse> ExportActualPerpetualGenericTotalsListFromDateAsync(
      ExportActualPerpetualGenericTotalsListFromDate arg)
    {
      return Client.PostAsync<ExportActualPerpetualGenericTotalsListFromDate, ExportActualPerpetualGenericTotalsListFromDateResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualGenericTotalsListResponse ExportActualPerpetualGenericTotalsList(
      ExportActualPerpetualGenericTotalsList arg)
    {
      return Client.Post<ExportActualPerpetualGenericTotalsList, ExportActualPerpetualGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualGenericTotalsListResponse> ExportActualPerpetualGenericTotalsListAsync(
      ExportActualPerpetualGenericTotalsList arg)
    {
      return Client.PostAsync<ExportActualPerpetualGenericTotalsList, ExportActualPerpetualGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportActualPerpetualGenericTotalsFromRelativeDatesResponse ExportActualPerpetualGenericTotalsFromRelativeDates(
      ExportActualPerpetualGenericTotalsFromRelativeDates arg)
    {
      return Client.Post<ExportActualPerpetualGenericTotalsFromRelativeDates, ExportActualPerpetualGenericTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportActualPerpetualGenericTotalsFromRelativeDatesResponse> ExportActualPerpetualGenericTotalsFromRelativeDatesAsync(
      ExportActualPerpetualGenericTotalsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportActualPerpetualGenericTotalsFromRelativeDates, ExportActualPerpetualGenericTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportWeeklyGenericTotalsListResponse ExportWeeklyGenericTotalsList(
      ExportWeeklyGenericTotalsList arg)
    {
      return Client.Post<ExportWeeklyGenericTotalsList, ExportWeeklyGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportWeeklyGenericTotalsListResponse> ExportWeeklyGenericTotalsListAsync(
      ExportWeeklyGenericTotalsList arg)
    {
      return Client.PostAsync<ExportWeeklyGenericTotalsList, ExportWeeklyGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportDailyGenericTotalsListResponse ExportDailyGenericTotalsList(
      ExportDailyGenericTotalsList arg)
    {
      return Client.Post<ExportDailyGenericTotalsList, ExportDailyGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportDailyGenericTotalsListResponse> ExportDailyGenericTotalsListAsync(
      ExportDailyGenericTotalsList arg)
    {
      return Client.PostAsync<ExportDailyGenericTotalsList, ExportDailyGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPerpetualGenericTotalsListResponse ExportPerpetualGenericTotalsList(
      ExportPerpetualGenericTotalsList arg)
    {
      return Client.Post<ExportPerpetualGenericTotalsList, ExportPerpetualGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPerpetualGenericTotalsListResponse> ExportPerpetualGenericTotalsListAsync(
      ExportPerpetualGenericTotalsList arg)
    {
      return Client.PostAsync<ExportPerpetualGenericTotalsList, ExportPerpetualGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportWeeklyGenericTotalsResponse ExportWeeklyGenericTotals(
      ExportWeeklyGenericTotals arg)
    {
      return Client.Post<ExportWeeklyGenericTotals, ExportWeeklyGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportWeeklyGenericTotalsResponse> ExportWeeklyGenericTotalsAsync(
      ExportWeeklyGenericTotals arg)
    {
      return Client.PostAsync<ExportWeeklyGenericTotals, ExportWeeklyGenericTotalsResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public ExportPeriodicalGenericTotalsListResponse ExportPeriodicalGenericTotalsList(
      ExportPeriodicalGenericTotalsList arg)
    {
      return Client.Post<ExportPeriodicalGenericTotalsList, ExportPeriodicalGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }

    public Task<ExportPeriodicalGenericTotalsListResponse> ExportPeriodicalGenericTotalsListAsync(
      ExportPeriodicalGenericTotalsList arg)
    {
      return Client.PostAsync<ExportPeriodicalGenericTotalsList, ExportPeriodicalGenericTotalsListResponse>(this.username, this.password, this.baseuri, "GenericTotalService", arg, this.timeoutSeconds);
    }
  }
}
