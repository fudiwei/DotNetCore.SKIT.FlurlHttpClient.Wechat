using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/register/apply_scene 接口的请求。</para>
    /// </summary>
    public class ShopRegisterApplySceneRequest : WechatApiRequest
    {
        /// <summary>
        /// 获取或设置场景 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("scene_group_id")]
        [System.Text.Json.Serialization.JsonPropertyName("scene_group_id")]
        public int SceneGroupId { get; set; }
    }
}
