using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MerchantCard Data Structure.
    /// </summary>
    [Serializable]
    public class MerchantCard : AopObject
    {
        /// <summary>
        /// 资金卡余额，单位：元，精确到小数点后两位。
        /// </summary>
        [XmlElement("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 支付宝业务卡号（查询接口中返回）  开卡接口(alipay.marketing.card.open接口)不需要提供该字段  更新、删卡卡接口，可以不填该字段
        /// </summary>
        [XmlElement("biz_card_no")]
        public string BizCardNo { get; set; }

        /// <summary>
        /// 商户外部会员卡卡号  会员卡开卡接口，如果卡类型为外部会员卡，则必须提供“外部会员卡”  更新、查询、删除等接口，输入参数可不设置该字段，如果设置了，必须匹配开卡预留的外部卡号
        /// </summary>
        [XmlElement("external_card_no")]
        public string ExternalCardNo { get; set; }

        /// <summary>
        /// 会员卡等级（由商户自定义，并可以在卡模板创建时，定义等级信息）
        /// </summary>
        [XmlElement("level")]
        public string Level { get; set; }

        /// <summary>
        /// 会员卡开卡时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("open_date")]
        public string OpenDate { get; set; }

        /// <summary>
        /// 会员卡积分，积分必须为数字型（可为浮点型，带2位小数点）
        /// </summary>
        [XmlElement("point")]
        public string Point { get; set; }

        /// <summary>
        /// 会员卡有效期
        /// </summary>
        [XmlElement("valid_date")]
        public string ValidDate { get; set; }
    }
}
