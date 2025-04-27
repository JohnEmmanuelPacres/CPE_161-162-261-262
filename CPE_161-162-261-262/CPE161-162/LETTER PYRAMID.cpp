#include <stdio.h>

int main() 
{
    int rows, i, j;
    printf("Please enter the number of rows: ");
    scanf("%d", &rows);
    for (i = 1; i <= rows; i++) 
	{
        for (j = 2; j < 2 + i; j++) 
		{
            printf("%d", j); 
            if (j <= 2 + i - 1) 
			{
                printf("x"); 
            }
        }
        printf("\n");
    }

    return 0;
}
