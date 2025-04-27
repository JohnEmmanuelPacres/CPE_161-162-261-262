#include <stdio.h>
#include <stdlib.h>

/*1*/typedef/*1*/ struct variable {
    char name;
    double value;
} var;

int displayMenu(int* choice);
void displayStoredValues(var* vars, int size);
void storeValue(var* vars, int* size, double value);
double basicOperation();
long factorialOperation();
long factorial(int n);

int main(void) {
    var* vars = (/*2*/var*/*2*/)malloc(/*3*/sizeof(var)/*3*/);
    int choice, size = 0;

    printf("Scientific-ish Calculator\n");
    do {
        choice = displayMenu(&choice); 
        switch (choice) {
        case 1:
            storeValue(vars, &size, basicOperation());
            break;
        case 2:
            storeValue(vars, &size, /*4*/factorialOperation()/*4*/);
            break;
        case 3:
            /*5*/displayStoredValues/*5*/(vars, size);
            break;
        case 4:
            printf("\nGoodbye! Till next time...");
            break;
        }
    } while (choice != /*6*/4/*6*/);

    free(vars);
    return 0;
}

int displayMenu(/*7*/int* choice/*7*/) {
    printf("\n==========================");
    printf("\nSelect a Function");
    printf("\n==========================");
    printf("\n[1] Basic Operation");
    printf("\n[2] Factorial Operation");
    printf("\n[3] Display Stored Values");
    printf("\n[4] Shutdown Calculator");
    printf("\n==========================");
    printf("\nEnter Choice: ");
    scanf("%d", /*8*/choice/*8*/);

    return *choice;
}

void /*9*/displayStoredValues/*9*/(var* vars, /*10*/int size/*10*/) {
    printf("\n==========================");
    printf("\nStored Values");
    printf("\n==========================");
    printf("\nName\tValue\n");
    for (int i = 0; i < size; i++) {
        printf("%c\t%.2lf\n", /*11*/vars[i].name, vars[i].value);
    }
    printf("\n==========================\n");
}

void storeValue(var* vars, /*12*/int* size/*12*/, double value) {
    char choice;

    printf("\nStore value after operation? (y/n): ");
    scanf(" %c", /*13*/&choice/*13*/);

    if (choice == 'y') {
        printf("\nEnter name of the variable: ");
        scanf(" %c", &vars[*size].name);
        vars[*size].value = value;
        vars = (var*) /*14*/realloc (vars, ((++*size)+1)* sizeof (/*15*/variable)); 
    }
}

double basicOperation() {
    char operand;
    double x, y;
    double result = 0;

    printf("\nEnter the first value: ");
    scanf("%lf", &x);
    printf("Enter the operand [+, -, *, /]: ");
    scanf(" %c", &operand); 
    printf("Enter the second value: ");
    scanf("%lf", &y);

    switch (/*16*/operand/*16*/) { 
    case '+':
        result = x + y;
        break;
    case '-':
        result = x - y;
        break;
    case '*':
        result = x * y;
        break;
    case '/':
        result = x / y;
        break;
    }

    printf("\nResult: %.2lf", result);
    return /*17*/result/*17*/;
}

long /*18*/factorialOperation/*18*/() {
    int n;
    long result;
    printf("\nEnter a number: ");
    scanf("%d", &n);

    result = /*19*/factorial/*19*/(n);

    printf("\nResult: %ld", result);
    return result;
}

long factorial(int n) {
    if (n == 0 || n == 1)
        return 1;
    else
        return n * /*20*/factorial(n - 1)/*20*/;
}

