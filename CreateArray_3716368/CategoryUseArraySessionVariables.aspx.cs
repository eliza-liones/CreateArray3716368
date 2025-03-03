using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreateArray_3716368
{
	public partial class CategoryUseArraySessionVariables : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnLookup_Click(object sender, EventArgs e)
        {
            // Declara un nuevo array.
            String[] strCategoryArray = new String[5];

            // Obtiene el array de la variable de sesión.
            strCategoryArray = Session["strCategoryArray"] as String[];

            // Usa el array normalmente.
            Int32 i32Index = Convert.ToInt32(txtIndex.Text);
            lblCategory.Text = strCategoryArray[i32Index];
        }
    }
}