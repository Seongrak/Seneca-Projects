/*
	Programmer : Seongrak Choi
	Discription : This program can keep track of its inventory and profits
					allowing the user to order supplies and track sales.
					Up to 10 different items can be tracked.
	Version : 1.0
*/
#define _CRT_SECURE_NO_WARNINGS

#include <stdio.h>
#include <stdlib.h>

typedef struct {
	char name[20];
	float cost;
	int numberStock;
	float profit;
	float allProfit;
}INVEN;

//Function 
void DisplayItem(INVEN inventory[], int number);
void DisplayProfit(INVEN inventory[], int number);
void AddItem(INVEN *inventory,int number);
void NewItem(INVEN *inventory);
void SaleItem(INVEN *inventory, int number);

int main(void)
{

	INVEN inventory[10] = { 0 };
	char menuOption = 0;
	int index = 0;
	int i = 0;

	FILE *fp;

	fp = fopen("test.txt", "r+"); //If there is a file, the file will be read

	if (fp != NULL) // If File exists, or skip this part.
	{

		while (fgetc(fp) != '\n'); // Reading the data unitl '\n', it's for the first line(ex-item number...)

		// Saving the datas from text file to program
		while (fscanf(fp, "%d %s %d %f %f", &index, &inventory[i].name, &inventory[i].numberStock, &inventory[i].cost, &inventory[i].profit) != EOF)
		{
			inventory->allProfit = inventory->allProfit + inventory[i].profit;
			i++;
		}
		index = i;
		fclose(fp);
	}
	

	//User information
	printf("\n\t***** Inventory Control System ***** \n\n");
	printf("\n\tThis program allows a business to keep track of its inventory\n");
	printf("\tand profits allowing the owner to order supplies and track sales.\n");
	printf("\tUp to 10 different items can be tracked.\n\n");
	printf("\n\tPlese Enter any key if you want to continue !\n");
	getch();

	while (menuOption != 'f' && menuOption != 'F')
	{
		//Menu
		system("cls");
		printf("\n\t*************************************************************\n");
		printf("\n\tTo choose a function, enter its letter label:\n\n");
		printf("\ta) Show the names and number of each item in stock");
		printf("\n\t   including the cost of each item and total value of each item in stock.\n\n");
		printf("\tb) Show the number of units sold each time, the profit for each item");
		printf("\n\t   in stock and the total store profit.\n\n");
		printf("\tc) Allow the owner to order more of existing items.\n\n");
		printf("\td) Allow the owner to order new items.\n\n");
		printf("\te) Allow the owner to enter the sale of items.\n\n");
		printf("\tf) Quit.\n\n");
		printf("\t*************************************************************\n");

		printf("\t");
		scanf("%c", &menuOption);

		switch (menuOption)
		{
		case'a':
		case'A':
			system("cls");
			DisplayItem(inventory, index);
			printf("\n\tPlese Enter any key if you want to continue !\n");
			getch();
			break;
		case'b':
		case'B':
			system("cls");
			DisplayProfit(inventory, index);
			printf("\n\tPlese Enter any key if you want to continue !\n");
			getch();
			break;
		case'c':
		case'C':
			if (index <= 0) // if there is nothing, exist item can't be ordered
			{
				system("cls");
				printf("\n----Failed :: There is no existing item now !---\n");
				printf("\n\tPlese Enter any key if you want to continue !\n");
				getch();
				break;
			}
			else 
			{
				AddItem(&inventory, index);
				break;
			}
		case'd':
		case'D':
			if (index < 10) { // if index <10, there are some space to get new items
				NewItem(&inventory[index]);
				index++;
				break;
			}
			else if (index >= 10) {
				system("cls");
				printf("\n----Failed :: There is no space !---\n");
				printf("\n\tPlese Enter any key if you want to continue !\n");
				getch();
				break;
			}
		case'e':
		case'E':
			if(index <= 0) // if there is nothing in inventory, it will print out
			{
				system("cls");
				printf("\n----Failed :: There is empty !---\n");
				printf("\n\tPlese Enter any key if you want to continue !\n");
				getch();
				break;
			}
			else {
				SaleItem(&inventory, index);
				break;
			}
		default:
			break;
		}
	}

	
	fp = fopen("C:/Users/rak/Desktop/test.txt", "w+"); // Make a file called test.txt
	
	//Saving the data in FILE
	fprintf(fp, "\tItem Number\tItem Name\t\tNumber\tUnit Cost\tProfit\n");
	for (i = 0;i<index;i++)
		fprintf(fp,"\t%d\t\t %10s\t\t %4d\t %7.2f\t\t %7.2f\n",i+1,inventory[i].name,inventory[i].numberStock,inventory[i].cost,inventory[i].profit);
	
	fclose(fp); // Close the Saving data in FIle

	system("pause");
	return(0);
}

void DisplayItem(INVEN inventory[], int number)
{
	int i;

	if (number == 0)
		printf("\n\n\tThere is nothing in inventory !!\n\n");
	else
	{
		printf("\n\n\tItem Number\tItem Name\t\tNumber\tUnit Cost\t  Value\n\n");
		for (i = 0;i < number;i++)
		{	// print out the values
			printf("\t%d\t\t%10s\t\t%4d\t$%7.2f\t\t$%7.2f\n\n", i + 1,inventory[i].name,inventory[i].numberStock,inventory[i].cost,inventory[i].numberStock*inventory[i].cost);
		}
	}
	
	return;
}

