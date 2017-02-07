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
using searchPerson.req;

namespace searchPerson.req
{

    /// <summary>
    /// TCRMService 类
    /// </summary>
    [Serializable]
    [XmlRoot(ElementName = "TCRMService",Namespace = "")]
    [XmlInclude(typeof(TCRMServiceClass))]
    [XmlInclude(typeof(RequestControlClass))]
    [XmlInclude(typeof(DWLControlClass))]
    [XmlInclude(typeof(TCRMTxClass))]
    [XmlInclude(typeof(TCRMObjectClass))]
    [XmlInclude(typeof(TCRMPersonSearchBObjClass))]
    public partial class TCRMServiceClass
    {

        /// <summary>
        /// RequestControl
        /// </summary>
        [XmlElement(ElementName = "RequestControl", Namespace = "")]
        public RequestControlClass RequestControl { get; set; }

        /// <summary>
        /// TCRMTx
        /// </summary>
        [XmlElement(ElementName = "TCRMTx", Namespace = "")]
        public TCRMTxClass TCRMTx { get; set; }
    }
}
