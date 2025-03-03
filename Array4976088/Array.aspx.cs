using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Array4976088
{
    public partial class Array : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCreateArray_Click(object sender, EventArgs e)
        {
            //Declare and load the array
            String[] strCategoryArray = new string[5];
            strCategoryArray[0] = "Footwear - Men  's' ";
            strCategoryArray[1] = "Clothing - Men  's' ";
            strCategoryArray[2] = "Racquets - Women 's' ";
            strCategoryArray[3] = "Footwear - Women 's' ";
            strCategoryArray[4] = " Clothing - Women 's' ";

            Session["strCategoryArray"] = strCategoryArray;


            Response.Redirect("from2.aspx");



        }

        protected void btnCreateArray_Click1(object sender, EventArgs e)
        {

        }

        protected void btnCreateArray_Click2(object sender, EventArgs e)
        {

        }

        protected void btnCreateArray_Click3(object sender, EventArgs e)
        {
            //Declare and load the array
            String[] strCategoryArray = new string[5];
            strCategoryArray[0] = "Footwear - Men  's' ";
            strCategoryArray[1] = "Clothing - Men  's' ";
            strCategoryArray[2] = "Racquets - Women 's' ";
            strCategoryArray[3] = "Footwear - Women 's' ";
            strCategoryArray[4] = " Clothing - Women 's' ";

            Session["strCategoryArray"] = strCategoryArray;


            Response.Redirect("Variables.aspx");

        }
    }
}