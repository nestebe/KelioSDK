
//.ImportPublicHolidaySetupResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importPublicHolidaySetupResponse")]
  public class ImportPublicHolidaySetupResponse
  {
    [XmlArray(ElementName = "publicHolidaySetupInError", IsNullable = false, Order = 0)]
    public List<PublicHolydaySetup> PublicHolidaySetupInError { get; set; }
  }
}
