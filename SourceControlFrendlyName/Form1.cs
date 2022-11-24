using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceControlFrendlyName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _input_TextChanged(object sender, EventArgs e)
        {
            _output.Text = PrepareString(_input.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText(TextDataFormat.Text))
            {
                _input.Text = Clipboard.GetText(TextDataFormat.Text);
            }
        }

        private string PrepareString(string input)
        {
            Regex re = new Regex("[^a-zA-Z0-9\\n]", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            return re.Replace(input, "_");
        }
    }
}
