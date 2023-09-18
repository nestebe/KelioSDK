
//.MedicalAppointmentServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class MedicalAppointmentServiceClient
  {
    private const string service = "MedicalAppointmentService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri; private readonly int timeoutSeconds;

    public MedicalAppointmentServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri; this.timeoutSeconds = timeoutSeconds;
    }

    public DeleteMedicalAppointmentsResponse DeleteMedicalAppointments(
      DeleteMedicalAppointments arg)
    {
      return Client.Post<DeleteMedicalAppointments, DeleteMedicalAppointmentsResponse>(this.username, this.password, this.baseuri, "MedicalAppointmentService", arg, this.timeoutSeconds);
    }

    public Task<DeleteMedicalAppointmentsResponse> DeleteMedicalAppointmentsAsync(
      DeleteMedicalAppointments arg)
    {
      return Client.PostAsync<DeleteMedicalAppointments, DeleteMedicalAppointmentsResponse>(this.username, this.password, this.baseuri, "MedicalAppointmentService", arg, this.timeoutSeconds);
    }

    public ImportMedicalAppointmentsResponse ImportMedicalAppointments(
      ImportMedicalAppointments arg)
    {
      return Client.Post<ImportMedicalAppointments, ImportMedicalAppointmentsResponse>(this.username, this.password, this.baseuri, "MedicalAppointmentService", arg, this.timeoutSeconds);
    }

    public Task<ImportMedicalAppointmentsResponse> ImportMedicalAppointmentsAsync(
      ImportMedicalAppointments arg)
    {
      return Client.PostAsync<ImportMedicalAppointments, ImportMedicalAppointmentsResponse>(this.username, this.password, this.baseuri, "MedicalAppointmentService", arg, this.timeoutSeconds);
    }

    public ExportMedicalAppointmentsListResponse ExportMedicalAppointmentsList(
      ExportMedicalAppointmentsList arg)
    {
      return Client.Post<ExportMedicalAppointmentsList, ExportMedicalAppointmentsListResponse>(this.username, this.password, this.baseuri, "MedicalAppointmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportMedicalAppointmentsListResponse> ExportMedicalAppointmentsListAsync(
      ExportMedicalAppointmentsList arg)
    {
      return Client.PostAsync<ExportMedicalAppointmentsList, ExportMedicalAppointmentsListResponse>(this.username, this.password, this.baseuri, "MedicalAppointmentService", arg, this.timeoutSeconds);
    }

    public ExportMedicalAppointmentsResponse ExportMedicalAppointments(
      ExportMedicalAppointments arg)
    {
      return Client.Post<ExportMedicalAppointments, ExportMedicalAppointmentsResponse>(this.username, this.password, this.baseuri, "MedicalAppointmentService", arg, this.timeoutSeconds);
    }

    public Task<ExportMedicalAppointmentsResponse> ExportMedicalAppointmentsAsync(
      ExportMedicalAppointments arg)
    {
      return Client.PostAsync<ExportMedicalAppointments, ExportMedicalAppointmentsResponse>(this.username, this.password, this.baseuri, "MedicalAppointmentService", arg, this.timeoutSeconds);
    }
  }
}
