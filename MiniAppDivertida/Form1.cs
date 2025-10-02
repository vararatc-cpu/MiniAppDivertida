using System;
using System.Windows.Forms;

namespace MiniAppDivertida
{
    public partial class Form1 : Form
    {
        Random rnd = new Random(); // Para generar n�meros aleatorios
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mover el bot�n a una posici�n aleatoria
            int maxX = this.ClientSize.Width - button1.Width;
            int maxY = this.ClientSize.Height - button1.Height;

            button1.Left = rnd.Next(0, maxX);
            button1.Top = rnd.Next(0, maxY);

            // Mensajes aleatorios
            string[] mensajes = { "�Hola!", "�Clic r�pido!", "�Sigue intentando!", "�Eres r�pido!" };
            label1.Text = mensajes[rnd.Next(mensajes.Length)];

            // Cambiar colores aleatorios
            button1.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            this.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
