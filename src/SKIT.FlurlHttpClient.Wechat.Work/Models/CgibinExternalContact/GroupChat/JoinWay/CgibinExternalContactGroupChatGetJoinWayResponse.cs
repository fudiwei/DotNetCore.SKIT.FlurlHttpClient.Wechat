namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/groupchat/get_join_way 接口的响应。</para>
    /// </summary>
    public class CgibinExternalContactGroupChatGetJoinWayResponse : WechatWorkResponse
    {
        public static class Types
        {
            public class JoinWay
            {
                /// <summary>
                /// 获取或设置配置 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("config_id")]
                [System.Text.Json.Serialization.JsonPropertyName("config_id")]
                public string ConfigId { get; set; } = default!;

                /// <summary>
                /// 获取或设置场景值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("scene")]
                [System.Text.Json.Serialization.JsonPropertyName("scene")]
                public int Scene { get; set; }

                /// <summary>
                /// 获取或设置备注信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("remark")]
                [System.Text.Json.Serialization.JsonPropertyName("remark")]
                public string Remark { get; set; } = default!;

                /// <summary>
                /// 获取或设置是否自动新建群。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("auto_create_room")]
                [System.Text.Json.Serialization.JsonPropertyName("auto_create_room")]
                public int AutoCreateRoom { get; set; }

                /// <summary>
                /// 获取或设置自动建群的群名前缀。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("room_base_name")]
                [System.Text.Json.Serialization.JsonPropertyName("room_base_name")]
                public string? RoomBaseName { get; set; }

                /// <summary>
                /// 获取或设置自动建群的群起始序号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("room_base_id")]
                [System.Text.Json.Serialization.JsonPropertyName("room_base_id")]
                public int? RoomBaseId { get; set; }

                /// <summary>
                /// 获取或设置客户群 ID 列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("chat_id_list")]
                [System.Text.Json.Serialization.JsonPropertyName("chat_id_list")]
                public string[] GroupChatIdList { get; set; } = default!;

                /// <summary>
                /// 获取或设置联系二维码 URL。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("qr_code")]
                [System.Text.Json.Serialization.JsonPropertyName("qr_code")]
                public string? QrcodeUrl { get; set; }

                /// <summary>
                /// 获取或设置入群渠道。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("state")]
                [System.Text.Json.Serialization.JsonPropertyName("state")]
                public string? State { get; set; }

                /// <summary>
                /// 获取或设置是否标记客户添加来源为该应用创建的。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("mark_source")]
                [System.Text.Json.Serialization.JsonPropertyName("mark_source")]
                public bool? IsMarkSource { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置配置 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("join_way")]
        [System.Text.Json.Serialization.JsonPropertyName("join_way")]
        public Types.JoinWay JoinWay { get; set; } = default!;
    }
}
