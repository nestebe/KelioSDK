
//.ImportAbsenceFiles




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "importAbsenceFiles")]
  public class ImportAbsenceFiles
  {
    [XmlArray(ElementName = "absenceFilesToImport", IsNullable = false, Order = 0)]
    public List<AbsenceFile> AbsenceFilesToImport { get; set; }
  }
}
