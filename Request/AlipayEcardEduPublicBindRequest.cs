using System;
using System.Collections.Generic;
using Aop.Api.Response;

namespace Aop.Api.Request
{
    /// <summary>
    /// AOP API: alipay.ecard.edu.public.bind
    /// </summary>
    public class AlipayEcardEduPublicBindRequest : IAopRequest<AlipayEcardEduPublicBindResponse>
    {
        /// <summary>
        /// 机构编码
        /// </summary>
        public string AgentCode { get; set; }

        /// <summary>
        /// 公众账号协议Id
        /// </summary>
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝userId
        /// </summary>
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 一卡通姓名
        /// </summary>
        public string CardName { get; set; }

        /// <summary>
        /// 一卡通卡号
        /// </summary>
        public string CardNo { get; set; }

        /// <summary>
        /// 公众账号id
        /// </summary>
        public string PublicId { get; set; }

        #region IAopRequest Members
		private bool  needEncrypt=false;
        private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
        private string prodCode;
		private string notifyUrl;


		public void SetNeedEncrypt(bool needEncrypt){
             this.needEncrypt=needEncrypt;
        }

        public bool GetNeedEncrypt(){

            return this.needEncrypt;
        }

		public void SetNotifyUrl(string notifyUrl){
            this.notifyUrl = notifyUrl;
        }

        public string GetNotifyUrl(){
            return this.notifyUrl;
        }

        public void SetTerminalType(String terminalType){
			this.terminalType=terminalType;
		}

    	public string GetTerminalType(){
    		return this.terminalType;
    	}

    	public void SetTerminalInfo(String terminalInfo){
    		this.terminalInfo=terminalInfo;
    	}

    	public string GetTerminalInfo(){
    		return this.terminalInfo;
    	}

        public void SetProdCode(String prodCode){
            this.prodCode=prodCode;
        }

        public string GetProdCode(){
            return this.prodCode;
        }

        public string GetApiName()
        {
            return "alipay.ecard.edu.public.bind";
        }

        public void SetApiVersion(string apiVersion){
            this.apiVersion=apiVersion;
        }

        public string GetApiVersion(){
            return this.apiVersion;
        }

        public IDictionary<string, string> GetParameters()
        {
            AopDictionary parameters = new AopDictionary();
            parameters.Add("agent_code", this.AgentCode);
            parameters.Add("agreement_id", this.AgreementId);
            parameters.Add("alipay_user_id", this.AlipayUserId);
            parameters.Add("card_name", this.CardName);
            parameters.Add("card_no", this.CardNo);
            parameters.Add("public_id", this.PublicId);
            return parameters;
        }

        #endregion
    }
}
