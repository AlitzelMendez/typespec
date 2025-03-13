// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;

namespace UnbrandedTypeSpec
{
    internal partial class ListWithNextLinkAsyncCollectionResult : AsyncCollectionResult
    {
        private readonly UnbrandedTypeSpecClient _client;
        private readonly Uri _initialUri;
        private readonly RequestOptions _options;

        public ListWithNextLinkAsyncCollectionResult(UnbrandedTypeSpecClient client, Uri initialUri, RequestOptions options)
        {
            _client = client;
            _initialUri = initialUri;
            _options = options;
        }

        public override async IAsyncEnumerable<ClientResult> GetRawPagesAsync()
        {
            PipelineMessage message = _client.CreateListWithNextLinkRequest(_initialUri, _options);
            Uri nextPageUri = null;
            while (true)
            {
                ClientResult result = ClientResult.FromResponse(await _client.Pipeline.ProcessMessageAsync(message, _options).ConfigureAwait(false));
                yield return result;

                nextPageUri = ((ListWithNextLinkResponse)result).Next;
                if (nextPageUri == null)
                {
                    yield break;
                }
                message = _client.CreateListWithNextLinkRequest(nextPageUri, _options);
            }
        }

        public override ContinuationToken GetContinuationToken(ClientResult page)
        {
            Uri nextPageUri = ((ListWithNextLinkResponse)page).Next;
            return ContinuationToken.FromBytes(BinaryData.FromString(nextPageUri.AbsoluteUri));
        }
    }
}
