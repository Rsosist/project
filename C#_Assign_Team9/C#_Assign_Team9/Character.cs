using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 캐릭터 정보저장 클래스

namespace C__Assign_Team9
{
    internal class Character
    {
        string name; // 캐릭터 이름
        int speed; // 캐릭터 속도
        private string[] skillList; // 스킬이름 항목
        int wallet = 5000; // 소지금
        int originalSpeed;

        private bool isSpeedIncreased; // 증가 스킬 중복 발동을 막는 용도
        private bool isSpeedDecreased; // 감소 스킬 중복 발동을 막는 용도
        private bool isFinishSpeed;
        private bool isLastSpeed;
        private bool isStun; //기절 스킬 발동 여부
        public int skillDuration; //스킬 지속 시간

        private const double increaseSkillProbability = 0.04; // 증가 스킬 확률 4% (여기서 확률 수정)
        private const double decreaseSkillProbability = 0.03; // 감소 스킬 확률 3% (여기서 확률 수정)
        private const double finishProbability = 0.015;
        private const double lastProbability = 0.04;
        private const double stunSkillProbability = 0.005;

        private Random rnd;
        private bool frontActive = false;
        private bool lastActive = false;

        public Character(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
            originalSpeed = speed;
            skillList = new string[3]; //스킬 리스트를 어디다 쓰지..
            skillList[0] = "증가 스킬";
            skillList[1] = "감소 스킬";
            skillList[2] = "기절!";
            rnd = new Random();
        }

        public string GetName()
        {
            return name;
        }


        public int GetSpeed()
        {
            return speed;
        }

        public string[] GetSkillList()
        {
            return skillList;
        }

        public void Frontrunner() { frontActive = true; }
        public void DisableFrontrunner() { frontActive = false; }

        public void Lastrunner() { lastActive = true; }
        public void DisableLastrunner() { lastActive = false; }

        public void ActivateRandomSkill()
        {
            double randomValue = rnd.NextDouble(); // 0.04
            if (randomValue <= increaseSkillProbability && !isSpeedIncreased && !isStun) //스턴 시 속도 증가가 영향을 주지 않게
            {
                IncreaseSpeed();
            }// 0.04가 아니면서 0.07
            else if (randomValue <= increaseSkillProbability + decreaseSkillProbability && !isSpeedDecreased && !isStun) //스턴 시 속도 감소가 영향을 주지 않게
            {
                DecreaseSpeed();
            }
            else if (frontActive == true && randomValue <= increaseSkillProbability + decreaseSkillProbability + finishProbability && !isFinishSpeed && !isStun)
            {
                FinishSpeed();
            }
            else if (lastActive == true && randomValue <= increaseSkillProbability + decreaseSkillProbability + lastProbability && !isLastSpeed && !isStun)
            {
                LastSpeed();
            }
        }
        public void Fatalskill()
        {
            double Valuerandom = rnd.Next();
            if (Valuerandom <= stunSkillProbability && !isStun) // 스턴 재발동 막기
            {
                Stun();
            }
        }

        private void IncreaseSpeed()
        {
            if (!isSpeedIncreased)
            {
                speed += 3;
                skillDuration = 15; ////지속시간 3초 * 5(0.2초 * 5 = 1초)
                isSpeedIncreased = true;
            }
        }

        private void FinishSpeed()
        {
            if (!isFinishSpeed)
            {
                speed += 6;
                skillDuration = 10;
                isFinishSpeed = true;
            }
        }

        private void LastSpeed()
        {
            if (!isLastSpeed)
            {
                speed += 5;
                skillDuration = 14;
                isLastSpeed = true;
            }
        }

        private void DecreaseSpeed()
        {
            if (!isSpeedDecreased)
            {
                speed -= 2;
                skillDuration = 10; //2초 * 5(0.2초 * 5 = 1초)
                isSpeedDecreased = true;
            }
        }

        private void Stun()
        {
            if (!isStun)
            {
                speed = 0;
                skillDuration = 4;
                isStun = true;
            }
        }

        public void ResetSpeed()
        {
            speed = originalSpeed; // 속도를 원래 값으로 되돌림
            isSpeedIncreased = false; // 증가 스킬 발동 여부 초기화
            isSpeedDecreased = false; // 감소 스킬 발동 여부 초기화
            isStun = false;
            isFinishSpeed = false;
            isLastSpeed = false;
        }
    }
}
