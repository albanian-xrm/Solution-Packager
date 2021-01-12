using Microsoft.Xrm.Sdk.Messages;
using System;

namespace AlbanianXrm.SolutionPackager.Models
{
    internal class ImportSolutionRequest
    {
        public Guid ImportJobId { get; set; }
        public ExecuteAsyncResponse ExecuteAsyncResponse { get; set; }
    }
}
