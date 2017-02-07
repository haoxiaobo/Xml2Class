//---------------------------------------------------
// class XPersonBObjExtClass
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
    /// XPersonBObjExt 类
    /// </summary>
    [Serializable]
    public partial class XPersonBObjExtClass
    {

        /// <summary>
        /// XOccupationTpCdType
        /// </summary>
        /// <example>[538]</example>
        [XmlElement(ElementName = "XOccupationTpCdType", Namespace = "")]
        public string XOccupationTpCdType { get; set; }

        /// <summary>
        /// XOccupationTpCdValue
        /// </summary>
        /// <example>[商业-外务员]</example>
        [XmlElement(ElementName = "XOccupationTpCdValue", Namespace = "")]
        public string XOccupationTpCdValue { get; set; }

        /// <summary>
        /// XRiskValue01
        /// </summary>
        /// <example>[30001.00]</example>
        [XmlElement(ElementName = "XRiskValue01", Namespace = "")]
        public string XRiskValue01 { get; set; }

        /// <summary>
        /// XRiskValue02
        /// </summary>
        /// <example>[1.00]</example>
        [XmlElement(ElementName = "XRiskValue02", Namespace = "")]
        public string XRiskValue02 { get; set; }

        /// <summary>
        /// XRiskValue09
        /// </summary>
        /// <example>[1.00]</example>
        [XmlElement(ElementName = "XRiskValue09", Namespace = "")]
        public string XRiskValue09 { get; set; }

        /// <summary>
        /// XRiskValue10
        /// </summary>
        /// <example>[1.00]</example>
        [XmlElement(ElementName = "XRiskValue10", Namespace = "")]
        public string XRiskValue10 { get; set; }

        /// <summary>
        /// XPersonLastUpdateDate
        /// </summary>
        /// <example>[2017-01-03 11:53:08.0]</example>
        [XmlElement(ElementName = "XPersonLastUpdateDate", Namespace = "")]
        public string XPersonLastUpdateDate { get; set; }

        /// <summary>
        /// XPersonLastUpdateTxId
        /// </summary>
        /// <example>[191148328261930070]</example>
        [XmlElement(ElementName = "XPersonLastUpdateTxId", Namespace = "")]
        public string XPersonLastUpdateTxId { get; set; }

        /// <summary>
        /// XPersonLastUpdateUser
        /// </summary>
        /// <example>[MDM_ETL]</example>
        [XmlElement(ElementName = "XPersonLastUpdateUser", Namespace = "")]
        public string XPersonLastUpdateUser { get; set; }
    }
}
