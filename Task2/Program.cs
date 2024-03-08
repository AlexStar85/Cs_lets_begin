using System.Net.Quic;

int i1 = 5;
int i2 = 6;
int sum = i1 + i2;
Console.WriteLine(sum);

long L1 = 6;
long sum2 = L1 + i1;
Console.WriteLine(sum);

double d1 = 5.5;
double sum3 = d1 + i1;

int product1 = i1 * i2;
long product2 = i1 * L1;
double product3 = d1 * i1;
Console.WriteLine(product1);
Console.WriteLine(product2);
Console.WriteLine(product3);

int quotient = i1 / i2;
Console.WriteLine(quotient);

d1 = 6;
double quotient2 = i1 / d1;
Console.WriteLine(quotient2);
