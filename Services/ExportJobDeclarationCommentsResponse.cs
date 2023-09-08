
//.ExportJobDeclarationCommentsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportJobDeclarationCommentsResponse")]
  public class ExportJobDeclarationCommentsResponse
  {
    [XmlArray(ElementName = "exportedJobDeclarationComments", IsNullable = false, Order = 0)]
    public List<JobDeclarationComment> ExportedJobDeclarationComments { get; set; }
  }
}
