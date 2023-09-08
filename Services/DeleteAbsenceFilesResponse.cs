
//.DeleteAbsenceFilesResponse




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteAbsenceFilesResponse")]
  public class DeleteAbsenceFilesResponse
  {
    [XmlArray(ElementName = "absenceFilesInError", IsNullable = false, Order = 0)]
    public List<AbsenceFile> AbsenceFilesInError { get; set; }
  }
}
