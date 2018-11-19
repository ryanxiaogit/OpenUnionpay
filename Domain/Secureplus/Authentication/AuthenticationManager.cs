using CoreServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Authentication
{
    public class AuthenticationManager
    {
        readonly IUOPService _service = null;

        public AuthenticationManager(IUOPService service)
        {
            _service = service;
        }


        public async Task SendSmsCode()
        {
            await _service.SmsSending(null);
        }

        public async Task<AuthenticationResponse> ProcessAuthentication(AuthenticationRequest request)
        {
            await Task.Yield();
            return null;
        }
    }
}
