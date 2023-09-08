
//.ExportAbsenceFilesList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAbsenceFilesList")]
  public class ExportAbsenceFilesList
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedAbsence> ExportFilter { get; set; }
  }
}
