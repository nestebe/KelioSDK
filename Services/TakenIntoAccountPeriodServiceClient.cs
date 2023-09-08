
//.TakenIntoAccountPeriodServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class TakenIntoAccountPeriodServiceClient
  {
    private const string service = "TakenIntoAccountPeriodService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public TakenIntoAccountPeriodServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportTakenIntoAccountPeriodsListResponse ExportTakenIntoAccountPeriodsList(
      ExportTakenIntoAccountPeriodsList arg)
    {
      return Client.Post<ExportTakenIntoAccountPeriodsList, ExportTakenIntoAccountPeriodsListResponse>(this.username, this.password, this.baseuri, "TakenIntoAccountPeriodService", arg);
    }

    public Task<ExportTakenIntoAccountPeriodsListResponse> ExportTakenIntoAccountPeriodsListAsync(
      ExportTakenIntoAccountPeriodsList arg)
    {
      return Client.PostAsync<ExportTakenIntoAccountPeriodsList, ExportTakenIntoAccountPeriodsListResponse>(this.username, this.password, this.baseuri, "TakenIntoAccountPeriodService", arg);
    }

    public DeleteTakenIntoAccountPeriodsResponse DeleteTakenIntoAccountPeriods(
      DeleteTakenIntoAccountPeriods arg)
    {
      return Client.Post<DeleteTakenIntoAccountPeriods, DeleteTakenIntoAccountPeriodsResponse>(this.username, this.password, this.baseuri, "TakenIntoAccountPeriodService", arg);
    }

    public Task<DeleteTakenIntoAccountPeriodsResponse> DeleteTakenIntoAccountPeriodsAsync(
      DeleteTakenIntoAccountPeriods arg)
    {
      return Client.PostAsync<DeleteTakenIntoAccountPeriods, DeleteTakenIntoAccountPeriodsResponse>(this.username, this.password, this.baseuri, "TakenIntoAccountPeriodService", arg);
    }

    public ExportTakenIntoAccountPeriodsResponse ExportTakenIntoAccountPeriods(
      ExportTakenIntoAccountPeriods arg)
    {
      return Client.Post<ExportTakenIntoAccountPeriods, ExportTakenIntoAccountPeriodsResponse>(this.username, this.password, this.baseuri, "TakenIntoAccountPeriodService", arg);
    }

    public Task<ExportTakenIntoAccountPeriodsResponse> ExportTakenIntoAccountPeriodsAsync(
      ExportTakenIntoAccountPeriods arg)
    {
      return Client.PostAsync<ExportTakenIntoAccountPeriods, ExportTakenIntoAccountPeriodsResponse>(this.username, this.password, this.baseuri, "TakenIntoAccountPeriodService", arg);
    }

    public ImportTakenIntoAccountPeriodsResponse ImportTakenIntoAccountPeriods(
      ImportTakenIntoAccountPeriods arg)
    {
      return Client.Post<ImportTakenIntoAccountPeriods, ImportTakenIntoAccountPeriodsResponse>(this.username, this.password, this.baseuri, "TakenIntoAccountPeriodService", arg);
    }

    public Task<ImportTakenIntoAccountPeriodsResponse> ImportTakenIntoAccountPeriodsAsync(
      ImportTakenIntoAccountPeriods arg)
    {
      return Client.PostAsync<ImportTakenIntoAccountPeriods, ImportTakenIntoAccountPeriodsResponse>(this.username, this.password, this.baseuri, "TakenIntoAccountPeriodService", arg);
    }
  }
}
