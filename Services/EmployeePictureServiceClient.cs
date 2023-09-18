
//.EmployeePictureServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmployeePictureServiceClient
  {
    private const string service = "EmployeePictureService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public EmployeePictureServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)  
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportEmployeePicturesResponse ExportEmployeePictures(
      ExportEmployeePictures arg)
    {
      return Client.Post<ExportEmployeePictures, ExportEmployeePicturesResponse>(this.username, this.password, this.baseuri, "EmployeePictureService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeePicturesResponse> ExportEmployeePicturesAsync(
      ExportEmployeePictures arg)
    {
      return Client.PostAsync<ExportEmployeePictures, ExportEmployeePicturesResponse>(this.username, this.password, this.baseuri, "EmployeePictureService", arg, this.timeoutSeconds);
    }

    public ExportEmployeePicturesListResponse ExportEmployeePicturesList(
      ExportEmployeePicturesList arg)
    {
      return Client.Post<ExportEmployeePicturesList, ExportEmployeePicturesListResponse>(this.username, this.password, this.baseuri, "EmployeePictureService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeePicturesListResponse> ExportEmployeePicturesListAsync(
      ExportEmployeePicturesList arg)
    {
      return Client.PostAsync<ExportEmployeePicturesList, ExportEmployeePicturesListResponse>(this.username, this.password, this.baseuri, "EmployeePictureService", arg, this.timeoutSeconds);
    }

    public ImportEmployeePicturesResponse ImportEmployeePictures(
      ImportEmployeePictures arg)
    {
      return Client.Post<ImportEmployeePictures, ImportEmployeePicturesResponse>(this.username, this.password, this.baseuri, "EmployeePictureService", arg, this.timeoutSeconds);
    }

    public Task<ImportEmployeePicturesResponse> ImportEmployeePicturesAsync(
      ImportEmployeePictures arg)
    {
      return Client.PostAsync<ImportEmployeePictures, ImportEmployeePicturesResponse>(this.username, this.password, this.baseuri, "EmployeePictureService", arg, this.timeoutSeconds);
    }
  }
}
