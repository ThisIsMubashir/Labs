using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            var qry = from x in context.Movies select x;
           // var qry = context.Movies.ToList();
            List<Movy> clst = qry.ToList<Movy>();
            dataGridView1.DataSource = clst;
            //dataGridView1.DataSource = qry;
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            var qry = from x in context.Movies orderby x.MovieTitle select x;
            //var qry = context.Movies.OrderBy(x => x.MovieTitle).ToList();
            List<Movy> clst = qry.ToList<Movy>();
            dataGridView1.DataSource = clst;
            //dataGridView1.DataSource = qry;
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            //var qry = from x in context.Movies orderby x.RentalPrice descending select x;
            var qry = context.Movies.OrderByDescending(x => x.RentalPrice).ToList();
            //List<Movy> clst = qry.ToList<Movy>();
            //dataGridView1.DataSource = clst;
            dataGridView1.DataSource = qry;
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            var qry = from x in context.Movies where x.Rating=="R"  select x;
            //var qry = context.Movies.Where(x => x.Rating == "R").ToList();
            List<Movy> clst = qry.ToList<Movy>();
            dataGridView1.DataSource = clst;
            //dataGridView1.DataSource = qry;
        }

        private void btnEx5_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            //var qry = from x in context.Movies where x.ProducerID == "Warner" && x.MovieType=="Sci-fi" select x;
            var qry = context.Movies.Where(x => x.ProducerID == "Warner" && x.MovieType == "Sci-fi").ToList();
            //List<Movy> clst = qry.ToList<Movy>();
            //dataGridView1.DataSource = clst;
            dataGridView1.DataSource = qry;
        }

        private void btnEx6_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            var qry = (from x in context.Movies where x.MovieType == "Action" select x).Count().ToString();
            //var qry = context.Movies.Where(x => x.MovieType == "Action").Count().ToString();
            lblEx6Ans.Text = qry;
            lblEx6Ans.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEx7_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            //var qry = (from x in context.Movies where x.MovieType == "Action" select x).Sum(x=>x.TotalStock).ToString();
            var qry = context.Movies.Where(x => x.MovieType == "Action").Sum(x=> x.TotalStock).ToString();
            lblEx7Ans.Text = qry;
            lblEx7Ans.Visible = true;
            //dataGridView1.DataSource = qry.ToList();
        }

        private void btnEx8_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            var qry = (from x in context.Movies where x.MovieType == "Comedy" select x).Average(x=>x.RentalPrice).ToString();
            //var qry = context.Movies.Where(x => x.MovieType == "Comedy").Average(y=>y.RentalPrice).ToString();
            lblEx8Ans.Text = qry;
            lblEx8Ans.Visible = true;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            //var qry = from x in context.Movies where x.Rating == "R" select new { x.VideoCode, x.MovieTitle, x.RentalPrice};
            var qry = context.Movies.Where(x => x.Rating == "R").Select(o=>new { o.VideoCode, o.MovieTitle,o.RentalPrice});
            //List<Movy> clst = qry.ToList<Movy>();
            dataGridView1.DataSource = qry.ToList();
            //dataGridView1.DataSource = qry;
        }

        private void btnEx10_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            //var qry = from x in context.Movies group x by x.MovieType into g select new { Category = g.Key, TotalStock = g.Sum(Y => Y.TotalStock) };
            var qry = context.Movies.GroupBy(x => x.MovieType).Select(g=>new { Category = g.Key, TotalStock = g.Sum(Y => Y.TotalStock) });
            //lblEx7Ans.Text = qry;
            //lblEx7Ans.Visible = true;
            dataGridView1.DataSource = qry.ToList();
        }

        private void btnEx11_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            //var qry = from x in context.Movies where x.VideoCode == 5 select new { x.MovieTitle,x.Rating,x.Producer.ProducerName};
            var qry = context.Movies.Where(x => x.VideoCode == 5).Select(x=> new { x.MovieTitle, x.Rating,x.Producer.ProducerName });
            //lblEx7Ans.Text = qry;
            //lblEx7Ans.Visible = true;
            dataGridView1.DataSource = qry.ToList();
        }

        private void btnEx12_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            //var qry = from x in context.Movies where x.ProducerID == "Walt" select new { x.MovieTitle,x.MovieType,x.Producer.ProducerName};
            var qry = context.Movies.Where(x => x.ProducerID == "Walt").Select(x => new { x.MovieTitle,x.MovieType,x.Producer.ProducerName });
            dataGridView1.DataSource = qry.ToList();
        }

        private void btnEx13_Click(object sender, EventArgs e)
        {
            DafestyEntities context = new DafestyEntities();
            //var qry = from x in context.Movies select new { x.MovieTitle, x.MovieType, x.Producer.ProducerName };
            var qry = context.Movies.Select(x => new { x.MovieTitle,x.MovieType,x.Producer.ProducerName });
            dataGridView1.DataSource = qry.ToList();
        }
    }
}
