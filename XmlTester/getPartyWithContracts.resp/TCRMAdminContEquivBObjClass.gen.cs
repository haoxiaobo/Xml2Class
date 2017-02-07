//---------------------------------------------------
// class TCRMAdminContEquivBObjClass
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
    /// TCRMAdminContEquivBObj 类
    /// </summary>
    [Serializable]
    public partial class TCRMAdminContEquivBObjClass
    {

        /// <summary>
        /// AdminContEquivIdPK
        /// </summary>
        /// <example>[896133955157721240], [389134804415678208], [395148328197493905]</example>
        [XmlElement(ElementName = "AdminContEquivIdPK", Namespace = "")]
        public string AdminContEquivIdPK { get; set; }

        /// <summary>
        /// AdminPartyId
        /// </summary>
        /// <example>[2159092538], [29101652], [48582785]</example>
        [XmlElement(ElementName = "AdminPartyId", Namespace = "")]
        public string AdminPartyId { get; set; }

        /// <summary>
        /// AdminSystemType
        /// </summary>
        /// <example>[3], [5], [1]</example>
        [XmlElement(ElementName = "AdminSystemType", Namespace = "")]
        public string AdminSystemType { get; set; }

        /// <summary>
        /// AdminSystemValue
        /// </summary>
        /// <example>[EBA], [TOL], [CSC]</example>
        [XmlElement(ElementName = "AdminSystemValue", Namespace = "")]
        public string AdminSystemValue { get; set; }

        /// <summary>
        /// ContEquivLastUpdateDate
        /// </summary>
        /// <example>[2012-06-13 09:39:37.212], [2012-09-19 16:42:36.782], [2017-01-01 22:46:14.939]</example>
        [XmlElement(ElementName = "ContEquivLastUpdateDate", Namespace = "")]
        public string ContEquivLastUpdateDate { get; set; }

        /// <summary>
        /// ContEquivLastUpdateTxId
        /// </summary>
        /// <example>[379133955157714951], [516134804415639137], [750148328197470362]</example>
        [XmlElement(ElementName = "ContEquivLastUpdateTxId", Namespace = "")]
        public string ContEquivLastUpdateTxId { get; set; }

        /// <summary>
        /// ContEquivLastUpdateUser
        /// </summary>
        /// <example>[EBABatch], [TOLMQ], [CSCMQ]</example>
        [XmlElement(ElementName = "ContEquivLastUpdateUser", Namespace = "")]
        public string ContEquivLastUpdateUser { get; set; }

        /// <summary>
        /// PartyId
        /// </summary>
        /// <example>[823133955157716616]</example>
        [XmlElement(ElementName = "PartyId", Namespace = "")]
        public string PartyId { get; set; }
    }
}
