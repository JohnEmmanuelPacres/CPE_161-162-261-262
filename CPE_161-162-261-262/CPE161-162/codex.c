#include <stdio.h>

int main() {
    int pin, choice;
    double balance = 1000.0;  
    int correctPin = 1234;    
    double amount;

    do {
        printf("Enter your PIN: ");
        scanf("%d", &pin);

        if (pin != correctPin) {
            printf("Incorrect PIN. Please try again.\n");
        }
    } while (pin != correctPin);

    if (pin == correctPin) {
        printf("Welcome to your account!\n");
        printf("What would you like to do?\n");

        // Menu interaction with do-while loop
        do {
            printf("1. Check Balance\n");
            printf("2. Withdraw Cash\n");
            printf("3. Exit\n");
            scanf("%d", &choice);

            switch (choice) {
                case 1:
                    printf("Your current balance is $%.2f.\n", balance);
                    break;
                case 2:
                    printf("Enter amount to withdraw: $");
                    scanf("%lf", &amount);
                    if (amount > balance) {
                        printf("Transaction declined. Insufficient funds.\n");
                    } else {
                        balance -= amount;
                        printf("$%.2f has been withdrawn. Your current balance is $%.2f.", amount, balance);
                    }
                    break;
                case 3:
                    printf("Thank you for using this ATM!\n");
                    break;
                default:
                    printf("Invalid choice. Please enter again.\n");
            }
        } while (choice != 3);
        
    } else {
        printf("Incorrect PIN. Please try again.\n");
    }

    return 0;
}
