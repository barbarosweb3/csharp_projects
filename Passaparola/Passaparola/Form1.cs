using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru=0, yanlis=0;

        private Dictionary<int, (string answer, string question)> questions = new Dictionary<int, (string, string)>
        {
            { 1, ("akdeniz", "Ülkemizin güney kısmındaki kıyı bölgesi?") },
            { 2, ("bursa", "Yeşilliği ile ünlü Marmara ilimiz") },
            { 3, ("cuma", "Müslümanların kutsal günü?") },
            {4, ("diyarbakır", "Karpuzuyla ünlü ilimiz?")},
            {5, ("eski", "Yeni kelimesinin zıt anlamlısı?")},
            {6, ("ferman","Padişahın emirlerinin yazılı hali?")},
            {7, ("güneş","Dünyanın ısı kaynağı nedir?")},
            {8, ("hırka","Öğrencilerin kötü karne getirince bakıştığı nesne?")},
            {9, ("ısparta","Gülüyle ünlü ilimiz?")},
            {10, ("içel", "Mersinin diğer ismi?")},
            {11, ("jandarma","Askeri bir topluluğa ne ad verilir?")},
            {12, ("kayısı", "Malatya'nın meşhur meyvesi nedir?")},
            {13, ("lale","Her yıl bahar aylarında düzenlenen meşhur çiçek festivali nedir?")},
            {14, ("mart","Yılın üçüncü ayı nedir?")},
            {15, ("ney","Üflemeli bir nefesli çalgı?") },
            {16, ("ozan","Halk şairine ne ad verilir?")},
            {17, ("pilav","Çocukların pek sevmediği pirinç, havuç gibi sebzeler ile yapılan yemek?")},
            {18, ("ramazan","Onbir ayın sultanı nedir?")},
            {19, ("snake","İngilizce dilinde yılan nasıl söylenir?") },
            {20, ("tarkan","Türkiye'nin megastarı kimdir?")},
            {21, ("umut","Ümit kelimesinin eş anlamlısı nedir")},
            {22, ("van","Kahvaltısı ile ünlü ilimiz?") },
            {23, ("yıldırım","Şimşek kelimesinin eş anlamlısı?") },
            {24, ("zeytin","Ege Bölgesi'nin en çok ağacı bulunan yağı da bulunan bir kahvaltı besini?")},
        };

        private void CheckAnswer(int buttonNumber, string answer)
        {
            var button = (Button)Controls["button" + buttonNumber];
            if (answer.ToLower() == questions[buttonNumber].answer)
            {
                button.BackColor = Color.Green;
                dogru++;
                label2.Text = dogru.ToString();
            }
            else
            {
                button.BackColor = Color.Red;
                yanlis++;
                label3.Text = yanlis.ToString();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && soruno >= 1 && soruno <= 24)
            {
                CheckAnswer(soruno, textBox1.Text.ToLower());
            }
        }

        private void ResetButtonColors()
        {
            for (int i = 1; i <= 24; i++)
            {
                if (Controls["button" + i] is Button btn)
                {
                    btn.BackColor = Color.White;
                }
            }
        }

        private void ResetGame()
        {
            ResetButtonColors();
            soruno = 0;
            dogru = 0;
            yanlis = 0;
            label2.Text = "0";
            label3.Text = "0";
            this.Text = "0";
            richTextBox1.Text = "OYUNA BAŞLA";
            linkLabel1.Text = "Sonraki";
        }

        private void ShowQuestion(int questionNumber)
        {
            if (questionNumber < 25)
            {
                richTextBox1.Text = questions[questionNumber].question;
                ResetButtonColors();
                if (Controls["button" + questionNumber] is Button btn)
                {
                    btn.BackColor = Color.Yellow;
                }
            }
            else
            {
                MessageBox.Show($"OYUN BİTTİ! \n\nDoğru Sayınız: {dogru}\nYanlış Sayınız: {yanlis}");
                ResetGame();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();
            ShowQuestion(soruno);
        }
    }
}