using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EDM_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Reset() {
            tbVideoCode.Text = "";
            tbMovieTitle.Text = "";
            tbGenre.Text = "";
            tbRentalCost.Text = "";
        
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(tbFind.Text);
            DafestyEntities ctx = new DafestyEntities();
            Movie mv = ctx.Movies1.Where(x => x.VideoCode == code).First();
            tbMovieTitle.Text = mv.MovieTitle;
            tbGenre.Text = mv.Genre;
            tbVideoCode.Text = mv.VideoCode.ToString();
            tbRentalCost.Text = mv.RentalCost.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int code = Convert.ToInt32(tbVideoCode.Text);
            DafestyEntities ctx = new DafestyEntities();
            Movie mv = ctx.Movies1.Where(x => x.VideoCode == code).First();
            mv.MovieTitle = tbMovieTitle.Text;
            mv.Genre = tbGenre.Text;
            mv.RentalCost = float.Parse(tbRentalCost.Text);
            ctx.SaveChanges();
            MessageBox.Show("Update is successful");
            Reset();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DafestyEntities ctx = new DafestyEntities();
            Movie mv = new Movie();
            Producer pd = ctx.Producers.Where(x => x.ProducerID == "Warner").First();
            //int code = Convert.ToInt16(tbVideoCode.Text);
            mv.VideoCode = 400;
            mv.MovieTitle = "Sully";
            mv.Genre = "Darama";
            mv.ProducerID = pd.ProducerID;
            mv.RentalCost = 2.50f;
            mv.Rating = "U";
            mv.TotalStock = 4;
            ctx.Movies1.Add(mv);
            ctx.SaveChanges();
            MessageBox.Show("Record is successfully inserted");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DafestyEntities ctx = new DafestyEntities();
            Movie mv = ctx.Movies1.Where(x => x.VideoCode == 400).First();
            ctx.Movies1.Remove(mv);
            ctx.SaveChanges();
            MessageBox.Show("Successfully Deleted");
        }
    }
}
