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
        private readonly int timeoutSeconds;

        public BookingServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportBookingResponse ExportBooking(ExportBooking arg)
        {
            return Client.Post<ExportBooking, ExportBookingResponse>(this.username, this.password, this.baseuri,
                "BookingService", arg, this.timeoutSeconds);
        }

        public Task<ExportBookingResponse> ExportBookingAsync(ExportBooking arg)
        {
            return Client.PostAsync<ExportBooking, ExportBookingResponse>(this.username, this.password, this.baseuri,
                "BookingService", arg, this.timeoutSeconds);
        }
    }
}