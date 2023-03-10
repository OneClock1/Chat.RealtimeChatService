using Common.Domain.Enums;
using Realtime.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Realtime.Domain.DTOs
{
    public class ErrorDTO
    {
        public ErrorCode StatusCode { get; set; }
        public string Message { get; set; }

        public ErrorDTO(ErrorCode statusCode, string message)
        {
            StatusCode = statusCode;
            Message = message;
        }
    }
}
