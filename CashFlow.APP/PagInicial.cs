//using CashFlow.BLL;
using CashFlow.MODEL;
using MyProject.BLL;

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


        private void btLogin_Click(object sender, EventArgs e)
        {
            string loginInput = loginTxt.Text;
            string senhaInput = senhaTxt.Text;

            try
            {
                if (MyProject.BLL.UsuarioRepository.AutenticaUsuario(loginInput, senhaInput))
                {
                    this.Hide();

                    Opcoes formularioOpcoes = new Opcoes(loginInput);
                    formularioOpcoes.ShowDialog();
                }
                else
                {
                    label3.Text = "Usuario nao cadastrado";
                    label3.Visible = true;
                }
            }
            catch (Exception ex)
            {
                label3.Text = "Nao foi possivel realizar o login: " + ex.Message;
                label3.Visible = true;
                senhaTxt.Text = "";
            }


        }

        private void btNovoUsuario_Click(object sender, EventArgs e)
        {
            NewUsuario cadastro = new NewUsuario();
            cadastro.ShowDialog();
            this.Close();
        }

    }
}