
//.DeleteToilCalendarFiling




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteToilCalendarFiling")]
  public class DeleteToilCalendarFiling
  {
    [XmlArray(ElementName = "toilCalendarFilingToDelete", IsNullable = false, Order = 0)]
    public List<Filing> ToilCalendarFilingToDelete { get; set; }
  }
}
