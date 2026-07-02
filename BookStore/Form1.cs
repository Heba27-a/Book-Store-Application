using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class Form1 : Form
    {
        public ActionSection s1 = new ActionSection(SectionType.Action, 10);
        public ScienceFiction s2 = new ScienceFiction(SectionType.ScienceFiction, 10);
        public MentalHealth s3 = new MentalHealth(SectionType.MentalHealth, 10);
        public PoetrySection s4 = new PoetrySection(SectionType.Poetry, 10);
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(1000, 600);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            actionPictureBox.Image = Properties.Resources.Action;
            sciFiPictureBox.Image = Properties.Resources.Science_Fiction;
            MHPictureBox.Image = Properties.Resources.Mental_Health;
            poetryPictureBox.Image = Properties.Resources.Poetry;

        }
        private void actionPictureBox_Click(object sender, EventArgs e)
        {
            booksGroupBox.Visible = true;
            detailsGroupBox.Visible = false;
            bookLabel1.Text = s1.Books[0].Title;
            picture1.Image = Properties.Resources.الجزار;
            bookLabel2.Text = s1.Books[1].Title;
            picture2.Image = Properties.Resources.يوتوبيا;
            bookLabel3.Text = s1.Books[2].Title;
            picture3.Image = Properties.Resources.the_cold_storm;
            bookLabel4.Text = s1.Books[3].Title;
            picture4.Image = Properties.Resources.the_hunter;
            bookLabel5.Text = s1.Books[4].Title;
            picture5.Image = Properties.Resources.the_walk;
            bookLabel6.Text = s1.Books[5].Title;
            picture6.Image = Properties.Resources.the_hunger_games;
        }
        private void sciFiPictureBox_Click(object sender, EventArgs e)
        {
            booksGroupBox.Visible = true;
            detailsGroupBox.Visible = false;
            bookLabel1.Text = s2.Books[0].Title;
            picture1.Image = Properties.Resources.اخر_ليالي_البشر_;
            bookLabel2.Text = s2.Books[1].Title;
            picture2.Image = Properties.Resources.أرسس;
            bookLabel3.Text = s2.Books[2].Title;
            picture3.Image = Properties.Resources.ارض_بلا_ظل_;
            bookLabel4.Text = s2.Books[3].Title;
            picture4.Image = Properties.Resources.Neuromancer;
            bookLabel5.Text = s2.Books[4].Title;
            picture5.Image = Properties.Resources.city_of_stairs;
            bookLabel6.Text = s2.Books[5].Title;
            picture6.Image = Properties.Resources.Contact;
        }
        private void MHPictureBox_Click(object sender, EventArgs e)
        {
            booksGroupBox.Visible = true;
            detailsGroupBox.Visible = false;
            bookLabel1.Text = s3.Books[0].Title;
            picture1.Image = Properties.Resources.الألعاب_النفسية_;
            bookLabel2.Text = s3.Books[1].Title;
            picture2.Image = Properties.Resources.قوانين_التحرر_من_الصراع_النفسي;
            bookLabel3.Text = s3.Books[2].Title;
            picture3.Image = Properties.Resources.ممتلئ_بالفراغ;
            bookLabel4.Text = s3.Books[3].Title;
            picture4.Image = Properties.Resources.جلسات_نفسية;
            bookLabel5.Text = s3.Books[4].Title;
            picture5.Image = Properties.Resources.مفتقد_للحياة;
            bookLabel6.Text = s3.Books[5].Title;
            picture6.Image = Properties.Resources.الخروج_عن_النص;
        }
        private void poetryPictureBox_Click(object sender, EventArgs e)
        {
            booksGroupBox.Visible = true;
            detailsGroupBox.Visible = false;
            bookLabel1.Text = s4.Books[0].Title;
            picture1.Image = Properties.Resources.الشعر_العربي_الفصيح;
            bookLabel2.Text = s4.Books[1].Title;
            picture2.Image = Properties.Resources.لا_تعتذر_عما_فعلت_;
            bookLabel3.Text = s4.Books[2].Title;
            picture3.Image = Properties.Resources.الخنساء;
            bookLabel4.Text = s4.Books[3].Title;
            picture4.Image = Properties.Resources.الفجر_الأول_;
            bookLabel5.Text = s4.Books[4].Title;
            picture5.Image = Properties.Resources.الشعر_العربي;
            bookLabel6.Text = s4.Books[5].Title;
            picture6.Image = Properties.Resources.الصبر_كان_أيوب;
        }
        private void picture1_Click(object sender, EventArgs e)
        {
            if (bookLabel1.Text == s1.Books[0].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.الجزار;
                bookDetails.Text = s1.Books[0].BookInfo();
            }
            else if (bookLabel1.Text == s2.Books[0].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.اخر_ليالي_البشر_;
                bookDetails.Text = s2.Books[0].BookInfo();
            }
            else if (bookLabel1.Text == s3.Books[0].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.الألعاب_النفسية_;
                bookDetails.Text = s3.Books[0].BookInfo();
            }
            else if (bookLabel1.Text == s4.Books[0].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.الشعر_العربي_الفصيح;
                bookDetails.Text = s4.Books[0].BookInfo();
            }

        }
        private void picture2_Click(object sender, EventArgs e)
        {
            if (bookLabel2.Text == s1.Books[1].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.يوتوبيا;
                bookDetails.Text = s1.Books[1].BookInfo();
            }
            else if (bookLabel2.Text == s2.Books[1].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.أرسس;
                bookDetails.Text = s2.Books[1].BookInfo();
            }
            else if (bookLabel2.Text == s3.Books[1].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.قوانين_التحرر_من_الصراع_النفسي;
                bookDetails.Text = s3.Books[1].BookInfo();
            }
            else if (bookLabel2.Text == s4.Books[1].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.لا_تعتذر_عما_فعلت_;
                bookDetails.Text = s4.Books[1].BookInfo();
            }
        }

        private void picture3_Click(object sender, EventArgs e)
        {
            if (bookLabel3.Text == s1.Books[2].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.the_cold_storm;
                bookDetails.Text = s1.Books[2].BookInfo();
            }
            else if (bookLabel3.Text == s2.Books[2].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.ارض_بلا_ظل_;
                bookDetails.Text = s2.Books[2].BookInfo();
            }
            else if (bookLabel3.Text == s3.Books[2].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.ممتلئ_بالفراغ;
                bookDetails.Text = s3.Books[2].BookInfo();
            }
            else if (bookLabel3.Text == s4.Books[2].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.الخنساء;
                bookDetails.Text = s4.Books[2].BookInfo();
            }
        }

        private void picture4_Click(object sender, EventArgs e)
        {
            if (bookLabel4.Text == s1.Books[3].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.the_hunter;
                bookDetails.Text = s1.Books[3].BookInfo();
            }
            else if (bookLabel4.Text == s2.Books[3].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.Neuromancer;
                bookDetails.Text = s2.Books[3].BookInfo();
            }
            else if (bookLabel4.Text == s3.Books[3].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.جلسات_نفسية;
                bookDetails.Text = s3.Books[3].BookInfo();
            }
            else if (bookLabel4.Text == s4.Books[3].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.الفجر_الأول_;
                bookDetails.Text = s4.Books[3].BookInfo();
            }
        }

        private void picture5_Click(object sender, EventArgs e)
        {
            if (bookLabel5.Text == s1.Books[4].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.the_walk;
                bookDetails.Text = s1.Books[4].BookInfo();
            }
            else if (bookLabel5.Text == s2.Books[4].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.city_of_stairs;
                bookDetails.Text = s2.Books[4].BookInfo();
            }
            else if (bookLabel5.Text == s3.Books[4].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.مفتقد_للحياة;
                bookDetails.Text = s3.Books[4].BookInfo();
            }
            else if (bookLabel5.Text == s4.Books[4].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.الشعر_العربي;
                bookDetails.Text = s4.Books[4].BookInfo();
            }
        }

        private void picture6_Click(object sender, EventArgs e)
        {
            if (bookLabel6.Text == s1.Books[5].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.the_hunger_games;
                bookDetails.Text = s1.Books[5].BookInfo();
            }
            else if (bookLabel6.Text == s2.Books[5].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.Contact;
                bookDetails.Text = s2.Books[5].BookInfo();
            }
            else if (bookLabel6.Text == s3.Books[5].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.الخروج_عن_النص;
                bookDetails.Text = s3.Books[5].BookInfo();
            }
            else if (bookLabel6.Text == s4.Books[5].Title)
            {
                detailsGroupBox.Visible = true;
                DisplayPicture.Image = Properties.Resources.الصبر_كان_أيوب;
                bookDetails.Text = s4.Books[5].BookInfo();
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string userRecommend = RecommendTextBox.Text;
            string filePath = "Recommendation.txt";
            StreamWriter writer = new StreamWriter(filePath, true);
            try
            {
                writer.WriteLine(userRecommend);
                MessageBox.Show("تم إرسال اقتراحك");
                RecommendTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                writer.Close();
            }
        }

        private void bookLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}


