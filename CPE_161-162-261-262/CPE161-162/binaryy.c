#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <conio.h>
#include <limits.h>

char *decimalToBinary(int num);
void printBinary(char* binary);

int main()
{
    int num;
    bool validity = false;
    
    while (!validity)
    {
        system("cls");
        printf("PCRS Number Converter\n");
        printf("Enter a positive integer: ");
        
        // Check if input is successful (returns 1 if integer input)
        if (scanf("%d", &num) == 1)
        {
            if (num >= 0)
            {
                if (num == 0)
                {
                    printf("Binary: 0\n");
                }
                else
                {
                    char *binary = decimalToBinary(num);
                    printBinary(binary);
                    free(binary);
                }
                validity = true;
            }
            else
            {
                // Clear the input buffer
                while (getchar() != '\n');
                printf("Invalid. Please enter a positive integer.\n");
                printf("Press any key to continue...\n");
                getch(); // Wait for user to press a key
            }
        }
        else
        {
            // Clear the input buffer
            while (getchar() != '\n');
            printf("Invalid. Please enter a positive integer.\n");
            printf("Press any key to continue...\n");
            getch(); // Wait for user to press a key
        }
    }

    return 0;
}

char *decimalToBinary(int num)
{
    int numBits = sizeof(int) * CHAR_BIT;
    char *binary = (char*)malloc(numBits + 1);
    if (binary == NULL)
    {
        printf("Memory allocation failed.");
        exit(1);
    }
    
    binary[numBits] = '\0';
    
    int i = numBits - 1;
    
    while (num > 0 && i >= 0)
    {
        binary[i] = (num % 2) + '0';
        num = num / 2;
        i--;
    }
    
    while (i >= 0)
    {
        binary[i] = '0';
        i--;
    }
    
    return binary;
}

void printBinary(char *binary)
{
    printf("Binary: %s\n", binary);
}

