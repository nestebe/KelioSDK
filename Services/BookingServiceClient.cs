
//.BookingServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class BookingServiceClient
  {
    private const string service = "BookingService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public BookingServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportBookingResponse ExportBooking(ExportBooking arg)
    {
      return Client.Post<ExportBooking, ExportBookingResponse>(this.username, this.password, this.baseuri, "BookingService", arg);
    }

    public Task<ExportBookingResponse> ExportBookingAsync(ExportBooking arg)
    {
      return Client.PostAsync<ExportBooking, ExportBookingResponse>(this.username, this.password, this.baseuri, "BookingService", arg);
    }
  }
}
