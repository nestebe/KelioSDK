
//.DeleteAbsenceFiles




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteAbsenceFiles")]
  public class DeleteAbsenceFiles
  {
    [XmlArray(ElementName = "absenceFilesToDelete", IsNullable = false, Order = 0)]
    public List<AbsenceFile> AbsenceFilesToDelete { get; set; }
  }
}
