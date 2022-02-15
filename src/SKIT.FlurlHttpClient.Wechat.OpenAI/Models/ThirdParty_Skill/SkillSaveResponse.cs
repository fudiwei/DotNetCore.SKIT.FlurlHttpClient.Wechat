﻿namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/skill/save 接口的响应。</para>
    /// </summary>
    public class SkillSaveResponse : WechatOpenAIThirdPartyResponse<SkillSaveResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置技能 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public long SkillId { get; set; }
            }
        }
    }
}
