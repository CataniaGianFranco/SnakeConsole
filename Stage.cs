using System;

namespace SnakeConsole
{
    public class Stage
    {
        GameObject[,] stageGameObject = new GameObject[1,1];

        private void LoadStageAndPosition()
        {
            stageGameObject[0,0] = new Floor();
            stageGameObject[0,0].MyPosition(0,0);
        }
        public void ShowStage()
        {
            LoadStageAndPosition();
            for (int r = 0; r < 1; r++)
            {
                for (int c = 0; c < 1; c++)
                {
                    Console.Write(stageGameObject[r,c].Element());
                }
                Console.WriteLine();
            }
        }
    }
}