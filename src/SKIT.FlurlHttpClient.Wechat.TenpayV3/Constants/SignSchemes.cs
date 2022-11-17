namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.Constants
{
    public static class SignSchemes
    {
        /// <summary>
        /// RSA 算法：RSA2048 Sign with SHA256。
        /// </summary>
        public const string WECHATPAY2_RSA_2048_WITH_SHA256 = "WECHATPAY2-SHA256-RSA2048";

        /// <summary>
        /// 国密算法：SM2 Sign with SM3。
        /// </summary>
        public const string WECHATPAY2_SM2_WITH_SM3 = "WECHATPAY2-SM2-WITH-SM3";
    }
}
