//---------------------------------------------------
// class TCRMAdminNativeKeyBObjClass
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
    /// TCRMAdminNativeKeyBObj 类
    /// </summary>
    [Serializable]
    public partial class TCRMAdminNativeKeyBObjClass
    {

        /// <summary>
        /// AdminContractId
        /// </summary>
        /// <example>[G152XXXXX], [G152XXXX0010100], [G152XXXX0010101], [G152XXXX0010102], [G152XXXX0010103], [21121070954139376], [23143451050148342]</example>
        [XmlElement(ElementName = "AdminContractId", Namespace = "")]
        public string AdminContractId { get; set; }

        /// <summary>
        /// AdminFieldNameType
        /// </summary>
        /// <example>[1], [101], [5], [105]</example>
        [XmlElement(ElementName = "AdminFieldNameType", Namespace = "")]
        public string AdminFieldNameType { get; set; }

        /// <summary>
        /// AdminFieldNameValue
        /// </summary>
        /// <example>[个险保单号], [个险保障计划编号], [泰康在线电子保单号], [泰康在线保障计划编号]</example>
        [XmlElement(ElementName = "AdminFieldNameValue", Namespace = "")]
        public string AdminFieldNameValue { get; set; }

        /// <summary>
        /// AdminNativeKeyIdPK
        /// </summary>
        /// <example>[1667706244], [1667945855], [1667945856], [1667945857], [1667945858], [791348044156919312], [235134804415690454], [481141370750232139], [986141370750231873]</example>
        [XmlElement(ElementName = "AdminNativeKeyIdPK", Namespace = "")]
        public string AdminNativeKeyIdPK { get; set; }

        /// <summary>
        /// AdminSystemType
        /// </summary>
        /// <example>[1], [5]</example>
        [XmlElement(ElementName = "AdminSystemType", Namespace = "")]
        public string AdminSystemType { get; set; }

        /// <summary>
        /// AdminSystemValue
        /// </summary>
        /// <example>[CSC], [TOL]</example>
        [XmlElement(ElementName = "AdminSystemValue", Namespace = "")]
        public string AdminSystemValue { get; set; }

        /// <summary>
        /// ContractId
        /// </summary>
        /// <example>[3566778110], [8739907057], [8739907058], [8739907059], [8739907060], [631348044156854454], [835134804415685755], [990141370750230951], [646141370750231393]</example>
        [XmlElement(ElementName = "ContractId", Namespace = "")]
        public string ContractId { get; set; }

        /// <summary>
        /// NativeKeyLastUpdateDate
        /// </summary>
        /// <example>[2017-01-02 03:32:21.0], [2017-01-02 04:53:05.0], [2012-09-19 16:42:36.919], [2012-09-19 16:42:36.904], [2014-10-19 16:31:42.321], [2014-10-19 16:31:42.319]</example>
        [XmlElement(ElementName = "NativeKeyLastUpdateDate", Namespace = "")]
        public string NativeKeyLastUpdateDate { get; set; }

        /// <summary>
        /// NativeKeyLastUpdateUser
        /// </summary>
        /// <example>[MDM_ETL], [TOLMQ]</example>
        [XmlElement(ElementName = "NativeKeyLastUpdateUser", Namespace = "")]
        public string NativeKeyLastUpdateUser { get; set; }

        /// <summary>
        /// ContractComponentIndicator
        /// </summary>
        /// <example>[Y], [N]</example>
        [XmlElement(ElementName = "ContractComponentIndicator", Namespace = "")]
        public string ContractComponentIndicator { get; set; }

        /// <summary>
        /// NativeKeyLastUpdateTxId
        /// </summary>
        /// <example>[516134804415639137], [650141370750213560]</example>
        [XmlElement(ElementName = "NativeKeyLastUpdateTxId", Namespace = "")]
        public string NativeKeyLastUpdateTxId { get; set; }
    }
}
