
//.ImportPublicHolidaySetup




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importPublicHolidaySetup")]
  public class ImportPublicHolidaySetup
  {
    [XmlArray(ElementName = "publicHolidaySetupToImport", IsNullable = false, Order = 0)]
    public List<PublicHolydaySetup> PublicHolidaySetupToImport { get; set; }
  }
}
