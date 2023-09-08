
// Type: KelioSDK.Models.HourlyBasisDistribution




using KelioSDK.Common;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "HourlyBasisDistribution")]
  public class HourlyBasisDistribution : ObjectBase
  {
    [XmlElement(DataType = "boolean", ElementName = "hourlyBasisDifferenceCalculationInRelationToHourlyBasisDistribution", IsNullable = true)]
    public bool? HourlyBasisDifferenceCalculationInRelationToHourlyBasisDistribution { get; set; }

    [XmlElement(DataType = "int", ElementName = "halfDayAbsenceDuration", IsNullable = true)]
    public int? HalfDayAbsenceDuration { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyBasisDistributionDescription", IsNullable = true)]
    public string HourlyBasisDistributionDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "hourlyBasisDistributionAbbreviation", IsNullable = true)]
    public string HourlyBasisDistributionAbbreviation { get; set; }

    [XmlElement(DataType = "double", ElementName = "firstDayFirstHalfDayDuration", IsNullable = true)]
    public double? FirstDayFirstHalfDayDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "firstDaySecondHalfDayDuration", IsNullable = true)]
    public double? FirstDaySecondHalfDayDuration { get; set; }

    [XmlElement(DataType = "string", ElementName = "absencesGroupDescription", IsNullable = true)]
    public string AbsencesGroupDescription { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "firstDayWorked", IsNullable = true)]
    public bool? FirstDayWorked { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "absenceCalculationInRelationToHourlyBasisDistribution", IsNullable = true)]
    public bool? AbsenceCalculationInRelationToHourlyBasisDistribution { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "publicHolidayCalculationInRelationToHourlyBasisDistribution", IsNullable = true)]
    public bool? PublicHolidayCalculationInRelationToHourlyBasisDistribution { get; set; }

    [XmlElement(DataType = "int", ElementName = "distributionType", IsNullable = true)]
    public int? DistributionType { get; set; }

    [XmlElement(DataType = "short", ElementName = "firstDayCalculationMode", IsNullable = true)]
    public short? FirstDayCalculationMode { get; set; }

    [XmlElement(DataType = "double", ElementName = "thirdDayFirstHalfDayDuration", IsNullable = true)]
    public double? ThirdDayFirstHalfDayDuration { get; set; }

    [XmlElement(DataType = "short", ElementName = "secondDayCalculationMode", IsNullable = true)]
    public short? SecondDayCalculationMode { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "fourthDayWorked", IsNullable = true)]
    public bool? FourthDayWorked { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "thirdDayWorked", IsNullable = true)]
    public bool? ThirdDayWorked { get; set; }

    [XmlElement(DataType = "double", ElementName = "fourthDayFirstHalfDayDuration", IsNullable = true)]
    public double? FourthDayFirstHalfDayDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "secondDaySecondHalfDayDuration", IsNullable = true)]
    public double? SecondDaySecondHalfDayDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "thirdDaySecondHalfDayDuration", IsNullable = true)]
    public double? ThirdDaySecondHalfDayDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "secondDayFirstHalfDayDuration", IsNullable = true)]
    public double? SecondDayFirstHalfDayDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "fourthDaySecondHalfDayDuration", IsNullable = true)]
    public double? FourthDaySecondHalfDayDuration { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "secondDayWorked", IsNullable = true)]
    public bool? SecondDayWorked { get; set; }

    [XmlElement(DataType = "short", ElementName = "fourthDayCalculationMode", IsNullable = true)]
    public short? FourthDayCalculationMode { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "fifthDayWorked", IsNullable = true)]
    public bool? FifthDayWorked { get; set; }

    [XmlElement(DataType = "short", ElementName = "thirdDayCalculationMode", IsNullable = true)]
    public short? ThirdDayCalculationMode { get; set; }

    [XmlElement(DataType = "short", ElementName = "seventhDayCalculationMode", IsNullable = true)]
    public short? SeventhDayCalculationMode { get; set; }

    [XmlElement(DataType = "short", ElementName = "sixthDayCalculationMode", IsNullable = true)]
    public short? SixthDayCalculationMode { get; set; }

    [XmlElement(DataType = "double", ElementName = "seventhDaySecondHalfDayDuration", IsNullable = true)]
    public double? SeventhDaySecondHalfDayDuration { get; set; }

    [XmlElement(DataType = "short", ElementName = "fifthDayCalculationMode", IsNullable = true)]
    public short? FifthDayCalculationMode { get; set; }

    [XmlElement(DataType = "double", ElementName = "sixthDayFirstHalfDayDuration", IsNullable = true)]
    public double? SixthDayFirstHalfDayDuration { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "sixthDayWorked", IsNullable = true)]
    public bool? SixthDayWorked { get; set; }

    [XmlElement(DataType = "double", ElementName = "seventhDayFirstHalfDayDuration", IsNullable = true)]
    public double? SeventhDayFirstHalfDayDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "fifthDayFirstHalfDayDuration", IsNullable = true)]
    public double? FifthDayFirstHalfDayDuration { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "seventhDayWorked", IsNullable = true)]
    public bool? SeventhDayWorked { get; set; }

    [XmlElement(DataType = "double", ElementName = "fifthDaySecondHalfDayDuration", IsNullable = true)]
    public double? FifthDaySecondHalfDayDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "sixthDaySecondHalfDayDuration", IsNullable = true)]
    public double? SixthDaySecondHalfDayDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "fourthDayDuration", IsNullable = true)]
    public double? FourthDayDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "thirdDayDuration", IsNullable = true)]
    public double? ThirdDayDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "firstDayDuration", IsNullable = true)]
    public double? FirstDayDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "fifthDayDuration", IsNullable = true)]
    public double? FifthDayDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "secondDayDuration", IsNullable = true)]
    public double? SecondDayDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "sixthDayDuration", IsNullable = true)]
    public double? SixthDayDuration { get; set; }

    [XmlElement(DataType = "double", ElementName = "seventhDayDuration", IsNullable = true)]
    public double? SeventhDayDuration { get; set; }
  }
}
