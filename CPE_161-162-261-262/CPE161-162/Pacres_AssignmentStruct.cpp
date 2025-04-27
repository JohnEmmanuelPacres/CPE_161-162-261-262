#include <stdio.h>
#include <stdlib.h>

struct date
{
	int day;
	int month;
	int year;
};

struct employee
{
	char name[50];
	char id[50];
	struct date bd;
	float salary;
};

int main()
{
	struct employee emp;
	
	printf("Enter employee name: ");
	scanf("%[^\n]", &emp.name);
	fflush(stdin);
	
	printf("Enter employee ID: ");
	scanf("%[^\n]", &emp.id);
	fflush(stdin);
	
	printf("Enter employee date of birth (MM/DD/YYYY): ");
	scanf("%d %d %d", &emp.bd.month, &emp.bd.day, &emp.bd.year);
	fflush(stdin);
	
	printf("Enter employee salary: ");
	scanf("%f", &emp.salary);
	fflush(stdin);
	
	system("cls");
	
	printf("\nEmployee Details:\n");
	printf("Name: %s\n", emp.name);
	printf("ID: %s\n", emp.id);
	printf("Date of birth: %d / %d / %d\n", emp.bd.month, emp.bd.day, emp.bd.year);
	printf("Salary: %.2f\n", emp.salary);
	
	return 0;
}
