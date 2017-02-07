//---------------------------------------------------
// class TCRMServiceClass
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
    /// TCRMService 类
    /// </summary>
    [Serializable]
    [XmlRoot(ElementName = "TCRMService",Namespace = "")]
    [XmlInclude(typeof(TCRMServiceClass))]
    [XmlInclude(typeof(ResponseControlClass))]
    [XmlInclude(typeof(DWLControlClass))]
    [XmlInclude(typeof(TxResponseClass))]
    [XmlInclude(typeof(TxResultClass))]
    [XmlInclude(typeof(ResponseObjectClass))]
    [XmlInclude(typeof(TCRMFSPartyBObjClass))]
    [XmlInclude(typeof(DWLStatusClass))]
    [XmlInclude(typeof(TCRMContractBObjClass))]
    [XmlInclude(typeof(TCRMAdminNativeKeyBObjClass))]
    [XmlInclude(typeof(TCRMContractComponentBObjClass))]
    [XmlInclude(typeof(TCRMContractPartyRoleBObjClass))]
    [XmlInclude(typeof(TCRMExtensionClass))]
    [XmlInclude(typeof(XContractComponentBObjExtClass))]
    [XmlInclude(typeof(XContractBObjExtClass))]
    [XmlInclude(typeof(TCRMPersonBObjClass))]
    [XmlInclude(typeof(TCRMPartyIdentificationBObjClass))]
    [XmlInclude(typeof(TCRMAdminContEquivBObjClass))]
    [XmlInclude(typeof(TCRMPersonNameBObjClass))]
    [XmlInclude(typeof(XPersonBObjExtClass))]
    public partial class TCRMServiceClass
    {

        /// <summary>
        /// test
        /// </summary>
        /// <example>[true]</example>
        [XmlAttribute]
        public string test { get; set; }

        /// <summary>
        /// ResponseControl
        /// </summary>
        [XmlElement(ElementName = "ResponseControl", Namespace = "")]
        public ResponseControlClass ResponseControl { get; set; }

        /// <summary>
        /// TxResponse
        /// </summary>
        [XmlElement(ElementName = "TxResponse", Namespace = "")]
        public TxResponseClass TxResponse { get; set; }
    }
}
