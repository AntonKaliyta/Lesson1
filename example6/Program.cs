int a = new Random() .Next(1,101);
int b = new Random() .Next(1,101);
int c = new Random() .Next(1,101);
int d = new Random() .Next(1,101);
int e = new Random() .Next(1,101);

int max = a;

if(a > max) max = a;
if(b > max) max = b;
if(c > max) max = c;
if(d > max) max = d;
if(e > max) max = e;
System.Console.Write("max = ");
System.Console.WriteLine(max);