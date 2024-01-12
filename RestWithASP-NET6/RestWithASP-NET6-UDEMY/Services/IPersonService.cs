using System;
using RestWithASP_NET6_UDEMY.Models;

namespace RestWithASP_NET6_UDEMY.Services;

	public interface IPersonService
	{
		Person Create(Person person);
		Person FindById(long id);
		List<Person> FindAll();
		Person Update(Person person);
		void Delete(long id);

	}