#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX_NAME_LENGTH 50
#define MAX_ASSIGNMENTS 10

// Define a structure for a student
typedef struct {
    char name[MAX_NAME_LENGTH];
    float grades[MAX_ASSIGNMENTS];
    int numAssignments;
} Student;

// Function prototypes
Student* createStudent(const char *name, int numAssignments);
void enterGrades(Student *student);
float calculateAverage(Student *student);
void generateReport(Student *student);

int main() {
    int numStudents, numAssignments;
    printf("Enter the number of students: ");
    scanf("%d", &numStudents);
    printf("Enter the number of assignments: ");
    scanf("%d", &numAssignments);

    // Allocate memory for an array of students
    Student *students = (Student *)malloc(numStudents * sizeof(Student));

    // Input students' information
    for (int i = 0; i < numStudents; i++) {
        char name[MAX_NAME_LENGTH];
        printf("Enter name of student %d: ", i + 1);
        scanf("%s", name);
        students[i] = *createStudent(name, numAssignments);
    }

    // Input grades for each student
    for (int i = 0; i < numStudents; i++) {
        printf("\nEnter grades for student %s:\n", students[i].name);
        enterGrades(&students[i]);
    }

    // Generate report for each student
    for (int i = 0; i < numStudents; i++) {
        generateReport(&students[i]);
    }

    // Free dynamically allocated memory
    free(students);

    return 0;
}

// Function to create a new student
Student* createStudent(const char *name, int numAssignments) {
    Student *student = (Student *)malloc(sizeof(Student));
    strcpy(student->name, name);
    student->numAssignments = numAssignments;
    return student;
}

// Function to input grades for a student
void enterGrades(Student *student) {
    for (int i = 0; i < student->numAssignments; i++) {
        printf("Enter grade for assignment %d: ", i + 1);
        scanf("%f", &student->grades[i]);
    }
}

// Function to calculate the average grade of a student
float calculateAverage(Student *student) {
    float sum = 0;
    for (int i = 0; i < student->numAssignments; i++) {
        sum += student->grades[i];
    }
    return sum / student->numAssignments;
}

// Function to generate a report for a student
void generateReport(Student *student) {
    printf("\nReport for student: %s\n", student->name);
    printf("Grades:\n");
    for (int i = 0; i < student->numAssignments; i++) {
        printf("Assignment %d: %.2f\n", i + 1, student->grades[i]);
    }
    printf("Average Grade: %.2f\n", calculateAverage(student));
}
