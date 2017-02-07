//---------------------------------------------------
// class TCRMFSPartyBObjClass
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
    /// TCRMFSPartyBObj 类
    /// </summary>
    [Serializable]
    public partial class TCRMFSPartyBObjClass
    {

        /// <summary>
        /// DWLStatus
        /// </summary>
        [XmlElement(ElementName = "DWLStatus", Namespace = "")]
        public DWLStatusClass DWLStatus { get; set; }

        /// <summary>
        /// TCRMContractBObj
        /// </summary>
        [XmlElement(ElementName = "TCRMContractBObj", Namespace = "")]
        public TCRMContractBObjClass[] TCRMContractBObj { get; set; }

        /// <summary>
        /// TCRMPersonBObj
        /// </summary>
        [XmlElement(ElementName = "TCRMPersonBObj", Namespace = "")]
        public TCRMPersonBObjClass TCRMPersonBObj { get; set; }
    }
}
