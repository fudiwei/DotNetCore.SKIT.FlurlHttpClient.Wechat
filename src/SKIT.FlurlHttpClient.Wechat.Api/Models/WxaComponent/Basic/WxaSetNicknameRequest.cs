using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /wxa/setnickname 接口的请求。</para>
    /// </summary>
    public class WxaSetNicknameRequest : WechatApiRequest, IMapResponse<WxaSetNicknameRequest, WxaSetNicknameResponse>
    {
        /// <summary>
        /// 获取或设置小程序昵称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nick_name")]
        [System.Text.Json.Serialization.JsonPropertyName("nick_name")]
        public string Nickname { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置身份证照片的 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id_card")]
        [System.Text.Json.Serialization.JsonPropertyName("id_card")]
        public string? IdCardPictureMediaId { get; set; }

        /// <summary>
        /// 获取或设置组织机构代码证或营业执照照片的 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("license")]
        [System.Text.Json.Serialization.JsonPropertyName("license")]
        public string? LicensePictureMediaId { get; set; }

        /// <summary>
        /// 获取或设置其他证明材料的 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("naming_other_stuff_1")]
        [System.Text.Json.Serialization.JsonPropertyName("naming_other_stuff_1")]
        public string? OtherStuff1MediaId { get; set; }

        /// <summary>
        /// 获取或设置其他证明材料的 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("naming_other_stuff_2")]
        [System.Text.Json.Serialization.JsonPropertyName("naming_other_stuff_2")]
        public string? OtherStuff2MediaId { get; set; }

        /// <summary>
        /// 获取或设置其他证明材料的 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("naming_other_stuff_3")]
        [System.Text.Json.Serialization.JsonPropertyName("naming_other_stuff_3")]
        public string? OtherStuff3MediaId { get; set; }

        /// <summary>
        /// 获取或设置其他证明材料的 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("naming_other_stuff_4")]
        [System.Text.Json.Serialization.JsonPropertyName("naming_other_stuff_4")]
        public string? OtherStuff4MediaId { get; set; }

        /// <summary>
        /// 获取或设置其他证明材料的 MediaId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("naming_other_stuff_5")]
        [System.Text.Json.Serialization.JsonPropertyName("naming_other_stuff_5")]
        public string? OtherStuff5MediaId { get; set; }
    }
}
