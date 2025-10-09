using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;

namespace MyApp.Application.Commands
{
    public record AddEmployeeCommand(EmployeeEntity Employee): IRequest<EmployeeEntity>;

    public class AddEmployeeCommandHandler(IEmployeeReository employeeReository)
        : IRequestHandler<AddEmployeeCommand, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {
            return await employeeReository.AddEmployeeAsync(request.Employee);
        }
    }
}
