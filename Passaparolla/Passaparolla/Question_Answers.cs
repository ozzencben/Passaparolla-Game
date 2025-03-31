using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparolla
{
    public partial class Question_Answers : Form
    {
        public Question_Answers()
        {
            InitializeComponent();
        }
        string QuestionA = string.Empty;
        string AnswerA = string.Empty;
        Button myBtn = new Button();

        public void answerControl()
        {
            if(AnswerA == AnswertextBox.Text)
            {
                myBtn.BackColor = Color.Green;
            } else if(AnswertextBox.Text != null && AnswerA != AnswertextBox.Text)
            {
                myBtn.BackColor = Color.Red;
            }
            myBtn.Enabled = false;
        }



        private void Abutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Hangi kıta yüzölçümü bakımından dünyanın en büyüğüdür?";
            richTextBox.Text = QuestionA;
            myBtn = Abutton;
            AnswerA = "asya";
        }

        private void Replybutton_Click(object sender, EventArgs e)
        {
            answerControl();
            AnswertextBox.Clear();
        }

        private void Bbutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Avrupa kıtasının güneydoğu kesiminde yer alan ve Türkiye'nin de bir bölümünün dahil olduğu coğrafi bölgeye ne ad verilir?";
            richTextBox.Text = QuestionA;
            myBtn = Bbutton;
            AnswerA = "balkanlar";
        }

        private void Cbutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Bir şeyin veya bir durumun hoşa giden, çekici ve güzel görünmesine ne ad verilir?";
            richTextBox.Text = QuestionA;
            myBtn = Cbutton;
            AnswerA = "cazibe";
        }

        private void Dbutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Bir şeyin veya bir durumun zaman içinde yavaş yavaş kötüleşmesi, azalması veya etkisini kaybetmesi sürecine ne ad verilir?";
            richTextBox.Text = QuestionA;
            myBtn = Dbutton;
            AnswerA = "dejenerasyon";
        }

        private void Ebutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Bir kişinin veya bir grubun belirli bir amaca ulaşmak için gösterdiği bilinçli ve planlı çabaya ne ad verilir?";
            richTextBox.Text = QuestionA;
            myBtn = Ebutton;
            AnswerA = "eylem";
        }

        private void Fbutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Türkiye'de en çok Karadeniz Bölgesi'nde yetiştirilen bir tarım ürünüdür.";
            richTextBox.Text = QuestionA;
            myBtn = Fbutton;
            AnswerA = "fındık";
        }

        private void Gbutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Bir canlının genetik yapısını oluşturan ve nesilden nesile aktarılan temel birimlere ne ad verilir?";
            richTextBox.Text = QuestionA;
            myBtn = Gbutton;
            AnswerA = "gen";
        }

        private void Hbutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Hastalıkların yayılmasını önlemek ve sağlığı korumak amacıyla yapılan temizlik uygulamalarının genel adına ne denir?";
            richTextBox.Text = QuestionA;
            myBtn = Hbutton;
            AnswerA = "hijyen";
        }

        private void Ibutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Batı Karadeniz Bölgesi'nde yer alan ve hem milli park hem de önemli bir kayak merkezi olan dağ silsilesinin adı nedir?";
            richTextBox.Text = QuestionA;
            myBtn = Ibutton;
            AnswerA = "ılgaz";
        }

        private void İbutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Böcek larvalarının salgıladığı bir proteinden elde edilen, parlak ve yumuşak dokusuyla bilinen doğal tekstil lifi hangisidir?";
            richTextBox.Text = QuestionA;
            myBtn = İbutton;
            AnswerA = "ipek";
        }

        private void Jbutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Tahta blokların üst üste dizilerek oluşturulduğu ve oyuncuların sırayla birer blok çekerek kuleyi devirmeden oyunu sürdürmeye çalıştığı popüler denge oyunu hangisidir?";
            richTextBox.Text = QuestionA;
            myBtn = Jbutton;
            AnswerA = "jenga";
        }

        private void Kbutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Güney Amerika kökenli, besin değeri yüksek, glutensiz bir tahıl benzeri tohum olup genellikle salatalarda kullanılan besin maddesi nedir?";
            richTextBox.Text = QuestionA;
            myBtn = Kbutton;
            AnswerA = "kinoa";
        }

        private void Lbutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Antik çağda Anadolu'nun güneybatısında yer alan, kaya mezarları ve özgün mimarisiyle bilinen medeniyet ve bölgeye verilen ad nedir?";
            richTextBox.Text = QuestionA;
            myBtn = Lbutton;
            AnswerA = "likya";
        }

        private void Mbutton_Click(object sender, EventArgs e)
        {
            QuestionA = "18. yüzyılda yaşamış, dahi olarak kabul edilen Avusturyalı besteci ve piyanist kimdir?";
            richTextBox.Text = QuestionA;
            myBtn = Mbutton;
            AnswerA = "mozart";
        }

        private void Nbutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Atom numarası 28 ve sembolü 'Ni' olan, gümüş beyazı renkte, ferromanyetik bir metal element hangisidir?";
            richTextBox.Text = QuestionA;
            myBtn = Nbutton;
            AnswerA = "nikel";
        }

        private void Obutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Çok çeşitli türleri bulunan, genellikle gösterişli ve egzotik çiçeklere sahip, bazı türleri epifit olarak ağaçlar üzerinde yetişebilen bitki familyası hangisidir?";
            richTextBox.Text = QuestionA;
            myBtn = Obutton;
            AnswerA = "orkide";
        }

        private void Pbutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Dünya nüfusunun büyük bir bölümü için temel besin kaynağı olan, sulak alanlarda yetişen bir tahıl türü hangisidir?";
            richTextBox.Text = QuestionA;
            myBtn = Pbutton;
            AnswerA = "pirinç";
        }

        private void Rbutton_Click(object sender, EventArgs e)
        {
            QuestionA = "14. yüzyılda İtalya'da başlayıp Avrupa'ya yayılan, bilim, sanat ve düşünce alanlarında büyük gelişmelerin yaşandığı tarihi dönem hangisidir?";
            richTextBox.Text = QuestionA;
            myBtn = Rbutton;
            AnswerA = "rönesans";
        }

        private void Sbutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Mezopotamya'da MÖ 4. binyılda ortaya çıkan ve yazıyı ilk kullanan medeniyet olarak bilinen halk hangisidir?";
            richTextBox.Text = QuestionA;
            myBtn = Sbutton;
            AnswerA = "sümerler";
        }

        private void Ubutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Kapadokya bölgesinde bulunan, en yüksek noktası üzerinde bir kale barındıran ve panoramik manzarasıyla ünlü yerleşim yeri hangisidir?";
            richTextBox.Text = QuestionA;
            myBtn = Ubutton;
            AnswerA = "uçhisar";
        }

        private void Vbutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Avusturya'nın başkenti olan ve tarihi boyunca önemli bir kültür ve sanat merkezi olmuş şehir hangisidir?";
            richTextBox.Text = QuestionA;
            myBtn = Vbutton;
            AnswerA = "viyana";
        }

        private void Ybutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Geleneksel olarak göçebe veya yarı göçebe bir yaşam tarzı süren, genellikle Toros Dağları ve çevresinde yaşayan Türk halkına verilen ad nedir?";
            richTextBox.Text = QuestionA;
            myBtn = Ybutton;
            AnswerA = "yörük";
        }

        private void Zbutton_Click(object sender, EventArgs e)
        {
            QuestionA = "Parlak yeşil renkte olan ve değerli bir mücevher taşı olarak bilinen beril mineralinin bir türü nedir?";
            richTextBox.Text = QuestionA;
            myBtn = Zbutton;
            AnswerA = "zümrüt";
        }
        public async Task StartCountdownAsync(int minutes)
        {
            int totalSeconds = minutes * 60;
            while (totalSeconds > 0)
            {
                TimeSpan time = TimeSpan.FromSeconds(totalSeconds);
                string countdownText = time.ToString(@"mm\:ss");
                // Assuming you have a label or textbox to show the countdown
                countdownLabel.Text = countdownText;
                await Task.Delay(1000);
                totalSeconds--;
            }
            countdownLabel.Text = "00:00";
            DialogResult decision = MessageBox.Show("Do you want to continue?","Hands Up",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            if(decision == DialogResult.Yes)
            {
                StartCountdownAsync(5);
            } else
            {
                this.Close();
            }
        }

        private void Question_Answers_Load(object sender, EventArgs e)
        {
            StartCountdownAsync(1);
        }
    }
}
