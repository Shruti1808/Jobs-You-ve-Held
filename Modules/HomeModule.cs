using Nancy;
using Jobs.Objects;
using System.Collections.Generic;

namespace Jobs
{
  public class HomeModule : NancyModule
  {
     public HomeModule()
     {
       Get["/"]= _ => View["add_jobs.cshtml"];

       Get["/view_jobs"] = _ => {
         List<Job> allJobs = Job.GetAll();
         return View["view_jobs.cshtml", allJobs];
       };

       Post["/add_jobs"] = _ => {
        Job newJob = new Job (Request.Form["new-job"], Request.Form["description"], Request.Form["time"]);
        newJob.Save();
        return View["view_jobs.cshtml", Job.GetAll()];
      };
      Post["/jobs_cleared"] = _ => {
          Job.ClearAll();
          return View["jobs_cleared.cshtml"];
        };
     }
  }
}
