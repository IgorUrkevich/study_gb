int a1 = 11;
int b1 = 21;
int c1 = 43;
int a2 = 45;
int b2 = 43;
int c2 = 12;
int a3 = 34;
int b3 = 67;
int c3 = 47;

int max = a1;
if(a1 > max) max = a1;
if(b1 > max) max = b1;
if(c1 > max) max = c1;

if(a2 > max) max = a2;
if(b2 > max) max = b2;
if(c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine (max);