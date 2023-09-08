
//.WorkbookServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class WorkbookServiceClient
  {
    private const string service = "WorkbookService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public WorkbookServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportWorkbooksResponse ExportWorkbooks(ExportWorkbooks arg)
    {
      return Client.Post<ExportWorkbooks, ExportWorkbooksResponse>(this.username, this.password, this.baseuri, "WorkbookService", arg);
    }

    public Task<ExportWorkbooksResponse> ExportWorkbooksAsync(
      ExportWorkbooks arg)
    {
      return Client.PostAsync<ExportWorkbooks, ExportWorkbooksResponse>(this.username, this.password, this.baseuri, "WorkbookService", arg);
    }

    public ImportWorkbooksResponse ImportWorkbooks(ImportWorkbooks arg)
    {
      return Client.Post<ImportWorkbooks, ImportWorkbooksResponse>(this.username, this.password, this.baseuri, "WorkbookService", arg);
    }

    public Task<ImportWorkbooksResponse> ImportWorkbooksAsync(
      ImportWorkbooks arg)
    {
      return Client.PostAsync<ImportWorkbooks, ImportWorkbooksResponse>(this.username, this.password, this.baseuri, "WorkbookService", arg);
    }

    public DeleteWorkbooksResponse DeleteWorkbooks(DeleteWorkbooks arg)
    {
      return Client.Post<DeleteWorkbooks, DeleteWorkbooksResponse>(this.username, this.password, this.baseuri, "WorkbookService", arg);
    }

    public Task<DeleteWorkbooksResponse> DeleteWorkbooksAsync(
      DeleteWorkbooks arg)
    {
      return Client.PostAsync<DeleteWorkbooks, DeleteWorkbooksResponse>(this.username, this.password, this.baseuri, "WorkbookService", arg);
    }
  }
}
