using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KTXC1
{
    public partial class Dangnhap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
        }
        
        protected void btnDN_Click(object sender, EventArgs e)
        {
            TaiKhoanDAO nvDAO = new TaiKhoanDAO();
            string manv = txtUsername.Text;
            string mk = txtPassword.Text;
            bool exist = nvDAO.KTDangNhapNV(manv, mk);
            bool kq = nvDAO.KTDangNhapQL(manv, mk);
            if (exist)
            {

                Session["manv"] = manv;
                Session["mk"] = mk;
                Response.Redirect("TrangQL.aspx");

            }
            else
                if (kq)
                {
                    Session["manv"] = manv;
                    Session["mk"] = mk;
                    Response.Redirect("TaiKhoan.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Sai tên đăng nhập hoặc mật khẩu')</script>");
                }
        }
    }
}