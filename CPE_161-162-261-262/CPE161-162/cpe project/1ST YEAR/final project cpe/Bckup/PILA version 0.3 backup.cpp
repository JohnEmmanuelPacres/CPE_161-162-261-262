#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <time.h>				//to do tomorrow: improve error handling and add search student
#include <math.h>
#include <ctype.h>
#include <string.h>
#include <stdbool.h>

#define PROFILE_FILE "profiles.txt"
#define MAX_NAME_LENGTH 100
#define MIN_LENGTH 8

//bookmark1
typedef struct 
{
	char username[50];
	char id[50];
	char password[50];
} UserProfile;

typedef struct
{
    int day;
    int month;
    int year;
} birthdate;

typedef struct
{
	char name[MAX_NAME_LENGTH];
    char gender;
    birthdate bd;
    float *assignments;
    float *exams;
    float *quizzes;
    float totalGrade;
} Student;

typedef struct
{
    float assignmentPerfect;
    float examPerfect;
    float quizPerfect;
} Perfect;
//function set 1
void MenuDisplay();
void writeUserProfile(const char *filename, const char *profile);
void readUserProfile(const char *filename);
void registerTeacher();
void loginTeacher();
//function set 2
void TeacherMenu(char *username, char *id);
void ProgressManagerTeacher(char *username, char *id);
//function set 3
void addStudent(Student *students, int *numStudents, int maxStudents, int maxAssignments, int maxExams, int maxQuizzes);
void calculateTotalGrade(Student *student, Perfect *perfect, int maxAssignments, int maxExams, int maxQuizzes, float percentageAssignments, float percentageExams, float percentageQuizzes);
void generateReport(Student *students, int numStudents);
void removeStudent(Student *students, int *numStudents, int indexToRemove);
void displayStudents(Student *students, int numStudents);
void enterPerfectScores(Perfect *perfect);
//function set 4
void ReadingLevelTracker(char *username, char *id);
char *askText(void);
void calculateReadingLevel(char *text);

