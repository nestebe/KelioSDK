
//.ExportActualSpecialHourTotalsFromRelativeDatesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportActualSpecialHourTotalsFromRelativeDatesResponse")]
  public class ExportActualSpecialHourTotalsFromRelativeDatesResponse
  {
    [XmlArray(ElementName = "exportedFromDateToDateSpecialHourTotals", IsNullable = false, Order = 0)]
    public List<FromDateToDateSpecialHourTotal> ExportedFromDateToDateSpecialHourTotals { get; set; }
  }
}
