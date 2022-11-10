using crudApi.Models;

namespace crudApi.Service;

public class UserService
{
	public static List<User> Users { get; }

	public static int nextId = 1236;
	static UserService()
	{
		Users = new List<User>{
			new User { Id = "1234", Name = "Andi", Age = 21 },
			new User { Id = "1235", Name = "Odang", Age = 32 }
		};
	}

	public static List<User> GetAll() => Users;

	public static User? Get(string id) => Users.FirstOrDefault(user => user.Id == id);

	public static void Add(User user)
	{
		var id = Convert.ToString(nextId++);
		user.Id = id;
		Users.Add(user);
	}

	public static void Update(User user)
	{
		var index = Users.FindIndex(u => u.Id == user.Id);
		if (index == -1)
			return;

		Users[index] = user;
	}

	public static void Delete(string id)
	{
		var user = Get(id);
		if (user == null)
			return;

		Users.Remove(user);
	}
}