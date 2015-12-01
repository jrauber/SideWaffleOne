using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wizard
{
    public partial class WizardForm : Form
    {
        public WizardForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            dpToday.Value = DateTime.Now;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Value = dpToday.Value;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public DateTime Value { get; set; }
    }
}
