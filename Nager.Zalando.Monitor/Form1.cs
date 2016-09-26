using Nager.Zalando.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nager.Zalando.Monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();

            var version = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = $"Nager - Zalando {version}";
        }

        private async void buttonGetArticle_Click(object sender, EventArgs e)
        {
            var zalandoWrapper = new ZalandoWrapper();

            var filter = new ArticleFilter();
            filter.AgeGroup = AgeGroup.Kids | AgeGroup.Babies;
            filter.Color = Color.Brown;

            var task = await zalandoWrapper.GetArticles(filter);

            this.dataGridView1.DataSource = task.Content;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView1.CurrentRow == null)
            {
                return;
            }

            if (this.dataGridView1.CurrentRow.DataBoundItem == null)
            {
                return;
            }

            var article = this.dataGridView1.CurrentRow.DataBoundItem as Article;
            this.propertyGrid1.SelectedObject = article.Brand;
            this.dataGridView2.DataSource = article.Media.Images;

            
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dataGridView2.CurrentRow == null)
            {
                return;
            }

            if (this.dataGridView2.CurrentRow.DataBoundItem == null)
            {
                return;
            }

            var image = this.dataGridView2.CurrentRow.DataBoundItem as Image;

            this.pictureBox1.ImageLocation = image.MediumUrl;
        }
    }
}
