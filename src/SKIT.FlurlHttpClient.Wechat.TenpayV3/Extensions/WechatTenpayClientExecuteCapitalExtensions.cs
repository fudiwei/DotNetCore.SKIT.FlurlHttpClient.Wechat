using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.TenpayV3
{
    public static class WechatTenpayClientExecuteCapitalExtensions
    {
        #region Banks
        /// <summary>
        /// <para>异步调用 [GET] /capital/capitallhh/banks/search-banks-by-bank-account 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter11_2_1.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryCapitalBanksByBankAccountResponse> ExecuteQueryCapitalBanksByBankAccountAsync(this WechatTenpayClient client, Models.QueryCapitalBanksByBankAccountRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "capital", "capitallhh", "banks", "search-banks-by-bank-account")
                .SetQueryParam("account_number", request.AccountNumber);

            return await client.SendRequestWithJsonAsync<Models.QueryCapitalBanksByBankAccountResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /capital/capitallhh/banks/personal-banking 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter11_2_2.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryCapitalBanksPersonalBankingResponse> ExecuteQueryCapitalBanksPersonalBankingAsync(this WechatTenpayClient client, Models.QueryCapitalBanksPersonalBankingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "capital", "capitallhh", "banks", "personal-banking")
                .SetQueryParam("limit", request.Limit)
                .SetQueryParam("offset", request.Offset);

            return await client.SendRequestWithJsonAsync<Models.QueryCapitalBanksPersonalBankingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /capital/capitallhh/banks/corporate-banking 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter11_2_3.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryCapitalBanksCorporateBankingResponse> ExecuteQueryCapitalBanksCorporateBankingAsync(this WechatTenpayClient client, Models.QueryCapitalBanksCorporateBankingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "capital", "capitallhh", "banks", "corporate-banking")
                .SetQueryParam("limit", request.Limit)
                .SetQueryParam("offset", request.Offset);

            return await client.SendRequestWithJsonAsync<Models.QueryCapitalBanksCorporateBankingResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /capital/capitallhh/banks/{bank_alias_code}/branches 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter11_2_6.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryCapitalBanksBranchesResponse> ExecuteQueryCapitalBanksBranchesAsync(this WechatTenpayClient client, Models.QueryCapitalBanksBranchesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "capital", "capitallhh", "banks", request.BankAliasCode, "branches")
                .SetQueryParam("city_code", request.CityCode)
                .SetQueryParam("limit", request.Limit)
                .SetQueryParam("offset", request.Offset);

            return await client.SendRequestWithJsonAsync<Models.QueryCapitalBanksBranchesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion

        #region Areas
        /// <summary>
        /// <para>异步调用 [GET] /capital/capitallhh/areas/provinces 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter11_2_4.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryCapitalAreasProvincesResponse> ExecuteQueryCapitalAreasProvincesAsync(this WechatTenpayClient client, Models.QueryCapitalAreasProvincesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "capital", "capitallhh", "areas", "provinces");

            return await client.SendRequestWithJsonAsync<Models.QueryCapitalAreasProvincesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /capital/capitallhh/areas/provinces/{province_code}/cities 接口。</para>
        /// <para>REF: https://pay.weixin.qq.com/wiki/doc/apiv3/Offline/apis/chapter11_2_5.shtml </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.QueryCapitalAreasCitiesResponse> ExecuteQueryCapitalAreasCitiesAsync(this WechatTenpayClient client, Models.QueryCapitalAreasCitiesRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "capital", "capitallhh", "areas", "provinces", request.ProvinceCode, "cities");

            return await client.SendRequestWithJsonAsync<Models.QueryCapitalAreasCitiesResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
