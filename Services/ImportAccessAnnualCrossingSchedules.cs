
//.ImportAccessAnnualCrossingSchedules




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAccessAnnualCrossingSchedules")]
  public class ImportAccessAnnualCrossingSchedules
  {
    [XmlArray(ElementName = "accessAnnualCrossingSchedulesToImport", IsNullable = false, Order = 0)]
    public List<AccessAnnualCrossingSchedule> AccessAnnualCrossingSchedulesToImport { get; set; }
  }
}
