using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study
{
    //referencia: https://raphaelcardoso.com.br/observer/
    //acessado em 24/5/2019
    class Observer
    {
    }
    public abstract class Stock
    {
        private string m_symbol;
        private double m_price;
        private List<IInvestor> m_investors = new List<IInvestor>();

        public Stock(string symbol, double price)
        {
            this.m_symbol = symbol;
            this.m_price = price;
        }

        public void Attach(IInvestor investor)
        {
            m_investors.Add(investor);
        }

        public void Detach(IInvestor investor)
        {
            m_investors.Remove(investor);
        }

        public void Notify()
        {
            foreach (IInvestor investor in m_investors)
                investor.Update(this);
        }

        public double Price
        {
            get { return m_price; }
            set
            {
                if (m_price != value)
                {
                    m_price = value;
                    Notify();
                }
            }
        }

        public string Symbol
        {
            get { return m_symbol; }
        }
    }
    public class IBM : Stock
    {
        public IBM(string symbol, double price) : base(symbol, price)
        {
        }
    }
    public interface IInvestor
    {
        void Update(Stock stock);
    }
    public class Investor : IInvestor
    {
        private string m_name;
        private Stock m_stock;

        public Investor(string name)
        {
            this.m_name = name;
        }

        public void Update(Stock stock)
        {
            /*MessageBox.Show("Notificação: (" + m_name + ") de " +
                             stock.Symbol + ".O preço foi alterado para " +
                             stock.Price.ToString("0.00"));*/
        }

        public Stock Stock
        {
            get { return m_stock; }
            set { m_stock = value; }
        }
    }
    /*private void Form1_Load(object sender, EventArgs e)
    {
        IBM ibm = new IBM("IBM", 100.00);
        ibm.Attach(new Investor("Acionista A"));
        ibm.Attach(new Investor("Acionista B"));
        /* depois de ter realizado o Attach, 
           a cada vez que atribuir um novo preço para ibm,
           cada um dos investidores será notificado.
         */
        /*ibm.Price = 200.10;
        ibm.Price = 500.00;

        this.Close();
    }*/

}
