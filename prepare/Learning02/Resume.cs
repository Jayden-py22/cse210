class Resume
{
    private List<Job> _jobs;
    private string _name;

    public Resume(string name)
    {
        _name = name;
        _jobs = new List<Job>();
    }

    public void AddJob(Job job)
    {
        _jobs.Add(job);
    }

    public void DisplayResume()
    {
        Console.WriteLine($"{_name} resume:  List of jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJob();
        }
    }

}