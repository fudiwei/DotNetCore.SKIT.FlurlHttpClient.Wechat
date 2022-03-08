namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/intent/name_exist 接口的响应。</para>
    /// </summary>
    public class IntentNameExistResponse : WechatOpenAIThirdPartyResponse<IntentNameExistResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置是否已存在。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("exist")]
                [System.Text.Json.Serialization.JsonPropertyName("exist")]
                public bool IsExisted { get; set; }
            }
        }
    }
}
