using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace StringCounter
{
    public partial class StringCounter : Form
    {

        private string LongString = "";
        private string KeyWord = "";
        private int _Count;
        private int lastind = -1;
        //private int firstIndex;
        //private int lastIndex;
        Search sc = new Search();

        public StringCounter()
        {
            InitializeComponent();
        }

        private void LongStringBox_TextChanged(object sender, EventArgs e)
        {
            LongString = LongStringBox.Text;
        }

        private void SearchKeywordBox_TextChanged(object sender, EventArgs e)
        {
            KeyWord = SearchKeywordBox.Text;
        }
        private void Search_Click(object sender, EventArgs e)
        {
            
            try
            {
                _Count = sc.WordCount(LongString, KeyWord);
                CounterBox.Text = Convert.ToString(_Count);
            }
            catch (Exception E )
            {
                MessageBox.Show("Something is missing!" + E.Message, "Missing Value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                
                //MessageBox.Show("Something is missing!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int i;
            i = LongStringBox.Text.IndexOf(SearchKeywordBox.Text , lastind + 1);
            lastind = i;
            CounterBox.Text = i.ToString();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt Files|*.txt";


            if
             (dialog.ShowDialog() == DialogResult.OK)
            {
                string texts = File.ReadAllText(dialog.FileName);
                LongStringBox.Text = texts;
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            LongStringBox.Text = null;
            CounterBox.Text = null;
            SearchKeywordBox.Text = null;
        }
    }
}
