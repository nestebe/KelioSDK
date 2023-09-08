
//.ImportPublicHolidaysResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importPublicHolidaysResponse")]
  public class ImportPublicHolidaysResponse
  {
    [XmlArray(ElementName = "publicHolidaysInError", IsNullable = false, Order = 0)]
    public List<PublicHoliday> PublicHolidaysInError { get; set; }
  }
}
