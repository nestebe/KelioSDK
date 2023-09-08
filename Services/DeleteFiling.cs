
//.DeleteFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteFiling")]
  public class DeleteFiling
  {
    [XmlArray(ElementName = "filingToDelete", IsNullable = false, Order = 0)]
    public List<GenericFiling> FilingToDelete { get; set; }
  }
}
