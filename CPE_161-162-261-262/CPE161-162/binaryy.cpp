#include <stdio.h>

// Function to convert decimal to binary
void decimalToBinary(int n) {
    // Array to store binary number
    int binaryNum[32];

    // Counter for binary array
    int i = 0;
    while (n > 0) {
        // Storing remainder in binary array
        binaryNum[i] = n % 2;
        n = n / 2;
        i++;
    }

    // Printing binary array in reverse order
    for (int j = i - 1; j >= 0; j--) {
        printf("%d", binaryNum[j]);
    }
}

int main() {
    int n;

    // Asking for user input
    printf("Enter a decimal number: ");
    scanf("%d", &n);

    // Handling the case for 0 explicitly
    if (n == 0) {
        printf("0");
    } else {
        printf("Binary representation of %d is: ", n);
        decimalToBinary(n);
    }

    return 0;
}
