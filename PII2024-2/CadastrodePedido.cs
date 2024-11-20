using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PII2024_2
{
    public partial class Pedido : Frm_Menu
    {
        public Pedido()
        {
            InitializeComponent();
            SQLServer sql = new SQLServer();
            sql.Conectar();
        }

        private void Pedido_Load(object sender, EventArgs e)
        {

        }
    }
}
