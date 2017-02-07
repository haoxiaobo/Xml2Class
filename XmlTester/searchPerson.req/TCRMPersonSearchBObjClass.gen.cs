//---------------------------------------------------
// class TCRMPersonSearchBObjClass
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
    /// TCRMPersonSearchBObj 类
    /// </summary>
    [Serializable]
    public partial class TCRMPersonSearchBObjClass
    {

        /// <summary>
        /// IdentificationType
        /// </summary>
        /// <example>[1]</example>
        [XmlElement(ElementName = "IdentificationType", Namespace = "")]
        public string IdentificationType { get; set; }

        /// <summary>
        /// IdentificationNum
        /// </summary>
        /// <example>[3508021XXXXXXX5023]</example>
        [XmlElement(ElementName = "IdentificationNum", Namespace = "")]
        public string IdentificationNum { get; set; }

        /// <summary>
        /// PartyFilter
        /// </summary>
        /// <example>[ACTIVE]</example>
        [XmlElement(ElementName = "PartyFilter", Namespace = "")]
        public string PartyFilter { get; set; }
    }
}
