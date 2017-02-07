//---------------------------------------------------
// class DWLControlClass
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
    /// DWLControl 类
    /// </summary>
    [Serializable]
    public partial class DWLControlClass
    {

        /// <summary>
        /// requesterName
        /// </summary>
        /// <example>[WECHATTKYL]</example>
        [XmlElement(ElementName = "requesterName", Namespace = "")]
        public string requesterName { get; set; }

        /// <summary>
        /// requesterLanguage
        /// </summary>
        /// <example>[400]</example>
        [XmlElement(ElementName = "requesterLanguage", Namespace = "")]
        public string requesterLanguage { get; set; }
    }
}
