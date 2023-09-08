
//.ImportToilCalendarFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importToilCalendarFiling")]
  public class ImportToilCalendarFiling
  {
    [XmlArray(ElementName = "toilCalendarFilingToImport", IsNullable = false, Order = 0)]
    public List<Filing> ToilCalendarFilingToImport { get; set; }
  }
}
