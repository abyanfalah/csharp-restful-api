namespace crudApi.CommonResponses;

class response
{
	public static Object DataMessage(Object data, string message)
	{
		return new
		{
			data = data,
			message = message,
		};
	}
}
