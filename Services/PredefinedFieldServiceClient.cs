
//.PredefinedFieldServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class PredefinedFieldServiceClient
  {
    private const string service = "PredefinedFieldService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public PredefinedFieldServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportPredefinedFreeFieldsResponse ExportPredefinedFreeFields(
      ExportPredefinedFreeFields arg)
    {
      return Client.Post<ExportPredefinedFreeFields, ExportPredefinedFreeFieldsResponse>(this.username, this.password, this.baseuri, "PredefinedFieldService", arg);
    }

    public Task<ExportPredefinedFreeFieldsResponse> ExportPredefinedFreeFieldsAsync(
      ExportPredefinedFreeFields arg)
    {
      return Client.PostAsync<ExportPredefinedFreeFields, ExportPredefinedFreeFieldsResponse>(this.username, this.password, this.baseuri, "PredefinedFieldService", arg);
    }

    public ImportPredefinedFieldsResponse ImportPredefinedFields(
      ImportPredefinedFields arg)
    {
      return Client.Post<ImportPredefinedFields, ImportPredefinedFieldsResponse>(this.username, this.password, this.baseuri, "PredefinedFieldService", arg);
    }

    public Task<ImportPredefinedFieldsResponse> ImportPredefinedFieldsAsync(
      ImportPredefinedFields arg)
    {
      return Client.PostAsync<ImportPredefinedFields, ImportPredefinedFieldsResponse>(this.username, this.password, this.baseuri, "PredefinedFieldService", arg);
    }
  }
}
