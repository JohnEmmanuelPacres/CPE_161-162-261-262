#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <time.h>

#define MAX_FLIGHTS 3
#define MAX_BOOKINGS 10

typedef struct {
    char flight_number[10], destination[50], departure_time[10];
    int available_seats;
    float price;
} Flight;

typedef struct {
    char reference_code[10], flight_number[10], flight_class[10], booking_time[20];
} Booking;

Flight flights[MAX_FLIGHTS] = {
    {"PR123", "Manila to Cebu", "10:00", 5, 50.00},
    {"PR456", "Cebu to Davao", "12:30", 3, 75.00},
    {"PR789", "Davao to Boracay", "15:45", 4, 100.00}
};

Booking bookings[MAX_BOOKINGS];
int booking_count = 0;

void display_flights() {
    printf("Available Flights:\n");
    for (int i = 0; i < MAX_FLIGHTS; i++) {
        printf("%s | %s | Departure: %s | Seats: %d | Price: $%.2f\n",
               flights[i].flight_number, flights[i].destination,
               flights[i].departure_time, flights[i].available_seats,
               flights[i].price);
    }
}

void book_seat() {
    char flight_number[10], flight_class[10];
    printf("Enter flight number to book: ");
    if (scanf("%9s", flight_number) != 1) {
        printf("Invalid input.\n");
        return;
    }

    for (int i = 0; i < MAX_FLIGHTS; i++) {
        if (strcmp(flights[i].flight_number, flight_number) == 0) {
            if (flights[i].available_seats > 0) {
                printf("Choose class (Economy/Business): ");
                if (scanf("%9s", flight_class) != 1) {
                    printf("Invalid input.\n");
                    return;
                }

                if (booking_count < MAX_BOOKINGS) {
                    sprintf(bookings[booking_count].reference_code, "REF%03d", booking_count + 1);
                    time_t now = time(NULL);
                    strftime(bookings[booking_count].booking_time, sizeof(bookings[booking_count].booking_time),
                             "%Y-%m-%d %H:%M:%S", localtime(&now));
                    strcpy(bookings[booking_count].flight_number, flight_number);
                    strcpy(bookings[booking_count].flight_class, flight_class);
                    flights[i].available_seats--;
                    printf("Booking Confirmed!\nReference Code: %s\nFlight Number: %s\nClass: %s\nBooking Time: %s\n",
                           bookings[booking_count].reference_code, bookings[booking_count].flight_number,
                           bookings[booking_count].flight_class, bookings[booking_count].booking_time);
                    booking_count++;
                } else {
                    printf("Booking limit reached.\n");
                }
                return;
            } else {
                printf("No available seats on this flight.\n");
                return;
            }
        }
    }
    printf("Flight number not found.\n");
}

int main() {
    display_flights();
    book_seat();
    return 0;
}
