#include <stdio.h>

int main() {
    int totalFuel, fuelToDispense;
    printf("Enter the total amount of fuel in the tank: ");
    scanf("%d", &totalFuel);

    
    if (totalFuel < 0) 
	{
        printf("Not enough fuel available.\n");
        printf("Remaining fuel: %d\n", totalFuel);
        return 0; 
    }

    do 
	{
        
        printf("Enter the amount of fuel to dispense (enter 0 to stop): ");
        scanf("%d", &fuelToDispense);

        
        if (fuelToDispense == 0) 
		{
            break;
        }

       
        if (fuelToDispense > totalFuel) 
		{
            printf("Not enough fuel available.\n");
            printf("Remaining fuel: %d\n", totalFuel);
        } 
		else 
		{
            // Dispense the fuel
            totalFuel -= fuelToDispense;
            printf("%d liters dispensed.\n", fuelToDispense);
            printf("Remaining fuel: %d\n", totalFuel);
        }

        
        if (totalFuel == 0) 
		{
            printf("Out of fuel.\n");
        }

    } while (totalFuel > 0);

    return 0;
}

