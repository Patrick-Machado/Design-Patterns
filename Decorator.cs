using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study
{
    //referencia: https://www.c-sharpcorner.com/UploadFile/SukeshMarla/learn-design-pattern-decorator-pattern/
    // acessado em 24/5/2019
    class Decorator
    {
        /*AbstractPlayerobjPlayer = null;

        if(RdbPlayer1.Checked)

        {

                  objPlayer = newPlayer1();

        }

        else

        {

                  objPlayer = newPlayer2();

        }

 

        if(ChkGun.Checked)

        {

                  objPlayer=newGunDecorator(objPlayer);

        }

        if(ChkKnife.Checked)

        {

                  objPlayer=newKnifeDecorator(objPlayer);

        }*/
    }
    /*
    public abstract class AbstractPlayer
    {
        void publicabstractstringGetDescription() { }
    }
    public class publicclassPlayer1:AbstractPlayer

    {

        string publicoverridestringGetDescription()
        {

            return "Player Name:Player1";

        }
    }

    public abstract class AbstractPlayerDecorator : AbstractPlayer

    {

        public abstract Playerobjplayer;

        public abstract PlayerDecorator(AbstractPlayerobjplayer)
        {
            this.objplayer = objplayer;
        }

    }
    public class GunDecorator : AbstractPlayerDecorator

    {

        public GunDecorator(AbstractPlayer player): base(player)
        {



        }

        public override string GetDescription()

        {

            returnthis.objplayer.GetDescription() + "<BR>Payer has Equipped with Gun";

        }

    }


    /*
    public class KnifeDecorator: AbstractPlayerDecorator
    {
        public KnifeDecorator(AbstractPlayer player): base(player)
        {



        }

        public override string GetDescription()

        {
            return this.objplayer.GetDescription() + "<BR>Payer has Equipped with Knife";

        }
    }
        */
}
