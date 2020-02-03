using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WorkflowCore.Interface;

namespace WorkflowCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkflowController : ControllerBase
    {
        private readonly IWorkflowController _workflowController;

        public WorkflowController(IWorkflowController workflowController)
        {
            _workflowController = workflowController;
        }

        // GET api/values
        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            string workflowId = await _workflowController.StartWorkflow("SampleWorkflow", null, null);
            return workflowId;
        }
    }
}
