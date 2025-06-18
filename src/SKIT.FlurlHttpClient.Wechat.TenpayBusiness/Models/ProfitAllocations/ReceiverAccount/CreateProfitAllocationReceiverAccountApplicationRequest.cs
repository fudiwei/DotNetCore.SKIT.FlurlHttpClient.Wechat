using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayBusiness.Models
{
    /// <summary>
    /// <para>表示 [POST] /mse-pay/profit-allocations/receiver-accounts-applications 接口的请求。</para>
    /// </summary>
    [WechatTenpayBusinessSensitive]
    public class CreateProfitAllocationReceiverAccountApplicationRequest : WechatTenpayBusinessRequest
    {
        public static class Types
        {
            public class NaturalPerson
            {
                public static class Types
                {
                    public class Address
                    {
                        /// <summary>
                        /// 获取或设置详细地址。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("detail_address")]
                        [System.Text.Json.Serialization.JsonPropertyName("detail_address")]
                        public string DetailedAddress { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置省份代码。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("province_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("province_code")]
                        public string ProvinceCode { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置省份名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("province_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("province_name")]
                        public string ProvinceName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置城市名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("city_code")]
                        public string CityCode { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置城市名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("city_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("city_name")]
                        public string CityName { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置区县名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("area_code")]
                        [System.Text.Json.Serialization.JsonPropertyName("area_code")]
                        public string DistrictCode { get; set; } = string.Empty;

                        /// <summary>
                        /// 获取或设置区县名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("area_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("area_name")]
                        public string DistrictName { get; set; } = string.Empty;
                    }
                }

                /// <summary>
                /// 获取或设置姓名（需使用微企付公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("name")]
                [System.Text.Json.Serialization.JsonPropertyName("name")]
                [WechatTenpayBusinessSensitiveProperty]
                public string Name { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证号（需使用微企付公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("number")]
                [System.Text.Json.Serialization.JsonPropertyName("number")]
                [WechatTenpayBusinessSensitiveProperty]
                public string IdCardNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证期限（格式：["yyyy-MM-dd", "yyyy-MM-dd"]，长期用 "长期" 表示）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("validity_period")]
                [System.Text.Json.Serialization.JsonPropertyName("validity_period")]
                public IList<string> ValidityPeriodStrings { get; set; } = new List<string>();

                /// <summary>
                /// 获取或设置身份证人像面照片 FileId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("front_photocopy_file_id")]
                [System.Text.Json.Serialization.JsonPropertyName("front_photocopy_file_id")]
                public string FrontPhotoCopyFileId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证国徽面照片 FileId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("back_photocopy_file_id")]
                [System.Text.Json.Serialization.JsonPropertyName("back_photocopy_file_id")]
                public string BackPhotoCopyFileId { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置身份证地址信息。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("id_card_address_info")]
                [System.Text.Json.Serialization.JsonPropertyName("id_card_address_info")]
                public Types.Address Address { get; set; } = new Types.Address();
            }

            public class SettlementAccount
            {
                /// <summary>
                /// 获取或设置账户类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("account_type")]
                [System.Text.Json.Serialization.JsonPropertyName("account_type")]
                public string AccountType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置开户银行。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_name")]
                public string BankName { get; set; } = default!;

                /// <summary>
                /// 获取或设置开户银行联行号。与字段 <see cref="BankBranchName"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_branch_id")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_branch_id")]
                public string? BankBranchId { get; set; }

                /// <summary>
                /// 获取或设置开户银行全称（含支行）。与字段 <see cref="BankBranchId"/> 二选一。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_branch_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_branch_name")]
                public string? BankBranchName { get; set; }

                /// <summary>
                /// 获取或设置开户名称（需使用微企付公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_name")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_name")]
                [WechatTenpayBusinessSensitiveProperty]
                public string BankAccountName { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置银行卡号（需使用微企付公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_number")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_number")]
                [WechatTenpayBusinessSensitiveProperty]
                public string BankAccountNumber { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置银行预留手机号（需使用微企付公钥加密）。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("bank_account_mobile")]
                [System.Text.Json.Serialization.JsonPropertyName("bank_account_mobile")]
                [WechatTenpayBusinessSensitiveProperty]
                public string? BankAccountMobileNumber { get; set; }

                /// <summary>
                /// 获取或设置银行卡正面照片 FileId。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("front_photocopy_file_id")]
                [System.Text.Json.Serialization.JsonPropertyName("front_photocopy_file_id")]
                public string? FrontPhotoCopyFileId { get; set; }
            }

            public class WithdrawCycle
            {
                /// <summary>
                /// 获取或设置周期类型。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cycle_type")]
                [System.Text.Json.Serialization.JsonPropertyName("cycle_type")]
                public string CycleType { get; set; } = string.Empty;

                /// <summary>
                /// 获取或设置周期值。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("cycle_value")]
                [System.Text.Json.Serialization.JsonPropertyName("cycle_value")]
                public int CycleValue { get; set; }
            }
        }

        /// <summary>
        /// 获取或设置企业商户 ID。如果不指定将使用构造 <see cref="WechatTenpayBusinessClient"/> 时的 <see cref="WechatTenpayBusinessClientOptions.EnterpriseId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ent_id")]
        [System.Text.Json.Serialization.JsonPropertyName("ent_id")]
        public string? EnterpriseId { get; set; }

        /// <summary>
        /// 获取或设置平台申请单号。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_application_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_application_id")]
        public string OutApplicationId { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置接收方类型。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("receiver_type")]
        [System.Text.Json.Serialization.JsonPropertyName("receiver_type")]
        public string ReceiverType { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置平台接收方名称。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_receiver_name")]
        [System.Text.Json.Serialization.JsonPropertyName("out_receiver_name")]
        public string OutReceiverName { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置个人经营者信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("natural_person_info")]
        [System.Text.Json.Serialization.JsonPropertyName("natural_person_info")]
        public Types.NaturalPerson? NaturalPerson { get; set; }

        /// <summary>
        /// 获取或设置结算账户信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("settlement_account")]
        [System.Text.Json.Serialization.JsonPropertyName("settlement_account")]
        public Types.SettlementAccount SettlementAccount { get; set; } = new Types.SettlementAccount();

        /// <summary>
        /// 获取或设置提现周期信息。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("withdraw_cycle")]
        [System.Text.Json.Serialization.JsonPropertyName("withdraw_cycle")]
        public Types.WithdrawCycle WithdrawCycle { get; set; } = new Types.WithdrawCycle();
    }
}
