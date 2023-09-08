
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
    private readonly string baseuri;

    public EmployeePictureServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportEmployeePicturesResponse ExportEmployeePictures(
      ExportEmployeePictures arg)
    {
      return Client.Post<ExportEmployeePictures, ExportEmployeePicturesResponse>(this.username, this.password, this.baseuri, "EmployeePictureService", arg);
    }

    public Task<ExportEmployeePicturesResponse> ExportEmployeePicturesAsync(
      ExportEmployeePictures arg)
    {
      return Client.PostAsync<ExportEmployeePictures, ExportEmployeePicturesResponse>(this.username, this.password, this.baseuri, "EmployeePictureService", arg);
    }

    public ExportEmployeePicturesListResponse ExportEmployeePicturesList(
      ExportEmployeePicturesList arg)
    {
      return Client.Post<ExportEmployeePicturesList, ExportEmployeePicturesListResponse>(this.username, this.password, this.baseuri, "EmployeePictureService", arg);
    }

    public Task<ExportEmployeePicturesListResponse> ExportEmployeePicturesListAsync(
      ExportEmployeePicturesList arg)
    {
      return Client.PostAsync<ExportEmployeePicturesList, ExportEmployeePicturesListResponse>(this.username, this.password, this.baseuri, "EmployeePictureService", arg);
    }

    public ImportEmployeePicturesResponse ImportEmployeePictures(
      ImportEmployeePictures arg)
    {
      return Client.Post<ImportEmployeePictures, ImportEmployeePicturesResponse>(this.username, this.password, this.baseuri, "EmployeePictureService", arg);
    }

    public Task<ImportEmployeePicturesResponse> ImportEmployeePicturesAsync(
      ImportEmployeePictures arg)
    {
      return Client.PostAsync<ImportEmployeePictures, ImportEmployeePicturesResponse>(this.username, this.password, this.baseuri, "EmployeePictureService", arg);
    }
  }
}
