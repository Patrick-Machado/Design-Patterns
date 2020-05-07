using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study
{
    //referencia: https://www.c-sharpcorner.com/UploadFile/SukeshMarla/learn-design-pattern-%E2%80%93-bridge-pattern/
    //acessado em 24/5/2019

    class Bridge
    {
        public static void Main(string[] args)
        {
            AbstarctPencil objPencil = null; AbstractShape objShape = null;
            objShape = new Circle(); objPencil = new RedPencil(objShape);
            objPencil.DrawWithColor();
        }
    }
    public abstract class AbstractShape
    {
        public abstract void Draw(string strColor);
    }
    public abstract class AbstarctPencil
    {
        protected AbstractShape objShape;

        public AbstarctPencil(AbstractShape objShape)
        {
            this.objShape = objShape;
        }
        public abstract void DrawWithColor();
    }

    public class BluePencil : AbstarctPencil
    {
        public BluePencil(AbstractShape objShape) : base(objShape)
        {

        }
        public override void DrawWithColor()
        {
            objShape.Draw("Blue");
        }
    }
    public class RedPencil : AbstarctPencil
    {
        public RedPencil(AbstractShape objShape) : base(objShape)
        {

        }
        public override void DrawWithColor()
        {
            objShape.Draw("Red");
        }
    }
    public class Circle : AbstractShape
    {
        public override void Draw(string strColor)
        {
            //HttpContext.Current.Response.Write("Circle in " + strColor + " Color<br><br>");
        }
    }
    public class Rectangle : AbstractShape
    {
        public override void Draw(string strColor)
        {

            //HttpContext.Current.Response.Write("Rectangle in " + strColor + " Color<br><br>");

        }
    }
}
