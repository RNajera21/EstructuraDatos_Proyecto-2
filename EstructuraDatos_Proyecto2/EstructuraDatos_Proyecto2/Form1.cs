using System.CodeDom;
using System.Security.Cryptography.X509Certificates;

namespace EstructuraDatos_Proyecto2
{
    public partial class Form1 : Form
    {
        int[,] matrizjuego = new int[6, 7];
        int fila = 0, col = 0;
        int boton = 0;
        bool turnop1 = true;

        public Form1()
        {
            InitializeComponent();
        }
        public void llenarmatrizjuego()
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

        public bool VerificarVictoria(int jugador)
        {
            // Verificar victoria en filas
            for (int fila = 0; fila < 6; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    if (matrizjuego[columna, fila] == jugador &&
                        matrizjuego[columna + 1, fila] == jugador &&
                        matrizjuego[columna + 2, fila] == jugador &&
                        matrizjuego[columna + 3, fila] == jugador)
                    {
                        return true;
                    }
                }
            }

            // Verificar victoria en columnas
            for (int columna = 0; columna < 7; columna++)
            {
                for (int fila = 0; fila < 3; fila++)
                {
                    if (matrizjuego[columna, fila] == jugador &&
                        matrizjuego[columna, fila + 1] == jugador &&
                        matrizjuego[columna, fila + 2] == jugador &&
                        matrizjuego[columna, fila + 3] == jugador)
                    {
                        return true;
                    }
                }
            }

            // Verificar victoria en diagonales \
            for (int columna = 0; columna < 4; columna++)
            {
                for (int fila = 0; fila < 3; fila++)
                {
                    if (matrizjuego[columna, fila] == jugador &&
                        matrizjuego[columna + 1, fila + 1] == jugador &&
                        matrizjuego[columna + 2, fila + 2] == jugador &&
                        matrizjuego[columna + 3, fila + 3] == jugador)
                    {
                        return true;
                    }
                }
            }

            // Verificar victoria en diagonales /
            for (int columna = 0; columna < 4; columna++)
            {
                for (int fila = 3; fila < 6; fila++)
                {
                    if (matrizjuego[columna, fila] == jugador &&
                        matrizjuego[columna + 1, fila - 1] == jugador &&
                        matrizjuego[columna + 2, fila - 2] == jugador &&
                        matrizjuego[columna + 3, fila - 3] == jugador)
                    {
                        return true;
                    }
                }
            }

            return false;

            if (VerificarVictoria(1))
            {
                MessageBox.Show("¡Jugador 1 ha ganado!");
            }
            else if (VerificarVictoria(2))
            {
                MessageBox.Show("¡Jugador 2 ha ganado!");
            }

        }
        private void reiniciar()
        {
            // Limpiar la matriz de juego
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    matrizjuego[i, j] = 0;
                }
            }
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    ((Button)control).Image = null;
                }
            }
            turnop1 = true;
        }

        public void marcarcasilla(int posicion)
        {
            Image image1 = Image.FromFile(@"C:\Users\roger\Desktop\UH\PROGRA\Progra II\Círculo Blanco.jpg");
            Image image = Image.FromFile(@"C:\Users\roger\Desktop\UH\PROGRA\Progra II\Círculo Negro.png");

            Image turn;
            if (turnop1)
            {
                turn = image1;
            }
            else
            {
                turn = image;
            }

            switch (posicion)
            {
                case 0: button1.Image = turn; break;
                case 1: button2.Image = turn; break;
                case 2: button3.Image = turn; break;
                case 3: button4.Image = turn; break;
                case 4: button5.Image = turn; break;
                case 5: button6.Image = turn; break;
                case 6: button7.Image = turn; break;
                case 10: button8.Image = turn; break;
                case 11: button9.Image = turn; break;
                case 12: button10.Image = turn; break;
                case 13: button11.Image = turn; break;
                case 14: button12.Image = turn; break;
                case 15: button13.Image = turn; break;
                case 16: button14.Image = turn; break;
                case 20: button15.Image = turn; break;
                case 21: button16.Image = turn; break;
                case 22: button17.Image = turn; break;
                case 23: button18.Image = turn; break;
                case 24: button19.Image = turn; break;
                case 25: button20.Image = turn; break;
                case 26: button21.Image = turn; break;
                case 30: button22.Image = turn; break;
                case 31: button23.Image = turn; break;
                case 32: button24.Image = turn; break;
                case 33: button25.Image = turn; break;
                case 34: button26.Image = turn; break;
                case 35: button27.Image = turn; break;
                case 36: button28.Image = turn; break;
                case 40: button29.Image = turn; break;
                case 41: button30.Image = turn; break;
                case 42: button31.Image = turn; break;
                case 43: button32.Image = turn; break;
                case 44: button33.Image = turn; break;
                case 45: button34.Image = turn; break;
                case 46: button35.Image = turn; break;
                case 50: button36.Image = turn; break;
                case 51: button37.Image = turn; break;
                case 52: button38.Image = turn; break;
                case 53: button39.Image = turn; break;
                case 54: button40.Image = turn; break;
                case 55: button41.Image = turn; break;
                case 56: button42.Image = turn; break;

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

        private void button43_Click(object sender, EventArgs e)
        {
            reiniciar();
        }
    }
}