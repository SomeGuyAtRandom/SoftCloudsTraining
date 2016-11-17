using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using api.Models;
using api.DAL;

namespace api.Controllers
{
    public class SoftCloudsController : Controller
    {

		private ISampleDB sampleDB;

		public SoftCloudsController()
		{
			this.sampleDB = new SampleDB();
		}

		[HttpPost]
		[ActionName("Candidate")]
		public JsonResult Post([Bind (Include = "name,yearsOfExperience,developer,qa,phone,resumeId")]Candidate candidate)
		{
			try{
				this.sampleDB.Insert (candidate);
				Response.StatusCode = 201;
				Response.Headers.Add("Location", "http://localhost/softclouds/candidate/" + candidate.id);
			}
			catch(Exception ex){
			}

			return Json("", JsonRequestBehavior.AllowGet);
		}

		[HttpGet]
		[ActionName("Candidate")]
		public JsonResult Get(int id)
		{
			Candidate candidate = this.sampleDB.GetByID (id);
			return Json(candidate, JsonRequestBehavior.AllowGet);
		}



		[HttpDelete]
		[ActionName("Candidate")]
		public JsonResult Delete(int id)
		{
			try{
				this.sampleDB.Delete (id);
				Response.StatusCode = 200;
			} catch(Exception ex){
			}

			return Json("", JsonRequestBehavior.AllowGet);
		}

		[HttpPut]
		[ActionName("Candidate")]
		public JsonResult Put([Bind (Include = "name,yearsOfExperience,developer,qa,phone,resumeId")]Candidate candidate)
		{
			try{
				this.sampleDB.Update (candidate);
				Response.StatusCode = 200;
			}
			catch(Exception ex){
			}

			return Json("", JsonRequestBehavior.AllowGet);
		}



		public ActionResult TestViewer()
		{
			Candidate candidate = new Candidate(){ };

			return View (candidate);
		}

		[HttpGet]
		[ActionName("Index")]
		public ActionResult Index()
		{
			return View ();
		}


    }
}
