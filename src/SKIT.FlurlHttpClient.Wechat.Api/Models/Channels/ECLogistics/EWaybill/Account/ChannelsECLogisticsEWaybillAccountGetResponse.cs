namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /channels/ec/logistics/ewaybill/biz/account/get 接口的响应。</para>
    /// </summary>
    public class ChannelsECLogisticsEWaybillAccountGetResponse : WechatApiResponse
    {
        public static class Types
        {
            public class Account
            {
                public static class Types
                {
                    public class SiteInfo
                    {
                        public static class Types
                        {
                            public class Address
                            {
                                /// <summary>
                                /// 获取或设置国家编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("country_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("country_code")]
                                public string CountryCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置省份编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("province_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("province_code")]
                                public string ProvinceCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置省份名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("province_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("province_name")]
                                public string ProvinceName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置城市编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("city_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("city_code")]
                                public string CityCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置城市名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("city_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("city_name")]
                                public string CityName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置区县编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("district_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("district_code")]
                                public string DistrictCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置区县名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("district_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("district_name")]
                                public string DistrictName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置街道编码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("street_code")]
                                [System.Text.Json.Serialization.JsonPropertyName("street_code")]
                                public string StreetCode { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置街道名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("street_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("street_name")]
                                public string StreetName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置详细地址。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("detail_address")]
                                [System.Text.Json.Serialization.JsonPropertyName("detail_address")]
                                public string DetailAddress { get; set; } = default!;
                            }

                            public class Contact
                            {
                                /// <summary>
                                /// 获取或设置联系人。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("name")]
                                [System.Text.Json.Serialization.JsonPropertyName("name")]
                                public string Name { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置手机号码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("mobile")]
                                [System.Text.Json.Serialization.JsonPropertyName("mobile")]
                                public string MobileNumber { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置电话号码。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("phone")]
                                [System.Text.Json.Serialization.JsonPropertyName("phone")]
                                public string PhoneNumber { get; set; } = default!;
                            }
                        }

                        /// <summary>
                        /// 获取或设置快递公司 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                        public string DeliveryId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置网点运营状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("site_status")]
                        [System.Text.Json.Serialization.JsonPropertyName("site_status")]
                        public int SiteStatus { get; set; }

                        /// <summary>
                        /// 获取或设置网点编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("site_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("site_code")]
                        public string SiteCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置网点名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("site_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("site_name")]
                        public string SiteName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置网点全名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("site_fullname")]
                        [System.Text.Json.Serialization.JsonPropertyName("site_fullname")]
                        public string SiteFullName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置地址信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public Types.Address Address { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置联系方式信息。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("contact")]
                        [System.Text.Json.Serialization.JsonPropertyName("contact")]
                        public Types.Contact Contact { get; set; } = default!;
                    }

                    public class ShareInfo
                    {
                        /// <summary>
                        /// 获取或设置快递公司 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("delivery_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                        public string DeliveryId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置网点编码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("site_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("site_code")]
                        public string SiteCode { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置网点名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("site_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("site_name")]
                        public string SiteName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置共享 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("share_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("share_id")]
                        public string ShareId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置店铺 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shop_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                        public string ShopId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置电子面单账号 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("acct_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("acct_id")]
                        public string AccountId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置发起共享方店铺名。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("nickname")]
                        [System.Text.Json.Serialization.JsonPropertyName("nickname")]
                        public string Nickname { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置月结账号。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("monthly_card")]
                        [System.Text.Json.Serialization.JsonPropertyName("monthly_card")]
                        public string? MonthlyCard { get; set; }

                        /// <summary>
                        /// 获取或设置更新时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("update_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("update_time")]
                        public long UpdateTimestamp { get; set; }
                    }

                    public class SenderAddress
                    {
                        /// <summary>
                        /// 获取或设置省份。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("province")]
                        [System.Text.Json.Serialization.JsonPropertyName("province")]
                        public string Province { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置城市。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city")]
                        [System.Text.Json.Serialization.JsonPropertyName("city")]
                        public string City { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置区县。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("county")]
                        [System.Text.Json.Serialization.JsonPropertyName("county")]
                        public string District { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置街道。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("street")]
                        [System.Text.Json.Serialization.JsonPropertyName("street")]
                        public string Street { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置详细地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("address")]
                        [System.Text.Json.Serialization.JsonPropertyName("address")]
                        public string DetailAddress { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置快递公司 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("delivery_id")]
                [System.Text.Json.Serialization.JsonPropertyName("delivery_id")]
                public string DeliveryId { get; set; } = default!;

                /// <summary>
                /// 获取或设置店铺 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("shop_id")]
                [System.Text.Json.Serialization.JsonPropertyName("shop_id")]
                public string ShopId { get; set; } = default!;

                /// <summary>
                /// 获取或设置电子面单账号 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("acct_id")]
                [System.Text.Json.Serialization.JsonPropertyName("acct_id")]
                public string AccountId { get; set; } = default!;

                /// <summary>
                /// 获取或设置电子面单账号类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("acct_type")]
                [System.Text.Json.Serialization.JsonPropertyName("acct_type")]
                public int AccountType { get; set; } = default!;

                /// <summary>
                /// 获取或设置状态。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("status")]
                [System.Text.Json.Serialization.JsonPropertyName("status")]
                public int Status { get; set; }

                /// <summary>
                /// 获取或设置面单余额（单位：分）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("available")]
                [System.Text.Json.Serialization.JsonPropertyName("available")]
                public int AvailableBalance { get; set; }

                /// <summary>
                /// 获取或设置累积已取单。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("allocated")]
                [System.Text.Json.Serialization.JsonPropertyName("allocated")]
                public int AllocatedCount { get; set; }

                /// <summary>
                /// 获取或设置累积已回收。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("recycled")]
                [System.Text.Json.Serialization.JsonPropertyName("recycled")]
                public int RecycledCount { get; set; }

                /// <summary>
                /// 获取或设置累计已取消。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cancel")]
                [System.Text.Json.Serialization.JsonPropertyName("cancel")]
                public int CancelCount { get; set; }

                /// <summary>
                /// 获取或设置月结账号。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("monthly_card")]
                [System.Text.Json.Serialization.JsonPropertyName("monthly_card")]
                public string? MonthlyCard { get; set; }

                /// <summary>
                /// 获取或设置网点信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("site_info")]
                [System.Text.Json.Serialization.JsonPropertyName("site_info")]
                public Types.SiteInfo? SiteInfo { get; set; }

                /// <summary>
                /// 获取或设置共享账号信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("share")]
                [System.Text.Json.Serialization.JsonPropertyName("share")]
                public Types.ShareInfo? ShareInfo { get; set; }

                /// <summary>
                /// 获取或设置发货地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sender_address")]
                [System.Text.Json.Serialization.JsonPropertyName("sender_address")]
                public Types.SenderAddress? SenderAddress { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置账号列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("account_list")]
        [System.Text.Json.Serialization.JsonPropertyName("account_list")]
        public Types.Account[] AccountList { get; set; } = default!;

        /// <summary>
        /// 获取或设置总数量。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total_num")]
        [System.Text.Json.Serialization.JsonPropertyName("total_num")]
        public int TotalCount { get; set; }
    }
}
