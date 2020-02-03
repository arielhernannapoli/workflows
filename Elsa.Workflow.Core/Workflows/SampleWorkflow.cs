using Elsa.Activities.Http.Activities;
using Elsa.Services;
using Elsa.Services.Models;
using Elsa.Workflow.Core.Workflows.Activities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Elsa.Workflow.Core.Workflows
{
    public class SampleWorkflow : IWorkflow
    {
        public void Build(IWorkflowBuilder builder)
        {
            builder.StartWith<SampleActivity>();
        }
    }
}
