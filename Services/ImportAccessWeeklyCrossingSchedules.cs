
//.ImportAccessWeeklyCrossingSchedules




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAccessWeeklyCrossingSchedules")]
  public class ImportAccessWeeklyCrossingSchedules
  {
    [XmlArray(ElementName = "accessWeeklyCrossingSchedulesToImport", IsNullable = false, Order = 0)]
    public List<AccessWeeklySchedule> AccessWeeklyCrossingSchedulesToImport { get; set; }
  }
}
