
//.ExportEmployeePicturesList




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeePicturesList")]
  public class ExportEmployeePicturesList
  {
    [XmlArray(ElementName = "exportFilter", IsNullable = false, Order = 0)]
    public List<AskedEmployeePicture> ExportFilter { get; set; }
  }
}
