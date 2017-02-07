//---------------------------------------------------
// class TCRMTxClass
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
    /// TCRMTx 类
    /// </summary>
    [Serializable]
    public partial class TCRMTxClass
    {

        /// <summary>
        /// TCRMTxType
        /// </summary>
        /// <example>[searchPerson]</example>
        [XmlElement(ElementName = "TCRMTxType", Namespace = "")]
        public string TCRMTxType { get; set; }

        /// <summary>
        /// TCRMTxObject
        /// </summary>
        /// <example>[TCRMPersonSearchBObj]</example>
        [XmlElement(ElementName = "TCRMTxObject", Namespace = "")]
        public string TCRMTxObject { get; set; }

        /// <summary>
        /// TCRMObject
        /// </summary>
        [XmlElement(ElementName = "TCRMObject", Namespace = "")]
        public TCRMObjectClass TCRMObject { get; set; }
    }
}