void DisplayProfit(INVEN inventory[], int number)
{
	int i;
	printf("\n\n\tItem Number\tItem Name\t\tNumber sold\tItem Profit\n\n");

	for (i = 0;i < number;i++) // Disply Item number/Name/Number of sold/Profit
		printf("\t%d\t\t%10s\t\t%7.2f\t\t$%7.2f\n\n", i + 1, inventory[i].name, (inventory[i].profit / inventory[i].cost) * 2, inventory[i].profit);
	
	printf("\tTotal profit = \t\t\t\t\t$%7.2f\n\n", inventory->allProfit);
	
	return;
}

void NewItem(INVEN *inventory)
{

	system("cls");

	printf("\n\t***************************************\n\n");
	printf("\tPlese Enter the name of new product :  ");
	scanf("%s",&inventory->name);
	printf("\n\tPlese Enter the amount of new product :  ");
	scanf("%d", &inventory->numberStock);
	printf("\n\tPlese Enter the cost of new product :  $ ");
	scanf("%f", &inventory->cost);
	inventory->profit = 0;

	// for tracking
	printf("\n\t***************************************\n\n");
	printf("\n\tSuccess to add in the inventory!!");
	printf("\n\n\tName : %s Number : %d Cost : $ %.2f Value : $%.2f\n", inventory->name, inventory->numberStock, inventory->cost, inventory->numberStock*inventory->cost);

	printf("\n\tPlese Enter any key if you want to continue !\n");
	getch();
	return;
}

void AddItem(INVEN *inventory, int number)
{
	int indexnum;
	int temp;

	system("cls");
	DisplayItem(inventory, number);

	printf("\n\t***************************************\n\n");
	printf("\n\tWhich number of item do you want to order more ? : ");
	scanf("%d", &indexnum);

	if (indexnum > number|| indexnum ==0 || indexnum <0)
	{
		printf("\n\t--It's wrong number !!--\n\n");
		getch();
	}
	else {
		printf("\n\tHow many more items do you want? : ");
		scanf("%d", &temp);
		inventory[indexnum-1].numberStock = inventory[indexnum-1].numberStock + temp;
	}
	
	//for tracking
	printf("\n\t***************************************\n\n");
	printf("\n\tSuccess to order !!");
	printf("\n\n\t** %d ** more items are added to %s", temp, inventory[indexnum - 1].name);
	printf("\n\tName : %s Number : %d Cost : $ %.2f Value : $%.2f\n", inventory[indexnum - 1].name, inventory[indexnum - 1].numberStock, inventory[indexnum - 1].cost,inventory[indexnum-1].numberStock*inventory[indexnum-1].cost);
	
	printf("\n\tPlese Enter any key if you want to continue !\n");
	getch();
	return;
}

void SaleItem(INVEN *inventory, int number)
{
	int indexnum;
	int temp;
	int i; // for using for loop

	system("cls");
	DisplayItem(inventory, number);

	printf("\n\tWhich number of item did you sell ?  ");
	scanf("%d", &indexnum);
	if (inventory[indexnum-1].numberStock > 0) // only user has enough item to sell, it will work
	{
		if (indexnum > number || indexnum == 0 || indexnum < 0) // user input the wrong number for index
		{
			printf("\n\t--It's wrong number !!--\n\n");
			printf("\n\tPlese Enter any key if you want to continue !\n");
			getch();
		}
		else {
			printf("\n\tHow many items did you sell?  ");
			scanf("%d", &temp);
			if (temp > inventory[indexnum-1].numberStock) // if the number,user wants to sell is more than user has, it won't work
			{
				printf("\n\t--You don't have enough Items to sell like that. !!--\n\n");
				printf("\n\tPlese Enter any key if you want to continue !\n");
				getch();
			}
			else if (temp < 0) // user input the wrong number to sell
			{
				printf("\n\t--It's wrong number !!--\n\n");
				printf("\n\tPlese Enter any key if you want to continue !\n");
				getch();
			}
			else { // Sell items and Calculate Profit 
				inventory[indexnum - 1].profit = (inventory[indexnum - 1].cost / 2.0) * (float)temp;
				inventory->allProfit = inventory->allProfit + inventory[indexnum - 1].profit;  // Total Profit is update when items are sold;
				inventory[indexnum - 1].numberStock = inventory[indexnum - 1].numberStock - temp;

				printf("\n\tSuccess!!! \n");
				printf("\n\tName : %s Number of Stock : %d Cost : $%2.f",inventory[indexnum-1].name,inventory[indexnum-1].numberStock,inventory[indexnum-1].cost);
				printf("\n\tThe Profit of This Item : $%2.f",inventory[indexnum-1].profit);
				printf("\n\tThe Profit of ALL Item : $%2.f\n", inventory->allProfit);
				printf("\n\tPlese Enter any key if you want to continue !\n");
				getch();
			}
		}
	}
	else{
	// the stock of item is zero, it will print out
		printf("\n\t--There is empty !! --\n\n");
		printf("\n\tPlese Enter any key if you want to continue !\n");
		getch();
	}
	printf("\n\tPlese Enter key if you want to continue !\n");
	return;
}