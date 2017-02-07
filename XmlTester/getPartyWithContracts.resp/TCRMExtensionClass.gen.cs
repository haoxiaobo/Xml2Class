//---------------------------------------------------
// class TCRMExtensionClass
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
    /// TCRMExtension 类
    /// </summary>
    [Serializable]
    public partial class TCRMExtensionClass
    {

        /// <summary>
        /// ExtendedObject
        /// </summary>
        /// <example>[XContractComponentBObjExt], [XContractBObjExt], [XPersonBObjExt]</example>
        [XmlElement(ElementName = "ExtendedObject", Namespace = "")]
        public string ExtendedObject { get; set; }

        /// <summary>
        /// XContractComponentBObjExt
        /// </summary>
        [XmlElement(ElementName = "XContractComponentBObjExt", Namespace = "")]
        public XContractComponentBObjExtClass XContractComponentBObjExt { get; set; }

        /// <summary>
        /// XContractBObjExt
        /// </summary>
        [XmlElement(ElementName = "XContractBObjExt", Namespace = "")]
        public XContractBObjExtClass XContractBObjExt { get; set; }

        /// <summary>
        /// XPersonBObjExt
        /// </summary>
        [XmlElement(ElementName = "XPersonBObjExt", Namespace = "")]
        public XPersonBObjExtClass XPersonBObjExt { get; set; }
    }
}
