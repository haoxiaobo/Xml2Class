//---------------------------------------------------
// class TCRMPersonSearchResultBObjClass
// date: 2017-02-07 15:10
// 本代码由 Xml2Class 生成器 (by Haoxiaobo) 自动生成
//---------------------------------------------------
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Linq; 
using searchPerson.resp;

namespace searchPerson.resp
{

    /// <summary>
    /// TCRMPersonSearchResultBObj 类
    /// </summary>
    [Serializable]
    public partial class TCRMPersonSearchResultBObjClass
    {

        /// <summary>
        /// ComponentID
        /// </summary>
        /// <example>[1014]</example>
        [XmlElement(ElementName = "ComponentID", Namespace = "")]
        public string ComponentID { get; set; }

        /// <summary>
        /// AddressId
        /// </summary>
        /// <example>[947148328261971874]</example>
        [XmlElement(ElementName = "AddressId", Namespace = "")]
        public string AddressId { get; set; }

        /// <summary>
        /// AddrLineOne
        /// </summary>
        /// <example>[福建省厦门市湖里区XXXXXXXXXXXXXXXX]</example>
        [XmlElement(ElementName = "AddrLineOne", Namespace = "")]
        public string AddrLineOne { get; set; }

        /// <summary>
        /// CityName
        /// </summary>
        /// <example>[N/A]</example>
        [XmlElement(ElementName = "CityName", Namespace = "")]
        public string CityName { get; set; }

        /// <summary>
        /// IdentificationNum
        /// </summary>
        /// <example>[350802XXXXXXXXX5023]</example>
        [XmlElement(ElementName = "IdentificationNum", Namespace = "")]
        public string IdentificationNum { get; set; }

        /// <summary>
        /// IdentificationType
        /// </summary>
        /// <example>[1]</example>
        [XmlElement(ElementName = "IdentificationType", Namespace = "")]
        public string IdentificationType { get; set; }

        /// <summary>
        /// PartyId
        /// </summary>
        /// <example>[823133955157716616]</example>
        [XmlElement(ElementName = "PartyId", Namespace = "")]
        public string PartyId { get; set; }

        /// <summary>
        /// ZipPostalCode
        /// </summary>
        /// <example>[361009]</example>
        [XmlElement(ElementName = "ZipPostalCode", Namespace = "")]
        public string ZipPostalCode { get; set; }

        /// <summary>
        /// DateOfBirth
        /// </summary>
        /// <example>[1985-05-24 00:00:00.0]</example>
        [XmlElement(ElementName = "DateOfBirth", Namespace = "")]
        public string DateOfBirth { get; set; }

        /// <summary>
        /// Gender
        /// </summary>
        /// <example>[F]</example>
        [XmlElement(ElementName = "Gender", Namespace = "")]
        public string Gender { get; set; }

        /// <summary>
        /// IdentificationTypeValue
        /// </summary>
        /// <example>[身份证]</example>
        [XmlElement(ElementName = "IdentificationTypeValue", Namespace = "")]
        public string IdentificationTypeValue { get; set; }

        /// <summary>
        /// PartyActiveIndicator
        /// </summary>
        /// <example>[Y]</example>
        [XmlElement(ElementName = "PartyActiveIndicator", Namespace = "")]
        public string PartyActiveIndicator { get; set; }

        /// <summary>
        /// PnLastName
        /// </summary>
        /// <example>[吴XXXX]</example>
        [XmlElement(ElementName = "PnLastName", Namespace = "")]
        public string PnLastName { get; set; }

        /// <summary>
        /// ResultNumber
        /// </summary>
        /// <example>[1]</example>
        [XmlElement(ElementName = "ResultNumber", Namespace = "")]
        public string ResultNumber { get; set; }

        /// <summary>
        /// ResultScore
        /// </summary>
        /// <example>[150]</example>
        [XmlElement(ElementName = "ResultScore", Namespace = "")]
        public string ResultScore { get; set; }

        /// <summary>
        /// ResultsFound
        /// </summary>
        /// <example>[1]</example>
        [XmlElement(ElementName = "ResultsFound", Namespace = "")]
        public string ResultsFound { get; set; }
    }
}
