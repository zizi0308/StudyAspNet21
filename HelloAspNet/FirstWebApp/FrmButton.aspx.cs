using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmButton : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack) TxtNum.Text = "0"; // 최초의 값만 IsPostBack이 False 그 이상은 관여안함 > 이게 반드시 들어가야 깜빡이가 실행되고 값이 바뀜
        }

        protected void BtnInc_Click(object sender, EventArgs e)
        {
            TxtNum.Text= $"{int.Parse(TxtNum.Text) + 1}";
        }

        protected void BtnDec_Click(object sender, EventArgs e)
        {
            TxtNum.Text = $"{int.Parse(TxtNum.Text) - 1}";
        }

        protected void BtnLink_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.naver.com");
        }

        protected void BtnImage_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}