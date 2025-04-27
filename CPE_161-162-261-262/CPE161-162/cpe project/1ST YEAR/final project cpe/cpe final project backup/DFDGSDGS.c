#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX_NAME_LENGTH 50

// Structure to represent student
typedef struct {
    char name[MAX_NAME_LENGTH];
    float *assignments;
    float *exams;
    float *quizzes;
    float totalGrade;
} Student;

// Function prototypes
void addStudent(Student *students, int *numStudents, int maxStudents, int maxAssignments, int maxExams, int maxQuizzes);
void calculateTotalGrade(Student *student, int maxAssignments, int maxExams, int maxQuizzes);
void generateReport(Student *students, int numStudents);

int main() {
    int maxStudents, maxAssignments, maxExams, maxQuizzes;

    printf("Enter the maximum number of students: ");
    scanf("%d", &maxStudents);
    
    printf("Enter the maximum number of assignments: ");
    scanf("%d", &maxAssignments);
    
    printf("Enter the maximum number of exams: ");
    scanf("%d", &maxExams);
    
    printf("Enter the maximum number of quizzes: ");
    scanf("%d", &maxQuizzes);

    Student *students = (Student *)malloc(maxStudents * sizeof(Student));
    int numStudents = 0;
    int choice;

    while (1) {
        printf("\nGradebook Menu:\n");
        printf("1. Add New Student\n");
        printf("2. Generate Report\n");
        printf("3. Exit\n");
        printf("Enter your choice: ");
        scanf("%d", &choice);

        switch (choice) {
            case 1:
                addStudent(students, &numStudents, maxStudents, maxAssignments, maxExams, maxQuizzes);
                break;
            case 2:
                for (int i = 0; i < numStudents; i++) {
                    calculateTotalGrade(&students[i], maxAssignments, maxExams, maxQuizzes);
                }
                generateReport(students, numStudents);
                break;
            case 3:
                printf("Exiting...\n");
                free(students);
                return 0;
            default:
                printf("Invalid choice. Please enter a valid option.\n");
        }
    }

    return 0;
}

// Function to add a new student to the gradebook
void addStudent(Student *students, int *numStudents, int maxStudents, int maxAssignments, int maxExams, int maxQuizzes) {
    if (*numStudents >= maxStudents) {
        printf("Gradebook is full. Cannot add more students.\n");
        return;
    }

    printf("Enter student name: ");
    getchar(); // Clear input buffer
    fgets(students[*numStudents].name, MAX_NAME_LENGTH, stdin);
    students[*numStudents].name[strcspn(students[*numStudents].name, "\n")] = '\0'; // Remove newline
    
    students[*numStudents].assignments = (float *)malloc(maxAssignments * sizeof(float));
    students[*numStudents].exams = (float *)malloc(maxExams * sizeof(float));
    students[*numStudents].quizzes = (float *)malloc(maxQuizzes * sizeof(float));

    printf("Enter grades for assignments (up to %d):\n", maxAssignments);
    for (int i = 0; i < maxAssignments; i++) {
        printf("Assignment %d: ", i + 1);
        scanf("%f", &students[*numStudents].assignments[i]);
    }

    printf("Enter grades for exams (up to %d):\n", maxExams);
    for (int i = 0; i < maxExams; i++) {
        printf("Exam %d: ", i + 1);
        scanf("%f", &students[*numStudents].exams[i]);
    }

    printf("Enter grades for quizzes (up to %d):\n", maxQuizzes);
    for (int i = 0; i < maxQuizzes; i++) {
        printf("Quiz %d: ", i + 1);
        scanf("%f", &students[*numStudents].quizzes[i]);
    }

    *numStudents += 1;
}

// Function to calculate the total grade for a student
void calculateTotalGrade(Student *student, int maxAssignments, int maxExams, int maxQuizzes) {
    float totalAssignments = 0;
    float totalExams = 0;
    float totalQuizzes = 0;

    for (int i = 0; i < maxAssignments; i++) {
        totalAssignments += student->assignments[i];
    }

    for (int i = 0; i < maxExams; i++) {
        totalExams += student->exams[i];
    }

    for (int i = 0; i < maxQuizzes; i++) {
        totalQuizzes += student->quizzes[i];
    }

    student->totalGrade = (totalAssignments / maxAssignments) * 0.4 + (totalExams / maxExams) * 0.3 + (totalQuizzes / maxQuizzes) * 0.3;
}

// Function to generate a report for all students
void generateReport(Student *students, int numStudents) {
    printf("Student\t\tTotal Grade\n");
    for (int i = 0; i < numStudents; i++) {
        printf("%s\t\t%.2f\n", students[i].name, students[i].totalGrade);
    }
}
