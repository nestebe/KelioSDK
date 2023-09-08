
//.EmergencyContactServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmergencyContactServiceClient
  {
    private const string service = "EmergencyContactService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public EmergencyContactServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public DeleteEmergencyContactResponse DeleteEmergencyContact(
      DeleteEmergencyContact arg)
    {
      return Client.Post<DeleteEmergencyContact, DeleteEmergencyContactResponse>(this.username, this.password, this.baseuri, "EmergencyContactService", arg);
    }

    public Task<DeleteEmergencyContactResponse> DeleteEmergencyContactAsync(
      DeleteEmergencyContact arg)
    {
      return Client.PostAsync<DeleteEmergencyContact, DeleteEmergencyContactResponse>(this.username, this.password, this.baseuri, "EmergencyContactService", arg);
    }

    public ExportEmergencyContactResponse ExportEmergencyContact(
      ExportEmergencyContact arg)
    {
      return Client.Post<ExportEmergencyContact, ExportEmergencyContactResponse>(this.username, this.password, this.baseuri, "EmergencyContactService", arg);
    }

    public Task<ExportEmergencyContactResponse> ExportEmergencyContactAsync(
      ExportEmergencyContact arg)
    {
      return Client.PostAsync<ExportEmergencyContact, ExportEmergencyContactResponse>(this.username, this.password, this.baseuri, "EmergencyContactService", arg);
    }

    public ImportEmergencyContactResponse ImportEmergencyContact(
      ImportEmergencyContact arg)
    {
      return Client.Post<ImportEmergencyContact, ImportEmergencyContactResponse>(this.username, this.password, this.baseuri, "EmergencyContactService", arg);
    }

    public Task<ImportEmergencyContactResponse> ImportEmergencyContactAsync(
      ImportEmergencyContact arg)
    {
      return Client.PostAsync<ImportEmergencyContact, ImportEmergencyContactResponse>(this.username, this.password, this.baseuri, "EmergencyContactService", arg);
    }
  }
}
