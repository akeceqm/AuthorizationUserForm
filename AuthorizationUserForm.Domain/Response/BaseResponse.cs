using AuthorizationUserForm.Domain.Enum;
using Microsoft.AspNetCore.Http;

namespace AuthorizationUserForm.Domain.Response;

public class BaseResponse<T>:IBaseResponse<T>
{
    public string Description { get; set; }
    public StatusCode StatusCode { get; init; }
    public T Data { get; }
}

public interface IBaseResponse<T>
{
    string Description { get; }
    StatusCode StatusCode { get; }
    T Data { get; }
}