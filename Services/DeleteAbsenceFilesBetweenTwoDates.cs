
//.DeleteAbsenceFilesBetweenTwoDates




using KelioSDK.Models;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace KelioSDK.Services
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "deleteAbsenceFilesBetweenTwoDates")]
  public class DeleteAbsenceFilesBetweenTwoDates
  {
    [XmlArray(ElementName = "absenceFilesWithDates", IsNullable = false, Order = 0)]
    public List<AbsenceFile> AbsenceFilesWithDates { get; set; }
  }
}
