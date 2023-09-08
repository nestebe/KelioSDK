
//.ExportGenericTypesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportGenericTypesResponse")]
  public class ExportGenericTypesResponse
  {
    [XmlArray(ElementName = "exportedGenericTypes", IsNullable = false, Order = 0)]
    public List<GenericType> ExportedGenericTypes { get; set; }
  }
}
