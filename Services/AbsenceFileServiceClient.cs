//.AbsenceFileServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class AbsenceFileServiceClient
    {
        private const string service = "AbsenceFileService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public AbsenceFileServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportAbsenceFilesLimitedToAPeriodResponse ExportAbsenceFilesLimitedToAPeriod(
            ExportAbsenceFilesLimitedToAPeriod arg)
        {
            return Client.Post<ExportAbsenceFilesLimitedToAPeriod, ExportAbsenceFilesLimitedToAPeriodResponse>(
                this.username, this.password, this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceFilesLimitedToAPeriodResponse> ExportAbsenceFilesLimitedToAPeriodAsync(
            ExportAbsenceFilesLimitedToAPeriod arg)
        {
            return Client.PostAsync<ExportAbsenceFilesLimitedToAPeriod, ExportAbsenceFilesLimitedToAPeriodResponse>(
                this.username, this.password, this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public ExportAbsenceFilesAssignmentListResponse ExportAbsenceFilesAssignmentList(
            ExportAbsenceFilesAssignmentList arg)
        {
            return Client.Post<ExportAbsenceFilesAssignmentList, ExportAbsenceFilesAssignmentListResponse>(
                this.username, this.password, this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceFilesAssignmentListResponse> ExportAbsenceFilesAssignmentListAsync(
            ExportAbsenceFilesAssignmentList arg)
        {
            return Client.PostAsync<ExportAbsenceFilesAssignmentList, ExportAbsenceFilesAssignmentListResponse>(
                this.username, this.password, this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public ExportAbsenceFilesListResponse ExportAbsenceFilesList(
            ExportAbsenceFilesList arg)
        {
            return Client.Post<ExportAbsenceFilesList, ExportAbsenceFilesListResponse>(this.username, this.password,
                this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceFilesListResponse> ExportAbsenceFilesListAsync(
            ExportAbsenceFilesList arg)
        {
            return Client.PostAsync<ExportAbsenceFilesList, ExportAbsenceFilesListResponse>(this.username,
                this.password, this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public DeleteAbsenceFilesBetweenTwoDatesResponse DeleteAbsenceFilesBetweenTwoDates(
            DeleteAbsenceFilesBetweenTwoDates arg)
        {
            return Client.Post<DeleteAbsenceFilesBetweenTwoDates, DeleteAbsenceFilesBetweenTwoDatesResponse>(
                this.username, this.password, this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public Task<DeleteAbsenceFilesBetweenTwoDatesResponse> DeleteAbsenceFilesBetweenTwoDatesAsync(
            DeleteAbsenceFilesBetweenTwoDates arg)
        {
            return Client.PostAsync<DeleteAbsenceFilesBetweenTwoDates, DeleteAbsenceFilesBetweenTwoDatesResponse>(
                this.username, this.password, this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public ExportAbsencePeriodsListResponse ExportAbsencePeriodsList(
            ExportAbsencePeriodsList arg)
        {
            return Client.Post<ExportAbsencePeriodsList, ExportAbsencePeriodsListResponse>(this.username, this.password,
                this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsencePeriodsListResponse> ExportAbsencePeriodsListAsync(
            ExportAbsencePeriodsList arg)
        {
            return Client.PostAsync<ExportAbsencePeriodsList, ExportAbsencePeriodsListResponse>(this.username,
                this.password, this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public ImportAbsenceFilesResponse ImportAbsenceFiles(
            ImportAbsenceFiles arg)
        {
            return Client.Post<ImportAbsenceFiles, ImportAbsenceFilesResponse>(this.username, this.password,
                this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public Task<ImportAbsenceFilesResponse> ImportAbsenceFilesAsync(
            ImportAbsenceFiles arg)
        {
            return Client.PostAsync<ImportAbsenceFiles, ImportAbsenceFilesResponse>(this.username, this.password,
                this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public DeleteAbsenceFilesResponse DeleteAbsenceFiles(
            DeleteAbsenceFiles arg)
        {
            return Client.Post<DeleteAbsenceFiles, DeleteAbsenceFilesResponse>(this.username, this.password,
                this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public Task<DeleteAbsenceFilesResponse> DeleteAbsenceFilesAsync(
            DeleteAbsenceFiles arg)
        {
            return Client.PostAsync<DeleteAbsenceFiles, DeleteAbsenceFilesResponse>(this.username, this.password,
                this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public ExportAbsencePeriodsResponse ExportAbsencePeriods(
            ExportAbsencePeriods arg)
        {
            return Client.Post<ExportAbsencePeriods, ExportAbsencePeriodsResponse>(this.username, this.password,
                this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsencePeriodsResponse> ExportAbsencePeriodsAsync(
            ExportAbsencePeriods arg)
        {
            return Client.PostAsync<ExportAbsencePeriods, ExportAbsencePeriodsResponse>(this.username, this.password,
                this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public ExportAbsencePeriodsFromEmployeeListResponse ExportAbsencePeriodsFromEmployeeList(
            ExportAbsencePeriodsFromEmployeeList arg)
        {
            return Client.Post<ExportAbsencePeriodsFromEmployeeList, ExportAbsencePeriodsFromEmployeeListResponse>(
                this.username, this.password, this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsencePeriodsFromEmployeeListResponse> ExportAbsencePeriodsFromEmployeeListAsync(
            ExportAbsencePeriodsFromEmployeeList arg)
        {
            return Client.PostAsync<ExportAbsencePeriodsFromEmployeeList, ExportAbsencePeriodsFromEmployeeListResponse>(
                this.username, this.password, this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public ExportAbsenceFilesResponse ExportAbsenceFiles(
            ExportAbsenceFiles arg)
        {
            return Client.Post<ExportAbsenceFiles, ExportAbsenceFilesResponse>(this.username, this.password,
                this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceFilesResponse> ExportAbsenceFilesAsync(
            ExportAbsenceFiles arg)
        {
            return Client.PostAsync<ExportAbsenceFiles, ExportAbsenceFilesResponse>(this.username, this.password,
                this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public ExportAbsenceFilesFromEmployeeListResponse ExportAbsenceFilesFromEmployeeList(
            ExportAbsenceFilesFromEmployeeList arg)
        {
            return Client.Post<ExportAbsenceFilesFromEmployeeList, ExportAbsenceFilesFromEmployeeListResponse>(
                this.username, this.password, this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceFilesFromEmployeeListResponse> ExportAbsenceFilesFromEmployeeListAsync(
            ExportAbsenceFilesFromEmployeeList arg)
        {
            return Client.PostAsync<ExportAbsenceFilesFromEmployeeList, ExportAbsenceFilesFromEmployeeListResponse>(
                this.username, this.password, this.baseuri, "AbsenceFileService", arg, this.timeoutSeconds);
        }
    }
}