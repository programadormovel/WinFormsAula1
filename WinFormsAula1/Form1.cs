namespace WinFormsAula1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtNome.Text) && !lstNomes.Items.Contains(txtNome.Text))
            {
                lstNomes.Items.Add(txtNome.Text);
            }
        }
    }
}