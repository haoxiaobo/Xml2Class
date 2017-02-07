//---------------------------------------------------
// class TCRMContractBObjClass
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
    /// TCRMContractBObj 类
    /// </summary>
    [Serializable]
    public partial class TCRMContractBObjClass
    {

        /// <summary>
        /// ComponentID
        /// </summary>
        /// <example>[2100023]</example>
        [XmlElement(ElementName = "ComponentID", Namespace = "")]
        public string ComponentID { get; set; }

        /// <summary>
        /// BillingType
        /// </summary>
        /// <example>[3]</example>
        [XmlElement(ElementName = "BillingType", Namespace = "")]
        public string BillingType { get; set; }

        /// <summary>
        /// BillingValue
        /// </summary>
        /// <example>[转账收费]</example>
        [XmlElement(ElementName = "BillingValue", Namespace = "")]
        public string BillingValue { get; set; }

        /// <summary>
        /// BusOrgunitId
        /// </summary>
        /// <example>[G], [4], [2]</example>
        [XmlElement(ElementName = "BusOrgunitId", Namespace = "")]
        public string BusOrgunitId { get; set; }

        /// <summary>
        /// AgreementName
        /// </summary>
        /// <example>[泰康人生赢家年金保障计划], [“e路泰康”旅客综合交通意外伤害保险], [泰康“飞常保”航空保障计划]</example>
        [XmlElement(ElementName = "AgreementName", Namespace = "")]
        public string AgreementName { get; set; }

        /// <summary>
        /// AgreementNickName
        /// </summary>
        /// <example>[A28], [107], [345]</example>
        [XmlElement(ElementName = "AgreementNickName", Namespace = "")]
        public string AgreementNickName { get; set; }

        /// <summary>
        /// ExecutedDate
        /// </summary>
        /// <example>[2017-01-02 00:00:00.0], [2012-09-21 00:00:00.0], [2014-10-19 00:00:00.0]</example>
        [XmlElement(ElementName = "ExecutedDate", Namespace = "")]
        public string ExecutedDate { get; set; }

        /// <summary>
        /// AgreementStatusType
        /// </summary>
        /// <example>[23], [1]</example>
        [XmlElement(ElementName = "AgreementStatusType", Namespace = "")]
        public string AgreementStatusType { get; set; }

        /// <summary>
        /// AgreementStatusValue
        /// </summary>
        /// <example>[有效]</example>
        [XmlElement(ElementName = "AgreementStatusValue", Namespace = "")]
        public string AgreementStatusValue { get; set; }

        /// <summary>
        /// ContractIdPK
        /// </summary>
        /// <example>[3566778110], [631348044156854454], [990141370750230951]</example>
        [XmlElement(ElementName = "ContractIdPK", Namespace = "")]
        public string ContractIdPK { get; set; }

        /// <summary>
        /// ContractLangType
        /// </summary>
        /// <example>[400]</example>
        [XmlElement(ElementName = "ContractLangType", Namespace = "")]
        public string ContractLangType { get; set; }

        /// <summary>
        /// ContractLangValue
        /// </summary>
        /// <example>[中文（简体）]</example>
        [XmlElement(ElementName = "ContractLangValue", Namespace = "")]
        public string ContractLangValue { get; set; }

        /// <summary>
        /// ContractLastUpdateDate
        /// </summary>
        /// <example>[2017-01-05 05:22:24.0], [2012-09-19 16:42:36.854], [2014-10-19 16:31:42.309]</example>
        [XmlElement(ElementName = "ContractLastUpdateDate", Namespace = "")]
        public string ContractLastUpdateDate { get; set; }

        /// <summary>
        /// ContractLastUpdateUser
        /// </summary>
        /// <example>[MDM_ETL], [TOLMQ]</example>
        [XmlElement(ElementName = "ContractLastUpdateUser", Namespace = "")]
        public string ContractLastUpdateUser { get; set; }

        /// <summary>
        /// CurrencyType
        /// </summary>
        /// <example>[1]</example>
        [XmlElement(ElementName = "CurrencyType", Namespace = "")]
        public string CurrencyType { get; set; }

        /// <summary>
        /// CurrencyValue
        /// </summary>
        /// <example>[中国人民币元]</example>
        [XmlElement(ElementName = "CurrencyValue", Namespace = "")]
        public string CurrencyValue { get; set; }

        /// <summary>
        /// FrequencyModeType
        /// </summary>
        /// <example>[1]</example>
        [XmlElement(ElementName = "FrequencyModeType", Namespace = "")]
        public string FrequencyModeType { get; set; }

        /// <summary>
        /// FrequencyModeValue
        /// </summary>
        /// <example>[每年]</example>
        [XmlElement(ElementName = "FrequencyModeValue", Namespace = "")]
        public string FrequencyModeValue { get; set; }

        /// <summary>
        /// LineOfBusiness
        /// </summary>
        /// <example>[CSC], [TOL]</example>
        [XmlElement(ElementName = "LineOfBusiness", Namespace = "")]
        public string LineOfBusiness { get; set; }

        /// <summary>
        /// NextBillingDate
        /// </summary>
        /// <example>[2018-01-02 00:00:00.0]</example>
        [XmlElement(ElementName = "NextBillingDate", Namespace = "")]
        public string NextBillingDate { get; set; }

        /// <summary>
        /// PremiumAmount
        /// </summary>
        /// <example>[30000.000], [20.000], [3.680]</example>
        [XmlElement(ElementName = "PremiumAmount", Namespace = "")]
        public string PremiumAmount { get; set; }

        /// <summary>
        /// ServiceOrgName
        /// </summary>
        /// <example>[GP1]</example>
        [XmlElement(ElementName = "ServiceOrgName", Namespace = "")]
        public string ServiceOrgName { get; set; }

        /// <summary>
        /// ServiceProvId
        /// </summary>
        /// <example>[GFGP1P110]</example>
        [XmlElement(ElementName = "ServiceProvId", Namespace = "")]
        public string ServiceProvId { get; set; }

        /// <summary>
        /// DWLStatus
        /// </summary>
        [XmlElement(ElementName = "DWLStatus", Namespace = "")]
        public DWLStatusClass DWLStatus { get; set; }

        /// <summary>
        /// TCRMAdminNativeKeyBObj
        /// </summary>
        [XmlElement(ElementName = "TCRMAdminNativeKeyBObj", Namespace = "")]
        public TCRMAdminNativeKeyBObjClass TCRMAdminNativeKeyBObj { get; set; }

        /// <summary>
        /// TCRMContractComponentBObj
        /// </summary>
        [XmlElement(ElementName = "TCRMContractComponentBObj", Namespace = "")]
        public TCRMContractComponentBObjClass[] TCRMContractComponentBObj { get; set; }

        /// <summary>
        /// TCRMExtension
        /// </summary>
        [XmlElement(ElementName = "TCRMExtension", Namespace = "")]
        public TCRMExtensionClass TCRMExtension { get; set; }

        /// <summary>
        /// SignedDate
        /// </summary>
        /// <example>[2012-09-19 00:00:00.0], [2014-10-19 00:00:00.0]</example>
        [XmlElement(ElementName = "SignedDate", Namespace = "")]
        public string SignedDate { get; set; }

        /// <summary>
        /// EndDate
        /// </summary>
        /// <example>[2012-09-28 00:00:00.0], [2015-10-19 00:00:00.0]</example>
        [XmlElement(ElementName = "EndDate", Namespace = "")]
        public string EndDate { get; set; }

        /// <summary>
        /// ContractLastUpdateTxId
        /// </summary>
        /// <example>[516134804415639137], [650141370750213560]</example>
        [XmlElement(ElementName = "ContractLastUpdateTxId", Namespace = "")]
        public string ContractLastUpdateTxId { get; set; }
    }
}
