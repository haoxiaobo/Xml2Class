//---------------------------------------------------
// class TxResponseClass
// date: 2017-02-07 15:10
// 本代码由 Xml2Class 生成器 (by Haoxiaobo) 自动生成
//---------------------------------------------------
using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.Linq; 
using searchPerson.resp;

namespace searchPerson.resp
{

    /// <summary>
    /// TxResponse 类
    /// </summary>
    [Serializable]
    public partial class TxResponseClass
    {

        /// <summary>
        /// RequestType
        /// </summary>
        /// <example>[searchPerson]</example>
        [XmlElement(ElementName = "RequestType", Namespace = "")]
        public string RequestType { get; set; }

        /// <summary>
        /// TxResult
        /// </summary>
        [XmlElement(ElementName = "TxResult", Namespace = "")]
        public TxResultClass TxResult { get; set; }

        /// <summary>
        /// ResponseObject
        /// </summary>
        [XmlElement(ElementName = "ResponseObject", Namespace = "")]
        public ResponseObjectClass ResponseObject { get; set; }
    }
}
