using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmRequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strUserID = "";
            string strPassword = string.Empty;
            string strName = "";
            string strAge = "";

            strUserID = Request.Params["TxtUserID"];
            //strUserID = Request.QueryString["TxtUserID"]; // GET방식 >> 주소URL 뒤에다 넣으면 됨 서버에서 데이터 넘길 때 씀 주소창 뒤에 ?로 시작 Key=Value&Key=Value 형식
            strPassword = Request.Params["TxtPassword"]; // Get,Post 둘다 가져옴 (뭐든지 불러옴)
            strName = Request.Form["TxtName"]; // POST형식 >> 태그안에 바로 쓰여 있는 값, 이걸로는 다른 주소에서 값 주기 힘듦 
            strAge = Request["TxtAge"]; // Get,Post 둘다 가져옴

            var result = $@"입력하신 아이디는 {strUserID}이고 <br />
암호는 {strPassword} 입니다 <br />이름은 {strName}이고 <br />
나이는 {strAge} 입니다<br />";
            LblResult.Text = result;  // 버튼누르는 행위 request >> request객체들 날아옴 >> 깜빡임 >> 그 값을 보여주는게 response임

            LblIpAddr.Text = Request.UserHostAddress;
        }

        protected void BtnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}