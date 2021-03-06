using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FirstWebApp
{
    public partial class FrmResponseBuffer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Expires = -1; // 현재페이지를 매번 새로 읽어옴
            Response.Buffer = true; // 버퍼사용, 메모리 화면에 처리할 것들 다 담아둔 뒤에 한꺼번에 출력
            Response.Write("[1] 현재 글이 보여짐");
            Response.Flush(); // 버퍼에 있는 내용 출력
            Response.Write("[3] 현재글은?");
            Response.Clear(); // 버퍼에 있는 내용을 지움
            Response.Write("[4] 출력");
            Response.End(); // 이후 Response 출력 안됨 별로 쓸일 없음
            Response.Write("[5] 출력이 안됨");
        }
    }
}