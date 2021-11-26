using System.Threading.Tasks;

namespace AutofacInterceptor.Services
{
    public interface IBranchQuery
    {
        Task<BranchDto> Get(long id);
    }
}