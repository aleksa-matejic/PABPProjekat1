using PABPProjekat1.src.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PABPProjekat1.src.FormProvider
{
    // Aleksa: implementation of Singleton pattern over the main form I am using in this application
    public class FormProvider
    {
        public static LoginForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginForm();
                }
                return instance;
            }
        }

        private static LoginForm instance;

        private FormProvider() { }
    }
}
