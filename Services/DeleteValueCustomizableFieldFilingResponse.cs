
//.DeleteValueCustomizableFieldFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteValueCustomizableFieldFilingResponse")]
  public class DeleteValueCustomizableFieldFilingResponse
  {
    [XmlArray(ElementName = "valueCustomizableFieldFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> ValueCustomizableFieldFilingInError { get; set; }
  }
}
