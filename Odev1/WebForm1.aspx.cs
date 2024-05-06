using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Odev1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            int maas = 25000;
            int yeniMaas = maas;
            
            if(CheckBox6.Checked == true)
            {
                yeniMaas += 5000;
            }
            if(CheckBox7.Checked == true)
            {
                yeniMaas += 5000;
            }
            if (CheckBox8.Checked == true)
            {
                yeniMaas += 5000;
            }
            if (RadioButton2.Checked != true)
            {
                Label10.Text = "Maaşınız : " + Convert.ToString(yeniMaas) + "TL'dir";
                 
            }
            else
            {
                yeniMaas += 5000;
                Label10.Text = "Maaşınız : " + Convert.ToString(yeniMaas) + "TL'dir";
            }

        }
    }
}