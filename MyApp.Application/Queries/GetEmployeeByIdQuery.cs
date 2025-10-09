﻿using MediatR;
using MyApp.Core.Entities;
using MyApp.Core.Interfaces;

namespace MyApp.Application.Queries
{
    public record GetEmployeeByIdQuery(Guid employeeId): IRequest<EmployeeEntity>;

    public class GetEmployeeByIdQueryHandler(IEmployeeReository employeeReository)
        : IRequestHandler<GetEmployeeByIdQuery, EmployeeEntity>
    {
        public async Task<EmployeeEntity> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            return await employeeReository.GetEmployeeByIdAsync(request.employeeId);
        }
    }
}
