#include <stdio.h>
#include <stdlib.h>

char display(); // declartion function
double CompoundInterest(double balance, double interestrate, int month);
double Moneyround(double roundbalance);

int main(void){

	char option = 0; // for getting menu option
	double balance = 0.00;
	float inputmoney = 0.00;
	double interest = 0;
	int month = 0;

	while (option != 'Q' && option != 'q'){ // working until option is Q or q
	
		option = display();
		
		switch (option){
		case 'd':
		case 'D':
			printf("\n How much do you want to deposit ? == $");
			scanf_s("%f", &inputmoney);

			if (inputmoney > 0.0)
				balance = balance + inputmoney; // deposit the money

			break;

		case 'w':
		case 'W':
			printf("\n How much do you want to withdraw ? == $");
			scanf_s("%f", &inputmoney);

			if (inputmoney > 0.0){
				balance = balance - inputmoney; // withdraw the money
				if (balance < 0.0){
					balance = balance + inputmoney; // cancle the withdrawing
					
					printf("\n **************************************************************************\n");
					printf("\n You can't get withdraw because the balance doesn't have enough money !!!!! \n");
					printf("\n **************************************************************************\n");
				}
			}
			break;
		case'a':
		case'A':
			printf("\n Enter the annual interest rete == ");
			scanf_s("%lf", &interest);

			printf("\n Enter the number of months of compound interest == ");
			scanf_s("%d", &month);

			if (interest > 0.00 && interest < 100.00){
				interest = interest / 100.00;
				balance = CompoundInterest(balance, interest, month);

				printf("\n*******************************\n");
				printf("\n The new balance is %lf\n", balance);
				balance = Moneyround(balance);
				printf("\n The new balance is rounded to %.2lf\n", balance);
				printf("\n*******************************\n");
			}

			break;

		case 's':
		case 'S':
			printf("\n *********************************\n");
			printf("\n Your current balance is $ %.2f ! \n", balance);
			printf("\n *********************************\n");
		
		default:
			break;
		}

		getchar(); // for getting enter key
	}

	system("pause");
	return 0;
}

char display() // show users the options
{
	char menu = 0;

	printf("\n ***Bank Account Management Application***\n");
	printf("\n (D)eposit funds into the account\n");
	printf("\n (W)ithdraw funds from the account\n");
	printf("\n (A)dd interest\n");
	printf("\n (S)how the balance\n");
	printf("\n (Q)uit the appliction\n");
	printf("\n Enter the character of options : ");

	scanf_s("%c", &menu);
	system("cls");

	return menu;
}

double CompoundInterest(double balance, double interestrate, int month)
{
	double amount = 1.00;
	int i;

	for (i = 0; i < month;i++)
		amount = amount * (1 + (interestrate / 12.00));

	balance = balance * amount;
	return balance;
}

double Moneyround(double roundbalance)
{
	double roundnumber;

	roundnumber = (int)(roundbalance * 100);
	roundbalance = roundbalance * 100.0;
	if (roundbalance - roundnumber >= 0.5)
		roundnumber = roundnumber + 1;

	roundbalance = roundnumber / 100;
	return roundbalance;

}