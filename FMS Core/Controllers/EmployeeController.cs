using FMS_Core.Models.EFModels;
using GraphQL.Client;
using GraphQL.Common.Request;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FMS_Core.Controllers
{
    //[Route("Employee")]
    //public class EmployeeController : Controller
    //{
    //    [HttpGet]
    //    public async Task<List<Employee>> Get()
    //    {
    //        using (GraphQLClient graphQLClient = new GraphQLClient("https://localhost:44303/graphql"))
    //        {
    //            var query = new GraphQLRequest
    //            {
    //                Query = @"
    //                    { employees
    //                        { name email }
    //                    }",
    //            };
    //            var response = await graphQLClient.PostAsync(query);
    //            return response.GetDataFieldAs<List<Employee>>("employees");
    //        }
    //    }
    //}
}