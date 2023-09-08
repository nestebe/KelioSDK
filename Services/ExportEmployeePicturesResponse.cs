
//.ExportEmployeePicturesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportEmployeePicturesResponse")]
  public class ExportEmployeePicturesResponse
  {
    [XmlArray(ElementName = "exportedEmployeePictures", IsNullable = false, Order = 0)]
    public List<EmployeePicture> ExportedEmployeePictures { get; set; }
  }
}
