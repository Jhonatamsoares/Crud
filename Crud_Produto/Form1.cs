namespace Crud_Produto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Produtos add = new Add_Produtos();
            add.ShowDialog();
        }
    }
}