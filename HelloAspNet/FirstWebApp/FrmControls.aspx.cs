using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LsbHobby.Items.Add("농구");
            LsbHobby.Items.Add("배구");

            CboPhoneNumber.Items.Add("010-3333-2222");

            if (!Page.IsPostBack)
            {
                CtlHidden.Value = DateTime.Now.ToShortTimeString();
            }
        }

        protected void BtnChage_Click(object sender, EventArgs e)
        {
            ImgChange.ImageUrl = "~/images/ASP-NET-Banners-02.png";
        }

        protected void BtnOK_Click(object sender, EventArgs e)
        {
            Response.Write(CtlHidden.Value);
        }
    }
}