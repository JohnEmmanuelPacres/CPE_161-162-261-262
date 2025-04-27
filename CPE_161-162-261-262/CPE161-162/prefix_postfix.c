#include <stdio.h>
#include <conio.h>
#include <stdbool.h>
#include <stdlib.h>

int main()
{
	int a, b;
	char choice, symbol;
	bool validity;
	symbol = '%';
	
	while(!validity)
	{
		system("cls");
		printf("Enter integer for variable 'a': ");
		scanf("%d", &a);
	
		b =  a++;
		printf("b = a++;\n");
		getch();
		printf("b is %d, and a is %d\n", b, a);
		getch();
	
		b = ++a;
		printf("\nb = ++a;\n");
		getch();
		printf("Now b is %d, and a is %d\n", b, a);
		getch();
	
		b = 5 % --a;
		printf("\nb = 5 %c --a;\n", symbol);
		getch();
		printf("Now b is %d, and a is %d\n", b, a);
		getch();
		printf("\nWhen ++b and a--\n");
		getch();
		printf("Now b is %d, and a is %d\n", ++b, a--);
		printf("Now b is %d, and a is %d\n", b, a);
		getch();
	
		printf("\nTry again [Y/N]?");
		scanf(" %c", &choice);
		
		if (choice == 'Y' || choice == 'y')
		{
			validity = false;
		}
		else if (choice == 'N' || choice == 'n')
		{
			printf("Exiting the program. Please press any button to continue...\n");
			getch();
			validity = true;
		}
		else
		{
			printf("Invalid choice. Please try again.\n");
			getch();
		}
	}
	return 0;
}
