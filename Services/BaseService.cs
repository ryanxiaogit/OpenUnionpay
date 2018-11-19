using AutoMapper;

namespace CoreServices
{
    public class BaseService
    {
        readonly IMapper _mapper = null;

        protected BaseService(IMapper mapper)
        {
            _mapper = mapper;
        }

        protected TRequest BuildRequest<TRequest, TSetting>(TRequest request)
        {
            return request;
        }
    }
}