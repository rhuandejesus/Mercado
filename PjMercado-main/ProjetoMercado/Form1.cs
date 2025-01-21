using ProjetoMercado.UserControls;
using System.Runtime.ConstrainedExecution;

namespace ProjetoMercado
{
    public partial class frmMercado : Form
    {
        public frmMercado()
        {
            InitializeComponent();

            VerificaUser();
        }

        private void VerificaUser()
        {
            if (variaveisGlobais.Cargo == "Caixa") //Se no formsLogin for ele verificar o "Cargo" no banco e 
            {                                      // amarzenar na varivel global a fun��o "Caixa", ele tem 2 restri��es                                   // no sistema que � feita abaixo.
                btnCadastroUsuario.Visible = false;
                btnProdutoCadastrar.Visible = false;
            }
        }

        // Evento para add da forma correta o UC
        private void addUserControl(UserControl userControl)
        {
            // Faz o controle 'userControl' preencher todo o painelVisual.
            userControl.Dock = DockStyle.Fill;

            // Remove todos os controles atuais do painel 'panelVisual'.
            panelVisual.Controls.Clear();

            // Adiciona o 'userControl' ao painel.
            panelVisual.Controls.Add(userControl);

            // Garante que o 'userControl' fique na frente de outros controles no painel.
            userControl.BringToFront();
        }

        // M�todo para alterar a cor dos bot�es
        private void AlterarCorBotoes(Button botaoSelecionado)
        {
            // Definir a cor padr�o para todos os bot�es
            CorPadraoButtons();

            // Mudar a cor do bot�o selecionado para laranja
            botaoSelecionado.BackColor = Color.FromArgb(250, 114, 4);
        }

        //Metodo que defini a cor padr�o para todos os bot�es
        private void CorPadraoButtons()
        {
            btnCadastroUsuario.BackColor = Color.FromArgb(2, 111, 216);
            btnCaixa.BackColor = Color.FromArgb(2, 111, 216);
            btnProdutoCadastrar.BackColor = Color.FromArgb(2, 111, 216);
        }

        // M�todo para adicionar o UserControl no painel
        private void CarregarUserControl(UserControl userControl)
        {
            addUserControl(userControl);  // Chama o m�todo que adiciona o UC no painel
        }

        // Evento do bot�o Cadastro de Usu�rio
        private void button3_Click(object sender, EventArgs e)
        {
            AlterarCorBotoes(btnCadastroUsuario); // Muda a cor do bot�o Cadastro de Usu�rio para laranja
            CarregarUserControl(new UC_UserCadastro()); // Carregar o UserControl de Cadastro de Usu�rio
        }

        // Evento do bot�o Caixa
        private void btnCaixa_Click(object sender, EventArgs e)
        {
            AlterarCorBotoes(btnCaixa); // Muda a cor do bot�o Caixa para laranja
            CarregarUserControl(new UC_Caixa()); // Carregar o UserControl de Caixa
        }

        // Evento do bot�o Cadastro de Produto
        private void btnProdutoCadastrar_Click(object sender, EventArgs e)
        {
            AlterarCorBotoes(btnProdutoCadastrar); // Muda a cor do bot�o Cadastro de Produto para laranja
            CarregarUserControl(new UC_ProdutoCadastro()); // Carregar o UserControl de Cadastro de Produto
        }

        // Evento do bot�o Home (imagem de Home)
        private void pictureHome_Click(object sender, EventArgs e)
        {
            CorPadraoButtons(); // Defini a cor padr�o para todos os bot�es
            CarregarUserControl(new UC_Home()); // Carregar o UserControl de Home
        }

        private void FrmMercado_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Exit();
        }

        private void btnSobre_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.Show();
        }
    }
}