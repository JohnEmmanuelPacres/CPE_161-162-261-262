#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define MAX_NAME_LENGTH 50 // Define MAX_NAME_LENGTH
#define MAX_GRADEBOOKS 10  // Define maximum number of gradebooks
#define MAX_ASSIGNMENTS 100 // Define maximum number of assignments

// Define structure
typedef struct {
    char name[MAX_NAME_LENGTH];
    float *grades;
    float *percentages; // Add percentages array
    float overall_grade;
} Student;

// Function prototypes
void addStudent(Student *students, int *num_students, int max_students, int max_assignments);
void enterGrades(Student *students, int num_students, int max_assignments);
void calculateOverallGrades(Student *students, int num_students, int max_assignments);
void generateReport(Student *students, int num_students, int max_assignments);
void exportToCSV(Student *students, int num_students, int max_assignments);
void createGradebook(char *gradebook_name);
void uploadGradebook(char *gradebook_name);
void displayMenu();

int main() {
    int max_students;
    int num_students = 0;
    char choice;
    char gradebook_name[MAX_NAME_LENGTH];
    Student students[MAX_GRADEBOOKS]; // Array of students

    printf("Welcome to Gradebook Manager!\n");

    printf("Enter the maximum number of students: ");
    scanf("%d", &max_students);

    do {
        displayMenu();
        printf("Enter your choice: ");
        scanf(" %c", &choice);

        switch (choice) {
            case '1':
                createGradebook(gradebook_name);
                break;
            case '2':
                uploadGradebook(gradebook_name);
                break;
            case '3':
                // Gradebook operations menu
                printf("\nGradebook Operations Menu:\n");
                printf("1. Add Student\n");
                printf("2. Enter Grades\n");
                printf("3. Calculate Overall Grades\n");
                printf("4. Generate Report\n");
                printf("5. Export to CSV\n");
                printf("6. Return to Main Menu\n");
                printf("Enter your choice: ");
                scanf(" %c", &choice);
                switch (choice) {
                    case '1':
                        addStudent(students, &num_students, max_students, MAX_ASSIGNMENTS);
                        break;
                    case '2':
                        enterGrades(students, num_students, MAX_ASSIGNMENTS);
                        break;
                    case '3':
                        calculateOverallGrades(students, num_students, MAX_ASSIGNMENTS);
                        break;
                    case '4':
                        generateReport(students, num_students, MAX_ASSIGNMENTS);
                        break;
                    case '5':
                        exportToCSV(students, num_students, MAX_ASSIGNMENTS);
                        break;
                    case '6':
                        printf("Returning to Main Menu...\n");
                        break;
                    default:
                        printf("Invalid choice. Please try again.\n");
                }
                break;
            case '4':
                printf("Exiting...\n");
                break;
            default:
                printf("Invalid choice. Please try again.\n");
        }
    } while (choice != '4');

    // Free dynamically allocated memory
    for (int i = 0; i < num_students; i++) {
        free(students[i].grades);
        free(students[i].percentages); // Free percentages array
    }

    return 0;
}

void createGradebook(char *gradebook_name) {
    printf("Enter the name of the new gradebook: ");
    fflush(stdin); // Clear input buffer
    fgets(gradebook_name, MAX_NAME_LENGTH, stdin); // Read string including spaces
    // Remove newline character if present
    gradebook_name[strcspn(gradebook_name, "\n")] = '\0';
    printf("New gradebook '%s' created.\n", gradebook_name);
}

void uploadGradebook(char *gradebook_name) {
    printf("Enter the name of the gradebook to upload: ");
    fflush(stdin); // Clear input buffer
    fgets(gradebook_name, MAX_NAME_LENGTH, stdin); // Read string including spaces
    // Remove newline character if present
    gradebook_name[strcspn(gradebook_name, "\n")] = '\0';
    printf("Gradebook '%s' uploaded.\n", gradebook_name);
}

