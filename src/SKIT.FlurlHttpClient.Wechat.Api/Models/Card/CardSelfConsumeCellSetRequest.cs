using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /card/selfconsumecell/set 接口的请求。</para>
    /// </summary>
    public class CardSelfConsumeCellSetRequest : WechatApiRequest, IMapResponse<CardSelfConsumeCellSetRequest, CardSelfConsumeCellSetResponse>
    {
        /// <summary>
        /// 获取或设置卡券模板编号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("card_id")]
        [System.Text.Json.Serialization.JsonPropertyName("card_id")]
        public string CardId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置是否开启自助核销功能。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("is_open")]
        [System.Text.Json.Serialization.JsonPropertyName("is_open")]
        public bool IsOpen { get; set; }

        /// <summary>
        /// 获取或设置用户核销时是否需要输入验证码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_verify_cod")]
        [System.Text.Json.Serialization.JsonPropertyName("need_verify_cod")]
        public bool RequireVerifyCode { get; set; }

        /// <summary>
        /// 获取或设置用户核销时是否需要备注核销金额。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("need_remark_amount")]
        [System.Text.Json.Serialization.JsonPropertyName("need_remark_amount")]
        public bool RequireRemarkAmount { get; set; }
    }
}
