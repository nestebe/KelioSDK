
//.LoansAndBorrowingsServiceClient




using KelioSDK.Common;
using System.Threading.Tasks;

namespace KelioSDK.Services
{
  public class LoansAndBorrowingsServiceClient
  {
    private const string service = "LoansAndBorrowingsService";
    private readonly string username;
    private readonly string password;
    private readonly string baseuri;

    public LoansAndBorrowingsServiceClient(string username, string password, string baseuri)
    {
      this.username = username;
      this.password = password;
      this.baseuri = baseuri;
    }

    public ExportLoansAndBorrowingsResponse ExportLoansAndBorrowings(
      ExportLoansAndBorrowings arg)
    {
      return Client.Post<ExportLoansAndBorrowings, ExportLoansAndBorrowingsResponse>(this.username, this.password, this.baseuri, "LoansAndBorrowingsService", arg);
    }

    public Task<ExportLoansAndBorrowingsResponse> ExportLoansAndBorrowingsAsync(
      ExportLoansAndBorrowings arg)
    {
      return Client.PostAsync<ExportLoansAndBorrowings, ExportLoansAndBorrowingsResponse>(this.username, this.password, this.baseuri, "LoansAndBorrowingsService", arg);
    }
  }
}
