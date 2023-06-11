using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.Xml.Serialization;

namespace C__Assign_Team9
{
    public partial class Form2 : Form
    {
        CharacterManager characterManager; // 캐릭터들을 관리하기위한 매니저변수
        bool GameResult; // 게임 승패결과
        int wallet = 5000; // 씨-드머니
        int betMoney; // 배팅금
        Point LocationChar1, LocationChar2;
        Character winCharacter, loseCharacter;



        private void setBetMoney() // 배팅머니 입력창에 text값을 변수로 가져오는 함수
        {
            betMoney = int.Parse(BetMoney.Text);
            wallet -= betMoney;
        }

        public Form2()
        {
            InitializeComponent();
            init();

            //Debug.Print(characterManager.character1.GetName());

        }

        private void init() // 오브젝트들의 초기화를 하는 함수
        {
            //Naration.Text = $"{CharacterImage1.Left}, {FinishLine.Left}";
            characterManager = CharacterManager.Instance();

            // 라디오버튼 text 초기화
            BetToChar1.Text = characterManager.character1.GetName() + "에 배팅!";
            BetToChar2.Text = characterManager.character2.GetName() + "에 배팅!";
        }
        int LeftCharacterImage1, LeftCharacterImage2;
        private void Form2_Load(object sender, EventArgs e)
        {
            button1.FlatAppearance.BorderSize = 0;

            LeftCharacterImage1 = CharacterImage1.Left;
            LeftCharacterImage2 = CharacterImage2.Left;

            LocationChar1 = CharacterImage1.Location;
            LocationChar2 = CharacterImage2.Location;

            Char1Name.Text = characterManager.character1.GetName();
            Char2Name.Text = characterManager.character2.GetName();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            setBetMoney();

            BetToChar1.Enabled = false;
            BetToChar2.Enabled = false;
            timer1.Enabled = true;
            HowToPlay.Enabled = false;
            percentTimer.Start(); // 확률 계산 시작
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

            //int widthCharacterImage1 = CharacterImage1.Width, widthCharacterImage2 = CharacterImage2.Width; // 캐릭터별 시작점 

            int finish = FinishLine.Left;   // 도착점

            CharacterImage1.Left = CharacterImage1.Left + characterManager.character1.GetSpeed();   // 캐릭터들 이동 속도
            CharacterImage2.Left = CharacterImage2.Left + characterManager.character2.GetSpeed();

            double ch1 = Math.Ceiling(((double)CharacterImage1.Left / 800) * 100);
            double ch2 = Math.Ceiling(((double)CharacterImage2.Left / 800) * 100);

            Location1.Text = $"{characterManager.character1.GetName()} : {ch1} %";   // 현재 진행상황 표시
            Location2.Text = $"{characterManager.character2.GetName()} : {ch2} %";

            label1.Text = $"{ch1}"; //테스트용 라벨으로 라벨 채로 지워도 무방
            label3.Text = $"{ch2}"; //테스트용 라벨으로 라벨 채로 지워도 무방

            if (ch1 - 5.0 > ch2 && ch1 >= 70.0) //현재 5만큼 앞서있고 70 이상일때
            {
                characterManager.character1.Frontrunner();
            }
            else if (ch2 - 5.0 > ch1 && ch2 >= 70.0)
            {
                characterManager.character2.Frontrunner();
            }
            else
            {
                characterManager.character1.DisableFrontrunner();
                characterManager.character2.DisableFrontrunner();
            }


            if (ch1 - 10.0 > ch2) //10 뒤쳐질때
            { 
                characterManager.character2.Lastrunner();
            } 
            else if(ch2 - 10.0 > ch1) 
            { 
                characterManager.character1.Lastrunner(); 
            }
            else
            {
                characterManager.character1.DisableLastrunner();
                characterManager.character2.DisableLastrunner();
            }

            //Naration.Text = $"{characterManager.character1.GetName()} : {CharacterImage1.Left}, {characterManager.character2.GetName()} : {CharacterImage2.Left}";  // 캐릭터별 현재 위치 프린트

            if (CharacterImage1.Left >= finish) // 도착선 밟으면 게임 종료
            {
                timer1.Enabled = false;
                percentTimer.Stop(); // 확률 계산 종료
                Naration.Text = $"게임 종료! {characterManager.character1.GetName()} 승리!";
                GameResult = true;

                winCharacter = characterManager.character1;
                loseCharacter = characterManager.character2;

                showGameResultMSGBox();

                // 캐릭터들의 위치 초기화 및 버튼 재활성화
                reSetting();

            }
            else if (CharacterImage2.Left >= finish)
            {
                timer1.Enabled = false;
                percentTimer.Stop(); // 확률 계산 종료
                Naration.Text = $"게임 종료! {characterManager.character2.GetName()} 승리!";
                GameResult = false;

                winCharacter = characterManager.character2;
                loseCharacter = characterManager.character1;

                showGameResultMSGBox();

                // 캐릭터들의 위치 초기화 및 버튼 재활성화
                reSetting();
            }


        }

