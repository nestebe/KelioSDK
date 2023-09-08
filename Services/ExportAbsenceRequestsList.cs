
//.ExportAbsenceRequestsList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAbsenceRequestsList")]
  public class ExportAbsenceRequestsList
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AbsenceRequestFilter> ExportFilter { get; set; }
  }
}
