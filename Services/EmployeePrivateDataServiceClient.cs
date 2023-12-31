﻿
//.EmployeePrivateDataServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmployeePrivateDataServiceClient
  {
    private const string service = "EmployeePrivateDataService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public EmployeePrivateDataServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)  
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportEmployeePrivateDataResponse ExportEmployeePrivateData(
      ExportEmployeePrivateData arg)
    {
      return Client.Post<ExportEmployeePrivateData, ExportEmployeePrivateDataResponse>(this.username, this.password, this.baseuri, "EmployeePrivateDataService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeePrivateDataResponse> ExportEmployeePrivateDataAsync(
      ExportEmployeePrivateData arg)
    {
      return Client.PostAsync<ExportEmployeePrivateData, ExportEmployeePrivateDataResponse>(this.username, this.password, this.baseuri, "EmployeePrivateDataService", arg, this.timeoutSeconds);
    }

    public ExportEmployeePrivateDataListResponse ExportEmployeePrivateDataList(
      ExportEmployeePrivateDataList arg)
    {
      return Client.Post<ExportEmployeePrivateDataList, ExportEmployeePrivateDataListResponse>(this.username, this.password, this.baseuri, "EmployeePrivateDataService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeePrivateDataListResponse> ExportEmployeePrivateDataListAsync(
      ExportEmployeePrivateDataList arg)
    {
      return Client.PostAsync<ExportEmployeePrivateDataList, ExportEmployeePrivateDataListResponse>(this.username, this.password, this.baseuri, "EmployeePrivateDataService", arg, this.timeoutSeconds);
    }

    public ImportEmployeePrivateDataResponse ImportEmployeePrivateData(
      ImportEmployeePrivateData arg)
    {
      return Client.Post<ImportEmployeePrivateData, ImportEmployeePrivateDataResponse>(this.username, this.password, this.baseuri, "EmployeePrivateDataService", arg, this.timeoutSeconds);
    }

    public Task<ImportEmployeePrivateDataResponse> ImportEmployeePrivateDataAsync(
      ImportEmployeePrivateData arg)
    {
      return Client.PostAsync<ImportEmployeePrivateData, ImportEmployeePrivateDataResponse>(this.username, this.password, this.baseuri, "EmployeePrivateDataService", arg, this.timeoutSeconds);
    }
  }
}
