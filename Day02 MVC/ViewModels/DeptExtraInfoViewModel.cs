using Day02_MVC.Models;

namespace Day02_MVC.ViewModels
{
    public class DeptExtraInfoViewModel
    {
        public string DeptName { get; set; }
        public List<Student> StudentsInDeptByAge { get; set; }
        public string DeptState { get; set; }
    }
}
