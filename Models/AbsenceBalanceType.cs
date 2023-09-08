
// Type: KelioSDK.Models.AbsenceBalanceType




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "AbsenceBalanceType")]
  public class AbsenceBalanceType : Type
  {
    [XmlElement(DataType = "boolean", ElementName = "visualizedInThePrintouts", IsNullable = true)]
    public bool? VisualizedInThePrintouts { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "trainingAccount", IsNullable = true)]
    public bool? TrainingAccount { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "estimated", IsNullable = true)]
    public bool? Estimated { get; set; }

    [XmlElement(DataType = "short", ElementName = "unit", IsNullable = true)]
    public short? Unit { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "visualizableAddDeductBalanceInit", IsNullable = true)]
    public bool? VisualizableAddDeductBalanceInit { get; set; }

    [XmlElement(DataType = "int", ElementName = "exerciseType", IsNullable = true)]
    public int? ExerciseType { get; set; }

    [XmlElement(DataType = "date", ElementName = "yearlyPeriodEndDate", IsNullable = true)]
    public DateTime? YearlyPeriodEndDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "balanceResetAtPeriodStartDate", IsNullable = true)]
    public bool? BalanceResetAtPeriodStartDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "macroCommandBalance", IsNullable = true)]
    public bool? MacroCommandBalance { get; set; }

    [XmlElement(DataType = "int", ElementName = "monthlyPeriodEndDay", IsNullable = true)]
    public int? MonthlyPeriodEndDay { get; set; }

    [XmlElement(DataType = "string", ElementName = "entryHelpComment", IsNullable = true)]
    public string EntryHelpComment { get; set; }

    [XmlElement(DataType = "date", ElementName = "resetDate", IsNullable = true)]
    public DateTime? ResetDate { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "visualizableInResult", IsNullable = true)]
    public bool? VisualizableInResult { get; set; }

    [XmlElement(DataType = "boolean", ElementName = "anomalyIfNegativeAbsenceBalance", IsNullable = true)]
    public bool? AnomalyIfNegativeAbsenceBalance { get; set; }
  }
}