        private void showGameResultMSGBox() // 게임결과 메세지박스를 출력
        {
            string resultText = "";
            if (wallet >= 0 && wallet < 7500)
            {
                if (BetToChar1.Checked == GameResult)
                {
                    wallet += betMoney + (betMoney / 2);

                    resultText = $"베팅 성공!\n{winCharacter.GetName()} 의 승리!\n획득 금액 : {betMoney + betMoney / 2}";

                    if (wallet >= 7500)
                    {
                        MessageBox.Show("목표금액을 달성했습니다!\n You are Winner!");
                        Application.Restart();
                    }
                }
                else if (BetToChar1.Checked != GameResult)
                {
                    resultText = $"베팅 실패!\n{loseCharacter.GetName()} 의 패배!\n잃은 금액 : {betMoney}";
                    if (wallet <= 0)
                    {
                        MessageBox.Show("소지금을 모두 잃었습니다!\n You are Loser!");
                        Application.Restart();
                    }
                }


                MessageBox.Show(resultText);
            }
        }

        private void reSetting()    // 캐릭터들의 위치 초기화 및 버튼 재활성화
        {
            CharacterImage1.Location = this.LocationChar1;
            CharacterImage2.Location = LocationChar2;
            BetToChar1.Enabled = true;
            BetToChar2.Enabled = true;
            HowToPlay.Enabled = true;
            BetMoney.Text = "";
        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            CurrentMoney.Text = wallet.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("간단한 게임설명!\n이길것 같은 개체에 베팅을 해서 \n맞추면 베팅금액의 1.5배, 틀리면 베팅금액 사라짐\n소지금이 0원이되면 게임오버, 2만원을 넘으면 승리!");
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {
        }

        public void ProgressBarIncrease(object sender) // 프로그레스바의 값을 증가시키는 함수
        {

        }

        private void CharacterImage1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }





        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void CharacterImage2_Click(object sender, EventArgs e)
        {

        }




        private void BetToChar1_CheckedChanged_1(object sender, EventArgs e)
        {
            //Debug.Print("");
        }

        private void BetToChar2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }


        private void BetMoney_TextChanged(object sender, EventArgs e)
        {

        }

        private void Naration_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_2(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void HowToPlayExplain_Click(object sender, EventArgs e)
        {

        }

        private void Lacation2_Click(object sender, EventArgs e)
        {

        }
        private void UpdateCharacterSpeedLabels() //속도가 제대로 잘 바뀌나 테스트 용도
        {
            if (characterManager.character1 != null)
            {
                testlabel1.Text = $"주자 1: {characterManager.character1.GetSpeed()}";
            }

            if (characterManager.character2 != null)
            {
                testlabel3.Text = $"주자 2: {characterManager.character2.GetSpeed()}";
            }
        }

        private void percentTimer_Tick(object sender, EventArgs e) //0.2초마다 확률 계산하는 타이머
        {
            // 각 주자의 스킬 확률 계산
            characterManager.character1.ActivateRandomSkill();
            characterManager.character2.ActivateRandomSkill();
            characterManager.character1.Fatalskill();
            characterManager.character1.Fatalskill();
            UpdateCharacterSpeedLabels(); //발동할때 속도 조정

            // 주자 1의 스킬 지속 시간 체크
            if (characterManager.character1.skillDuration > 0) //0.2초마다 1씩 감소
            {
                characterManager.character1.skillDuration--;
                if (characterManager.character1.skillDuration == 0)
                {
                    characterManager.character1.ResetSpeed(); //속도 리셋
                }
            }

            // 주자 2의 스킬 지속 시간 체크
            if (characterManager.character2.skillDuration > 0)
            {
                characterManager.character2.skillDuration--;
                if (characterManager.character2.skillDuration == 0)
                {
                    characterManager.character2.ResetSpeed(); //속도 리셋
                }
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e) // 창을 닫아도 폼1이 안닫혀서 둘다 종료하게끔
        {
            Application.Exit();
        }
    }
}
