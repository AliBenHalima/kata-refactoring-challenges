using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Game_Kata
{
    public class Game
    {
        public int[] Rolls = new int[21];
        public int[] Frames = new int[10];
        public int CurrentRoll = 0;
        public int FrameIndex = 0;
        public int Sum = 0;

        public void Roll(int pins)
        {
            Rolls[CurrentRoll++] = pins;
        }

        public void Roll(int[] pins)
        {
            for(int i =0; i < pins.Length; i++)
            {
                Rolls[CurrentRoll++] = pins[i];
            }
        }

        public int Score()
        {
            for(int i = 0; i< 10; i++)
            {
                if (IsSpare(FrameIndex))
                {
                    Sum += 10 + Rolls[FrameIndex + 2];
                    FrameIndex += 2;
                }
                else if (IsStrike(FrameIndex))
                {
                    Sum += 10 + Rolls[FrameIndex + 1] + Rolls[FrameIndex + 2];
                    FrameIndex += 1;
                }
                else
                {
                    Sum += Rolls[FrameIndex] + Rolls[FrameIndex + 1];
                    FrameIndex += 2;
                }

            }
            return Sum;
        }

        public bool IsSpare(int index)
        {
            return Rolls[index] + Rolls[index + 1] == 10;

        }
        public bool IsStrike(int index)
        {
            return Rolls[index] == 10;

        }
    }
}
