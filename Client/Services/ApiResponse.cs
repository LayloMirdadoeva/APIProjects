using Domain.Exceptions;
using System.Net;

namespace Client.Services;
public record ApiResponse
{
    public bool Success { get; set; }   
    public string Error { get; set; }
    public HttpStatusCode? HttpStatusCode { get; set; }

    public static ApiResponse OrderSucces(HttpStatusCode? httpStatusCode = null)
    {
        return new ApiResponse()
        {
            Success = true,
            HttpStatusCode = httpStatusCode
        };
    }

    public static ApiResponse OrderFailed(string error, HttpStatusCode? httpStatusCode = null)
    {
        return new ApiResponse
        {
            Error = error,
            HttpStatusCode = httpStatusCode,
        };
    }

    public static ApiResponse OrderFailed(ErrorResponse error, HttpStatusCode? httpStatusCode = null)
    {
        return new ApiResponse
        {
            Error = string.Join(',', error.Errors.Select(s => s.Message)),
            HttpStatusCode = httpStatusCode,
        };
    }
}

public record ApiResponse<T> : ApiResponse
{
    public T Result { get; set; }
    public static ApiResponse<T> OrderSuccess(T response, HttpStatusCode? httpStatusCode = null)
    {
        return new ApiResponse<T>
        {
            Success = true,
            Result = response,
            HttpStatusCode = httpStatusCode
        };
    }

    public static new ApiResponse<T> OrderFailed(string error, HttpStatusCode? httpStatusCode = null)
    {
        return new ApiResponse<T>
        {
            Error = error,
            HttpStatusCode = httpStatusCode,
        };
    }
    
    public static ApiResponse<T> OrderFailed(T response, HttpStatusCode? httpStatusCode = null)
    {
        return new ApiResponse<T>
        {
            HttpStatusCode = httpStatusCode,
            Result = response
        };
    }

    public new static ApiResponse<T> OrderFailed(ErrorResponse error, HttpStatusCode? httpStatusCode = null)
    {
        return new ApiResponse<T>
        {
            Error = string.Join(',', error.Errors.Select(s => s.Message)),
            HttpStatusCode = httpStatusCode,
        };
    }
}
