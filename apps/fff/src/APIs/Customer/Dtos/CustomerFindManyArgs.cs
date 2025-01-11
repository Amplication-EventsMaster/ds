using Fff.APIs.Common;
using Fff.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fff.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class CustomerFindManyArgs : FindManyInput<Customer, CustomerWhereInput> { }
