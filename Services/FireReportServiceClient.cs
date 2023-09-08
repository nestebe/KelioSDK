
//.FireReportServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class FireReportServiceClient
  {
    private const string service = "FireReportService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public FireReportServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportDetailFireReportPeoplePresentResponse ExportDetailFireReportPeoplePresent(
      ExportDetailFireReportPeoplePresent arg)
    {
      return Client.Post<ExportDetailFireReportPeoplePresent, ExportDetailFireReportPeoplePresentResponse>(this.username, this.password, this.baseuri, "FireReportService", arg);
    }

    public Task<ExportDetailFireReportPeoplePresentResponse> ExportDetailFireReportPeoplePresentAsync(
      ExportDetailFireReportPeoplePresent arg)
    {
      return Client.PostAsync<ExportDetailFireReportPeoplePresent, ExportDetailFireReportPeoplePresentResponse>(this.username, this.password, this.baseuri, "FireReportService", arg);
    }

    public ExportFireReportPeoplePresentResponse ExportFireReportPeoplePresent(
      ExportFireReportPeoplePresent arg)
    {
      return Client.Post<ExportFireReportPeoplePresent, ExportFireReportPeoplePresentResponse>(this.username, this.password, this.baseuri, "FireReportService", arg);
    }

    public Task<ExportFireReportPeoplePresentResponse> ExportFireReportPeoplePresentAsync(
      ExportFireReportPeoplePresent arg)
    {
      return Client.PostAsync<ExportFireReportPeoplePresent, ExportFireReportPeoplePresentResponse>(this.username, this.password, this.baseuri, "FireReportService", arg);
    }
  }
}
