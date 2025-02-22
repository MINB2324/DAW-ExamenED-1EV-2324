﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenED1EV2324
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Función que realiza una división entera mediante restas sucesivas.
        // Contamos cuantas veces "cabe" el dividendo en el divisor.
        int divisionRestas(int MINB2324dividendo, int MINB2324divisor)
        {
            // Declaramos una variable para almacenar el resultado.
            int cont = 0;

            // Restamos el divisor al dividendo
            //
            for (int i =MINB2324divisor; i<MINB2324dividendo; i++)
            {
                    int resultado = MINB2324dividendo - MINB2324divisor;
                    cont++;
            }

            // Devolvemos el resultado.
            return cont;
        }

        // Evento que se llama al pulsar el botón "Dividir".
        private void btDividir_Click(object sender, EventArgs e)
        {
            try
            {
                // Declaramos las variables necesarias.
                int MINB2324dividendo, MINB2324divisor, resultado;

                // Leemos los valores del cuadro de texto.
                MINB2324dividendo = int.Parse(txtDividendo.Text);
                MINB2324divisor = int.Parse(txtDivisor.Text);

                // Comprobamos que el divisor no sea cero.
                if (MINB2324divisor == 0)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisor no puede ser cero.");
                }
                // Comprobamos que el divisor no sea mayor que el dividendo.
                if (MINB2324dividendo < MINB2324divisor)
                {
                    // Lanzamos una excepción.
                    throw new Exception("El divisor no es menor o igual que el dividendo.");
                }

                // Llamamos a la función para realizar la división.
                resultado = divisionRestas(MINB2324dividendo, MINB2324divisor);

                // Mostramos el resultado.
                MessageBox.Show("El resultado de dividir " + MINB2324dividendo + " entre " + MINB2324divisor + " es : " + resultado);
            }
            catch (FormatException ex)
            {
                // Capturamos la excepción de formato incorrecto.
                MessageBox.Show("Error de formato: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Capturamos cualquier otra excepción.
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}