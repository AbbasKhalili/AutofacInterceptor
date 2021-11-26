using System.Threading.Tasks;

namespace AutofacInterceptor.Services
{
    public class BranchCachingDecorator : IBranchQuery
    {
        private readonly IBranchQuery _query;
        
        public BranchCachingDecorator(IBranchQuery query)
        {
            _query = query;
        }

        public Task<BranchDto> Get(long id)
        {
            //return data from Redis cache if exists
            //else

            return _query.Get(id);
        }
    }
}