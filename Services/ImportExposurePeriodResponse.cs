
//.ImportExposurePeriodResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importExposurePeriodResponse")]
  public class ImportExposurePeriodResponse
  {
    [XmlArray(ElementName = "exposurePeriodInError", IsNullable = false, Order = 0)]
    public List<ExposurePeriod> ExposurePeriodInError { get; set; }
  }
}
