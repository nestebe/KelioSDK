
//.ImportAccessDailyCrossingSchedules




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAccessDailyCrossingSchedules")]
  public class ImportAccessDailyCrossingSchedules
  {
    [XmlArray(ElementName = "accessDailyCrossingSchedulesToImport", IsNullable = false, Order = 0)]
    public List<AccessDailyCrossingSchedule> AccessDailyCrossingSchedulesToImport { get; set; }
  }
}
