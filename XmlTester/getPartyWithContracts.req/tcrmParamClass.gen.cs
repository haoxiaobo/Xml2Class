//---------------------------------------------------
// class tcrmParamClass
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
    /// tcrmParam 类
    /// </summary>
    [Serializable]
    public partial class tcrmParamClass
    {

        /// <summary>
        /// name
        /// </summary>
        /// <example>[PartyId], [PartyInquiryLevel], [ContractInquiryLevel]</example>
        [XmlAttribute]
        public string name { get; set; }

        /// <summary>
        /// Text
        /// </summary>
        /// <example>[823133955157716616], [0], [1]</example>
        [XmlText]
        public string Text { get; set; }
    }
}
