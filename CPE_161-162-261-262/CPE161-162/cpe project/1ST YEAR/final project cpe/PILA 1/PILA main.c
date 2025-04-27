#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <time.h>
#include <math.h>
#include <ctype.h>
#include <string.h>
#include <stdbool.h>

struct date
{
	int day;
	int month;
	int year;
};

typedef struct teacher
{
	char name[50];
	char id[50];
	struct date bd;
	int yr_lvl;
}
teacher;

typedef struct student
{
	char name[50];
	char id[50];
	struct date bd;
	int yr_lvl;
}
student;

void MainMenu();
void TeacherIntroduction();
void StudentIntroduction();
void TeacherMenu(teacher *tchr);
void StudentMenu(student *stdnt);

int main()
{
	char choice;
	bool ValidChoice = false;
	
	system("cls");
	
	while (!ValidChoice)
	{
		system("COLOR 02");
		MainMenu();
		printf("\t\t\t\t\t Are you a:\n");
		printf("\t\t\t\t\t 1. Teacher\n");
		printf("\t\t\t\t\t 2. Student\n");
		printf("\t\t\t\t\t 3. Exit Application\n");
		printf("\n");
		printf("\t\t\t\t\t Enter 1 for Teacher, 2 for Student, and 3 for Exit: ");
		
		scanf(" %c", &choice);
		
		if (choice == '1' || choice == '2' || choice == '3')
		{
			ValidChoice = true;
		}
		else
		{
			system ("cls");
			system("COLOR 04");
			for (int i = 0; i < 15; i++)
			{
				printf("\n");
			}
			printf("\t\t\t\t\t Invalid input. Please try again. Press any button to continue..\n");
			getch();
			system("cls");
		}
	}
	
	switch (choice)
	{
		case '1':
			TeacherIntroduction();
			break;
		case '2':
			StudentIntroduction();
			break;
		case '3':
			printf("\t\t\t\t\t Exiting application. Press any button to close..\n");
			getch();
			exit(0);
		default:
			printf("\t\t\t\t\t Invalid input. Please try again. Press any button to continue..\n");
			break;
	}
}

void MainMenu()
{
	printf("\t\t\t\t\t******************************************\n");
	printf("\n");
	printf("\t\t\t\t\t* Pacres Integrated Learning Application *\n");
	printf("\n");
	printf("\t\t\t\t\t******************************************\n");
	printf("\n");
	printf("\t\t\t\t\t PPPPPP    CCCCCC RRRRRR   SSSSSS    \n"); //LOGO
    printf("\t\t\t\t\t P     P  C       R     R S          \n");
    printf("\t\t\t\t\t PPPPPP  C        RRRRRR   SSSSS     \n");
    printf("\t\t\t\t\t P       C        R  R          S    \n");
    printf("\t\t\t\t\t P        C       R   R          S   \n");
    printf("\t\t\t\t\t P         CCCCCC R    R   SSSSSS    \n");
    printf("\n");
}

