using System;
using System.Threading.Tasks;

namespace AutofacInterceptor.Services
{
    public class BranchQuery : IBranchQuery
    {
        public Task<BranchDto> Get(long id)
        {
            //get data from Db
            var result = new BranchDto{Id = id, Name = Guid.NewGuid().ToString()};
            return Task.FromResult(result);
        }
    }
}