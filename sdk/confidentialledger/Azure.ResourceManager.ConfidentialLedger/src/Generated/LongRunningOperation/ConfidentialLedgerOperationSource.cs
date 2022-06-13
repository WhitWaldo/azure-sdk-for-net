// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.ConfidentialLedger
{
    internal class ConfidentialLedgerOperationSource : IOperationSource<ConfidentialLedgerResource>
    {
        private readonly ArmClient _client;

        internal ConfidentialLedgerOperationSource(ArmClient client)
        {
            _client = client;
        }

        ConfidentialLedgerResource IOperationSource<ConfidentialLedgerResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ConfidentialLedgerData.DeserializeConfidentialLedgerData(document.RootElement);
            return new ConfidentialLedgerResource(_client, data);
        }

        async ValueTask<ConfidentialLedgerResource> IOperationSource<ConfidentialLedgerResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ConfidentialLedgerData.DeserializeConfidentialLedgerData(document.RootElement);
            return new ConfidentialLedgerResource(_client, data);
        }
    }
}
