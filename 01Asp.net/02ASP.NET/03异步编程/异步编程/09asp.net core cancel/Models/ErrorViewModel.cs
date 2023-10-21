using System;

namespace _09asp.net_core_cancel.Models {
    public class ErrorViewModel {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}