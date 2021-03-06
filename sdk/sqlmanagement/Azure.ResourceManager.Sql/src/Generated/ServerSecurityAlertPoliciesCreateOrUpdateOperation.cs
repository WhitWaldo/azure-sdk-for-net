// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> Creates or updates a threat detection policy. </summary>
    public partial class ServerSecurityAlertPoliciesCreateOrUpdateOperation : Operation<ServerSecurityAlertPolicy>, IOperationSource<ServerSecurityAlertPolicy>
    {
        private readonly ArmOperationHelpers<ServerSecurityAlertPolicy> _operation;
        internal ServerSecurityAlertPoliciesCreateOrUpdateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<ServerSecurityAlertPolicy>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ServerSecurityAlertPoliciesCreateOrUpdateOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ServerSecurityAlertPolicy Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ServerSecurityAlertPolicy>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ServerSecurityAlertPolicy>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ServerSecurityAlertPolicy IOperationSource<ServerSecurityAlertPolicy>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return ServerSecurityAlertPolicy.DeserializeServerSecurityAlertPolicy(document.RootElement);
        }

        async ValueTask<ServerSecurityAlertPolicy> IOperationSource<ServerSecurityAlertPolicy>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return ServerSecurityAlertPolicy.DeserializeServerSecurityAlertPolicy(document.RootElement);
        }
    }
}
