using Nager.Zalando.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridViewImages.AutoGenerateColumns = false;

            this.comboBoxColor.DataSource = (new object[] { DBNull.Value }.Concat(Enum.GetValues(typeof(Color)).Cast<object>())).ToList();
            this.comboBoxAgeGroup.DataSource = (new object[] { DBNull.Value }.Concat(Enum.GetValues(typeof(AgeGroup)).Cast<object>())).ToList();
            this.comboBoxGender.DataSource = (new object[] { DBNull.Value }.Concat(Enum.GetValues(typeof(Gender)).Cast<object>())).ToList();

            this.pictureBoxProduct.InitialImage = ImageHelper.GetImage("loading...");
            this.pictureBoxLogo.InitialImage = ImageHelper.GetImage("loading...");
        }

        private async void buttonGetArticle_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = null;
            this.buttonGetArticle.Enabled = false;

            try
            {
                var zalandoWrapper = new ZalandoWrapper();

                var filter = new ArticleFilter();
                //filter.AgeGroup = AgeGroup.Kids | AgeGroup.Babies;
                filter.AgeGroup = this.comboBoxAgeGroup.SelectedItem as AgeGroup?;
                filter.Color = this.comboBoxColor.SelectedItem as Color?;
                filter.FullText = this.textBoxFullText.Text;
                filter.Gender = this.comboBoxGender.SelectedItem as Gender?;

                var task = await zalandoWrapper.GetArticles(filter);

                this.dataGridView1.DataSource = task.Content;
            }
            catch (Exception exception)
            {

            }

            this.buttonGetArticle.Enabled = true;
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
            if (article == null)
            {
                return;
            }

            this.textBoxId.Text = article.Id;
            this.textBoxModelId.Text = article.ModelId;
            this.textBoxShopUrl.Text = article.ShopUrl;

            if (article.Brand != null)
            {
                this.pictureBoxLogo.ImageLocation = article.Brand.LogoUrl;
            }

            this.dataGridViewImages.DataSource = article.Media.Images;
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            this.pictureBoxProduct.Image = null;

            if (this.dataGridViewImages.CurrentRow == null)
            {
                return;
            }

            if (this.dataGridViewImages.CurrentRow.DataBoundItem == null)
            {
                return;
            }

            var image = this.dataGridViewImages.CurrentRow.DataBoundItem as Image;
            if (image == null)
            {
                return;
            }

            this.pictureBoxProduct.ImageLocation = image.LargeHdUrl;
        }
    }
}
