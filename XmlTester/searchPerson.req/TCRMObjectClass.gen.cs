//---------------------------------------------------
// class TCRMObjectClass
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
    /// TCRMObject 类
    /// </summary>
    [Serializable]
    public partial class TCRMObjectClass
    {

        /// <summary>
        /// TCRMPersonSearchBObj
        /// </summary>
        [XmlElement(ElementName = "TCRMPersonSearchBObj", Namespace = "")]
        public TCRMPersonSearchBObjClass TCRMPersonSearchBObj { get; set; }
    }
}
