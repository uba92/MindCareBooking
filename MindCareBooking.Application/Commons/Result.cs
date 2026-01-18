using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindCareBooking.Application.Commons
{
    public class Result
    {
        public bool IsSuccess { get; }
        public string? ErrorCode { get; }
        private Result(bool isSuccess, string? errorCode)
        {
            IsSuccess = isSuccess;
            ErrorCode = errorCode;
        }
        public static Result Ok() => new Result(true, null);
        public static Result Fail(string errorCode) => new Result(false, errorCode);
    }

    public class Result<T> where T : class
    {
        public bool IsSuccess { get; }
        public string? ErrorCode { get; }
        public T? Value { get; }
        public Result(bool isSuccess, string? errorCode, T? value)
        {
            IsSuccess = isSuccess;
            ErrorCode = errorCode;
            Value = value;
        }
        public static Result<T> Ok(T value) => new Result<T>(true, null, value);
        public static Result<T> Fail(string errorCode) => new Result<T>(false, errorCode, null);
    }
}
