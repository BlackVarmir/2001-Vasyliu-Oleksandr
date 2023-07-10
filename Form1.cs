using System;
using System.Windows.Forms;

namespace _2001_події_для_форми
{
    public partial class Form1 : Form
    {
        private int clickCount;

        public Form1()
        {
            InitializeComponent();

            // Додати обробник подій для натискання мишки на формі
            this.MouseClick += Form1_MouseClick;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            clickCount++; // Збільшити лічильник кліків
            label1.Text = $"Кількість кліків: {clickCount}"; // Вивести повідомлення з кількістю кліків
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


/*namespace _2001_події_для_форми
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
    }
}*/