
//.ImportClearingResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importClearingResponse")]
  public class ImportClearingResponse
  {
    [XmlArray(ElementName = "clearingInError", IsNullable = false, Order = 0)]
    public List<Clearing> ClearingInError { get; set; }
  }
}
