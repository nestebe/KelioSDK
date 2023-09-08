
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
    private readonly string baseuri;

    public ExpenseSheetTagServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportExpenseSheetTagsResponse ImportExpenseSheetTags(
      ImportExpenseSheetTags arg)
    {
      return Client.Post<ImportExpenseSheetTags, ImportExpenseSheetTagsResponse>(this.username, this.password, this.baseuri, "ExpenseSheetTagService", arg);
    }

    public Task<ImportExpenseSheetTagsResponse> ImportExpenseSheetTagsAsync(
      ImportExpenseSheetTags arg)
    {
      return Client.PostAsync<ImportExpenseSheetTags, ImportExpenseSheetTagsResponse>(this.username, this.password, this.baseuri, "ExpenseSheetTagService", arg);
    }

    public DeleteExpenseSheetTagsResponse DeleteExpenseSheetTags(
      DeleteExpenseSheetTags arg)
    {
      return Client.Post<DeleteExpenseSheetTags, DeleteExpenseSheetTagsResponse>(this.username, this.password, this.baseuri, "ExpenseSheetTagService", arg);
    }

    public Task<DeleteExpenseSheetTagsResponse> DeleteExpenseSheetTagsAsync(
      DeleteExpenseSheetTags arg)
    {
      return Client.PostAsync<DeleteExpenseSheetTags, DeleteExpenseSheetTagsResponse>(this.username, this.password, this.baseuri, "ExpenseSheetTagService", arg);
    }

    public ExportExpenseSheetTagsResponse ExportExpenseSheetTags(
      ExportExpenseSheetTags arg)
    {
      return Client.Post<ExportExpenseSheetTags, ExportExpenseSheetTagsResponse>(this.username, this.password, this.baseuri, "ExpenseSheetTagService", arg);
    }

    public Task<ExportExpenseSheetTagsResponse> ExportExpenseSheetTagsAsync(
      ExportExpenseSheetTags arg)
    {
      return Client.PostAsync<ExportExpenseSheetTags, ExportExpenseSheetTagsResponse>(this.username, this.password, this.baseuri, "ExpenseSheetTagService", arg);
    }
  }
}
