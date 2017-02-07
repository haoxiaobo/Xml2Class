//---------------------------------------------------
// class TxResultClass
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
    /// TxResult 类
    /// </summary>
    [Serializable]
    public partial class TxResultClass
    {

        /// <summary>
        /// ResultCode
        /// </summary>
        /// <example>[SUCCESS]</example>
        [XmlElement(ElementName = "ResultCode", Namespace = "")]
        public string ResultCode { get; set; }
    }
}
