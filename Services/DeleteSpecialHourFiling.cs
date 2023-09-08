
//.DeleteSpecialHourFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteSpecialHourFiling")]
  public class DeleteSpecialHourFiling
  {
    [XmlArray(ElementName = "specialHourFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> SpecialHourFilingToDelete { get; set; }
  }
}
