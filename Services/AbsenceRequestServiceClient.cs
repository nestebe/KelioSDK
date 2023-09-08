
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

    public AbsenceRequestServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportAbsenceRequestsListResponse ExportAbsenceRequestsList(
      ExportAbsenceRequestsList arg)
    {
      return Client.Post<ExportAbsenceRequestsList, ExportAbsenceRequestsListResponse>(this.username, this.password, this.baseuri, "AbsenceRequestService", arg);
    }

    public Task<ExportAbsenceRequestsListResponse> ExportAbsenceRequestsListAsync(
      ExportAbsenceRequestsList arg)
    {
      return Client.PostAsync<ExportAbsenceRequestsList, ExportAbsenceRequestsListResponse>(this.username, this.password, this.baseuri, "AbsenceRequestService", arg);
    }

    public ExportAbsenceRequestsLimitedToAPeriodListResponse ExportAbsenceRequestsLimitedToAPeriodList(
      ExportAbsenceRequestsLimitedToAPeriodList arg)
    {
      return Client.Post<ExportAbsenceRequestsLimitedToAPeriodList, ExportAbsenceRequestsLimitedToAPeriodListResponse>(this.username, this.password, this.baseuri, "AbsenceRequestService", arg);
    }

    public Task<ExportAbsenceRequestsLimitedToAPeriodListResponse> ExportAbsenceRequestsLimitedToAPeriodListAsync(
      ExportAbsenceRequestsLimitedToAPeriodList arg)
    {
      return Client.PostAsync<ExportAbsenceRequestsLimitedToAPeriodList, ExportAbsenceRequestsLimitedToAPeriodListResponse>(this.username, this.password, this.baseuri, "AbsenceRequestService", arg);
    }

    public ExportAbsenceRequestPeriodsResponse ExportAbsenceRequestPeriods(
      ExportAbsenceRequestPeriods arg)
    {
      return Client.Post<ExportAbsenceRequestPeriods, ExportAbsenceRequestPeriodsResponse>(this.username, this.password, this.baseuri, "AbsenceRequestService", arg);
    }

    public Task<ExportAbsenceRequestPeriodsResponse> ExportAbsenceRequestPeriodsAsync(
      ExportAbsenceRequestPeriods arg)
    {
      return Client.PostAsync<ExportAbsenceRequestPeriods, ExportAbsenceRequestPeriodsResponse>(this.username, this.password, this.baseuri, "AbsenceRequestService", arg);
    }

    public ExportAbsenceRequestPeriodsFromEmployeeListResponse ExportAbsenceRequestPeriodsFromEmployeeList(
      ExportAbsenceRequestPeriodsFromEmployeeList arg)
    {
      return Client.Post<ExportAbsenceRequestPeriodsFromEmployeeList, ExportAbsenceRequestPeriodsFromEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceRequestService", arg);
    }

    public Task<ExportAbsenceRequestPeriodsFromEmployeeListResponse> ExportAbsenceRequestPeriodsFromEmployeeListAsync(
      ExportAbsenceRequestPeriodsFromEmployeeList arg)
    {
      return Client.PostAsync<ExportAbsenceRequestPeriodsFromEmployeeList, ExportAbsenceRequestPeriodsFromEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceRequestService", arg);
    }

    public ExportAbsenceRequestsLimitedToAPeriodFromEmployeeListResponse ExportAbsenceRequestsLimitedToAPeriodFromEmployeeList(
      ExportAbsenceRequestsLimitedToAPeriodFromEmployeeList arg)
    {
      return Client.Post<ExportAbsenceRequestsLimitedToAPeriodFromEmployeeList, ExportAbsenceRequestsLimitedToAPeriodFromEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceRequestService", arg);
    }

    public Task<ExportAbsenceRequestsLimitedToAPeriodFromEmployeeListResponse> ExportAbsenceRequestsLimitedToAPeriodFromEmployeeListAsync(
      ExportAbsenceRequestsLimitedToAPeriodFromEmployeeList arg)
    {
      return Client.PostAsync<ExportAbsenceRequestsLimitedToAPeriodFromEmployeeList, ExportAbsenceRequestsLimitedToAPeriodFromEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceRequestService", arg);
    }

    public ExportAbsenceRequestsLimitedToAPeriodResponse ExportAbsenceRequestsLimitedToAPeriod(
      ExportAbsenceRequestsLimitedToAPeriod arg)
    {
      return Client.Post<ExportAbsenceRequestsLimitedToAPeriod, ExportAbsenceRequestsLimitedToAPeriodResponse>(this.username, this.password, this.baseuri, "AbsenceRequestService", arg);
    }

    public Task<ExportAbsenceRequestsLimitedToAPeriodResponse> ExportAbsenceRequestsLimitedToAPeriodAsync(
      ExportAbsenceRequestsLimitedToAPeriod arg)
    {
      return Client.PostAsync<ExportAbsenceRequestsLimitedToAPeriod, ExportAbsenceRequestsLimitedToAPeriodResponse>(this.username, this.password, this.baseuri, "AbsenceRequestService", arg);
    }

    public ExportAbsenceRequestPeriodsListResponse ExportAbsenceRequestPeriodsList(
      ExportAbsenceRequestPeriodsList arg)
    {
      return Client.Post<ExportAbsenceRequestPeriodsList, ExportAbsenceRequestPeriodsListResponse>(this.username, this.password, this.baseuri, "AbsenceRequestService", arg);
    }

    public Task<ExportAbsenceRequestPeriodsListResponse> ExportAbsenceRequestPeriodsListAsync(
      ExportAbsenceRequestPeriodsList arg)
    {
      return Client.PostAsync<ExportAbsenceRequestPeriodsList, ExportAbsenceRequestPeriodsListResponse>(this.username, this.password, this.baseuri, "AbsenceRequestService", arg);
    }

    public ExportAbsenceRequestsFromEmployeeListResponse ExportAbsenceRequestsFromEmployeeList(
      ExportAbsenceRequestsFromEmployeeList arg)
    {
      return Client.Post<ExportAbsenceRequestsFromEmployeeList, ExportAbsenceRequestsFromEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceRequestService", arg);
    }

    public Task<ExportAbsenceRequestsFromEmployeeListResponse> ExportAbsenceRequestsFromEmployeeListAsync(
      ExportAbsenceRequestsFromEmployeeList arg)
    {
      return Client.PostAsync<ExportAbsenceRequestsFromEmployeeList, ExportAbsenceRequestsFromEmployeeListResponse>(this.username, this.password, this.baseuri, "AbsenceRequestService", arg);
    }

    public ExportAbsenceRequestsResponse ExportAbsenceRequests(
      ExportAbsenceRequests arg)
    {
      return Client.Post<ExportAbsenceRequests, ExportAbsenceRequestsResponse>(this.username, this.password, this.baseuri, "AbsenceRequestService", arg);
    }

    public Task<ExportAbsenceRequestsResponse> ExportAbsenceRequestsAsync(
      ExportAbsenceRequests arg)
    {
      return Client.PostAsync<ExportAbsenceRequests, ExportAbsenceRequestsResponse>(this.username, this.password, this.baseuri, "AbsenceRequestService", arg);
    }
  }
}
