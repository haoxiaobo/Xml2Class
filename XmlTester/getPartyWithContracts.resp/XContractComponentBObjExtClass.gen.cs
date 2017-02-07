//---------------------------------------------------
// class XContractComponentBObjExtClass
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
    /// XContractComponentBObjExt 类
    /// </summary>
    [Serializable]
    public partial class XContractComponentBObjExtClass
    {

        /// <summary>
        /// XProductCode
        /// </summary>
        /// <example>[A28P], [R46P], [WPCP], [RUMS]</example>
        [XmlElement(ElementName = "XProductCode", Namespace = "")]
        public string XProductCode { get; set; }

        /// <summary>
        /// XProductName
        /// </summary>
        /// <example>[泰康人生赢家祝寿金期], [泰康人生赢家生存金及养老金期], [人生赢家投保人意外豁同一人], [泰康尊享理财年金（万能型）]</example>
        [XmlElement(ElementName = "XProductName", Namespace = "")]
        public string XProductName { get; set; }

        /// <summary>
        /// XInsuredAmount
        /// </summary>
        /// <example>[43342.80], [30000.00], [0.00]</example>
        [XmlElement(ElementName = "XInsuredAmount", Namespace = "")]
        public string XInsuredAmount { get; set; }

        /// <summary>
        /// XContractComponentLastUpdateDate
        /// </summary>
        /// <example>[2017-01-04 02:29:17.0], [2012-09-19 16:42:36.918], [2014-10-19 16:31:42.32]</example>
        [XmlElement(ElementName = "XContractComponentLastUpdateDate", Namespace = "")]
        public string XContractComponentLastUpdateDate { get; set; }

        /// <summary>
        /// XContractComponentLastUpdateUser
        /// </summary>
        /// <example>[MDM_ETL], [TOLMQ]</example>
        [XmlElement(ElementName = "XContractComponentLastUpdateUser", Namespace = "")]
        public string XContractComponentLastUpdateUser { get; set; }

        /// <summary>
        /// XUnderwriteInd10
        /// </summary>
        /// <example>[2]</example>
        [XmlElement(ElementName = "XUnderwriteInd10", Namespace = "")]
        public string XUnderwriteInd10 { get; set; }

        /// <summary>
        /// XContractComponentLastUpdateTxId
        /// </summary>
        /// <example>[516134804415639137], [650141370750213560]</example>
        [XmlElement(ElementName = "XContractComponentLastUpdateTxId", Namespace = "")]
        public string XContractComponentLastUpdateTxId { get; set; }
    }
}
