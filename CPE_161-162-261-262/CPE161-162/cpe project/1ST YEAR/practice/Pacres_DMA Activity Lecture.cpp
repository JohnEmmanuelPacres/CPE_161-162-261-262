#include <stdio.h>
#include <stdlib.h>

float calculateAverage(int *arr, int size);

int main()
{
    int i, newSize1, newSize2, initialSize = 5;

    int *arr1 = (int *)malloc(initialSize * sizeof(int));
    if (arr1 == NULL)
    {
        printf("Memory allocation failed...\n");
        return 1;
    }

    printf("Enter %d scores for the first array:\n", initialSize);
    for (i = 0; i < initialSize; i++)
    {
        scanf("%d", &arr1[i]);
    }

    printf("Enter the new size for the first array (greater than 5): ");
    scanf("%d", &newSize1);
    
    if(newSize1 < initialSize || newSize1 == initialSize)
    {
    	do
		{
			printf("Enter the new size for the first array (greater than 5): ");
			scanf("%d", &newSize1);
		}
		while(newSize1 < initialSize || newSize1 == initialSize);
	}

    arr1 = (int *)realloc(arr1, newSize1 * sizeof(int));
    if (arr1 == NULL)
    {
        printf("Memory reallocation failed...\n");
        return 1;
    }

    printf("Enter %d more scores for the first array:\n", newSize1 - initialSize);
    for (i = initialSize; i < newSize1; i++)
    {
        scanf("%d", &arr1[i]);
    }

    int *arr2 = (int *)calloc(initialSize, sizeof(int));
    if (arr2 == NULL)
    {
        printf("Memory allocation failed...\n");
        return 1;
    }

    printf("Enter %d scores for the second array: \n", initialSize);
    for (i = 0; i < initialSize; i++)
    {
        scanf("%d", &arr2[i]);
    }

    printf("Enter the new size for the second array (greater than 5): ");
    scanf("%d", &newSize2);
    
    if (newSize2 < initialSize || newSize2 == initialSize)
    {
    	do
		{
			printf("Enter the new size for the second array (greater than 5): ");
			scanf("%d", &newSize2);
		}
		while(newSize2 < initialSize || newSize2 == initialSize);
	}

    arr2 = (int *)realloc(arr2, newSize2 * sizeof(int));
    if (arr2 == NULL)
    {
        printf("Memory reallocation failed...\n");
        return 1;
    }

    printf("Enter %d more scores for the second array: \n", newSize2 - initialSize);
    for (i = initialSize; i < newSize2; i++)
    {
        scanf("%d", &arr2[i]);
    }

    printf("Average of first array (initial size %d): %.2f\n", initialSize, calculateAverage(arr1, initialSize));
    printf("Average of first array (size changed to %d): %.2f\n", newSize1, calculateAverage(arr1, newSize1));
    printf("Average of second array (initial size %d): %.2f\n", initialSize, calculateAverage(arr2, initialSize));
    printf("Average of second array (size changed to %d): %.2f\n", newSize2, calculateAverage(arr2, newSize2));

    free(arr1);
    free(arr2);

    return 0;
}

float calculateAverage(int *arr, int size)
{
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        sum += arr[i];
    }
    return (float)sum / size;
}
