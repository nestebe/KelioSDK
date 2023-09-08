
//.ImportSchedules




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importSchedules")]
  public class ImportSchedules
  {
    [XmlArray(ElementName = "schedulesToImport", IsNullable = false, Order = 0)]
    public List<Schedule> SchedulesToImport { get; set; }
  }
}
