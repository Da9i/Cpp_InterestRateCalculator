#include<math.h>
using namespace std;
void periodic_payment(double &l, double &r, double &m, double &t, double &k)
{
	double result=0, i=0, temp;
	i = r / m;
	result = (l * i) / (1 - pow(1 + i, (-m*t)));
	cout << "THE PERIODIC PAYMENT IS: " << result << endl;
	cout << "ENTER 1 IF YOU WANT TO CHECK UNPAID BALANCE IF NOT PRESS ANY OTHER NUMBER:";
	cin >> temp;
	if (temp == 1)
	{
		double L;
		cout << "ENTER VALUE OF K PAYMENTS:";
		cin >> k;
		L = result * (1 - pow(1 + i, -(m*t - k)));
		cout << "THE UNPAID BALANCE IS: " << L << endl;
	}
}
int main()
{
	char ch;
	double l, r, m, t, k,temp;
	cout << "ENTER 1 FOR QUIT IF NOT PRESS ANY OTHER NUMBER TO CHECK PERIODIC PAYMENTS\n";
	cin >> temp;
	system("cls");
	while (temp != 1)
	{
		cout << "ENTER LOAN AMOUNT:";
		cin >> l;
		cout << "ENTER INTEREST RATE:";
		cin >> r;
		cout << "ENTER M FOR MONTHLY ENTER A FOR ANUALLY:";
		cin >> ch;
		if (ch == 'M' || ch == 'm')
			m = 12;
		else
			m = 1;
		cout << "ENTER NUMBER OF YEARS:";
		cin >> t;
		periodic_payment(l, r, m, t, k);
		system("pause>0");
		system("cls");
		cout << "ENTER 1 FOR QUIT IF NOT PRESS ANY OTHER NUMBER TO ENTER ANOTHER VALUE\n";
		cin >> temp;
		system("cls");
	}
	system("pause>0");
}
