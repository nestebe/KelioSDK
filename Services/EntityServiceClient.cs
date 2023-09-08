
//.EntityServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EntityServiceClient
  {
    private const string service = "EntityService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public EntityServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportEntitiesResponse ImportEntities(ImportEntities arg)
    {
      return Client.Post<ImportEntities, ImportEntitiesResponse>(this.username, this.password, this.baseuri, "EntityService", arg);
    }

    public Task<ImportEntitiesResponse> ImportEntitiesAsync(
      ImportEntities arg)
    {
      return Client.PostAsync<ImportEntities, ImportEntitiesResponse>(this.username, this.password, this.baseuri, "EntityService", arg);
    }

    public DeleteEntitiesResponse DeleteEntities(DeleteEntities arg)
    {
      return Client.Post<DeleteEntities, DeleteEntitiesResponse>(this.username, this.password, this.baseuri, "EntityService", arg);
    }

    public Task<DeleteEntitiesResponse> DeleteEntitiesAsync(
      DeleteEntities arg)
    {
      return Client.PostAsync<DeleteEntities, DeleteEntitiesResponse>(this.username, this.password, this.baseuri, "EntityService", arg);
    }

    public ExportEntitiesResponse ExportEntities(ExportEntities arg)
    {
      return Client.Post<ExportEntities, ExportEntitiesResponse>(this.username, this.password, this.baseuri, "EntityService", arg);
    }

    public Task<ExportEntitiesResponse> ExportEntitiesAsync(
      ExportEntities arg)
    {
      return Client.PostAsync<ExportEntities, ExportEntitiesResponse>(this.username, this.password, this.baseuri, "EntityService", arg);
    }
  }
}
