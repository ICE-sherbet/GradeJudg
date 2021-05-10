using System;
using System.Windows.Forms;

namespace GradeJudg
{
    public partial class Form1 : Form
    {
        private int[] rankClass = new int[] {60, 70, 80,90,100};
        private string[] rankClassString = new string[] {"D:不可","C:可","B:良","A:優","S:秀"};
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonJudg_Click(object sender, EventArgs e)
        {
            label2.Text = rankclassify(textBoxScore.getNum());
        }
        private string rankclassify(int score)
        {
            for (int i = 0; i < rankClass.Length; i++)
            {
                if (score < rankClass[i]) return rankClassString[i];
            }
            return rankClassString[rankClassString.Length -1];
        }
    }
}
