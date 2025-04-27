#include <stdio.h>
#include <stdlib.h>
#include <stdbool.h>
#include <limits.h>
#include <string.h>

// Function prototypes
void display();
int getFormat();
int getConversion();
void convert(int format, int conversion);
int binaryToDecimal(long long n);
long long decimalToBinary(int n);
int octalToDecimal(int octalNumber);
int hexToDecimal(char hexVal[]);
void decimalToHex(int decimalNum, char hexResult[]);
void decimalToOctal(int decimalNum, int octalResult[]);

int main() {
    int format, conversion;

    display();
    format = getFormat();
    if (format == -1) {
        printf("Invalid format selection.\n");
        return 1;
    }

    conversion = getConversion();
    if (conversion == -1) {
        printf("Invalid conversion selection.\n");
        return 1;
    }

    convert(format, conversion);

    return 0;
}

void display() {
    printf("PCRS Number Converter\n");
    printf("Choose a number format: \n");
    printf("1. Binary\n");
    printf("2. Decimal\n");
    printf("3. Hexadecimal\n");
    printf("4. Octal\n");
}

int getFormat() {
    int format;
    printf("Enter the format number: ");
    scanf("%d", &format);

    if (format < 1 || format > 4) {
        return -1;
    }

    return format;
}

int getConversion() {
    int conversion;
    printf("Choose the conversion type: \n");
    printf("1. To Binary\n");
    printf("2. To Decimal\n");
    printf("3. To Hexadecimal\n");
    printf("4. To Octal\n");
    printf("Enter the conversion number: ");
    scanf("%d", &conversion);

    if (conversion < 1 || conversion > 4) {
        return -1;
    }

    return conversion;
}

void convert(int format, int conversion) {
    int decimalNumber;
    long long binaryNumber;
    char hexNumber[20];
    int octalNumber;
    char hexResult[20];
    int octalResult[20];
    int i;

    switch (format) {
        case 1: // Binary
            printf("Enter a binary number: ");
            scanf("%lld", &binaryNumber);
            decimalNumber = binaryToDecimal(binaryNumber);
            break;
        case 2: // Decimal
            printf("Enter a decimal number: ");
            scanf("%d", &decimalNumber);
            break;
        case 3: // Hexadecimal
            printf("Enter a hexadecimal number: ");
            scanf("%s", hexNumber);
            decimalNumber = hexToDecimal(hexNumber);
            break;
        case 4: // Octal
            printf("Enter an octal number: ");
            scanf("%o", &octalNumber);
            decimalNumber = octalToDecimal(octalNumber);
            break;
        default:
            printf("Invalid format.\n");
            return;
    }

    switch (conversion) {
        case 1: // To Binary
            printf("Result in Binary: %lld\n", decimalToBinary(decimalNumber));
            break;
        case 2: // To Decimal
            printf("Result in Decimal: %d\n", decimalNumber);
            break;
        case 3: // To Hexadecimal
            decimalToHex(decimalNumber, hexResult);
            printf("Result in Hexadecimal: %s\n", hexResult);
            break;
        case 4: // To Octal
            decimalToOctal(decimalNumber, octalResult);
            printf("Result in Octal: ");
            for (i = 0; octalResult[i] != -1; i++) {
                printf("%d", octalResult[i]);
            }
            printf("\n");
            break;
        default:
            printf("Invalid conversion.\n");
            return;
    }
}

// Function to convert binary to decimal
int binaryToDecimal(long long n) {
    int decimalNumber = 0, base = 1, rem;
    while (n > 0) {
        rem = n % 10;
        decimalNumber = decimalNumber + rem * base;
        n = n / 10;
        base = base * 2;
    }
    return decimalNumber;
}

// Function to convert decimal to binary
long long decimalToBinary(int n) {
    long long binaryNumber = 0;
    int remainder, i = 1;
    
    while (n != 0) {
        remainder = n % 2;
        n /= 2;
        binaryNumber += remainder * i;
        i *= 10;
    }
    return binaryNumber;
}

// Function to convert octal to decimal
int octalToDecimal(int octalNumber) {
    int decimalNumber = 0, base = 1, rem;
    while (octalNumber > 0) {
        rem = octalNumber % 10;
        decimalNumber += rem * base;
        octalNumber /= 10;
        base *= 8;
    }
    return decimalNumber;
}

// Function to convert hexadecimal to decimal
int hexToDecimal(char hexVal[]) {
    int len = strlen(hexVal);
    int base = 1;
    int decimalNumber = 0;

    for (int i = len - 1; i >= 0; i--) {
        if (hexVal[i] >= '0' && hexVal[i] <= '9') {
            decimalNumber += (hexVal[i] - 48) * base;
            base *= 16;
        } else if (hexVal[i] >= 'A' && hexVal[i] <= 'F') {
            decimalNumber += (hexVal[i] - 55) * base;
            base *= 16;
        } else if (hexVal[i] >= 'a' && hexVal[i] <= 'f') {
            decimalNumber += (hexVal[i] - 87) * base;
            base *= 16;
        }
    }
    return decimalNumber;
}

// Function to convert decimal to hexadecimal
void decimalToHex(int decimalNum, char hexResult[]) {
    int i = 0;
    while (decimalNum != 0) {
        int temp = 0;
        temp = decimalNum % 16;
        if (temp < 10) {
            hexResult[i] = temp + 48;
            i++;
        } else {
            hexResult[i] = temp + 55;
            i++;
        }
        decimalNum = decimalNum / 16;
    }
    hexResult[i] = '\0';

    // Reverse the result
    int len = strlen(hexResult);
    for (int j = 0; j < len / 2; j++) {
        char temp = hexResult[j];
        hexResult[j] = hexResult[len - j - 1];
        hexResult[len - j - 1] = temp;
    }
}

// Function to convert decimal to octal
void decimalToOctal(int decimalNum, int octalResult[]) {
    int i = 0;
    while (decimalNum != 0) {
        octalResult[i] = decimalNum % 8;
        decimalNum /= 8;
        i++;
    }
    octalResult[i] = -1;  // Mark the end of the array

    // Reverse the result
    for (int j = 0; j < i / 2; j++) {
        int temp = octalResult[j];
        octalResult[j] = octalResult[i - j - 1];
        octalResult[i - j - 1] = temp;
    }
}