void displayMenu() {
    printf("\nMain Menu:\n");
    printf("1. Create New Gradebook\n");
    printf("2. Upload Gradebook\n");
    printf("3. Select Gradebook and Perform Operations\n");
    printf("4. Exit\n");
}

void addStudent(Student *students, int *num_students, int max_students, int max_assignments) {
    if (*num_students < max_students) {
        printf("Enter student name: ");
        scanf("%s", students[*num_students].name);
        students[*num_students].grades = (float *)malloc(max_assignments * sizeof(float));
        students[*num_students].percentages = (float *)malloc(max_assignments * sizeof(float)); // Allocate memory for percentages array
        if (students[*num_students].grades == NULL || students[*num_students].percentages == NULL) {
            printf("Memory allocation failed.\n");
            return;
        }
        printf("Enter total score for each assignment:\n");
        for (int i = 0; i < max_assignments; i++) {
            printf("Total score for assignment %d: ", i + 1);
            scanf("%f", &students[*num_students].grades[i]);
        }
        (*num_students)++;
    } else {
        printf("Cannot add more students. Maximum limit reached.\n");
    }
}

void enterGrades(Student *students, int num_students, int max_assignments) {
    char student_name[MAX_NAME_LENGTH];
    int i, j;

    printf("Enter student name: ");
    scanf("%s", student_name);

    for (i = 0; i < num_students; i++) {
        if (strcmp(students[i].name, student_name) == 0) {
            printf("Enter scores for %s (Enter -1 to stop):\n", students[i].name);
            for (j = 0; j < max_assignments; j++) {
                printf("Enter score for assignment %d (or -1 to stop): ", j + 1);
                scanf("%f", &students[i].percentages[j]);
                if (students[i].percentages[j] == -1) {
                    printf("Score entry stopped for %s.\n", students[i].name);
                    return;
                }
            }
            // Calculate percentages based on total score
            for (j = 0; j < max_assignments; j++) {
                students[i].percentages[j] = (students[i].percentages[j] / students[i].grades[j]) * 100;
            }
            printf("Scores entered successfully for %s.\n", students[i].name);
            return;
        }
    }

    printf("Student not found.\n");
}

void calculateOverallGrades(Student *students, int num_students, int max_assignments) {
    int i, j;
    float total;

    for (i = 0; i < num_students; i++) {
        total = 0;
        for (j = 0; j < max_assignments; j++) {
            total += students[i].percentages[j]; // Calculate overall grade using percentages
        }
        students[i].overall_grade = total / max_assignments;
    }

    printf("Overall grades calculated successfully.\n");
}

void generateReport(Student *students, int num_students, int max_assignments) {
    int i, j;

    printf("Student\t\tOverall Grade\n");
    printf("-------\t\t-------------\n");
    for (i = 0; i < num_students; i++) {
        printf("%s\t\t%.2f\n", students[i].name, students[i].overall_grade);
        printf("Assignment\tPercentage\n");
        for (j = 0; j < max_assignments; j++) {
            printf("%d\t\t%.2f%%\n", j + 1, students[i].percentages[j]);
        }
        printf("\n");
    }
}

void exportToCSV(Student *students, int num_students, int max_assignments) {
    FILE *csv_file;
    int i, j;

    csv_file = fopen("gradebook.csv", "w");

    if (csv_file == NULL) {
        printf("Error opening file for writing.\n");
        return;
    }

    // Write header
    fprintf(csv_file, "Name,");
    for (j = 0; j < max_assignments; j++) {
        fprintf(csv_file, "Assignment %d,", j + 1);
    }
    fprintf(csv_file, "Overall Grade\n");

    // Write data
    for (i = 0; i < num_students; i++) {
        fprintf(csv_file, "%s,", students[i].name);
        for (j = 0; j < max_assignments; j++) {
            fprintf(csv_file, "%.2f,", students[i].percentages[j]); // Write percentages to file
        }
        fprintf(csv_file, "%.2f\n", students[i].overall_grade);
    }

    fclose(csv_file);

    printf("Data exported to gradebook.csv successfully.\n");
}
