
//.SectionAssignmentDayPerDayServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class SectionAssignmentDayPerDayServiceClient
  {
    private const string service = "SectionAssignmentDayPerDayService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public SectionAssignmentDayPerDayServiceClient(
      string username,
      string password,
      string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportSectionAssignmentsDayPerDayResponse ExportSectionAssignmentsDayPerDay(
      ExportSectionAssignmentsDayPerDay arg)
    {
      return Client.Post<ExportSectionAssignmentsDayPerDay, ExportSectionAssignmentsDayPerDayResponse>(this.username, this.password, this.baseuri, "SectionAssignmentDayPerDayService", arg, this.timeoutSeconds);
    }

    public Task<ExportSectionAssignmentsDayPerDayResponse> ExportSectionAssignmentsDayPerDayAsync(
      ExportSectionAssignmentsDayPerDay arg)
    {
      return Client.PostAsync<ExportSectionAssignmentsDayPerDay, ExportSectionAssignmentsDayPerDayResponse>(this.username, this.password, this.baseuri, "SectionAssignmentDayPerDayService", arg, this.timeoutSeconds);
    }

    public ExportSectionAssignmentsDayPerDayListResponse ExportSectionAssignmentsDayPerDayList(
      ExportSectionAssignmentsDayPerDayList arg)
    {
      return Client.Post<ExportSectionAssignmentsDayPerDayList, ExportSectionAssignmentsDayPerDayListResponse>(this.username, this.password, this.baseuri, "SectionAssignmentDayPerDayService", arg, this.timeoutSeconds);
    }

    public Task<ExportSectionAssignmentsDayPerDayListResponse> ExportSectionAssignmentsDayPerDayListAsync(
      ExportSectionAssignmentsDayPerDayList arg)
    {
      return Client.PostAsync<ExportSectionAssignmentsDayPerDayList, ExportSectionAssignmentsDayPerDayListResponse>(this.username, this.password, this.baseuri, "SectionAssignmentDayPerDayService", arg, this.timeoutSeconds);
    }
  }
}
