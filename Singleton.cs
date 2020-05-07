using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Study
{
    //referencia: https://forum.unity.com/threads/singleton.225938/
    //acessado em 24/5/2019
    class Singleton
    {
        /*
        private static Singleton instance = null;

        public static Singleton Instance
        {
            get { return instance; }
        }

        private void Awake()
        {
            // If instance already exist, destroy ourself.
            if (instance != null  instance != this)
            {
                Destroy(gameObject);
                return;
            }

            // No instance exist yet? We are it.
            instance = this;

            // This line exist so that the Singleton would persist between scene loads.
            // Not all singletons needs that.
            DontDestroyOnLoad(gameObject);
        }*/
    }

}
