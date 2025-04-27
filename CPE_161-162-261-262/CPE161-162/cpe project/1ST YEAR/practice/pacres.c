#include <stdio.h>
#include <stdlib.h>

void rotateRight(int *arr, int size, int k);
void rotateLeft(int *arr, int size, int k);


int main()
{
    int *arr = NULL;
    int size = 0;
    
    printf("Enter integer values to be stored in the array (enter non-positive or zero to stop)...\n");
    printf("\n");
    int value;
    while (1) 
	{
        printf("Enter value for the array at index #%d: ", size);
        scanf("%d", &value);
        if (value <= 0) 
		{
            break;
        }
        size++;
        arr = realloc(arr, size * sizeof(int));
        if (arr == NULL) 
		{
            printf("Memory allocation failed.\n");
            return 1;
        }
        arr[size - 1] = value;
    }
    
    printf("\nOriginal Array: [");
    for (int i = 0; i < size; i++) 
	{
        printf(" %d", arr[i]);
    }
    printf(" ]\n");
    
    int k;
    printf("\nEnter number of positions to shift: ");
    scanf("%d", &k);
    
    if (k > 0) 
	{
        rotateRight(arr, size, k);
    } 
	else if (k < 0) 
	{
        rotateLeft(arr, size, -k);
    }
    
    printf("\nShifted Array: [");
    for (int i = 0; i < size; i++) 
	{
        printf(" %d", arr[i]);
    }
    printf(" ]\n");
    
    free(arr);
    return 0;
}

void rotateRight(int *arr, int size, int k)
{
    int *temp = malloc(size * sizeof(int));
    if (temp == NULL) 
	{
        printf("Memory allocation failed.\n");
        return;
    }

    for (int i = 0; i < k; i++) 
	{
        temp[i] = arr[size - k + i];
    }

    for (int i = size - 1; i >= k; i--) 
	{
        arr[i] = arr[i - k];
    }
    
    for (int i = 0; i < k; i++) 
	{
        arr[i] = temp[i];
    }
    
    free(temp);
}

void rotateLeft(int *arr, int size, int k)
{
    int *temp = malloc(size * sizeof(int));
    if (temp == NULL) 
	{
        printf("Memory allocation failed.\n");
        return;
    }
    
    for (int i = 0; i < k; i++) 
	{
        temp[i] = arr[i];
    }
    
    for (int i = 0; i < size - k; i++) 
	{
        arr[i] = arr[i + k];
    }
    
    for (int i = size - k; i < size; i++) 
	{
        arr[i] = temp[i - (size - k)];
    }
    
    free(temp);
}

