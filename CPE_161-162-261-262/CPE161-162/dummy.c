#include <stdio.h>

int isPerfectSquare (long long age);
int main()
{
	long long birth_year, current_year, age;
	
	printf("Enter your birth year: ");
	scanf("%lld", &birth_year);
	printf("Enter the current year: ");
	scanf("%lld", &current_year);
	
	age = current_year - birth_year;
	
	if (isPerfectSquare(age))
		printf("Your age is a perfect square.\n");
	else
		printf("Your age is not a perfect square.\n");
	return 0;
}

int isPerfectSquare (long long age)
{
	double i, sqrt;
	if (age < 0)
	return 0;
	
	for (i = 0.01; i * i < age; i = i + 0.01);
		if ((long long)i * (long long)i == age)
		{
			return 1;
		}
		else
		{
			return 0;
		}
}
