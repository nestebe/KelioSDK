
//.ImportEndOfPeriodDate




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEndOfPeriodDate")]
  public class ImportEndOfPeriodDate
  {
    [XmlArray(ElementName = "endOfPeriodDateToImport", IsNullable = false, Order = 0)]
    public List<EndOfPeriodDate> EndOfPeriodDateToImport { get; set; }
  }
}
