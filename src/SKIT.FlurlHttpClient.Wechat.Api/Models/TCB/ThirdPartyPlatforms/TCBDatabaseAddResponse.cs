namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /tcb/databaseadd 接口的响应。</para>
    /// </summary>
    public class TCBDatabaseAddResponse : WechatApiResponse
    {
        /// <summary>
        /// 获取或设置插入成功的数据集合主键 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("id_list")]
        public string[] IdList { get; set; } = default!;
    }
}
