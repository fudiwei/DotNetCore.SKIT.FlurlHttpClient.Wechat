namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /xpay/bind_transfer_accout 接口的请求。</para>
    /// </summary>
    public class XPayBindTransferAccountRequest : XPayRequestBase, IInferable<XPayBindTransferAccountRequest, XPayBindTransferAccountResponse>
    {
        /// <summary>
        /// 获取或设置充值账户 UID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_account_uid")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_account_uid")]
        public int TransferAccountUID { get; set; }

        /// <summary>
        /// 获取或设置充值账户主体名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transfer_account_org_name")]
        [System.Text.Json.Serialization.JsonPropertyName("transfer_account_org_name")]
        public string TransferAccountOrganizationName { get; set; } = string.Empty;

        protected internal override string GetRequestPath()
        {
            return "/xpay/bind_transfer_accout";
        }
    }
}
