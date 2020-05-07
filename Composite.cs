using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study
{
    //referencia: https://www.c-sharpcorner.com/UploadFile/SukeshMarla/learn-design-pattern-composite-pattern/
    //acessado em 24/5/2019
    class Composite
    {
        public static void Main(string[] args)// com erro em conversão implicita de classe pra interface
        {/*
            IWebControl objRoot = new Panel();

            objRoot.Name = "Panel1";



            IWebControl objChild1 = new Textbox();

            objChild1.Name = "Textbox1.1";

            objRoot.CreateChildControl(objChild1);



            IWebControl objChild2 = new Panel();

            objChild2.Name = "Panel1.1";

            objRoot.CreateChildControl(objChild2);





            IWebControl objChild21 = new Textbox();

            objChild21.Name = "Textbox1.1.1";

            objChild2.CreateChildControl(objChild21);



            IWebControl objChild22 = new Textbox();

            objChild22.Name = "Textbox1.1.2";

            objChild2.CreateChildControl(objChild22);



            IWebControl objChild23 = new Textbox();

            objChild23.Name = "Textbox1.1.3";

            objChild2.CreateChildControl(objChild23);



            objRoot.Render();


            */
        }
    }
    public interface IWebControl

    {

        string Name { get; set; }



        int Width { get; set; }

        int Height { get; set; }



        void Render();



        void CreateChildControl(IWebControl control);

        void DeleteChildControl(IWebControl control);

    }

    public class Textbox

    {

        public string Name { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }



        public void Render()

        {

            Console.WriteLine("Textbox(" + Name + ") Rendered");

        }

    }


    public class Panel : IWebControl

    {

        private List<IWebControl> ChildControls = new List<IWebControl>();



        public string Name { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }



        public void Render()

        {



            Console.WriteLine("Child Control for Panel(" + Name + ")  Render start");

            foreach (IWebControl item in ChildControls)

            {

                item.Render();

            }

            Console.WriteLine("Child Control for Panel(" + Name + ")  Render End");

        }



        public void CreateChildControl(IWebControl control)

        {

            ChildControls.Add(control);

        }



        public void DeleteChildControl(IWebControl control)

        {

            ChildControls.Remove(control);

        }



    }



}
