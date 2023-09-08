
//.ImportJobDeclarationApprovals




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importJobDeclarationApprovals")]
  public class ImportJobDeclarationApprovals
  {
    [XmlArray(ElementName = "jobDeclarationApprovalsToImport", IsNullable = false, Order = 0)]
    public List<JobDeclarationApproval> JobDeclarationApprovalsToImport { get; set; }
  }
}
