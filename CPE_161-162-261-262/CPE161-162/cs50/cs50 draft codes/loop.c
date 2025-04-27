#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int get_height(void);
void print_pyramid(int height);

int main()
{
	// ask height
	int height = get_height();
	//print pyramid
	print_pyramid(height);
	
	getch();
	return 0;
}

int get_height(void)
{
	int n;
	do
	{
		printf("Height: ");
		scanf("%d", &n);
	}
	while(n < 1 || n > 8);
	return n;
}

void print_pyramid(int height)
{
	int j, i;
	//rows
	for (i = 1; i <= height; i++)
	{
		//spaces
		for (j = 1; j <= height - i; j++)
		{
			printf(" ");
		}
		//left hash
		for (j = 1; j <= i; j++)
		{
			printf("#");
		}
		//gap
		printf("  ");
		//right hash
		for (j = 1; j <= i; j++)
		{
			printf("#");
		}
		printf("\n");
	}
}
