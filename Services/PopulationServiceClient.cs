
//.PopulationServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class PopulationServiceClient
  {
    private const string service = "PopulationService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public PopulationServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportMixedPopulationResponse ImportMixedPopulation(
      ImportMixedPopulation arg)
    {
      return Client.Post<ImportMixedPopulation, ImportMixedPopulationResponse>(this.username, this.password, this.baseuri, "PopulationService", arg);
    }

    public Task<ImportMixedPopulationResponse> ImportMixedPopulationAsync(
      ImportMixedPopulation arg)
    {
      return Client.PostAsync<ImportMixedPopulation, ImportMixedPopulationResponse>(this.username, this.password, this.baseuri, "PopulationService", arg);
    }

    public ExportPopulationDescriptionsResponse ExportPopulationDescriptions(
      ExportPopulationDescriptions arg)
    {
      return Client.Post<ExportPopulationDescriptions, ExportPopulationDescriptionsResponse>(this.username, this.password, this.baseuri, "PopulationService", arg);
    }

    public Task<ExportPopulationDescriptionsResponse> ExportPopulationDescriptionsAsync(
      ExportPopulationDescriptions arg)
    {
      return Client.PostAsync<ExportPopulationDescriptions, ExportPopulationDescriptionsResponse>(this.username, this.password, this.baseuri, "PopulationService", arg);
    }

    public ExportPopulationResponse ExportPopulation(ExportPopulation arg)
    {
      return Client.Post<ExportPopulation, ExportPopulationResponse>(this.username, this.password, this.baseuri, "PopulationService", arg);
    }

    public Task<ExportPopulationResponse> ExportPopulationAsync(
      ExportPopulation arg)
    {
      return Client.PostAsync<ExportPopulation, ExportPopulationResponse>(this.username, this.password, this.baseuri, "PopulationService", arg);
    }
  }
}
