
//.DeleteToilCalendarFilingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteToilCalendarFilingResponse")]
  public class DeleteToilCalendarFilingResponse
  {
    [XmlArray(ElementName = "toilCalendarFilingInError", IsNullable = false, Order = 0)]
    public List<Filing> ToilCalendarFilingInError { get; set; }
  }
}
