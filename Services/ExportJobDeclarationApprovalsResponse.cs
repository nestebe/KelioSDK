
//.ExportJobDeclarationApprovalsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportJobDeclarationApprovalsResponse")]
  public class ExportJobDeclarationApprovalsResponse
  {
    [XmlArray(ElementName = "exportedJobDeclarationApprovals", IsNullable = false, Order = 0)]
    public List<JobDeclarationApproval> ExportedJobDeclarationApprovals { get; set; }
  }
}
