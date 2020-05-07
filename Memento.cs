using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study
{
    //referencia: https://www.dofactory.com/net/memento-design-pattern
    //acessado em 24/5/2019

    class Memento
    {
        public static void Main(string[] args)
        {
            SalesProspect s = new SalesProspect();
            s.Name = "Noel van Halen";
            s.Phone = "(412) 256-0990";
            s.Budget = 25000.0;

            // Store internal state

            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();

            // Continue changing originator

            s.Name = "Leo Welch";
            s.Phone = "(310) 209-7111";
            s.Budget = 1000000.0;

            // Restore saved state

            s.RestoreMemento(m.Memento);

            // Wait for user

            Console.ReadKey();
        }
    }

    /// <summary>

    /// The 'Originator' class

    /// </summary>

    class SalesProspect

    {
        private string _name;
        private string _phone;
        private double _budget;

        // Gets or sets name

        public string Name
        {
            get { return _name; }
            set

            {
                _name = value;
                Console.WriteLine("Name:  " + _name);
            }
        }

        // Gets or sets phone

        public string Phone
        {
            get { return _phone; }
            set

            {
                _phone = value;
                Console.WriteLine("Phone: " + _phone);
            }
        }

        // Gets or sets budget

        public double Budget
        {
            get { return _budget; }
            set

            {
                _budget = value;
                Console.WriteLine("Budget: " + _budget);
            }
        }

        // Stores memento

        public Memento2 SaveMemento()
        {
            Console.WriteLine("\nSaving state --\n");
            return new Memento2(_name, _phone, _budget);
        }

        // Restores memento

        public void RestoreMemento(Memento2 memento)
        {
            Console.WriteLine("\nRestoring state --\n");
            this.Name = memento.Name;
            this.Phone = memento.Phone;
            this.Budget = memento.Budget;
        }
    }

    /// <summary>

    /// The 'Memento' class

    /// </summary>

    class Memento2

    {
        private string _name;
        private string _phone;
        private double _budget;

        // Constructor

        public Memento2(string name, string phone, double budget)
        {
            this._name = name;
            this._phone = phone;
            this._budget = budget;
        }

        // Gets or sets name

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        // Gets or set phone

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        // Gets or sets budget

        public double Budget
        {
            get { return _budget; }
            set { _budget = value; }
        }
    }

    /// <summary>

    /// The 'Caretaker' class

    /// </summary>

    class ProspectMemory

    {
        private Memento2 _memento;

        // Property

        public Memento2 Memento
        {
            set { _memento = value; }
            get { return _memento; }
        }
    }


}
