//.FilingServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class FilingServiceClient
    {
        private const string service = "FilingService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public FilingServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportSpecialHourFilingResponse ExportSpecialHourFiling(
            ExportSpecialHourFiling arg)
        {
            return Client.Post<ExportSpecialHourFiling, ExportSpecialHourFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportSpecialHourFilingResponse> ExportSpecialHourFilingAsync(
            ExportSpecialHourFiling arg)
        {
            return Client.PostAsync<ExportSpecialHourFiling, ExportSpecialHourFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportOnCallDutyFilingResponse ExportOnCallDutyFiling(
            ExportOnCallDutyFiling arg)
        {
            return Client.Post<ExportOnCallDutyFiling, ExportOnCallDutyFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportOnCallDutyFilingResponse> ExportOnCallDutyFilingAsync(
            ExportOnCallDutyFiling arg)
        {
            return Client.PostAsync<ExportOnCallDutyFiling, ExportOnCallDutyFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportCostCenterFilingResponse ExportCostCenterFiling(
            ExportCostCenterFiling arg)
        {
            return Client.Post<ExportCostCenterFiling, ExportCostCenterFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportCostCenterFilingResponse> ExportCostCenterFilingAsync(
            ExportCostCenterFiling arg)
        {
            return Client.PostAsync<ExportCostCenterFiling, ExportCostCenterFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportDailyScheduleFilingResponse ExportDailyScheduleFiling(
            ExportDailyScheduleFiling arg)
        {
            return Client.Post<ExportDailyScheduleFiling, ExportDailyScheduleFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportDailyScheduleFilingResponse> ExportDailyScheduleFilingAsync(
            ExportDailyScheduleFiling arg)
        {
            return Client.PostAsync<ExportDailyScheduleFiling, ExportDailyScheduleFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportCalculationSetupFilingResponse ExportCalculationSetupFiling(
            ExportCalculationSetupFiling arg)
        {
            return Client.Post<ExportCalculationSetupFiling, ExportCalculationSetupFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportCalculationSetupFilingResponse> ExportCalculationSetupFilingAsync(
            ExportCalculationSetupFiling arg)
        {
            return Client.PostAsync<ExportCalculationSetupFiling, ExportCalculationSetupFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportCustomizedReportFilingResponse ExportCustomizedReportFiling(
            ExportCustomizedReportFiling arg)
        {
            return Client.Post<ExportCustomizedReportFiling, ExportCustomizedReportFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportCustomizedReportFilingResponse> ExportCustomizedReportFilingAsync(
            ExportCustomizedReportFiling arg)
        {
            return Client.PostAsync<ExportCustomizedReportFiling, ExportCustomizedReportFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportCustomizableFieldFilingResponse ExportCustomizableFieldFiling(
            ExportCustomizableFieldFiling arg)
        {
            return Client.Post<ExportCustomizableFieldFiling, ExportCustomizableFieldFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportCustomizableFieldFilingResponse> ExportCustomizableFieldFilingAsync(
            ExportCustomizableFieldFiling arg)
        {
            return Client.PostAsync<ExportCustomizableFieldFiling, ExportCustomizableFieldFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportBodetAppsFilingResponse ExportBodetAppsFiling(
            ExportBodetAppsFiling arg)
        {
            return Client.Post<ExportBodetAppsFiling, ExportBodetAppsFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportBodetAppsFilingResponse> ExportBodetAppsFilingAsync(
            ExportBodetAppsFiling arg)
        {
            return Client.PostAsync<ExportBodetAppsFiling, ExportBodetAppsFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportHourlyContractsFilingResponse ExportHourlyContractsFiling(
            ExportHourlyContractsFiling arg)
        {
            return Client.Post<ExportHourlyContractsFiling, ExportHourlyContractsFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportHourlyContractsFilingResponse> ExportHourlyContractsFilingAsync(
            ExportHourlyContractsFiling arg)
        {
            return Client.PostAsync<ExportHourlyContractsFiling, ExportHourlyContractsFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportAutomaticScheduleFilingResponse ExportAutomaticScheduleFiling(
            ExportAutomaticScheduleFiling arg)
        {
            return Client.Post<ExportAutomaticScheduleFiling, ExportAutomaticScheduleFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportAutomaticScheduleFilingResponse> ExportAutomaticScheduleFilingAsync(
            ExportAutomaticScheduleFiling arg)
        {
            return Client.PostAsync<ExportAutomaticScheduleFiling, ExportAutomaticScheduleFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportSchoolHolidaysFilingResponse ExportSchoolHolidaysFiling(
            ExportSchoolHolidaysFiling arg)
        {
            return Client.Post<ExportSchoolHolidaysFiling, ExportSchoolHolidaysFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportSchoolHolidaysFilingResponse> ExportSchoolHolidaysFilingAsync(
            ExportSchoolHolidaysFiling arg)
        {
            return Client.PostAsync<ExportSchoolHolidaysFiling, ExportSchoolHolidaysFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportScheduleContractFilingResponse ExportScheduleContractFiling(
            ExportScheduleContractFiling arg)
        {
            return Client.Post<ExportScheduleContractFiling, ExportScheduleContractFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportScheduleContractFilingResponse> ExportScheduleContractFilingAsync(
            ExportScheduleContractFiling arg)
        {
            return Client.PostAsync<ExportScheduleContractFiling, ExportScheduleContractFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteTransferFileAccountFilingResponse DeleteTransferFileAccountFiling(
            DeleteTransferFileAccountFiling arg)
        {
            return Client.Post<DeleteTransferFileAccountFiling, DeleteTransferFileAccountFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteTransferFileAccountFilingResponse> DeleteTransferFileAccountFilingAsync(
            DeleteTransferFileAccountFiling arg)
        {
            return Client.PostAsync<DeleteTransferFileAccountFiling, DeleteTransferFileAccountFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportValueCustomizableFieldFilingResponse ExportValueCustomizableFieldFiling(
            ExportValueCustomizableFieldFiling arg)
        {
            return Client.Post<ExportValueCustomizableFieldFiling, ExportValueCustomizableFieldFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportValueCustomizableFieldFilingResponse> ExportValueCustomizableFieldFilingAsync(
            ExportValueCustomizableFieldFiling arg)
        {
            return Client.PostAsync<ExportValueCustomizableFieldFiling, ExportValueCustomizableFieldFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteOvertimeHourFilingResponse DeleteOvertimeHourFiling(
            DeleteOvertimeHourFiling arg)
        {
            return Client.Post<DeleteOvertimeHourFiling, DeleteOvertimeHourFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteOvertimeHourFilingResponse> DeleteOvertimeHourFilingAsync(
            DeleteOvertimeHourFiling arg)
        {
            return Client.PostAsync<DeleteOvertimeHourFiling, DeleteOvertimeHourFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteSchoolHolidaysCalendarFilingResponse DeleteSchoolHolidaysCalendarFiling(
            DeleteSchoolHolidaysCalendarFiling arg)
        {
            return Client.Post<DeleteSchoolHolidaysCalendarFiling, DeleteSchoolHolidaysCalendarFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteSchoolHolidaysCalendarFilingResponse> DeleteSchoolHolidaysCalendarFilingAsync(
            DeleteSchoolHolidaysCalendarFiling arg)
        {
            return Client.PostAsync<DeleteSchoolHolidaysCalendarFiling, DeleteSchoolHolidaysCalendarFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportScheduleContractFilingResponse ImportScheduleContractFiling(
            ImportScheduleContractFiling arg)
        {
            return Client.Post<ImportScheduleContractFiling, ImportScheduleContractFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportScheduleContractFilingResponse> ImportScheduleContractFilingAsync(
            ImportScheduleContractFiling arg)
        {
            return Client.PostAsync<ImportScheduleContractFiling, ImportScheduleContractFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportValueCustomizableFieldFilingResponse ImportValueCustomizableFieldFiling(
            ImportValueCustomizableFieldFiling arg)
        {
            return Client.Post<ImportValueCustomizableFieldFiling, ImportValueCustomizableFieldFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportValueCustomizableFieldFilingResponse> ImportValueCustomizableFieldFilingAsync(
            ImportValueCustomizableFieldFiling arg)
        {
            return Client.PostAsync<ImportValueCustomizableFieldFiling, ImportValueCustomizableFieldFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteScheduleContractFilingResponse DeleteScheduleContractFiling(
            DeleteScheduleContractFiling arg)
        {
            return Client.Post<DeleteScheduleContractFiling, DeleteScheduleContractFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteScheduleContractFilingResponse> DeleteScheduleContractFilingAsync(
            DeleteScheduleContractFiling arg)
        {
            return Client.PostAsync<DeleteScheduleContractFiling, DeleteScheduleContractFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportOvertimeHourFilingResponse ExportOvertimeHourFiling(
            ExportOvertimeHourFiling arg)
        {
            return Client.Post<ExportOvertimeHourFiling, ExportOvertimeHourFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportOvertimeHourFilingResponse> ExportOvertimeHourFilingAsync(
            ExportOvertimeHourFiling arg)
        {
            return Client.PostAsync<ExportOvertimeHourFiling, ExportOvertimeHourFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteCustomizableFieldFilingResponse DeleteCustomizableFieldFiling(
            DeleteCustomizableFieldFiling arg)
        {
            return Client.Post<DeleteCustomizableFieldFiling, DeleteCustomizableFieldFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteCustomizableFieldFilingResponse> DeleteCustomizableFieldFilingAsync(
            DeleteCustomizableFieldFiling arg)
        {
            return Client.PostAsync<DeleteCustomizableFieldFiling, DeleteCustomizableFieldFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteValueCustomizableFieldFilingResponse DeleteValueCustomizableFieldFiling(
            DeleteValueCustomizableFieldFiling arg)
        {
            return Client.Post<DeleteValueCustomizableFieldFiling, DeleteValueCustomizableFieldFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteValueCustomizableFieldFilingResponse> DeleteValueCustomizableFieldFilingAsync(
            DeleteValueCustomizableFieldFiling arg)
        {
            return Client.PostAsync<DeleteValueCustomizableFieldFiling, DeleteValueCustomizableFieldFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteToilCalendarFilingResponse DeleteToilCalendarFiling(
            DeleteToilCalendarFiling arg)
        {
            return Client.Post<DeleteToilCalendarFiling, DeleteToilCalendarFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteToilCalendarFilingResponse> DeleteToilCalendarFilingAsync(
            DeleteToilCalendarFiling arg)
        {
            return Client.PostAsync<DeleteToilCalendarFiling, DeleteToilCalendarFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportSchoolHolidaysFilingResponse ImportSchoolHolidaysFiling(
            ImportSchoolHolidaysFiling arg)
        {
            return Client.Post<ImportSchoolHolidaysFiling, ImportSchoolHolidaysFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportSchoolHolidaysFilingResponse> ImportSchoolHolidaysFilingAsync(
            ImportSchoolHolidaysFiling arg)
        {
            return Client.PostAsync<ImportSchoolHolidaysFiling, ImportSchoolHolidaysFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportOvertimeHourFilingResponse ImportOvertimeHourFiling(
            ImportOvertimeHourFiling arg)
        {
            return Client.Post<ImportOvertimeHourFiling, ImportOvertimeHourFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportOvertimeHourFilingResponse> ImportOvertimeHourFilingAsync(
            ImportOvertimeHourFiling arg)
        {
            return Client.PostAsync<ImportOvertimeHourFiling, ImportOvertimeHourFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportFilingResponse ExportFiling(ExportFiling arg)
        {
            return Client.Post<ExportFiling, ExportFilingResponse>(this.username, this.password, this.baseuri,
                "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportFilingResponse> ExportFilingAsync(ExportFiling arg)
        {
            return Client.PostAsync<ExportFiling, ExportFilingResponse>(this.username, this.password, this.baseuri,
                "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteFilingResponse DeleteFiling(DeleteFiling arg)
        {
            return Client.Post<DeleteFiling, DeleteFilingResponse>(this.username, this.password, this.baseuri,
                "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteFilingResponse> DeleteFilingAsync(DeleteFiling arg)
        {
            return Client.PostAsync<DeleteFiling, DeleteFilingResponse>(this.username, this.password, this.baseuri,
                "FilingService", arg, this.timeoutSeconds);
        }

        public ImportFilingResponse ImportFiling(ImportFiling arg)
        {
            return Client.Post<ImportFiling, ImportFilingResponse>(this.username, this.password, this.baseuri,
                "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportFilingResponse> ImportFilingAsync(ImportFiling arg)
        {
            return Client.PostAsync<ImportFiling, ImportFilingResponse>(this.username, this.password, this.baseuri,
                "FilingService", arg, this.timeoutSeconds);
        }

        public ExportScheduleFilingResponse ExportScheduleFiling(
            ExportScheduleFiling arg)
        {
            return Client.Post<ExportScheduleFiling, ExportScheduleFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportScheduleFilingResponse> ExportScheduleFilingAsync(
            ExportScheduleFiling arg)
        {
            return Client.PostAsync<ExportScheduleFiling, ExportScheduleFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportBonusFilingResponse ImportBonusFiling(
            ImportBonusFiling arg)
        {
            return Client.Post<ImportBonusFiling, ImportBonusFilingResponse>(this.username, this.password, this.baseuri,
                "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportBonusFilingResponse> ImportBonusFilingAsync(
            ImportBonusFiling arg)
        {
            return Client.PostAsync<ImportBonusFiling, ImportBonusFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportAbsenceBalanceFilingResponse ImportAbsenceBalanceFiling(
            ImportAbsenceBalanceFiling arg)
        {
            return Client.Post<ImportAbsenceBalanceFiling, ImportAbsenceBalanceFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportAbsenceBalanceFilingResponse> ImportAbsenceBalanceFilingAsync(
            ImportAbsenceBalanceFiling arg)
        {
            return Client.PostAsync<ImportAbsenceBalanceFiling, ImportAbsenceBalanceFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportEmployeeGroupFilingResponse ExportEmployeeGroupFiling(
            ExportEmployeeGroupFiling arg)
        {
            return Client.Post<ExportEmployeeGroupFiling, ExportEmployeeGroupFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportEmployeeGroupFilingResponse> ExportEmployeeGroupFilingAsync(
            ExportEmployeeGroupFiling arg)
        {
            return Client.PostAsync<ExportEmployeeGroupFiling, ExportEmployeeGroupFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportHomepageFilingResponse ExportHomepageFiling(
            ExportHomepageFiling arg)
        {
            return Client.Post<ExportHomepageFiling, ExportHomepageFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportHomepageFilingResponse> ExportHomepageFilingAsync(
            ExportHomepageFiling arg)
        {
            return Client.PostAsync<ExportHomepageFiling, ExportHomepageFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportAbsenceFilingResponse ImportAbsenceFiling(
            ImportAbsenceFiling arg)
        {
            return Client.Post<ImportAbsenceFiling, ImportAbsenceFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportAbsenceFilingResponse> ImportAbsenceFilingAsync(
            ImportAbsenceFiling arg)
        {
            return Client.PostAsync<ImportAbsenceFiling, ImportAbsenceFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportScheduleFilingResponse ImportScheduleFiling(
            ImportScheduleFiling arg)
        {
            return Client.Post<ImportScheduleFiling, ImportScheduleFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportScheduleFilingResponse> ImportScheduleFilingAsync(
            ImportScheduleFiling arg)
        {
            return Client.PostAsync<ImportScheduleFiling, ImportScheduleFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportActivityFilingResponse ImportActivityFiling(
            ImportActivityFiling arg)
        {
            return Client.Post<ImportActivityFiling, ImportActivityFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportActivityFilingResponse> ImportActivityFilingAsync(
            ImportActivityFiling arg)
        {
            return Client.PostAsync<ImportActivityFiling, ImportActivityFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportProfileFilingResponse ImportProfileFiling(
            ImportProfileFiling arg)
        {
            return Client.Post<ImportProfileFiling, ImportProfileFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportProfileFilingResponse> ImportProfileFilingAsync(
            ImportProfileFiling arg)
        {
            return Client.PostAsync<ImportProfileFiling, ImportProfileFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportProfileFilingResponse ExportProfileFiling(
            ExportProfileFiling arg)
        {
            return Client.Post<ExportProfileFiling, ExportProfileFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportProfileFilingResponse> ExportProfileFilingAsync(
            ExportProfileFiling arg)
        {
            return Client.PostAsync<ExportProfileFiling, ExportProfileFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportAbsenceFilingResponse ExportAbsenceFiling(
            ExportAbsenceFiling arg)
        {
            return Client.Post<ExportAbsenceFiling, ExportAbsenceFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceFilingResponse> ExportAbsenceFilingAsync(
            ExportAbsenceFiling arg)
        {
            return Client.PostAsync<ExportAbsenceFiling, ExportAbsenceFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportBonusFilingResponse ExportBonusFiling(
            ExportBonusFiling arg)
        {
            return Client.Post<ExportBonusFiling, ExportBonusFilingResponse>(this.username, this.password, this.baseuri,
                "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportBonusFilingResponse> ExportBonusFilingAsync(
            ExportBonusFiling arg)
        {
            return Client.PostAsync<ExportBonusFiling, ExportBonusFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportActivityFilingResponse ExportActivityFiling(
            ExportActivityFiling arg)
        {
            return Client.Post<ExportActivityFiling, ExportActivityFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportActivityFilingResponse> ExportActivityFilingAsync(
            ExportActivityFiling arg)
        {
            return Client.PostAsync<ExportActivityFiling, ExportActivityFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportAbsenceBalanceFilingResponse ExportAbsenceBalanceFiling(
            ExportAbsenceBalanceFiling arg)
        {
            return Client.Post<ExportAbsenceBalanceFiling, ExportAbsenceBalanceFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportAbsenceBalanceFilingResponse> ExportAbsenceBalanceFilingAsync(
            ExportAbsenceBalanceFiling arg)
        {
            return Client.PostAsync<ExportAbsenceBalanceFiling, ExportAbsenceBalanceFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportCustomizedReportFilingResponse ImportCustomizedReportFiling(
            ImportCustomizedReportFiling arg)
        {
            return Client.Post<ImportCustomizedReportFiling, ImportCustomizedReportFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportCustomizedReportFilingResponse> ImportCustomizedReportFilingAsync(
            ImportCustomizedReportFiling arg)
        {
            return Client.PostAsync<ImportCustomizedReportFiling, ImportCustomizedReportFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportTransferFileTemplateFilingResponse ExportTransferFileTemplateFiling(
            ExportTransferFileTemplateFiling arg)
        {
            return Client.Post<ExportTransferFileTemplateFiling, ExportTransferFileTemplateFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportTransferFileTemplateFilingResponse> ExportTransferFileTemplateFilingAsync(
            ExportTransferFileTemplateFiling arg)
        {
            return Client.PostAsync<ExportTransferFileTemplateFiling, ExportTransferFileTemplateFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportToilCalendarFilingResponse ExportToilCalendarFiling(
            ExportToilCalendarFiling arg)
        {
            return Client.Post<ExportToilCalendarFiling, ExportToilCalendarFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportToilCalendarFilingResponse> ExportToilCalendarFilingAsync(
            ExportToilCalendarFiling arg)
        {
            return Client.PostAsync<ExportToilCalendarFiling, ExportToilCalendarFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportPublicHolidayCalendarFilingResponse ExportPublicHolidayCalendarFiling(
            ExportPublicHolidayCalendarFiling arg)
        {
            return Client.Post<ExportPublicHolidayCalendarFiling, ExportPublicHolidayCalendarFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportPublicHolidayCalendarFilingResponse> ExportPublicHolidayCalendarFilingAsync(
            ExportPublicHolidayCalendarFiling arg)
        {
            return Client.PostAsync<ExportPublicHolidayCalendarFiling, ExportPublicHolidayCalendarFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportCalculationSetupFilingResponse ImportCalculationSetupFiling(
            ImportCalculationSetupFiling arg)
        {
            return Client.Post<ImportCalculationSetupFiling, ImportCalculationSetupFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportCalculationSetupFilingResponse> ImportCalculationSetupFilingAsync(
            ImportCalculationSetupFiling arg)
        {
            return Client.PostAsync<ImportCalculationSetupFiling, ImportCalculationSetupFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportEndOfPeriodCalendarFilingResponse ExportEndOfPeriodCalendarFiling(
            ExportEndOfPeriodCalendarFiling arg)
        {
            return Client.Post<ExportEndOfPeriodCalendarFiling, ExportEndOfPeriodCalendarFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportEndOfPeriodCalendarFilingResponse> ExportEndOfPeriodCalendarFilingAsync(
            ExportEndOfPeriodCalendarFiling arg)
        {
            return Client.PostAsync<ExportEndOfPeriodCalendarFiling, ExportEndOfPeriodCalendarFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportUserSpaceFilingResponse ExportUserSpaceFiling(
            ExportUserSpaceFiling arg)
        {
            return Client.Post<ExportUserSpaceFiling, ExportUserSpaceFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportUserSpaceFilingResponse> ExportUserSpaceFilingAsync(
            ExportUserSpaceFiling arg)
        {
            return Client.PostAsync<ExportUserSpaceFiling, ExportUserSpaceFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportSpecialHourFilingResponse ImportSpecialHourFiling(
            ImportSpecialHourFiling arg)
        {
            return Client.Post<ImportSpecialHourFiling, ImportSpecialHourFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportSpecialHourFilingResponse> ImportSpecialHourFilingAsync(
            ImportSpecialHourFiling arg)
        {
            return Client.PostAsync<ImportSpecialHourFiling, ImportSpecialHourFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportUserSpaceFilingResponse ImportUserSpaceFiling(
            ImportUserSpaceFiling arg)
        {
            return Client.Post<ImportUserSpaceFiling, ImportUserSpaceFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportUserSpaceFilingResponse> ImportUserSpaceFilingAsync(
            ImportUserSpaceFiling arg)
        {
            return Client.PostAsync<ImportUserSpaceFiling, ImportUserSpaceFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportCostCenterFilingResponse ImportCostCenterFiling(
            ImportCostCenterFiling arg)
        {
            return Client.Post<ImportCostCenterFiling, ImportCostCenterFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportCostCenterFilingResponse> ImportCostCenterFilingAsync(
            ImportCostCenterFiling arg)
        {
            return Client.PostAsync<ImportCostCenterFiling, ImportCostCenterFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportTransferFileTemplateFilingResponse ImportTransferFileTemplateFiling(
            ImportTransferFileTemplateFiling arg)
        {
            return Client.Post<ImportTransferFileTemplateFiling, ImportTransferFileTemplateFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportTransferFileTemplateFilingResponse> ImportTransferFileTemplateFilingAsync(
            ImportTransferFileTemplateFiling arg)
        {
            return Client.PostAsync<ImportTransferFileTemplateFiling, ImportTransferFileTemplateFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportDailyScheduleFilingResponse ImportDailyScheduleFiling(
            ImportDailyScheduleFiling arg)
        {
            return Client.Post<ImportDailyScheduleFiling, ImportDailyScheduleFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportDailyScheduleFilingResponse> ImportDailyScheduleFilingAsync(
            ImportDailyScheduleFiling arg)
        {
            return Client.PostAsync<ImportDailyScheduleFiling, ImportDailyScheduleFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ExportTransferFileAccountFilingResponse ExportTransferFileAccountFiling(
            ExportTransferFileAccountFiling arg)
        {
            return Client.Post<ExportTransferFileAccountFiling, ExportTransferFileAccountFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ExportTransferFileAccountFilingResponse> ExportTransferFileAccountFilingAsync(
            ExportTransferFileAccountFiling arg)
        {
            return Client.PostAsync<ExportTransferFileAccountFiling, ExportTransferFileAccountFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportOnCallDutyFilingResponse ImportOnCallDutyFiling(
            ImportOnCallDutyFiling arg)
        {
            return Client.Post<ImportOnCallDutyFiling, ImportOnCallDutyFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportOnCallDutyFilingResponse> ImportOnCallDutyFilingAsync(
            ImportOnCallDutyFiling arg)
        {
            return Client.PostAsync<ImportOnCallDutyFiling, ImportOnCallDutyFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportTransferFileAccountFilingResponse ImportTransferFileAccountFiling(
            ImportTransferFileAccountFiling arg)
        {
            return Client.Post<ImportTransferFileAccountFiling, ImportTransferFileAccountFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportTransferFileAccountFilingResponse> ImportTransferFileAccountFilingAsync(
            ImportTransferFileAccountFiling arg)
        {
            return Client.PostAsync<ImportTransferFileAccountFiling, ImportTransferFileAccountFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteUserSpaceFilingResponse DeleteUserSpaceFiling(
            DeleteUserSpaceFiling arg)
        {
            return Client.Post<DeleteUserSpaceFiling, DeleteUserSpaceFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteUserSpaceFilingResponse> DeleteUserSpaceFilingAsync(
            DeleteUserSpaceFiling arg)
        {
            return Client.PostAsync<DeleteUserSpaceFiling, DeleteUserSpaceFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteTransferFileTemplateFilingResponse DeleteTransferFileTemplateFiling(
            DeleteTransferFileTemplateFiling arg)
        {
            return Client.Post<DeleteTransferFileTemplateFiling, DeleteTransferFileTemplateFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteTransferFileTemplateFilingResponse> DeleteTransferFileTemplateFilingAsync(
            DeleteTransferFileTemplateFiling arg)
        {
            return Client.PostAsync<DeleteTransferFileTemplateFiling, DeleteTransferFileTemplateFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportToilCalendarFilingResponse ImportToilCalendarFiling(
            ImportToilCalendarFiling arg)
        {
            return Client.Post<ImportToilCalendarFiling, ImportToilCalendarFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportToilCalendarFilingResponse> ImportToilCalendarFilingAsync(
            ImportToilCalendarFiling arg)
        {
            return Client.PostAsync<ImportToilCalendarFiling, ImportToilCalendarFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteOnCallDutyFilingResponse DeleteOnCallDutyFiling(
            DeleteOnCallDutyFiling arg)
        {
            return Client.Post<DeleteOnCallDutyFiling, DeleteOnCallDutyFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteOnCallDutyFilingResponse> DeleteOnCallDutyFilingAsync(
            DeleteOnCallDutyFiling arg)
        {
            return Client.PostAsync<DeleteOnCallDutyFiling, DeleteOnCallDutyFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteCustomizedReportFilingResponse DeleteCustomizedReportFiling(
            DeleteCustomizedReportFiling arg)
        {
            return Client.Post<DeleteCustomizedReportFiling, DeleteCustomizedReportFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteCustomizedReportFilingResponse> DeleteCustomizedReportFilingAsync(
            DeleteCustomizedReportFiling arg)
        {
            return Client.PostAsync<DeleteCustomizedReportFiling, DeleteCustomizedReportFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteAutomaticScheduleFilingResponse DeleteAutomaticScheduleFiling(
            DeleteAutomaticScheduleFiling arg)
        {
            return Client.Post<DeleteAutomaticScheduleFiling, DeleteAutomaticScheduleFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteAutomaticScheduleFilingResponse> DeleteAutomaticScheduleFilingAsync(
            DeleteAutomaticScheduleFiling arg)
        {
            return Client.PostAsync<DeleteAutomaticScheduleFiling, DeleteAutomaticScheduleFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportCustomizableFieldFilingResponse ImportCustomizableFieldFiling(
            ImportCustomizableFieldFiling arg)
        {
            return Client.Post<ImportCustomizableFieldFiling, ImportCustomizableFieldFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportCustomizableFieldFilingResponse> ImportCustomizableFieldFilingAsync(
            ImportCustomizableFieldFiling arg)
        {
            return Client.PostAsync<ImportCustomizableFieldFiling, ImportCustomizableFieldFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteCostCenterFilingResponse DeleteCostCenterFiling(
            DeleteCostCenterFiling arg)
        {
            return Client.Post<DeleteCostCenterFiling, DeleteCostCenterFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteCostCenterFilingResponse> DeleteCostCenterFilingAsync(
            DeleteCostCenterFiling arg)
        {
            return Client.PostAsync<DeleteCostCenterFiling, DeleteCostCenterFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteActivityFilingResponse DeleteActivityFiling(
            DeleteActivityFiling arg)
        {
            return Client.Post<DeleteActivityFiling, DeleteActivityFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteActivityFilingResponse> DeleteActivityFilingAsync(
            DeleteActivityFiling arg)
        {
            return Client.PostAsync<DeleteActivityFiling, DeleteActivityFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportEndOfPeriodCalendarFilingResponse ImportEndOfPeriodCalendarFiling(
            ImportEndOfPeriodCalendarFiling arg)
        {
            return Client.Post<ImportEndOfPeriodCalendarFiling, ImportEndOfPeriodCalendarFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportEndOfPeriodCalendarFilingResponse> ImportEndOfPeriodCalendarFilingAsync(
            ImportEndOfPeriodCalendarFiling arg)
        {
            return Client.PostAsync<ImportEndOfPeriodCalendarFiling, ImportEndOfPeriodCalendarFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteEmployeeGroupFilingResponse DeleteEmployeeGroupFiling(
            DeleteEmployeeGroupFiling arg)
        {
            return Client.Post<DeleteEmployeeGroupFiling, DeleteEmployeeGroupFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteEmployeeGroupFilingResponse> DeleteEmployeeGroupFilingAsync(
            DeleteEmployeeGroupFiling arg)
        {
            return Client.PostAsync<DeleteEmployeeGroupFiling, DeleteEmployeeGroupFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteEndOfPeriodCalendarFilingResponse DeleteEndOfPeriodCalendarFiling(
            DeleteEndOfPeriodCalendarFiling arg)
        {
            return Client.Post<DeleteEndOfPeriodCalendarFiling, DeleteEndOfPeriodCalendarFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteEndOfPeriodCalendarFilingResponse> DeleteEndOfPeriodCalendarFilingAsync(
            DeleteEndOfPeriodCalendarFiling arg)
        {
            return Client.PostAsync<DeleteEndOfPeriodCalendarFiling, DeleteEndOfPeriodCalendarFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportPublicHolidayCalendarFilingResponse ImportPublicHolidayCalendarFiling(
            ImportPublicHolidayCalendarFiling arg)
        {
            return Client.Post<ImportPublicHolidayCalendarFiling, ImportPublicHolidayCalendarFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportPublicHolidayCalendarFilingResponse> ImportPublicHolidayCalendarFilingAsync(
            ImportPublicHolidayCalendarFiling arg)
        {
            return Client.PostAsync<ImportPublicHolidayCalendarFiling, ImportPublicHolidayCalendarFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteSpecialHourFilingResponse DeleteSpecialHourFiling(
            DeleteSpecialHourFiling arg)
        {
            return Client.Post<DeleteSpecialHourFiling, DeleteSpecialHourFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteSpecialHourFilingResponse> DeleteSpecialHourFilingAsync(
            DeleteSpecialHourFiling arg)
        {
            return Client.PostAsync<DeleteSpecialHourFiling, DeleteSpecialHourFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteCalculationSetupFilingResponse DeleteCalculationSetupFiling(
            DeleteCalculationSetupFiling arg)
        {
            return Client.Post<DeleteCalculationSetupFiling, DeleteCalculationSetupFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteCalculationSetupFilingResponse> DeleteCalculationSetupFilingAsync(
            DeleteCalculationSetupFiling arg)
        {
            return Client.PostAsync<DeleteCalculationSetupFiling, DeleteCalculationSetupFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteBodetAppsFilingResponse DeleteBodetAppsFiling(
            DeleteBodetAppsFiling arg)
        {
            return Client.Post<DeleteBodetAppsFiling, DeleteBodetAppsFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteBodetAppsFilingResponse> DeleteBodetAppsFilingAsync(
            DeleteBodetAppsFiling arg)
        {
            return Client.PostAsync<DeleteBodetAppsFiling, DeleteBodetAppsFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportHourlyContractsFilingResponse ImportHourlyContractsFiling(
            ImportHourlyContractsFiling arg)
        {
            return Client.Post<ImportHourlyContractsFiling, ImportHourlyContractsFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportHourlyContractsFilingResponse> ImportHourlyContractsFilingAsync(
            ImportHourlyContractsFiling arg)
        {
            return Client.PostAsync<ImportHourlyContractsFiling, ImportHourlyContractsFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportBodetAppsFilingResponse ImportBodetAppsFiling(
            ImportBodetAppsFiling arg)
        {
            return Client.Post<ImportBodetAppsFiling, ImportBodetAppsFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportBodetAppsFilingResponse> ImportBodetAppsFilingAsync(
            ImportBodetAppsFiling arg)
        {
            return Client.PostAsync<ImportBodetAppsFiling, ImportBodetAppsFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteDailyScheduleFilingResponse DeleteDailyScheduleFiling(
            DeleteDailyScheduleFiling arg)
        {
            return Client.Post<DeleteDailyScheduleFiling, DeleteDailyScheduleFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteDailyScheduleFilingResponse> DeleteDailyScheduleFilingAsync(
            DeleteDailyScheduleFiling arg)
        {
            return Client.PostAsync<DeleteDailyScheduleFiling, DeleteDailyScheduleFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportAutomaticScheduleFilingResponse ImportAutomaticScheduleFiling(
            ImportAutomaticScheduleFiling arg)
        {
            return Client.Post<ImportAutomaticScheduleFiling, ImportAutomaticScheduleFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportAutomaticScheduleFilingResponse> ImportAutomaticScheduleFilingAsync(
            ImportAutomaticScheduleFiling arg)
        {
            return Client.PostAsync<ImportAutomaticScheduleFiling, ImportAutomaticScheduleFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteHourlyContractsFilingResponse DeleteHourlyContractsFiling(
            DeleteHourlyContractsFiling arg)
        {
            return Client.Post<DeleteHourlyContractsFiling, DeleteHourlyContractsFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteHourlyContractsFilingResponse> DeleteHourlyContractsFilingAsync(
            DeleteHourlyContractsFiling arg)
        {
            return Client.PostAsync<DeleteHourlyContractsFiling, DeleteHourlyContractsFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeletePublicHolidayCalendarFilingResponse DeletePublicHolidayCalendarFiling(
            DeletePublicHolidayCalendarFiling arg)
        {
            return Client.Post<DeletePublicHolidayCalendarFiling, DeletePublicHolidayCalendarFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeletePublicHolidayCalendarFilingResponse> DeletePublicHolidayCalendarFilingAsync(
            DeletePublicHolidayCalendarFiling arg)
        {
            return Client.PostAsync<DeletePublicHolidayCalendarFiling, DeletePublicHolidayCalendarFilingResponse>(
                this.username, this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteBonusFilingResponse DeleteBonusFiling(
            DeleteBonusFiling arg)
        {
            return Client.Post<DeleteBonusFiling, DeleteBonusFilingResponse>(this.username, this.password, this.baseuri,
                "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteBonusFilingResponse> DeleteBonusFilingAsync(
            DeleteBonusFiling arg)
        {
            return Client.PostAsync<DeleteBonusFiling, DeleteBonusFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteAbsenceBalanceFilingResponse DeleteAbsenceBalanceFiling(
            DeleteAbsenceBalanceFiling arg)
        {
            return Client.Post<DeleteAbsenceBalanceFiling, DeleteAbsenceBalanceFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteAbsenceBalanceFilingResponse> DeleteAbsenceBalanceFilingAsync(
            DeleteAbsenceBalanceFiling arg)
        {
            return Client.PostAsync<DeleteAbsenceBalanceFiling, DeleteAbsenceBalanceFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportHomepageFilingResponse ImportHomepageFiling(
            ImportHomepageFiling arg)
        {
            return Client.Post<ImportHomepageFiling, ImportHomepageFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportHomepageFilingResponse> ImportHomepageFilingAsync(
            ImportHomepageFiling arg)
        {
            return Client.PostAsync<ImportHomepageFiling, ImportHomepageFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public ImportEmployeeGroupFilingResponse ImportEmployeeGroupFiling(
            ImportEmployeeGroupFiling arg)
        {
            return Client.Post<ImportEmployeeGroupFiling, ImportEmployeeGroupFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<ImportEmployeeGroupFilingResponse> ImportEmployeeGroupFilingAsync(
            ImportEmployeeGroupFiling arg)
        {
            return Client.PostAsync<ImportEmployeeGroupFiling, ImportEmployeeGroupFilingResponse>(this.username,
                this.password, this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteAbsenceFilingResponse DeleteAbsenceFiling(
            DeleteAbsenceFiling arg)
        {
            return Client.Post<DeleteAbsenceFiling, DeleteAbsenceFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteAbsenceFilingResponse> DeleteAbsenceFilingAsync(
            DeleteAbsenceFiling arg)
        {
            return Client.PostAsync<DeleteAbsenceFiling, DeleteAbsenceFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteScheduleFilingResponse DeleteScheduleFiling(
            DeleteScheduleFiling arg)
        {
            return Client.Post<DeleteScheduleFiling, DeleteScheduleFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteScheduleFilingResponse> DeleteScheduleFilingAsync(
            DeleteScheduleFiling arg)
        {
            return Client.PostAsync<DeleteScheduleFiling, DeleteScheduleFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteProfileFilingResponse DeleteProfileFiling(
            DeleteProfileFiling arg)
        {
            return Client.Post<DeleteProfileFiling, DeleteProfileFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteProfileFilingResponse> DeleteProfileFilingAsync(
            DeleteProfileFiling arg)
        {
            return Client.PostAsync<DeleteProfileFiling, DeleteProfileFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public DeleteHomepageFilingResponse DeleteHomepageFiling(
            DeleteHomepageFiling arg)
        {
            return Client.Post<DeleteHomepageFiling, DeleteHomepageFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }

        public Task<DeleteHomepageFilingResponse> DeleteHomepageFilingAsync(
            DeleteHomepageFiling arg)
        {
            return Client.PostAsync<DeleteHomepageFiling, DeleteHomepageFilingResponse>(this.username, this.password,
                this.baseuri, "FilingService", arg, this.timeoutSeconds);
        }
    }
}