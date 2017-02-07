//---------------------------------------------------
// class TCRMInquiryClass
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
    /// TCRMInquiry 类
    /// </summary>
    [Serializable]
    public partial class TCRMInquiryClass
    {

        /// <summary>
        /// InquiryType
        /// </summary>
        /// <example>[getPartyWithContracts]</example>
        [XmlElement(ElementName = "InquiryType", Namespace = "")]
        public string InquiryType { get; set; }

        /// <summary>
        /// InquiryParam
        /// </summary>
        [XmlElement(ElementName = "InquiryParam", Namespace = "")]
        public InquiryParamClass InquiryParam { get; set; }
    }
}
