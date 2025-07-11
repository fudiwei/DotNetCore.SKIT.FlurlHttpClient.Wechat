using System;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/cooperation/shop/list 接口的响应。</para>
    /// </summary>
    [Obsolete("相关接口或字段于 2025-06-16 下线。")]
    public class ChannelsECCooperationShopListResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Shop
            {
                /// <summary>
                /// 获取或设置小店 AppId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("appid")]
                [System.Text.Json.Serialization.JsonPropertyName("appid")]
                public string AppId { get; set; } = default!;

                /// <summary>
                /// 获取或设置小店名称。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("nickname")]
                [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                public string Nickname { get; set; } = default!;

                /// <summary>
                /// 获取或设置绑定状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置绑定时间毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bind_time")]
                [System.Text.Json.Serialization.JsonPropertyName("bind_time")]
                public long? BindTimeMilliseconds { get; set; }

                /// <summary>
                /// 获取或设置解绑时间毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("unbind_time")]
                [System.Text.Json.Serialization.JsonPropertyName("unbind_time")]
                public long? UnbindTimeMilliseconds { get; set; }

                /// <summary>
                /// 获取或设置取消时间毫秒级时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cancel_time")]
                [System.Text.Json.Serialization.JsonPropertyName("cancel_time")]
                public long? CancelTimeMilliseconds { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置小店列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shop_list")]
        [System.Text.Json.Serialization.JsonPropertyName("shop_list")]
        public Types.Shop[] ShopList { get; set; } = default!;
    }
}
