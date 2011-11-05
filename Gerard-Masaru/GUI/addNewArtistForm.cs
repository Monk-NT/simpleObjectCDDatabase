using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cddb.cddbDAO;

namespace cddb.GUI
{
    public partial class addNewArtistForm : Form
    {
        public addNewArtistForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SimpleAccessControl.getInstance().addArtist(tbArtist.Text);
            this.Close();
        }
    }
}
