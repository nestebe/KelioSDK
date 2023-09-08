﻿
//.PreliminaryPlanningActionsServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class PreliminaryPlanningActionsServiceClient
  {
    private const string service = "PreliminaryPlanningActionsService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public PreliminaryPlanningActionsServiceClient(
      string username,
      string password,
      string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportPreliminaryPlanningActionsServiceResponse ExportPreliminaryPlanningActionsService(
      ExportPreliminaryPlanningActionsService arg)
    {
      return Client.Post<ExportPreliminaryPlanningActionsService, ExportPreliminaryPlanningActionsServiceResponse>(this.username, this.password, this.baseuri, "PreliminaryPlanningActionsService", arg);
    }

    public Task<ExportPreliminaryPlanningActionsServiceResponse> ExportPreliminaryPlanningActionsServiceAsync(
      ExportPreliminaryPlanningActionsService arg)
    {
      return Client.PostAsync<ExportPreliminaryPlanningActionsService, ExportPreliminaryPlanningActionsServiceResponse>(this.username, this.password, this.baseuri, "PreliminaryPlanningActionsService", arg);
    }
  }
}
