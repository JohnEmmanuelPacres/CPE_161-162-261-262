#include <stdio.h>
#include <stdlib.h>
#include <string.h>

struct Student {
    char name[50];
    float prelim_exam, midterm_exam, prefinal_exam, final_exam;
    float midterm_grade, final_grade;
    float midterm_quizzes, midterm_assignments;
    float final_quizzes, final_assignments;
};

struct Section {
    struct Student *students;
    int student_count;
    int max_students;
};

void addStudent(struct Section *section);
void removeStudent(struct Section *section, int index);
void calculateMidtermGrade(struct Section *section);
void calculateFinalGrade(struct Section *section);
void generateReports();

void main() {//will implement
    struct Section section;
    section.student_count = 0;
    int choice;
    
    do {
        printf("\n1. Add Student\n");
        printf("2. Remove Student\n");
        printf("3. Calculate Midterm Grade\n");
        printf("4. Calculate Final Grade\n");
        printf("5. Exit\n");
        printf("Enter your choice: ");
        scanf("%d", &choice);
        
        switch (choice) {
            case 1:
                addStudent(&section);
                break;
            case 2:
                if (section.student_count > 0) {
                    int index;
                    printf("Enter index of student to remove: ");
                    scanf("%d", &index);
                    removeStudent(&section, index);
                } else {
                    printf("No students to remove.\n");
                }
                break;
            case 3:
                calculateMidtermGrade(&section);
                printf("Midterm grades calculated.\n");
                break;
            case 4:
                calculateFinalGrade(&section);
                printf("Final grades calculated.\n");
                break;
            case 5:
                printf("Exiting program.\n");
                break;
            default:
                printf("Invalid choice. Please enter a number between 1 and 5.\n");
        }
    } while (choice != 5);
    
    return 0;
}

void addStudent(struct Section *section) {//will implement
    if (section->student_count < section->max_students) {
        printf("Enter student name: ");
        fflush(stdin); // Clear input buffer
        fgets(section->students[section->student_count].name, sizeof(section->students[section->student_count].name), stdin);
        // Remove newline character if present
        size_t len = strlen(section->students[section->student_count].name);
        if (len > 0 && section->students[section->student_count].name[len - 1] == '\n') {
            section->students[section->student_count].name[len - 1] = '\0';
        }
        // Increment student count
        section->student_count++;
    } else {
        printf("Expanding section...\n");
        section->max_students *= 2;
        section->students = realloc(section->students, section->max_students * sizeof(struct Student));
        if (section->students == NULL) {
            printf("Memory allocation failed. Exiting program.\n");
            exit(1);
        }
        // Add new student after expanding
        printf("Enter student name: ");
        fflush(stdin); // Clear input buffer
        fgets(section->students[section->student_count].name, sizeof(section->students[section->student_count].name), stdin);
        // Remove newline character if present
        size_t len = strlen(section->students[section->student_count].name);
        if (len > 0 && section->students[section->student_count].name[len - 1] == '\n') {
            section->students[section->student_count].name[len - 1] = '\0';
        }
        // Increment student count
        section->student_count++;
    }
}

void removeStudent(struct Section *section, int index) {// will implement
    if (index >= 0 && index < section->student_count) {
        for (int i = index; i < section->student_count - 1; i++) {
            section->students[i] = section->students[i + 1];
        }
        // Decrement student count
        section->student_count--;
        printf("Student removed successfully.\n");
    } else {
        printf("Invalid student index.\n");
    }
}

void calculateMidtermGrade(struct Section *section) {
    // Display students in the section
    printf("Students in the section:\n");
    for (int i = 0; i < section->student_count; i++) {
        printf("%d. %s\n", i + 1, section->students[i].name);
    }
    
    // Choose a student
    int student_choice;
    printf("Enter the number of the student to manage: ");
    scanf("%d", &student_choice);
    if (student_choice < 1 || student_choice > section->student_count) {
        printf("Invalid student number.\n");
        return;
    }
    
    // Selecting the chosen student
    struct Student *student = &section->students[student_choice - 1];
    
    // Input score for the preliminary exam
    printf("Enter score for the preliminary exam: ");
    scanf("%f", &student->prelim_exam);
    
    // Input scores for quizzes (midterm only)
    int num_quizzes;
    printf("Enter number of quizzes for the midterm: ");
    scanf("%d", &num_quizzes);
    float quizzes_total = 0.0;
    for (int i = 0; i < num_quizzes; i++) {
        printf("Quiz %d: ", i + 1);
        scanf("%f", &student->midterm_quizzes);
        quizzes_total += student->midterm_quizzes;
    }
    
    // Input scores for assignments (midterm only)
    int num_assignments;
    printf("Enter number of assignments for the midterm: ");
    scanf("%d", &num_assignments);
    float assignments_total = 0.0;
    for (int i = 0; i < num_assignments; i++) {
        printf("Assignment %d: ", i + 1);
        scanf("%f", &student->midterm_assignments);
        assignments_total += student->midterm_assignments;
    }
    
    // Input score for the midterm exam
    printf("Enter score for the midterm exam: ");
    scanf("%f", &student->midterm_exam);
    
    // Calculate midterm grade
    float prelim_weight = 0.2, quizzes_weight = 0.3, assignments_weight = 0.2, midterm_exam_weight = 0.3;
    student->midterm_grade = prelim_weight * 2 * student->prelim_exam +
                             quizzes_weight * (quizzes_total) +
                             assignments_weight * (assignments_total) +
                             student->midterm_exam / 0.8 * 3;
    float mega_total = student->midterm_grade/10;
    
    printf("Midterm grade calculated for %s: %.2f\n", student->name, mega_total);
}

void calculateFinalGrade(struct Section *section) {//change
    float midterm_grade_weight = 0.4, quizzes_weight = 0.18, assignments_weight = 0.12,
          prefinal_exam_weight = 0.12, final_exam_weight = 0.18;
    
    for (int i = 0; i < section->student_count; i++) {
        struct Student *student = &section->students[i];
        student->final_grade = midterm_grade_weight * student->midterm_grade +
                               quizzes_weight * student->final_quizzes +
                               assignments_weight * student->final_assignments +
                               prefinal_exam_weight * student->prefinal_exam +
                               final_exam_weight * student->final_exam;
    }
}

void generateReports()
{
	
}


