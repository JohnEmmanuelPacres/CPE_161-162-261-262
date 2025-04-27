#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <time.h>
#include <math.h>
#include <ctype.h>
#include <string.h>
#include <stdbool.h>

#define PROFILE_FILE "profiles.txt"
//bookmark1
typedef struct 
{
	char username[50];
	char id[50];
	char password[50];
}
UserProfile;

typedef struct
{
	
}
student;

void MenuDisplay();
void writeUserProfile(const char *filename, const char *profile);
void readUserProfile(const char *filename);
void registerTeacher();
void loginTeacher();

void TeacherMenu(char *username, char *id);

void ProgressManagerTeacher(char *username, char *id);
void addStudent();
void removeStudent();
void calculateGrades();
void generateReports();



void main()
{
	char choice;
	bool ValidChoice = false;
	
	system("cls");
	
	while (!ValidChoice)
	{
		system("COLOR 02");
		MenuDisplay();
		printf("\t\t\t\t\t 1. Register\n");
		printf("\t\t\t\t\t 2. Log In\n");
		printf("\t\t\t\t\t 3. Exit\n");
		printf("\n");
		printf("\t\t\t\t\t Choose your options: ");
		scanf("%s", &choice);
		getchar();
		
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
			printf("\t\t\t\t\t Invalid input. Please try again. Press any keys to continue.\n");
			getchar();
			system("cls");
		}
	}
	
	switch (choice)
	{
		case '1':
			registerTeacher();
			break;
		case '2':
			loginTeacher();
			break;
		case '3':
			printf("\t\t\t\t\t Exiting application. Press any keys to close..\n");
			getchar();
			exit(0);
		default:
			printf("\t\t\t\t\t Invalid input. Please try again. Press any keys to continue.\n");
			getchar();
			break;
	}
}

void MenuDisplay()
{
	printf("\t\t\t\t\t******************************************\n");
	printf("\n");
	printf("\t\t\t\t\t* Pacres Integrated Learning Application *\n");
	printf("\n");
	printf("\t\t\t\t\t******************************************\n");
	printf("\n");
	printf("\t\t\t\t\t PPPPPP    CCCCCC RRRRRR   SSSSSS    \n");
    printf("\t\t\t\t\t P     P  C       R     R S          \n");
    printf("\t\t\t\t\t PPPPPP  C        RRRRRR   SSSSS     \n");
    printf("\t\t\t\t\t P       C        R  R          S    \n");
    printf("\t\t\t\t\t P        C       R   R          S   \n");
    printf("\t\t\t\t\t P         CCCCCC R    R   SSSSSS    \n");
    printf("\n");
}

void writeUserProfile(const char *filename, const char *profile)
{
	FILE *file = fopen(filename, "a");
	if (file != NULL)
	{
		fprintf(file, "%s\n", profile);
		fclose(file);
	}
	else
	{
		printf("\n");
		system("COLOR 04");
		printf("\t\t\t\t\t Error writing file. Press any keys to continue.\n");
		getchar();
		system("cls");
	}
}

void readUserProfile(const char *filename)
{
	char buffer[100];
	FILE *file = fopen(filename, "r");
	if (file != NULL)
	{
		printf("Existing profiles:\n");
		while (fgets(buffer, sizeof(buffer), file) != NULL)
		{
			printf("%s", buffer);
		}
		fclose(file);
	}
	else
	{
		system ("cls");
		system("COLOR 04");
		for (int i = 0; i < 15; i++)
		{
			printf("\n");
		}
		printf("\t\t\t\t\t Error reading file. Press any keys to continue.\n");
		getchar();
		system("cls");
	}
}

void registerTeacher()
{
	system("cls");
	char username[50];
	char password[50];
	char id[50];
	
	for (int i = 0; i < 15; i++)
	{
		printf("\n");
	}
	printf("\t\t\t\t\t REGISTER:\n");
	printf("\t\t\t\t\t Register teacher username: ");
	fgets(username, sizeof(username), stdin);
	username[strcspn(username, "\n")] = '\0';
	printf("\t\t\t\t\t Register teacher ID number: ");
	fgets(id, sizeof(id), stdin);
	id[strcspn(id, "\n")] = '\0';
	printf("\t\t\t\t\t Register teacher password: ");
	fgets(password, sizeof(password), stdin);
	password[strcspn(password, "\n")] = '\0';
	
	char profile[100];
	sprintf(profile, "user: %s, id: %s, pass: %s, teacher", username, id, password);
	writeUserProfile(PROFILE_FILE, profile);
	
	system("cls");
	for (int i = 0; i < 15; i++)
	{
		printf("\n");
	}
	printf("\t\t\t\t\t Teacher registered successfully. Press any keys to continue.");
	main();
	getchar();
}

