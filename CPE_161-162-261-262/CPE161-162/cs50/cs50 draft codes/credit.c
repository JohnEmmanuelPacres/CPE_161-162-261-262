#include <stdio.h>
#include <conio.h>

long get_credit(void);
void printcredit(long credit_card);

int main(void)
{
    long credit = get_credit();
    printcredit(credit);
    getch();
    return 0;
}

long get_credit(void)
{
    long credit_card;
    do
    {
        printf("Number: ");
        scanf("%ld", &credit_card);
    }
    while (credit_card <= 0);
    return credit_card;
}

void printcredit(long credit_card)
{
    long working_credit = credit_card;
    int sum = 0;
    int count = 0;
    long divisor = 10;

    // 1st case
    while (working_credit > 0)
    {
        int lastDigit = working_credit % 10;
        sum = sum + lastDigit;
        working_credit = working_credit / 100;
    }

    // 2nd case
    working_credit = credit_card / 10;
    while (working_credit > 0)
    {
        int lastDigit = working_credit % 10;
        int timesTwo = lastDigit * 2;
        sum = sum + (timesTwo % 10) + (timesTwo / 10);
        working_credit = working_credit / 100;
    }

    // length number
    working_credit = credit_card;
    while (working_credit != 0)
    {
        working_credit = working_credit / 10;
        count++;
    }

    // divisor
    for (int i = 0; i < count - 2; i++)
    {
        divisor = divisor * 10;
    }

    int firstDigit = credit_card / divisor;
    int firstTwoDigit = credit_card / (divisor / 10);

    // final check
    if (sum % 10 == 0)
    {
        if (firstDigit == 4 && (count == 13 || count == 16))
        {
            printf("VISA\n");
        }
        else if ((firstTwoDigit == 34 || firstTwoDigit == 37) && count == 15)
        {
            printf("AMEX\n");
        }
        else if ((firstTwoDigit >= 51 && firstTwoDigit <= 55) && count == 16)
        {
            printf("MASTERCARD\n");
        }
        else
        {
            printf("INVALID\n");
        }
    }
    else
    {
        printf("INVALID\n");
    }
}
