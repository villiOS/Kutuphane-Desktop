using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLogin;
using EntityLogin.Facade;


namespace frmLogin
{
    public partial class frmLogin : Form
    {
        public frmLogin( )
        {
            InitializeComponent();
        }

        private void txtGiris_Click( object sender, EventArgs e )
        {
            LoginFacade adminLogin = new LoginFacade();
            
            bool successLogin = adminLogin.Kontrol( txtAdminName.Text, txtAdminPassword.Text );

            if ( successLogin )
            {
                
                LoginMessage( successLogin );
                frmMain frmMain = new frmMain();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                LoginMessage( successLogin );
            }



            //var admin = new Admin()
            //{
            //    adminName = txtAdminPassword.Text,
            //    adminPassword = txtAdminPassword.Text
            //};
            //adminLogin.Ekle(admin);
        }

        private void LoginMessage( bool successLogin )
        {
            MessageBox.Show( "Giriş izni: " + successLogin );
        }

        private void frmLogin_Load( object sender, EventArgs e )
        {
          
        }
    }
}
