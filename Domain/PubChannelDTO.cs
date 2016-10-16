using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PubChannelDTO Data Structure.
    /// </summary>
    [Serializable]
    public class PubChannelDTO : AopObject
    {
        /// <summary>
        /// 扩展信息，无需配置
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// SHOP_DETAIL:店铺详情页   PAYMENT_RESULT: 支付成功页
        /// </summary>
        [XmlElement("pub_channel")]
        public string PubChannel { get; set; }
    }
}
