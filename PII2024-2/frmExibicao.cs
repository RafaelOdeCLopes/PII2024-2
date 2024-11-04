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
    public partial class frmExibicao : Form
    {
        SQLServer sql = new SQLServer();
        public frmExibicao(string consulta)
        {
            InitializeComponent();
            dgvExibicao.DataSource = sql.RetornarTabela(consulta);
        }
    }
}
