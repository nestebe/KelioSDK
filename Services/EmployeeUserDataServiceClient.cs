﻿
//.EmployeeUserDataServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class EmployeeUserDataServiceClient
  {
    private const string service = "EmployeeUserDataService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public EmployeeUserDataServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)  
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public ExportEmployeeUserDataResponse ExportEmployeeUserData(
      ExportEmployeeUserData arg)
    {
      return Client.Post<ExportEmployeeUserData, ExportEmployeeUserDataResponse>(this.username, this.password, this.baseuri, "EmployeeUserDataService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeeUserDataResponse> ExportEmployeeUserDataAsync(
      ExportEmployeeUserData arg)
    {
      return Client.PostAsync<ExportEmployeeUserData, ExportEmployeeUserDataResponse>(this.username, this.password, this.baseuri, "EmployeeUserDataService", arg, this.timeoutSeconds);
    }

    public ExportEmployeeUserDataListResponse ExportEmployeeUserDataList(
      ExportEmployeeUserDataList arg)
    {
      return Client.Post<ExportEmployeeUserDataList, ExportEmployeeUserDataListResponse>(this.username, this.password, this.baseuri, "EmployeeUserDataService", arg, this.timeoutSeconds);
    }

    public Task<ExportEmployeeUserDataListResponse> ExportEmployeeUserDataListAsync(
      ExportEmployeeUserDataList arg)
    {
      return Client.PostAsync<ExportEmployeeUserDataList, ExportEmployeeUserDataListResponse>(this.username, this.password, this.baseuri, "EmployeeUserDataService", arg, this.timeoutSeconds);
    }

    public ImportEmployeeUserDataResponse ImportEmployeeUserData(
      ImportEmployeeUserData arg)
    {
      return Client.Post<ImportEmployeeUserData, ImportEmployeeUserDataResponse>(this.username, this.password, this.baseuri, "EmployeeUserDataService", arg, this.timeoutSeconds);
    }

    public Task<ImportEmployeeUserDataResponse> ImportEmployeeUserDataAsync(
      ImportEmployeeUserData arg)
    {
      return Client.PostAsync<ImportEmployeeUserData, ImportEmployeeUserDataResponse>(this.username, this.password, this.baseuri, "EmployeeUserDataService", arg, this.timeoutSeconds);
    }
  }
}
