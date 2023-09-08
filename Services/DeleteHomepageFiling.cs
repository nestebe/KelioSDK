
//.DeleteHomepageFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteHomepageFiling")]
  public class DeleteHomepageFiling
  {
    [XmlArray(ElementName = "homepageFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> HomepageFilingToDelete { get; set; }
  }
}
