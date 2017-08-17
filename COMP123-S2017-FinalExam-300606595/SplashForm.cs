using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2017_FinalExam_300606595
{
    public partial class SplashForm : Form
    {
        private PickHighestCardForm _pickHighestCardForm;
        public PickHighestCardForm PickHighestCardForm
        {
            get
            {
                return Program.pickHighestCardForm;
            }
        }
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.PickHighestCardForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }
    }
}
