using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [GET] /union/promoter/open_product/list 接口的请求。</para>
    /// </summary>
    public class UnionPromoterOpenProductListRequest : WechatApiRequest, IInferable<UnionPromoterOpenProductListRequest, UnionPromoterOpenProductListResponse>
    {
        /// <summary>
        /// 获取或设置分页起始位置。
        /// <para>默认值：0</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Offset { get; set; } = 0;

        /// <summary>
        /// 获取或设置分页起始位置。
        /// <para>默认值：30</para>
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int Limit { get; set; } = 10;

        /// <summary>
        /// 获取或设置搜索类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? QueryType { get; set; }

        /// <summary>
        /// 获取或设置搜索关键词。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public string? Query { get; set; }

        /// <summary>
        /// 获取或设置商品最高价格（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? MaxPrice { get; set; }

        /// <summary>
        /// 获取或设置商品最低价格（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? MinPrice { get; set; }

        /// <summary>
        /// 获取或设置佣金金额下限（单位：分）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? MinCommissionValue { get; set; }

        /// <summary>
        /// 获取或设置佣金比例下限（单位：万分数）。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? MinCommissionRatio { get; set; }

        /// <summary>
        /// 获取或设置排序类型。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? SortType { get; set; }

        /// <summary>
        /// 获取或设置类目 ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public int? CategoryId { get; set; }

        /// <summary>
        /// 获取或设置小程序 AppId 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<string>? ShopAppIdList { get; set; }

        /// <summary>
        /// 获取或设置类目 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<int>? CategoryIdList { get; set; }

        /// <summary>
        /// 获取或设置黑名单类目 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<int>? CategoryIdBlackList { get; set; }

        /// <summary>
        /// 获取或设置商品 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        public IList<long>? ProductIdList { get; set; }
    }
}
