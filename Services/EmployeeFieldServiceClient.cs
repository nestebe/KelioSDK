
//.EmployeeFieldServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmployeeFieldServiceClient
  {
    private const string service = "EmployeeFieldService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public EmployeeFieldServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportEmployeeFreeFieldsResponse ExportEmployeeFreeFields(
      ExportEmployeeFreeFields arg)
    {
      return Client.Post<ExportEmployeeFreeFields, ExportEmployeeFreeFieldsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldService", arg);
    }

    public Task<ExportEmployeeFreeFieldsResponse> ExportEmployeeFreeFieldsAsync(
      ExportEmployeeFreeFields arg)
    {
      return Client.PostAsync<ExportEmployeeFreeFields, ExportEmployeeFreeFieldsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldService", arg);
    }

    public ImportEmployeeFreeFieldsResponse ImportEmployeeFreeFields(
      ImportEmployeeFreeFields arg)
    {
      return Client.Post<ImportEmployeeFreeFields, ImportEmployeeFreeFieldsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldService", arg);
    }

    public Task<ImportEmployeeFreeFieldsResponse> ImportEmployeeFreeFieldsAsync(
      ImportEmployeeFreeFields arg)
    {
      return Client.PostAsync<ImportEmployeeFreeFields, ImportEmployeeFreeFieldsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldService", arg);
    }

    public ImportEmployeePredefinedFieldsResponse ImportEmployeePredefinedFields(
      ImportEmployeePredefinedFields arg)
    {
      return Client.Post<ImportEmployeePredefinedFields, ImportEmployeePredefinedFieldsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldService", arg);
    }

    public Task<ImportEmployeePredefinedFieldsResponse> ImportEmployeePredefinedFieldsAsync(
      ImportEmployeePredefinedFields arg)
    {
      return Client.PostAsync<ImportEmployeePredefinedFields, ImportEmployeePredefinedFieldsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldService", arg);
    }

    public ExportEmployeePredefinedFieldsResponse ExportEmployeePredefinedFields(
      ExportEmployeePredefinedFields arg)
    {
      return Client.Post<ExportEmployeePredefinedFields, ExportEmployeePredefinedFieldsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldService", arg);
    }

    public Task<ExportEmployeePredefinedFieldsResponse> ExportEmployeePredefinedFieldsAsync(
      ExportEmployeePredefinedFields arg)
    {
      return Client.PostAsync<ExportEmployeePredefinedFields, ExportEmployeePredefinedFieldsResponse>(this.username, this.password, this.baseuri, "EmployeeFieldService", arg);
    }
  }
}
