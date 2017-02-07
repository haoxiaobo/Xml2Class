//---------------------------------------------------
// class ResponseControlClass
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
    /// ResponseControl 类
    /// </summary>
    [Serializable]
    public partial class ResponseControlClass
    {

        /// <summary>
        /// ResultCode
        /// </summary>
        /// <example>[SUCCESS]</example>
        [XmlElement(ElementName = "ResultCode", Namespace = "")]
        public string ResultCode { get; set; }

        /// <summary>
        /// ServiceTime
        /// </summary>
        /// <example>[202]</example>
        [XmlElement(ElementName = "ServiceTime", Namespace = "")]
        public string ServiceTime { get; set; }

        /// <summary>
        /// DWLControl
        /// </summary>
        [XmlElement(ElementName = "DWLControl", Namespace = "")]
        public DWLControlClass DWLControl { get; set; }
    }
}