void loginTeacher()
{
	system("cls");
	system("COLOR 02");
	char username[50];
	char id[50];
	
	for (int i = 0; i < 15; i++)
	{
		printf("\n");
	}
	
	printf("\t\t\t\t\t LOG IN:\n");
	printf("\t\t\t\t\t Enter teacher username: ");
	fgets(username, sizeof(username), stdin);
	username[strcspn(username, "\n")] = '\0';
	
	printf("\t\t\t\t\t Enter teacher ID number: ");
	fgets(id, sizeof(id), stdin);
	id[strcspn(id, "\n")] = '\0';
	
	printf("\t\t\t\t\t Enter teacher password: ");
	char password[50];
	int i = 0;
	while(true)
	{
		char ch = _getch();
		if (ch == '\r')
		{
			password[i] = '\0';
			break;
		}
		else if (ch == '\b')
		{
			if (i > 0)
			{
				i--;
				printf("\b \b");
			}
		}
		else
		{
			password[i] = ch;
			i++;
			printf("*");
		}
	}
	
	char buffer[100];
	FILE *file = fopen(PROFILE_FILE, "r");
	bool found = false;
	if (file != NULL)
	{
		while (fgets(buffer, sizeof(buffer), file) != NULL)
		{
			char savedUsername[50], savedPassword[50], savedID[50], role[10];
			sscanf(buffer, "user: %[^,], id: %[^,], pass: %[^,], %s", savedUsername, savedID, savedPassword, role);
			if (strcmp(username, savedUsername) == 0 && strcmp(id, savedID) == 0 && strcmp(password, savedPassword) == 0 && strcmp(role, "teacher") == 0)
			{
				found = true;
				break;
			}
		}
		fclose(file);
	}
	else
	{
		system("cls");
		system("COLOR 08");
		for (int i = 0; i < 15; i++)
		{
			printf("\n");
		}
		printf("\t\t\t\t\t Error reading file. Press any keys to continue.\n");
		getchar();
		main();
	}
	
	if (found)
	{
		system("cls");
		for (int i = 0; i < 15; i++)
		{
			printf("\n");
		}
		printf("\t\t\t\t\t Teacher login successful. Press any keys to continue.\n");
		getchar();
		TeacherMenu(username, id);
	}
	else if (!found)
	{
		system("cls");
		system("COLOR 04");
		for (int i = 0; i < 15; i++)
		{
			printf("\n");
		}
		printf("\t\t\t Incorrect username, ID, or password. Please try again.\n");
		getchar();
		char choice;
		bool validChoice = false;
		while (!validChoice)
		{
			system("cls");
			system("COLOR 0E");
			printf("\n");
			printf("\t\t\t\t\t Return to main menu [Y] or Reattempt [N]? ");
			scanf("%s", &choice);
			getchar();
			if (choice == 'Y' || choice == 'y')
			{
				validChoice = true;
				main();
				getchar();
			}
			else if (choice == 'N' || choice == 'n')
			{
				validChoice = true;
				loginTeacher();
				getchar();
			}
			else
			{
				printf("\n");
				printf("\t\t\t\t\t Invalid choice. Press any keys to continue.");
				getchar();
			}
		}
	}
}

void TeacherMenu(char *username, char *id)
{
	char choice;
	bool validChoice = false;
	
	while (!validChoice)
	{
		system("cls");
		system("COLOR 0A");
		printf("\n");
		printf("\t Welcome User %s!\n", username);
		printf("\t ID Number: %s", id);
		printf("\n");
		MenuDisplay();
		printf("\t\t\t\t\t 1. Progress Manager\n");
		printf("\t\t\t\t\t 2. Reading Level Tracker\n");
		printf("\t\t\t\t\t 3. Main Menu\n");
		printf("\t\t\t\t\t 4. Exit\n");
		printf("\n");
		printf("\t\t\t\t\t Choose your options: ");
		scanf("%s", &choice);
		getchar();
		
		if (choice == '1' || choice == '2' || choice == '3' || choice == '4' || choice == '5')
		{
			validChoice = true;
		}
		else
		{
			system ("cls");
			system("COLOR 04");
			for (int i = 0; i < 15; i++)
			{
				printf("\n");
			}
			printf("\t\t\t\t\t Invalid input. Please try again. Press any keys to continue.\n");
			getchar();
			system("cls");
		}
	}
	
	switch (choice)
	{
		case '1':
			ProgressManagerTeacher(username, id);
			break;
		case '2':
			ReadingLevelTracker(username, id);
			break;
		case '3':
			main();
			break;
		case '4':
			printf("\t\t\t\t\t Exiting application. Press any keys to close..\n");
			getchar();
			exit(0);
			break;
		default:
			printf("\t\t\t\t\t Invalid input. Please try again. Press any keys to continue.\n");
			getchar();
			break;
	}
}

