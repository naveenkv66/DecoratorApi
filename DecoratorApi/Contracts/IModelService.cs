using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorApi.Contracts
{
    public interface IModelService<TRequest,TResponse>
    {
        TResponse Process();
    }
}
