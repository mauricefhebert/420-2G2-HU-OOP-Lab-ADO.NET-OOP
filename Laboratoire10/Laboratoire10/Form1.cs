using System.Configuration;
using System.Data.SqlClient;

namespace Laboratoire10
{
    public partial class Form1 : Form
    {
        EtudiantDataContext dt;
        public Form1()
        {
            InitializeComponent();
            string strConnection = ConfigurationManager.ConnectionStrings[""].ConnectionString;
            this.dt = new EtudiantDataContext(strConnection);
        }

        /**
         * try {
         *  dt.nomDeLaMethod()
         *  MessageBox("Message");
         * } catch (Exception ex) { MessageBox.Show(ex.Message); }
         */
    }
}