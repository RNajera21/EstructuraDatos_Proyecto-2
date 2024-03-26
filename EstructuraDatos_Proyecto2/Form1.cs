using System.Security.Cryptography.X509Certificates;

namespace EstructuraDatos_Proyecto2
{
    public partial class Form1 : Form
    {
        int[,] matrizjuego = new int[6, 7];
        int fila = 0, col = 0;
        int boton = 0;
        string text1 = "O";
        string text2 = "X";
        bool turnop1 = true;

        public Form1()
        {
            InitializeComponent();
        }


        private void llenarmatrizjuego()
        {
            for (int i = 5; i > -1; i--)
            {
                if (matrizjuego[i, col] != 1)
                {
                    matrizjuego[i, col] = 1;
                    int pos = int.Parse((i.ToString() + col.ToString()).ToString());
                    marcarcasilla(pos);
                    Turno();
                    break;
                }
            }
        }
        private void Turno()
        {
            turnop1 = !turnop1;
        }

        private void marcarcasilla(int posicion)
        {
            string turn = turnop1 ? text1 : text2;
            switch (posicion)
            {
                case 0: button1.Text = turn; break;
                case 1: button2.Text = turn; break;
                case 2: button3.Text = turn; break;
                case 3: button4.Text = turn; break;
                case 4: button5.Text = turn; break;
                case 5: button6.Text = turn; break;
                case 6: button7.Text = turn; break;
                case 10: button8.Text = turn; break;
                case 11: button9.Text = turn; break;
                case 12: button10.Text = turn; break;
                case 13: button11.Text = turn; break;
                case 14: button12.Text = turn; break;
                case 15: button13.Text = turn; break;
                case 16: button14.Text = turn; break;
                case 20: button15.Text = turn; break;
                case 21: button16.Text = turn; break;
                case 22: button17.Text = turn; break;
                case 23: button18.Text = turn; break;
                case 24: button19.Text = turn; break;
                case 25: button20.Text = turn; break;
                case 26: button21.Text = turn; break;
                case 30: button22.Text = turn; break;
                case 31: button23.Text = turn; break;
                case 32: button24.Text = turn; break;
                case 33: button25.Text = turn; break;
                case 34: button26.Text = turn; break;
                case 35: button27.Text = turn; break;
                case 36: button28.Text = turn; break;
                case 40: button29.Text = turn; break;
                case 41: button30.Text = turn; break;
                case 42: button31.Text = turn; break;
                case 43: button32.Text = turn; break;
                case 44: button33.Text = turn; break;
                case 45: button34.Text = turn; break;
                case 46: button35.Text = turn; break;
                case 50: button36.Text = turn; break;
                case 51: button37.Text = turn; break;
                case 52: button38.Text = turn; break;
                case 53: button39.Text = turn; break;
                case 54: button40.Text = turn; break;
                case 55: button41.Text = turn; break;
                case 56: button42.Text = turn; break;

                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fila = 0;
            col = 0;
            boton = 0;
            llenarmatrizjuego();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fila = 0;
            col = 1;
            boton = 01;
            llenarmatrizjuego();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fila = 0;
            col = 2;
            boton = 02;
            llenarmatrizjuego();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fila = 0;
            col = 3;
            boton = 03;
            llenarmatrizjuego();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fila = 0;
            col = 4;
            boton = 04;
            llenarmatrizjuego();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fila = 0;
            col = 5;
            boton = 05;
            llenarmatrizjuego();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fila = 0;
            col = 6;
            boton = 06;
            llenarmatrizjuego();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fila = 1;
            col = 0;
            boton = 10;
            llenarmatrizjuego();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fila = 1;
            col = 1;
            boton = 11;
            llenarmatrizjuego();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            fila = 1;
            col = 2;
            boton = 12;
            llenarmatrizjuego();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            fila = 1;
            col = 3;
            boton = 13;
            llenarmatrizjuego();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            fila = 1;
            col = 4;
            boton = 14;
            llenarmatrizjuego();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            fila = 1;
            col = 5;
            boton = 15;
            llenarmatrizjuego();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            fila = 1;
            col = 6;
            boton = 16;
            llenarmatrizjuego();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            fila = 2;
            col = 0;
            boton = 20;
            llenarmatrizjuego();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            fila = 2;
            col = 1;
            boton = 21;
            llenarmatrizjuego();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            fila = 2;
            col = 2;
            boton = 22;
            llenarmatrizjuego();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            fila = 2;
            col = 3;
            boton = 23;
            llenarmatrizjuego();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            fila = 2;
            col = 4;
            boton = 24;
            llenarmatrizjuego();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            fila = 2;
            col = 5;
            boton = 25;
            llenarmatrizjuego();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            fila = 2;
            col = 6;
            boton = 26;
            llenarmatrizjuego();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            fila = 3;
            col = 0;
            boton = 30;
            llenarmatrizjuego();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            fila = 3;
            col = 1;
            boton = 31;
            llenarmatrizjuego();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            fila = 3;
            col = 2;
            boton = 32;
            llenarmatrizjuego();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            fila = 3;
            col = 3;
            boton = 33;
            llenarmatrizjuego();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            fila = 3;
            col = 4;
            boton = 34;
            llenarmatrizjuego();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            fila = 3;
            col = 5;
            boton = 35;
            llenarmatrizjuego();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            fila = 3;
            col = 6;
            boton = 36;
            llenarmatrizjuego();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            fila = 4;
            col = 0;
            boton = 40;
            llenarmatrizjuego();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            fila = 4;
            col = 1;
            boton = 41;
            llenarmatrizjuego();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            fila = 4;
            col = 2;
            boton = 42;
            llenarmatrizjuego();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            fila = 4;
            col = 3;
            boton = 43;
            llenarmatrizjuego();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            fila = 4;
            col = 4;
            boton = 44;
            llenarmatrizjuego();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            fila = 4;
            col = 5;
            boton = 45;
            llenarmatrizjuego();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            fila = 4;
            col = 6;
            boton = 46;
            llenarmatrizjuego();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            fila = 5;
            col = 0;
            boton = 50;
            llenarmatrizjuego();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            fila = 5;
            col = 1;
            boton = 51;
            llenarmatrizjuego();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            fila = 5;
            col = 2;
            boton = 52;
            llenarmatrizjuego();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            fila = 5;
            col = 3;
            boton = 53;
            llenarmatrizjuego();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            fila = 5;
            col = 4;
            boton = 54;
            llenarmatrizjuego();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            fila = 5;
            col = 5;
            boton = 55;
            llenarmatrizjuego();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            fila = 5;
            col = 6;
            boton = 56;
            llenarmatrizjuego();
        }
    }
}
