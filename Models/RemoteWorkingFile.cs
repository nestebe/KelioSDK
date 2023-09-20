// Type: KelioSDK.Models.RemoteWorkingFile


using System.Xml.Serialization;

namespace KelioSDK.Models;

[XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "RemoteWorkingFile")]
public class RemoteWorkingFile : EmployeeInformation
{
    [XmlElement(DataType = "int", ElementName = "remoteWorkingTypeKey", IsNullable = true)]
    public int? RemoteWorkingTypeKey { get; set; }

    [XmlElement(DataType = "int", ElementName = "remoteWorkingFileKey", IsNullable = true)]
    public int? RemoteWorkingFileKey { get; set; }

    [XmlElement(DataType = "string", ElementName = "remoteWorkingTypeAbbreviation", IsNullable = true)]
    public string? RemoteWorkingTypeAbbreviation { get; set; }

    [XmlElement(DataType = "string", ElementName = "remoteWorkingTypeDescription", IsNullable = true)]
    public string? RemoteWorkingTypeDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "comment", IsNullable = true)]
    public string? Comment { get; set; }

    [XmlElement(DataType = "date", ElementName = "startDate", IsNullable = true)]
    public DateTime? StartDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "startInTheMorning", IsNullable = true)]
    public bool? StartInTheMorning { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "endingTheAfternoon", IsNullable = true)]
    public bool? EndingTheAfternoon { get; set; }
}