namespace DecoratorApi
{
    public interface IRequestHandler<TRequest,TResponse>
    {
         TResponse Handle(TRequest request);
    }
}