using Models.Untappd.Core;
using System;
using System.Collections.Generic;

namespace Models.Untappd.Responses
{
    public class BaseResponse<T>
    {
        public Meta meta { get; set; }
        public List<string> notifications;
        public T response { get; set; }

        public bool WasSuccessful()
        {
            return meta?.code == 200;
        }

        public string GetErrorMessage()
        {
            if (!WasSuccessful())
            {
                return meta.developer_friendly
                    ?? meta.error_detail
                    ?? "No error message specified";
            }

            else
            {
                throw new InvalidOperationException(
                    $"Calling {nameof(GetErrorMessage)} when call was successful.");
            }
        }
    }
}
