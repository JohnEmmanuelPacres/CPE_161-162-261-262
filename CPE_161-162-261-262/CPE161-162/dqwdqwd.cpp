#include<stdio.h>

// Function to remove duplicates from the array and return the new size
int removeDuplicates(int arr[], int size);

int main()
{
    int size;
    printf("Enter size of array: ");
    scanf("%d", &size);

    int x[size];

    printf("Enter elements of the array:\n");
    for (int i = 0; i < size; i++)
    {
        scanf("%d", &x[i]);
    }

    // Call the function to remove duplicates
    int newSize = removeDuplicates(x, size);

    // Print the array after removing duplicates
    printf("\nArray after removing duplicates: ");
    for (int i = 0; i < newSize; i++)
    {
        printf("%d ", x[i]);
    }

    printf("\n");

    return 0;
}

// Function to remove duplicates from the array and return the new size
int removeDuplicates(int arr[], int size)
{
    if (size == 0 || size == 1)
        return size;

    int temp[size];

    // Initialize result index
    int j = 0;

    // Traverse input array
    for (int i = 0; i < size - 1; i++)
    {
        // If current element is not equal to next element, then store the current element
        if (arr[i] != arr[i + 1])
        {
            temp[j++] = arr[i];
        }
    }

    // Store the last element as it will always be unique
    temp[j++] = arr[size - 1];

    // Modify original array
    for (int i = 0; i < j; i++)
    {
        arr[i] = temp[i];
    }

    return j;
}
