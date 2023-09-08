
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

    public AccessEventServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportAccessEventsFromDateToDateForListResponse ExportAccessEventsFromDateToDateForList(
      ExportAccessEventsFromDateToDateForList arg)
    {
      return Client.Post<ExportAccessEventsFromDateToDateForList, ExportAccessEventsFromDateToDateForListResponse>(this.username, this.password, this.baseuri, "AccessEventService", arg);
    }

    public Task<ExportAccessEventsFromDateToDateForListResponse> ExportAccessEventsFromDateToDateForListAsync(
      ExportAccessEventsFromDateToDateForList arg)
    {
      return Client.PostAsync<ExportAccessEventsFromDateToDateForList, ExportAccessEventsFromDateToDateForListResponse>(this.username, this.password, this.baseuri, "AccessEventService", arg);
    }

    public ExportAccessEventsFromRelativeDatesForListResponse ExportAccessEventsFromRelativeDatesForList(
      ExportAccessEventsFromRelativeDatesForList arg)
    {
      return Client.Post<ExportAccessEventsFromRelativeDatesForList, ExportAccessEventsFromRelativeDatesForListResponse>(this.username, this.password, this.baseuri, "AccessEventService", arg);
    }

    public Task<ExportAccessEventsFromRelativeDatesForListResponse> ExportAccessEventsFromRelativeDatesForListAsync(
      ExportAccessEventsFromRelativeDatesForList arg)
    {
      return Client.PostAsync<ExportAccessEventsFromRelativeDatesForList, ExportAccessEventsFromRelativeDatesForListResponse>(this.username, this.password, this.baseuri, "AccessEventService", arg);
    }

    public ExportAccessEventsResponse ExportAccessEvents(
      ExportAccessEvents arg)
    {
      return Client.Post<ExportAccessEvents, ExportAccessEventsResponse>(this.username, this.password, this.baseuri, "AccessEventService", arg);
    }

    public Task<ExportAccessEventsResponse> ExportAccessEventsAsync(
      ExportAccessEvents arg)
    {
      return Client.PostAsync<ExportAccessEvents, ExportAccessEventsResponse>(this.username, this.password, this.baseuri, "AccessEventService", arg);
    }

    public ExportAccessEventsFromDateToDateResponse ExportAccessEventsFromDateToDate(
      ExportAccessEventsFromDateToDate arg)
    {
      return Client.Post<ExportAccessEventsFromDateToDate, ExportAccessEventsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccessEventService", arg);
    }

    public Task<ExportAccessEventsFromDateToDateResponse> ExportAccessEventsFromDateToDateAsync(
      ExportAccessEventsFromDateToDate arg)
    {
      return Client.PostAsync<ExportAccessEventsFromDateToDate, ExportAccessEventsFromDateToDateResponse>(this.username, this.password, this.baseuri, "AccessEventService", arg);
    }

    public ExportAccessEventsFromRelativeDatesResponse ExportAccessEventsFromRelativeDates(
      ExportAccessEventsFromRelativeDates arg)
    {
      return Client.Post<ExportAccessEventsFromRelativeDates, ExportAccessEventsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccessEventService", arg);
    }

    public Task<ExportAccessEventsFromRelativeDatesResponse> ExportAccessEventsFromRelativeDatesAsync(
      ExportAccessEventsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportAccessEventsFromRelativeDates, ExportAccessEventsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "AccessEventService", arg);
    }
  }
}
