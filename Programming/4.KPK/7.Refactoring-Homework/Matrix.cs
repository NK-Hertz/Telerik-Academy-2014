using System;

namespace Matrix{
    public class WalkInMatrix 
    {
        public const int DIRECTION_COUNT = 8;

        static void ChangeDirection(ref int moveDirectionX,ref int moveDirectionY) 
        {
            int[] allDirectionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] allDirectionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int currentDirection = 0;
            for (int count = 0; count < DIRECTION_COUNT; count++)
            {
                if (allDirectionsX[count] == moveDirectionX && allDirectionsY[count] == moveDirectionY)
                {
                    currentDirection = count;
                    break;
                }
            }

            if(currentDirection == 7) 
            { 
                moveDirectionX = allDirectionsX[0];
                moveDirectionY = allDirectionsY[0];
                return; 
            }

            moveDirectionX = allDirectionsX[currentDirection + 1];
            moveDirectionY = allDirectionsY[currentDirection + 1];
        }

        public static bool FindNextEmptyCell(int[,] arr, int x, int y)
        {
            int[] allDirectionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] allDirectionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            for(int i = 0; i < DIRECTION_COUNT; i++)
            {
                if (x + allDirectionsX[i] >= arr.GetLength(0) || x + allDirectionsX[i] < 0)
                {
                    allDirectionsX[i] = 0;
                }

                if (y + allDirectionsY[i] >= arr.GetLength(0) || y + allDirectionsY[i] < 0)
                {
                    allDirectionsY[i] = 0;
                }
            }
            for (int i = 0; i < DIRECTION_COUNT; i++)
            {
                if (arr[x + allDirectionsX[i], y + allDirectionsY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static void CheckForEmptyCellsLeft(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        x = i;
                        y = j;
                        return;
                    }
                }
            }
        }

        static void PrintMatrix(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write("{0,3}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static void Main(string[] args){
            Console.WriteLine("Enter a positive number ");
            string input = Console.ReadLine();
            int sizeOfMatrix = 0;
            while (!int.TryParse(input, out sizeOfMatrix) || sizeOfMatrix < 0 || sizeOfMatrix > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }
            //int sizeOfMatrix = 3;
            int[,] matrix = new int[sizeOfMatrix, sizeOfMatrix];
            int cellCounter = 1, i = 0, j = 0, moveDirectionX = 1, moveDirectionY = 1;
            while(true)
            { //malko e kofti tova uslovie, no break-a raboti 100% : )
                matrix[i, j] = cellCounter;

                if(!FindNextEmptyCell(matrix, i, j))
                {
                    break; 
                }

                //here lies black magic
                //also it is done to see if params are out of bounderies or if matrix[i, j] is visited
                while ((i + moveDirectionX >= sizeOfMatrix ||
                        i + moveDirectionX < 0 || j + moveDirectionY >= sizeOfMatrix ||
                        j + moveDirectionY < 0 || matrix[i + moveDirectionX, j + moveDirectionY] != 0)) 
                {
                    ChangeDirection(ref moveDirectionX, ref moveDirectionY);
                }

                i += moveDirectionX;
                j += moveDirectionY;
                cellCounter++;
            }

            PrintMatrix(matrix);

            CheckForEmptyCellsLeft(matrix, out i, out j);
            //the function needs us to define out params
            if(i != 0 && j != 0) 
            { 
                moveDirectionX = 1;
                moveDirectionY = 1;

                while (true) 
                { //malko e kofti tova uslovie, no break-a raboti 100% : )
                    matrix[i, j] = cellCounter;
                    if(!FindNextEmptyCell(matrix, i, j))
                    {
                        break;
                    }

                    //here lies black magic
                    //also it is done to see if params are out of bounderies or if matrix[i, j] is visited
                    while ((i + moveDirectionX >= sizeOfMatrix ||
                            i + moveDirectionX < 0 || j + moveDirectionY >= sizeOfMatrix ||
                            j + moveDirectionY < 0 || matrix[i + moveDirectionX, j + moveDirectionY] != 0))
                    {
                        ChangeDirection(ref moveDirectionX, ref moveDirectionY);
                    }

                    i += moveDirectionX;
                    j += moveDirectionY;
                    cellCounter++;
                }
            }

            PrintMatrix(matrix);
        }
    }
}
