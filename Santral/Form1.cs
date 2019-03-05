using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Santral
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        SantralDbEntities dbCon = new SantralDbEntities();


       FrmBilgi frmBilgi = new FrmBilgi();
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {

            var fonksiyon = new girisKontrol();
            string login, pwd;

            login = txtKullanici.Text;
            pwd = txtSifre.Text;

            if (!fonksiyon.Giris(login,pwd))
            {
                MessageBox.Show("Kullanıcı Adı Şifre Hatalı");
            }
            else
            {
                frmBilgi.Show();

            }

        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
