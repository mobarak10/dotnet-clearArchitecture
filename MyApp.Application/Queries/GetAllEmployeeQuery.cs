using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;

namespace MyApp.Application.Queries
{
    public record GetAllEmployeeQuery(): IRequest<IEnumerable<EmployeeEntity>>;

    public class GetAllEmployeeQueryHandler(IEmployeeReository employeeRepository)
        : IRequestHandler<GetAllEmployeeQuery, IEnumerable<EmployeeEntity>>
    {
        public async Task<IEnumerable<EmployeeEntity>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            return await employeeRepository.GetEmployees();
        }
    }
}
