using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cddb.cddbDAO;
using cddb.Model;


namespace cddb.GUI
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {

            
            InitializeComponent();
            populateDataGrid();
            
        }

        private void populateDataGrid()
        {
            lwMain.Items.Clear();
            List<Artist> artists = SimpleAccessControl.getInstance().listArtistsAndAlbums();
            foreach(Artist artist in artists)
                foreach (Album album in artist.Albums)
                {
                    ListViewItem item = new ListViewItem(artist.ToString());
                    item.SubItems.Add(album.CdName);
                    item.SubItems.Add(album.CdYear);
                    lwMain.Items.Add(item);
                    
                }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNewArtistForm f = new addNewArtistForm();
            f.Show();
     
        }

       
       }

       
    }
