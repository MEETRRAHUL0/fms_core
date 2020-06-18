using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FMS_Core.API;
using GraphQL.Types;

namespace FMS_Core.GraphQL
{
    public class EmployeeQuery : ObjectGraphType
    {
        public EmployeeQuery(IEmployeeRepository employeeRepository)
        {
            Field<ListGraphType<EmployeeType>>(
                "employees",
                resolve: context => employeeRepository.GetEmployees()
            );
        }

        //public EmployeeQuery(IEmployeeRepository employeeRepository)
        //{  
        //    Field<EmployeeType>(
        //        "employee",
        //        arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>>
        //            { Name = "id" }),
        //        resolve: context =>
        //        {
        //            var id = context.GetArgument<int>("id");
        //            return employeeRepository.GetEmployeeById(id);
        //        }
        //    );
        //}
    }
}
