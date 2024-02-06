namespace GeorgeTownCleaningServices
{
    public partial class frmPrincipal : Form
    {
        //atributos

        //constantes para los precios de los items
        const double priceOneShirt = 0.75;
        const double pricePairPants = 2.25;
        const double priceOneDress = 4.36;

        const double ITBIS = 0.18;

        //variables para almacenar las cantidades de los items
        uint ShirtsQuantity;
        uint PantsQuantity;
        uint DressesQuantity;

        public frmPrincipal()
        {
            InitializeComponent();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //deshabilitamos el boton de calcular hasta que se introduzcan cantidades
            //a procesar
            btnCalculate.Enabled = false;

            //cargamos los precios unitarios de los items
            txtShirtPrice.Text = priceOneShirt.ToString("C");
            txtPantsPrice.Text = pricePairPants.ToString("C");
            txtDressPrice.Text = priceOneDress.ToString("C");
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            //Salir de la aplicacion
            Application.Exit();
        }

        private void txtShirtsQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtShirtsQuantity.TextLength > 0 || txtPantsQuantity.TextLength > 0 || txtDressesQuantity.TextLength > 0)
            {
                btnCalculate.Enabled = true; //habilita el botón porque hay algun valor
            }
            else
            {
                btnCalculate.Enabled = false;
            }
        }

        private void txtShirtsQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //procesar la orden

            //capturar los datos del cliente
            string customerName = "";
            string customerPhone = "";
            //DateTime orderDate = 

            double subTotalShirts;
            double subTotalPants = 0;
            double subTotalDress = 0;

            //vamos a calcular

            if (txtShirtsQuantity.Text == string.Empty)
            {
                txtShirtsQuantity.Text = "0";
            }
            if(txtPantsQuantity.Text == string.Empty)
            {
                txtPantsQuantity.Text = "0";
            }

            ShirtsQuantity = Convert.ToUInt32(txtShirtsQuantity.Text);




        }
    }
}

//subTotalShirts = Convert.ToUInt32(txtShirtsQuantity.Text) * priceOneShirt;
////completar los otros subtotales

//double totalGross = subTotalShirts + subTotalPants + subTotalDress;

////calcular el impuesto a pagar
//double taxes = ITBIS * totalGross;

////calcular el total neto
//double totalNet = totalGross + taxes;

////Informar al cliente del total
//MessageBox.Show($"El total de su compra es {totalNet:C}", "Resume",
//    MessageBoxButtons.OK, MessageBoxIcon.Information);

////pedir el pago
//double payment = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Digite el Pago"));

////calcular la devuelta
//double difference = payment - totalNet;