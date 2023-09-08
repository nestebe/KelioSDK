
//.ExportLoansAndBorrowingsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportLoansAndBorrowingsResponse")]
  public class ExportLoansAndBorrowingsResponse
  {
    [XmlArray(ElementName = "exportedLoansAndBorrowings", IsNullable = false, Order = 0)]
    public List<EmployeeLoanedOrBorrowed> ExportedLoansAndBorrowings { get; set; }
  }
}
