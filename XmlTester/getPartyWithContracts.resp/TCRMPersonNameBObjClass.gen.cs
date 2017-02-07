//---------------------------------------------------
// class TCRMPersonNameBObjClass
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
    /// TCRMPersonNameBObj 类
    /// </summary>
    [Serializable]
    public partial class TCRMPersonNameBObjClass
    {

        /// <summary>
        /// LastName
        /// </summary>
        /// <example>[吴XX]</example>
        [XmlElement(ElementName = "LastName", Namespace = "")]
        public string LastName { get; set; }

        /// <summary>
        /// LastUpdatedBy
        /// </summary>
        /// <example>[CSCMQ]</example>
        [XmlElement(ElementName = "LastUpdatedBy", Namespace = "")]
        public string LastUpdatedBy { get; set; }

        /// <summary>
        /// LastUpdatedDate
        /// </summary>
        /// <example>[2017-01-01 22:56:59.626]</example>
        [XmlElement(ElementName = "LastUpdatedDate", Namespace = "")]
        public string LastUpdatedDate { get; set; }

        /// <summary>
        /// NameUsageType
        /// </summary>
        /// <example>[1]</example>
        [XmlElement(ElementName = "NameUsageType", Namespace = "")]
        public string NameUsageType { get; set; }

        /// <summary>
        /// NameUsageValue
        /// </summary>
        /// <example>[法律]</example>
        [XmlElement(ElementName = "NameUsageValue", Namespace = "")]
        public string NameUsageValue { get; set; }

        /// <summary>
        /// PersonNameIdPK
        /// </summary>
        /// <example>[440133955157718575]</example>
        [XmlElement(ElementName = "PersonNameIdPK", Namespace = "")]
        public string PersonNameIdPK { get; set; }

        /// <summary>
        /// PersonNameLastUpdateDate
        /// </summary>
        /// <example>[2017-01-01 22:56:59.626]</example>
        [XmlElement(ElementName = "PersonNameLastUpdateDate", Namespace = "")]
        public string PersonNameLastUpdateDate { get; set; }

        /// <summary>
        /// PersonNameLastUpdateTxId
        /// </summary>
        /// <example>[191148328261930070]</example>
        [XmlElement(ElementName = "PersonNameLastUpdateTxId", Namespace = "")]
        public string PersonNameLastUpdateTxId { get; set; }

        /// <summary>
        /// PersonNameLastUpdateUser
        /// </summary>
        /// <example>[CSCMQ]</example>
        [XmlElement(ElementName = "PersonNameLastUpdateUser", Namespace = "")]
        public string PersonNameLastUpdateUser { get; set; }

        /// <summary>
        /// PersonPartyId
        /// </summary>
        /// <example>[823133955157716616]</example>
        [XmlElement(ElementName = "PersonPartyId", Namespace = "")]
        public string PersonPartyId { get; set; }

        /// <summary>
        /// StartDate
        /// </summary>
        /// <example>[2012-06-13 09:39:37.185]</example>
        [XmlElement(ElementName = "StartDate", Namespace = "")]
        public string StartDate { get; set; }

        /// <summary>
        /// StdLastName
        /// </summary>
        /// <example>[吴XX]</example>
        [XmlElement(ElementName = "StdLastName", Namespace = "")]
        public string StdLastName { get; set; }
    }
}
