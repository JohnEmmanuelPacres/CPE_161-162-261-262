#include <stdio.h> //ID Number: 23-1866-313
#include <string.h>
#include <conio.h>

#define MAX_ITEMS 10
#define MAX_NAME_LENGTH 50

void menu();
int add_item(char item_names[MAX_ITEMS][MAX_NAME_LENGTH], float item_prices[MAX_ITEMS], int num_items);
void display_items(char item_names[MAX_ITEMS][MAX_NAME_LENGTH], float item_prices[MAX_ITEMS], int num_items);
int select_items(int selected_items[MAX_ITEMS], int num_items);
float calculate_payment(char item_names[MAX_ITEMS][MAX_NAME_LENGTH], float item_prices[MAX_ITEMS], int selected_items[MAX_ITEMS], int num_items, int num_selected_items);
void get_payment_change(float total_payment);

int main()
{
    char item_names[MAX_ITEMS][MAX_NAME_LENGTH];
    float item_prices[MAX_ITEMS];
    int num_items = 0;
    int selected_items[MAX_ITEMS];
    int num_selected_items = 0;
    char choice;

    do
    {
        menu();
        printf("Enter your choice: ");
        scanf(" %c", &choice);

        switch (choice)
        {
        case '1':
            num_items = add_item(item_names, item_prices, num_items);
            break;
        case '2':
            display_items(item_names, item_prices, num_items);
            break;
        case '3':
            num_selected_items = select_items(selected_items, num_items);
            break;
        case '4':
            calculate_payment(item_names, item_prices, selected_items, num_items, num_selected_items);
            break;
        case '5':
            get_payment_change(calculate_payment(item_names, item_prices, selected_items, num_items, num_selected_items));
            break;
        case '6':
            printf("Exiting program...\n");
            break;
        default:
            printf("Invalid choice. Please try again.\n");
            break;
        }
    } while (choice != '6');

    getch();
    return 0;
}

void menu()
{
    printf("\n");
    printf("WELCOME TO PCRS STORE\n");
    printf("\n");
    printf("1. Add Item to Cart\n");
    printf("2. Display Items in Cart\n");
    printf("3. Select Items for Checkout\n");
    printf("4. Calculate Payment\n");
    printf("5. Get Payment Change\n");
    printf("6. Exit\n");
}

int add_item(char item_names[MAX_ITEMS][MAX_NAME_LENGTH], float item_prices[MAX_ITEMS], int num_items)
{
    if (num_items < MAX_ITEMS)
    {
        printf("Enter item name: ");
        fflush(stdin);
        fgets(item_names[num_items], sizeof(item_names[num_items]), stdin);
        item_names[num_items][strlen(item_names[num_items]) - 1] = '\0';
        printf("Enter item price: ");
        scanf("%f", &item_prices[num_items]);
        num_items++;
        printf("Item added to cart successfully.\n");
    }
    else
    {
        printf("Cart is full. Cannot add more items.\n");
    }
    return num_items;
}

void display_items(char item_names[MAX_ITEMS][MAX_NAME_LENGTH], float item_prices[MAX_ITEMS], int num_items)
{
    if (num_items == 0)
    {
        printf("Cart is empty.\n");
    }
    else
    {
        printf("Items in Cart:\n");
        for (int i = 0; i < num_items; i++)
        {
            printf("%d. %s - P%.2f\n", i + 1, item_names[i], item_prices[i]);
        }
    }
}

int select_items(int selected_items[MAX_ITEMS], int num_items)
{
    int num_selected_items = 0;
    int item_number;

    do
    {
        printf("Select item to checkout (enter item number, 0 to finish selection): ");
        scanf("%d", &item_number);

        if (item_number > 0 && item_number <= num_items)
        {
            selected_items[num_selected_items++] = item_number - 1;
            printf("Item added to the cart successfully!\n");
        }
        else if (item_number < 0 || item_number > num_items)
        {
            printf("Invalid item number. Please try again.\n");
        }
    } while (item_number != 0 && num_selected_items < MAX_ITEMS);

    return num_selected_items;
}

float calculate_payment(char item_names[MAX_ITEMS][MAX_NAME_LENGTH], float item_prices[MAX_ITEMS], int selected_items[MAX_ITEMS], int num_items, int num_selected_items)
{
    float total_price = 0;
    for (int i = 0; i < num_selected_items; i++)
    {
        total_price += item_prices[selected_items[i]];
    }
    float total_payment = total_price + 57; // Assuming fixed shipping fee
    printf("Total payment amount: P%.2f\n", total_payment);
    return total_payment;
}

void get_payment_change(float total_payment)
{
    float payment_amount;
    printf("Enter payment amount: ");
    scanf("%f", &payment_amount);
    if (payment_amount >= total_payment)
    {
        float change = payment_amount - total_payment;
        printf("Change: P%.2f\n", change);
    }
    else
    {
        printf("Insufficient payment amount.\n");
    }
}
