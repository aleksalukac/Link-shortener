using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Link_Shortner
{
    public partial class Change : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if (TextBoxNewPass.Text.Contains(" ") || TextBoxNewPass.Text.Length < 5 || String.IsNullOrEmpty(TextBoxNewPass.Text) || String.IsNullOrEmpty(TextBoxNewPass1.Text) || String.IsNullOrEmpty(TextBoxOldPass.Text))
            {
                Response.Write("<script>alert('Wrong parameters')</script>");
                return;
            }
            string password = "";
            using (StreamReader sr = File.OpenText((Server.MapPath("") + "\\passssword.txt")))
            {
                string ss = "";
                while ((ss = sr.ReadLine()) != null)
                {
                    password += ss;
                }
            }

            if (TextBoxOldPass.Text == password && TextBoxNewPass.Text == TextBoxNewPass1.Text)
            {
                if (File.Exists((Server.MapPath("") + "\\passssword.txt")))
                {
                    File.Delete((Server.MapPath("") + "\\passssword.txt"));
                }
                using (FileStream fs = File.Create((Server.MapPath("") + "\\passssword.txt")))
                {
                    // Add some text to file  
                    Byte[] title = new UTF8Encoding(true).GetBytes(TextBoxNewPass.Text);
                    fs.Write(title, 0, title.Length);

                }

                Response.Write("<script>alert('Successful')</script>");
            }
            else
                Response.Write("<script>alert('Not successful')</script>");
        }
    }
}