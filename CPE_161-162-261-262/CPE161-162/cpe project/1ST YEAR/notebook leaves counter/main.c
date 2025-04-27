#include <stdio.h>
#include <stdbool.h>

int main()
{
    int page, leaves;
    bool again = true;
    while (again)
    {
    	printf("Enter page/s used: ");
    scanf("%d", &page);
    	if(page==0){
        printf("No leaves used yet\n");
    }else if(page%2==0){
        leaves=page/2;

        if(leaves==1){
            printf("Used %d leaf\n", leaves);
        }else if(leaves!=1){
            printf("Used %d leaves\n", leaves);
        }

    }else if(page%2!=0){
        leaves=(page/2)+1;

        if(leaves==1){
            printf("Used %d leaf\n", leaves);
        }else if(leaves!=1){
            printf("Used %d leaves\n", leaves);
        }
    }
    char confirm;
    printf("Reattempt? ");
    scanf(" %c", &confirm);
    
    bool reattempt = true;
    
    if (confirm == 'y' || confirm == 'Y')
    {
    	reattempt = false;
    	again = true;
	}
	else if (confirm == 'n' || confirm == 'N')
	{
		reattempt = false;
		again = false;
	}
	else
	{
		printf("Invalid choice. Program terminating.");
		again = false;
	}
	
	}
    
    return 0;
}
