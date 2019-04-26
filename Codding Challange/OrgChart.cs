using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;

namespace Codding_Challange
{
    public class OrgChart
    {
        Dictionary<string, string> Employee = new Dictionary<string, string>();// id name
        Dictionary<string, string> EmployeeManager = new Dictionary<string, string>();//emp , mang
        List<string> managers = new List<string>();
        public void Add(string id, string name, string managerId)
        {
            if (!Employee.ContainsKey(id))
            {
                
                Employee.Add(id, name);
                EmployeeManager.Add(id, "-1");
            }
            if (EmployeeManager.ContainsKey(id) && managerId != "-1")
            {
                EmployeeManager[id] = managerId;
            }
            if (!managers.Contains(managerId) && managerId != "-1")
            {
                managers.Add(managerId);
            }
        }

        public void Print()
        {
            foreach(var item in EmployeeManager)
           PrintRecursion(item,0);
            
        }
        public void PrintRecursion(KeyValuePair<string,string> emp, int space)
        {
            var result = new StringBuilder();
            var temp = Employee;
            
            if(emp.Value == "-1" && temp.ContainsKey(emp.Key))
            {
                result.Append(temp[emp.Key]);
                result.Append(" ");
                result.Append("[");
                result.Append(emp.Key);
                result.Append("]");

                Console.WriteLine(result.ToString().PadLeft(space));
                temp.Remove(emp.Key);
                var next = EmployeeManager.Where(x => x.Value == emp.Key).ToDictionary(x => x.Key, x =>x.Value);
                if (!next.Equals(default(KeyValuePair<string, string>)))
                {
                    foreach(var i in next)
                    PrintRecursion(i, space + 2);

                }
                else
                {
                    return;
                }
                
            }
            else if(temp.ContainsKey(emp.Key))
            {
                result.Append(new string(' ', space));
                result.Append(temp[emp.Key]);
                result.Append(" ");
                result.Append("[");
                result.Append(emp.Key);
                result.Append("]");

                Console.WriteLine(result.ToString());
                temp.Remove(emp.Key);
                var next = EmployeeManager.Where(x => x.Value == emp.Key).ToDictionary(x => x.Key, x => x.Value);
                if (!next.Equals(default(KeyValuePair<string, string>)))
                {
                    foreach (var i in next)
                        PrintRecursion(i, space + 2);

                }
            }
           
        }
        public void Remove(string employeeId)
        {
            if (Employee.ContainsKey(employeeId))
            {
                Employee.Remove(employeeId);
            }
            if (EmployeeManager.ContainsKey(employeeId))
            {
                var reportingmanager = EmployeeManager[employeeId];
                var list = EmployeeManager.Where(X => X.Value == employeeId).ToDictionary(x => x.Key, x => x.Value);
                foreach(var i in list)
                {
                    EmployeeManager[i.Key] = reportingmanager;
                }
                EmployeeManager.Remove(employeeId);
            }
        }

        public void Move(string employeeId, string newManagerId)
        {
            if(Employee.ContainsKey(employeeId) && Employee.ContainsKey(newManagerId))
            {
                if (!managers.Contains(newManagerId) && newManagerId != "-1")
                {
                    managers.Add(newManagerId);
                }
                if(EmployeeManager.ContainsKey(employeeId))
                EmployeeManager[employeeId] = newManagerId;
            }
        }

        public int Count(string employeeId)
        {
           return reporteeCount(employeeId,0);
        }
        public int reporteeCount(string managerId, int counter)
        {
            
            if (managers.Contains(managerId))
            {
                counter++;
                var m = EmployeeManager.FirstOrDefault(x => x.Value == managerId).Key;
                return reporteeCount(m,counter);
            }
            return counter;
        }
    }
}
