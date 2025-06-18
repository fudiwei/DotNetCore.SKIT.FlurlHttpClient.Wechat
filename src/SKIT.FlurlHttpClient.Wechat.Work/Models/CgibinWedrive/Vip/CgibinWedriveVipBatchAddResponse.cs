namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/wedrive/vip/batch_add 接口的响应。</para>
    /// </summary>
    public class CgibinWedriveVipBatchAddResponse : WechatWorkResponse
    {
        /// <summary>
        /// 获取或设置分配成功的成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("succ_userid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("succ_userid_list")]
        public string[]? SuccessfulUserIdList { get; set; }

        /// <summary>
        /// 获取或设置分配失败的成员账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fail_userid_list")]
        [System.Text.Json.Serialization.JsonPropertyName("fail_userid_list")]
        public string[]? FailedUserIdList { get; set; }
    }
}