void TeacherIntroduction()
{
	teacher tchr;
	system("cls");
	system("COLOR 03");
	
	for (int i = 0; i < 15; i++)
	{	
		printf("\n");
	}
	printf("\t\t\t\t\t\t What is your name? ");
    fflush(stdin);
    fgets(tchr.name, sizeof(tchr.name), stdin);
    tchr.name[strcspn(tchr.name, "\n")] = '\0';
	
	system("cls");
	for (int i = 0; i < 15; i++)
	{	
		printf("\n");
	}
	printf("\t\t\t\t\t\t Please input your ID number: ");
	scanf("%[^\n]", &tchr.id);
	fflush(stdin);
	
	bool validDate = false;
	while (!validDate)
	{
		system("COLOR 03");
		system("cls");
		for (int i = 0; i < 15; i++)
		{	
			printf("\n");
		}
		printf("\t\t\t\t\t\t Please input your birthdate (MM/DD/YYYY): ");
		scanf("%d %d %d", &tchr.bd.month, &tchr.bd.day, &tchr.bd.year);
		
		if (tchr.bd.month <= 12 && tchr.bd.month > 0 && tchr.bd.day <= 30 && tchr.bd.day > 0 && tchr.bd.year <= 2024 && tchr.bd.year > 1900)
		{
			validDate = true;
		}
		else
		{
			system("cls");
			system("COLOR 04");
			for (int i = 0; i < 15; i++)
			{
				printf("\n");
			}
			printf("\t\t\t\t\t Invalid date. Please try again. Press any button to continue..\n");
			getch();
			system("cls");
		}
		fflush(stdin);
	}
	
	bool validYrLvl = false;
	while (!validYrLvl)
	{
		system("COLOR 03");
		system("cls");
		for (int i = 0; i < 15; i++)
		{	
			printf("\n");
		}
		printf("\t\t\t\t\t\t Please input year level that you are teaching: ");
		scanf("%d", &tchr.yr_lvl);
		
		if (tchr.yr_lvl > 0 && tchr.yr_lvl < 5)
		{
			validYrLvl = true;
		}
		else
		{
			system("cls");
			system("COLOR 04");
			for (int i = 0; i < 15; i++)
			{
				printf("\n");
			}
			printf("\t\t\t\t\t Invalid year level. Please try again. Press any button to continue..\n");
			getch();
			system("cls");
		}
		fflush(stdin);
	}
	
	TeacherMenu(&tchr);
}

void StudentIntroduction()
{
	student stdnt;
	system("cls");
	system("COLOR 0B");
	
	for (int i = 0; i < 15; i++)
	{	
		printf("\n");
	}
	printf("\t\t\t\t\t\t What is your name?: ");
    fflush(stdin);
    fgets(stdnt.name, sizeof(stdnt.name), stdin);
    stdnt.name[strcspn(stdnt.name, "\n")] = '\0';
	
	system("cls");
	for (int i = 0; i < 15; i++)
	{	
		printf("\n");
	}
	printf("\t\t\t\t\t\t Please input your ID number: ");
	scanf("%[^\n]", &stdnt.id);
	fflush(stdin);
	
	bool validDate = false;
	while (!validDate)
	{
		system("COLOR 0B");
		system("cls");
		for (int i = 0; i < 15; i++)
		{	
			printf("\n");
		}
		printf("\t\t\t\t\t\t Please input your birthdate (MM/DD/YYYY): ");
		scanf("%d %d %d", &stdnt.bd.month, &stdnt.bd.day, &stdnt.bd.year);
		
		if (stdnt.bd.month <= 12 && stdnt.bd.month > 0 && stdnt.bd.day <= 31 && stdnt.bd.day > 0 && stdnt.bd.year <= 2024 && stdnt.bd.year > 1900)
		{
			validDate = true;
		}
		else
		{
			system("cls");
			system("COLOR 04");
			for (int i = 0; i < 15; i++)
			{
				printf("\n");
			}
			printf("\t\t\t\t\t Invalid date. Please try again. Press any button to continue..\n");
			getch();
			system("cls");
		}
		fflush(stdin);
	}
	
	bool validYrLvl = false;
	
	while (!validYrLvl)
	{
		system("COLOR 0B");
		system("cls");
		for (int i = 0; i < 15; i++)
		{	
			printf("\n");
		}
		printf("\t\t\t\t\t\t Please input your current year level: ");
		scanf("%d", &stdnt.yr_lvl);
		
		if (stdnt.yr_lvl > 0 && stdnt.yr_lvl < 5)
		{
			validYrLvl = true;
		}
		else
		{
			system("cls");
			system("COLOR 04");
			for (int i = 0; i < 15; i++)
			{
				printf("\n");
			}
			printf("\t\t\t\t\t Invalid year level. Please try again. Press any button to continue..\n");
			getch();
			system("cls");
		}
		fflush(stdin);
	}
	
	StudentMenu(&stdnt);
}

void TeacherMenu(teacher *tchr)
{
	system("cls");
	printf("\n");
	printf("\t\t\t\t\t\t Welcome User %s", tchr->name);
}

void StudentMenu(student *stdnt)
{
	system("cls");
	printf("\n");
	printf("\t\t\t\t\t\t Welcome User %s", stdnt->name);
}
