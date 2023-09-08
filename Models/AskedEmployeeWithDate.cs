
// Type: KelioSDK.Models.AskedEmployeeWithDate




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "askedEmployeeWithDate")]
  public class AskedEmployeeWithDate : EmployeeInformation
  {
    [XmlElement(DataType = "date", ElementName = "date", IsNullable = true)]
    public DateTime? Date { get; set; }
  }
}
