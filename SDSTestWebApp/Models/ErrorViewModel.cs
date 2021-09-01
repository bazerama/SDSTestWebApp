using System;

namespace SDSTestWebApp.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        // some change

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}