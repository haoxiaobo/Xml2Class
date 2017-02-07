//---------------------------------------------------
// class TCRMPersonBObjClass
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
    /// TCRMPersonBObj 类
    /// </summary>
    [Serializable]
    public partial class TCRMPersonBObjClass
    {

        /// <summary>
        /// ComponentID
        /// </summary>
        /// <example>[2000026]</example>
        [XmlElement(ElementName = "ComponentID", Namespace = "")]
        public string ComponentID { get; set; }

        /// <summary>
        /// ClientImportanceType
        /// </summary>
        /// <example>[15]</example>
        [XmlElement(ElementName = "ClientImportanceType", Namespace = "")]
        public string ClientImportanceType { get; set; }

        /// <summary>
        /// ClientImportanceValue
        /// </summary>
        /// <example>[金卡]</example>
        [XmlElement(ElementName = "ClientImportanceValue", Namespace = "")]
        public string ClientImportanceValue { get; set; }

        /// <summary>
        /// ClientPotentialType
        /// </summary>
        /// <example>[1]</example>
        [XmlElement(ElementName = "ClientPotentialType", Namespace = "")]
        public string ClientPotentialType { get; set; }

        /// <summary>
        /// ClientPotentialValue
        /// </summary>
        /// <example>[客户]</example>
        [XmlElement(ElementName = "ClientPotentialValue", Namespace = "")]
        public string ClientPotentialValue { get; set; }

        /// <summary>
        /// CreatedDate
        /// </summary>
        /// <example>[2012-06-13 09:39:37.153]</example>
        [XmlElement(ElementName = "CreatedDate", Namespace = "")]
        public string CreatedDate { get; set; }

        /// <summary>
        /// SinceDate
        /// </summary>
        /// <example>[2012-06-13 09:39:37.212]</example>
        [XmlElement(ElementName = "SinceDate", Namespace = "")]
        public string SinceDate { get; set; }

        /// <summary>
        /// DisplayName
        /// </summary>
        /// <example>[吴XX]</example>
        [XmlElement(ElementName = "DisplayName", Namespace = "")]
        public string DisplayName { get; set; }

        /// <summary>
        /// PartyActiveIndicator
        /// </summary>
        /// <example>[Y]</example>
        [XmlElement(ElementName = "PartyActiveIndicator", Namespace = "")]
        public string PartyActiveIndicator { get; set; }

        /// <summary>
        /// PartyId
        /// </summary>
        /// <example>[823133955157716616]</example>
        [XmlElement(ElementName = "PartyId", Namespace = "")]
        public string PartyId { get; set; }

        /// <summary>
        /// PartyLastUpdateDate
        /// </summary>
        /// <example>[2017-01-03 11:53:08.0]</example>
        [XmlElement(ElementName = "PartyLastUpdateDate", Namespace = "")]
        public string PartyLastUpdateDate { get; set; }

        /// <summary>
        /// PartyLastUpdateTxId
        /// </summary>
        /// <example>[191148328261930070]</example>
        [XmlElement(ElementName = "PartyLastUpdateTxId", Namespace = "")]
        public string PartyLastUpdateTxId { get; set; }

        /// <summary>
        /// PartyLastUpdateUser
        /// </summary>
        /// <example>[MDM_ETL]</example>
        [XmlElement(ElementName = "PartyLastUpdateUser", Namespace = "")]
        public string PartyLastUpdateUser { get; set; }

        /// <summary>
        /// PartyType
        /// </summary>
        /// <example>[P]</example>
        [XmlElement(ElementName = "PartyType", Namespace = "")]
        public string PartyType { get; set; }

        /// <summary>
        /// BirthDate
        /// </summary>
        /// <example>[1985-05-24 00:00:00.0]</example>
        [XmlElement(ElementName = "BirthDate", Namespace = "")]
        public string BirthDate { get; set; }

        /// <summary>
        /// CitizenshipType
        /// </summary>
        /// <example>[36]</example>
        [XmlElement(ElementName = "CitizenshipType", Namespace = "")]
        public string CitizenshipType { get; set; }

        /// <summary>
        /// CitizenshipValue
        /// </summary>
        /// <example>[中国]</example>
        [XmlElement(ElementName = "CitizenshipValue", Namespace = "")]
        public string CitizenshipValue { get; set; }

        /// <summary>
        /// GenderType
        /// </summary>
        /// <example>[F]</example>
        [XmlElement(ElementName = "GenderType", Namespace = "")]
        public string GenderType { get; set; }

        /// <summary>
        /// HighestEducationType
        /// </summary>
        /// <example>[6]</example>
        [XmlElement(ElementName = "HighestEducationType", Namespace = "")]
        public string HighestEducationType { get; set; }

        /// <summary>
        /// HighestEducationValue
        /// </summary>
        /// <example>[本科]</example>
        [XmlElement(ElementName = "HighestEducationValue", Namespace = "")]
        public string HighestEducationValue { get; set; }

        /// <summary>
        /// MaritalStatusType
        /// </summary>
        /// <example>[1]</example>
        [XmlElement(ElementName = "MaritalStatusType", Namespace = "")]
        public string MaritalStatusType { get; set; }

        /// <summary>
        /// MaritalStatusValue
        /// </summary>
        /// <example>[未婚]</example>
        [XmlElement(ElementName = "MaritalStatusValue", Namespace = "")]
        public string MaritalStatusValue { get; set; }

        /// <summary>
        /// PersonLastUpdateDate
        /// </summary>
        /// <example>[2017-01-03 11:53:08.0]</example>
        [XmlElement(ElementName = "PersonLastUpdateDate", Namespace = "")]
        public string PersonLastUpdateDate { get; set; }

        /// <summary>
        /// PersonLastUpdateTxId
        /// </summary>
        /// <example>[191148328261930070]</example>
        [XmlElement(ElementName = "PersonLastUpdateTxId", Namespace = "")]
        public string PersonLastUpdateTxId { get; set; }

        /// <summary>
        /// PersonLastUpdateUser
        /// </summary>
        /// <example>[MDM_ETL]</example>
        [XmlElement(ElementName = "PersonLastUpdateUser", Namespace = "")]
        public string PersonLastUpdateUser { get; set; }

        /// <summary>
        /// PersonPartyId
        /// </summary>
        /// <example>[823133955157716616]</example>
        [XmlElement(ElementName = "PersonPartyId", Namespace = "")]
        public string PersonPartyId { get; set; }

        /// <summary>
        /// TCRMPartyIdentificationBObj
        /// </summary>
        [XmlElement(ElementName = "TCRMPartyIdentificationBObj", Namespace = "")]
        public TCRMPartyIdentificationBObjClass TCRMPartyIdentificationBObj { get; set; }

        /// <summary>
        /// TCRMAdminContEquivBObj
        /// </summary>
        [XmlElement(ElementName = "TCRMAdminContEquivBObj", Namespace = "")]
        public TCRMAdminContEquivBObjClass[] TCRMAdminContEquivBObj { get; set; }

        /// <summary>
        /// TCRMPersonNameBObj
        /// </summary>
        [XmlElement(ElementName = "TCRMPersonNameBObj", Namespace = "")]
        public TCRMPersonNameBObjClass TCRMPersonNameBObj { get; set; }

        /// <summary>
        /// TCRMExtension
        /// </summary>
        [XmlElement(ElementName = "TCRMExtension", Namespace = "")]
        public TCRMExtensionClass TCRMExtension { get; set; }
    }
}
