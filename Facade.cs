using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study
{
    //Referencia: https://www.c-sharpcorner.com/uploadfile/sukeshmarla/learn-design-pattern-facade-pattern/
    //acessado em: 24/5/2019
    class Facade
    {
        public static void  Main(string[] args)
        {
            Customer c = new Customer();

            LoanFascade objLoanFascade = new LoanFascade();

            if (objLoanFascade.doApplicableForLoan(c))

            {

                Console.WriteLine("Loan Approved");

            }

            else

            {

                Console.WriteLine("Loan Rejected");

            }
        }
    }
    public class Customer { }
    public class AddressVerifier { public bool HasProperAddress(Customer c) { return true; } }//just for testing, not working properly tho }
    public class FinanceVerifier { public bool HasGoodSalary(Customer c) { return true; } public bool HaveAnyOtherLoan(Customer c) { return true; } }//just for testing, not working properly tho 
    public class LoanFascade

    {

        public bool doApplicableForLoan(Customer c)

        {

            AddressVerifier objAddressVerifier = new AddressVerifier();

            bool isAddressVerified = objAddressVerifier.HasProperAddress(c);



            FinanceVerifier objFinanceVerifier = new FinanceVerifier();

            bool hasGoodSalary = objFinanceVerifier.HasGoodSalary(c);

            bool hasAnyOtherLoan = objFinanceVerifier.HaveAnyOtherLoan(c);



            return (isAddressVerified && hasGoodSalary && !hasAnyOtherLoan);

        }



    }

}
