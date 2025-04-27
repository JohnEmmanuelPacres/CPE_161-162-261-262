#include <stdio.h>

typedef struct {
    int id;
    char name[50];
    float grade;
} Student;

void addStudent(Student *gradebook, int *numStudents) {
    printf("Enter student ID: ");
    scanf("%d", &gradebook[*numStudents].id);
    printf("Enter student name: ");
    scanf("%s", gradebook[*numStudents].name);
    printf("Enter student grade: ");
    scanf("%f", &gradebook[*numStudents].grade);
    (*numStudents)++;
}

void removeStudent(Student *gradebook, int *numStudents, int id) {
    for (int i = 0; i < *numStudents; i++) {
        if (gradebook[i].id == id) {
            for (int j = i; j < *numStudents - 1; j++) {
                gradebook[j] = gradebook[j + 1];
            }
            (*numStudents)--;
            printf("Student with ID %d removed successfully.\n", id);
            return;
        }
    }
    printf("Student with ID %d not found.\n", id);
}

int main() {
    Student gradebook[100];
    int numStudents = 0;
    int choice, id;

    do {
        printf("\n1. Add student\n2. Remove student\n3. Exit\n");
        printf("Enter your choice: ");
        scanf("%d", &choice);

        switch (choice) {
            case 1:
                addStudent(gradebook, &numStudents);
                break;
            case 2:
                printf("Enter student ID to remove: ");
                scanf("%d", &id);
                removeStudent(gradebook, &numStudents, id);
                break;
            case 3:
                printf("Exiting...\n");
                break;
            default:
                printf("Invalid choice!\n");
        }
    } while (choice != 3);

    return 0;
}
