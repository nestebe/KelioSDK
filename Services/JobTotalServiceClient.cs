//.JobTotalServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class JobTotalServiceClient
    {
        private const string service = "JobTotalService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public JobTotalServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportActualDailyJobTotalsFromDateToDateForEmployeeListResponse
            ExportActualDailyJobTotalsFromDateToDateForEmployeeList(
                ExportActualDailyJobTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportActualDailyJobTotalsFromDateToDateForEmployeeList,
                    ExportActualDailyJobTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualDailyJobTotalsFromDateToDateForEmployeeListResponse>
            ExportActualDailyJobTotalsFromDateToDateForEmployeeListAsync(
                ExportActualDailyJobTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualDailyJobTotalsFromDateToDateForEmployeeList,
                    ExportActualDailyJobTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualDailyJobTotalsFromPeriodForEmployeeListResponse
            ExportActualDailyJobTotalsFromPeriodForEmployeeList(
                ExportActualDailyJobTotalsFromPeriodForEmployeeList arg)
        {
            return Client
                .Post<ExportActualDailyJobTotalsFromPeriodForEmployeeList,
                    ExportActualDailyJobTotalsFromPeriodForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualDailyJobTotalsFromPeriodForEmployeeListResponse>
            ExportActualDailyJobTotalsFromPeriodForEmployeeListAsync(
                ExportActualDailyJobTotalsFromPeriodForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualDailyJobTotalsFromPeriodForEmployeeList,
                    ExportActualDailyJobTotalsFromPeriodForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualPeriodicalJobTotalsListFromDateToDateForEmployeeListResponse
            ExportActualPeriodicalJobTotalsListFromDateToDateForEmployeeList(
                ExportActualPeriodicalJobTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportActualPeriodicalJobTotalsListFromDateToDateForEmployeeList,
                    ExportActualPeriodicalJobTotalsListFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualPeriodicalJobTotalsListFromDateToDateForEmployeeListResponse>
            ExportActualPeriodicalJobTotalsListFromDateToDateForEmployeeListAsync(
                ExportActualPeriodicalJobTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualPeriodicalJobTotalsListFromDateToDateForEmployeeList,
                    ExportActualPeriodicalJobTotalsListFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualPerpetualJobTotalsListFromDateForEmployeeListResponse
            ExportActualPerpetualJobTotalsListFromDateForEmployeeList(
                ExportActualPerpetualJobTotalsListFromDateForEmployeeList arg)
        {
            return Client
                .Post<ExportActualPerpetualJobTotalsListFromDateForEmployeeList,
                    ExportActualPerpetualJobTotalsListFromDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualPerpetualJobTotalsListFromDateForEmployeeListResponse>
            ExportActualPerpetualJobTotalsListFromDateForEmployeeListAsync(
                ExportActualPerpetualJobTotalsListFromDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualPerpetualJobTotalsListFromDateForEmployeeList,
                    ExportActualPerpetualJobTotalsListFromDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedPerpetualJobTotalsListFromDateForEmployeeListResponse
            ExportEstimatedPerpetualJobTotalsListFromDateForEmployeeList(
                ExportEstimatedPerpetualJobTotalsListFromDateForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedPerpetualJobTotalsListFromDateForEmployeeList,
                    ExportEstimatedPerpetualJobTotalsListFromDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedPerpetualJobTotalsListFromDateForEmployeeListResponse>
            ExportEstimatedPerpetualJobTotalsListFromDateForEmployeeListAsync(
                ExportEstimatedPerpetualJobTotalsListFromDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedPerpetualJobTotalsListFromDateForEmployeeList,
                    ExportEstimatedPerpetualJobTotalsListFromDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualPeriodicalJobTotalsForEmployeeListResponse ExportActualPeriodicalJobTotalsForEmployeeList(
            ExportActualPeriodicalJobTotalsForEmployeeList arg)
        {
            return Client
                .Post<ExportActualPeriodicalJobTotalsForEmployeeList,
                    ExportActualPeriodicalJobTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualPeriodicalJobTotalsForEmployeeListResponse>
            ExportActualPeriodicalJobTotalsForEmployeeListAsync(
                ExportActualPeriodicalJobTotalsForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualPeriodicalJobTotalsForEmployeeList,
                    ExportActualPeriodicalJobTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedPerpetualJobTotalsListForEmployeeListResponse
            ExportPlannedPerpetualJobTotalsListForEmployeeList(
                ExportPlannedPerpetualJobTotalsListForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedPerpetualJobTotalsListForEmployeeList,
                    ExportPlannedPerpetualJobTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedPerpetualJobTotalsListForEmployeeListResponse>
            ExportPlannedPerpetualJobTotalsListForEmployeeListAsync(
                ExportPlannedPerpetualJobTotalsListForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedPerpetualJobTotalsListForEmployeeList,
                    ExportPlannedPerpetualJobTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualPerpetualJobTotalsListForEmployeeListResponse
            ExportActualPerpetualJobTotalsListForEmployeeList(
                ExportActualPerpetualJobTotalsListForEmployeeList arg)
        {
            return Client
                .Post<ExportActualPerpetualJobTotalsListForEmployeeList,
                    ExportActualPerpetualJobTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualPerpetualJobTotalsListForEmployeeListResponse>
            ExportActualPerpetualJobTotalsListForEmployeeListAsync(
                ExportActualPerpetualJobTotalsListForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualPerpetualJobTotalsListForEmployeeList,
                    ExportActualPerpetualJobTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedPerpetualJobTotalsListFromDateForEmployeeListResponse
            ExportPlannedPerpetualJobTotalsListFromDateForEmployeeList(
                ExportPlannedPerpetualJobTotalsListFromDateForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedPerpetualJobTotalsListFromDateForEmployeeList,
                    ExportPlannedPerpetualJobTotalsListFromDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedPerpetualJobTotalsListFromDateForEmployeeListResponse>
            ExportPlannedPerpetualJobTotalsListFromDateForEmployeeListAsync(
                ExportPlannedPerpetualJobTotalsListFromDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedPerpetualJobTotalsListFromDateForEmployeeList,
                    ExportPlannedPerpetualJobTotalsListFromDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedJobTotalsFromDateToDateForEmployeeListResponse
            ExportPlannedJobTotalsFromDateToDateForEmployeeList(
                ExportPlannedJobTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedJobTotalsFromDateToDateForEmployeeList,
                    ExportPlannedJobTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedJobTotalsFromDateToDateForEmployeeListResponse>
            ExportPlannedJobTotalsFromDateToDateForEmployeeListAsync(
                ExportPlannedJobTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedJobTotalsFromDateToDateForEmployeeList,
                    ExportPlannedJobTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualJobTotalsFromDateToDateForEmployeeListResponse
            ExportActualJobTotalsFromDateToDateForEmployeeList(
                ExportActualJobTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportActualJobTotalsFromDateToDateForEmployeeList,
                    ExportActualJobTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualJobTotalsFromDateToDateForEmployeeListResponse>
            ExportActualJobTotalsFromDateToDateForEmployeeListAsync(
                ExportActualJobTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualJobTotalsFromDateToDateForEmployeeList,
                    ExportActualJobTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedDailyJobTotalsFromDateToDateForEmployeeListResponse
            ExportEstimatedDailyJobTotalsFromDateToDateForEmployeeList(
                ExportEstimatedDailyJobTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedDailyJobTotalsFromDateToDateForEmployeeList,
                    ExportEstimatedDailyJobTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedDailyJobTotalsFromDateToDateForEmployeeListResponse>
            ExportEstimatedDailyJobTotalsFromDateToDateForEmployeeListAsync(
                ExportEstimatedDailyJobTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedDailyJobTotalsFromDateToDateForEmployeeList,
                    ExportEstimatedDailyJobTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualDailyJobTotalsFromRelativeDatesForEmployeeListResponse
            ExportActualDailyJobTotalsFromRelativeDatesForEmployeeList(
                ExportActualDailyJobTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .Post<ExportActualDailyJobTotalsFromRelativeDatesForEmployeeList,
                    ExportActualDailyJobTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualDailyJobTotalsFromRelativeDatesForEmployeeListResponse>
            ExportActualDailyJobTotalsFromRelativeDatesForEmployeeListAsync(
                ExportActualDailyJobTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualDailyJobTotalsFromRelativeDatesForEmployeeList,
                    ExportActualDailyJobTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedWeeklyJobTotalsForEmployeeListResponse ExportEstimatedWeeklyJobTotalsForEmployeeList(
            ExportEstimatedWeeklyJobTotalsForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedWeeklyJobTotalsForEmployeeList,
                    ExportEstimatedWeeklyJobTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedWeeklyJobTotalsForEmployeeListResponse>
            ExportEstimatedWeeklyJobTotalsForEmployeeListAsync(
                ExportEstimatedWeeklyJobTotalsForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedWeeklyJobTotalsForEmployeeList,
                    ExportEstimatedWeeklyJobTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedWeeklyJobTotalsForEmployeeListResponse ExportPlannedWeeklyJobTotalsForEmployeeList(
            ExportPlannedWeeklyJobTotalsForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedWeeklyJobTotalsForEmployeeList, ExportPlannedWeeklyJobTotalsForEmployeeListResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedWeeklyJobTotalsForEmployeeListResponse>
            ExportPlannedWeeklyJobTotalsForEmployeeListAsync(
                ExportPlannedWeeklyJobTotalsForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedWeeklyJobTotalsForEmployeeList,
                    ExportPlannedWeeklyJobTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualWeeklyJobTotalsListForEmployeeListResponse ExportActualWeeklyJobTotalsListForEmployeeList(
            ExportActualWeeklyJobTotalsListForEmployeeList arg)
        {
            return Client
                .Post<ExportActualWeeklyJobTotalsListForEmployeeList,
                    ExportActualWeeklyJobTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualWeeklyJobTotalsListForEmployeeListResponse>
            ExportActualWeeklyJobTotalsListForEmployeeListAsync(
                ExportActualWeeklyJobTotalsListForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualWeeklyJobTotalsListForEmployeeList,
                    ExportActualWeeklyJobTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualWeeklyJobTotalsForEmployeeListResponse ExportActualWeeklyJobTotalsForEmployeeList(
            ExportActualWeeklyJobTotalsForEmployeeList arg)
        {
            return Client
                .Post<ExportActualWeeklyJobTotalsForEmployeeList, ExportActualWeeklyJobTotalsForEmployeeListResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualWeeklyJobTotalsForEmployeeListResponse> ExportActualWeeklyJobTotalsForEmployeeListAsync(
            ExportActualWeeklyJobTotalsForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualWeeklyJobTotalsForEmployeeList,
                    ExportActualWeeklyJobTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedDailyJobTotalsFromRelativeDatesForEmployeeListResponse
            ExportPlannedDailyJobTotalsFromRelativeDatesForEmployeeList(
                ExportPlannedDailyJobTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedDailyJobTotalsFromRelativeDatesForEmployeeList,
                    ExportPlannedDailyJobTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedDailyJobTotalsFromRelativeDatesForEmployeeListResponse>
            ExportPlannedDailyJobTotalsFromRelativeDatesForEmployeeListAsync(
                ExportPlannedDailyJobTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedDailyJobTotalsFromRelativeDatesForEmployeeList,
                    ExportPlannedDailyJobTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedDailyJobTotalsFromPeriodForEmployeeListResponse
            ExportEstimatedDailyJobTotalsFromPeriodForEmployeeList(
                ExportEstimatedDailyJobTotalsFromPeriodForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedDailyJobTotalsFromPeriodForEmployeeList,
                    ExportEstimatedDailyJobTotalsFromPeriodForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedDailyJobTotalsFromPeriodForEmployeeListResponse>
            ExportEstimatedDailyJobTotalsFromPeriodForEmployeeListAsync(
                ExportEstimatedDailyJobTotalsFromPeriodForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedDailyJobTotalsFromPeriodForEmployeeList,
                    ExportEstimatedDailyJobTotalsFromPeriodForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedDailyJobTotalsFromDateToDateForEmployeeListResponse
            ExportPlannedDailyJobTotalsFromDateToDateForEmployeeList(
                ExportPlannedDailyJobTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedDailyJobTotalsFromDateToDateForEmployeeList,
                    ExportPlannedDailyJobTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedDailyJobTotalsFromDateToDateForEmployeeListResponse>
            ExportPlannedDailyJobTotalsFromDateToDateForEmployeeListAsync(
                ExportPlannedDailyJobTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedDailyJobTotalsFromDateToDateForEmployeeList,
                    ExportPlannedDailyJobTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedDailyJobTotalsFromPeriodForEmployeeListResponse
            ExportPlannedDailyJobTotalsFromPeriodForEmployeeList(
                ExportPlannedDailyJobTotalsFromPeriodForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedDailyJobTotalsFromPeriodForEmployeeList,
                    ExportPlannedDailyJobTotalsFromPeriodForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedDailyJobTotalsFromPeriodForEmployeeListResponse>
            ExportPlannedDailyJobTotalsFromPeriodForEmployeeListAsync(
                ExportPlannedDailyJobTotalsFromPeriodForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedDailyJobTotalsFromPeriodForEmployeeList,
                    ExportPlannedDailyJobTotalsFromPeriodForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedPeriodicalJobTotalsForEmployeeListResponse
            ExportEstimatedPeriodicalJobTotalsForEmployeeList(
                ExportEstimatedPeriodicalJobTotalsForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedPeriodicalJobTotalsForEmployeeList,
                    ExportEstimatedPeriodicalJobTotalsForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedPeriodicalJobTotalsForEmployeeListResponse>
            ExportEstimatedPeriodicalJobTotalsForEmployeeListAsync(
                ExportEstimatedPeriodicalJobTotalsForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedPeriodicalJobTotalsForEmployeeList,
                    ExportEstimatedPeriodicalJobTotalsForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualWeeklyJobTotalsListFromDateToDateForEmployeeListResponse
            ExportActualWeeklyJobTotalsListFromDateToDateForEmployeeList(
                ExportActualWeeklyJobTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportActualWeeklyJobTotalsListFromDateToDateForEmployeeList,
                    ExportActualWeeklyJobTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualWeeklyJobTotalsListFromDateToDateForEmployeeListResponse>
            ExportActualWeeklyJobTotalsListFromDateToDateForEmployeeListAsync(
                ExportActualWeeklyJobTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualWeeklyJobTotalsListFromDateToDateForEmployeeList,
                    ExportActualWeeklyJobTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualPerpetualJobTotalsFromRelativeDatesForEmployeeListResponse
            ExportActualPerpetualJobTotalsFromRelativeDatesForEmployeeList(
                ExportActualPerpetualJobTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .Post<ExportActualPerpetualJobTotalsFromRelativeDatesForEmployeeList,
                    ExportActualPerpetualJobTotalsFromRelativeDatesForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualPerpetualJobTotalsFromRelativeDatesForEmployeeListResponse>
            ExportActualPerpetualJobTotalsFromRelativeDatesForEmployeeListAsync(
                ExportActualPerpetualJobTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualPerpetualJobTotalsFromRelativeDatesForEmployeeList,
                    ExportActualPerpetualJobTotalsFromRelativeDatesForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualJobTotalsFromRelativeDatesForEmployeeListResponse
            ExportActualJobTotalsFromRelativeDatesForEmployeeList(
                ExportActualJobTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .Post<ExportActualJobTotalsFromRelativeDatesForEmployeeList,
                    ExportActualJobTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualJobTotalsFromRelativeDatesForEmployeeListResponse>
            ExportActualJobTotalsFromRelativeDatesForEmployeeListAsync(
                ExportActualJobTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualJobTotalsFromRelativeDatesForEmployeeList,
                    ExportActualJobTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedWeeklyJobTotalsListFromDateToDateForEmployeeListResponse
            ExportPlannedWeeklyJobTotalsListFromDateToDateForEmployeeList(
                ExportPlannedWeeklyJobTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedWeeklyJobTotalsListFromDateToDateForEmployeeList,
                    ExportPlannedWeeklyJobTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedWeeklyJobTotalsListFromDateToDateForEmployeeListResponse>
            ExportPlannedWeeklyJobTotalsListFromDateToDateForEmployeeListAsync(
                ExportPlannedWeeklyJobTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedWeeklyJobTotalsListFromDateToDateForEmployeeList,
                    ExportPlannedWeeklyJobTotalsListFromDateToDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedPerpetualJobTotalsFromRelativeDatesForEmployeeListResponse
            ExportPlannedPerpetualJobTotalsFromRelativeDatesForEmployeeList(
                ExportPlannedPerpetualJobTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedPerpetualJobTotalsFromRelativeDatesForEmployeeList,
                    ExportPlannedPerpetualJobTotalsFromRelativeDatesForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedPerpetualJobTotalsFromRelativeDatesForEmployeeListResponse>
            ExportPlannedPerpetualJobTotalsFromRelativeDatesForEmployeeListAsync(
                ExportPlannedPerpetualJobTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedPerpetualJobTotalsFromRelativeDatesForEmployeeList,
                    ExportPlannedPerpetualJobTotalsFromRelativeDatesForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedWeeklyJobTotalsListFromDateToDateForEmployeeListResponse
            ExportEstimatedWeeklyJobTotalsListFromDateToDateForEmployeeList(
                ExportEstimatedWeeklyJobTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedWeeklyJobTotalsListFromDateToDateForEmployeeList,
                    ExportEstimatedWeeklyJobTotalsListFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedWeeklyJobTotalsListFromDateToDateForEmployeeListResponse>
            ExportEstimatedWeeklyJobTotalsListFromDateToDateForEmployeeListAsync(
                ExportEstimatedWeeklyJobTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedWeeklyJobTotalsListFromDateToDateForEmployeeList,
                    ExportEstimatedWeeklyJobTotalsListFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedPeriodicalJobTotalsForEmployeeListResponse ExportPlannedPeriodicalJobTotalsForEmployeeList(
            ExportPlannedPeriodicalJobTotalsForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedPeriodicalJobTotalsForEmployeeList,
                    ExportPlannedPeriodicalJobTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedPeriodicalJobTotalsForEmployeeListResponse>
            ExportPlannedPeriodicalJobTotalsForEmployeeListAsync(
                ExportPlannedPeriodicalJobTotalsForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedPeriodicalJobTotalsForEmployeeList,
                    ExportPlannedPeriodicalJobTotalsForEmployeeListResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedJobTotalsFromDateToDateForEmployeeListResponse
            ExportEstimatedJobTotalsFromDateToDateForEmployeeList(
                ExportEstimatedJobTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedJobTotalsFromDateToDateForEmployeeList,
                    ExportEstimatedJobTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedJobTotalsFromDateToDateForEmployeeListResponse>
            ExportEstimatedJobTotalsFromDateToDateForEmployeeListAsync(
                ExportEstimatedJobTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedJobTotalsFromDateToDateForEmployeeList,
                    ExportEstimatedJobTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedPeriodicalJobTotalsListFromDateToDateForEmployeeListResponse
            ExportEstimatedPeriodicalJobTotalsListFromDateToDateForEmployeeList(
                ExportEstimatedPeriodicalJobTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedPeriodicalJobTotalsListFromDateToDateForEmployeeList,
                    ExportEstimatedPeriodicalJobTotalsListFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedPeriodicalJobTotalsListFromDateToDateForEmployeeListResponse>
            ExportEstimatedPeriodicalJobTotalsListFromDateToDateForEmployeeListAsync(
                ExportEstimatedPeriodicalJobTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedPeriodicalJobTotalsListFromDateToDateForEmployeeList,
                    ExportEstimatedPeriodicalJobTotalsListFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualPeriodicalJobTotalsListForEmployeeListResponse
            ExportActualPeriodicalJobTotalsListForEmployeeList(
                ExportActualPeriodicalJobTotalsListForEmployeeList arg)
        {
            return Client
                .Post<ExportActualPeriodicalJobTotalsListForEmployeeList,
                    ExportActualPeriodicalJobTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualPeriodicalJobTotalsListForEmployeeListResponse>
            ExportActualPeriodicalJobTotalsListForEmployeeListAsync(
                ExportActualPeriodicalJobTotalsListForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualPeriodicalJobTotalsListForEmployeeList,
                    ExportActualPeriodicalJobTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedPerpetualJobTotalsListForEmployeeListResponse
            ExportEstimatedPerpetualJobTotalsListForEmployeeList(
                ExportEstimatedPerpetualJobTotalsListForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedPerpetualJobTotalsListForEmployeeList,
                    ExportEstimatedPerpetualJobTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedPerpetualJobTotalsListForEmployeeListResponse>
            ExportEstimatedPerpetualJobTotalsListForEmployeeListAsync(
                ExportEstimatedPerpetualJobTotalsListForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedPerpetualJobTotalsListForEmployeeList,
                    ExportEstimatedPerpetualJobTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedPeriodicalJobTotalsListForEmployeeListResponse
            ExportPlannedPeriodicalJobTotalsListForEmployeeList(
                ExportPlannedPeriodicalJobTotalsListForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedPeriodicalJobTotalsListForEmployeeList,
                    ExportPlannedPeriodicalJobTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedPeriodicalJobTotalsListForEmployeeListResponse>
            ExportPlannedPeriodicalJobTotalsListForEmployeeListAsync(
                ExportPlannedPeriodicalJobTotalsListForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedPeriodicalJobTotalsListForEmployeeList,
                    ExportPlannedPeriodicalJobTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedPeriodicalJobTotalsListFromDateToDateForEmployeeListResponse
            ExportPlannedPeriodicalJobTotalsListFromDateToDateForEmployeeList(
                ExportPlannedPeriodicalJobTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedPeriodicalJobTotalsListFromDateToDateForEmployeeList,
                    ExportPlannedPeriodicalJobTotalsListFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedPeriodicalJobTotalsListFromDateToDateForEmployeeListResponse>
            ExportPlannedPeriodicalJobTotalsListFromDateToDateForEmployeeListAsync(
                ExportPlannedPeriodicalJobTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedPeriodicalJobTotalsListFromDateToDateForEmployeeList,
                    ExportPlannedPeriodicalJobTotalsListFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedJobTotalsFromRelativeDatesForEmployeeListResponse
            ExportPlannedJobTotalsFromRelativeDatesForEmployeeList(
                ExportPlannedJobTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedJobTotalsFromRelativeDatesForEmployeeList,
                    ExportPlannedJobTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedJobTotalsFromRelativeDatesForEmployeeListResponse>
            ExportPlannedJobTotalsFromRelativeDatesForEmployeeListAsync(
                ExportPlannedJobTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedJobTotalsFromRelativeDatesForEmployeeList,
                    ExportPlannedJobTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedJobTotalsFromRelativeDatesForEmployeeListResponse
            ExportEstimatedJobTotalsFromRelativeDatesForEmployeeList(
                ExportEstimatedJobTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedJobTotalsFromRelativeDatesForEmployeeList,
                    ExportEstimatedJobTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedJobTotalsFromRelativeDatesForEmployeeListResponse>
            ExportEstimatedJobTotalsFromRelativeDatesForEmployeeListAsync(
                ExportEstimatedJobTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedJobTotalsFromRelativeDatesForEmployeeList,
                    ExportEstimatedJobTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedWeeklyJobTotalsListForEmployeeListResponse
            ExportEstimatedWeeklyJobTotalsListForEmployeeList(
                ExportEstimatedWeeklyJobTotalsListForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedWeeklyJobTotalsListForEmployeeList,
                    ExportEstimatedWeeklyJobTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedWeeklyJobTotalsListForEmployeeListResponse>
            ExportEstimatedWeeklyJobTotalsListForEmployeeListAsync(
                ExportEstimatedWeeklyJobTotalsListForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedWeeklyJobTotalsListForEmployeeList,
                    ExportEstimatedWeeklyJobTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedWeeklyJobTotalsListForEmployeeListResponse ExportPlannedWeeklyJobTotalsListForEmployeeList(
            ExportPlannedWeeklyJobTotalsListForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedWeeklyJobTotalsListForEmployeeList,
                    ExportPlannedWeeklyJobTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedWeeklyJobTotalsListForEmployeeListResponse>
            ExportPlannedWeeklyJobTotalsListForEmployeeListAsync(
                ExportPlannedWeeklyJobTotalsListForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedWeeklyJobTotalsListForEmployeeList,
                    ExportPlannedWeeklyJobTotalsListForEmployeeListResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedPerpetualJobTotalsFromRelativeDatesForEmployeeListResponse
            ExportEstimatedPerpetualJobTotalsFromRelativeDatesForEmployeeList(
                ExportEstimatedPerpetualJobTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedPerpetualJobTotalsFromRelativeDatesForEmployeeList,
                    ExportEstimatedPerpetualJobTotalsFromRelativeDatesForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedPerpetualJobTotalsFromRelativeDatesForEmployeeListResponse>
            ExportEstimatedPerpetualJobTotalsFromRelativeDatesForEmployeeListAsync(
                ExportEstimatedPerpetualJobTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedPerpetualJobTotalsFromRelativeDatesForEmployeeList,
                    ExportEstimatedPerpetualJobTotalsFromRelativeDatesForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedPeriodicalJobTotalsListForEmployeeListResponse
            ExportEstimatedPeriodicalJobTotalsListForEmployeeList(
                ExportEstimatedPeriodicalJobTotalsListForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedPeriodicalJobTotalsListForEmployeeList,
                    ExportEstimatedPeriodicalJobTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedPeriodicalJobTotalsListForEmployeeListResponse>
            ExportEstimatedPeriodicalJobTotalsListForEmployeeListAsync(
                ExportEstimatedPeriodicalJobTotalsListForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedPeriodicalJobTotalsListForEmployeeList,
                    ExportEstimatedPeriodicalJobTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedDailyJobTotalsFromRelativeDatesForEmployeeListResponse
            ExportEstimatedDailyJobTotalsFromRelativeDatesForEmployeeList(
                ExportEstimatedDailyJobTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedDailyJobTotalsFromRelativeDatesForEmployeeList,
                    ExportEstimatedDailyJobTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedDailyJobTotalsFromRelativeDatesForEmployeeListResponse>
            ExportEstimatedDailyJobTotalsFromRelativeDatesForEmployeeListAsync(
                ExportEstimatedDailyJobTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedDailyJobTotalsFromRelativeDatesForEmployeeList,
                    ExportEstimatedDailyJobTotalsFromRelativeDatesForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedPeriodicalJobTotalsListFromDateToDateResponse
            ExportPlannedPeriodicalJobTotalsListFromDateToDate(
                ExportPlannedPeriodicalJobTotalsListFromDateToDate arg)
        {
            return Client
                .Post<ExportPlannedPeriodicalJobTotalsListFromDateToDate,
                    ExportPlannedPeriodicalJobTotalsListFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedPeriodicalJobTotalsListFromDateToDateResponse>
            ExportPlannedPeriodicalJobTotalsListFromDateToDateAsync(
                ExportPlannedPeriodicalJobTotalsListFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportPlannedPeriodicalJobTotalsListFromDateToDate,
                    ExportPlannedPeriodicalJobTotalsListFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedPeriodicalJobTotalsResponse ExportPlannedPeriodicalJobTotals(
            ExportPlannedPeriodicalJobTotals arg)
        {
            return Client.Post<ExportPlannedPeriodicalJobTotals, ExportPlannedPeriodicalJobTotalsResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedPeriodicalJobTotalsResponse> ExportPlannedPeriodicalJobTotalsAsync(
            ExportPlannedPeriodicalJobTotals arg)
        {
            return Client.PostAsync<ExportPlannedPeriodicalJobTotals, ExportPlannedPeriodicalJobTotalsResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedPeriodicalJobTotalsListResponse ExportPlannedPeriodicalJobTotalsList(
            ExportPlannedPeriodicalJobTotalsList arg)
        {
            return Client.Post<ExportPlannedPeriodicalJobTotalsList, ExportPlannedPeriodicalJobTotalsListResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedPeriodicalJobTotalsListResponse> ExportPlannedPeriodicalJobTotalsListAsync(
            ExportPlannedPeriodicalJobTotalsList arg)
        {
            return Client.PostAsync<ExportPlannedPeriodicalJobTotalsList, ExportPlannedPeriodicalJobTotalsListResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedPerpetualJobTotalsListResponse ExportPlannedPerpetualJobTotalsList(
            ExportPlannedPerpetualJobTotalsList arg)
        {
            return Client.Post<ExportPlannedPerpetualJobTotalsList, ExportPlannedPerpetualJobTotalsListResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedPerpetualJobTotalsListResponse> ExportPlannedPerpetualJobTotalsListAsync(
            ExportPlannedPerpetualJobTotalsList arg)
        {
            return Client.PostAsync<ExportPlannedPerpetualJobTotalsList, ExportPlannedPerpetualJobTotalsListResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedPerpetualJobTotalsFromRelativeDatesResponse
            ExportPlannedPerpetualJobTotalsFromRelativeDates(
                ExportPlannedPerpetualJobTotalsFromRelativeDates arg)
        {
            return Client
                .Post<ExportPlannedPerpetualJobTotalsFromRelativeDates,
                    ExportPlannedPerpetualJobTotalsFromRelativeDatesResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedPerpetualJobTotalsFromRelativeDatesResponse>
            ExportPlannedPerpetualJobTotalsFromRelativeDatesAsync(
                ExportPlannedPerpetualJobTotalsFromRelativeDates arg)
        {
            return Client
                .PostAsync<ExportPlannedPerpetualJobTotalsFromRelativeDates,
                    ExportPlannedPerpetualJobTotalsFromRelativeDatesResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedPerpetualJobTotalsListFromDateResponse ExportPlannedPerpetualJobTotalsListFromDate(
            ExportPlannedPerpetualJobTotalsListFromDate arg)
        {
            return Client
                .Post<ExportPlannedPerpetualJobTotalsListFromDate, ExportPlannedPerpetualJobTotalsListFromDateResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedPerpetualJobTotalsListFromDateResponse>
            ExportPlannedPerpetualJobTotalsListFromDateAsync(
                ExportPlannedPerpetualJobTotalsListFromDate arg)
        {
            return Client
                .PostAsync<ExportPlannedPerpetualJobTotalsListFromDate,
                    ExportPlannedPerpetualJobTotalsListFromDateResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualPeriodicalJobTotalsListResponse ExportActualPeriodicalJobTotalsList(
            ExportActualPeriodicalJobTotalsList arg)
        {
            return Client.Post<ExportActualPeriodicalJobTotalsList, ExportActualPeriodicalJobTotalsListResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualPeriodicalJobTotalsListResponse> ExportActualPeriodicalJobTotalsListAsync(
            ExportActualPeriodicalJobTotalsList arg)
        {
            return Client.PostAsync<ExportActualPeriodicalJobTotalsList, ExportActualPeriodicalJobTotalsListResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualPeriodicalJobTotalsListFromDateToDateResponse
            ExportActualPeriodicalJobTotalsListFromDateToDate(
                ExportActualPeriodicalJobTotalsListFromDateToDate arg)
        {
            return Client
                .Post<ExportActualPeriodicalJobTotalsListFromDateToDate,
                    ExportActualPeriodicalJobTotalsListFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualPeriodicalJobTotalsListFromDateToDateResponse>
            ExportActualPeriodicalJobTotalsListFromDateToDateAsync(
                ExportActualPeriodicalJobTotalsListFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportActualPeriodicalJobTotalsListFromDateToDate,
                    ExportActualPeriodicalJobTotalsListFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualPeriodicalJobTotalsResponse ExportActualPeriodicalJobTotals(
            ExportActualPeriodicalJobTotals arg)
        {
            return Client.Post<ExportActualPeriodicalJobTotals, ExportActualPeriodicalJobTotalsResponse>(this.username,
                this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualPeriodicalJobTotalsResponse> ExportActualPeriodicalJobTotalsAsync(
            ExportActualPeriodicalJobTotals arg)
        {
            return Client.PostAsync<ExportActualPeriodicalJobTotals, ExportActualPeriodicalJobTotalsResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedPerpetualJobTotalsFromRelativeDatesResponse
            ExportEstimatedPerpetualJobTotalsFromRelativeDates(
                ExportEstimatedPerpetualJobTotalsFromRelativeDates arg)
        {
            return Client
                .Post<ExportEstimatedPerpetualJobTotalsFromRelativeDates,
                    ExportEstimatedPerpetualJobTotalsFromRelativeDatesResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedPerpetualJobTotalsFromRelativeDatesResponse>
            ExportEstimatedPerpetualJobTotalsFromRelativeDatesAsync(
                ExportEstimatedPerpetualJobTotalsFromRelativeDates arg)
        {
            return Client
                .PostAsync<ExportEstimatedPerpetualJobTotalsFromRelativeDates,
                    ExportEstimatedPerpetualJobTotalsFromRelativeDatesResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedPerpetualJobTotalsListResponse ExportEstimatedPerpetualJobTotalsList(
            ExportEstimatedPerpetualJobTotalsList arg)
        {
            return Client.Post<ExportEstimatedPerpetualJobTotalsList, ExportEstimatedPerpetualJobTotalsListResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedPerpetualJobTotalsListResponse> ExportEstimatedPerpetualJobTotalsListAsync(
            ExportEstimatedPerpetualJobTotalsList arg)
        {
            return Client
                .PostAsync<ExportEstimatedPerpetualJobTotalsList, ExportEstimatedPerpetualJobTotalsListResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedPerpetualJobTotalsListFromDateResponse ExportEstimatedPerpetualJobTotalsListFromDate(
            ExportEstimatedPerpetualJobTotalsListFromDate arg)
        {
            return Client
                .Post<ExportEstimatedPerpetualJobTotalsListFromDate,
                    ExportEstimatedPerpetualJobTotalsListFromDateResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedPerpetualJobTotalsListFromDateResponse>
            ExportEstimatedPerpetualJobTotalsListFromDateAsync(
                ExportEstimatedPerpetualJobTotalsListFromDate arg)
        {
            return Client
                .PostAsync<ExportEstimatedPerpetualJobTotalsListFromDate,
                    ExportEstimatedPerpetualJobTotalsListFromDateResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedJobTotalsFromRelativeDatesResponse ExportEstimatedJobTotalsFromRelativeDates(
            ExportEstimatedJobTotalsFromRelativeDates arg)
        {
            return Client
                .Post<ExportEstimatedJobTotalsFromRelativeDates, ExportEstimatedJobTotalsFromRelativeDatesResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedJobTotalsFromRelativeDatesResponse> ExportEstimatedJobTotalsFromRelativeDatesAsync(
            ExportEstimatedJobTotalsFromRelativeDates arg)
        {
            return Client
                .PostAsync<ExportEstimatedJobTotalsFromRelativeDates,
                    ExportEstimatedJobTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedJobTotalsFromDateToDateResponse ExportEstimatedJobTotalsFromDateToDate(
            ExportEstimatedJobTotalsFromDateToDate arg)
        {
            return Client.Post<ExportEstimatedJobTotalsFromDateToDate, ExportEstimatedJobTotalsFromDateToDateResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedJobTotalsFromDateToDateResponse> ExportEstimatedJobTotalsFromDateToDateAsync(
            ExportEstimatedJobTotalsFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportEstimatedJobTotalsFromDateToDate, ExportEstimatedJobTotalsFromDateToDateResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedJobTotalsFromRelativeDatesResponse ExportPlannedJobTotalsFromRelativeDates(
            ExportPlannedJobTotalsFromRelativeDates arg)
        {
            return Client
                .Post<ExportPlannedJobTotalsFromRelativeDates, ExportPlannedJobTotalsFromRelativeDatesResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedJobTotalsFromRelativeDatesResponse> ExportPlannedJobTotalsFromRelativeDatesAsync(
            ExportPlannedJobTotalsFromRelativeDates arg)
        {
            return Client
                .PostAsync<ExportPlannedJobTotalsFromRelativeDates, ExportPlannedJobTotalsFromRelativeDatesResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedJobTotalsFromDateToDateResponse ExportPlannedJobTotalsFromDateToDate(
            ExportPlannedJobTotalsFromDateToDate arg)
        {
            return Client.Post<ExportPlannedJobTotalsFromDateToDate, ExportPlannedJobTotalsFromDateToDateResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedJobTotalsFromDateToDateResponse> ExportPlannedJobTotalsFromDateToDateAsync(
            ExportPlannedJobTotalsFromDateToDate arg)
        {
            return Client.PostAsync<ExportPlannedJobTotalsFromDateToDate, ExportPlannedJobTotalsFromDateToDateResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportDailyJobTotalsResponse ExportDailyJobTotals(
            ExportDailyJobTotals arg)
        {
            return Client.Post<ExportDailyJobTotals, ExportDailyJobTotalsResponse>(this.username, this.password,
                this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportDailyJobTotalsResponse> ExportDailyJobTotalsAsync(
            ExportDailyJobTotals arg)
        {
            return Client.PostAsync<ExportDailyJobTotals, ExportDailyJobTotalsResponse>(this.username, this.password,
                this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPeriodicalJobTotalsResponse ExportPeriodicalJobTotals(
            ExportPeriodicalJobTotals arg)
        {
            return Client.Post<ExportPeriodicalJobTotals, ExportPeriodicalJobTotalsResponse>(this.username,
                this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPeriodicalJobTotalsResponse> ExportPeriodicalJobTotalsAsync(
            ExportPeriodicalJobTotals arg)
        {
            return Client.PostAsync<ExportPeriodicalJobTotals, ExportPeriodicalJobTotalsResponse>(this.username,
                this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedDailyJobTotalsFromDateToDateResponse ExportEstimatedDailyJobTotalsFromDateToDate(
            ExportEstimatedDailyJobTotalsFromDateToDate arg)
        {
            return Client
                .Post<ExportEstimatedDailyJobTotalsFromDateToDate, ExportEstimatedDailyJobTotalsFromDateToDateResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedDailyJobTotalsFromDateToDateResponse>
            ExportEstimatedDailyJobTotalsFromDateToDateAsync(
                ExportEstimatedDailyJobTotalsFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportEstimatedDailyJobTotalsFromDateToDate,
                    ExportEstimatedDailyJobTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedDailyJobTotalsFromPeriodResponse ExportEstimatedDailyJobTotalsFromPeriod(
            ExportEstimatedDailyJobTotalsFromPeriod arg)
        {
            return Client
                .Post<ExportEstimatedDailyJobTotalsFromPeriod, ExportEstimatedDailyJobTotalsFromPeriodResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedDailyJobTotalsFromPeriodResponse> ExportEstimatedDailyJobTotalsFromPeriodAsync(
            ExportEstimatedDailyJobTotalsFromPeriod arg)
        {
            return Client
                .PostAsync<ExportEstimatedDailyJobTotalsFromPeriod, ExportEstimatedDailyJobTotalsFromPeriodResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedDailyJobTotalsFromRelativeDatesResponse ExportEstimatedDailyJobTotalsFromRelativeDates(
            ExportEstimatedDailyJobTotalsFromRelativeDates arg)
        {
            return Client
                .Post<ExportEstimatedDailyJobTotalsFromRelativeDates,
                    ExportEstimatedDailyJobTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedDailyJobTotalsFromRelativeDatesResponse>
            ExportEstimatedDailyJobTotalsFromRelativeDatesAsync(
                ExportEstimatedDailyJobTotalsFromRelativeDates arg)
        {
            return Client
                .PostAsync<ExportEstimatedDailyJobTotalsFromRelativeDates,
                    ExportEstimatedDailyJobTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualWeeklyJobTotalsListFromDateToDateResponse ExportActualWeeklyJobTotalsListFromDateToDate(
            ExportActualWeeklyJobTotalsListFromDateToDate arg)
        {
            return Client
                .Post<ExportActualWeeklyJobTotalsListFromDateToDate,
                    ExportActualWeeklyJobTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualWeeklyJobTotalsListFromDateToDateResponse>
            ExportActualWeeklyJobTotalsListFromDateToDateAsync(
                ExportActualWeeklyJobTotalsListFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportActualWeeklyJobTotalsListFromDateToDate,
                    ExportActualWeeklyJobTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualWeeklyJobTotalsListResponse ExportActualWeeklyJobTotalsList(
            ExportActualWeeklyJobTotalsList arg)
        {
            return Client.Post<ExportActualWeeklyJobTotalsList, ExportActualWeeklyJobTotalsListResponse>(this.username,
                this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualWeeklyJobTotalsListResponse> ExportActualWeeklyJobTotalsListAsync(
            ExportActualWeeklyJobTotalsList arg)
        {
            return Client.PostAsync<ExportActualWeeklyJobTotalsList, ExportActualWeeklyJobTotalsListResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualWeeklyJobTotalsResponse ExportActualWeeklyJobTotals(
            ExportActualWeeklyJobTotals arg)
        {
            return Client.Post<ExportActualWeeklyJobTotals, ExportActualWeeklyJobTotalsResponse>(this.username,
                this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualWeeklyJobTotalsResponse> ExportActualWeeklyJobTotalsAsync(
            ExportActualWeeklyJobTotals arg)
        {
            return Client.PostAsync<ExportActualWeeklyJobTotals, ExportActualWeeklyJobTotalsResponse>(this.username,
                this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedDailyJobTotalsFromPeriodResponse ExportPlannedDailyJobTotalsFromPeriod(
            ExportPlannedDailyJobTotalsFromPeriod arg)
        {
            return Client.Post<ExportPlannedDailyJobTotalsFromPeriod, ExportPlannedDailyJobTotalsFromPeriodResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedDailyJobTotalsFromPeriodResponse> ExportPlannedDailyJobTotalsFromPeriodAsync(
            ExportPlannedDailyJobTotalsFromPeriod arg)
        {
            return Client
                .PostAsync<ExportPlannedDailyJobTotalsFromPeriod, ExportPlannedDailyJobTotalsFromPeriodResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedDailyJobTotalsFromRelativeDatesResponse ExportPlannedDailyJobTotalsFromRelativeDates(
            ExportPlannedDailyJobTotalsFromRelativeDates arg)
        {
            return Client
                .Post<ExportPlannedDailyJobTotalsFromRelativeDates,
                    ExportPlannedDailyJobTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedDailyJobTotalsFromRelativeDatesResponse>
            ExportPlannedDailyJobTotalsFromRelativeDatesAsync(
                ExportPlannedDailyJobTotalsFromRelativeDates arg)
        {
            return Client
                .PostAsync<ExportPlannedDailyJobTotalsFromRelativeDates,
                    ExportPlannedDailyJobTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedDailyJobTotalsFromDateToDateResponse ExportPlannedDailyJobTotalsFromDateToDate(
            ExportPlannedDailyJobTotalsFromDateToDate arg)
        {
            return Client
                .Post<ExportPlannedDailyJobTotalsFromDateToDate, ExportPlannedDailyJobTotalsFromDateToDateResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedDailyJobTotalsFromDateToDateResponse> ExportPlannedDailyJobTotalsFromDateToDateAsync(
            ExportPlannedDailyJobTotalsFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportPlannedDailyJobTotalsFromDateToDate,
                    ExportPlannedDailyJobTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualDailyJobTotalsFromDateToDateResponse ExportActualDailyJobTotalsFromDateToDate(
            ExportActualDailyJobTotalsFromDateToDate arg)
        {
            return Client
                .Post<ExportActualDailyJobTotalsFromDateToDate, ExportActualDailyJobTotalsFromDateToDateResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualDailyJobTotalsFromDateToDateResponse> ExportActualDailyJobTotalsFromDateToDateAsync(
            ExportActualDailyJobTotalsFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportActualDailyJobTotalsFromDateToDate, ExportActualDailyJobTotalsFromDateToDateResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualDailyJobTotalsFromRelativeDatesResponse ExportActualDailyJobTotalsFromRelativeDates(
            ExportActualDailyJobTotalsFromRelativeDates arg)
        {
            return Client
                .Post<ExportActualDailyJobTotalsFromRelativeDates, ExportActualDailyJobTotalsFromRelativeDatesResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualDailyJobTotalsFromRelativeDatesResponse>
            ExportActualDailyJobTotalsFromRelativeDatesAsync(
                ExportActualDailyJobTotalsFromRelativeDates arg)
        {
            return Client
                .PostAsync<ExportActualDailyJobTotalsFromRelativeDates,
                    ExportActualDailyJobTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualDailyJobTotalsFromPeriodResponse ExportActualDailyJobTotalsFromPeriod(
            ExportActualDailyJobTotalsFromPeriod arg)
        {
            return Client.Post<ExportActualDailyJobTotalsFromPeriod, ExportActualDailyJobTotalsFromPeriodResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualDailyJobTotalsFromPeriodResponse> ExportActualDailyJobTotalsFromPeriodAsync(
            ExportActualDailyJobTotalsFromPeriod arg)
        {
            return Client.PostAsync<ExportActualDailyJobTotalsFromPeriod, ExportActualDailyJobTotalsFromPeriodResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedWeeklyJobTotalsResponse ExportPlannedWeeklyJobTotals(
            ExportPlannedWeeklyJobTotals arg)
        {
            return Client.Post<ExportPlannedWeeklyJobTotals, ExportPlannedWeeklyJobTotalsResponse>(this.username,
                this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedWeeklyJobTotalsResponse> ExportPlannedWeeklyJobTotalsAsync(
            ExportPlannedWeeklyJobTotals arg)
        {
            return Client.PostAsync<ExportPlannedWeeklyJobTotals, ExportPlannedWeeklyJobTotalsResponse>(this.username,
                this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedWeeklyJobTotalsListFromDateToDateResponse ExportPlannedWeeklyJobTotalsListFromDateToDate(
            ExportPlannedWeeklyJobTotalsListFromDateToDate arg)
        {
            return Client
                .Post<ExportPlannedWeeklyJobTotalsListFromDateToDate,
                    ExportPlannedWeeklyJobTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedWeeklyJobTotalsListFromDateToDateResponse>
            ExportPlannedWeeklyJobTotalsListFromDateToDateAsync(
                ExportPlannedWeeklyJobTotalsListFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportPlannedWeeklyJobTotalsListFromDateToDate,
                    ExportPlannedWeeklyJobTotalsListFromDateToDateResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedWeeklyJobTotalsListResponse ExportPlannedWeeklyJobTotalsList(
            ExportPlannedWeeklyJobTotalsList arg)
        {
            return Client.Post<ExportPlannedWeeklyJobTotalsList, ExportPlannedWeeklyJobTotalsListResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedWeeklyJobTotalsListResponse> ExportPlannedWeeklyJobTotalsListAsync(
            ExportPlannedWeeklyJobTotalsList arg)
        {
            return Client.PostAsync<ExportPlannedWeeklyJobTotalsList, ExportPlannedWeeklyJobTotalsListResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedPeriodicalJobTotalsResponse ExportEstimatedPeriodicalJobTotals(
            ExportEstimatedPeriodicalJobTotals arg)
        {
            return Client.Post<ExportEstimatedPeriodicalJobTotals, ExportEstimatedPeriodicalJobTotalsResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedPeriodicalJobTotalsResponse> ExportEstimatedPeriodicalJobTotalsAsync(
            ExportEstimatedPeriodicalJobTotals arg)
        {
            return Client.PostAsync<ExportEstimatedPeriodicalJobTotals, ExportEstimatedPeriodicalJobTotalsResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedPeriodicalJobTotalsListResponse ExportEstimatedPeriodicalJobTotalsList(
            ExportEstimatedPeriodicalJobTotalsList arg)
        {
            return Client.Post<ExportEstimatedPeriodicalJobTotalsList, ExportEstimatedPeriodicalJobTotalsListResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedPeriodicalJobTotalsListResponse> ExportEstimatedPeriodicalJobTotalsListAsync(
            ExportEstimatedPeriodicalJobTotalsList arg)
        {
            return Client
                .PostAsync<ExportEstimatedPeriodicalJobTotalsList, ExportEstimatedPeriodicalJobTotalsListResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedPeriodicalJobTotalsListFromDateToDateResponse
            ExportEstimatedPeriodicalJobTotalsListFromDateToDate(
                ExportEstimatedPeriodicalJobTotalsListFromDateToDate arg)
        {
            return Client
                .Post<ExportEstimatedPeriodicalJobTotalsListFromDateToDate,
                    ExportEstimatedPeriodicalJobTotalsListFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedPeriodicalJobTotalsListFromDateToDateResponse>
            ExportEstimatedPeriodicalJobTotalsListFromDateToDateAsync(
                ExportEstimatedPeriodicalJobTotalsListFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportEstimatedPeriodicalJobTotalsListFromDateToDate,
                    ExportEstimatedPeriodicalJobTotalsListFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedWeeklyJobTotalsListFromDateToDateResponse
            ExportEstimatedWeeklyJobTotalsListFromDateToDate(
                ExportEstimatedWeeklyJobTotalsListFromDateToDate arg)
        {
            return Client
                .Post<ExportEstimatedWeeklyJobTotalsListFromDateToDate,
                    ExportEstimatedWeeklyJobTotalsListFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedWeeklyJobTotalsListFromDateToDateResponse>
            ExportEstimatedWeeklyJobTotalsListFromDateToDateAsync(
                ExportEstimatedWeeklyJobTotalsListFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportEstimatedWeeklyJobTotalsListFromDateToDate,
                    ExportEstimatedWeeklyJobTotalsListFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedWeeklyJobTotalsListResponse ExportEstimatedWeeklyJobTotalsList(
            ExportEstimatedWeeklyJobTotalsList arg)
        {
            return Client.Post<ExportEstimatedWeeklyJobTotalsList, ExportEstimatedWeeklyJobTotalsListResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedWeeklyJobTotalsListResponse> ExportEstimatedWeeklyJobTotalsListAsync(
            ExportEstimatedWeeklyJobTotalsList arg)
        {
            return Client.PostAsync<ExportEstimatedWeeklyJobTotalsList, ExportEstimatedWeeklyJobTotalsListResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedWeeklyJobTotalsResponse ExportEstimatedWeeklyJobTotals(
            ExportEstimatedWeeklyJobTotals arg)
        {
            return Client.Post<ExportEstimatedWeeklyJobTotals, ExportEstimatedWeeklyJobTotalsResponse>(this.username,
                this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedWeeklyJobTotalsResponse> ExportEstimatedWeeklyJobTotalsAsync(
            ExportEstimatedWeeklyJobTotals arg)
        {
            return Client.PostAsync<ExportEstimatedWeeklyJobTotals, ExportEstimatedWeeklyJobTotalsResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualJobTotalsFromRelativeDatesResponse ExportActualJobTotalsFromRelativeDates(
            ExportActualJobTotalsFromRelativeDates arg)
        {
            return Client.Post<ExportActualJobTotalsFromRelativeDates, ExportActualJobTotalsFromRelativeDatesResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualJobTotalsFromRelativeDatesResponse> ExportActualJobTotalsFromRelativeDatesAsync(
            ExportActualJobTotalsFromRelativeDates arg)
        {
            return Client
                .PostAsync<ExportActualJobTotalsFromRelativeDates, ExportActualJobTotalsFromRelativeDatesResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualJobTotalsFromDateToDateResponse ExportActualJobTotalsFromDateToDate(
            ExportActualJobTotalsFromDateToDate arg)
        {
            return Client.Post<ExportActualJobTotalsFromDateToDate, ExportActualJobTotalsFromDateToDateResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualJobTotalsFromDateToDateResponse> ExportActualJobTotalsFromDateToDateAsync(
            ExportActualJobTotalsFromDateToDate arg)
        {
            return Client.PostAsync<ExportActualJobTotalsFromDateToDate, ExportActualJobTotalsFromDateToDateResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualPerpetualJobTotalsListResponse ExportActualPerpetualJobTotalsList(
            ExportActualPerpetualJobTotalsList arg)
        {
            return Client.Post<ExportActualPerpetualJobTotalsList, ExportActualPerpetualJobTotalsListResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualPerpetualJobTotalsListResponse> ExportActualPerpetualJobTotalsListAsync(
            ExportActualPerpetualJobTotalsList arg)
        {
            return Client.PostAsync<ExportActualPerpetualJobTotalsList, ExportActualPerpetualJobTotalsListResponse>(
                this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualPerpetualJobTotalsListFromDateResponse ExportActualPerpetualJobTotalsListFromDate(
            ExportActualPerpetualJobTotalsListFromDate arg)
        {
            return Client
                .Post<ExportActualPerpetualJobTotalsListFromDate, ExportActualPerpetualJobTotalsListFromDateResponse>(
                    this.username, this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualPerpetualJobTotalsListFromDateResponse> ExportActualPerpetualJobTotalsListFromDateAsync(
            ExportActualPerpetualJobTotalsListFromDate arg)
        {
            return Client
                .PostAsync<ExportActualPerpetualJobTotalsListFromDate,
                    ExportActualPerpetualJobTotalsListFromDateResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualPerpetualJobTotalsFromRelativeDatesResponse ExportActualPerpetualJobTotalsFromRelativeDates(
            ExportActualPerpetualJobTotalsFromRelativeDates arg)
        {
            return Client
                .Post<ExportActualPerpetualJobTotalsFromRelativeDates,
                    ExportActualPerpetualJobTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualPerpetualJobTotalsFromRelativeDatesResponse>
            ExportActualPerpetualJobTotalsFromRelativeDatesAsync(
                ExportActualPerpetualJobTotalsFromRelativeDates arg)
        {
            return Client
                .PostAsync<ExportActualPerpetualJobTotalsFromRelativeDates,
                    ExportActualPerpetualJobTotalsFromRelativeDatesResponse>(this.username, this.password, this.baseuri,
                    "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportWeeklyJobTotalsListResponse ExportWeeklyJobTotalsList(
            ExportWeeklyJobTotalsList arg)
        {
            return Client.Post<ExportWeeklyJobTotalsList, ExportWeeklyJobTotalsListResponse>(this.username,
                this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportWeeklyJobTotalsListResponse> ExportWeeklyJobTotalsListAsync(
            ExportWeeklyJobTotalsList arg)
        {
            return Client.PostAsync<ExportWeeklyJobTotalsList, ExportWeeklyJobTotalsListResponse>(this.username,
                this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportDailyJobTotalsListResponse ExportDailyJobTotalsList(
            ExportDailyJobTotalsList arg)
        {
            return Client.Post<ExportDailyJobTotalsList, ExportDailyJobTotalsListResponse>(this.username, this.password,
                this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportDailyJobTotalsListResponse> ExportDailyJobTotalsListAsync(
            ExportDailyJobTotalsList arg)
        {
            return Client.PostAsync<ExportDailyJobTotalsList, ExportDailyJobTotalsListResponse>(this.username,
                this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportWeeklyJobTotalsResponse ExportWeeklyJobTotals(
            ExportWeeklyJobTotals arg)
        {
            return Client.Post<ExportWeeklyJobTotals, ExportWeeklyJobTotalsResponse>(this.username, this.password,
                this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportWeeklyJobTotalsResponse> ExportWeeklyJobTotalsAsync(
            ExportWeeklyJobTotals arg)
        {
            return Client.PostAsync<ExportWeeklyJobTotals, ExportWeeklyJobTotalsResponse>(this.username, this.password,
                this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public ExportPeriodicalJobTotalsListResponse ExportPeriodicalJobTotalsList(
            ExportPeriodicalJobTotalsList arg)
        {
            return Client.Post<ExportPeriodicalJobTotalsList, ExportPeriodicalJobTotalsListResponse>(this.username,
                this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPeriodicalJobTotalsListResponse> ExportPeriodicalJobTotalsListAsync(
            ExportPeriodicalJobTotalsList arg)
        {
            return Client.PostAsync<ExportPeriodicalJobTotalsList, ExportPeriodicalJobTotalsListResponse>(this.username,
                this.password, this.baseuri, "JobTotalService", arg, this.timeoutSeconds);
        }
    }
}