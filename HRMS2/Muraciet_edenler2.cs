using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS2
{
    public partial class Muraciet_edenler2 : Form
    {
        public Muraciet_edenler2()
        {
            InitializeComponent();
        }

        private void Muraciet_edenler2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRMSystemDataSet5.Muraciet1' table. You can move, or remove it, as needed.
            this.muraciet1TableAdapter.Fill(this.hRMSystemDataSet5.Muraciet1);

        }
    }
}
