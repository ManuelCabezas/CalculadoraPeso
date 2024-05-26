namespace CalculadoraIMC
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                double alturaCm = double.Parse(txtAltura.Text);
                string genero;

                if (rbtnHombre.Checked)
                {
                    genero = "Hombre";
                }
                else if (rbtnMujer.Checked)
                {
                    genero = "Mujer";
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un género.");
                    return;
                }


                double alturaInches = alturaCm * 0.393701;


                if (alturaInches <= 0)
                {
                    MessageBox.Show("Por favor, ingrese una altura positiva.");
                    return;
                }

                double pesoIdeal;

                if (genero == "Hombre")
                {
                    pesoIdeal = 50 + 2.3 * (alturaInches - 60);
                }
                else if (genero == "Mujer")
                {
                    pesoIdeal = 45.5 + 2.3 * (alturaInches - 60);
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un género válido.");
                    return;
                }


                MessageBox.Show($"El peso ideal es: {pesoIdeal:F2} kg");
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos para la altura y la edad.");
            }
        }
    

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
