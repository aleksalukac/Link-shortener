using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Link_Shortner
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(TextBoxLink.Text) || String.IsNullOrEmpty(TextBoxPassword.Text) || String.IsNullOrEmpty(TextBoxFolder.Text))
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

            if (TextBoxPassword.Text == password)
            {
                //Response.Write("<script>alert('Data inserted successfully')</script>");
                string subPath = TextBoxFolder.Text; // your code goes here

                bool exists = System.IO.Directory.Exists(Server.MapPath(subPath));
                //bool exists = System.IO.Directory.Exists(Server.MapPath("../" + subPath));

                if (!exists)
                {
                    System.IO.Directory.CreateDirectory(Server.MapPath(subPath));
                    //System.IO.Directory.CreateDirectory(Server.MapPath("../" + subPath));

                    string fileName = (Server.MapPath(subPath) + "/index.html");

                    try
                    {
                        // Create a new file   
                        using (FileStream fs = File.Create(fileName))
                        {
                            // Add some text to file  
                            string link;
                            if (!(TextBoxLink.Text.StartsWith("http://") || TextBoxLink.Text.StartsWith("https://")))
                            {
                                link = "http://" + TextBoxLink.Text;
                            }
                            else
                                link = TextBoxLink.Text;

                            Byte[] title = new UTF8Encoding(true).GetBytes("<html><head><meta http-equiv = \"refresh\" content = \"0; url=" + link + "\"/></head></html>");
                            fs.Write(title, 0, title.Length);
                        }
                    }
                    catch (Exception Ex)
                    {
                        Response.Write("<script>alert('Not successful')</script>");
                        return;
                        //Console.WriteLine();
                    }

                    Response.Write("<script>alert('Successful')</script>");
                }
                else

                    Response.Write("<script>alert('Not successful')</script>");

            }
            else
                Response.Write("<script>alert('Not successful')</script>");
        }
    }
}