
//.ExportEmployeeGroupFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeeGroupFilingResponse")]
  public class ExportEmployeeGroupFilingResponse
  {
    [XmlArray(ElementName = "exportedEmployeeGroupFiling", IsNullable = false, Order = 0)]
    public List<Filing> ExportedEmployeeGroupFiling { get; set; }
  }
}
