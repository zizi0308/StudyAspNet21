using DotNetNote.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetNote.Board
{
    public partial class BoardList : System.Web.UI.Page
    {

        private DbRepository _repo;
        // 검색모드이면 true, 보통 false
        public bool SearchMode { get; set; } = false;
        
        public int RecordCount = 0; // 총 레코드 수
        public int PageIndex = 0; // 페이징 할 때 꼭 필요한 값, 현재 보여줄 페이지 번호
        public BoardList()
        {
            _repo = new DbRepository(); // SqlConnection생성
        }

        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!SearchMode)
            {
                RecordCount = _repo.GetCountAll();
            }
            LblTotalRecord.Text = $"Total Record : {RecordCount}";

            if (Request["Page"] != null)
            {
                // Page보여지는 쪽은 1, 2, 3 ... 코드단에서는 0, 1, 2...
                PageIndex = Convert.ToInt32(Request["Page"]) - 1;
            }
            else
            {
                PageIndex = 0; // 1페이지
            }

            // TODO : 쿠키를 사용해서 페이지 리스트에 페이지 번호를 유지하는데 씀

            // 페이징 처리
            PagingControl.PageIndex = PageIndex;
            PagingControl.RecordCount = RecordCount;

            if (!Page.IsPostBack)
            {
                DisplayData();
            }
            
        }

        private void DisplayData()
        {
            if (!SearchMode)
            {
                GrvNates.DataSource = _repo.GetAll(PageIndex); // 페이징은 0부터 시작
            }

            GrvNates.DataBind(); // 데이터 바인딩 끝
        }
    }
}