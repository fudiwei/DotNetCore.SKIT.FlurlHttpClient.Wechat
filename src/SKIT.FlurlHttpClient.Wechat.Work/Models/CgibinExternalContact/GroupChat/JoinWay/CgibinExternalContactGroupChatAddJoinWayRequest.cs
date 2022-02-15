using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Work.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/externalcontact/groupchat/add_join_way 接口的请求。</para>
    /// </summary>
    public class CgibinExternalContactGroupChatAddJoinWayRequest : WechatWorkRequest
    {
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
        public string? Remark { get; set; }

        /// <summary>
        /// 获取或设置是否自动新建群。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auto_create_room")]
        [System.Text.Json.Serialization.JsonPropertyName("auto_create_room")]
        public int? AutoCreateRoom { get; set; }

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
        public IList<string> GroupChatIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置入群渠道。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("state")]
        [System.Text.Json.Serialization.JsonPropertyName("state")]
        public string? State { get; set; }
    }
}
