//---------------------------------------------------
// class TCRMContractComponentBObjClass
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
    /// TCRMContractComponentBObj 类
    /// </summary>
    [Serializable]
    public partial class TCRMContractComponentBObjClass
    {

        /// <summary>
        /// ComponentID
        /// </summary>
        /// <example>[2200030]</example>
        [XmlElement(ElementName = "ComponentID", Namespace = "")]
        public string ComponentID { get; set; }

        /// <summary>
        /// BaseIndicator
        /// </summary>
        /// <example>[Y]</example>
        [XmlElement(ElementName = "BaseIndicator", Namespace = "")]
        public string BaseIndicator { get; set; }

        /// <summary>
        /// ContractComponentIdPK
        /// </summary>
        /// <example>[8739907057], [8739907058], [8739907059], [8739907060], [835134804415685755], [646141370750231393]</example>
        [XmlElement(ElementName = "ContractComponentIdPK", Namespace = "")]
        public string ContractComponentIdPK { get; set; }

        /// <summary>
        /// ContractComponentLastUpdateDate
        /// </summary>
        /// <example>[2017-01-04 02:29:17.0], [2012-09-19 16:42:36.918], [2014-10-19 16:31:42.32]</example>
        [XmlElement(ElementName = "ContractComponentLastUpdateDate", Namespace = "")]
        public string ContractComponentLastUpdateDate { get; set; }

        /// <summary>
        /// ContractComponentLastUpdateUser
        /// </summary>
        /// <example>[MDM_ETL], [TOLMQ]</example>
        [XmlElement(ElementName = "ContractComponentLastUpdateUser", Namespace = "")]
        public string ContractComponentLastUpdateUser { get; set; }

        /// <summary>
        /// ContractComponentType
        /// </summary>
        /// <example>[1], [2]</example>
        [XmlElement(ElementName = "ContractComponentType", Namespace = "")]
        public string ContractComponentType { get; set; }

        /// <summary>
        /// ContractComponentValue
        /// </summary>
        /// <example>[主险], [附加险]</example>
        [XmlElement(ElementName = "ContractComponentValue", Namespace = "")]
        public string ContractComponentValue { get; set; }

        /// <summary>
        /// ContractId
        /// </summary>
        /// <example>[3566778110], [631348044156854454], [990141370750230951]</example>
        [XmlElement(ElementName = "ContractId", Namespace = "")]
        public string ContractId { get; set; }

        /// <summary>
        /// ContractStatusType
        /// </summary>
        /// <example>[23], [1]</example>
        [XmlElement(ElementName = "ContractStatusType", Namespace = "")]
        public string ContractStatusType { get; set; }

        /// <summary>
        /// ContractStatusValue
        /// </summary>
        /// <example>[有效]</example>
        [XmlElement(ElementName = "ContractStatusValue", Namespace = "")]
        public string ContractStatusValue { get; set; }

        /// <summary>
        /// PremiumAmount
        /// </summary>
        /// <example>[30000.000], [10.000]</example>
        [XmlElement(ElementName = "PremiumAmount", Namespace = "")]
        public string PremiumAmount { get; set; }

        /// <summary>
        /// TCRMAdminNativeKeyBObj
        /// </summary>
        [XmlElement(ElementName = "TCRMAdminNativeKeyBObj", Namespace = "")]
        public TCRMAdminNativeKeyBObjClass TCRMAdminNativeKeyBObj { get; set; }

        /// <summary>
        /// TCRMContractPartyRoleBObj
        /// </summary>
        [XmlElement(ElementName = "TCRMContractPartyRoleBObj", Namespace = "")]
        public TCRMContractPartyRoleBObjClass[] TCRMContractPartyRoleBObj { get; set; }

        /// <summary>
        /// TCRMExtension
        /// </summary>
        [XmlElement(ElementName = "TCRMExtension", Namespace = "")]
        public TCRMExtensionClass TCRMExtension { get; set; }

        /// <summary>
        /// ContractComponentLastUpdateTxId
        /// </summary>
        /// <example>[516134804415639137], [650141370750213560]</example>
        [XmlElement(ElementName = "ContractComponentLastUpdateTxId", Namespace = "")]
        public string ContractComponentLastUpdateTxId { get; set; }
    }
}
