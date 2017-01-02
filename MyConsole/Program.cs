using System;
using System.Collections.Generic;
using System.Linq;
using MyConsole.DbContext;

namespace MyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            employees db = new employees();
            List<employee> emp = db.employee.Where(p => p.cDept_code == "11").ToList();
            foreach (var row in emp)
            {
                Console.WriteLine(row.cName + " " + (row.dOut_date == null ? "" : Convert.ToDateTime(row.dOut_date).ToString("yyyy-MM-dd")));
            }

            var tmp = from a in db.employee
                      join b in db.per_dept
                      on a.cDept_code equals b.cDept_code
                      where a.cDept_code == "11"
                      group a by a.cDept_code into n
                      select new { a = n.Key, b = n.Count() };

            //Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd"));

            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
