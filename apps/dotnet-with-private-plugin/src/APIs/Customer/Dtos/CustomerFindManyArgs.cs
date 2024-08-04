using DotnetWithPrivatePlugin.APIs.Common;
using DotnetWithPrivatePlugin.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetWithPrivatePlugin.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class CustomerFindManyArgs : FindManyInput<Customer, CustomerWhereInput> { }
