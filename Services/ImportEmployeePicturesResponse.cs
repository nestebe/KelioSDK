
//.ImportEmployeePicturesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importEmployeePicturesResponse")]
  public class ImportEmployeePicturesResponse
  {
    [XmlArray(ElementName = "employeePicturesInError", IsNullable = false, Order = 0)]
    public List<EmployeePicture> EmployeePicturesInError { get; set; }
  }
}
