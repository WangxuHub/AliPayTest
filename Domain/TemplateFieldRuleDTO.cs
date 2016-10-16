using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateFieldRuleDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateFieldRuleDTO : AopObject
    {
        /// <summary>
        /// 字段名称，现在支持如下几个Key（暂不支持自定义）  Balance：金额  Point：整数  Level：任意字符串  OpenDate：开卡日期  ValidDate：过期日期
        /// </summary>
        [XmlElement("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 规则名  ASSIGN_FROM_REQUEST:  以rule_value为key值，从开卡请求中取指定值  DATE_IN_FUTURE: 生成一个未来的日期（格式YYYY-MM-DD)  CONST: 常量
        /// </summary>
        [XmlElement("rule_name")]
        public string RuleName { get; set; }

        /// <summary>
        /// 根据rule_name，采取相应取值策略  CONST：直接取rule_value作为卡属性值  DATE_IN_FUTURE：10m或10d 分别表示10个月或10天  ASSIGN_FROM_REQUEST：在开卡Reuqest请求中按rule_value取值，现在和field_name对应的为（OpenDate、ValidDate、Level、Point、Balance）
        /// </summary>
        [XmlElement("rule_value")]
        public string RuleValue { get; set; }
    }
}
