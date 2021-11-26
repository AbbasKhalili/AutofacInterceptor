using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using AutofacInterceptor.Services;

namespace AutofacInterceptor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BranchController : ControllerBase
    {
        private readonly IBranchQuery _query;

        public BranchController(IBranchQuery query)
        {
            _query = query;
        }

        [HttpGet("{id:long}")]
        public Task<BranchDto> Get(long id)
        {
            return _query.Get(id);
        }
    }
}
