using System;

namespace FluentValidation_Net_5
{
	class Program
	{
		static void Main(string[] args)
		{
			Person person = new();
			var validator = new PersonValidator();
			var results = validator.Validate(person);

			if (!results.IsValid)
			{
				foreach (var failure in results.Errors)
				{
					Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
				}
			}

			string allMessages = results.ToString('~'.ToString());
			Console.WriteLine(allMessages);

			Console.WriteLine("Hello World!");
			Console.ReadKey();
		}
	}
}
