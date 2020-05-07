using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study
{
    //referencia: https://www.c-sharpcorner.com/UploadFile/SukeshMarla/learn-design-pattern-flyweight-pattern/
    // acessado em 24/5/2019
    class FlyWeight
    {/*
        private void CreateSoldier(DropDownList DdlCharacterType, TextBox TxtCharacterName, TextBox TxtColor)

        {

            Soldier soldier = factory.GetSoldier(DdlCharacterType.SelectedValue);

            soldier.RenderSoldier(TxtCharacterName.Text, TxtColor.Text);

        }
        public static void Main(string[] args)
        {
            this.CreateSoldier(DdlCharacterType1, TxtCharacterName1, TxtColor1);

            Response.Write("<Br>");

            this.CreateSoldier(DdlCharacterType2, TxtCharacterName2, TxtColor2);

            Response.Write("<Br>");

            this.CreateSoldier(DdlCharacterType3, TxtCharacterName3, TxtColor3);
        }
    }
    public class WeaponType { public object Gun; }
    public abstract class Soldier
    {
        public WeaponType Weapon { get; set; }
        public abstract void RenderSoldier(string StrPriName, string Color);
    }

    public class GunSoldier : Soldier

    {

        public GunSoldier()

        {

            this.Weapon = WeaponType.Gun;

        }

        public override void RenderSoldier(string StrPriName, string Color)

        {

            HttpContext.Current.Response.Write("Gun Character " + StrPriName + " Rendered with " + Color + " Color");

        }

    }



    public class SwordSoldier : Soldier

    {

        public SwordSoldier()

        {

            this.Weapon = WeaponType.Sword;

        }

        public override void RenderSoldier(string StrPriName, string Color)

        {

            HttpContext.Current.Response.Write("Sword Character " + StrPriName + " Rendered with " + Color + " Color");

        }

    }

    public class SoldierFactory

    {

        Dictionary<string, Soldier> SoldierCollection;

        public SoldierFactory()

        {

            SoldierCollection = new Dictionary<string, Soldier>();

        }

        public Soldier GetSoldier(string SoldierIndex)

        {

            if (!SoldierCollection.ContainsKey(SoldierIndex))

            {

                HttpContext.Current.Response.Write("Objet created - ");

                switch (SoldierIndex)

                {

                    case "0":

                        SoldierCollection.Add(SoldierIndex, new GunSoldier());

                        break;

                    case "1":

                        SoldierCollection.Add(SoldierIndex, new SwordSoldier());

                        break;

                }

            }

            else

            {

                HttpContext.Current.Response.Write("Objet reused - ");

            }

            return SoldierCollection[SoldierIndex];

        }
        */
    }



}
