
//.CalculationFunctionServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class CalculationFunctionServiceClient
  {
    private const string service = "CalculationFunctionService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public CalculationFunctionServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportCalculationFunctionExecutionsFromRelativeDatesForEmployeeListResponse ExportCalculationFunctionExecutionsFromRelativeDatesForEmployeeList(
      ExportCalculationFunctionExecutionsFromRelativeDatesForEmployeeList arg)
    {
      return Client.Post<ExportCalculationFunctionExecutionsFromRelativeDatesForEmployeeList, ExportCalculationFunctionExecutionsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "CalculationFunctionService", arg, this.timeoutSeconds);
    }

    public Task<ExportCalculationFunctionExecutionsFromRelativeDatesForEmployeeListResponse> ExportCalculationFunctionExecutionsFromRelativeDatesForEmployeeListAsync(
      ExportCalculationFunctionExecutionsFromRelativeDatesForEmployeeList arg)
    {
      return Client.PostAsync<ExportCalculationFunctionExecutionsFromRelativeDatesForEmployeeList, ExportCalculationFunctionExecutionsFromRelativeDatesForEmployeeListResponse>(this.username, this.password, this.baseuri, "CalculationFunctionService", arg, this.timeoutSeconds);
    }

    public ExportCalculationFunctionExecutionsListResponse ExportCalculationFunctionExecutionsList(
      ExportCalculationFunctionExecutionsList arg)
    {
      return Client.Post<ExportCalculationFunctionExecutionsList, ExportCalculationFunctionExecutionsListResponse>(this.username, this.password, this.baseuri, "CalculationFunctionService", arg, this.timeoutSeconds);
    }

    public Task<ExportCalculationFunctionExecutionsListResponse> ExportCalculationFunctionExecutionsListAsync(
      ExportCalculationFunctionExecutionsList arg)
    {
      return Client.PostAsync<ExportCalculationFunctionExecutionsList, ExportCalculationFunctionExecutionsListResponse>(this.username, this.password, this.baseuri, "CalculationFunctionService", arg, this.timeoutSeconds);
    }

    public ExportCalculationFunctionExecutionsFromDateToDateForEmployeeListResponse ExportCalculationFunctionExecutionsFromDateToDateForEmployeeList(
      ExportCalculationFunctionExecutionsFromDateToDateForEmployeeList arg)
    {
      return Client.Post<ExportCalculationFunctionExecutionsFromDateToDateForEmployeeList, ExportCalculationFunctionExecutionsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "CalculationFunctionService", arg, this.timeoutSeconds);
    }

    public Task<ExportCalculationFunctionExecutionsFromDateToDateForEmployeeListResponse> ExportCalculationFunctionExecutionsFromDateToDateForEmployeeListAsync(
      ExportCalculationFunctionExecutionsFromDateToDateForEmployeeList arg)
    {
      return Client.PostAsync<ExportCalculationFunctionExecutionsFromDateToDateForEmployeeList, ExportCalculationFunctionExecutionsFromDateToDateForEmployeeListResponse>(this.username, this.password, this.baseuri, "CalculationFunctionService", arg, this.timeoutSeconds);
    }

    public ExportCalculationFunctionExecutionsFromRelativeDatesResponse ExportCalculationFunctionExecutionsFromRelativeDates(
      ExportCalculationFunctionExecutionsFromRelativeDates arg)
    {
      return Client.Post<ExportCalculationFunctionExecutionsFromRelativeDates, ExportCalculationFunctionExecutionsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "CalculationFunctionService", arg, this.timeoutSeconds);
    }

    public Task<ExportCalculationFunctionExecutionsFromRelativeDatesResponse> ExportCalculationFunctionExecutionsFromRelativeDatesAsync(
      ExportCalculationFunctionExecutionsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportCalculationFunctionExecutionsFromRelativeDates, ExportCalculationFunctionExecutionsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "CalculationFunctionService", arg, this.timeoutSeconds);
    }

    public ExportCalculationFunctionExecutionsFromDateToDateResponse ExportCalculationFunctionExecutionsFromDateToDate(
      ExportCalculationFunctionExecutionsFromDateToDate arg)
    {
      return Client.Post<ExportCalculationFunctionExecutionsFromDateToDate, ExportCalculationFunctionExecutionsFromDateToDateResponse>(this.username, this.password, this.baseuri, "CalculationFunctionService", arg, this.timeoutSeconds);
    }

    public Task<ExportCalculationFunctionExecutionsFromDateToDateResponse> ExportCalculationFunctionExecutionsFromDateToDateAsync(
      ExportCalculationFunctionExecutionsFromDateToDate arg)
    {
      return Client.PostAsync<ExportCalculationFunctionExecutionsFromDateToDate, ExportCalculationFunctionExecutionsFromDateToDateResponse>(this.username, this.password, this.baseuri, "CalculationFunctionService", arg, this.timeoutSeconds);
    }
  }
}
