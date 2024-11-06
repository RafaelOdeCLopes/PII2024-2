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

namespace PII2024_2
{
    public partial class Pedido : Frm_Menu
    {
        SQLServer sql = new SQLServer();
        public Pedido()
        {
            InitializeComponent();
            sql.Conectar();
            using (SqlCommand cmd = new SqlCommand("SELECT id_familia FROM pedidos", sql.Conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string idFamilia = reader["id_familia"].ToString();
                        if (!cmbFamilia.Items.Contains(idFamilia))
                        {
                            cmbFamilia.Items.Add(idFamilia);
                        }
                    }
                }
            }
            using (SqlCommand cmd = new SqlCommand("SELECT id_alimento FROM pedidos", sql.Conn))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string idAlimento = reader["id_alimento"].ToString();
                        if (!cmbAlimento.Items.Contains(idAlimento))
                        {
                            cmbAlimento.Items.Add(idAlimento);
                        }
                    }
                }
            }
        }
    }
}
