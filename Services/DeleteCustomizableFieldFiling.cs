
//.DeleteCustomizableFieldFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteCustomizableFieldFiling")]
  public class DeleteCustomizableFieldFiling
  {
    [XmlArray(ElementName = "customizableFieldFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> CustomizableFieldFilingToDelete { get; set; }
  }
}
