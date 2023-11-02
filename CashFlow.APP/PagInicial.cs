//using CashFlow.BLL;
using CashFlow.MODEL;

namespace CashFlow.APP
{
    public partial class PagInicial : Form
    {
        public PagInicial()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        /*private void btLogin_Click(object sender, EventArgs e)
        {
            string loginInput = loginTxt.Text;
            string senhaInput = senhaTxt.Text;

            try
            {
                if (CashFlow.BLL.UsuarioRepository.AutenticaUsuario(loginInput, senhaInput))
                {
                    this.Hide();

                    Tipo formularioOpcoes = new Tipo(loginInput);
                    formularioOpcoes.ShowDialog();
                }
                else
                {
                    label3.Text = "Usu?rio n?o cadastrado";
                    label3.Visible = true;
                }
            }
            catch (Exception ex)
            {
                label3.Text = "N?o foi poss?vel realizar o login: " + ex.Message;
                label3.Visible = true;
                senhaTxt.Text = "";
            }


        }*/

        /*private void btNovoUsuario_Click(object sender, EventArgs e)
        {
            Form4 cadastro = new Form4();
            cadastro.ShowDialog();
            this.Close();
        }*/

    }
}