
using crudApi.CommonResponses;
using crudApi.Models;
using crudApi.Service;
using Microsoft.AspNetCore.Mvc;

namespace crudApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
	[HttpGet]
	public ActionResult<List<User>> GetAll() => UserService.GetAll();

	[HttpGet("{id}")]
	public ActionResult<User> GetById(string id)
	{
		var user = UserService.Get(id);
		if (user == null)
			return NotFound();

		return user;
	}

	[HttpPost]
	public Object Create(User user)
	{
		UserService.Add(user);
		// return CreatedAtAction(nameof(Create), user);
		return response.DataMessage(user, "user created");
	}

	[HttpPut("{id}")]
	public Object Update(string id, User user)
	{
		var userFound = UserService.Get(id);
		if (userFound == null)
			return NotFound();

		user.Id = id;
		UserService.Update(user);
		return response.DataMessage(user, "user updated");
	}

	[HttpDelete("{id}")]
	public Object Delete(string id)
	{
		var user = UserService.Get(id);
		if (user == null)
			return NotFound();

		UserService.Delete(id);
		return response.DataMessage(user, "user deleted");
	}
}