
//.PayrollPeriodServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class PayrollPeriodServiceClient
  {
    private const string service = "PayrollPeriodService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public PayrollPeriodServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportPayrollPeriodsResponse ExportPayrollPeriods(
      ExportPayrollPeriods arg)
    {
      return Client.Post<ExportPayrollPeriods, ExportPayrollPeriodsResponse>(this.username, this.password, this.baseuri, "PayrollPeriodService", arg);
    }

    public Task<ExportPayrollPeriodsResponse> ExportPayrollPeriodsAsync(
      ExportPayrollPeriods arg)
    {
      return Client.PostAsync<ExportPayrollPeriods, ExportPayrollPeriodsResponse>(this.username, this.password, this.baseuri, "PayrollPeriodService", arg);
    }
  }
}
