//---------------------------------------------------
// class XContractBObjExtClass
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
    /// XContractBObjExt 类
    /// </summary>
    [Serializable]
    public partial class XContractBObjExtClass
    {

        /// <summary>
        /// XServiceFlag
        /// </summary>
        /// <example>[M2]</example>
        [XmlElement(ElementName = "XServiceFlag", Namespace = "")]
        public string XServiceFlag { get; set; }

        /// <summary>
        /// XPostAddress
        /// </summary>
        /// <example>[福建省厦门市湖里区泗水道６１７号宝拓大厦１４０１]</example>
        [XmlElement(ElementName = "XPostAddress", Namespace = "")]
        public string XPostAddress { get; set; }

        /// <summary>
        /// XPostCode
        /// </summary>
        /// <example>[361009]</example>
        [XmlElement(ElementName = "XPostCode", Namespace = "")]
        public string XPostCode { get; set; }

        /// <summary>
        /// XMobile
        /// </summary>
        /// <example>[13696919243]</example>
        [XmlElement(ElementName = "XMobile", Namespace = "")]
        public string XMobile { get; set; }

        /// <summary>
        /// XPremValue01
        /// </summary>
        /// <example>[30001.00]</example>
        [XmlElement(ElementName = "XPremValue01", Namespace = "")]
        public string XPremValue01 { get; set; }

        /// <summary>
        /// XPremValue10
        /// </summary>
        /// <example>[0.00]</example>
        [XmlElement(ElementName = "XPremValue10", Namespace = "")]
        public string XPremValue10 { get; set; }

        /// <summary>
        /// XContractLastUpdateDate
        /// </summary>
        /// <example>[2017-01-05 05:22:24.0], [2012-09-19 16:42:36.854], [2014-10-19 16:31:42.309]</example>
        [XmlElement(ElementName = "XContractLastUpdateDate", Namespace = "")]
        public string XContractLastUpdateDate { get; set; }

        /// <summary>
        /// XContractLastUpdateUser
        /// </summary>
        /// <example>[MDM_ETL], [TOLMQ]</example>
        [XmlElement(ElementName = "XContractLastUpdateUser", Namespace = "")]
        public string XContractLastUpdateUser { get; set; }

        /// <summary>
        /// XContractLastUpdateTxId
        /// </summary>
        /// <example>[516134804415639137], [650141370750213560]</example>
        [XmlElement(ElementName = "XContractLastUpdateTxId", Namespace = "")]
        public string XContractLastUpdateTxId { get; set; }
    }
}
