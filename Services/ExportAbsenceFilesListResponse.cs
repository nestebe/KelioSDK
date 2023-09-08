
//.ExportAbsenceFilesListResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "exportAbsenceFilesListResponse")]
  public class ExportAbsenceFilesListResponse
  {
    [XmlArray(ElementName = "exportedAbsenceFiles", IsNullable = false, Order = 0)]
    public List<AbsenceFile> ExportedAbsenceFiles { get; set; }
  }
}
