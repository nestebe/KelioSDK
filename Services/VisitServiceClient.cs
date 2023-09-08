
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
    private readonly string baseuri;

    public VisitServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportVisitsPurposesFromRelativeDatesResponse ExportVisitsPurposesFromRelativeDates(
      ExportVisitsPurposesFromRelativeDates arg)
    {
      return Client.Post<ExportVisitsPurposesFromRelativeDates, ExportVisitsPurposesFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "VisitService", arg);
    }

    public Task<ExportVisitsPurposesFromRelativeDatesResponse> ExportVisitsPurposesFromRelativeDatesAsync(
      ExportVisitsPurposesFromRelativeDates arg)
    {
      return Client.PostAsync<ExportVisitsPurposesFromRelativeDates, ExportVisitsPurposesFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "VisitService", arg);
    }

    public ExportVisitsPurposesResponse ExportVisitsPurposes(
      ExportVisitsPurposes arg)
    {
      return Client.Post<ExportVisitsPurposes, ExportVisitsPurposesResponse>(this.username, this.password, this.baseuri, "VisitService", arg);
    }

    public Task<ExportVisitsPurposesResponse> ExportVisitsPurposesAsync(
      ExportVisitsPurposes arg)
    {
      return Client.PostAsync<ExportVisitsPurposes, ExportVisitsPurposesResponse>(this.username, this.password, this.baseuri, "VisitService", arg);
    }

    public ExportVisitsPurposesFromDateToDateResponse ExportVisitsPurposesFromDateToDate(
      ExportVisitsPurposesFromDateToDate arg)
    {
      return Client.Post<ExportVisitsPurposesFromDateToDate, ExportVisitsPurposesFromDateToDateResponse>(this.username, this.password, this.baseuri, "VisitService", arg);
    }

    public Task<ExportVisitsPurposesFromDateToDateResponse> ExportVisitsPurposesFromDateToDateAsync(
      ExportVisitsPurposesFromDateToDate arg)
    {
      return Client.PostAsync<ExportVisitsPurposesFromDateToDate, ExportVisitsPurposesFromDateToDateResponse>(this.username, this.password, this.baseuri, "VisitService", arg);
    }

    public ExportVisitsFromDateToDateResponse ExportVisitsFromDateToDate(
      ExportVisitsFromDateToDate arg)
    {
      return Client.Post<ExportVisitsFromDateToDate, ExportVisitsFromDateToDateResponse>(this.username, this.password, this.baseuri, "VisitService", arg);
    }

    public Task<ExportVisitsFromDateToDateResponse> ExportVisitsFromDateToDateAsync(
      ExportVisitsFromDateToDate arg)
    {
      return Client.PostAsync<ExportVisitsFromDateToDate, ExportVisitsFromDateToDateResponse>(this.username, this.password, this.baseuri, "VisitService", arg);
    }

    public ExportVisitsResponse ExportVisits(ExportVisits arg)
    {
      return Client.Post<ExportVisits, ExportVisitsResponse>(this.username, this.password, this.baseuri, "VisitService", arg);
    }

    public Task<ExportVisitsResponse> ExportVisitsAsync(ExportVisits arg)
    {
      return Client.PostAsync<ExportVisits, ExportVisitsResponse>(this.username, this.password, this.baseuri, "VisitService", arg);
    }

    public ExportVisitsFromRelativeDatesResponse ExportVisitsFromRelativeDates(
      ExportVisitsFromRelativeDates arg)
    {
      return Client.Post<ExportVisitsFromRelativeDates, ExportVisitsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "VisitService", arg);
    }

    public Task<ExportVisitsFromRelativeDatesResponse> ExportVisitsFromRelativeDatesAsync(
      ExportVisitsFromRelativeDates arg)
    {
      return Client.PostAsync<ExportVisitsFromRelativeDates, ExportVisitsFromRelativeDatesResponse>(this.username, this.password, this.baseuri, "VisitService", arg);
    }
  }
}
