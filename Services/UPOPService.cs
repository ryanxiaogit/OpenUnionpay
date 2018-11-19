using Infrastructure.WebClient;
using Microsoft.Extensions.Options;
using CoreServices.ServiceObjects.UPOP;
using System;
using System.Threading.Tasks;
using CoreServices.Settings.Models;
using AutoMapper;

namespace CoreServices
{
    public interface IUOPService
    {
        Task<UPOPSMSSendingResponse> SmsSending(UPOPSMSSendingRequest request);
    }

    public class UPOPService : BaseService
    {
        readonly IWebClientService _webClient = null;
        readonly ServicesSettingOption _serviceSetting = null;

        public UPOPService(IWebClientService webClientService,
            IOptions<ServicesSettingOption> serviceSetting,
            IMapper mapper) : base(mapper)
        {
            _webClient = webClientService;
            _serviceSetting = serviceSetting.Value;
        }

        public async Task<UPOPSMSSendingResponse> SmsSending(UPOPSMSSendingRequest request)
        {
            request = BuildRequest<UPOPSMSSendingRequest, UPOPSMSSendingRequestSetting>(request);
            var response = await _webClient.ExecuteAsync<UPOPSMSSendingResponse>(request, "POST", _serviceSetting.BackTransUrl);

            return response;
        }
    }
}
