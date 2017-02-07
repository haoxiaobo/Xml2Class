//---------------------------------------------------
// class TCRMPartyIdentificationBObjClass
// date: 2017-02-07 15:10
// 本代码由 Xml2Class 生成器 (by Haoxiaobo) 自动生成
//---------------------------------------------------
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Linq; 
using getPartyWithContracts.resp;

namespace getPartyWithContracts.resp
{

    /// <summary>
    /// TCRMPartyIdentificationBObj 类
    /// </summary>
    [Serializable]
    public partial class TCRMPartyIdentificationBObjClass
    {

        /// <summary>
        /// IdentificationIdPK
        /// </summary>
        /// <example>[4501339XXXXXXX1160]</example>
        [XmlElement(ElementName = "IdentificationIdPK", Namespace = "")]
        public string IdentificationIdPK { get; set; }

        /// <summary>
        /// IdentificationNumber
        /// </summary>
        /// <example>[350802198505245023]</example>
        [XmlElement(ElementName = "IdentificationNumber", Namespace = "")]
        public string IdentificationNumber { get; set; }

        /// <summary>
        /// IdentificationType
        /// </summary>
        /// <example>[1]</example>
        [XmlElement(ElementName = "IdentificationType", Namespace = "")]
        public string IdentificationType { get; set; }

        /// <summary>
        /// IdentificationValue
        /// </summary>
        /// <example>[身份证]</example>
        [XmlElement(ElementName = "IdentificationValue", Namespace = "")]
        public string IdentificationValue { get; set; }

        /// <summary>
        /// PartyId
        /// </summary>
        /// <example>[823133955157716616]</example>
        [XmlElement(ElementName = "PartyId", Namespace = "")]
        public string PartyId { get; set; }

        /// <summary>
        /// PartyIdentificationLastUpdateDate
        /// </summary>
        /// <example>[2017-01-01 22:56:59.661]</example>
        [XmlElement(ElementName = "PartyIdentificationLastUpdateDate", Namespace = "")]
        public string PartyIdentificationLastUpdateDate { get; set; }

        /// <summary>
        /// PartyIdentificationLastUpdateTxId
        /// </summary>
        /// <example>[191148328261930070]</example>
        [XmlElement(ElementName = "PartyIdentificationLastUpdateTxId", Namespace = "")]
        public string PartyIdentificationLastUpdateTxId { get; set; }

        /// <summary>
        /// PartyIdentificationLastUpdateUser
        /// </summary>
        /// <example>[CSCMQ]</example>
        [XmlElement(ElementName = "PartyIdentificationLastUpdateUser", Namespace = "")]
        public string PartyIdentificationLastUpdateUser { get; set; }

        /// <summary>
        /// StartDate
        /// </summary>
        /// <example>[2012-06-13 09:39:37.211]</example>
        [XmlElement(ElementName = "StartDate", Namespace = "")]
        public string StartDate { get; set; }
    }
}
