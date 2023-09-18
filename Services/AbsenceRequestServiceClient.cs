//.AbsenceRequestServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class AbsenceRequestServiceClient
    {
        private const string service = "AbsenceRequestService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public AbsenceRequestServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportAbsenceRequestsListResponse ExportAbsenceRequestsList(
            ExportAbsenceRequestsList arg)
        {
            return Client.Post<ExportAbsenceRequestsList, ExportAbsenceRequestsListResponse>(this.username,
                this.password, this.baseuri, "AbsenceRequestService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceRequestsListResponse> ExportAbsenceRequestsListAsync(
            ExportAbsenceRequestsList arg)
        {
            return Client.PostAsync<ExportAbsenceRequestsList, ExportAbsenceRequestsListResponse>(this.username,
                this.password, this.baseuri, "AbsenceRequestService", arg, this.timeoutSeconds);
        }

        public ExportAbsenceRequestsLimitedToAPeriodListResponse ExportAbsenceRequestsLimitedToAPeriodList(
            ExportAbsenceRequestsLimitedToAPeriodList arg)
        {
            return Client
                .Post<ExportAbsenceRequestsLimitedToAPeriodList, ExportAbsenceRequestsLimitedToAPeriodListResponse>(
                    this.username, this.password, this.baseuri, "AbsenceRequestService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceRequestsLimitedToAPeriodListResponse> ExportAbsenceRequestsLimitedToAPeriodListAsync(
            ExportAbsenceRequestsLimitedToAPeriodList arg)
        {
            return Client
                .PostAsync<ExportAbsenceRequestsLimitedToAPeriodList,
                    ExportAbsenceRequestsLimitedToAPeriodListResponse>(this.username, this.password, this.baseuri,
                    "AbsenceRequestService", arg, this.timeoutSeconds);
        }

        public ExportAbsenceRequestPeriodsResponse ExportAbsenceRequestPeriods(
            ExportAbsenceRequestPeriods arg)
        {
            return Client.Post<ExportAbsenceRequestPeriods, ExportAbsenceRequestPeriodsResponse>(this.username,
                this.password, this.baseuri, "AbsenceRequestService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceRequestPeriodsResponse> ExportAbsenceRequestPeriodsAsync(
            ExportAbsenceRequestPeriods arg)
        {
            return Client.PostAsync<ExportAbsenceRequestPeriods, ExportAbsenceRequestPeriodsResponse>(this.username,
                this.password, this.baseuri, "AbsenceRequestService", arg, this.timeoutSeconds);
        }

        public ExportAbsenceRequestPeriodsFromEmployeeListResponse ExportAbsenceRequestPeriodsFromEmployeeList(
            ExportAbsenceRequestPeriodsFromEmployeeList arg)
        {
            return Client
                .Post<ExportAbsenceRequestPeriodsFromEmployeeList, ExportAbsenceRequestPeriodsFromEmployeeListResponse>(
                    this.username, this.password, this.baseuri, "AbsenceRequestService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceRequestPeriodsFromEmployeeListResponse>
            ExportAbsenceRequestPeriodsFromEmployeeListAsync(
                ExportAbsenceRequestPeriodsFromEmployeeList arg)
        {
            return Client
                .PostAsync<ExportAbsenceRequestPeriodsFromEmployeeList,
                    ExportAbsenceRequestPeriodsFromEmployeeListResponse>(this.username, this.password, this.baseuri,
                    "AbsenceRequestService", arg, this.timeoutSeconds);
        }

        public ExportAbsenceRequestsLimitedToAPeriodFromEmployeeListResponse
            ExportAbsenceRequestsLimitedToAPeriodFromEmployeeList(
                ExportAbsenceRequestsLimitedToAPeriodFromEmployeeList arg)
        {
            return Client
                .Post<ExportAbsenceRequestsLimitedToAPeriodFromEmployeeList,
                    ExportAbsenceRequestsLimitedToAPeriodFromEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceRequestService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceRequestsLimitedToAPeriodFromEmployeeListResponse>
            ExportAbsenceRequestsLimitedToAPeriodFromEmployeeListAsync(
                ExportAbsenceRequestsLimitedToAPeriodFromEmployeeList arg)
        {
            return Client
                .PostAsync<ExportAbsenceRequestsLimitedToAPeriodFromEmployeeList,
                    ExportAbsenceRequestsLimitedToAPeriodFromEmployeeListResponse>(this.username, this.password,
                    this.baseuri, "AbsenceRequestService", arg, this.timeoutSeconds);
        }

        public ExportAbsenceRequestsLimitedToAPeriodResponse ExportAbsenceRequestsLimitedToAPeriod(
            ExportAbsenceRequestsLimitedToAPeriod arg)
        {
            return Client.Post<ExportAbsenceRequestsLimitedToAPeriod, ExportAbsenceRequestsLimitedToAPeriodResponse>(
                this.username, this.password, this.baseuri, "AbsenceRequestService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceRequestsLimitedToAPeriodResponse> ExportAbsenceRequestsLimitedToAPeriodAsync(
            ExportAbsenceRequestsLimitedToAPeriod arg)
        {
            return Client
                .PostAsync<ExportAbsenceRequestsLimitedToAPeriod, ExportAbsenceRequestsLimitedToAPeriodResponse>(
                    this.username, this.password, this.baseuri, "AbsenceRequestService", arg, this.timeoutSeconds);
        }

        public ExportAbsenceRequestPeriodsListResponse ExportAbsenceRequestPeriodsList(
            ExportAbsenceRequestPeriodsList arg)
        {
            return Client.Post<ExportAbsenceRequestPeriodsList, ExportAbsenceRequestPeriodsListResponse>(this.username,
                this.password, this.baseuri, "AbsenceRequestService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceRequestPeriodsListResponse> ExportAbsenceRequestPeriodsListAsync(
            ExportAbsenceRequestPeriodsList arg)
        {
            return Client.PostAsync<ExportAbsenceRequestPeriodsList, ExportAbsenceRequestPeriodsListResponse>(
                this.username, this.password, this.baseuri, "AbsenceRequestService", arg, this.timeoutSeconds);
        }

        public ExportAbsenceRequestsFromEmployeeListResponse ExportAbsenceRequestsFromEmployeeList(
            ExportAbsenceRequestsFromEmployeeList arg)
        {
            return Client.Post<ExportAbsenceRequestsFromEmployeeList, ExportAbsenceRequestsFromEmployeeListResponse>(
                this.username, this.password, this.baseuri, "AbsenceRequestService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceRequestsFromEmployeeListResponse> ExportAbsenceRequestsFromEmployeeListAsync(
            ExportAbsenceRequestsFromEmployeeList arg)
        {
            return Client
                .PostAsync<ExportAbsenceRequestsFromEmployeeList, ExportAbsenceRequestsFromEmployeeListResponse>(
                    this.username, this.password, this.baseuri, "AbsenceRequestService", arg, this.timeoutSeconds);
        }

        public ExportAbsenceRequestsResponse ExportAbsenceRequests(
            ExportAbsenceRequests arg)
        {
            return Client.Post<ExportAbsenceRequests, ExportAbsenceRequestsResponse>(this.username, this.password,
                this.baseuri, "AbsenceRequestService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceRequestsResponse> ExportAbsenceRequestsAsync(
            ExportAbsenceRequests arg)
        {
            return Client.PostAsync<ExportAbsenceRequests, ExportAbsenceRequestsResponse>(this.username, this.password,
                this.baseuri, "AbsenceRequestService", arg, this.timeoutSeconds);
        }
    }
}