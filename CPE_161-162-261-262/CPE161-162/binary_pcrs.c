#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <conio.h>
#include <limits.h>

char *decimalToBinary(int num);
void printBinary(char* binary);

int main()
{
	int num;
	bool validity = false;
	char choice;
	
	while (!validity)
	{
		system ("cls");
		printf("PCRS Number Converter\n");
		printf("Enter an integer: ");
		
		if (scanf("%d", &num) == 1)
		{
			if (num >= 0)
			{
				if (num == 0)
				{
					printf("Binary: 0\n");
					getch();
					validity = true;
				}
				else
				{
					char *binary = decimalToBinary(num);
					printBinary(binary);
					getch();
					free(binary);
				}
				validity = true;
			}
			else
			{
				printf("Invalid. Please enter positive integer.\n");
				getch();
			}
		}
		else
		{
			printf("Invalid. Please enter positive integer.\n");
			while (getchar() != '\n');
			getch();
		}
		
		system("cls");
		printf("Do you want to convert another number? [Y/N]\n");
		scanf(" %c", &choice);
		
		if (choice == 'Y' || choice == 'y')
		{
			validity = false;
		}
		else
		{
			validity = true;
		}
	}
	return 0;
}

char *decimalToBinary(int num)
{
	int numBits = sizeof(int) * CHAR_BIT;
	char *binary = (char*)malloc(numBits + 1);
	if (binary == NULL)
	{
		printf("Memory allocation failed.");
		exit(1);
	}
	
	binary[numBits] = '\0';
	
	int i = numBits - 1;
	
	while (num > 0 && i >= 0)
	{
		binary[i] = (num % 2) + '0';
		num = num / 2;
		i--;
	}
	
	while (i >= 0)
	{
		binary[i] = '0';
		i--;
	}
	
	return binary;
}

void printBinary(char *binary)
{
	printf("Binary: %s\n", binary);
}
