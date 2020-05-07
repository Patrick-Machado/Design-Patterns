using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study
{
    class Adapter
    {
        //Referencia: https://www.c-sharpcorner.com/UploadFile/SukeshMarla/learn-design-pattern-%E2%80%93-adapter-pattern/,
        //acessado em 24/5/2019
    }
    public class G1Consultant { }
    public interface IEmployee { }
    public class G2Consultant { }

        public class G1ConsultantEmployee : G1Consultant, IEmployee
        {
            int GetFinalIncome(int Salary)//just for example its not working properly though
        {
                return Salary;
            }
            public int GetFinalSalary(int Salary)
            {
                return this.GetFinalIncome(Salary);
            }
        }

        public class G2ConsultantEmployee : G2Consultant, IEmployee
        {
            int GetFinalIncome(int Salary)//just for example its not working properly though
            {
                return Salary;
            }
        public int GetFinalSalary(int Salary)
            {
                return this.GetFinalIncome(Salary);
            }
        }
}
