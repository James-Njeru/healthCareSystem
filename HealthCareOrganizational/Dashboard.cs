using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCareOrganizational
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void billToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bill a = new Bill();
            a.Visible = true;
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Doctor a = new Doctor();
            a.Visible = true;
        }

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Patient a = new Patient();
            a.Visible = true;
        }

        private void wardBoyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WardBoy a = new WardBoy();
            a.Visible = true;
        }

        private void nurseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nurse a = new Nurse();
            a.Visible = true;
        }
    }
}
