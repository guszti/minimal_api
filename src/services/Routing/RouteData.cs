namespace DemoAPI.services.Routing;

public enum HttpMethod
{
    GET,
    POST,
    PUT,
    DELETE
}

public class RouteData(string path, HttpMethod method, Func<Task> callBack)
{
    public string Path { get; set; } = path;

    public HttpMethod Method { get; set; } = method;

    public Func<Task> CallBack { get; set; } = callBack;
}