#include<stdio.h>
#include<conio.h>
#include<stdlib.h>
#include<string.h>
#include<stdbool.h>
#define SIZE 3

void menu();
void emptyBoard(char board[SIZE][SIZE]);
void drawBoard(char board[SIZE][SIZE], int winningPositions[3][2]);
int checkWinner(char board[SIZE][SIZE], char player, int winningPositions[3][2]);
int checkDraw(char board[SIZE][SIZE]);
void validity(char board[SIZE][SIZE], char player1[50], char player2[50], int position, int currentPlayer, int moves, int winningPositions[3][2]);

int main()
{
	char board[SIZE][SIZE];
	char player1[50], player2[50];
	int position, currentPlayer = 1, moves = 0;
	int winningPositions[3][2] = {{-1, -1}, {-1,-1}, {-1,-1}};
	
	system("cls");
	fflush(stdin);
	menu();
    getch();
    system("cls");
    
    //ask player name
    system("COLOR 06");
	printf("\nEnter player 1 name (X): ");
	fgets(player1, sizeof(player1), stdin);
	player1[strcspn(player1, "\n")] = 0; //remove newline character
	
	printf("\nEnter player 2 name (O): ");	
	fgets(player2, sizeof(player2), stdin);
	player2[strcspn(player2, "\n")] = 0;//remove newline character
	
	//clear console screen
	system("cls");
	
	while(1)
	{
		currentPlayer = 1;
		moves = 0;
		
		//initialize empty board
		emptyBoard(board);
	
		//game loop/validate player moves
		validity(board, player1, player2, position, currentPlayer, moves, winningPositions);
		getch();
		
		char choice;
		bool validChoice = false;
		
		while (!validChoice)
		{
			system("cls");
			system("COLOR 02");
			printf("Go back to main menu [Y/N]?\n");
			scanf(" %c", &choice);
			
			if (choice == 'Y' || choice == 'y')
			{
				validChoice = true;
				main(1);
			}
			else if (choice == 'N' || choice == 'n')
			{
				validChoice = true;
				printf("Exiting program...\n");
				printf("Press any button to continue...");
				return 0;
			}
			else
			{
				system("COLOR 04");
				printf("Invalid choice. Please try again.");
				getch();
			}
		}	
	}	
}

void menu()
{
	system("COLOR 0D");
	printf("\n");
	printf("\n");
	printf("\n");
	printf(" PPPPPP    CCCCCC RRRRRR   SSSSSS    TTTTTTTTTT IIIII  CCCCCCCC TTTTTTTTTT  AAAAAAA   CCCCCCCC TTTTTTTTTT OOOOOOOOO EEEEEEEE    \n");
    printf(" P     P  C       R     R S               T       I   C              T     A       A C              T     O       O E           \n");
    printf(" PPPPPP  C        RRRRRR   SSSSS          T       I   C              T     A       A C              T     O       O EEEEEEE     \n");
    printf(" P       C        R  R          S         T       I   C              T     AAAAAAAAA C              T     O       O E           \n");
    printf(" P        C       R   R          S        T       I   C              T     A       A C              T     O       O E           \n");
    printf(" P         CCCCCC R    R   SSSSSS         T     IIIII  CCCCCCCC      T     A       A  CCCCCCCC      T     OOOOOOOOO EEEEEEEE    \n");
    printf("\n");
    printf("\n\t\t\t\t\t Press any button to play!");
}

