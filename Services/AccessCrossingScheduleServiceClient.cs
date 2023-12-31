﻿//.AccessCrossingScheduleServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class AccessCrossingScheduleServiceClient
    {
        private const string service = "AccessCrossingScheduleService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public AccessCrossingScheduleServiceClient(string username, string password, string baseuri,
            int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ImportAccessDailyCrossingSchedulesResponse ImportAccessDailyCrossingSchedules(
            ImportAccessDailyCrossingSchedules arg)
        {
            return Client.Post<ImportAccessDailyCrossingSchedules, ImportAccessDailyCrossingSchedulesResponse>(
                this.username, this.password, this.baseuri, "AccessCrossingScheduleService", arg, this.timeoutSeconds);
        }

        public Task<ImportAccessDailyCrossingSchedulesResponse> ImportAccessDailyCrossingSchedulesAsync(
            ImportAccessDailyCrossingSchedules arg)
        {
            return Client.PostAsync<ImportAccessDailyCrossingSchedules, ImportAccessDailyCrossingSchedulesResponse>(
                this.username, this.password, this.baseuri, "AccessCrossingScheduleService", arg, this.timeoutSeconds);
        }

        public ImportAccessAnnualCrossingSchedulesResponse ImportAccessAnnualCrossingSchedules(
            ImportAccessAnnualCrossingSchedules arg)
        {
            return Client.Post<ImportAccessAnnualCrossingSchedules, ImportAccessAnnualCrossingSchedulesResponse>(
                this.username, this.password, this.baseuri, "AccessCrossingScheduleService", arg, this.timeoutSeconds);
        }

        public Task<ImportAccessAnnualCrossingSchedulesResponse> ImportAccessAnnualCrossingSchedulesAsync(
            ImportAccessAnnualCrossingSchedules arg)
        {
            return Client.PostAsync<ImportAccessAnnualCrossingSchedules, ImportAccessAnnualCrossingSchedulesResponse>(
                this.username, this.password, this.baseuri, "AccessCrossingScheduleService", arg, this.timeoutSeconds);
        }

        public ImportAccessWeeklyCrossingSchedulesResponse ImportAccessWeeklyCrossingSchedules(
            ImportAccessWeeklyCrossingSchedules arg)
        {
            return Client.Post<ImportAccessWeeklyCrossingSchedules, ImportAccessWeeklyCrossingSchedulesResponse>(
                this.username, this.password, this.baseuri, "AccessCrossingScheduleService", arg, this.timeoutSeconds);
        }

        public Task<ImportAccessWeeklyCrossingSchedulesResponse> ImportAccessWeeklyCrossingSchedulesAsync(
            ImportAccessWeeklyCrossingSchedules arg)
        {
            return Client.PostAsync<ImportAccessWeeklyCrossingSchedules, ImportAccessWeeklyCrossingSchedulesResponse>(
                this.username, this.password, this.baseuri, "AccessCrossingScheduleService", arg, this.timeoutSeconds);
        }

        public ExportAccessAnnualCrossingSchedulesResponse ExportAccessAnnualCrossingSchedules(
            ExportAccessAnnualCrossingSchedules arg)
        {
            return Client.Post<ExportAccessAnnualCrossingSchedules, ExportAccessAnnualCrossingSchedulesResponse>(
                this.username, this.password, this.baseuri, "AccessCrossingScheduleService", arg, this.timeoutSeconds);
        }

        public Task<ExportAccessAnnualCrossingSchedulesResponse> ExportAccessAnnualCrossingSchedulesAsync(
            ExportAccessAnnualCrossingSchedules arg)
        {
            return Client.PostAsync<ExportAccessAnnualCrossingSchedules, ExportAccessAnnualCrossingSchedulesResponse>(
                this.username, this.password, this.baseuri, "AccessCrossingScheduleService", arg, this.timeoutSeconds);
        }
    }
}