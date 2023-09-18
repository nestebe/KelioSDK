//.TransportTicketServiceClient


using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
    public class TransportTicketServiceClient
    {
        private const string service = "TransportTicketService";
        private readonly string username;
        private readonly string password;
        private readonly string baseuri;
        private readonly int timeoutSeconds;

        public TransportTicketServiceClient(string username, string password, string baseuri, int timeoutSeconds = 60)
        {
            this.username = username;
            this.password = password;
            this.baseuri = baseuri;
            this.timeoutSeconds = timeoutSeconds;
        }

        public ExportTransportTicketsResponse ExportTransportTickets(
            ExportTransportTickets arg)
        {
            return Client.Post<ExportTransportTickets, ExportTransportTicketsResponse>(this.username, this.password,
                this.baseuri, "TransportTicketService", arg, this.timeoutSeconds);
        }

        public Task<ExportTransportTicketsResponse> ExportTransportTicketsAsync(
            ExportTransportTickets arg)
        {
            return Client.PostAsync<ExportTransportTickets, ExportTransportTicketsResponse>(this.username,
                this.password, this.baseuri, "TransportTicketService", arg, this.timeoutSeconds);
        }

        public ExportTransportTicketsListResponse ExportTransportTicketsList(
            ExportTransportTicketsList arg)
        {
            return Client.Post<ExportTransportTicketsList, ExportTransportTicketsListResponse>(this.username,
                this.password, this.baseuri, "TransportTicketService", arg, this.timeoutSeconds);
        }

        public Task<ExportTransportTicketsListResponse> ExportTransportTicketsListAsync(
            ExportTransportTicketsList arg)
        {
            return Client.PostAsync<ExportTransportTicketsList, ExportTransportTicketsListResponse>(this.username,
                this.password, this.baseuri, "TransportTicketService", arg, this.timeoutSeconds);
        }

        public ImportTransportTicketsResponse ImportTransportTickets(
            ImportTransportTickets arg)
        {
            return Client.Post<ImportTransportTickets, ImportTransportTicketsResponse>(this.username, this.password,
                this.baseuri, "TransportTicketService", arg, this.timeoutSeconds);
        }

        public Task<ImportTransportTicketsResponse> ImportTransportTicketsAsync(
            ImportTransportTickets arg)
        {
            return Client.PostAsync<ImportTransportTickets, ImportTransportTicketsResponse>(this.username,
                this.password, this.baseuri, "TransportTicketService", arg, this.timeoutSeconds);
        }
    }
}