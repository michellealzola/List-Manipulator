using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Manipulator
{
    public partial class MainForm : Form
    {
        List<int> orig = new List<int>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile = File.OpenText("random.txt");
                int num;

                while(!inputFile.EndOfStream)
                {
                    num = int.Parse(inputFile.ReadLine());
                    orig.Add(num);
                }

                inputFile.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach(int num in orig)
            {
                lBoxOrigList.Items.Add(num);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            orig.RemoveAll(num =>  num < 0);

            lBoxResults.Items.Clear();

            foreach(int num in orig)
            {
                lBoxResults.Items.Add(num);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> reults = orig.FindAll(num => num >= 0 && num <= 10);

            lBoxResults.Items.Clear();

            foreach(int num in reults)
            {
                lBoxResults.Items.Add(num);
            }

        }
    }
}
