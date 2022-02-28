using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/createwxagameroom 接口的请求。</para>
    /// </summary>
    public class WxaCreateWxaGameRoomRequest : WechatApiRequest, IInferable<WxaCreateWxaGameRoomRequest, WxaCreateWxaGameRoomResponse>
    {
        /// <summary>
        /// 获取或设置后台下发游戏逻辑帧的周期（单位：毫秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("game_tick")]
        [System.Text.Json.Serialization.JsonPropertyName("game_tick")]
        public int GameTick { get; set; }

        /// <summary>
        /// 获取或设置房间成员的 OpenId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("open_id_list")]
        [System.Text.Json.Serialization.JsonPropertyName("open_id_list")]
        public IList<string> OpenIdList { get; set; } = new List<string>();

        /// <summary>
        /// 获取或设置发送开始游戏指令的玩家达到比例后开始游戏。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("start_percent")]
        [System.Text.Json.Serialization.JsonPropertyName("start_percent")]
        public int StartPercent { get; set; }

        /// <summary>
        /// 获取或设置使用的 UDP 可靠性策略。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("udp_reliability_strategy")]
        [System.Text.Json.Serialization.JsonPropertyName("udp_reliability_strategy")]
        public int UdpReliabilityStrategy { get; set; } = 3;

        /// <summary>
        /// 获取或设置是否需要用户的头像昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_user_info")]
        [System.Text.Json.Serialization.JsonPropertyName("need_user_info")]
        public bool? RequireUserInformation { get; set; }

        /// <summary>
        /// 获取或设置游戏对局时长（单位：秒）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("game_last_time")]
        [System.Text.Json.Serialization.JsonPropertyName("game_last_time")]
        public int? GameLastTime { get; set; }

        /// <summary>
        /// 获取或设置第三方自定义的房间信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("room_ext_info")]
        [System.Text.Json.Serialization.JsonPropertyName("room_ext_info")]
        public string? RoomExtra { get; set; }

        /// <summary>
        /// 获取或设置是否需要在创建房间时同时生成一个随机的游戏种子。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_game_seed")]
        [System.Text.Json.Serialization.JsonPropertyName("need_game_seed")]
        public bool? RequireGameSeed { get; set; }
    }
}
