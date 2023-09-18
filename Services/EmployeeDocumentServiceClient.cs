
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
    private readonly string baseuri; private readonly int timeoutSeconds;

    public EmployeeDocumentServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)  
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportEmployeeDocumentsResponse ExportEmployeeDocuments(
      ExportEmployeeDocuments arg)
    {
      return Client.Post<ExportEmployeeDocuments, ExportEmployeeDocumentsResponse>(this.username, this.password, this.baseuri, "EmployeeDocumentService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeeDocumentsResponse> ExportEmployeeDocumentsAsync(
      ExportEmployeeDocuments arg)
    {
      return Client.PostAsync<ExportEmployeeDocuments, ExportEmployeeDocumentsResponse>(this.username, this.password, this.baseuri, "EmployeeDocumentService", arg, this.timeoutSeconds);
    }

    public ImportEmployeeDocumentsResponse ImportEmployeeDocuments(
      ImportEmployeeDocuments arg)
    {
      return Client.Post<ImportEmployeeDocuments, ImportEmployeeDocumentsResponse>(this.username, this.password, this.baseuri, "EmployeeDocumentService", arg, this.timeoutSeconds);
    }

    public Task<ImportEmployeeDocumentsResponse> ImportEmployeeDocumentsAsync(
      ImportEmployeeDocuments arg)
    {
      return Client.PostAsync<ImportEmployeeDocuments, ImportEmployeeDocumentsResponse>(this.username, this.password, this.baseuri, "EmployeeDocumentService", arg, this.timeoutSeconds);
    }
  }
}
