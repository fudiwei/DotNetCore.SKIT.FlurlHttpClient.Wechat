using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Models
{
    /// <summary>
    /// <para>表示 [GET] /new-tax-control-fapiao/fapiaomerchant/listspinvitemchinfo 接口的请求。</para>
    /// </summary>
    public class QueryNewTaxControlFapiaoMerchantServicePartnerInvitedMerchantsRequest : WechatTenpayRequest
    {
        /// <summary>
        /// 获取或设置查询起始时间。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public DateTimeOffset? QueryStartTime { get; set; }

        /// <summary>
        /// 获取或设置查询截止时间。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public DateTimeOffset? QueryEndTime { get; set; }

        /// <summary>
        /// 获取或设置分页大小。
        /// <para>默认值：0</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Limit { get; set; } = 0;

        /// <summary>
        /// 获取或设置分页开始位置。
        /// <para>默认值：10</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Offset { get; set; } = 10;

        /// <summary>
        /// 获取或设置邀请码。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? InviteCode { get; set; }

        /// <summary>
        /// 获取或设置商户邀请状态。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? MerchantInviteStatus { get; set; }
    }
}
