#include<stdio.h>
#include<stdbool.h>
#include<stdlib.h>
#include<string.h>
int main()
{
char bp[10];
bool toPrint = false;
printf("reply sa gc: ");
scanf("%s", &bp);

if (strcmp(bp, "long") == 0 || strcmp(bp, "short") == 0)
{
toPrint = true;
}
else
{
printf("wa man ni reply sa gc.. ako nalang mag pa print ogma sa backgate\n");
return 0;
}

printf("ikaw na bahala print, juliana..\n");
return 0;
}
