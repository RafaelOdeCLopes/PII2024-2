using Neo4j.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PII2024_2
{
    public partial class CadastroAlimentos : Frm_Menu
    {
        bool sidebarExpand;
        bool homeCollapsed;
        SQLServer sql = new SQLServer();
        public CadastroAlimentos()
        {
            InitializeComponent();
            sql.Conectar();
            using (SqlCommand cmd = new SqlCommand("SELECT id_empresa_fabricante FROM alimentos", sql.Conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string idEmpresa = reader["id_empresa_fabricante"].ToString();
                        if (!cmbEmpresa.Items.Contains(idEmpresa))
                        {
                            cmbEmpresa.Items.Add(idEmpresa);
                        }
                    }
                }
            }
            using (SqlCommand cmd = new SqlCommand("SELECT id_doacao FROM alimentos", sql.Conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string idDoacao = reader["id_doacao"].ToString();
                        if (!cmbDoacao.Items.Contains(idDoacao))
                        {
                            cmbDoacao.Items.Add(idDoacao);
                        }
                    }
                }
            }
        }

        private void btnSalvarcadastroalimentos_Click(object sender, EventArgs e)
        {
            
        }
    }
}
