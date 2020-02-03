using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Elsa.Services;
using Elsa.Workflow.Core.Workflows;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Elsa.Workflow.Core.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SampleController : Controller
    {
        private readonly ILogger<SampleController> _logger;
        private readonly IWorkflowInvoker _invoker;

        public SampleController(ILogger<SampleController> logger, IWorkflowInvoker invoker)
        {
            _logger = logger;
            _invoker = invoker;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            var workflow = await _invoker.StartAsync<SampleWorkflow>();
            return workflow.Workflow.Id;
        }
    }
}
