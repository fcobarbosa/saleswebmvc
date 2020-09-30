using System;

namespace SalesWebMVC.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public string Messge { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}