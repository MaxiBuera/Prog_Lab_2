using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AContarPalabras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, int> diccionario;

        private void Form1_Load(object sender, EventArgs e)
        {
            diccionario = new Dictionary<string, int>();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContarPalabras(richTextBox1.Text);

            MessageBox.Show(Mostrar(richTextBox1.Text));
        }

        public void ContarPalabras(string texto)
        {
            string palabra;
            int indexPalabra = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == ' ' || i == texto.Length - 1)
                {
                    if (i == texto.Length - 1)
                    {
                        palabra = texto.Substring(indexPalabra, i + 1);
                    }
                    else
                    {
                        palabra = texto.Substring(indexPalabra, i + 1);
                    }


                    if (!ComprobarPalabra(palabra))
                    {
                        diccionario.Add(palabra, 1);
                        indexPalabra = i + 2; 
                    }
                    else
                    {
                        diccionario[palabra]++;
                    }
                }
            }
        }

        public bool ComprobarPalabra(string texto)
        {
            bool existe = false;

            foreach (KeyValuePair<string, int> elemento in diccionario)
            {

                if (elemento.Key == texto)
                {
                    existe = true;
                }
                else
                {
                    existe = false;
                }
            }
            return existe;
        }

        public string Mostrar(string texto)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0;
            string eliminar = "";

            //while (i < 3)
            //{
                foreach (KeyValuePair<string, int> elemento in diccionario)
                {
                    //if (diccionario.Values.Max() == elemento.Value && i < 3)
                    //{
                        //eliminar = elemento.Key;
                        sb.AppendLine($"{elemento.Key}: {elemento.Value}");
                        //break;
                    //}
                }

            /* if (diccionario.Remove(eliminar))
             {
                 i++;
             }*/
            //}
           // sb.AppendLine($"213");
            //sb.AppendLine($"214");

            return sb.ToString();
        }
    }
}
