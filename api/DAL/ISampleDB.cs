using System;
using api.Models;
using System.Collections.Generic;

namespace api.DAL
{
	public interface ISampleDB : IDisposable
	{
		IEnumerable<Candidate> GetAll();
		Candidate GetByID(int id);
		void Insert(Candidate candidate);
		void Delete(int id);
		void Update(Candidate candidate);
		void Save();
	}
}

