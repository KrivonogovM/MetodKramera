﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metodkramera
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        double b11, b12, b13, b14, b21, b22, b23, b24, b31, b32, b33, b34, det1, det2, det3, det4, detx, detx1, detx2;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            {


                b11 = Convert.ToInt32(a11.Text);
                b12 = Convert.ToInt32(a12.Text);
                b13 = Convert.ToInt32(a13.Text);
                b14 = Convert.ToInt32(a14.Text);
                b21 = Convert.ToInt32(a21.Text);
                b22 = Convert.ToInt32(a22.Text);
                b23 = Convert.ToInt32(a23.Text);
                b24 = Convert.ToInt32(a24.Text);
                b31 = Convert.ToInt32(a31.Text);
                b32 = Convert.ToInt32(a32.Text);
                b33 = Convert.ToInt32(a33.Text);
                b34 = Convert.ToInt32(a34.Text);
               


                det1 = b11 * b22 * b33 + b12 * b23 * b31 + b21 * b32 * b13 - b13 * b22 * b31 - b21 * b12 * b33 - b32 * b23 * b11;
                
               

                        
                }

                if (det1 == 0)
                {
                    MessageBox.Show(
                        "Определитель = 0",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly
                        );
                }
                else
                {
                    det2 = b14 * b22 * b33 + b24 * b32 * b13 + b12 * b23 * b34 - b13 * b22 * b34 - b24 * b12 * b33 - b32 * b23 * b14;
                    det3 = b11 * b24 * b33 + b21 * b34 * b13 + b14 * b23 * b31 - b13 * b24 * b31 - b21 * b14 * b33 - b34 * b23 * b11;
                    det4 = b11 * b22 * b34 + b21 * b32 * b14 + b12 * b24 * b31 - b14 * b22 * b31 - b21 * b12 * b34 - b32 * b24 * b11;

                    detx = det2 / det1;
                    detx1 = det3 / det1;
                    detx2 = det4 / det1;
                    Result.Text = Convert.ToString(det1);
                    Result1.Text = Convert.ToString(det2);
                    Result2.Text = Convert.ToString(det3);
                    Result3.Text = Convert.ToString(det4);
                    x1.Text = Convert.ToString(detx);
                    x2.Text = Convert.ToString(detx1);
                    x3.Text = Convert.ToString(detx2);
                }



            }
        }
    }


