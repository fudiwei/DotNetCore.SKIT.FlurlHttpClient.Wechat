namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /mch-manage/mch-manage-records/{manage_record_id} 接口的请求。</para>
    /// </summary>
    public class GetMerchantManageRecordRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置子商户号。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string SubMerchantId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户管理记录 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string ManageRecordId { get; set; } = string.Empty;
    }
}
