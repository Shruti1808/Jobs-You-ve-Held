using System.Collections.Generic;

namespace Jobs.Objects
{
  public class Job
  {
    private string _jobTitle;
    private string _jobDescription;
    private string _timePeriod;
    private static List<Job> _jobDetails = new List<Job> {};

    public Job (string jobTitle, string jobDescription, string timePeriod)
    {
      _jobTitle = jobTitle;
      _jobDescription = jobDescription;
      _timePeriod = timePeriod;
    }
    public string GetjobTitle()
    {
      return _jobTitle;
    }
    public void SetjobTitle(string newjobTitle)
    {
      _jobTitle = newjobTitle;
    }
    public string GetjobDescription()
    {
      return _jobDescription;
    }
    public void SetjobDescription(string newjobDescription)
    {
      _jobDescription = newjobDescription;
    }
    public string GettimePeriod()
    {
      return _timePeriod;
    }
    public void SettimePeriod(string newtimePeriod)
    {
      _timePeriod = newtimePeriod;
    }
    public static List<Job> GetAll()
    {
      return _jobDetails;
    }
    public void Save()
    {
      _jobDetails.Add(this);
    }
    public static void ClearAll()
{
  _jobDetails.Clear();
}
  }
}
