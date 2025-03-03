using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Array4976088
{
    public partial class from2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCreateArray_Click(object sender, EventArgs e)
        {

            String[] strCategoryArray = new String[5];
            strCategoryArray = Session["strCategoryArray"] as String[];
            Int32 i32Index = Convert.ToInt32(txtIndex.Text);
            lblCategory.Text = strCategoryArray[i32Index];
        }
    }
}