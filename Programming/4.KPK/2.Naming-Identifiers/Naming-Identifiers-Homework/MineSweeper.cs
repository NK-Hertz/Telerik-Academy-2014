using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MineSweeper
{
    
	public class MineSweeper
	{
		public class Points
		{
			private string name;
			private int score;

			public Points() { }

            public Points(string name, int score)
			{
				this.Name = name;
                this.Score = score;
			}

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int Score
            {
                get { return this.score; }
                set { this.score = value; }
            }
		}

		static void Main(string[] args)
		{
            const int maxSafeCells = 35;
			string command = string.Empty;
			char[,] field = CreateGameField();
			char[,] bombs = PlaceBombs();
			int openedSafeCells = 0;
			bool steppedOnMine = false;
            List<Points> champions = new List<Points>(6);
			int row = 0;
			int column = 0;
			bool intro = true;
			bool outro = false;

			do
			{
				if (intro)
				{
					Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
					" Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
					DrawField(field);
					intro = false;
				}
				Console.Write("Daj red i kolona : ");
				command = Console.ReadLine().Trim();
				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
					int.TryParse(command[2].ToString(), out column) &&
						row <= field.GetLength(0) && column <= field.GetLength(1))
					{
						command = "turn";
					}
				}
				switch (command)
				{
					case "top":
						PrintLeaderboard(champions);
						break;
					case "restart":
						field = CreateGameField();
						bombs = PlaceBombs();
						DrawField(field);
						steppedOnMine = false;
						intro = false;
						break;
					case "exit":
						Console.WriteLine("4a0, 4a0, 4a0!");
						break;
					case "turn":
						if (bombs[row, column] != '*')
						{
							if (bombs[row, column] == '-')
							{
								MakeAMove(field, bombs, row, column);
								openedSafeCells++;
							}
							if (maxSafeCells == openedSafeCells)
							{
								outro = true;
							}
							else
							{
								DrawField(field);
							}
						}
						else
						{
							steppedOnMine = true;
						}
						break;
					default:
						Console.WriteLine("\nGreshka! nevalidna Komanda\n");
						break;
				}
				if (steppedOnMine)
				{
					DrawField(bombs);
					Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
						"Daj si niknejm: ", openedSafeCells);
					string name = Console.ReadLine();
					Points score = new Points(name, openedSafeCells);
					if (champions.Count < 5)
					{
						champions.Add(score);
					}
					else
					{
						for (int i = 0; i < champions.Count; i++)
						{
                            if (champions[i].Score < score.Score)
							{
								champions.Insert(i, score);
								champions.RemoveAt(champions.Count - 1);
								break;
							}
						}
					}
					champions.Sort((Points scoreFirst, Points scoreSecond) => scoreSecond.Name.CompareTo(scoreFirst.Name));
					champions.Sort((Points scoreFirst, Points scoreSecond) => scoreSecond.Score.CompareTo(scoreFirst.Score));
					PrintLeaderboard(champions);

					field = CreateGameField();
					bombs = PlaceBombs();
					openedSafeCells = 0;
					steppedOnMine = false;
					intro = true;
				}
				if (outro)
				{
					Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
					DrawField(bombs);
					Console.WriteLine("Daj si imeto, batka: ");
					string name = Console.ReadLine();
                    Points score = new Points(name, openedSafeCells);
					champions.Add(score);
					PrintLeaderboard(champions);
					field = CreateGameField();
					bombs = PlaceBombs();
					openedSafeCells = 0;
					outro = false;
					intro = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.WriteLine("AREEEEEEeeeeeee.");
			Console.Read();
		}

		private static void PrintLeaderboard(List<Points> score)
		{
			Console.WriteLine("\nTo4KI:");
            if (score.Count > 0)
			{
                for (int i = 0; i < score.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, score[i].Name, score[i].Score);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("prazna klasaciq!\n");
			}
		}

		private static void MakeAMove(char[,] board,
			char[,] bombs, int row, int column)
		{
            char bombsCount = GetNonBombElements(bombs, row, column);
            bombs[row, column] = bombsCount;
            board[row, column] = bombsCount;
		}

        //former dumpp
		private static void DrawField(char[,] board)
		{
			int rows = board.GetLength(0);
			int columns = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < rows; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < columns; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}
				Console.Write("|");
				Console.WriteLine();
			}
			Console.WriteLine("   ---------------------\n");
		}

        private static char[,] CreateGameField()
		{
			int boardRows = 5;
			int boardColumns = 10;
			char[,] board = new char[boardRows, boardColumns];
			for (int i = 0; i < boardRows; i++)
			{
				for (int j = 0; j < boardColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] PlaceBombs()
		{
			int rows = 5;
			int columns = 10;
			char[,] board = new char[rows, columns];

            int bombsToPlace = 15;

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					board[i, j] = '-';
				}
			}

			List<int> bombs = new List<int>();
            while (bombs.Count < bombsToPlace)
			{
                Random randomGenerator = new Random();
				int position =  randomGenerator.Next(50);
                if (!bombs.Contains(position))
				{
					bombs.Add(position);
				}
			}
            
			foreach (int bomb in bombs)
			{
				int column = (bomb / columns);
				int row = (bomb % columns);
				if (row == 0 && bomb != 0)
				{
					column--;
					row = columns;
				}
				else
				{
					row++;
				}

				board[column, row - 1] = '*';
			}

			return board;
		}

		private static void DisplayDangerZone(char[,] board)
		{
			int columns = board.GetLength(0);
			int rows = board.GetLength(1);

			for (int i = 0; i < columns; i++)
			{
				for (int j = 0; j < rows; j++)
				{
					if (board[i, j] != '*')
					{
						char bombCount = GetNonBombElements(board, i, j);
                        board[i, j] = bombCount;
					}
				}
			}
		}

		private static char GetNonBombElements(char[,] board, int row, int column)
		{
			int nonBombElementsCount = 0;
			int rows = board.GetLength(0);
			int columns = board.GetLength(1);

			if (row - 1 >= 0)
			{
				if (board[row - 1, column] == '*')
				{ 
					nonBombElementsCount++; 
				}
			}
			if (row + 1 < rows)
			{
				if (board[row + 1, column] == '*')
				{ 
					nonBombElementsCount++; 
				}
			}
			if (column - 1 >= 0)
			{
				if (board[row, column - 1] == '*')
				{ 
					nonBombElementsCount++;
				}
			}
			if (column + 1 < columns)
			{
				if (board[row, column + 1] == '*')
				{ 
					nonBombElementsCount++;
				}
			}
			if ((row - 1 >= 0) && (column - 1 >= 0))
			{
				if (board[row - 1, column - 1] == '*')
				{ 
					nonBombElementsCount++; 
				}
			}
			if ((row - 1 >= 0) && (column + 1 < columns))
			{
				if (board[row - 1, column + 1] == '*')
				{ 
					nonBombElementsCount++; 
				}
			}
			if ((row + 1 < rows) && (column - 1 >= 0))
			{
				if (board[row + 1, column - 1] == '*')
				{ 
					nonBombElementsCount++; 
				}
			}
			if ((row + 1 < rows) && (column + 1 < columns))
			{
				if (board[row + 1, column + 1] == '*')
				{ 
					nonBombElementsCount++; 
				}
			}

			return char.Parse(nonBombElementsCount.ToString());
		}
	}
}
