//---------------------------------------------------
// class DWLStatusClass
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
    /// DWLStatus 类
    /// </summary>
    [Serializable]
    public partial class DWLStatusClass
    {

        /// <summary>
        /// Status
        /// </summary>
        /// <example>[0]</example>
        [XmlElement(ElementName = "Status", Namespace = "")]
        public string Status { get; set; }
    }
}
