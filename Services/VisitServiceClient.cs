
//.VisitServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class VisitServiceClient
  {
    private const string service = "VisitService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public VisitServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportVisitsPurposesFromRelativeDatesResponse ExportVisitsPurposesFromRelativeDates(
      ExportVisitsPurposesFromRelativeDates arg)
    {
      return Client.Post<ExportVisitsPurposesFromRelativeDates, ExportVisitsPurposesFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "VisitService", arg, this.timeoutSeconds);
    }

    public Task<ExportVisitsPurposesFromRelativeDatesResponse> ExportVisitsPurposesFromRelativeDatesAsync(
      ExportVisitsPurposesFromRelativeDates arg)
    {
      return Client.PostAsync<ExportVisitsPurposesFromRelativeDates, ExportVisitsPurposesFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "VisitService", arg, this.timeoutSeconds);
    }

    public ExportVisitsPurposesResponse ExportVisitsPurposes(
      ExportVisitsPurposes arg)
    {
      return Client.Post<ExportVisitsPurposes, ExportVisitsPurposesResponse>(this.username, this.password, this.baseuri, "VisitService", arg, this.timeoutSeconds);
    }

    public Task<ExportVisitsPurposesResponse> ExportVisitsPurposesAsync(
      ExportVisitsPurposes arg)
    {
      return Client.PostAsync<ExportVisitsPurposes, ExportVisitsPurposesResponse>(this.username, this.password, this.baseuri, "VisitService", arg, this.timeoutSeconds);
    }

    public ExportVisitsPurposesFromDateToDateResponse ExportVisitsPurposesFromDateToDate(
      ExportVisitsPurposesFromDateToDate arg)
    {
      return Client.Post<ExportVisitsPurposesFromDateToDate, ExportVisitsPurposesFromDateToDateResponse>(this.username, this.password, this.baseuri, "VisitService", arg, this.timeoutSeconds);
    }

    public Task<ExportVisitsPurposesFromDateToDateResponse> ExportVisitsPurposesFromDateToDateAsync(
      ExportVisitsPurposesFromDateToDate arg)
    {
      return Client.PostAsync<ExportVisitsPurposesFromDateToDate, ExportVisitsPurposesFromDateToDateResponse>(this.username, this.password, this.baseuri, "VisitService", arg, this.timeoutSeconds);
    }

    public ExportVisitsFromDateToDateResponse ExportVisitsFromDateToDate(
      ExportVisitsFromDateToDate arg)
    {
      return Client.Post<ExportVisitsFromDateToDate, ExportVisitsFromDateToDateResponse>(this.username, this.password, this.baseuri, "VisitService", arg, this.timeoutSeconds);
    }

    public Task<ExportVisitsFromDateToDateResponse> ExportVisitsFromDateToDateAsync(
      ExportVisitsFromDateToDate arg)
    {
      return Client.PostAsync<ExportVisitsFromDateToDate, ExportVisitsFromDateToDateResponse>(this.username, this.password, this.baseuri, "VisitService", arg, this.timeoutSeconds);
    }

    public ExportVisitsResponse ExportVisits(ExportVisits arg)
    {
      return Client.Post<ExportVisits, ExportVisitsResponse>(this.username, this.password, this.baseuri, "VisitService", arg, this.timeoutSeconds);
    }

    public Task<ExportVisitsResponse> ExportVisitsAsync(ExportVisits arg)
    {
      return Client.PostAsync<ExportVisits, ExportVisitsResponse>(this.username, this.password, this.baseuri, "VisitService", arg, this.timeoutSeconds);
    }

    public ExportVisitsFromRelativeDatesResponse ExportVisitsFromRelativeDates(
      ExportVisitsFromRelativeDates arg)
    {
      return Client.Post<ExportVisitsFromRelativeDates, ExportVisitsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "VisitService", arg, this.timeoutSeconds);
    }

    public Task<ExportVisitsFromRelativeDatesResponse> ExportVisitsFromRelativeDatesAsync(
      ExportVisitsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportVisitsFromRelativeDates, ExportVisitsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "VisitService", arg, this.timeoutSeconds);
    }
  }
}
