using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PABPProjekat1.src.Session
{
    public class UserSession
    {
        public string Username { get; set; }

        public int SupplierID { get; set; }

        public bool IsActive { get; set; }

        private UserSession()
        {
            IsActive = false;
            Username = string.Empty;
        }

        #region Singleton

        public static UserSession Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserSession();
                }
                return instance;
            }
        }

        private static UserSession instance;

        #endregion
    }
}
