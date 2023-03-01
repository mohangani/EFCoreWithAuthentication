using Newtonsoft.Json;
using System;

namespace EFCoreApi.Models.OutputModels
{
    public class ExceptionModel
    {
        public int Status { get; set; }
        public string ExceptionMessage { get; set; }
        public Exception InnerExceptionMessage { get; set; }
        public string ExceptionType { get; set; }
        public string StackTrace { get; set; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
