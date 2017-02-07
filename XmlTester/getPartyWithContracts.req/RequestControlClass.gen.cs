//---------------------------------------------------
// class RequestControlClass
// date: 2017-02-07 15:10
// 本代码由 Xml2Class 生成器 (by Haoxiaobo) 自动生成
//---------------------------------------------------
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Linq; 
using getPartyWithContracts.req;

namespace getPartyWithContracts.req
{

    /// <summary>
    /// RequestControl 类
    /// </summary>
    [Serializable]
    public partial class RequestControlClass
    {

        /// <summary>
        /// requestID
        /// </summary>
        /// <example>[100185]</example>
        [XmlElement(ElementName = "requestID", Namespace = "")]
        public string requestID { get; set; }

        /// <summary>
        /// DWLControl
        /// </summary>
        [XmlElement(ElementName = "DWLControl", Namespace = "")]
        public DWLControlClass DWLControl { get; set; }
    }
}
