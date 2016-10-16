using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardUserInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardUserInfo : AopObject
    {
        /// <summary>
        /// 用户唯一标识
        /// </summary>
        [XmlElement("user_uni_id")]
        public string UserUniId { get; set; }

        /// <summary>
        /// ID类型  UID：用户支付宝用户号，以2088开头的16位纯数字组成；
        /// </summary>
        [XmlElement("user_uni_id_type")]
        public string UserUniIdType { get; set; }
    }
}
