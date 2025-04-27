#include <stdio.h>

int main()
{
	int num1, num2;
	printf("Input first integer: ");
	scanf("%d", &num1);
	
	printf("Input second integer: ");
	scanf("%d", &num2);
	
	float average = num1 + num2 / 2;
	
	if (average > 85)
	{
		printf("Average: %.2f", average);
	}
	
	return 0;
}
