//---------------------------------------------------
// class TCRMContractPartyRoleBObjClass
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
    /// TCRMContractPartyRoleBObj 类
    /// </summary>
    [Serializable]
    public partial class TCRMContractPartyRoleBObjClass
    {

        /// <summary>
        /// ContractComponentId
        /// </summary>
        /// <example>[8739907057], [8739907058], [8739907059], [8739907060], [835134804415685755], [646141370750231393]</example>
        [XmlElement(ElementName = "ContractComponentId", Namespace = "")]
        public string ContractComponentId { get; set; }

        /// <summary>
        /// ContractPartyRoleLastUpdateDate
        /// </summary>
        /// <example>[2017-01-02 04:53:05.0], [2017-01-02 06:40:28.0], [2017-01-03 05:12:01.0], [2012-09-19 16:42:36.888], [2014-10-19 16:31:42.317]</example>
        [XmlElement(ElementName = "ContractPartyRoleLastUpdateDate", Namespace = "")]
        public string ContractPartyRoleLastUpdateDate { get; set; }

        /// <summary>
        /// ContractPartyRoleLastUpdateUser
        /// </summary>
        /// <example>[MDM_ETL], [TOLMQ]</example>
        [XmlElement(ElementName = "ContractPartyRoleLastUpdateUser", Namespace = "")]
        public string ContractPartyRoleLastUpdateUser { get; set; }

        /// <summary>
        /// ContractRoleIdPK
        /// </summary>
        /// <example>[2387028175], [2387228854], [2387373133], [2387028176], [2387228855], [2387373136], [2387028177], [2387228856], [2387373139], [2387028178]</example>
        [XmlElement(ElementName = "ContractRoleIdPK", Namespace = "")]
        public string ContractRoleIdPK { get; set; }

        /// <summary>
        /// PartyId
        /// </summary>
        /// <example>[823133955157716616]</example>
        [XmlElement(ElementName = "PartyId", Namespace = "")]
        public string PartyId { get; set; }

        /// <summary>
        /// RoleType
        /// </summary>
        /// <example>[1], [2], [31]</example>
        [XmlElement(ElementName = "RoleType", Namespace = "")]
        public string RoleType { get; set; }

        /// <summary>
        /// RoleValue
        /// </summary>
        /// <example>[投保人], [被保人], [生存受益人－第一顺序]</example>
        [XmlElement(ElementName = "RoleValue", Namespace = "")]
        public string RoleValue { get; set; }

        /// <summary>
        /// StartDate
        /// </summary>
        /// <example>[2017-01-02 04:53:05.0], [2017-01-02 06:40:28.0], [2017-01-02 00:00:00.0], [2012-09-19 16:42:36.888], [2014-10-19 16:31:42.317]</example>
        [XmlElement(ElementName = "StartDate", Namespace = "")]
        public string StartDate { get; set; }

        /// <summary>
        /// DistributionPercentage
        /// </summary>
        /// <example>[100.00]</example>
        [XmlElement(ElementName = "DistributionPercentage", Namespace = "")]
        public string DistributionPercentage { get; set; }

        /// <summary>
        /// ContractPartyRoleLastUpdateTxId
        /// </summary>
        /// <example>[516134804415639137], [650141370750213560]</example>
        [XmlElement(ElementName = "ContractPartyRoleLastUpdateTxId", Namespace = "")]
        public string ContractPartyRoleLastUpdateTxId { get; set; }
    }
}
