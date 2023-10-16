﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pertemuan9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double temp;
        char oper;
        bool oper1;
        private void Form1_Load(object sender, EventArgs e)
        {
            bersih();
            fokus();
        }
        private void fokus()
        {
            txthasil.Focus();
            txthasil.Select(txthasil.Text.Length,1);
        }
        private void bersih()
        {
            txthasil.Text = "0";
            txtinput.Text = "";
            temp = 0;
            oper = ' ';
            oper1 = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bersih();
            fokus();
        }
        private void btnAngka_Click(object sender, EventArgs e)
        {
            Button btnAng = (Button)sender;
            if (txthasil.Text == "0")
            {
                txthasil.Clear();
            }
            if (oper == '=')
            {
                oper = ' ';
                oper1 = false;
                temp = 0;
            }
            txthasil.Text = txthasil.Text + btnAng.Text;
            fokus();
        }
        private void btnOperator_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Berhasil");
            Button op = (Button)sender;
            if (oper1 == false)
            {
                if (txtinput.Text == "")
                {
                    temp = Convert.ToDouble(txthasil.Text);
                }
                else
                {
                    if (oper == '+')
                    {
                        temp = temp + Convert.ToDouble(txthasil.Text);   
                    }
                    else if (oper == '-')
                    {
                        temp = temp - Convert.ToDouble(txthasil.Text);
                    }
                    else if (oper == ':')
                    {
                        temp = temp / Convert.ToDouble(txthasil.Text);
                    }
                    else if (oper == 'X')
                    {
                        temp = temp * Convert.ToDouble(txthasil.Text);
                    }
                }
            }
            if(oper == '=')
            {
                txtinput.Text = "";
                txthasil.Text = temp.ToString();
            }
            else
            {
                txtinput.Text = temp.ToString() + op.Text;
                txthasil.Text = "0";
            }
            oper = Convert.ToChar(op.Text);
            fokus();
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            txthasil.Text = txthasil.Text.Remove(txthasil.Text.Length - 1);

            if (oper == '=')
            {
                temp = 0;
                oper1 = false;
                oper = ' ';
            }
            fokus() ;
        }

        private void txtinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void txthasil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
