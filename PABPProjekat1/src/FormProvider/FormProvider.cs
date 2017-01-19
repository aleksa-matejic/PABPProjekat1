using PABPProjekat1.src.UpdateSupplier;
using PABPProjekat1.src.Categories;
using PABPProjekat1.src.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PABPProjekat1.src.FormProvider
{
    // Aleksa: implementation of Singleton pattern over the forms I am using in this application
    public class FormProvider
    {
        #region LoginForm

        public static LoginForm LoginForm
        {
            get
            {
                if (loginForm == null)
                {
                    loginForm = new LoginForm();
                }
                return loginForm;
            }

        }

        private static LoginForm loginForm;

        #endregion

        #region CategoriesForm

        public static CategoriesForm CategoriesForm
        {
            get
            {
                if (categoriesForm == null)
                {
                    categoriesForm = new CategoriesForm();
                }
                return categoriesForm;
            }

            set
            {
                categoriesForm = value;
            }
        }

        public static CategoriesForm GetCategoriesForm()
        {
            return categoriesForm;
        }

        private static CategoriesForm categoriesForm;

        #endregion

        #region UpdateSupplierForm

        public static UpdateSupplierForm UpdateSupplierForm
        {
            get
            {
                if (updateSupplierForm == null)
                {
                    updateSupplierForm = new UpdateSupplierForm();
                }
                return updateSupplierForm;
            }

            set
            {
                updateSupplierForm = value;
            }
        }

        public static UpdateSupplierForm GetUpdateSupplierForm()
        {
            return updateSupplierForm;
        }

        private static UpdateSupplierForm updateSupplierForm;

        #endregion
    }
}
