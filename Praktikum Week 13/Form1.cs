using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktikum_Week_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtTypePemain = new DataTable();
        DataTable dtPremier_league = new DataTable();
        int PosisiSekarang = 0;

        private void FormViewPemain_Load(object sender, EventArgs e)
        {
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "select p.player_id as 'Player ID', p.player_name as 'Player Name', p.birthdate as 'BirthDate', n.nation as 'Nationality', t.team_name as 'Team', p.team_number as 'Team Number' from player p left join nationality n on p.nationality_id = n.nationality_id left join team t  on p.team_id = t.team_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTypePemain);
            

            sqlQuery = "select team_id as 'ID Tim', team_name as 'Nama Tim' from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPremier_league);
            cmbox_team.DataSource = dtPremier_league;
            cmbox_team.DisplayMember = "Nama Tim";
            cmbox_team.ValueMember = "ID Tim";

            IsiDataPemain(0);
        }

        public void IsiDataPemain(int Posisi)
        {
            tbx_id.Text = dtTypePemain.Rows[Posisi][0].ToString();
            tbx_name.Text = dtTypePemain.Rows[Posisi][1].ToString();
            dtp_birthdate.Text = dtTypePemain.Rows[Posisi][2].ToString();
            cmbox_nationality.DataSource = dtTypePemain;
            cmbox_nationality.DisplayMember = "Nationality";

            cmbox_nationality.Text = dtTypePemain.Rows[Posisi][3].ToString();

            cmbox_team.DataSource = dtTypePemain;
            cmbox_team.DisplayMember = "Team";
            cmbox_team.Text = dtTypePemain.Rows[Posisi][4].ToString();
            nud_number.Text = dtTypePemain.Rows[Posisi][5].ToString();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtTypePemain.Rows.Count - 1);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_left1_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtTypePemain.Rows.Count - 1)
            {
                PosisiSekarang++;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
