using System;
using api.Models;
using System.Collections.Generic;

namespace api.DAL
{
	public class SampleDB: ISampleDB, IDisposable
	{
		static public List<Candidate> candidates;
		public SampleDB ()

		{
			candidates = new List<Candidate>();
			candidates.Add ( new Candidate(){ id= 1, name="One", yearsOfExperience = 10 });
			candidates.Add ( new Candidate(){ id= 2, name="Two", yearsOfExperience = 20 });
			candidates.Add ( new Candidate(){ id= 3, name="Three", yearsOfExperience = 30 });
			candidates.Add ( new Candidate(){ id= 4, name="Four", yearsOfExperience = 40 });
		}

		public IEnumerable<Candidate> GetAll()
		{
			return candidates;
		}
		public Candidate GetByID(int id)
		{
			foreach(Candidate c in candidates)
			{
				if (id == c.id) {
					return c;
				}
			}
			return null;
		}
		public void Insert(Candidate candidate){}
		public void Delete(int id){}
		public void Update(Candidate candidate){}
		public void Save(){} 
		public void Dispose(){}

	}
}

