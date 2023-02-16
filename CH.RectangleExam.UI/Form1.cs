namespace CH.RectangleExam.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float length = 0;
            float width = 0;

            if (float.TryParse(txtLength.Text, out length)) 
            {
                if(float.TryParse(txtWidth.Text, out width)) 
                {
                    //instanciating it
                    Rectangle rectangle = new Rectangle();
                    rectangle.Width = width;
                    rectangle.Length= length;
                    txtArea.Text = rectangle.CalculateArea().ToString();

                    txtPerimeter.Text = rectangle.CalculatePerimeter().ToString();
                
                }
                else
                {
                    MessageBox.Show("You need to type in a positive number");
                }
            
            }
            else
            {
                MessageBox.Show("You need to type in a positive number");
            }
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            txtPerimeter.Text = "";
            txtArea.Text = "";

        }

        private void txtLength_TextChanged(object sender, EventArgs e)
        {
            txtPerimeter.Text = "";
            txtArea.Text = "";
        }
    }
}