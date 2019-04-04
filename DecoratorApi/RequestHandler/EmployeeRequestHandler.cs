using DecoratorApi.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DecoratorApi.Model;

namespace DecoratorApi.RequestHandler
{
    public class EmployeeRequestHandler : IRequestHandler<EmployeeRequest, EmployeeReponse>
    {
        private readonly IModelService<EmployeeRequest, EmployeeReponse> modelService;
        public EmployeeRequestHandler(IModelService<EmployeeRequest, EmployeeReponse> modelService)
        {
            this.modelService = modelService;
        }
        

        public EmployeeReponse Handle(EmployeeRequest request)
        {
           var empResponse = modelService.Process(request);
           return empResponse;
        }
    }
}
