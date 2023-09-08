
//.ExportPayrollPeriodsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPayrollPeriodsResponse")]
  public class ExportPayrollPeriodsResponse
  {
    [XmlArray(ElementName = "exportedPayrollPeriods", IsNullable = false, Order = 0)]
    public List<PayrollPeriod> ExportedPayrollPeriods { get; set; }
  }
}