//bookmark2
void ProgressManagerTeacher(char *username, char *id) //teacher mode
{
	int choice, index;
	bool validChoice = false;
	
	while (!validChoice)
	{
		system("cls");
		system("COLOR 0A");
		MenuDisplay();
		printf("\t\t\t\t\t 1. Add student\n");
		printf("\t\t\t\t\t 2. Remove student\n");
		printf("\t\t\t\t\t 3. Search student\n");
		printf("\t\t\t\t\t 4. Display student\n");
		printf("\t\t\t\t\t 5. Calculate Grades\n");
		printf("\t\t\t\t\t 6. Generate Reports\n");
		printf("\t\t\t\t\t 7. Return to Teacher Menu\n");
		printf("\n");
		printf("\t\t\t\t\t Choose your options: ");
		scanf("%s", &choice);
		getchar();
}
//bookmark3
void addStudent()
{
    
}
//bookmark4
void removeStudent()
{

}

void calculateGrades()
{
	
}

void generateReports()
{
	
}

void ReadingLevelTracker(char *username, char *id) //teacher mode
{
	system("cls");
	system("COLOR 0A");
	char *text = askText();
	calculateReadingLevel(text);
	char choice;
	bool validChoice = false;
	
	while (!validChoice)
	{
		system("cls");
		system("COLOR 0E");
		printf("\n");
		printf("\t\t\t\t\t Return to teacher menu [Y]. Use again readability tracker [N]. ");
		scanf("%s", &choice);
		getchar();
		if (choice == 'Y' || choice == 'y')
		{
			validChoice = true;
			TeacherMenu(username, id);
			getchar();
		}
		else if (choice == 'N' || choice == 'n')
		{
			validChoice = true;
			ReadingLevelTracker(username, id);
			getchar();
		}
		else
		{
			system("cls");
			system("COLOR 04");
			printf("\n");
			printf("\t\t\t\t\t Invalid input. Press any keys to continue.");
			getchar();
		}
	}
}

char *askText(void) //teacher mode
{
	printf("\n");
	printf("\t\t\t\t\t This is based from Coleman-Liau Index\n");
	printf("\t\t\t\t\t (0.0588 * L) - (0.296 * S) - 15.8\n");
	printf("\t\t\t\t\t wherein:\n");
	printf("\t\t\t\t\t L = average number of letters per 100 words\n");
	printf("\t\t\t\t\t S = average number of sentences per 100 words\n");
	
	printf("\n\t\t\t\t\t READABILITY SCORE CARD: \n");
	for (int i = 1; i <= 17; i++)
	{
		printf("\t\t\t\t\t %d ", i);
		if (i <= 9)
		{
			printf(" ");
		}
		if (i == 1)
		{
			printf("Preschool to  Grade %d\n", i);
		}
		else if (i >= 13 && i <= 16)
		{
			printf("College level\n");
		}
		else if (i == 17)
		{
			printf("Professional\n");
		}
		else
		{
			printf("Grade %d\n", i);
		}
	}
	
	printf("\n\t\t\t\t\t Enter Text: ");
	char *text = malloc(1000*sizeof(char));
	fgets(text, 1000, stdin);
	text[strcspn(text, "\n")] = '\0';
	return text;
}

void calculateReadingLevel(char *text) //teacher mode
{
	int letters = 0, words = 0, sentences = 0;
	
	for (int i = 0; text[i] != '\0'; i++)
	{
		if (isalpha(text[i]))
		{
			letters++;
		}
		else if (text[i] == ' ')
		{
			words++;
		}
		else if (text[i] == '.' || text[i] == '?' || text[i] == '!')
		{
			sentences++;
		}
	}
	
	words++;
	
	float L = (float) letters / (float) words * 100;
	float S = (float) sentences / (float) words * 100;
	int index = round(0.0588 * L - 0.296 * S - 15.8);
	
	printf("\n\t\t\t\t\t Sum of letters: %d", letters);
	printf("\n\t\t\t\t\t Sum of words: %d", words);
	printf("\n\t\t\t\t\t Sum of sentences: %d", sentences);
	
	printf("\n\t\t\t\t\t Grade Level: ");

	if (index >= 16)
	{
		printf("Grade 17+\n");
	}
	else if (index < 1)
	{
		printf("Preschool to Grade 1\n");
	}
	else
	{
		printf("Grade %d", index);
	}
	getchar();
	free(text);
}
