using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Employee
    {
        public int Id { get; set;}
        public string Name { get; set; }
        public string Address { get; set; }
        private List<Employee> elist;
        
        public Employee()
        {
           
           
        }
        public void InitializeEmployees()
        {
            elist = new List<Employee>();
            elist.Add(new Employee() { Id = 122, Name = "ABC", Address = "NY" });
            elist.Add(new Employee() { Id = 123, Name = "DEF", Address = "NY" });
            elist.Add(new Employee() { Id = 124, Name = "GHE", Address = "NY" });
        }
        public List<Employee> GetEmployees()
        {
            
            return elist; //returns data back
        }
        public void DeleteEmp(int eid)
        {
            //logic
        }
        
        public void AddEmp(Employee obj) //send emp you want to add
        {
            elist.Add(obj);
            
        }
    }
}
