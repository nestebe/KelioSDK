//.AbsenceBalanceTotalServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class AbsenceBalanceTotalServiceClient
    {
        private const string service = "AbsenceBalanceTotalService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public AbsenceBalanceTotalServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportActualDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse
            ExportActualDailyAbsenceBalanceTotalsFromDateToDateForEmployeeList(
                ExportActualDailyAbsenceBalanceTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportActualDailyAbsenceBalanceTotalsFromDateToDateForEmployeeList,
                    ExportActualDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse>
            ExportActualDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListAsync(
                ExportActualDailyAbsenceBalanceTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualDailyAbsenceBalanceTotalsFromDateToDateForEmployeeList,
                    ExportActualDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualDailyAbsenceBalanceTotalsFromPeriodForEmployeeListResponse
            ExportActualDailyAbsenceBalanceTotalsFromPeriodForEmployeeList(
                ExportActualDailyAbsenceBalanceTotalsFromPeriodForEmployeeList arg)
        {
            return Client
                .Post<ExportActualDailyAbsenceBalanceTotalsFromPeriodForEmployeeList,
                    ExportActualDailyAbsenceBalanceTotalsFromPeriodForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualDailyAbsenceBalanceTotalsFromPeriodForEmployeeListResponse>
            ExportActualDailyAbsenceBalanceTotalsFromPeriodForEmployeeListAsync(
                ExportActualDailyAbsenceBalanceTotalsFromPeriodForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualDailyAbsenceBalanceTotalsFromPeriodForEmployeeList,
                    ExportActualDailyAbsenceBalanceTotalsFromPeriodForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse
            ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeList(
                ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeList,
                    ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse>
            ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeListAsync(
                ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeList,
                    ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualPeriodicalAbsenceBalanceTotalsForEmployeeListResponse
            ExportActualPeriodicalAbsenceBalanceTotalsForEmployeeList(
                ExportActualPeriodicalAbsenceBalanceTotalsForEmployeeList arg)
        {
            return Client
                .Post<ExportActualPeriodicalAbsenceBalanceTotalsForEmployeeList,
                    ExportActualPeriodicalAbsenceBalanceTotalsForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualPeriodicalAbsenceBalanceTotalsForEmployeeListResponse>
            ExportActualPeriodicalAbsenceBalanceTotalsForEmployeeListAsync(
                ExportActualPeriodicalAbsenceBalanceTotalsForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualPeriodicalAbsenceBalanceTotalsForEmployeeList,
                    ExportActualPeriodicalAbsenceBalanceTotalsForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse
            ExportPlannedAbsenceBalanceTotalsFromDateToDateForEmployeeList(
                ExportPlannedAbsenceBalanceTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedAbsenceBalanceTotalsFromDateToDateForEmployeeList,
                    ExportPlannedAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse>
            ExportPlannedAbsenceBalanceTotalsFromDateToDateForEmployeeListAsync(
                ExportPlannedAbsenceBalanceTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedAbsenceBalanceTotalsFromDateToDateForEmployeeList,
                    ExportPlannedAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse
            ExportActualAbsenceBalanceTotalsFromDateToDateForEmployeeList(
                ExportActualAbsenceBalanceTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportActualAbsenceBalanceTotalsFromDateToDateForEmployeeList,
                    ExportActualAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse>
            ExportActualAbsenceBalanceTotalsFromDateToDateForEmployeeListAsync(
                ExportActualAbsenceBalanceTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualAbsenceBalanceTotalsFromDateToDateForEmployeeList,
                    ExportActualAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse
            ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeList(
                ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeList,
                    ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse>
            ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListAsync(
                ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeList,
                    ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse
            ExportActualDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeList(
                ExportActualDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .Post<ExportActualDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeList,
                    ExportActualDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse>
            ExportActualDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeListAsync(
                ExportActualDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeList,
                    ExportActualDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedWeeklyAbsenceBalanceTotalsForEmployeeListResponse
            ExportEstimatedWeeklyAbsenceBalanceTotalsForEmployeeList(
                ExportEstimatedWeeklyAbsenceBalanceTotalsForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedWeeklyAbsenceBalanceTotalsForEmployeeList,
                    ExportEstimatedWeeklyAbsenceBalanceTotalsForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedWeeklyAbsenceBalanceTotalsForEmployeeListResponse>
            ExportEstimatedWeeklyAbsenceBalanceTotalsForEmployeeListAsync(
                ExportEstimatedWeeklyAbsenceBalanceTotalsForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedWeeklyAbsenceBalanceTotalsForEmployeeList,
                    ExportEstimatedWeeklyAbsenceBalanceTotalsForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedWeeklyAbsenceBalanceTotalsForEmployeeListResponse
            ExportPlannedWeeklyAbsenceBalanceTotalsForEmployeeList(
                ExportPlannedWeeklyAbsenceBalanceTotalsForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedWeeklyAbsenceBalanceTotalsForEmployeeList,
                    ExportPlannedWeeklyAbsenceBalanceTotalsForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedWeeklyAbsenceBalanceTotalsForEmployeeListResponse>
            ExportPlannedWeeklyAbsenceBalanceTotalsForEmployeeListAsync(
                ExportPlannedWeeklyAbsenceBalanceTotalsForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedWeeklyAbsenceBalanceTotalsForEmployeeList,
                    ExportPlannedWeeklyAbsenceBalanceTotalsForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualWeeklyAbsenceBalanceTotalsListForEmployeeListResponse
            ExportActualWeeklyAbsenceBalanceTotalsListForEmployeeList(
                ExportActualWeeklyAbsenceBalanceTotalsListForEmployeeList arg)
        {
            return Client
                .Post<ExportActualWeeklyAbsenceBalanceTotalsListForEmployeeList,
                    ExportActualWeeklyAbsenceBalanceTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualWeeklyAbsenceBalanceTotalsListForEmployeeListResponse>
            ExportActualWeeklyAbsenceBalanceTotalsListForEmployeeListAsync(
                ExportActualWeeklyAbsenceBalanceTotalsListForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualWeeklyAbsenceBalanceTotalsListForEmployeeList,
                    ExportActualWeeklyAbsenceBalanceTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualWeeklyAbsenceBalanceTotalsForEmployeeListResponse
            ExportActualWeeklyAbsenceBalanceTotalsForEmployeeList(
                ExportActualWeeklyAbsenceBalanceTotalsForEmployeeList arg)
        {
            return Client
                .Post<ExportActualWeeklyAbsenceBalanceTotalsForEmployeeList,
                    ExportActualWeeklyAbsenceBalanceTotalsForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualWeeklyAbsenceBalanceTotalsForEmployeeListResponse>
            ExportActualWeeklyAbsenceBalanceTotalsForEmployeeListAsync(
                ExportActualWeeklyAbsenceBalanceTotalsForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualWeeklyAbsenceBalanceTotalsForEmployeeList,
                    ExportActualWeeklyAbsenceBalanceTotalsForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse
            ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeList(
                ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeList,
                    ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse>
            ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeListAsync(
                ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeList,
                    ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedDailyAbsenceBalanceTotalsFromPeriodForEmployeeListResponse
            ExportEstimatedDailyAbsenceBalanceTotalsFromPeriodForEmployeeList(
                ExportEstimatedDailyAbsenceBalanceTotalsFromPeriodForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedDailyAbsenceBalanceTotalsFromPeriodForEmployeeList,
                    ExportEstimatedDailyAbsenceBalanceTotalsFromPeriodForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedDailyAbsenceBalanceTotalsFromPeriodForEmployeeListResponse>
            ExportEstimatedDailyAbsenceBalanceTotalsFromPeriodForEmployeeListAsync(
                ExportEstimatedDailyAbsenceBalanceTotalsFromPeriodForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedDailyAbsenceBalanceTotalsFromPeriodForEmployeeList,
                    ExportEstimatedDailyAbsenceBalanceTotalsFromPeriodForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse
            ExportPlannedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeList(
                ExportPlannedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeList,
                    ExportPlannedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse>
            ExportPlannedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListAsync(
                ExportPlannedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeList,
                    ExportPlannedDailyAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedDailyAbsenceBalanceTotalsFromPeriodForEmployeeListResponse
            ExportPlannedDailyAbsenceBalanceTotalsFromPeriodForEmployeeList(
                ExportPlannedDailyAbsenceBalanceTotalsFromPeriodForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedDailyAbsenceBalanceTotalsFromPeriodForEmployeeList,
                    ExportPlannedDailyAbsenceBalanceTotalsFromPeriodForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedDailyAbsenceBalanceTotalsFromPeriodForEmployeeListResponse>
            ExportPlannedDailyAbsenceBalanceTotalsFromPeriodForEmployeeListAsync(
                ExportPlannedDailyAbsenceBalanceTotalsFromPeriodForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedDailyAbsenceBalanceTotalsFromPeriodForEmployeeList,
                    ExportPlannedDailyAbsenceBalanceTotalsFromPeriodForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedPeriodicalAbsenceBalanceTotalsForEmployeeListResponse
            ExportEstimatedPeriodicalAbsenceBalanceTotalsForEmployeeList(
                ExportEstimatedPeriodicalAbsenceBalanceTotalsForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedPeriodicalAbsenceBalanceTotalsForEmployeeList,
                    ExportEstimatedPeriodicalAbsenceBalanceTotalsForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedPeriodicalAbsenceBalanceTotalsForEmployeeListResponse>
            ExportEstimatedPeriodicalAbsenceBalanceTotalsForEmployeeListAsync(
                ExportEstimatedPeriodicalAbsenceBalanceTotalsForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedPeriodicalAbsenceBalanceTotalsForEmployeeList,
                    ExportEstimatedPeriodicalAbsenceBalanceTotalsForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse
            ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeList(
                ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeList,
                    ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse>
            ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeListAsync(
                ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeList,
                    ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse
            ExportActualAbsenceBalanceTotalsFromRelativeDatesForEmployeeList(
                ExportActualAbsenceBalanceTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .Post<ExportActualAbsenceBalanceTotalsFromRelativeDatesForEmployeeList,
                    ExportActualAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse>
            ExportActualAbsenceBalanceTotalsFromRelativeDatesForEmployeeListAsync(
                ExportActualAbsenceBalanceTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualAbsenceBalanceTotalsFromRelativeDatesForEmployeeList,
                    ExportActualAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse
            ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeList(
                ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeList,
                    ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse>
            ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeListAsync(
                ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeList,
                    ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse
            ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeList(
                ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeList,
                    ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse>
            ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeListAsync(
                ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeList,
                    ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedPeriodicalAbsenceBalanceTotalsForEmployeeListResponse
            ExportPlannedPeriodicalAbsenceBalanceTotalsForEmployeeList(
                ExportPlannedPeriodicalAbsenceBalanceTotalsForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedPeriodicalAbsenceBalanceTotalsForEmployeeList,
                    ExportPlannedPeriodicalAbsenceBalanceTotalsForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedPeriodicalAbsenceBalanceTotalsForEmployeeListResponse>
            ExportPlannedPeriodicalAbsenceBalanceTotalsForEmployeeListAsync(
                ExportPlannedPeriodicalAbsenceBalanceTotalsForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedPeriodicalAbsenceBalanceTotalsForEmployeeList,
                    ExportPlannedPeriodicalAbsenceBalanceTotalsForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse
            ExportEstimatedAbsenceBalanceTotalsFromDateToDateForEmployeeList(
                ExportEstimatedAbsenceBalanceTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedAbsenceBalanceTotalsFromDateToDateForEmployeeList,
                    ExportEstimatedAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse>
            ExportEstimatedAbsenceBalanceTotalsFromDateToDateForEmployeeListAsync(
                ExportEstimatedAbsenceBalanceTotalsFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedAbsenceBalanceTotalsFromDateToDateForEmployeeList,
                    ExportEstimatedAbsenceBalanceTotalsFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse
            ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeList(
                ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeList,
                    ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse>(
                    this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse>
            ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeListAsync(
                ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeList,
                    ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse>(
                    this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualPeriodicalAbsenceBalanceTotalsListForEmployeeListResponse
            ExportActualPeriodicalAbsenceBalanceTotalsListForEmployeeList(
                ExportActualPeriodicalAbsenceBalanceTotalsListForEmployeeList arg)
        {
            return Client
                .Post<ExportActualPeriodicalAbsenceBalanceTotalsListForEmployeeList,
                    ExportActualPeriodicalAbsenceBalanceTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualPeriodicalAbsenceBalanceTotalsListForEmployeeListResponse>
            ExportActualPeriodicalAbsenceBalanceTotalsListForEmployeeListAsync(
                ExportActualPeriodicalAbsenceBalanceTotalsListForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportActualPeriodicalAbsenceBalanceTotalsListForEmployeeList,
                    ExportActualPeriodicalAbsenceBalanceTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedPeriodicalAbsenceBalanceTotalsListForEmployeeListResponse
            ExportPlannedPeriodicalAbsenceBalanceTotalsListForEmployeeList(
                ExportPlannedPeriodicalAbsenceBalanceTotalsListForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedPeriodicalAbsenceBalanceTotalsListForEmployeeList,
                    ExportPlannedPeriodicalAbsenceBalanceTotalsListForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedPeriodicalAbsenceBalanceTotalsListForEmployeeListResponse>
            ExportPlannedPeriodicalAbsenceBalanceTotalsListForEmployeeListAsync(
                ExportPlannedPeriodicalAbsenceBalanceTotalsListForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedPeriodicalAbsenceBalanceTotalsListForEmployeeList,
                    ExportPlannedPeriodicalAbsenceBalanceTotalsListForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse
            ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeList(
                ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeList,
                    ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse>
            ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeListAsync(
                ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeList,
                    ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDateForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse
            ExportPlannedAbsenceBalanceTotalsFromRelativeDatesForEmployeeList(
                ExportPlannedAbsenceBalanceTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedAbsenceBalanceTotalsFromRelativeDatesForEmployeeList,
                    ExportPlannedAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse>
            ExportPlannedAbsenceBalanceTotalsFromRelativeDatesForEmployeeListAsync(
                ExportPlannedAbsenceBalanceTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedAbsenceBalanceTotalsFromRelativeDatesForEmployeeList,
                    ExportPlannedAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse
            ExportEstimatedAbsenceBalanceTotalsFromRelativeDatesForEmployeeList(
                ExportEstimatedAbsenceBalanceTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedAbsenceBalanceTotalsFromRelativeDatesForEmployeeList,
                    ExportEstimatedAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse>
            ExportEstimatedAbsenceBalanceTotalsFromRelativeDatesForEmployeeListAsync(
                ExportEstimatedAbsenceBalanceTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedAbsenceBalanceTotalsFromRelativeDatesForEmployeeList,
                    ExportEstimatedAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedWeeklyAbsenceBalanceTotalsListForEmployeeListResponse
            ExportEstimatedWeeklyAbsenceBalanceTotalsListForEmployeeList(
                ExportEstimatedWeeklyAbsenceBalanceTotalsListForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedWeeklyAbsenceBalanceTotalsListForEmployeeList,
                    ExportEstimatedWeeklyAbsenceBalanceTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedWeeklyAbsenceBalanceTotalsListForEmployeeListResponse>
            ExportEstimatedWeeklyAbsenceBalanceTotalsListForEmployeeListAsync(
                ExportEstimatedWeeklyAbsenceBalanceTotalsListForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedWeeklyAbsenceBalanceTotalsListForEmployeeList,
                    ExportEstimatedWeeklyAbsenceBalanceTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedWeeklyAbsenceBalanceTotalsListForEmployeeListResponse
            ExportPlannedWeeklyAbsenceBalanceTotalsListForEmployeeList(
                ExportPlannedWeeklyAbsenceBalanceTotalsListForEmployeeList arg)
        {
            return Client
                .Post<ExportPlannedWeeklyAbsenceBalanceTotalsListForEmployeeList,
                    ExportPlannedWeeklyAbsenceBalanceTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedWeeklyAbsenceBalanceTotalsListForEmployeeListResponse>
            ExportPlannedWeeklyAbsenceBalanceTotalsListForEmployeeListAsync(
                ExportPlannedWeeklyAbsenceBalanceTotalsListForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportPlannedWeeklyAbsenceBalanceTotalsListForEmployeeList,
                    ExportPlannedWeeklyAbsenceBalanceTotalsListForEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedPeriodicalAbsenceBalanceTotalsListForEmployeeListResponse
            ExportEstimatedPeriodicalAbsenceBalanceTotalsListForEmployeeList(
                ExportEstimatedPeriodicalAbsenceBalanceTotalsListForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedPeriodicalAbsenceBalanceTotalsListForEmployeeList,
                    ExportEstimatedPeriodicalAbsenceBalanceTotalsListForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedPeriodicalAbsenceBalanceTotalsListForEmployeeListResponse>
            ExportEstimatedPeriodicalAbsenceBalanceTotalsListForEmployeeListAsync(
                ExportEstimatedPeriodicalAbsenceBalanceTotalsListForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedPeriodicalAbsenceBalanceTotalsListForEmployeeList,
                    ExportEstimatedPeriodicalAbsenceBalanceTotalsListForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse
            ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeList(
                ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .Post<ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeList,
                    ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse>
            ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeListAsync(
                ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeList arg)
        {
            return Client
                .PostAsync<ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeList,
                    ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDatesForEmployeeListResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDateResponse
            ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDate(
                ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDate arg)
        {
            return Client
                .Post<ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDate,
                    ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDateResponse>
            ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDateAsync(
                ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDate,
                    ExportPlannedPeriodicalAbsenceBalanceTotalsListFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedPeriodicalAbsenceBalanceTotalsListResponse ExportPlannedPeriodicalAbsenceBalanceTotalsList(
            ExportPlannedPeriodicalAbsenceBalanceTotalsList arg)
        {
            return Client
                .Post<ExportPlannedPeriodicalAbsenceBalanceTotalsList,
                    ExportPlannedPeriodicalAbsenceBalanceTotalsListResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedPeriodicalAbsenceBalanceTotalsListResponse>
            ExportPlannedPeriodicalAbsenceBalanceTotalsListAsync(
                ExportPlannedPeriodicalAbsenceBalanceTotalsList arg)
        {
            return Client
                .PostAsync<ExportPlannedPeriodicalAbsenceBalanceTotalsList,
                    ExportPlannedPeriodicalAbsenceBalanceTotalsListResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedPeriodicalAbsenceBalanceTotalsResponse ExportPlannedPeriodicalAbsenceBalanceTotals(
            ExportPlannedPeriodicalAbsenceBalanceTotals arg)
        {
            return Client
                .Post<ExportPlannedPeriodicalAbsenceBalanceTotals, ExportPlannedPeriodicalAbsenceBalanceTotalsResponse>(
                    this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedPeriodicalAbsenceBalanceTotalsResponse>
            ExportPlannedPeriodicalAbsenceBalanceTotalsAsync(
                ExportPlannedPeriodicalAbsenceBalanceTotals arg)
        {
            return Client
                .PostAsync<ExportPlannedPeriodicalAbsenceBalanceTotals,
                    ExportPlannedPeriodicalAbsenceBalanceTotalsResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualPeriodicalAbsenceBalanceTotalsResponse ExportActualPeriodicalAbsenceBalanceTotals(
            ExportActualPeriodicalAbsenceBalanceTotals arg)
        {
            return Client
                .Post<ExportActualPeriodicalAbsenceBalanceTotals, ExportActualPeriodicalAbsenceBalanceTotalsResponse>(
                    this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualPeriodicalAbsenceBalanceTotalsResponse> ExportActualPeriodicalAbsenceBalanceTotalsAsync(
            ExportActualPeriodicalAbsenceBalanceTotals arg)
        {
            return Client
                .PostAsync<ExportActualPeriodicalAbsenceBalanceTotals,
                    ExportActualPeriodicalAbsenceBalanceTotalsResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualPeriodicalAbsenceBalanceTotalsListResponse ExportActualPeriodicalAbsenceBalanceTotalsList(
            ExportActualPeriodicalAbsenceBalanceTotalsList arg)
        {
            return Client
                .Post<ExportActualPeriodicalAbsenceBalanceTotalsList,
                    ExportActualPeriodicalAbsenceBalanceTotalsListResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualPeriodicalAbsenceBalanceTotalsListResponse>
            ExportActualPeriodicalAbsenceBalanceTotalsListAsync(
                ExportActualPeriodicalAbsenceBalanceTotalsList arg)
        {
            return Client
                .PostAsync<ExportActualPeriodicalAbsenceBalanceTotalsList,
                    ExportActualPeriodicalAbsenceBalanceTotalsListResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDateResponse
            ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDate(
                ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDate arg)
        {
            return Client
                .Post<ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDate,
                    ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDateResponse>
            ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDateAsync(
                ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDate,
                    ExportActualPeriodicalAbsenceBalanceTotalsListFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedAbsenceBalanceTotalsFromRelativeDatesResponse
            ExportEstimatedAbsenceBalanceTotalsFromRelativeDates(
                ExportEstimatedAbsenceBalanceTotalsFromRelativeDates arg)
        {
            return Client
                .Post<ExportEstimatedAbsenceBalanceTotalsFromRelativeDates,
                    ExportEstimatedAbsenceBalanceTotalsFromRelativeDatesResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedAbsenceBalanceTotalsFromRelativeDatesResponse>
            ExportEstimatedAbsenceBalanceTotalsFromRelativeDatesAsync(
                ExportEstimatedAbsenceBalanceTotalsFromRelativeDates arg)
        {
            return Client
                .PostAsync<ExportEstimatedAbsenceBalanceTotalsFromRelativeDates,
                    ExportEstimatedAbsenceBalanceTotalsFromRelativeDatesResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedAbsenceBalanceTotalsFromDateToDateResponse
            ExportEstimatedAbsenceBalanceTotalsFromDateToDate(
                ExportEstimatedAbsenceBalanceTotalsFromDateToDate arg)
        {
            return Client
                .Post<ExportEstimatedAbsenceBalanceTotalsFromDateToDate,
                    ExportEstimatedAbsenceBalanceTotalsFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedAbsenceBalanceTotalsFromDateToDateResponse>
            ExportEstimatedAbsenceBalanceTotalsFromDateToDateAsync(
                ExportEstimatedAbsenceBalanceTotalsFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportEstimatedAbsenceBalanceTotalsFromDateToDate,
                    ExportEstimatedAbsenceBalanceTotalsFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedAbsenceBalanceTotalsFromRelativeDatesResponse
            ExportPlannedAbsenceBalanceTotalsFromRelativeDates(
                ExportPlannedAbsenceBalanceTotalsFromRelativeDates arg)
        {
            return Client
                .Post<ExportPlannedAbsenceBalanceTotalsFromRelativeDates,
                    ExportPlannedAbsenceBalanceTotalsFromRelativeDatesResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedAbsenceBalanceTotalsFromRelativeDatesResponse>
            ExportPlannedAbsenceBalanceTotalsFromRelativeDatesAsync(
                ExportPlannedAbsenceBalanceTotalsFromRelativeDates arg)
        {
            return Client
                .PostAsync<ExportPlannedAbsenceBalanceTotalsFromRelativeDates,
                    ExportPlannedAbsenceBalanceTotalsFromRelativeDatesResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedAbsenceBalanceTotalsFromDateToDateResponse ExportPlannedAbsenceBalanceTotalsFromDateToDate(
            ExportPlannedAbsenceBalanceTotalsFromDateToDate arg)
        {
            return Client
                .Post<ExportPlannedAbsenceBalanceTotalsFromDateToDate,
                    ExportPlannedAbsenceBalanceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedAbsenceBalanceTotalsFromDateToDateResponse>
            ExportPlannedAbsenceBalanceTotalsFromDateToDateAsync(
                ExportPlannedAbsenceBalanceTotalsFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportPlannedAbsenceBalanceTotalsFromDateToDate,
                    ExportPlannedAbsenceBalanceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportDailyAbsenceBalanceTotalsResponse ExportDailyAbsenceBalanceTotals(
            ExportDailyAbsenceBalanceTotals arg)
        {
            return Client.Post<ExportDailyAbsenceBalanceTotals, ExportDailyAbsenceBalanceTotalsResponse>(this.username,
                this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportDailyAbsenceBalanceTotalsResponse> ExportDailyAbsenceBalanceTotalsAsync(
            ExportDailyAbsenceBalanceTotals arg)
        {
            return Client.PostAsync<ExportDailyAbsenceBalanceTotals, ExportDailyAbsenceBalanceTotalsResponse>(
                this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPeriodicalAbsenceBalanceTotalsResponse ExportPeriodicalAbsenceBalanceTotals(
            ExportPeriodicalAbsenceBalanceTotals arg)
        {
            return Client.Post<ExportPeriodicalAbsenceBalanceTotals, ExportPeriodicalAbsenceBalanceTotalsResponse>(
                this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPeriodicalAbsenceBalanceTotalsResponse> ExportPeriodicalAbsenceBalanceTotalsAsync(
            ExportPeriodicalAbsenceBalanceTotals arg)
        {
            return Client.PostAsync<ExportPeriodicalAbsenceBalanceTotals, ExportPeriodicalAbsenceBalanceTotalsResponse>(
                this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDateResponse
            ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDate(
                ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDate arg)
        {
            return Client
                .Post<ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDate,
                    ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDateResponse>
            ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDateAsync(
                ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDate,
                    ExportEstimatedDailyAbsenceBalanceTotalsFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedDailyAbsenceBalanceTotalsFromPeriodResponse
            ExportEstimatedDailyAbsenceBalanceTotalsFromPeriod(
                ExportEstimatedDailyAbsenceBalanceTotalsFromPeriod arg)
        {
            return Client
                .Post<ExportEstimatedDailyAbsenceBalanceTotalsFromPeriod,
                    ExportEstimatedDailyAbsenceBalanceTotalsFromPeriodResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedDailyAbsenceBalanceTotalsFromPeriodResponse>
            ExportEstimatedDailyAbsenceBalanceTotalsFromPeriodAsync(
                ExportEstimatedDailyAbsenceBalanceTotalsFromPeriod arg)
        {
            return Client
                .PostAsync<ExportEstimatedDailyAbsenceBalanceTotalsFromPeriod,
                    ExportEstimatedDailyAbsenceBalanceTotalsFromPeriodResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDatesResponse
            ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDates(
                ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDates arg)
        {
            return Client
                .Post<ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDates,
                    ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDatesResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDatesResponse>
            ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDatesAsync(
                ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDates arg)
        {
            return Client
                .PostAsync<ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDates,
                    ExportEstimatedDailyAbsenceBalanceTotalsFromRelativeDatesResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualWeeklyAbsenceBalanceTotalsResponse ExportActualWeeklyAbsenceBalanceTotals(
            ExportActualWeeklyAbsenceBalanceTotals arg)
        {
            return Client.Post<ExportActualWeeklyAbsenceBalanceTotals, ExportActualWeeklyAbsenceBalanceTotalsResponse>(
                this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualWeeklyAbsenceBalanceTotalsResponse> ExportActualWeeklyAbsenceBalanceTotalsAsync(
            ExportActualWeeklyAbsenceBalanceTotals arg)
        {
            return Client
                .PostAsync<ExportActualWeeklyAbsenceBalanceTotals, ExportActualWeeklyAbsenceBalanceTotalsResponse>(
                    this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDateResponse
            ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDate(
                ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDate arg)
        {
            return Client
                .Post<ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDate,
                    ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDateResponse>
            ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDateAsync(
                ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDate,
                    ExportActualWeeklyAbsenceBalanceTotalsListFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualWeeklyAbsenceBalanceTotalsListResponse ExportActualWeeklyAbsenceBalanceTotalsList(
            ExportActualWeeklyAbsenceBalanceTotalsList arg)
        {
            return Client
                .Post<ExportActualWeeklyAbsenceBalanceTotalsList, ExportActualWeeklyAbsenceBalanceTotalsListResponse>(
                    this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualWeeklyAbsenceBalanceTotalsListResponse> ExportActualWeeklyAbsenceBalanceTotalsListAsync(
            ExportActualWeeklyAbsenceBalanceTotalsList arg)
        {
            return Client
                .PostAsync<ExportActualWeeklyAbsenceBalanceTotalsList,
                    ExportActualWeeklyAbsenceBalanceTotalsListResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedDailyAbsenceBalanceTotalsFromDateToDateResponse
            ExportPlannedDailyAbsenceBalanceTotalsFromDateToDate(
                ExportPlannedDailyAbsenceBalanceTotalsFromDateToDate arg)
        {
            return Client
                .Post<ExportPlannedDailyAbsenceBalanceTotalsFromDateToDate,
                    ExportPlannedDailyAbsenceBalanceTotalsFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedDailyAbsenceBalanceTotalsFromDateToDateResponse>
            ExportPlannedDailyAbsenceBalanceTotalsFromDateToDateAsync(
                ExportPlannedDailyAbsenceBalanceTotalsFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportPlannedDailyAbsenceBalanceTotalsFromDateToDate,
                    ExportPlannedDailyAbsenceBalanceTotalsFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedDailyAbsenceBalanceTotalsFromPeriodResponse
            ExportPlannedDailyAbsenceBalanceTotalsFromPeriod(
                ExportPlannedDailyAbsenceBalanceTotalsFromPeriod arg)
        {
            return Client
                .Post<ExportPlannedDailyAbsenceBalanceTotalsFromPeriod,
                    ExportPlannedDailyAbsenceBalanceTotalsFromPeriodResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedDailyAbsenceBalanceTotalsFromPeriodResponse>
            ExportPlannedDailyAbsenceBalanceTotalsFromPeriodAsync(
                ExportPlannedDailyAbsenceBalanceTotalsFromPeriod arg)
        {
            return Client
                .PostAsync<ExportPlannedDailyAbsenceBalanceTotalsFromPeriod,
                    ExportPlannedDailyAbsenceBalanceTotalsFromPeriodResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDatesResponse
            ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDates(
                ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDates arg)
        {
            return Client
                .Post<ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDates,
                    ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDatesResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDatesResponse>
            ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDatesAsync(
                ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDates arg)
        {
            return Client
                .PostAsync<ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDates,
                    ExportPlannedDailyAbsenceBalanceTotalsFromRelativeDatesResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualDailyAbsenceBalanceTotalsFromRelativeDatesResponse
            ExportActualDailyAbsenceBalanceTotalsFromRelativeDates(
                ExportActualDailyAbsenceBalanceTotalsFromRelativeDates arg)
        {
            return Client
                .Post<ExportActualDailyAbsenceBalanceTotalsFromRelativeDates,
                    ExportActualDailyAbsenceBalanceTotalsFromRelativeDatesResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualDailyAbsenceBalanceTotalsFromRelativeDatesResponse>
            ExportActualDailyAbsenceBalanceTotalsFromRelativeDatesAsync(
                ExportActualDailyAbsenceBalanceTotalsFromRelativeDates arg)
        {
            return Client
                .PostAsync<ExportActualDailyAbsenceBalanceTotalsFromRelativeDates,
                    ExportActualDailyAbsenceBalanceTotalsFromRelativeDatesResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualDailyAbsenceBalanceTotalsFromPeriodResponse ExportActualDailyAbsenceBalanceTotalsFromPeriod(
            ExportActualDailyAbsenceBalanceTotalsFromPeriod arg)
        {
            return Client
                .Post<ExportActualDailyAbsenceBalanceTotalsFromPeriod,
                    ExportActualDailyAbsenceBalanceTotalsFromPeriodResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualDailyAbsenceBalanceTotalsFromPeriodResponse>
            ExportActualDailyAbsenceBalanceTotalsFromPeriodAsync(
                ExportActualDailyAbsenceBalanceTotalsFromPeriod arg)
        {
            return Client
                .PostAsync<ExportActualDailyAbsenceBalanceTotalsFromPeriod,
                    ExportActualDailyAbsenceBalanceTotalsFromPeriodResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualDailyAbsenceBalanceTotalsFromDateToDateResponse
            ExportActualDailyAbsenceBalanceTotalsFromDateToDate(
                ExportActualDailyAbsenceBalanceTotalsFromDateToDate arg)
        {
            return Client
                .Post<ExportActualDailyAbsenceBalanceTotalsFromDateToDate,
                    ExportActualDailyAbsenceBalanceTotalsFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualDailyAbsenceBalanceTotalsFromDateToDateResponse>
            ExportActualDailyAbsenceBalanceTotalsFromDateToDateAsync(
                ExportActualDailyAbsenceBalanceTotalsFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportActualDailyAbsenceBalanceTotalsFromDateToDate,
                    ExportActualDailyAbsenceBalanceTotalsFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDateResponse
            ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDate(
                ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDate arg)
        {
            return Client
                .Post<ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDate,
                    ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDateResponse>
            ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDateAsync(
                ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDate,
                    ExportPlannedWeeklyAbsenceBalanceTotalsListFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedWeeklyAbsenceBalanceTotalsListResponse ExportPlannedWeeklyAbsenceBalanceTotalsList(
            ExportPlannedWeeklyAbsenceBalanceTotalsList arg)
        {
            return Client
                .Post<ExportPlannedWeeklyAbsenceBalanceTotalsList, ExportPlannedWeeklyAbsenceBalanceTotalsListResponse>(
                    this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedWeeklyAbsenceBalanceTotalsListResponse>
            ExportPlannedWeeklyAbsenceBalanceTotalsListAsync(
                ExportPlannedWeeklyAbsenceBalanceTotalsList arg)
        {
            return Client
                .PostAsync<ExportPlannedWeeklyAbsenceBalanceTotalsList,
                    ExportPlannedWeeklyAbsenceBalanceTotalsListResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPlannedWeeklyAbsenceBalanceTotalsResponse ExportPlannedWeeklyAbsenceBalanceTotals(
            ExportPlannedWeeklyAbsenceBalanceTotals arg)
        {
            return Client
                .Post<ExportPlannedWeeklyAbsenceBalanceTotals, ExportPlannedWeeklyAbsenceBalanceTotalsResponse>(
                    this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPlannedWeeklyAbsenceBalanceTotalsResponse> ExportPlannedWeeklyAbsenceBalanceTotalsAsync(
            ExportPlannedWeeklyAbsenceBalanceTotals arg)
        {
            return Client
                .PostAsync<ExportPlannedWeeklyAbsenceBalanceTotals, ExportPlannedWeeklyAbsenceBalanceTotalsResponse>(
                    this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedPeriodicalAbsenceBalanceTotalsListResponse
            ExportEstimatedPeriodicalAbsenceBalanceTotalsList(
                ExportEstimatedPeriodicalAbsenceBalanceTotalsList arg)
        {
            return Client
                .Post<ExportEstimatedPeriodicalAbsenceBalanceTotalsList,
                    ExportEstimatedPeriodicalAbsenceBalanceTotalsListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedPeriodicalAbsenceBalanceTotalsListResponse>
            ExportEstimatedPeriodicalAbsenceBalanceTotalsListAsync(
                ExportEstimatedPeriodicalAbsenceBalanceTotalsList arg)
        {
            return Client
                .PostAsync<ExportEstimatedPeriodicalAbsenceBalanceTotalsList,
                    ExportEstimatedPeriodicalAbsenceBalanceTotalsListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedPeriodicalAbsenceBalanceTotalsResponse ExportEstimatedPeriodicalAbsenceBalanceTotals(
            ExportEstimatedPeriodicalAbsenceBalanceTotals arg)
        {
            return Client
                .Post<ExportEstimatedPeriodicalAbsenceBalanceTotals,
                    ExportEstimatedPeriodicalAbsenceBalanceTotalsResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedPeriodicalAbsenceBalanceTotalsResponse>
            ExportEstimatedPeriodicalAbsenceBalanceTotalsAsync(
                ExportEstimatedPeriodicalAbsenceBalanceTotals arg)
        {
            return Client
                .PostAsync<ExportEstimatedPeriodicalAbsenceBalanceTotals,
                    ExportEstimatedPeriodicalAbsenceBalanceTotalsResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDateResponse
            ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDate(
                ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDate arg)
        {
            return Client
                .Post<ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDate,
                    ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDateResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDateResponse>
            ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDateAsync(
                ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDate,
                    ExportEstimatedPeriodicalAbsenceBalanceTotalsListFromDateToDateResponse>(this.username,
                    this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedWeeklyAbsenceBalanceTotalsResponse ExportEstimatedWeeklyAbsenceBalanceTotals(
            ExportEstimatedWeeklyAbsenceBalanceTotals arg)
        {
            return Client
                .Post<ExportEstimatedWeeklyAbsenceBalanceTotals, ExportEstimatedWeeklyAbsenceBalanceTotalsResponse>(
                    this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedWeeklyAbsenceBalanceTotalsResponse> ExportEstimatedWeeklyAbsenceBalanceTotalsAsync(
            ExportEstimatedWeeklyAbsenceBalanceTotals arg)
        {
            return Client
                .PostAsync<ExportEstimatedWeeklyAbsenceBalanceTotals,
                    ExportEstimatedWeeklyAbsenceBalanceTotalsResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDateResponse
            ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDate(
                ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDate arg)
        {
            return Client
                .Post<ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDate,
                    ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDateResponse>
            ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDateAsync(
                ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDate,
                    ExportEstimatedWeeklyAbsenceBalanceTotalsListFromDateToDateResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportEstimatedWeeklyAbsenceBalanceTotalsListResponse ExportEstimatedWeeklyAbsenceBalanceTotalsList(
            ExportEstimatedWeeklyAbsenceBalanceTotalsList arg)
        {
            return Client
                .Post<ExportEstimatedWeeklyAbsenceBalanceTotalsList,
                    ExportEstimatedWeeklyAbsenceBalanceTotalsListResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportEstimatedWeeklyAbsenceBalanceTotalsListResponse>
            ExportEstimatedWeeklyAbsenceBalanceTotalsListAsync(
                ExportEstimatedWeeklyAbsenceBalanceTotalsList arg)
        {
            return Client
                .PostAsync<ExportEstimatedWeeklyAbsenceBalanceTotalsList,
                    ExportEstimatedWeeklyAbsenceBalanceTotalsListResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualAbsenceBalanceTotalsFromDateToDateResponse ExportActualAbsenceBalanceTotalsFromDateToDate(
            ExportActualAbsenceBalanceTotalsFromDateToDate arg)
        {
            return Client
                .Post<ExportActualAbsenceBalanceTotalsFromDateToDate,
                    ExportActualAbsenceBalanceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualAbsenceBalanceTotalsFromDateToDateResponse>
            ExportActualAbsenceBalanceTotalsFromDateToDateAsync(
                ExportActualAbsenceBalanceTotalsFromDateToDate arg)
        {
            return Client
                .PostAsync<ExportActualAbsenceBalanceTotalsFromDateToDate,
                    ExportActualAbsenceBalanceTotalsFromDateToDateResponse>(this.username, this.password, this.baseuri,
                    "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportActualAbsenceBalanceTotalsFromRelativeDatesResponse
            ExportActualAbsenceBalanceTotalsFromRelativeDates(
                ExportActualAbsenceBalanceTotalsFromRelativeDates arg)
        {
            return Client
                .Post<ExportActualAbsenceBalanceTotalsFromRelativeDates,
                    ExportActualAbsenceBalanceTotalsFromRelativeDatesResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportActualAbsenceBalanceTotalsFromRelativeDatesResponse>
            ExportActualAbsenceBalanceTotalsFromRelativeDatesAsync(
                ExportActualAbsenceBalanceTotalsFromRelativeDates arg)
        {
            return Client
                .PostAsync<ExportActualAbsenceBalanceTotalsFromRelativeDates,
                    ExportActualAbsenceBalanceTotalsFromRelativeDatesResponse>(this.username, this.password,
                    this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportWeeklyAbsenceBalanceTotalsListResponse ExportWeeklyAbsenceBalanceTotalsList(
            ExportWeeklyAbsenceBalanceTotalsList arg)
        {
            return Client.Post<ExportWeeklyAbsenceBalanceTotalsList, ExportWeeklyAbsenceBalanceTotalsListResponse>(
                this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportWeeklyAbsenceBalanceTotalsListResponse> ExportWeeklyAbsenceBalanceTotalsListAsync(
            ExportWeeklyAbsenceBalanceTotalsList arg)
        {
            return Client.PostAsync<ExportWeeklyAbsenceBalanceTotalsList, ExportWeeklyAbsenceBalanceTotalsListResponse>(
                this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportDailyAbsenceBalanceTotalsListResponse ExportDailyAbsenceBalanceTotalsList(
            ExportDailyAbsenceBalanceTotalsList arg)
        {
            return Client.Post<ExportDailyAbsenceBalanceTotalsList, ExportDailyAbsenceBalanceTotalsListResponse>(
                this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportDailyAbsenceBalanceTotalsListResponse> ExportDailyAbsenceBalanceTotalsListAsync(
            ExportDailyAbsenceBalanceTotalsList arg)
        {
            return Client.PostAsync<ExportDailyAbsenceBalanceTotalsList, ExportDailyAbsenceBalanceTotalsListResponse>(
                this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportWeeklyAbsenceBalanceTotalsResponse ExportWeeklyAbsenceBalanceTotals(
            ExportWeeklyAbsenceBalanceTotals arg)
        {
            return Client.Post<ExportWeeklyAbsenceBalanceTotals, ExportWeeklyAbsenceBalanceTotalsResponse>(
                this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportWeeklyAbsenceBalanceTotalsResponse> ExportWeeklyAbsenceBalanceTotalsAsync(
            ExportWeeklyAbsenceBalanceTotals arg)
        {
            return Client.PostAsync<ExportWeeklyAbsenceBalanceTotals, ExportWeeklyAbsenceBalanceTotalsResponse>(
                this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public ExportPeriodicalAbsenceBalanceTotalsListResponse ExportPeriodicalAbsenceBalanceTotalsList(
            ExportPeriodicalAbsenceBalanceTotalsList arg)
        {
            return Client
                .Post<ExportPeriodicalAbsenceBalanceTotalsList, ExportPeriodicalAbsenceBalanceTotalsListResponse>(
                    this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }

        public Task<ExportPeriodicalAbsenceBalanceTotalsListResponse> ExportPeriodicalAbsenceBalanceTotalsListAsync(
            ExportPeriodicalAbsenceBalanceTotalsList arg)
        {
            return Client
                .PostAsync<ExportPeriodicalAbsenceBalanceTotalsList, ExportPeriodicalAbsenceBalanceTotalsListResponse>(
                    this.username, this.password, this.baseuri, "AbsenceBalanceTotalService", arg, this.timeoutSeconds);
        }
    }
}