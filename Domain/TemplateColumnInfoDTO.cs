using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateColumnInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateColumnInfoDTO : AopObject
    {
        /// <summary>
        /// 标准栏位：行为由支付宝统一定，同时已经分配标准Code  BALANCE：会员卡余额  POINT：积分  LEVEL：等级  TELEPHOME：联系方式  自定义栏位：行为由商户定义，自定义Code码（只要无重复）
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [XmlElement("more_info")]
        public MoreInfoDTO MoreInfo { get; set; }

        /// <summary>
        /// openNative：打开二级页面，展现 more中descs  openWeb：打开URL  staticinfo：静态信息（默认）
        /// </summary>
        [XmlElement("operate_type")]
        public string OperateType { get; set; }

        /// <summary>
        /// 栏目的标题
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 卡包详情页面，卡栏位右边展现的值
        /// </summary>
        [XmlElement("value")]
        public string Value { get; set; }
    }
}
