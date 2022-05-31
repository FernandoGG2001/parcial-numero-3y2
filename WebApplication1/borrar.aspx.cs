using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class borrar : System.Web.UI.Page
    {
        static List<video_juego> juegosTemp = new List<video_juego>();
        static List<participantes> jugadorTemp = new List<participantes>();


        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (var album in participantes)
            {

                participantes alb = juegosTemp.Find(c => c.Nombre == TextBox1.Text);
                if (alb != null)
                {
                    juegosTemp.Remove(alb);
                }
            }
            GuardarJson();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}