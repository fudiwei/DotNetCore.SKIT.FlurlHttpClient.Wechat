using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3.ExtendedSDK.Global
{
    public static class WechatTenpayGlobalClientParameterExtensions
    {
        /// <summary>
        /// <para>生成客户端 JSAPI / 小程序调起支付所需的参数字典。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter3_3_12.shtml ]]> <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter3_5_12.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="prepayId"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForJsapiPayRequest(this WechatTenpayGlobalClient client, string appId, string prepayId)
        {
            return WechatTenpayClientParameterExtensions.GenerateParametersForJsapiPayRequest(client, appId, prepayId);
        }

        /// <summary>
        /// <para>生成 APP 调起支付所需的参数字典。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter3_4_12.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="appId"></param>
        /// <param name="prepayId"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForAppPayRequest(this WechatTenpayGlobalClient client, string appId, string prepayId)
        {
            return WechatTenpayClientParameterExtensions.GenerateParametersForAppPayRequest(client, appId, prepayId);
        }

        /// <summary>
        /// <para>生成 APP 调起支付所需的参数字典。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://pay.weixin.qq.com/wiki/doc/api_external/en/apis/chapter3_4_12.shtml ]]>
        /// </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="merchantId"></param>
        /// <param name="appId"></param>
        /// <param name="prepayId"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GenerateParametersForAppPayRequest(this WechatTenpayGlobalClient client, string merchantId, string appId, string prepayId)
        {
            return WechatTenpayClientParameterExtensions.GenerateParametersForAppPayRequest(client, merchantId, appId, prepayId);
        }
    }
}
