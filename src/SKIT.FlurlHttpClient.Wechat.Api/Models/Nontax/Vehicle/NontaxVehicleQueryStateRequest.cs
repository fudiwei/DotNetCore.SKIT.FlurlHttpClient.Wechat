using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /nontax/vehicle/querystate 接口的请求。</para>
    /// </summary>
    public class NontaxVehicleQueryStateRequest : WechatApiRequest, IMapResponse<NontaxVehicleQueryStateRequest, NontaxVehicleQueryStateResponse>
    {
        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatApiClient"/> 时的 <see cref="WechatApiClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置银行 ID。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_id")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_id")]
        public string? BankId { get; set; }

        /// <summary>
        /// 获取或设置清分银行账号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bank_account")]
        [System.Text.Json.Serialization.JsonPropertyName("bank_account")]
        public string? BankAccount { get; set; }

        /// <summary>
        /// 获取或设置结算商户号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mch_id")]
        [System.Text.Json.Serialization.JsonPropertyName("mch_id")]
        public string? MerchantId { get; set; }

        /// <summary>
        /// 获取或设置行政区划代码。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region_code")]
        [System.Text.Json.Serialization.JsonPropertyName("region_code")]
        public string RegionCode { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置委托代扣的交易场景值。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("trade_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("trade_scene")]
        public string TradeScene { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商户跳转的业务场景。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jump_scene")]
        [System.Text.Json.Serialization.JsonPropertyName("jump_scene")]
        public string? JumpScene { get; set; }

        /// <summary>
        /// 获取或设置用户 OpenId。与字段 <see cref="PlateNumber"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string? OpenId { get; set; }

        /// <summary>
        /// 获取或设置车牌号。与字段 <see cref="OpenId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("plate_number")]
        [System.Text.Json.Serialization.JsonPropertyName("plate_number")]
        public string? PlateNumber { get; set; }

        /// <summary>
        /// 获取或设置用户通过扫码进入商户小程序时所扫的物料码信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("material_info")]
        [System.Text.Json.Serialization.JsonPropertyName("material_info")]
        public string? MaterialInformation { get; set; }

        /// <summary>
        /// 获取或设置高速通道类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("channel_type")]
        [System.Text.Json.Serialization.JsonPropertyName("channel_type")]
        public string? ChannelType { get; set; }
    }
}
