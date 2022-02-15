﻿using System;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Ads
{
    public static class WechatAdsClientExecuteAsyncTasksExtensions
    {
        /// <summary>
        /// <para>异步调用 [POST] /async_tasks/add 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AsyncTasksAddResponse> ExecuteAsyncTasksAddAsync(this WechatAdsClient client, Models.AsyncTasksAddRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Post, "async_tasks", "add")
                .SetQueryParam("access_token", request.AccessToken);

            return await client.SendRequestWithJsonAsync<Models.AsyncTasksAddResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [GET] /async_tasks/get 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AsyncTasksGetResponse> ExecuteAsyncTasksGetAsync(this WechatAdsClient client, Models.AsyncTasksGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "async_tasks", "get")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.Filters != null && request.Filters.Any())
                flurlReq.SetQueryParam("filtering", client.JsonSerializer.Serialize(request.Filters));

            if (request.PageSize != null)
                flurlReq.SetQueryParam("page_size", request.PageSize.Value);

            if (request.Page != null)
                flurlReq.SetQueryParam("page", request.Page.Value);

            return await client.SendRequestWithJsonAsync<Models.AsyncTasksGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }

        #region Files
        /// <summary>
        /// <para>异步调用 [GET] /async_task_files/get 接口。</para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.AsyncTaskFilesGetResponse> ExecuteAsyncTaskFilesGetAsync(this WechatAdsClient client, Models.AsyncTaskFilesGetRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(request, HttpMethod.Get, "async_task_files", "get")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("task_id", request.TaskId)
                .SetQueryParam("file_id", request.FileId);

            return await client.SendRequestWithJsonAsync<Models.AsyncTaskFilesGetResponse>(flurlReq, data: request, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
