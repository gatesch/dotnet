using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Diagnostics.CodeAnalysis;

namespace MPTDevOpsWeb
{
    public partial class Info : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblEnv.Text = getenvinfo();
            LblHost.Text = getserverhost();
            LblLocation.Text = getlocationinfo();
            LblStage.Text = getstageinfo();
            LblMyTNS.Text = gettnsinfo();
            TxtServerVars.Text = getservervars();
        }

        private string getservervars()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in Request.ServerVariables)
            {
                sb.AppendLine(string.Format("{0} = {1}",item,Request.ServerVariables[item.ToString()].ToString()));
            }
            return sb.ToString();
        }


        private string gettnsinfo()
        {
            string tnsinf = ConfigurationManager.AppSettings["MyTNS"];
            return tnsinf;
        }

        private string getserverhost()
        {
            string hostinf = System.Net.Dns.GetHostName();
            return hostinf;
        }
        private string getstageinfo()
        {
            string stageinf = ConfigurationManager.AppSettings["STAGE"];
            return stageinf; 
        }
        private string getlocationinfo()
        {
            string locinf = ConfigurationManager.AppSettings["Location"];
            return locinf;
        }
        private string getenvinfo()
        {
            string envinf = ConfigurationManager.AppSettings["ENVNAME"];
            return envinf;
        }
        [ExcludeFromCodeCoverage]
        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.Visible = !GridView1.Visible;
        }
    }
}