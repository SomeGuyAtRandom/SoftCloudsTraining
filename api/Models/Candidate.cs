﻿using System;

namespace api.Models
{
	public class Candidate
	{
		public Candidate ()
		{
		}
		// TODO: convert to GUID

		public int id { get; set;}
		public string name { get; set;}
		public int yearsOfExperience { get; set;}
		public bool developer { get; set;}
		public bool qa { get; set;}
		public string phone { get; set;} //TODO: Mask entry and/or validate
		public int resumeId { get; set;}


	}
}

