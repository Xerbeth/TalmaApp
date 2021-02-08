using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Domain.Common.DataTransferObject
{
    public class TransactionDto<T>
    {
        public Status Status { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public TransactionDto()
        {
            Message = String.Empty;
            Status = Status.Failure;
        }
    }

    public enum Status
    {
        Failure,
        Success
    }
}
