
//.ImportJobDeclarationApprovalsResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importJobDeclarationApprovalsResponse")]
  public class ImportJobDeclarationApprovalsResponse
  {
    [XmlArray(ElementName = "jobDeclarationApprovalsInError", IsNullable = false, Order = 0)]
    public List<JobDeclarationApproval> JobDeclarationApprovalsInError { get; set; }
  }
}
