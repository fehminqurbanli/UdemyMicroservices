using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace FreeCourse.Shared.Dtos
{
    public class ResponseDto<T>
    {
        public T Data { get; set; }
        [JsonIgnore]
        public int StatusCode { get; set; }
        [JsonIgnore]
        public bool IsSuccessFul { get; set; }

        public List<string> Errors { get; set; }

        //static Factory method
        public static ResponseDto<T> Success(T data,int statusCode)
        {
            return new ResponseDto<T> { Data = data, StatusCode = statusCode, IsSuccessFul = true };
        }

        public static ResponseDto<T> Success(int statusCode)
        {
            return new ResponseDto<T> { Data = default(T), StatusCode = statusCode, IsSuccessFul = true };
        }

        public static ResponseDto<T> Fail(List<string> errors, int statusCode)
        {
            return new ResponseDto<T>
            {
                Errors=errors,
                StatusCode = statusCode,
                IsSuccessFul = false
            };
        }

        public static ResponseDto<T> Fail(string error, int statusCode)
        {
            return new ResponseDto<T> { Errors = new List<string>() { error }, StatusCode = statusCode, IsSuccessFul = false };
        }

    }
}
