namespace _02.KnightGame
{
    using System;

    public class KnightGame
    {
        public static void Main()
        {
            var sizeOfTheBoard = int.Parse(Console.ReadLine());

            var matrix = FillMatrix(sizeOfTheBoard, sizeOfTheBoard);

            var removedKnightsCount = 0;
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < matrix[rowIndex].Length; colIndex++)
                {
                    if (matrix[rowIndex][colIndex] == 'K')
                    {
                        if (IsInMatrix(rowIndex + 1, colIndex + 2, matrix)) // ->->v
                        {
                            if (matrix[rowIndex + 1][colIndex + 2] == 'K')
                            {
                                matrix[rowIndex + 1][colIndex + 2] = 'O';
                                removedKnightsCount++;
                            }
                        }
                        else if (IsInMatrix(rowIndex - 1, colIndex + 2, matrix)) // ->->^
                        {
                            if (matrix[rowIndex - 1][colIndex + 2] == 'K')
                            {
                                matrix[rowIndex - 1][colIndex + 2] = 'O';
                                removedKnightsCount++;
                            }
                        }
                        else if (IsInMatrix(rowIndex + 1, colIndex - 2, matrix)) // v<-<-
                        {
                            if (matrix[rowIndex + 1][colIndex - 2] == 'K')
                            {
                                matrix[rowIndex + 1][colIndex - 2] = 'O';
                                removedKnightsCount++;
                            }
                        }
                        else if (IsInMatrix(rowIndex - 1, colIndex - 2, matrix)) // ^<-<-
                        {
                            if (matrix[rowIndex - 1][colIndex - 2] == 'K')
                            {
                                matrix[rowIndex - 1][colIndex - 2] = 'O';
                                removedKnightsCount++;
                            }
                        }
                        else if (IsInMatrix(rowIndex + 2, colIndex + 1, matrix)) //vv->
                        {
                            if (matrix[rowIndex + 2][colIndex + 1] == 'K')
                            {
                                matrix[rowIndex + 2][colIndex + 1] = 'O';
                                removedKnightsCount++;
                            }
                        }
                        else if (IsInMatrix(rowIndex + 2, colIndex - 1, matrix)) //vv<-
                        {
                            if (matrix[rowIndex + 2][colIndex - 1] == 'K')
                            {
                                matrix[rowIndex + 2][colIndex - 1] = 'O';
                                removedKnightsCount++;
                            }
                        }
                        else if (IsInMatrix(rowIndex - 2, colIndex + 1, matrix)) // ^^->
                        {
                            if (matrix[rowIndex - 2][colIndex + 1] == 'K')
                            {
                                matrix[rowIndex - 2][colIndex + 1] = 'O';
                                removedKnightsCount++;
                            }
                        }
                        else if (IsInMatrix(rowIndex - 2, colIndex - 1, matrix)) // ^^<-
                        {
                            if (matrix[rowIndex - 2][colIndex - 1] == 'K')
                            {
                                matrix[rowIndex - 2][colIndex - 1] = 'O';
                                removedKnightsCount++;
                            }
                        }
                    }
                }
            }

            //if (removedKnightsCount == 0)
            //{
            //    Console.WriteLine(removedKnightsCount);
            //}
            //else
            //{
            //    Console.WriteLine(removedKnightsCount);
            //}

            Console.WriteLine(removedKnightsCount);
            
        }

        //private static bool CheckWhetherCanAtack(int rowIndex, int colIndex, char[][] matrix)
        //{
        //    //current position => matrix[rowIndex][colIndex]

        //    if (IsInMatrix(rowIndex + 1,colIndex + 2,matrix)) // ->->v
        //    {

        //    }
        //    else if (IsInMatrix(rowIndex - 1, colIndex + 2, matrix)) // ->->^
        //    {

        //    }
        //    else if (IsInMatrix(rowIndex + 1, colIndex - 2, matrix)) // v<-<-
        //    {

        //    }
        //    else if (IsInMatrix(rowIndex - 1, colIndex - 2, matrix)) // ^<-<-
        //    {

        //    }
        //    else if (IsInMatrix(rowIndex + 2, colIndex + 1, matrix)) //vv->
        //    {

        //    }
        //    else if (IsInMatrix(rowIndex + 2, colIndex - 1, matrix)) //vv<-
        //    {

        //    }
        //    else if (IsInMatrix(rowIndex - 2, colIndex + 1, matrix)) // ^^->
        //    {

        //    }
        //    else if (IsInMatrix(rowIndex - 2, colIndex - 1, matrix)) // ^^<-
        //    {

        //    }
        //}

        private static bool IsInMatrix(int currentRow, int currentCol, char[][] matrix)
        {
            if(currentRow >= 0 && currentRow < matrix.Length &&
                currentCol >= 0 && currentCol < matrix[currentRow].Length)
            {
                return true;
            }
            return false;
        }

        private static char[][] FillMatrix(int row, int col)
        {
            var board = new char[row][];

            for (int rowIndex = 0; rowIndex < board.Length; rowIndex++)
            {
                board[rowIndex] = Console.ReadLine().ToCharArray();
            }

            return board;
        }
    }
}
