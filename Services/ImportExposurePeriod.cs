
//.ImportExposurePeriod




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importExposurePeriod")]
  public class ImportExposurePeriod
  {
    [XmlArray(ElementName = "exposurePeriodToImport", IsNullable = false, Order = 0)]
    public List<ExposurePeriod> ExposurePeriodToImport { get; set; }
  }
}
