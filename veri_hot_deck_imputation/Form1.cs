using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veri_hot_deck_imputation
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

        private void button1_Click(object sender, EventArgs e)
        {
            double d1d1 = Convert.ToDouble(listView1.Items[0].SubItems[1].Text);
            double d1d2 = Convert.ToDouble(listView1.Items[0].SubItems[2].Text);
            double d1d3 = Convert.ToDouble(listView1.Items[0].SubItems[3].Text);
            double d1d4 = Convert.ToDouble(listView1.Items[0].SubItems[4].Text);

            double d2d1 = Convert.ToDouble(listView1.Items[1].SubItems[1].Text);
            double d2d2 = Convert.ToDouble(listView1.Items[1].SubItems[2].Text);
            double d2d3 = Convert.ToDouble(listView1.Items[1].SubItems[3].Text);
            double d2d4 = Convert.ToDouble(listView1.Items[1].SubItems[4].Text);

            double d3d1 = Convert.ToDouble(listView1.Items[2].SubItems[1].Text);
            double d3d2 = Convert.ToDouble(listView1.Items[2].SubItems[2].Text);
            double d3d3 = Convert.ToDouble(listView1.Items[2].SubItems[3].Text);
            double d3d4 = Convert.ToDouble(listView1.Items[2].SubItems[4].Text);

            double d4d1 = Convert.ToDouble(listView1.Items[3].SubItems[1].Text);
            double d4d2 = Convert.ToDouble(listView1.Items[3].SubItems[2].Text);
            double d4d3 = Convert.ToDouble(listView1.Items[3].SubItems[3].Text);
            double d4d4 = Convert.ToDouble(listView1.Items[3].SubItems[4].Text);

            double d5d1 = Convert.ToDouble(listView1.Items[4].SubItems[1].Text);
            double d5d3 = Convert.ToDouble(listView1.Items[4].SubItems[3].Text);
            double d5d4 = Convert.ToDouble(listView1.Items[4].SubItems[4].Text);

            double d6d1 = Convert.ToDouble(listView1.Items[5].SubItems[1].Text);
            double d6d2 = Convert.ToDouble(listView1.Items[5].SubItems[2].Text);
            double d6d3 = Convert.ToDouble(listView1.Items[5].SubItems[3].Text);
            double d6d4 = Convert.ToDouble(listView1.Items[5].SubItems[4].Text);

            double d7d1 = Convert.ToDouble(listView1.Items[6].SubItems[1].Text);
            double d7d2 = Convert.ToDouble(listView1.Items[6].SubItems[2].Text);
            double d7d3 = Convert.ToDouble(listView1.Items[6].SubItems[3].Text);
            double d7d4 = Convert.ToDouble(listView1.Items[6].SubItems[4].Text);

            double d8d1 = Convert.ToDouble(listView1.Items[7].SubItems[1].Text);
            double d8d2 = Convert.ToDouble(listView1.Items[7].SubItems[2].Text);
            double d8d3 = Convert.ToDouble(listView1.Items[7].SubItems[3].Text);
            double d8d4 = Convert.ToDouble(listView1.Items[7].SubItems[4].Text);

            double d9d1 = Convert.ToDouble(listView1.Items[8].SubItems[1].Text);
            double d9d2 = Convert.ToDouble(listView1.Items[8].SubItems[2].Text);
            double d9d3 = Convert.ToDouble(listView1.Items[8].SubItems[3].Text);

            double[] kr = new double[10];
            double[] kr2 = new double[10];

            //durum5
            kr2[0] = Math.Abs((d5d1 - d1d1)) + Math.Abs((d5d3 - d1d3)) + Math.Abs((d5d4 - d1d4));

            kr2[1] = Math.Abs((d5d1 - d2d1)) + Math.Abs((d5d3 - d2d3)) + Math.Abs((d5d4 - d2d4));

            kr2[2] = Math.Abs((d5d1 - d3d1)) + Math.Abs((d5d3 - d3d3)) + Math.Abs((d5d4 - d3d4));

            kr2[3] = Math.Abs((d5d1 - d4d1)) + Math.Abs((d5d3 - d4d3)) + Math.Abs((d5d4 - d4d4));

            kr2[5] = Math.Abs((d5d1 - d6d1)) + Math.Abs((d5d3 - d6d3)) + Math.Abs((d5d4 - d6d4));

            kr2[6] = Math.Abs((d5d1 - d7d1)) + Math.Abs((d5d3 - d7d3)) + Math.Abs((d5d4 - d7d4));

            kr2[7] = Math.Abs((d5d1 - d8d1)) + Math.Abs((d5d3 - d8d3)) + Math.Abs((d5d4 - d8d4));


            //durum 9
            kr[0] = Math.Abs((d9d1 - d1d1)) + Math.Abs((d9d2 - d1d2)) + Math.Abs((d9d3 - d1d3));

            kr[1] = Math.Abs((d9d1 - d2d1)) + Math.Abs((d9d2 - d2d2)) + Math.Abs((d9d3 - d2d3));

            kr[2] = Math.Abs((d9d1 - d3d1)) + Math.Abs((d9d2 - d3d2)) + Math.Abs((d9d3 - d3d3));

            kr[3] = Math.Abs((d9d1 - d4d1)) + Math.Abs((d9d2 - d4d2)) + Math.Abs((d9d3 - d4d3));


            kr[5] = Math.Abs((d9d1 - d6d1)) + Math.Abs((d9d2 - d6d2)) + Math.Abs((d9d3 - d6d3));

            kr[6] = Math.Abs((d9d1 - d7d1)) + Math.Abs((d9d2 - d7d2)) + Math.Abs((d9d3 - d7d3));

            kr[7] = Math.Abs((d9d1 - d8d1)) + Math.Abs((d9d2 - d8d2)) + Math.Abs((d9d3 - d8d3));

            double min = kr[0];
            double ds = 0;

            double min2 = kr2[0];
            double ds2 = 0;

            if (listView1.Items[4].SubItems[2].Text == "")
            {
                for (int k = 0; k < 8; k++)
                {
                    if (kr[k] < min)
                    {
                        if (kr[k] == kr[4])
                        {
                        }
                        else
                        {
                            min = kr[k];
                            ds = k;
                        }
                    }
                }
            }
            else
            {
                double d5d2 = Convert.ToDouble(listView1.Items[4].SubItems[2].Text);
                kr[4] = Math.Abs((d9d1 - d5d1)) + Math.Abs((d9d2 - d5d2)) + Math.Abs((d9d3 - d5d3));
                for (int k = 0; k < 8; k++)
                {
                    if (kr[k] < min)
                    {
                        min = kr[k];
                        ds = k;
                    }
                }
            }

            if (listView1.Items[8].SubItems[4].Text == "")
            {
                for (int j = 0; j < 8; j++)
                {
                    if (kr2[j] < min)
                    {
                        if (kr2[j] == kr2[4])
                        {
                        }
                        else
                        {
                            min2 = kr2[j];
                            ds2 = j;
                        }
                    }
                }
            }
            else
            {
                double d9d4 = Convert.ToDouble(listView1.Items[8].SubItems[4].Text);
                kr2[8] = Math.Abs((d5d1 - d9d1)) + Math.Abs((d5d3 - d9d3)) + Math.Abs((d5d4 - d9d4));

                for (int i = 0; i < 10; i++)
                {
                    if (kr2[i] < min)
                    {
                        if (kr2[i] == kr2[4])
                        {
                        }
                        else
                        {
                            min2 = kr2[i];
                            ds2 = i;
                        }
                    }

                }
            }


                if (listView1.Items[4].SubItems[2].Text == "")
                {

                    if (ds2 == 0)
                    {
                        MessageBox.Show("5 Numaralı durum 1 numaralı duruma göre tamamlanıyor");
                        listView1.Items[4].SubItems[2].Text = d1d2.ToString();


                    }
                    if (ds2 == 1)
                    {
                        MessageBox.Show("5 Numaralı durum 2 numaralı duruma göre tamamlanıyor");
                        listView1.Items[4].SubItems[2].Text = d2d2.ToString();

                    }
                    if (ds2 == 2)
                    {
                        MessageBox.Show("5 Numaralı durum 3 numaralı duruma göre tamamlanıyor");
                        listView1.Items[4].SubItems[2].Text = d3d2.ToString();

                    }
                    if (ds2 == 3)
                    {
                        MessageBox.Show("5 Numaralı durum 4 numaralı duruma göre tamamlanıyor");
                        listView1.Items[4].SubItems[2].Text = d4d2.ToString();

                    }
                    if (ds2 == 5)
                    {
                        MessageBox.Show("5 Numaralı durum 6 numaralı duruma göre tamamlanıyor");
                        listView1.Items[4].SubItems[2].Text = d6d2.ToString();

                    }
                    if (ds2 == 6)
                    {
                        MessageBox.Show("5 Numaralı durum 7 numaralı duruma göre tamamlanıyor");
                        listView1.Items[4].SubItems[2].Text = d7d2.ToString();

                    }
                    if (ds2 == 7)
                    {
                        MessageBox.Show("5 Numaralı durum 8 numaralı duruma göre tamamlanıyor");
                        listView1.Items[4].SubItems[2].Text = d8d2.ToString();

                    }
                    if (ds2 == 8)
                    {
                        MessageBox.Show("5 Numaralı durum 9 numaralı duruma göre tamamlanıyor");
                        listView1.Items[4].SubItems[2].Text = d9d2.ToString();
                    }

                }
                else
                {

                }

                if (listView1.Items[8].SubItems[4].Text == "")
                {
                    if (ds == 0)
                    {
                        MessageBox.Show("9 Numaralı durum 1 numaralı duruma göre tamamlanıyor");
                        listView1.Items[8].SubItems[4].Text = d1d4.ToString();

                    }
                    if (ds == 1)
                    {
                        MessageBox.Show("9 Numaralı durum 2 numaralı duruma göre tamamlanıyor");
                        listView1.Items[8].SubItems[4].Text = d2d4.ToString();

                    }
                    if (ds == 2)
                    {
                        MessageBox.Show("9 Numaralı durum 3 numaralı duruma göre tamamlanıyor");
                        listView1.Items[8].SubItems[4].Text = d3d4.ToString();

                    }
                    if (ds == 3)
                    {
                        MessageBox.Show("9 Numaralı durum 4 numaralı duruma göre tamamlanıyor");
                        listView1.Items[8].SubItems[4].Text = d4d4.ToString();

                    }
                    if (ds == 4)
                    {
                        MessageBox.Show("9 Numaralı durum 5 numaralı duruma göre tamamlanıyor");
                        listView1.Items[8].SubItems[4].Text = d5d4.ToString();

                    }
                    if (ds == 5)
                    {
                        MessageBox.Show("9 Numaralı durum 6 numaralı duruma göre tamamlanıyor");
                        listView1.Items[8].SubItems[4].Text = d6d4.ToString();

                    }
                    if (ds == 6)
                    {
                        MessageBox.Show("9 Numaralı durum 7 numaralı duruma göre tamamlanıyor");
                        listView1.Items[8].SubItems[4].Text = d7d4.ToString();

                    }
                    if (ds == 7)
                    {
                        MessageBox.Show("9 Numaralı durum 8 numaralı duruma göre tamamlanıyor");
                        listView1.Items[8].SubItems[4].Text = d8d4.ToString();

                    }

                }
                else
                {
                }


            }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double d1d1 = Convert.ToDouble(listView1.Items[0].SubItems[1].Text);
            double d1d2 = Convert.ToDouble(listView1.Items[0].SubItems[2].Text);
            double d1d3 = Convert.ToDouble(listView1.Items[0].SubItems[3].Text);
            double d1d4 = Convert.ToDouble(listView1.Items[0].SubItems[4].Text);

            double d2d1 = Convert.ToDouble(listView1.Items[1].SubItems[1].Text);
            double d2d2 = Convert.ToDouble(listView1.Items[1].SubItems[2].Text);
            double d2d3 = Convert.ToDouble(listView1.Items[1].SubItems[3].Text);
            double d2d4 = Convert.ToDouble(listView1.Items[1].SubItems[4].Text);

            double d3d1 = Convert.ToDouble(listView1.Items[2].SubItems[1].Text);
            double d3d2 = Convert.ToDouble(listView1.Items[2].SubItems[2].Text);
            double d3d3 = Convert.ToDouble(listView1.Items[2].SubItems[3].Text);
            double d3d4 = Convert.ToDouble(listView1.Items[2].SubItems[4].Text);

            double d4d1 = Convert.ToDouble(listView1.Items[3].SubItems[1].Text);
            double d4d2 = Convert.ToDouble(listView1.Items[3].SubItems[2].Text);
            double d4d3 = Convert.ToDouble(listView1.Items[3].SubItems[3].Text);
            double d4d4 = Convert.ToDouble(listView1.Items[3].SubItems[4].Text);

            double d5d1 = Convert.ToDouble(listView1.Items[4].SubItems[1].Text);
            double d5d3 = Convert.ToDouble(listView1.Items[4].SubItems[3].Text);
            double d5d4 = Convert.ToDouble(listView1.Items[4].SubItems[4].Text);

            double d6d1 = Convert.ToDouble(listView1.Items[5].SubItems[1].Text);
            double d6d2 = Convert.ToDouble(listView1.Items[5].SubItems[2].Text);
            double d6d3 = Convert.ToDouble(listView1.Items[5].SubItems[3].Text);
            double d6d4 = Convert.ToDouble(listView1.Items[5].SubItems[4].Text);

            double d7d1 = Convert.ToDouble(listView1.Items[6].SubItems[1].Text);
            double d7d2 = Convert.ToDouble(listView1.Items[6].SubItems[2].Text);
            double d7d3 = Convert.ToDouble(listView1.Items[6].SubItems[3].Text);
            double d7d4 = Convert.ToDouble(listView1.Items[6].SubItems[4].Text);

            double d8d1 = Convert.ToDouble(listView1.Items[7].SubItems[1].Text);
            double d8d2 = Convert.ToDouble(listView1.Items[7].SubItems[2].Text);
            double d8d3 = Convert.ToDouble(listView1.Items[7].SubItems[3].Text);
            double d8d4 = Convert.ToDouble(listView1.Items[7].SubItems[4].Text);

            double d9d1 = Convert.ToDouble(listView1.Items[8].SubItems[1].Text);
            double d9d2 = Convert.ToDouble(listView1.Items[8].SubItems[2].Text);
            double d9d3 = Convert.ToDouble(listView1.Items[8].SubItems[3].Text);


            int sayi = Convert.ToInt16(comboBox1.SelectedItem);
            if (sayi == 1)
            {
                textBox1.Text = d1d1.ToString();
                textBox2.Text = d1d2.ToString();
                textBox3.Text = d1d3.ToString();
                textBox4.Text = d1d4.ToString();
            }
            if (sayi == 2)
            {
                textBox1.Text = d2d1.ToString();
                textBox2.Text = d2d2.ToString();
                textBox3.Text = d2d3.ToString();
                textBox4.Text = d2d4.ToString();
            }
            if (sayi == 3)
            {
                textBox1.Text = d3d1.ToString();
                textBox2.Text = d3d2.ToString();
                textBox3.Text = d3d3.ToString();
                textBox4.Text = d3d4.ToString();
            }
            if (sayi == 4)
            {
                textBox1.Text = d4d1.ToString();
                textBox2.Text = d4d2.ToString();
                textBox3.Text = d4d3.ToString();
                textBox4.Text = d4d4.ToString();
            }
            if (sayi == 5)
            {
                textBox1.Text = d5d1.ToString();
                if (listView1.Items[4].SubItems[2].Text == "")
                    textBox2.Text = "";
                else
                    textBox2.Text = listView1.Items[4].SubItems[2].Text;
                textBox3.Text = d5d3.ToString();
                textBox4.Text = d5d4.ToString();
            }
            if (sayi == 6)
            {
                textBox1.Text = d6d1.ToString();
                textBox2.Text = d6d2.ToString();
                textBox3.Text = d6d3.ToString();
                textBox4.Text = d6d4.ToString();
            }
            if (sayi == 7)
            {
                textBox1.Text = d7d1.ToString();
                textBox2.Text = d7d2.ToString();
                textBox3.Text = d7d3.ToString();
                textBox4.Text = d7d4.ToString();
            }
            if (sayi == 8)
            {
                textBox1.Text = d8d1.ToString();
                textBox2.Text = d8d2.ToString();
                textBox3.Text = d8d3.ToString();
                textBox4.Text = d8d4.ToString();
            }
            if (sayi == 9)
            {
                textBox1.Text = d9d1.ToString();
                textBox2.Text = d9d2.ToString();
                textBox3.Text = d9d3.ToString();
                if (listView1.Items[8].SubItems[4].Text == "")
                    textBox4.Text = "";
                else
                    textBox4.Text = listView1.Items[8].SubItems[4].Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(comboBox1.SelectedItem);
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Bir değer girmelisiniz");
            }
            else
            {
                if (sayi == 1)
                {
                    listView1.Items[0].SubItems[1].Text = textBox1.Text;
                    listView1.Items[0].SubItems[2].Text = textBox2.Text;
                    listView1.Items[0].SubItems[3].Text = textBox3.Text;
                    listView1.Items[0].SubItems[4].Text = textBox4.Text;
                }
                if (sayi == 2)
                {
                    listView1.Items[1].SubItems[1].Text = textBox1.Text;
                    listView1.Items[1].SubItems[2].Text = textBox2.Text;
                    listView1.Items[1].SubItems[3].Text = textBox3.Text;
                    listView1.Items[1].SubItems[4].Text = textBox4.Text;
                }
                if (sayi == 3)
                {
                    listView1.Items[2].SubItems[1].Text = textBox1.Text;
                    listView1.Items[2].SubItems[2].Text = textBox2.Text;
                    listView1.Items[2].SubItems[3].Text = textBox3.Text;
                    listView1.Items[2].SubItems[4].Text = textBox4.Text;
                }
                if (sayi == 4)
                {
                    listView1.Items[3].SubItems[1].Text = textBox1.Text;
                    listView1.Items[3].SubItems[2].Text = textBox2.Text;
                    listView1.Items[3].SubItems[3].Text = textBox3.Text;
                    listView1.Items[3].SubItems[4].Text = textBox4.Text;
                }
                if (sayi == 5)
                {
                    listView1.Items[4].SubItems[1].Text = textBox1.Text;
                    listView1.Items[4].SubItems[2].Text = textBox2.Text;
                    listView1.Items[4].SubItems[3].Text = textBox3.Text;
                    listView1.Items[4].SubItems[4].Text = textBox4.Text;
                }
                if (sayi == 6)
                {
                    listView1.Items[5].SubItems[1].Text = textBox1.Text;
                    listView1.Items[5].SubItems[2].Text = textBox2.Text;
                    listView1.Items[5].SubItems[3].Text = textBox3.Text;
                    listView1.Items[5].SubItems[4].Text = textBox4.Text;
                }
                if (sayi == 7)
                {
                    listView1.Items[6].SubItems[1].Text = textBox1.Text;
                    listView1.Items[6].SubItems[2].Text = textBox2.Text;
                    listView1.Items[6].SubItems[3].Text = textBox3.Text;
                    listView1.Items[6].SubItems[4].Text = textBox4.Text;
                }
                if (sayi == 8)
                {
                    listView1.Items[7].SubItems[1].Text = textBox1.Text;
                    listView1.Items[7].SubItems[2].Text = textBox2.Text;
                    listView1.Items[7].SubItems[3].Text = textBox3.Text;
                    listView1.Items[7].SubItems[4].Text = textBox4.Text;
                }
                if (sayi == 9)
                {
                    listView1.Items[8].SubItems[1].Text = textBox1.Text;
                    listView1.Items[8].SubItems[2].Text = textBox2.Text;
                    listView1.Items[8].SubItems[3].Text = textBox3.Text;
                    listView1.Items[8].SubItems[4].Text = textBox4.Text;
                }
            }
        }




    }
}

