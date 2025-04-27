#include <stdio.h>

void modifyValue(int** ptr) {
    **ptr = **ptr * 2;
}

int main() {
    int a = 5;
    int *ptr = &a;
    int **ptr_ptr = &ptr;
    
    printf("Initial value of a: %d\n", a);
    modifyValue(&ptr);
    printf("Value of a after modification: %d\n", a);
    
    return 0;
}
