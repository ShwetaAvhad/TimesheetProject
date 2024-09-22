using Microsoft.AspNetCore.Mvc;
using TimesheetProject.Model;

namespace TimesheetProject.Repository
{
    public interface IActivityRepository
    {
        public void Add(Activity activity);
        public void Add(int id, [FromBody] Activity activity);
        public List<Activity> DisplayA();
        public Activity Find(int id);
        public void Delete(int id);
        public void Update( Activity activity);

        //methods for dropdown
        public void Add(Project project);
        public List<Project> DisplayP();
        public void Add(SubProject subProject);
        public List<SubProject> DisplayS();
        public void Add(Batch batch);
        public List<Batch> DisplayB();
    }
}
