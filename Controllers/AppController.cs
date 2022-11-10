using crudApi.Models;
using crudApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace crudApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AppController : ControllerBase
{
	[HttpGet]
	public string Hello() => "Hello";
}

