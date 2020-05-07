using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study
{

    //referencia: https://www.dofactory.com/net/template-method-design-pattern
    // acessado em 24/5/2019
    class TemplateMethod
    {
        public static void Main(string[] args)
        {
            /*DataAccessObject daoCategories = new Categories();
              daoCategories.Run();
 
              DataAccessObject daoProducts = new Products();
              daoProducts.Run();
 
              // Wait for user

              Console.ReadKey();*/
        }
    }
    /*
    /// <summary>

    /// The 'AbstractClass' abstract class

    /// </summary>
    public class DataSet { }
    abstract class DataAccessObject

    {
        protected string connectionString;
        protected DataSet dataSet;

        public virtual void Connect()
        {
            // Make sure mdb is available to app

            connectionString =
              "provider=Microsoft.JET.OLEDB.4.0; " +
              "data source=..\\..\\..\\db1.mdb";
        }

        public abstract void Select();
        public abstract void Process();

        public virtual void Disconnect()
        {
            connectionString = "";
        }

        // The 'Template Method' 

        public void Run()
        {
            Connect();
            Select();
            Process();
            Disconnect();
        }
    }

    /// <summary>

    /// A 'ConcreteClass' class

    /// </summary>
    public class OleDbDataAdapter { void OleDbDataAdapter(string s, string path) { } }
    class Categories : DataAccessObject

    {
        public override void Select()
        {
            string sql = "select CategoryName from Categories";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(
              sql, connectionString);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Categories");
        }

        public override void Process()
        {
            Console.WriteLine("Categories ---- ");

            DataTable dataTable = dataSet.Tables["Categories"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["CategoryName"]);
            }
            Console.WriteLine();
        }
    }

    /// <summary>

    /// A 'ConcreteClass' class

    /// </summary>

    class Products : DataAccessObject

    {
        public override void Select()
        {
            string sql = "select ProductName from Products";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(
              sql, connectionString);

            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Products");
        }

        public override void Process()
        {
            Console.WriteLine("Products ---- ");
            DataTable dataTable = dataSet.Tables["Products"];
            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["ProductName"]);
            }
            Console.WriteLine();
        }
    }*/

}
