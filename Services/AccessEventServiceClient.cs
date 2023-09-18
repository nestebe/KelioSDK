//.AccessEventServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class AccessEventServiceClient
    {
        private const string service = "AccessEventService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public AccessEventServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportAccessEventsFromDateToDateForListResponse ExportAccessEventsFromDateToDateForList(
            ExportAccessEventsFromDateToDateForList arg)
        {
            return Client
                .Post<ExportAccessEventsFromDateToDateForList, ExportAccessEventsFromDateToDateForListResponse>(
                    this.username, this.password, this.baseuri, "AccessEventService", arg, this.timeoutSeconds);
        }

        public Task<ExportAccessEventsFromDateToDateForListResponse> ExportAccessEventsFromDateToDateForListAsync(
            ExportAccessEventsFromDateToDateForList arg)
        {
            return Client
                .PostAsync<ExportAccessEventsFromDateToDateForList, ExportAccessEventsFromDateToDateForListResponse>(
                    this.username, this.password, this.baseuri, "AccessEventService", arg, this.timeoutSeconds);
        }

        public ExportAccessEventsFromRelativeDatesForListResponse ExportAccessEventsFromRelativeDatesForList(
            ExportAccessEventsFromRelativeDatesForList arg)
        {
            return Client
                .Post<ExportAccessEventsFromRelativeDatesForList, ExportAccessEventsFromRelativeDatesForListResponse>(
                    this.username, this.password, this.baseuri, "AccessEventService", arg, this.timeoutSeconds);
        }

        public Task<ExportAccessEventsFromRelativeDatesForListResponse> ExportAccessEventsFromRelativeDatesForListAsync(
            ExportAccessEventsFromRelativeDatesForList arg)
        {
            return Client
                .PostAsync<ExportAccessEventsFromRelativeDatesForList,
                    ExportAccessEventsFromRelativeDatesForListResponse>(this.username, this.password, this.baseuri,
                    "AccessEventService", arg, this.timeoutSeconds);
        }

        public ExportAccessEventsResponse ExportAccessEvents(
            ExportAccessEvents arg)
        {
            return Client.Post<ExportAccessEvents, ExportAccessEventsResponse>(this.username, this.password,
                this.baseuri, "AccessEventService", arg, this.timeoutSeconds);
        }

        public Task<ExportAccessEventsResponse> ExportAccessEventsAsync(
            ExportAccessEvents arg)
        {
            return Client.PostAsync<ExportAccessEvents, ExportAccessEventsResponse>(this.username, this.password,
                this.baseuri, "AccessEventService", arg, this.timeoutSeconds);
        }

        public ExportAccessEventsFromDateToDateResponse ExportAccessEventsFromDateToDate(
            ExportAccessEventsFromDateToDate arg)
        {
            return Client.Post<ExportAccessEventsFromDateToDate, ExportAccessEventsFromDateToDateResponse>(
                this.username, this.password, this.baseuri, "AccessEventService", arg, this.timeoutSeconds);
        }

        public Task<ExportAccessEventsFromDateToDateResponse> ExportAccessEventsFromDateToDateAsync(
            ExportAccessEventsFromDateToDate arg)
        {
            return Client.PostAsync<ExportAccessEventsFromDateToDate, ExportAccessEventsFromDateToDateResponse>(
                this.username, this.password, this.baseuri, "AccessEventService", arg, this.timeoutSeconds);
        }

        public ExportAccessEventsFromRelativeDatesResponse ExportAccessEventsFromRelativeDates(
            ExportAccessEventsFromRelativeDates arg)
        {
            return Client.Post<ExportAccessEventsFromRelativeDates, ExportAccessEventsFromRelativeDatesResponse>(
                this.username, this.password, this.baseuri, "AccessEventService", arg, this.timeoutSeconds);
        }

        public Task<ExportAccessEventsFromRelativeDatesResponse> ExportAccessEventsFromRelativeDatesAsync(
            ExportAccessEventsFromRelativeDates arg)
        {
            return Client.PostAsync<ExportAccessEventsFromRelativeDates, ExportAccessEventsFromRelativeDatesResponse>(
                this.username, this.password, this.baseuri, "AccessEventService", arg, this.timeoutSeconds);
        }
    }
}