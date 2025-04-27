#include <stdio.h>

int main(void)
{
	char *s = "BITCH";
	printf("%p\n", s);
	for (int i = 0; i < 5; i++)
	{
		printf("%p\n", &s[i]);
	}
}
