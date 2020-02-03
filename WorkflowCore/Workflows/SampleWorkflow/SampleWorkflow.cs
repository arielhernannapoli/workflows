using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Workflow.Core.Workflows.SampleWorkflow.Models;
using Workflow.Core.Workflows.SampleWorkflow.Steps;
using WorkflowCore.Interface;

namespace Workflow.Core.Workflows.SampleWorkflow
{
    public class SampleWorkflow : IWorkflow<SampleWorkflowModel>
    {
        public string Id => "SampleWorkflow";

        public int Version => 1;

        public void Build(IWorkflowBuilder<SampleWorkflowModel> builder)
        {
            builder
                .StartWith<SampleStepOne>()
                .Then<SampleStepTwo>();
        }
    }
}
