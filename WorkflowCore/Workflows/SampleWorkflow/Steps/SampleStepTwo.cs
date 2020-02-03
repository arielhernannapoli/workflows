using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkflowCore.Interface;
using WorkflowCore.Models;

namespace Workflow.Core.Workflows.SampleWorkflow.Steps
{
    public class SampleStepTwo : StepBodyAsync
    {
        public override async Task<ExecutionResult> RunAsync(IStepExecutionContext context)
        {
            return ExecutionResult.Next();
        }
    }
}
