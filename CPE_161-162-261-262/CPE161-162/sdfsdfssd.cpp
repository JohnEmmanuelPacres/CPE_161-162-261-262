#include <stdio.h>
#include <string.h>

#define MAX_SIZE 50

void stringConcat(char *dest, const char *src);
int main() 
{
    char dest[MAX_SIZE], src[MAX_SIZE];
    printf("Enter 1st string: ");
    scanf("%s", &dest);
    printf("Enter 2nd string: ");
    scanf("%s", &src);

    printf("String 1: %s\n", dest);
    printf("String 2: %s\n", src);

    stringConcat(dest, src);

    printf("Concatenated string: %s\n", dest);

    return 0;
}

void stringConcat(char *dest, const char *src) 
{
    while (*dest)
        dest++;

    while (*src) {
        *dest = *src;
        dest++;
        src++;
    }

    *dest = '\0';
}
