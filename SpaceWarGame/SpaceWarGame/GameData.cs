using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceWarGame
{
    public class GameData
    {
        private static Random randomGenerator;
        private static int difficultyLevel;
        private static int giftLevel;

        static GameData()
        {
            randomGenerator = new Random();
            difficultyLevel = 1;
            giftLevel = 10;
        }

        public static void IncreaseDifficulty()
        {
            difficultyLevel++;
        }

        public static bool ShootingProbability()
        {
            int randomNumber = randomGenerator.Next(1001);
            if (randomNumber <= difficultyLevel)
            {
                return true;
            }

            return false;
        }

        public static Gift GetGift()
        {
            //create a "fake" gift
            Gift producedGift = new Gift(new MatrixPosition(0, 0), new MatrixPosition(0, 0));

            int randomNumber = randomGenerator.Next(101);
            if (randomNumber <= giftLevel)
            {
                switch (randomGenerator.Next(3))
                {
                    case 0:
                        producedGift = new GiftLife(new MatrixPosition(0, 0), new MatrixPosition(0, 0));
                        break;
                    case 1:
                    case 2:
                        producedGift = new GiftPoints(new MatrixPosition(0, 0), new MatrixPosition(0, 0));
                        break;
                    default:
                        break;
                }
            }

            return producedGift;
        }
    }
}
