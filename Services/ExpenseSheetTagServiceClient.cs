
//.ExpenseSheetTagServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class ExpenseSheetTagServiceClient
  {
    private const string service = "ExpenseSheetTagService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public ExpenseSheetTagServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ImportExpenseSheetTagsResponse ImportExpenseSheetTags(
      ImportExpenseSheetTags arg)
    {
      return Client.Post<ImportExpenseSheetTags, ImportExpenseSheetTagsResponse>(this.username, this.password, this.baseuri, "ExpenseSheetTagService", arg, this.timeoutSeconds);
    }

    public Task<ImportExpenseSheetTagsResponse> ImportExpenseSheetTagsAsync(
      ImportExpenseSheetTags arg)
    {
      return Client.PostAsync<ImportExpenseSheetTags, ImportExpenseSheetTagsResponse>(this.username, this.password, this.baseuri, "ExpenseSheetTagService", arg, this.timeoutSeconds);
    }

    public DeleteExpenseSheetTagsResponse DeleteExpenseSheetTags(
      DeleteExpenseSheetTags arg)
    {
      return Client.Post<DeleteExpenseSheetTags, DeleteExpenseSheetTagsResponse>(this.username, this.password, this.baseuri, "ExpenseSheetTagService", arg, this.timeoutSeconds);
    }

    public Task<DeleteExpenseSheetTagsResponse> DeleteExpenseSheetTagsAsync(
      DeleteExpenseSheetTags arg)
    {
      return Client.PostAsync<DeleteExpenseSheetTags, DeleteExpenseSheetTagsResponse>(this.username, this.password, this.baseuri, "ExpenseSheetTagService", arg, this.timeoutSeconds);
    }

    public ExportExpenseSheetTagsResponse ExportExpenseSheetTags(
      ExportExpenseSheetTags arg)
    {
      return Client.Post<ExportExpenseSheetTags, ExportExpenseSheetTagsResponse>(this.username, this.password, this.baseuri, "ExpenseSheetTagService", arg, this.timeoutSeconds);
    }

    public Task<ExportExpenseSheetTagsResponse> ExportExpenseSheetTagsAsync(
      ExportExpenseSheetTags arg)
    {
      return Client.PostAsync<ExportExpenseSheetTags, ExportExpenseSheetTagsResponse>(this.username, this.password, this.baseuri, "ExpenseSheetTagService", arg, this.timeoutSeconds);
    }
  }
}
