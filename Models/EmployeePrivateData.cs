
// Type: KelioSDK.Models.EmployeePrivateData




using System;
using System.Xml.Serialization;

namespace KelioSDK.Models
{
  [XmlType(Namespace = "http://echange.service.open.bodet.com", TypeName = "EmployeePrivateData")]
  public class EmployeePrivateData : EmployeeInformationAndCriterion
  {
    [XmlElement(DataType = "string", ElementName = "region", IsNullable = true)]
    public string Region { get; set; }

    [XmlElement(DataType = "string", ElementName = "familyStatusCode", IsNullable = true)]
    public string FamilyStatusCode { get; set; }

    [XmlElement(DataType = "date", ElementName = "familyStatusDate", IsNullable = true)]
    public DateTime? FamilyStatusDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "familyStatusDescription", IsNullable = true)]
    public string FamilyStatusDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "birthCountryDescription", IsNullable = true)]
    public string BirthCountryDescription { get; set; }

    [XmlElement(DataType = "base64Binary", ElementName = "photo", IsNullable = true)]
    public byte[] Photo { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeSecondName", IsNullable = true)]
    public string EmployeeSecondName { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeThirdName", IsNullable = true)]
    public string EmployeeThirdName { get; set; }

    [XmlElement(DataType = "int", ElementName = "title", IsNullable = true)]
    public int? Title { get; set; }

    [XmlElement(DataType = "string", ElementName = "postcode", IsNullable = true)]
    public string Postcode { get; set; }

    [XmlElement(DataType = "string", ElementName = "address", IsNullable = true)]
    public string Address { get; set; }

    [XmlElement(DataType = "string", ElementName = "town", IsNullable = true)]
    public string Town { get; set; }

    [XmlElement(DataType = "int", ElementName = "sex", IsNullable = true)]
    public int? Sex { get; set; }

    [XmlElement(DataType = "date", ElementName = "birthDate", IsNullable = true)]
    public DateTime? BirthDate { get; set; }

    [XmlElement(DataType = "string", ElementName = "mutualInsuranceCompany", IsNullable = true)]
    public string MutualInsuranceCompany { get; set; }

    [XmlElement(DataType = "string", ElementName = "nationalInsuranceCenter", IsNullable = true)]
    public string NationalInsuranceCenter { get; set; }

    [XmlElement(DataType = "string", ElementName = "nationalityCode", IsNullable = true)]
    public string NationalityCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "nationalityDescription", IsNullable = true)]
    public string NationalityDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "employeeMaidenName", IsNullable = true)]
    public string EmployeeMaidenName { get; set; }

    [XmlElement(DataType = "string", ElementName = "adressAddition1", IsNullable = true)]
    public string AdressAddition1 { get; set; }

    [XmlElement(DataType = "string", ElementName = "adressAddition2", IsNullable = true)]
    public string AdressAddition2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "privateEmail", IsNullable = true)]
    public string PrivateEmail { get; set; }

    [XmlElement(DataType = "string", ElementName = "nationalInsuranceNumber", IsNullable = true)]
    public string NationalInsuranceNumber { get; set; }

    [XmlElement(DataType = "string", ElementName = "privatePhoneNumber3", IsNullable = true)]
    public string PrivatePhoneNumber3 { get; set; }

    [XmlElement(DataType = "string", ElementName = "titleDescription", IsNullable = true)]
    public string TitleDescription { get; set; }

    [XmlElement(DataType = "string", ElementName = "birthPlace", IsNullable = true)]
    public string BirthPlace { get; set; }

    [XmlElement(DataType = "string", ElementName = "addressCountryCode", IsNullable = true)]
    public string AddressCountryCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "privatePhoneNumber2", IsNullable = true)]
    public string PrivatePhoneNumber2 { get; set; }

    [XmlElement(DataType = "string", ElementName = "birthCountryCode", IsNullable = true)]
    public string BirthCountryCode { get; set; }

    [XmlElement(DataType = "string", ElementName = "privatePhoneNumber1", IsNullable = true)]
    public string PrivatePhoneNumber1 { get; set; }

    [XmlElement(DataType = "string", ElementName = "emergencyContact", IsNullable = true)]
    public string EmergencyContact { get; set; }

    [XmlElement(DataType = "string", ElementName = "adressCountryDescription", IsNullable = true)]
    public string AdressCountryDescription { get; set; }

    [XmlElement(DataType = "int", ElementName = "ageYear", IsNullable = true)]
    public int? AgeYear { get; set; }

    [XmlElement(DataType = "int", ElementName = "ageMonth", IsNullable = true)]
    public int? AgeMonth { get; set; }

    [XmlElement(DataType = "int", ElementName = "childCount", IsNullable = true)]
    public int? ChildCount { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalPhoneNumber1", IsNullable = true)]
    public string ProfessionalPhoneNumber1 { get; set; }

    [XmlElement(DataType = "string", ElementName = "professionalPhoneNumber2", IsNullable = true)]
    public string ProfessionalPhoneNumber2 { get; set; }
  }
}
