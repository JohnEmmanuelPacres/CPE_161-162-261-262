#include <stdio.h>
#include <string.h>
#include <ctype.h>
#include <stdlib.h>
#include <math.h>
#include <conio.h>

char *ask_text(void);
void calculate_readability(char *text);

int main(void)
{
    char *text = ask_text();
    calculate_readability(text);
    return 0;
}

char *ask_text(void)
{
    printf("Enter Text: ");
    char *text = malloc(1000 * sizeof(char)); // Adjust the size according to your needs
    fgets(text, 1000, stdin);
    text[strcspn(text, "\n")] = '\0'; // Remove trailing newline character
    return text;
}

void calculate_readability(char *text)
{
    int letters = 0;
    int words = 0; // Initialize words to 0
    int sentences = 0;

    for (int i = 0; text[i] != '\0'; i++)
    {
        if (isalpha(text[i]))
        {
            letters++;
        }
        else if (text[i] == ' ')
        {
            words++;
        }
        else if (text[i] == '.' || text[i] == '?' || text[i] == '!')
        {
            sentences++;
        }
    }

    words++; // Increment words to include the last word

    float L = (float) letters / (float) words * 100;
    float S = (float) sentences / (float) words * 100;
    int index = round(0.0588 * L - 0.296 * S - 15.8);
    
    printf("\nGrade level:\n");
    
    if (index >= 16)
    {
        printf("Grade 16+\n");
    }
    else if (index < 1)
    {
        printf("Preschool to Grade 1 Level\n");
    }
    else
    {
        printf("Grade %d\n", index);
    }
    
    getch();
    free(text);
}
