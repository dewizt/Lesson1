using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Занят");
            comboBox1.Items.Add("Свободен");
            comboBox1.Items.Add("");
            
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void button1_Click(object sender, EventArgs e)
        {
            Parallel.Invoke(

                () =>
                {
                    if (comboBox1.Text == "Занят")
                    {
                        listBox2.Items.Add("Свободен");
                    }
                    if (comboBox1.Text == "Свободен")
                    {
                        listBox2.Items.Add("Занят");
                    }
                    if (comboBox1.Text == "")
                    {
                        listBox2.Items.Add("Статус не был задан");
                    }

                },
                () =>
                {
                    listBox1.Items.Add(textBox1.Text);
                }
                );
            
        }

        void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
