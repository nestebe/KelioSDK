//.TypeServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class TypeServiceClient
    {
        private const string service = "TypeService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public TypeServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ImportOvertimeHourTypesResponse ImportOvertimeHourTypes(
            ImportOvertimeHourTypes arg)
        {
            return Client.Post<ImportOvertimeHourTypes, ImportOvertimeHourTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ImportOvertimeHourTypesResponse> ImportOvertimeHourTypesAsync(
            ImportOvertimeHourTypes arg)
        {
            return Client.PostAsync<ImportOvertimeHourTypes, ImportOvertimeHourTypesResponse>(this.username,
                this.password, this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ExportOvertimeHourTypesResponse ExportOvertimeHourTypes(
            ExportOvertimeHourTypes arg)
        {
            return Client.Post<ExportOvertimeHourTypes, ExportOvertimeHourTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ExportOvertimeHourTypesResponse> ExportOvertimeHourTypesAsync(
            ExportOvertimeHourTypes arg)
        {
            return Client.PostAsync<ExportOvertimeHourTypes, ExportOvertimeHourTypesResponse>(this.username,
                this.password, this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ExportBalanceTypesResponse ExportBalanceTypes(
            ExportBalanceTypes arg)
        {
            return Client.Post<ExportBalanceTypes, ExportBalanceTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ExportBalanceTypesResponse> ExportBalanceTypesAsync(
            ExportBalanceTypes arg)
        {
            return Client.PostAsync<ExportBalanceTypes, ExportBalanceTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ExportSpecialHourTypesResponse ExportSpecialHourTypes(
            ExportSpecialHourTypes arg)
        {
            return Client.Post<ExportSpecialHourTypes, ExportSpecialHourTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ExportSpecialHourTypesResponse> ExportSpecialHourTypesAsync(
            ExportSpecialHourTypes arg)
        {
            return Client.PostAsync<ExportSpecialHourTypes, ExportSpecialHourTypesResponse>(this.username,
                this.password, this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ImportSpecialHourTypesResponse ImportSpecialHourTypes(
            ImportSpecialHourTypes arg)
        {
            return Client.Post<ImportSpecialHourTypes, ImportSpecialHourTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ImportSpecialHourTypesResponse> ImportSpecialHourTypesAsync(
            ImportSpecialHourTypes arg)
        {
            return Client.PostAsync<ImportSpecialHourTypes, ImportSpecialHourTypesResponse>(this.username,
                this.password, this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ImportCostCentreTypesResponse ImportCostCentreTypes(
            ImportCostCentreTypes arg)
        {
            return Client.Post<ImportCostCentreTypes, ImportCostCentreTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ImportCostCentreTypesResponse> ImportCostCentreTypesAsync(
            ImportCostCentreTypes arg)
        {
            return Client.PostAsync<ImportCostCentreTypes, ImportCostCentreTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ExportLatenessEarlyDepartureTypesResponse ExportLatenessEarlyDepartureTypes(
            ExportLatenessEarlyDepartureTypes arg)
        {
            return Client.Post<ExportLatenessEarlyDepartureTypes, ExportLatenessEarlyDepartureTypesResponse>(
                this.username, this.password, this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ExportLatenessEarlyDepartureTypesResponse> ExportLatenessEarlyDepartureTypesAsync(
            ExportLatenessEarlyDepartureTypes arg)
        {
            return Client.PostAsync<ExportLatenessEarlyDepartureTypes, ExportLatenessEarlyDepartureTypesResponse>(
                this.username, this.password, this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ExportCostCentreTypesResponse ExportCostCentreTypes(
            ExportCostCentreTypes arg)
        {
            return Client.Post<ExportCostCentreTypes, ExportCostCentreTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ExportCostCentreTypesResponse> ExportCostCentreTypesAsync(
            ExportCostCentreTypes arg)
        {
            return Client.PostAsync<ExportCostCentreTypes, ExportCostCentreTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public DeleteJobTypeCostCentreTypeLinksResponse DeleteJobTypeCostCentreTypeLinks(
            DeleteJobTypeCostCentreTypeLinks arg)
        {
            return Client.Post<DeleteJobTypeCostCentreTypeLinks, DeleteJobTypeCostCentreTypeLinksResponse>(
                this.username, this.password, this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<DeleteJobTypeCostCentreTypeLinksResponse> DeleteJobTypeCostCentreTypeLinksAsync(
            DeleteJobTypeCostCentreTypeLinks arg)
        {
            return Client.PostAsync<DeleteJobTypeCostCentreTypeLinks, DeleteJobTypeCostCentreTypeLinksResponse>(
                this.username, this.password, this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ExportJobTypeCostCentreTypeLinksResponse ExportJobTypeCostCentreTypeLinks(
            ExportJobTypeCostCentreTypeLinks arg)
        {
            return Client.Post<ExportJobTypeCostCentreTypeLinks, ExportJobTypeCostCentreTypeLinksResponse>(
                this.username, this.password, this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ExportJobTypeCostCentreTypeLinksResponse> ExportJobTypeCostCentreTypeLinksAsync(
            ExportJobTypeCostCentreTypeLinks arg)
        {
            return Client.PostAsync<ExportJobTypeCostCentreTypeLinks, ExportJobTypeCostCentreTypeLinksResponse>(
                this.username, this.password, this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ImportJobTypeCostCentreTypeLinksResponse ImportJobTypeCostCentreTypeLinks(
            ImportJobTypeCostCentreTypeLinks arg)
        {
            return Client.Post<ImportJobTypeCostCentreTypeLinks, ImportJobTypeCostCentreTypeLinksResponse>(
                this.username, this.password, this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ImportJobTypeCostCentreTypeLinksResponse> ImportJobTypeCostCentreTypeLinksAsync(
            ImportJobTypeCostCentreTypeLinks arg)
        {
            return Client.PostAsync<ImportJobTypeCostCentreTypeLinks, ImportJobTypeCostCentreTypeLinksResponse>(
                this.username, this.password, this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ExportBonusTypesResponse ExportBonusTypes(ExportBonusTypes arg)
        {
            return Client.Post<ExportBonusTypes, ExportBonusTypesResponse>(this.username, this.password, this.baseuri,
                "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ExportBonusTypesResponse> ExportBonusTypesAsync(
            ExportBonusTypes arg)
        {
            return Client.PostAsync<ExportBonusTypes, ExportBonusTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ExportOnCallDutyTypesResponse ExportOnCallDutyTypes(
            ExportOnCallDutyTypes arg)
        {
            return Client.Post<ExportOnCallDutyTypes, ExportOnCallDutyTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ExportOnCallDutyTypesResponse> ExportOnCallDutyTypesAsync(
            ExportOnCallDutyTypes arg)
        {
            return Client.PostAsync<ExportOnCallDutyTypes, ExportOnCallDutyTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ExportAccountTypesResponse ExportAccountTypes(
            ExportAccountTypes arg)
        {
            return Client.Post<ExportAccountTypes, ExportAccountTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ExportAccountTypesResponse> ExportAccountTypesAsync(
            ExportAccountTypes arg)
        {
            return Client.PostAsync<ExportAccountTypes, ExportAccountTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ExportAbsenceTypesResponse ExportAbsenceTypes(
            ExportAbsenceTypes arg)
        {
            return Client.Post<ExportAbsenceTypes, ExportAbsenceTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceTypesResponse> ExportAbsenceTypesAsync(
            ExportAbsenceTypes arg)
        {
            return Client.PostAsync<ExportAbsenceTypes, ExportAbsenceTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ExportBreakTypesResponse ExportBreakTypes(ExportBreakTypes arg)
        {
            return Client.Post<ExportBreakTypes, ExportBreakTypesResponse>(this.username, this.password, this.baseuri,
                "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ExportBreakTypesResponse> ExportBreakTypesAsync(
            ExportBreakTypes arg)
        {
            return Client.PostAsync<ExportBreakTypes, ExportBreakTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ExportAbsenceBalanceTypesResponse ExportAbsenceBalanceTypes(
            ExportAbsenceBalanceTypes arg)
        {
            return Client.Post<ExportAbsenceBalanceTypes, ExportAbsenceBalanceTypesResponse>(this.username,
                this.password, this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceBalanceTypesResponse> ExportAbsenceBalanceTypesAsync(
            ExportAbsenceBalanceTypes arg)
        {
            return Client.PostAsync<ExportAbsenceBalanceTypes, ExportAbsenceBalanceTypesResponse>(this.username,
                this.password, this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ExportJobTypesResponse ExportJobTypes(ExportJobTypes arg)
        {
            return Client.Post<ExportJobTypes, ExportJobTypesResponse>(this.username, this.password, this.baseuri,
                "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ExportJobTypesResponse> ExportJobTypesAsync(
            ExportJobTypes arg)
        {
            return Client.PostAsync<ExportJobTypes, ExportJobTypesResponse>(this.username, this.password, this.baseuri,
                "TypeService", arg, this.timeoutSeconds);
        }

        public ExportCustomerTypesResponse ExportCustomerTypes(
            ExportCustomerTypes arg)
        {
            return Client.Post<ExportCustomerTypes, ExportCustomerTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ExportCustomerTypesResponse> ExportCustomerTypesAsync(
            ExportCustomerTypes arg)
        {
            return Client.PostAsync<ExportCustomerTypes, ExportCustomerTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ImportAbsenceBalanceTypesResponse ImportAbsenceBalanceTypes(
            ImportAbsenceBalanceTypes arg)
        {
            return Client.Post<ImportAbsenceBalanceTypes, ImportAbsenceBalanceTypesResponse>(this.username,
                this.password, this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ImportAbsenceBalanceTypesResponse> ImportAbsenceBalanceTypesAsync(
            ImportAbsenceBalanceTypes arg)
        {
            return Client.PostAsync<ImportAbsenceBalanceTypes, ImportAbsenceBalanceTypesResponse>(this.username,
                this.password, this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ImportCustomerTypesResponse ImportCustomerTypes(
            ImportCustomerTypes arg)
        {
            return Client.Post<ImportCustomerTypes, ImportCustomerTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ImportCustomerTypesResponse> ImportCustomerTypesAsync(
            ImportCustomerTypes arg)
        {
            return Client.PostAsync<ImportCustomerTypes, ImportCustomerTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ImportBonusTypesResponse ImportBonusTypes(ImportBonusTypes arg)
        {
            return Client.Post<ImportBonusTypes, ImportBonusTypesResponse>(this.username, this.password, this.baseuri,
                "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ImportBonusTypesResponse> ImportBonusTypesAsync(
            ImportBonusTypes arg)
        {
            return Client.PostAsync<ImportBonusTypes, ImportBonusTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ExportGenericTypesResponse ExportGenericTypes(
            ExportGenericTypes arg)
        {
            return Client.Post<ExportGenericTypes, ExportGenericTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ExportGenericTypesResponse> ExportGenericTypesAsync(
            ExportGenericTypes arg)
        {
            return Client.PostAsync<ExportGenericTypes, ExportGenericTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ImportAbsenceTypesResponse ImportAbsenceTypes(
            ImportAbsenceTypes arg)
        {
            return Client.Post<ImportAbsenceTypes, ImportAbsenceTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ImportAbsenceTypesResponse> ImportAbsenceTypesAsync(
            ImportAbsenceTypes arg)
        {
            return Client.PostAsync<ImportAbsenceTypes, ImportAbsenceTypesResponse>(this.username, this.password,
                this.baseuri, "TypeService", arg, this.timeoutSeconds);
        }

        public ImportJobTypesResponse ImportJobTypes(ImportJobTypes arg)
        {
            return Client.Post<ImportJobTypes, ImportJobTypesResponse>(this.username, this.password, this.baseuri,
                "TypeService", arg, this.timeoutSeconds);
        }

        public Task<ImportJobTypesResponse> ImportJobTypesAsync(
            ImportJobTypes arg)
        {
            return Client.PostAsync<ImportJobTypes, ImportJobTypesResponse>(this.username, this.password, this.baseuri,
                "TypeService", arg, this.timeoutSeconds);
        }
    }
}