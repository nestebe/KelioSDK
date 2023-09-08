
//.SectionAssignmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class SectionAssignmentServiceClient
  {
    private const string service = "SectionAssignmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public SectionAssignmentServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportSectionAssignmentsResponse ImportSectionAssignments(
      ImportSectionAssignments arg)
    {
      return Client.Post<ImportSectionAssignments, ImportSectionAssignmentsResponse>(this.username, this.password, this.baseuri, "SectionAssignmentService", arg);
    }

    public Task<ImportSectionAssignmentsResponse> ImportSectionAssignmentsAsync(
      ImportSectionAssignments arg)
    {
      return Client.PostAsync<ImportSectionAssignments, ImportSectionAssignmentsResponse>(this.username, this.password, this.baseuri, "SectionAssignmentService", arg);
    }

    public ExportSectionAssignmentsResponse ExportSectionAssignments(
      ExportSectionAssignments arg)
    {
      return Client.Post<ExportSectionAssignments, ExportSectionAssignmentsResponse>(this.username, this.password, this.baseuri, "SectionAssignmentService", arg);
    }

    public Task<ExportSectionAssignmentsResponse> ExportSectionAssignmentsAsync(
      ExportSectionAssignments arg)
    {
      return Client.PostAsync<ExportSectionAssignments, ExportSectionAssignmentsResponse>(this.username, this.password, this.baseuri, "SectionAssignmentService", arg);
    }

    public ExportSectionAssignmentsListResponse ExportSectionAssignmentsList(
      ExportSectionAssignmentsList arg)
    {
      return Client.Post<ExportSectionAssignmentsList, ExportSectionAssignmentsListResponse>(this.username, this.password, this.baseuri, "SectionAssignmentService", arg);
    }

    public Task<ExportSectionAssignmentsListResponse> ExportSectionAssignmentsListAsync(
      ExportSectionAssignmentsList arg)
    {
      return Client.PostAsync<ExportSectionAssignmentsList, ExportSectionAssignmentsListResponse>(this.username, this.password, this.baseuri, "SectionAssignmentService", arg);
    }
  }
}
