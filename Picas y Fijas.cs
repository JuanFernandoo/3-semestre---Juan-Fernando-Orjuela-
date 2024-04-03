using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public int cantidadIntentos { get; set; }

        public Form1()
        {
            InitializeComponent();

         
        }



        private void textBoxUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                textBoxContrasena.Focus();

            }
        }

        private void textBoxContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                textBoxMinutos.Focus();
            }
        }

        private void textBoxMinutos_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                textBoxIntentos.Focus();
            }
            if ((e.KeyChar >= 37 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("SOLO NÚMEROS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxIntentos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 37 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("SOLO NÚMEROS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsuario.Text;
            string contrasena = textBoxContrasena.Text;
            string minutos = textBoxMinutos.Text;
            string intentos = textBoxIntentos.Text;



            int cantidadIntentos;
            if (int.TryParse(intentos, out cantidadIntentos))
            {
                if (usuario == "usuario" && contrasena == "contraseña")
                {
                    Form2 form2 = new Form2();
                    form2.CantidadIntentos = cantidadIntentos; 
                    form2.Show();
                    this.Hide();
                }
                else 
                {
                    MessageBox.Show("Credenciales incorrectas. Inténtalo de nuevo.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}