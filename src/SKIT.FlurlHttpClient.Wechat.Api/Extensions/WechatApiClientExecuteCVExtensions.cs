using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static class WechatApiClientExecuteCVExtensions
    {
        private static HttpContent CreateRequestHttpContent(byte[]? fileBytes = null)
        {
            string boundary = "--BOUNDARY--" + DateTimeOffset.Now.Ticks.ToString("x");
            var httpContent = new MultipartFormDataContent(boundary);

            if (fileBytes != null && fileBytes.Any())
            {
                string filename = "image.png";
                var fileContent = new ByteArrayContent(fileBytes);
                httpContent.Add(fileContent, "\"img\"", "\"" + filename + "\"");
                fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("image/png");
                fileContent.Headers.ContentLength = fileBytes.Length;
            }

            httpContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data; boundary=" + boundary);

            return httpContent;
        }

        #region Image
        /// <summary>
        /// <para>异步调用 [POST] /cv/img/qrcode 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Intelligent_Interface/Img_Proc.html#%E4%BA%8C%E3%80%81%E4%BA%8C%E7%BB%B4%E7%A0%81-%E6%9D%A1%E7%A0%81%E8%AF%86%E5%88%AB%E6%8E%A5%E5%8F%A3 </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/img/img.scanQRCode.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CVImageQrcodeResponse> ExecuteCVImageQrcodeAsync(this WechatApiClient client, Models.CVImageQrcodeRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cv", "img", "qrcode")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            if (!string.IsNullOrEmpty(request.ImageUrl))
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

            using var httpContent = CreateRequestHttpContent(request.ImageFileBytes ?? new byte[0]);
            return await client.SendRequestAsync<Models.CVImageQrcodeResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cv/img/superresolution 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Intelligent_Interface/Img_Proc.html#%E4%B8%89%E3%80%81%E5%9B%BE%E7%89%87%E9%AB%98%E6%B8%85%E5%8C%96%E6%8E%A5%E5%8F%A3 </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/img/img.superresolution.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CVImageSuperResolutionResponse> ExecuteCVImageSuperResolutionAsync(this WechatApiClient client, Models.CVImageSuperResolutionRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cv", "img", "superresolution")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            if (!string.IsNullOrEmpty(request.ImageUrl))
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

            using var httpContent = CreateRequestHttpContent(request.ImageFileBytes ?? new byte[0]);
            return await client.SendRequestAsync<Models.CVImageSuperResolutionResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cv/img/aicrop 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Intelligent_Interface/Img_Proc.html#%E5%9B%9B%E3%80%81%E5%9B%BE%E7%89%87%E6%99%BA%E8%83%BD%E8%A3%81%E5%89%AA%E6%8E%A5%E5%8F%A3 </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/img/img.aiCrop.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CVImageAICropResponse> ExecuteCVImageAICropAsync(this WechatApiClient client, Models.CVImageAICropRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cv", "img", "aicrop")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            if (!string.IsNullOrEmpty(request.ImageUrl))
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

            using var httpContent = CreateRequestHttpContent(request.ImageFileBytes ?? new byte[0]);
            return await client.SendRequestAsync<Models.CVImageAICropResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }
        #endregion

        #region OCR
        /// <summary>
        /// <para>异步调用 [POST] /cv/ocr/idcard 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Intelligent_Interface/OCR.html </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/ocr/ocr.idcard.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CVOCRIdCardResponse> ExecuteCVOCRIdCardAsync(this WechatApiClient client, Models.CVOCRIdCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cv", "ocr", "idcard")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.ImageMode);

            if (!string.IsNullOrEmpty(request.ImageUrl))
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

            using var httpContent = CreateRequestHttpContent(request.ImageFileBytes ?? new byte[0]);
            return await client.SendRequestAsync<Models.CVOCRIdCardResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cv/ocr/bankcard 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Intelligent_Interface/OCR.html </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/ocr/ocr.bankcard.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CVOCRBankCardResponse> ExecuteCVOCRBankCardAsync(this WechatApiClient client, Models.CVOCRBankCardRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cv", "ocr", "bankcard")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.ImageMode);

            if (!string.IsNullOrEmpty(request.ImageUrl))
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

            using var httpContent = CreateRequestHttpContent(request.ImageFileBytes ?? new byte[0]);
            return await client.SendRequestAsync<Models.CVOCRBankCardResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cv/ocr/driving 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Intelligent_Interface/OCR.html </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/ocr/ocr.vehicleLicense.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CVOCRDrivingResponse> ExecuteCVOCRDrivingAsync(this WechatApiClient client, Models.CVOCRDrivingRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cv", "ocr", "driving")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.ImageMode);

            if (!string.IsNullOrEmpty(request.ImageUrl))
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

            using var httpContent = CreateRequestHttpContent(request.ImageFileBytes ?? new byte[0]);
            return await client.SendRequestAsync<Models.CVOCRDrivingResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cv/ocr/drivinglicense 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Intelligent_Interface/OCR.html </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/ocr/ocr.driverLicense.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CVOCRDrivingLicenseResponse> ExecuteCVOCRDrivingLicenseAsync(this WechatApiClient client, Models.CVOCRDrivingLicenseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cv", "ocr", "drivinglicense")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.ImageMode);

            if (!string.IsNullOrEmpty(request.ImageUrl))
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

            using var httpContent = CreateRequestHttpContent(request.ImageFileBytes ?? new byte[0]);
            return await client.SendRequestAsync<Models.CVOCRDrivingLicenseResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cv/ocr/bizlicense 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Intelligent_Interface/OCR.html </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/ocr/ocr.businessLicense.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CVOCRBusinessLicenseResponse> ExecuteCVOCRBusinessLicenseAsync(this WechatApiClient client, Models.CVOCRBusinessLicenseRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cv", "ocr", "bizlicense")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.ImageMode);

            if (!string.IsNullOrEmpty(request.ImageUrl))
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

            using var httpContent = CreateRequestHttpContent(request.ImageFileBytes ?? new byte[0]);
            return await client.SendRequestAsync<Models.CVOCRBusinessLicenseResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cv/ocr/comm 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Intelligent_Interface/OCR.html </para>
        /// <para>REF: https://developers.weixin.qq.com/miniprogram/dev/api-backend/open-api/ocr/ocr.printedText.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CVOCRCommonResponse> ExecuteCVOCRCommonAsync(this WechatApiClient client, Models.CVOCRCommonRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cv", "ocr", "comm")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            if (!string.IsNullOrEmpty(request.ImageUrl))
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

            using var httpContent = CreateRequestHttpContent(request.ImageFileBytes ?? new byte[0]);
            return await client.SendRequestAsync<Models.CVOCRCommonResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// <para>异步调用 [POST] /cv/ocr/platenum 接口。</para>
        /// <para>REF: https://developers.weixin.qq.com/doc/offiaccount/Intelligent_Interface/OCR.html </para>
        /// </summary>
        /// <param name="client"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public static async Task<Models.CVOCRPlateNumberResponse> ExecuteCVOCRPlateNumberAsync(this WechatApiClient client, Models.CVOCRPlateNumberRequest request, CancellationToken cancellationToken = default)
        {
            if (client is null) throw new ArgumentNullException(nameof(client));
            if (request is null) throw new ArgumentNullException(nameof(request));

            IFlurlRequest flurlReq = client
                .CreateRequest(HttpMethod.Post, "cv", "ocr", "platenum")
                .SetOptions(request)
                .SetQueryParam("access_token", request.AccessToken);

            if (!string.IsNullOrEmpty(request.ImageUrl))
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

            using var httpContent = CreateRequestHttpContent(request.ImageFileBytes ?? new byte[0]);
            return await client.SendRequestAsync<Models.CVOCRPlateNumberResponse>(flurlReq, content: httpContent, cancellationToken: cancellationToken);
        }
        #endregion
    }
}
