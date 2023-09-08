
//.ImportPublicHolidays




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importPublicHolidays")]
  public class ImportPublicHolidays
  {
    [XmlArray(ElementName = "publicHolidaysToImport", IsNullable = false, Order = 0)]
    public List<PublicHoliday> PublicHolidaysToImport { get; set; }
  }
}