void validity(char board[SIZE][SIZE], char player1[50], char player2[50], int position, int currentPlayer, int moves, int winningPositions[3][2])
{
	do
	{
		system("cls");
		system("COLOR 0D");
		drawBoard(board, winningPositions);
		//decide current player
		char currentPlayerName[50];
		if (currentPlayer == 1)
		{
			strcpy(currentPlayerName, player1);
		}
		else
		{
			strcpy(currentPlayerName, player2);
		}
		
		//get current player's move
		printf("\nPlayer %s turn (%c), Choose square 1-9: ", currentPlayerName, (currentPlayer == 1) ? 'X' : 'O');
		scanf("%d", &position);
		
		//adjust position to array indices (0-indexed)
		position--;
		
		//check if the move is valid
		if (position >= 0 && position < SIZE * SIZE && board[position / SIZE][position % SIZE] == ' ')
		{
			//update the board
			if (currentPlayer == 1)
			{
				board[position / SIZE][position % SIZE] = 'X';
			}
			else
			{
				board[position / SIZE][position % SIZE] = 'O';
			}
			
			//increment moves
			moves++;
			
			//winning display
			system("cls");
			drawBoard(board, winningPositions);
			
			if (checkWinner(board, 'X', winningPositions))
			{
				system("COLOR 0A"); 
				printf("\nPlayer %s (X) wins!\n", player1);
				printf("Congratulations!\n");
				break;
			}
			else if (checkWinner(board, 'O', winningPositions))
			{
				system("COLOR 09"); 
				printf("\nPlayer %s (O) wins!\n", player2);
				printf("Congratulations!\n");
				break;
			}
			else if (checkDraw(board))
			{
				system("COLOR 08"); 
				printf("\nIt's a draw!\n");
				break;
			}
			
			//switch player
			currentPlayer = (currentPlayer == 1) ? 2 : 1;
		}
		else
		{
			system("COLOR 04");
			printf("\nInvalid move! Please try again...\n");
			getch();
		}
		
		//clear input buffer
		while (getchar() != '\n');
	}
	while(1);
}

void emptyBoard(char board[SIZE][SIZE])
{
	int i, j;
	for (i = 0; i < SIZE; i++)
	{
		for (j = 0; j < SIZE; j++)
		{
			board[i][j] = ' ';
		}
	}
}

void drawBoard(char board[SIZE][SIZE], int winningPositions[3][2])
{
	int i, j, k;
	printf("\nCurrent board: \n");
	printf("\n");
	for (i = 0; i < SIZE; i++)
	{
		for (j = 0; j < SIZE; j++)
		{
			int count = i * SIZE + j + 1;
			int isWinningMove = 0;
			for (k = 0; k < 3; k++)
			{
				if (winningPositions[k][0] == i && winningPositions[k][1] == j)
				{
					isWinningMove = 1;
					break;
				}
			}
			
			if (isWinningMove)
			{
				printf(" ", board[i][j]);
			}
			else if (board[i][j] == ' ')
			{
				printf(" %d ", count);
			}
			else
			{
				printf(" %c ", board[i][j]);
			}
			if (j < SIZE - 1)
			{
				printf("|");
			}
		}
		printf("\n");
		if (i < SIZE - 1)
		{
			printf("---|---|---\n");
		}
	}
}

//determine winner
int checkWinner(char board[SIZE][SIZE], char player, int winningPositions[3][2])
{
    int i, j;
    //reset winning position
    for (i = 0; i < SIZE; i++)
    {
        winningPositions[i][0] = -1;
        winningPositions[i][1] = -1;
    }

    for (i = 0; i < SIZE; i++)
    {
        //check rows
        if (board[i][0] == player && board[i][1] == player && board[i][2] == player)
        {
            //highlight winning row
            for (j = 0; j < SIZE; j++)
            {
                winningPositions[j][0] = i;
                winningPositions[j][1] = j;
            }
            return 1;
        }
        //check columns
        if (board[0][i] == player && board[1][i] == player && board[2][i] == player)
        {
            //highlight winning column
            for (j = 0; j < SIZE; j++)
            {
                winningPositions[j][0] = j;
                winningPositions[j][1] = i;
            }
            return 1;
        }
    }
    //check diagonals
    if (board[0][0] == player && board[1][1] == player && board[2][2] == player)
    {
        //highlight winning diagonal
        for (i = 0; i < SIZE; i++)
        {
            winningPositions[i][0] = i;
            winningPositions[i][1] = i;
        }
        return 1;
    }
    if (board[0][2] == player && board[1][1] == player && board[2][0] == player)
    {
        //highlight winning diagonal
        for (i = 0; i < SIZE; i++)
        {
            winningPositions[i][0] = i;
            winningPositions[i][1] = (SIZE - 1) - i;
        }
        return 1;
    }
    return 0;
}

int checkDraw(char board[SIZE][SIZE])
{
	int i, j;
	for (i = 0; i < SIZE; i++)
	{
		for (j = 0; j < SIZE; j++)
		{
			if (board[i][j] == ' ')
			{
				return 0;
			}
		}
	}
	return 1; 
}
