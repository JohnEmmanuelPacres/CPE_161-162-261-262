#include<stdio.h>
#include <windows.h>
#include <MMSystem.h>
#include <string.h>

void play();
void stop();

int main()
{
	int choice;
	do
	{
		printf("\n Enter choice \n1. Play \n2. Stop \n3. Exit\n");
		scanf("%d", &choice);
		switch(choice)
		{
			case 1:
				play();
				break;
			case 2:
				stop();
				break;	
		}
	}
	while(choice != 3);
	return 0;
}

void stop()
{
	PlaySound(TEXT("STOPPED"), NULL, SND_APPLICATION);
}

void play()
{
	char songname[100];
	printf("Enter songname: ");
	scanf("%s", &songname);
	PlaySound(songname,NULL,SND_ASYNC);
	printf("\nPlaying Song");
}
