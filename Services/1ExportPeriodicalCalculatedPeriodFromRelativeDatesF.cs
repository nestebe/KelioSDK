
//.ExportPeriodicalCalculatedPeriodFromRelativeDatesForEmployeeListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportPeriodicalCalculatedPeriodFromRelativeDatesForEmployeeListResponse")]
  public class ExportPeriodicalCalculatedPeriodFromRelativeDatesForEmployeeListResponse
  {
    [XmlArray(ElementName = "exportedPeriodicalCalculatedPeriods", IsNullable = false, Order = 0)]
    public List<CalculatedPeriod> ExportedPeriodicalCalculatedPeriods { get; set; }
  }
}
