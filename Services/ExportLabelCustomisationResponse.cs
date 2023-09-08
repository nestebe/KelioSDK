
//.ExportLabelCustomisationResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportLabelCustomisationResponse")]
  public class ExportLabelCustomisationResponse
  {
    [XmlArray(ElementName = "exportedLabelCustomisation", IsNullable = false, Order = 0)]
    public List<LabelCustomisation> ExportedLabelCustomisation { get; set; }
  }
}
