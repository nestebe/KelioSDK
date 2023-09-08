
//.EmployeeDocumentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmployeeDocumentServiceClient
  {
    private const string service = "EmployeeDocumentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public EmployeeDocumentServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportEmployeeDocumentsResponse ExportEmployeeDocuments(
      ExportEmployeeDocuments arg)
    {
      return Client.Post<ExportEmployeeDocuments, ExportEmployeeDocumentsResponse>(this.username, this.password, this.baseuri, "EmployeeDocumentService", arg);
    }

    public Task<ExportEmployeeDocumentsResponse> ExportEmployeeDocumentsAsync(
      ExportEmployeeDocuments arg)
    {
      return Client.PostAsync<ExportEmployeeDocuments, ExportEmployeeDocumentsResponse>(this.username, this.password, this.baseuri, "EmployeeDocumentService", arg);
    }

    public ImportEmployeeDocumentsResponse ImportEmployeeDocuments(
      ImportEmployeeDocuments arg)
    {
      return Client.Post<ImportEmployeeDocuments, ImportEmployeeDocumentsResponse>(this.username, this.password, this.baseuri, "EmployeeDocumentService", arg);
    }

    public Task<ImportEmployeeDocumentsResponse> ImportEmployeeDocumentsAsync(
      ImportEmployeeDocuments arg)
    {
      return Client.PostAsync<ImportEmployeeDocuments, ImportEmployeeDocumentsResponse>(this.username, this.password, this.baseuri, "EmployeeDocumentService", arg);
    }
  }
}
