
//.SkillServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class SkillServiceClient
  {
    private const string service = "SkillService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public SkillServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ImportSkillsResponse ImportSkills(ImportSkills arg)
    {
      return Client.Post<ImportSkills, ImportSkillsResponse>(this.username, this.password, this.baseuri, "SkillService", arg);
    }

    public Task<ImportSkillsResponse> ImportSkillsAsync(ImportSkills arg)
    {
      return Client.PostAsync<ImportSkills, ImportSkillsResponse>(this.username, this.password, this.baseuri, "SkillService", arg);
    }

    public ExportSkillsResponse ExportSkills(ExportSkills arg)
    {
      return Client.Post<ExportSkills, ExportSkillsResponse>(this.username, this.password, this.baseuri, "SkillService", arg);
    }

    public Task<ExportSkillsResponse> ExportSkillsAsync(ExportSkills arg)
    {
      return Client.PostAsync<ExportSkills, ExportSkillsResponse>(this.username, this.password, this.baseuri, "SkillService", arg);
    }
  }
}
