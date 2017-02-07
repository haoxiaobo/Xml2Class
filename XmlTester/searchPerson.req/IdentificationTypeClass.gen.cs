//---------------------------------------------------
// class IdentificationTypeClass
// date: 2017-02-03 15:09
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
    /// IdentificationType 类
    /// </summary>
    [Serializable]
    
    public partial class IdentificationTypeClass
    {

        /// <summary>
        /// aaa
        /// </summary>
        /// <example>222</example>
        [XmlAttribute]
        public string aaa { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        /// <example>1</example>
        [XmlText]
        public string Text { get; set; }
    }
}
