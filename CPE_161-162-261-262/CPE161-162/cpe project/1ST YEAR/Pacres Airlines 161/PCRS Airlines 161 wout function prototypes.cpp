#include <stdio.h>
#include <conio.h>
#include <stdlib.h>

#define ROWS 2
#define COLS 5
#define FIRST_CLASS_ROW 0
#define ECONOMY_ROW 1

// FUNCTION TO DETECT IF BOTH SEATS ARE FULL OR NOT (DETECTOR FUNCTION)
int areAllSeatsFull(int seats[][COLS]) {
    for (int row = 0; row < ROWS; ++row) {
        for (int col = 0; col < COLS; ++col) {
            if (seats[row][col] == 0) {
                return 0; // Not all seats are full
            }
        }
    }
    return 1; // All seats are full
}

// MAIN FUNCTION
int main() {
    int seats[ROWS][COLS] = {{0}}; // initialize seat to 0
    int choice, seatNumber;
 	
    do {
    	//Menu Tab
    	printf("Welcome to PCRS Airlines 161\n");
    	printf("\n");
		printf(" PPPPPP    CCCCCC RRRRRR   SSSSSS    \n"); //LOGO
    	printf(" P     P  C       R     R S          \n");
    	printf(" PPPPPP  C        RRRRRR   SSSSS     \n");
    	printf(" P       C        R  R          S    \n");
    	printf(" P        C       R   R          S   \n");
    	printf(" P         CCCCCC R    R   SSSSSS    \n");
    	printf("\n");
    	
        printf("Please type 1 for \"First Class\"\n");
        printf("Please type 2 for \"Economy\"\n");
        printf("Please type 3 to exit the program\n");
        
        printf("\nPlease type your choice here: ");
        
        scanf("%d", &choice);
  
        system("cls");// command to clear console tab
        
        if (choice == 1) { // FIRST CLASS SECTION
            int sectionRow = FIRST_CLASS_ROW;
            int otherRow = ECONOMY_ROW;
            int sectionStart = 0;
            int sectionEnd = 5;
            
            
            // If both sections are full the program will terminate...
            if(areAllSeatsFull(seats)){
            	printf("Dear passenger, have a safe and enjoyable flight.");
            	getch();
            	return 0;
				}

            // Check if all seats in the FIRST CLASS section are full
            int allSeatsFull = 1;
            for (int i = 0; i < COLS; ++i) {
                if (seats[sectionRow][i] == 0) {
                    allSeatsFull = 0;
                    break;
                }
            }

            if (allSeatsFull) {
                printf("All seats in %s are full. Would you like to be placed in the other section? (Y for Yes, N for No): ", "First Class");
                char accept;
                scanf(" %c", &accept);
                system("cls");

                if (accept == 'Y' || accept == 'y') {
                    // Scenario when switching to the other section goes here

                    // Check if there's a vacant seat in the other row
                    	int vacantSeatFound = 0;
							for (int i = COLS; i < COLS * 2; ++i) {
    						if (seats[otherRow][i % COLS] == 0) {
        					seatNumber = i + 1;
        					seats[otherRow][i % COLS] = seatNumber; // Assign the seat
        					printf("*****************************************\n");
        					printf("*       Boarding Pass                   *\n");
        					printf("*       Economy Section                 *\n");
        					printf("*       Seat #%d                         *\n", seatNumber);
        					printf("*****************************************\n");
        					printf("\n");
							
							for(int i=0; i<5; i++){ //RECTANGLE pattern (only in economy section)
								for(int j=0; j<5; j++){
									printf("*");
								}
								printf("\n");
							}
        					
        					vacantSeatFound = 1;
        					break;
    						}
						}
						// If both sections are full the program will terminate... 
                    if (!vacantSeatFound) {
                        printf("Dear passenger, have a safe and enjoyable flight\n");
                        getch();
                        return 0;
                    }
                } else if (accept == 'N' || accept == 'n') {
                    printf("Next flight leaves in 3 hours. Thank you :)\n");
                    getch();
                    return 0;
                } else{
                    printf("Invalid choice. Please type Y for Yes or N for No\n");
						  getch(); 
                }
            } else {
                // There is at least one vacant seat in the FIRST CLASS
                for (int i = sectionStart; i < sectionEnd; i++) {
                    if (seats[sectionRow][i % COLS] == 0) {
                        seatNumber = i + 1;
                        seats[sectionRow][i % COLS] = seatNumber; // Assign the seat
                        printf("*****************************************\n");
                        printf("*       Boarding Pass                   *\n");
                        printf("*       First Class Section             *\n");
                        printf("*       Seat #%d                         *\n", seatNumber);
                        printf("*****************************************\n");
                        printf("\n");
        							for(int i = 1; i <= 5; i += 2){ // DIAMOND PATTERN (only in first class section boarding pass)
    									for(int j = 0; j < (5 - i) / 2; j++){
    										printf(" ");
			 							}
			 							for(int j = 0; j < i; j++){
			 								printf("*");
			 							}
			 							printf("\n");
		 							}
		 							
		 							for(int i = 5 - 2; i >= 1; i -= 2){
		 								for(int j = 0; j < (5 - i) / 2; j++){
		 									printf(" ");
			 							}
			 							for(int j = 0; j < i; j++){
			 								printf("*");
			 							}
		 							printf("\n");
		 							}
                        
                        break;
                    }
                }
            }

            // Display the seating chart for First Class
            printf("\n");
				printf("First Class Section: ");
            for (int i = 0; i < COLS; ++i) {
                printf("[%d] ", seats[FIRST_CLASS_ROW][i]);
            }

            printf("\nEconomy Section:     ");
            for (int i = 0; i < COLS; ++i) {
                printf("[%d] ", seats[ECONOMY_ROW][i]);
            }

            printf("\n");
				printf("\nPress any key to continue . . .\n");
            getch();
            system("cls");
        
        } else if (choice == 2) { // ECONOMY SECTION
            int sectionRow = ECONOMY_ROW;
            int otherRow = FIRST_CLASS_ROW;
            int sectionStart = 5;
            int sectionEnd = 10;
            
            // If both sections are full the program will terminate...            
            if(areAllSeatsFull(seats)){
            	printf("Dear passenger, have a safe and enjoyable flight.");
            	getch();
            	return 0;
				}

            // Check if all seats in the ECONOMY section are full
            int allSeatsFull = 1;
            for (int i = 0; i < COLS; ++i) {
                if (seats[sectionRow][i] == 0) {
                    allSeatsFull = 0;
                    break;
                }
            }

            if (allSeatsFull) {
                printf("All seats in %s are full. Would you like to be placed in the other section? (Y for Yes, N for No): ", "Economy");
                char accept;
                scanf(" %c", &accept);
                system("cls");

                if (accept == 'Y' || accept == 'y') {
                    // Scenario when switching to the other section goes here

                    // Check if there's a vacant seat in the other row
                    int vacantSeatFound = 0;
                    for (int i = 0; i < COLS; ++i) {
                        if (seats[otherRow][i] == 0) {
                            seatNumber = i + 1;
                            seats[otherRow][i] = seatNumber; // Assign the seat
                            printf("*****************************************\n");
                            printf("*       Boarding Pass                   *\n");
                            printf("*       First Class Section             *\n");
                            printf("*       Seat #%d                         *\n", seatNumber);
                            printf("*****************************************\n");
                            printf("\n");
                            
        							for(int i = 1; i <= 5; i += 2){ // DIAMOND PATTERN (only in first class section boarding pass)
    									for(int j = 0; j < (5 - i) / 2; j++){
    										printf(" ");
			 							}
			 							for(int j = 0; j < i; j++){
			 								printf("*");
			 							}
			 							printf("\n");
		 							}
		 							
		 							for(int i = 5 - 2; i >= 1; i -= 2){
		 								for(int j = 0; j < (5 - i) / 2; j++){
		 									printf(" ");
			 							}
			 							for(int j = 0; j < i; j++){
			 								printf("*");
			 							}
		 							printf("\n");
		 							}
                            
                            vacantSeatFound = 1;
                            break;
                        }
                    }

                    if (!vacantSeatFound) {
                        printf("Dear passenger, have a safe and enjoyable flight\n");
                        getch();
								return 0;
                    }
                } else if (accept == 'N' || accept == 'n') {
                    printf("Next flight leaves in 3 hours. Thank you :)\n");
                    getch();
						  return 0;
                } else{
                    printf("Invalid choice. Please type Y for Yes or N for No\n");
                    getch();
                }
            } else {
                // There is at least one vacant seat in the chosen section
                for (int i = sectionStart; i < sectionEnd; i++) {
                    if (seats[sectionRow][i % COLS] == 0) {
                        seatNumber = i + 1;
                        seats[sectionRow][i % COLS] = seatNumber; // Assign the seat
                        printf("*****************************************\n");
                        printf("*       Boarding Pass                   *\n");
                        printf("*       Economy Section                 *\n");
                        printf("*       Seat #%d                         *\n", seatNumber);
                        printf("*****************************************\n");
                        printf("\n");
                        
                        for(int i=0; i<5; i++){ //RECTANGLE pattern (only in economy section)
								for(int j=0; j<5; j++){
									printf("*");
								}
								printf("\n");
								}
                        break;
                    }
                }
            }

            // Display the seating chart for Economy
            printf("\n");
				printf("First Class Section: ");
            for (int i = 0; i < COLS; ++i) {
                printf("[%d] ", seats[FIRST_CLASS_ROW][i]);
            }

            printf("\nEconomy Section:     ");
            for (int i = 0; i < COLS; ++i) {
                printf("[%d] ", seats[ECONOMY_ROW][i]);
            }

            printf("\n");
				printf("\nPress any key to continue . . .\n");
            getch();
            system("cls");

        } else if (choice == 3) {
            printf("Next flight leaves in 3 hours. Thank you :)\n");
            getch();
            break; // Exit the loop when the user chooses option 3
        } else {
            printf("Invalid choice. Please type 1 for First Class, 2 for Economy, or 3 to exit.\n");
            printf("\nPress any key to continue. . .\n");
            getch();
            break;
        }

    } while (1);

    return 0;
}

