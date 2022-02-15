using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /cgi-bin/express/delivery/open_msg/update_follow_waybill_goods 接口的请求。</para>
    /// </summary>
    public class CgibinExpressDeliveryOpenMessageUpdateFollowWaybillGoodsRequest : WechatApiRequest, IMapResponse<CgibinExpressDeliveryOpenMessageUpdateFollowWaybillGoodsRequest, CgibinExpressDeliveryOpenMessageUpdateFollowWaybillGoodsResponse>
    {
        public static class Types
        {
            public class Goods
            {
                public static class Types
                {
                    public class Detail : CgibinExpressDeliveryOpenMessageFollowWaybillRequest.Types.Goods.Types.Detail
                    {
                    }
                }

                /// <summary>
                /// 获取或设置商品详情列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("detail_list")]
                [System.Text.Json.Serialization.JsonPropertyName("detail_list")]
                public IList<Types.Detail> DetailList { get; set; } = new List<Types.Detail>();
            }
        }

        /// <summary>
        /// 获取或设置用户 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置微信订单查询 Token。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("waybill_token")]
        [System.Text.Json.Serialization.JsonPropertyName("waybill_token")]
        public string WaybillToken { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置商品信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("goods_info")]
        [System.Text.Json.Serialization.JsonPropertyName("goods_info")]
        public Types.Goods? Goods { get; set; }
    }
}
