using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study
{

    //referencia: http://www.dsc.ufcg.edu.br/~jacques/cursos/map/html/pat/abstractfactory.htm
    // acessado em 24/5/2019

    class AbstractFactory
    {
    }

    public class JogoimplementsJogoIF
    {
        // Observe que essa função não tem new: ela usa uma Abstract Factory
        // Esta é a *única* diferença com relação à versão original
        // Observe como montaLabirinto acessa a factory (através de um singleton)
        /* public LabirintoIF montaLabirinto(FactoryDeLabirintoIF factory)
         {
             LabirintoIF umLabirinto = factory.criaLabirinto();
             SalaIF sala1 = factory.criaSala(1);
             SalaIF sala2 = factory.criaSala(2);
             PortaIF aPorta = factory.criaPorta(sala1, sala2);

             umLabirinto.adicionaSala(sala1);
             umLabirinto.adicionaSala(sala2);

             sala1.setVizinho(NORTE, factory.criaParede());
             sala1.setVizinho(LESTE, aPorta);
             sala1.setVizinho(SUL, factory.criaParede());
             sala1.setVizinho(OESTE, factory.criaParede());

             sala2.setVizinho(NORTE, factory.criaParede());
             sala2.setVizinho(LESTE, factory.criaParede());
             sala2.setVizinho(SUL, factory.criaParede());
             sala2.setVizinho(OESTE, aPorta);

             return umLabirinto;
         }
     }
     public class FactoryDeLabirintoEncantado : FactoryDeLabirinto
     {
         public SalaIF criaSala(int númeroDaSala)
         {
             return new salaEncantada(númeroDaSala, jogaEncantamento());
         }
         public PortaIF criaPorta(SalaIF sala1, SalaIF sala2)
         {
             return new portaPrecisandoDeEncantamento(sala1, sala2);
         }
         protected EncantamentoIF jogaEncantamento()
         {

         }
     }
     public class FactoryDeLabirintoPerigoso extends FactoryDeLabirinto
     {
       public ParedeIF criaParede()
         {
             return new paredeDestruível();
         }
         public SalaIF criaSala(int númeroDaSala)
         {
             return new salaComBomba(númeroDaSala);
         }
     }
 }
 */
    }
}