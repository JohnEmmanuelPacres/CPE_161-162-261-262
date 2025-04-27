#include <stdio.h>

int main()
{
int arr[] = {10, 20, 30, 40, 50};
int *ptr = arr;

// Accessing elements using pointer arithmetic
for (int i = 0; i < 5; i++) {
    printf("Element %d: %p\n", i, *(ptr + i));
}
}
