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
    }
}
