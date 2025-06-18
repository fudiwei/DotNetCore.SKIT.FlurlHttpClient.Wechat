﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/material/del_material 接口的请求。</para>
    /// </summary>
    public class CgibinMaterialDeleteMaterialRequest : WechatApiRequest, IInferable<CgibinMaterialDeleteMaterialRequest, CgibinMaterialDeleteMaterialResponse>
    {
        /// <summary>
        /// 获取或设置媒体文件标识。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("media_id")]
        [System.Text.Json.Serialization.JsonPropertyName("media_id")]
        public string MediaId { get; set; } = string.Empty;
    }
}
