using System;

namespace Integrating_Azure_AD_into_an_ASP.NET_Core_web_app.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}