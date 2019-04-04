using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecoratorApi.Contracts;
using DecoratorApi.Model;

namespace DecoratorApi.ModelService
{
    public class EmployeeModelService : IModelService<EmployeeRequest, EmployeeReponse>
    {
        public EmployeeReponse Process(EmployeeRequest request)
        {
            return new EmployeeReponse()
            {
                Name= "Naveen"
            };
        }
    }
}
