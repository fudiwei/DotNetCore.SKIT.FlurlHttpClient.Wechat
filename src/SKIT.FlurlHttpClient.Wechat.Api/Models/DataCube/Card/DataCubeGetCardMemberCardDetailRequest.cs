using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /datacube/getcardmembercarddetail 接口的请求。</para>
    /// </summary>
    public class DataCubeGetCardMemberCardDetailRequest : WechatApiRequest, IMapResponse<DataCubeGetCardMemberCardDetailRequest, DataCubeGetCardMemberCardDetailResponse>
    {
        /// <summary>
        /// 获取或设置获取数据的起始日期（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("begin_date")]
        [System.Text.Json.Serialization.JsonPropertyName("begin_date")]
        public string BeginDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置获取数据的结束日期（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("end_date")]
        [System.Text.Json.Serialization.JsonPropertyName("end_date")]
        public string EndDateString { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;
    }
}
