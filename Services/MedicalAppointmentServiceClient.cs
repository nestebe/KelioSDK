
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
    private readonly string baseuri;

    public MedicalAppointmentServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public DeleteMedicalAppointmentsResponse DeleteMedicalAppointments(
      DeleteMedicalAppointments arg)
    {
      return Client.Post<DeleteMedicalAppointments, DeleteMedicalAppointmentsResponse>(this.username, this.password, this.baseuri, "MedicalAppointmentService", arg);
    }

    public Task<DeleteMedicalAppointmentsResponse> DeleteMedicalAppointmentsAsync(
      DeleteMedicalAppointments arg)
    {
      return Client.PostAsync<DeleteMedicalAppointments, DeleteMedicalAppointmentsResponse>(this.username, this.password, this.baseuri, "MedicalAppointmentService", arg);
    }

    public ImportMedicalAppointmentsResponse ImportMedicalAppointments(
      ImportMedicalAppointments arg)
    {
      return Client.Post<ImportMedicalAppointments, ImportMedicalAppointmentsResponse>(this.username, this.password, this.baseuri, "MedicalAppointmentService", arg);
    }

    public Task<ImportMedicalAppointmentsResponse> ImportMedicalAppointmentsAsync(
      ImportMedicalAppointments arg)
    {
      return Client.PostAsync<ImportMedicalAppointments, ImportMedicalAppointmentsResponse>(this.username, this.password, this.baseuri, "MedicalAppointmentService", arg);
    }

    public ExportMedicalAppointmentsListResponse ExportMedicalAppointmentsList(
      ExportMedicalAppointmentsList arg)
    {
      return Client.Post<ExportMedicalAppointmentsList, ExportMedicalAppointmentsListResponse>(this.username, this.password, this.baseuri, "MedicalAppointmentService", arg);
    }

    public Task<ExportMedicalAppointmentsListResponse> ExportMedicalAppointmentsListAsync(
      ExportMedicalAppointmentsList arg)
    {
      return Client.PostAsync<ExportMedicalAppointmentsList, ExportMedicalAppointmentsListResponse>(this.username, this.password, this.baseuri, "MedicalAppointmentService", arg);
    }

    public ExportMedicalAppointmentsResponse ExportMedicalAppointments(
      ExportMedicalAppointments arg)
    {
      return Client.Post<ExportMedicalAppointments, ExportMedicalAppointmentsResponse>(this.username, this.password, this.baseuri, "MedicalAppointmentService", arg);
    }

    public Task<ExportMedicalAppointmentsResponse> ExportMedicalAppointmentsAsync(
      ExportMedicalAppointments arg)
    {
      return Client.PostAsync<ExportMedicalAppointments, ExportMedicalAppointmentsResponse>(this.username, this.password, this.baseuri, "MedicalAppointmentService", arg);
    }
  }
}
