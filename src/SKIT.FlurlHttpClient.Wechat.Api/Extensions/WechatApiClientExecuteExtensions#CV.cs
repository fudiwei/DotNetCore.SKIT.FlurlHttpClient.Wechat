namespace SKIT.FlurlHttpClient.Wechat.Api
{
    public static partial class WechatApiClientExecuteExtensions
    {
        #region Image
        /// <summary>
        /// <para>异步调用 [POST] /cv/img/qrcode 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/openpoc/image/api_imgqrcode.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/openpoc/image/api_imgqrcode.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/img-ocr/img/api_imgqrcode.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cv", "img", "qrcode")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.ImageUrl is not null)
            {
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

                return await client.SendFlurlRequestAsJsonAsync<Models.CVImageQrcodeResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: "image.png", fileBytes: request.ImageFileBytes, fileContentType: "image/png", formDataName: "img");
                return await client.SendFlurlRequestAsync<Models.CVImageQrcodeResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// <para>异步调用 [POST] /cv/img/superresolution 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/openpoc/image/api_imgsuperresolution.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/openpoc/image/api_imgsuperresolution.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/img-ocr/img/api_imgsuperresolution.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cv", "img", "superresolution")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.ImageUrl is not null)
            {
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

                return await client.SendFlurlRequestAsJsonAsync<Models.CVImageSuperResolutionResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: "image.png", fileBytes: request.ImageFileBytes, fileContentType: "image/png", formDataName: "img");
                return await client.SendFlurlRequestAsync<Models.CVImageSuperResolutionResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// <para>异步调用 [POST] /cv/img/aicrop 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/openpoc/image/api_imgaicrop.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/openpoc/image/api_imgaicrop.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/img-ocr/img/api_imgaicrop.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cv", "img", "aicrop")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.ImageUrl is not null)
            {
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

                return await client.SendFlurlRequestAsJsonAsync<Models.CVImageAICropResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: "image.png", fileBytes: request.ImageFileBytes, fileContentType: "image/png", formDataName: "img");
                return await client.SendFlurlRequestAsync<Models.CVImageAICropResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }
        #endregion

        #region OCR
        /// <summary>
        /// <para>异步调用 [POST] /cv/ocr/comm 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/openpoc/ocr/api_commocr.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/openpoc/ocr/api_commocr.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/img-ocr/ocr/api_commocr.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cv", "ocr", "comm")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.ImageUrl is not null)
            {
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

                return await client.SendFlurlRequestAsJsonAsync<Models.CVOCRCommonResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: "image.png", fileBytes: request.ImageFileBytes, fileContentType: "image/png", formDataName: "img");
                return await client.SendFlurlRequestAsync<Models.CVOCRCommonResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// <para>异步调用 [POST] /cv/ocr/idcard 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/openpoc/ocr/api_idcardocr.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/openpoc/ocr/api_idcardocr.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/img-ocr/ocr/api_idcardocr.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cv", "ocr", "idcard")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.ImageMode);

            if (request.ImageUrl is not null)
            {
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

                return await client.SendFlurlRequestAsJsonAsync<Models.CVOCRIdCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: "image.png", fileBytes: request.ImageFileBytes, fileContentType: "image/png", formDataName: "img");
                return await client.SendFlurlRequestAsync<Models.CVOCRIdCardResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// <para>异步调用 [POST] /cv/ocr/bankcard 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/openpoc/ocr/api_bankcardocr.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/openpoc/ocr/api_bankcardocr.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/img-ocr/ocr/api_bankcardocr.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cv", "ocr", "bankcard")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.ImageMode);

            if (request.ImageUrl is not null)
            {
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

                return await client.SendFlurlRequestAsJsonAsync<Models.CVOCRBankCardResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: "image.png", fileBytes: request.ImageFileBytes, fileContentType: "image/png", formDataName: "img");
                return await client.SendFlurlRequestAsync<Models.CVOCRBankCardResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// <para>异步调用 [POST] /cv/ocr/driving 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/openpoc/ocr/api_drivingocr.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/openpoc/ocr/api_drivingocr.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/img-ocr/ocr/api_drivingocr.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cv", "ocr", "driving")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.ImageMode);

            if (request.ImageUrl is not null)
            {
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

                return await client.SendFlurlRequestAsJsonAsync<Models.CVOCRDrivingResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: "image.png", fileBytes: request.ImageFileBytes, fileContentType: "image/png", formDataName: "img");
                return await client.SendFlurlRequestAsync<Models.CVOCRDrivingResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// <para>异步调用 [POST] /cv/ocr/drivinglicense 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/openpoc/ocr/api_drivingocr.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/openpoc/ocr/api_drivingocr.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/img-ocr/ocr/api_drivinglicenseocr.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cv", "ocr", "drivinglicense")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.ImageMode);

            if (request.ImageUrl is not null)
            {
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

                return await client.SendFlurlRequestAsJsonAsync<Models.CVOCRDrivingLicenseResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: "image.png", fileBytes: request.ImageFileBytes, fileContentType: "image/png", formDataName: "img");
                return await client.SendFlurlRequestAsync<Models.CVOCRDrivingLicenseResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// <para>异步调用 [POST] /cv/ocr/bizlicense 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/openpoc/ocr/api_bizlicenseocr.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/openpoc/ocr/api_bizlicenseocr.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/miniprogram/dev/server/API/img-ocr/ocr/api_bizlicenseocr.html ]]>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cv", "ocr", "bizlicense")
                .SetQueryParam("access_token", request.AccessToken)
                .SetQueryParam("type", request.ImageMode);

            if (request.ImageUrl is not null)
            {
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

                return await client.SendFlurlRequestAsJsonAsync<Models.CVOCRBusinessLicenseResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: "image.png", fileBytes: request.ImageFileBytes, fileContentType: "image/png", formDataName: "img");
                return await client.SendFlurlRequestAsync<Models.CVOCRBusinessLicenseResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// <para>异步调用 [POST] /cv/ocr/platenum 接口。</para>
        /// <para>
        /// REF: <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/subscription/api/openpoc/ocr/api_platenumocr.html ]]> <br/>
        /// <![CDATA[ https://developers.weixin.qq.com/doc/service/api/openpoc/ocr/api_platenumocr.html ]]> <br/>
        /// </para>
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
                .CreateFlurlRequest(request, HttpMethod.Post, "cv", "ocr", "platenum")
                .SetQueryParam("access_token", request.AccessToken);

            if (request.ImageUrl is not null)
            {
                flurlReq.SetQueryParam("img_url", request.ImageUrl);

                return await client.SendFlurlRequestAsJsonAsync<Models.CVOCRPlateNumberResponse>(flurlReq, data: request, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                using var httpContent = Utilities.HttpContentBuilder.BuildWithFile(fileName: "image.png", fileBytes: request.ImageFileBytes, fileContentType: "image/png", formDataName: "img");
                return await client.SendFlurlRequestAsync<Models.CVOCRPlateNumberResponse>(flurlReq, httpContent: httpContent, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }
        #endregion
    }
}
