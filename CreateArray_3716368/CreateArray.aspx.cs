using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CreateArray_3716368
{
	public partial class CreateArray : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

        protected void btnCreateArray_Click(object sender, EventArgs e)
        {
            // Declare and initialize the category array.
            string[] strCategoryArray = new string[5]
            {
                   "Footwear - Men's",
                   "Clothing - Men's",
                   "Racquets",
                   "Footwear - Women's",
                   "Clothing - Women's"
            };

            // Save the array in a session variable for future use.
            Session["strCategoryArray"] = strCategoryArray;

            // Redirect to the next page.
            Response.Redirect("CategoryUseArraySessionVariables.aspx");
        }
    }
}