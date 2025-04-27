#include <stdio.h>

int sumAtRange(int x[], int size, int start, int end);

int main()
{
    int size, i, start, end;
    printf("Enter size of array: ");
    scanf("%d", &size);
    int x[size];
    printf("Enter array values: ");
    for (i = 0; i < size; i++)
    {
        scanf("%d", &x[i]);
    }
    printf("Enter starting range: ");
    scanf("%d", &start);
    printf("Enter end range: ");
    scanf("%d", &end);
    int sum = sumAtRange(x, size, start, end);
    printf("Sum at range: %d", sum);
}

int sumAtRange(int x[], int size, int start, int end)
{
    int sum = 0;
    // Adjust start and end indexes if they are out of array bounds
    start = (start < 0) ? 0 : start;
    end = (end >= size) ? size + 1 : end;

    // Calculate sum within the range
    for (int i = start; i <= end; i++) // Corrected condition
    {
        sum += x[i];
    }
    return sum;
}
