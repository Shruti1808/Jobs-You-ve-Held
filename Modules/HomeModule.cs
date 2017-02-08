using Nancy;
using Jobs.Objects;

namespace Jobs
{
  public class HomeModule : NancyModule
  {
     public HomeModule()
     {
       Get["/"]= _ => View["add_jobs.cshtml"];

       Post["/add_jobs"] = _ => {
        Job newJob = new Job (Request.Form["new-job"], Request.Form["description"], Request.Form["time"]);
        newJob.Save();
        return View["view_jobs.cshtml", newJob];
      };
     }
  }
}
