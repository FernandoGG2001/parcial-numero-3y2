using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page

    {
        static List<video_juego> juegosTemp = new List<video_juego>();
        static List<participantes> jugadorTemp = new List<participantes>();
      

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            
                string archivo = Server.MapPath("Albumnes.json");
                StreamReader jsonStream = File.OpenText(archivo);
                string json = jsonStream.ReadToEnd();
                jsonStream.Close();
                jugadorTemp = JsonConvert.DeserializeObject<List<participantes>>(json);

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string json = JsonConvert.SerializeObject(juegosTemp);
            string archivo = Server.MapPath("Albumnes.json");
            System.IO.File.WriteAllText(archivo, json);
        }
    }


 }

