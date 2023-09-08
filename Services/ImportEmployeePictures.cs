
//.ImportEmployeePictures




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeePictures")]
  public class ImportEmployeePictures
  {
    [XmlArray(ElementName = "employeePicturesToImport", IsNullable = false, Order = 0)]
    public List<EmployeePicture> EmployeePicturesToImport { get; set; }
  }
}
