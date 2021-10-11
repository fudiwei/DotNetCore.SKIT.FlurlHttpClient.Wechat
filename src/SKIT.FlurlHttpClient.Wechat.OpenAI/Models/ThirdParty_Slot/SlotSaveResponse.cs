using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI.Models.ThirdParty
{
    /// <summary>
    /// <para>表示 [POST] /v2/slot/save 接口的响应。</para>
    /// </summary>
    public class SlotSaveResponse : WechatOpenAIThirdPartyResponse<SlotSaveResponse.Types.Slot[]>
    {
        public static class Types
        {
            public class Slot
            {
                /// <summary>
                /// 获取或设置语义槽 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id")]
                [System.Text.Json.Serialization.JsonPropertyName("id")]
                public long SlotId { get; set; }

                /// <summary>
                /// 获取或设置语义槽名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                public string Name { get; set; } = default!;
            }
        }
    }
}