void main()//bookmark1
{
	char choice;
	bool ValidChoice = false;
	
	system("cls");
	
	while (!ValidChoice)
	{
		system("COLOR 0A");
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
	
	system("cls");
	for (int i = 0; i < 15; i++)
	{
		printf("\n");
	}
	printf("\t\t\t\t\t REGISTER:\n");
	printf("\t\t\t\t\t Register teacher ID number: ");
	fgets(id, sizeof(id), stdin);
	id[strcspn(id, "\n")] = '\0';
	
	do
	{
		system("cls");
		for (int i = 0; i < 15; i++)
		{
			printf("\n");
		}
		printf("\t\t\t\t\t REGISTER:\n");
		printf("\t\t\t\t\t Register teacher password (minimum 8 characters): ");
		fgets(password, sizeof(password), stdin);
		password[strcspn(password, "\n")] = '\0';
		
		if (strlen(password) < MIN_LENGTH)
		{
			printf("\n\t\t\t\t\t Password must have at least 8 characters. Please try again.\n");
			getchar();
		}
	}
	while(strlen(password) < MIN_LENGTH);
	
	
	
	
	char profile[100];
	sprintf(profile, "user: %s, id: %s, pass: %s, teacher", username, id, password);
	writeUserProfile(PROFILE_FILE, profile);
	
	system("cls");
	for (int i = 0; i < 15; i++)
	{
		printf("\n");
	}
	printf("\t\t\t\t\t Teacher registered successfully. Press any keys to continue.");
	getchar();
	main();
}

void loginTeacher()
{
	system("cls");
	system("COLOR 0A");
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
		printf("\t\t\t\t\t Incorrect username, ID, or password. Please try again.\n");
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

void TeacherMenu(char *username, char *id) //bookmark2
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

void ProgressManagerTeacher(char *username, char *id) //bookmark3 
{
	system("cls");
	int maxStudents, maxAssignments, maxExams, maxQuizzes, maxPerfect;
    float percentageExams, percentageAssignments, percentageQuizzes;
	
	char choice;
	
	bool validity = false;
	
	system ("COLOR 0A");
	printf("\t\t\t Initializing needed data for gradebook...\n");

	printf("\n\t\t\t\t\t Enter the maximum number of students: ");
	scanf("%d", &maxStudents);	

	printf("\t\t\t\t\t Enter the maximum number of assignments: ");
    scanf("%d", &maxAssignments);
    
    printf("\t\t\t\t\t Enter the maximum number of exams: ");
	scanf("%d", &maxExams);
    
	printf("\t\t\t\t\t Enter the maximum number of quizzes: ");
    scanf("%d", &maxQuizzes);	
    
    float totalPercentage;
    
    while (totalPercentage != 100)
    {
    	system("cls");
    	system("COLOR 0A");
    	printf("\t\t\t Initializing needed data for gradebook...\n");
    	printf("\n\t\t\t\t\t Note: For better calculation, ensure total percentage is equivalent to 100.\n");
    	
		printf("\n\t\t\t\t\t Enter percentage for assignments: ");
    	scanf("%f", &percentageAssignments);
    
    	printf("\t\t\t\t\t Enter percentage for quizzes: ");
    	scanf("%f", &percentageQuizzes);
    
    	printf("\t\t\t\t\t Enter percentage for exams: ");
    	scanf("%f", &percentageExams);
    	
    	totalPercentage = percentageAssignments + percentageQuizzes + percentageExams;
    	
    	if (totalPercentage != 100)
    	{
    		system("COLOR 04");
    		printf("\n\t\t\t\t\t Total percentage is not equivalent to 100. Please try again.\n");
    		getch();
		}
	}
    
    printf("\n\t\t\t\t\t Information initialized successfully. Press any keys to continue.\n");
    getch();
    
    percentageAssignments /= 100;
    percentageExams /= 100;
    percentageQuizzes /= 100;

    maxPerfect = maxAssignments + maxExams + maxQuizzes;

    Student *students = (Student *)malloc(maxStudents * sizeof(Student));
    Perfect perfect;
    
    enterPerfectScores(&perfect);

    int numStudents = 0;
	
	while (1)
	{
		system("cls");
		system("COLOR 0A");
		printf("\n");
		printf("\t Welcome User %s!\n", username);
		printf("\t ID Number: %s", id);
		printf("\n");
		MenuDisplay();
		printf("\t\t\t\t\t 1. Add New Student\n");
		printf("\t\t\t\t\t 2. Generate Report\n");
		printf("\t\t\t\t\t 3. Remove Student\n");
		printf("\t\t\t\t\t 4. Adjust Perfect Scores\n");
		printf("\t\t\t\t\t 5. Return to Teacher Menu\n");
		printf("\n");
		printf("\t\t\t\t\t Choose your options: ");
		scanf("%s", &choice);
		getchar();
		
		switch (choice)
		{
			case '1':
				system("cls");
				printf("\n\t\t\t\t\t ADDING STUDENT...\n");
				addStudent(students, &numStudents, maxStudents, maxAssignments, maxExams, maxQuizzes);
				getchar();
            	break;
            case '2':
            	system("cls");
            	for (int i = 0; i < numStudents; i++)
            	{
                	calculateTotalGrade(&students[i], &perfect, maxAssignments, maxExams, maxQuizzes, percentageAssignments, percentageExams, percentageQuizzes);
            	}
            	generateReport(students, numStudents);
            	printf("\n\t\t\t\t\t Press any keys to continue.\n");
            	getch();
            	break;
            case '3':
            	if (numStudents > 0)
            	{
            		system("cls");
					printf("\n\t\t\t\t\t REMOVING STUDENT...\n");
                	int indexToRemove;
                	displayStudents(students, numStudents);
                	printf("\n\t\t\t\t\t Enter the index of the student to remove (starting from 0): ");
                	scanf("%d", &indexToRemove);
                	
                	if (indexToRemove >= 0 && indexToRemove < numStudents)
                	{
                    	system("cls");
						removeStudent(students, &numStudents, indexToRemove);
                    	printf("\n\t\t\t\t\t %s removed successfully. Press any keys to continue.\n", students[numStudents].name);
                    	getch();
                	}
                	else
                	{
                    	system("cls");
                    	system("COLOR 04");
						printf("\t\t\t\t\t Invalid index. Press any keys to continue.\n");
                    	getchar();
                	}
            	}
            	else
            	{
                	system("cls");
					system("COLOR 0D");
					for (int i = 0; i < 15; i++)
					{
						printf("\n");
					}
					printf("\t\t\t\t\t No students to remove. Press any keys to continue.\n");
                	getch();
            	}
            	break;
            case '4':
            	enterPerfectScores(&perfect);
            	break;
            case '5':
            	printf("\n\t\t\t\t\t Returning to teacher menu...\n");
            	for (int i = 0; i < numStudents; i++)
            	{
                	free(students[i].assignments);
                	free(students[i].exams);
                	free(students[i].quizzes);
            	}
            	free(students);
            	TeacherMenu(username, id);
        	default:
            	system("cls");
        		system("COLOR 04");
            	printf("\n\t\t\t\t\t Invalid choice. Please enter a valid option.\n");
            	getchar();	
		}
	}
}
//bookmark4
void addStudent(Student *students, int *numStudents, int maxStudents, int maxAssignments, int maxExams, int maxQuizzes)
{
    if (*numStudents >= maxStudents)
    {
        printf("\n\t\t\t\t\t Gradebook is full. Cannot add more students.\n");
        return;
    }

    printf("\n\t\t\t\t\t Enter student name: ");
    scanf("%[^\n]", students[*numStudents].name);
    getchar(); // Clear input buffer

    printf("\t\t\t\t\t Enter student sex [M/F]: ");
    scanf(" %c", &students[*numStudents].gender);
    getchar(); // Clear newline character from input buffer
    
    size_t len = strlen(students[*numStudents].name);
    if (len > 0 && students[*numStudents].name[len - 1] == '\n') 
    {
        students[*numStudents].name[len - 1] = '\0'; // Remove newline
    }    

    students[*numStudents].assignments = (float *)malloc(maxAssignments * sizeof(float));
    students[*numStudents].exams = (float *)malloc(maxExams * sizeof(float));
    students[*numStudents].quizzes = (float *)malloc(maxQuizzes * sizeof(float));

    printf("\n\t\t\t\t\t Enter grades for assignments (up to %d):\n", maxAssignments);
    for (int i = 0; i < maxAssignments; i++)
    {
        printf("\t\t\t\t\t Assignment %d: ", i + 1);
        scanf("%f", &students[*numStudents].assignments[i]);
    }

    printf("\n\t\t\t\t\t Enter grades for exams (up to %d):\n", maxExams);
    for (int i = 0; i < maxExams; i++)
    {
        printf("\t\t\t\t\t Exam %d: ", i + 1);
        scanf("%f", &students[*numStudents].exams[i]);
    }

    printf("\n\t\t\t\t\t Enter grades for quizzes (up to %d):\n", maxQuizzes);
    for (int i = 0; i < maxQuizzes; i++)
    {
        printf("\t\t\t\t\t Quiz %d: ", i + 1);
        scanf("%f", &students[*numStudents].quizzes[i]);
    }

    (*numStudents)++;
    
    printf("\n\t\t\t\t\t Student added successfully. Press any keys to continue.\n");
    getch();
}
//bookmark5
void removeStudent(Student *students, int *numStudents, int indexToRemove)
{
    free(students[indexToRemove].assignments);
    free(students[indexToRemove].exams);
    free(students[indexToRemove].quizzes);

    for (int i = indexToRemove; i < (*numStudents) - 1; i++)
    {
        students[i] = students[i + 1];
    }
    
    (*numStudents)--;
}

void calculateTotalGrade(Student *student, Perfect *perfect, int maxAssignments, int maxExams, int maxQuizzes, float percentageAssignments, float percentageExams, float percentageQuizzes)
{	
    float totalAssignments = 0;
    float totalExams = 0;
    float totalQuizzes = 0;

    for (int i = 0; i < maxAssignments; i++)
    {
        totalAssignments += student->assignments[i];
    }

    for (int i = 0; i < maxExams; i++)
    {
        totalExams += student->exams[i];
    }

    for (int i = 0; i < maxQuizzes; i++)
    {
        totalQuizzes += student->quizzes[i];
    }

    float perfectTotalAssignments = perfect->assignmentPerfect;
    float perfectTotalExams = perfect->examPerfect;
    float perfectTotalQuizzes = perfect->quizPerfect;
    
    student->totalGrade = ((totalAssignments / perfectTotalAssignments) * percentageAssignments + (totalExams / perfectTotalExams) * percentageExams + (totalQuizzes / perfectTotalQuizzes) * percentageQuizzes) * 100;
}

void generateReport(Student *students, int numStudents)
{
    printf("\n\t\t\t\t\t Student Report:\n");
    printf("\t\t\t\t\t -------------------------------------------------------------\n");
    printf("\t\t\t\t\t | %-20s | %-6s | %-10s |\n", "Name", "Gender", "Total Grade");
    printf("\t\t\t\t\t -------------------------------------------------------------\n");
    for (int i = 0; i < numStudents; i++)
    {
        printf("\t\t\t\t\t | %-20s | %-6c | %-10.2f |\n", students[i].name, students[i].gender, students[i].totalGrade);
    }
    printf("\t\t\t\t\t -------------------------------------------------------------\n");
}

void displayStudents(Student *students, int numStudents)
{
    printf("\n\t\t\t\t\t Choose students to drop out: \n");
    for (int i = 0; i < numStudents; i++)
    {
        printf("\t\t\t\t\t %d. Name: %s \t Gender: %c\n", i, students[i].name, students[i].gender);
    }
}

void enterPerfectScores(Perfect *perfect)
{
	system("cls");
	printf("\t\t\t Initializing needed data for gradebook...\n");
    printf("\n\t\t\t\t\t Enter perfect score for assignments: ");
    scanf("%f", &perfect->assignmentPerfect);

    printf("\t\t\t\t\t Enter perfect score for exams: ");
    scanf("%f", &perfect->examPerfect);

    printf("\t\t\t\t\t Enter perfect score for quizzes: ");
    scanf("%f", &perfect->quizPerfect);	
}

void ReadingLevelTracker(char *username, char *id) 
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

void calculateReadingLevel(char *text)
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
