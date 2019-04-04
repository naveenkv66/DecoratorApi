using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DecoratorApi.Contracts
{
    public interface IValidator<Trequest,Trsponse>
    {
        void Validate(Trequest request);
    }
}
