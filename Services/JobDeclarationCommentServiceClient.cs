
//.JobDeclarationCommentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class JobDeclarationCommentServiceClient
  {
    private const string service = "JobDeclarationCommentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public JobDeclarationCommentServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportJobDeclarationCommentsResponse ExportJobDeclarationComments(
      ExportJobDeclarationComments arg)
    {
      return Client.Post<ExportJobDeclarationComments, ExportJobDeclarationCommentsResponse>(this.username, this.password, this.baseuri, "JobDeclarationCommentService", arg, this.timeoutSeconds);
    }

    public Task<ExportJobDeclarationCommentsResponse> ExportJobDeclarationCommentsAsync(
      ExportJobDeclarationComments arg)
    {
      return Client.PostAsync<ExportJobDeclarationComments, ExportJobDeclarationCommentsResponse>(this.username, this.password, this.baseuri, "JobDeclarationCommentService", arg, this.timeoutSeconds);
    }
  }
}
