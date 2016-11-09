using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace Dobre_misli
{
    
    public partial class Default : System.Web.UI.Page
    {
        public static ArrayList al = new ArrayList();
        protected void Page_Load(object sender, EventArgs e)
        {
            refresh();
        }

        protected void dodajMisel_Click(object sender, EventArgs e)
        {
            al.Add(misel.Text);
            misel.Text = "";
            refresh();
            
        }
        public void refresh()
        {
            
            foreach (string s1 in al)
            {
                Label l = new Label();
                l.Text = s1;
                misli.Controls.Add(l);
            }
        }
    }
    
}