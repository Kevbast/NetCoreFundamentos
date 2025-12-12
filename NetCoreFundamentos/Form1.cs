namespace NetCoreFundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnSaludo_Click(object sender, EventArgs e)
        {
            string texto = this.txtNombre.Text;
            //SOLO ESCRIBIMOS AQUÍ
            MessageBox.Show("Hola " + texto);
            this.lblSaludo.Text = "HOLA " + texto;
            this.txtNombre.Location = new Point(10,30);
            this.lblSaludo.Width = 200;
            this.lblSaludo.Height = 500;
            this.lblSaludo.BackColor = Color.Red;
            //NO ES UNA CONVERSION AUTOMATICA
            short pequeño = 88;
            int mayor = pequeño;

        }

    }
}
