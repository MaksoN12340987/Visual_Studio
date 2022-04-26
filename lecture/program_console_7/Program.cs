int a1 = 1;
int b1 = 2;
int c1 = 6;
int a2 = 83;
int b2 = 4;
int c2 = 666;
int a3 = 8;
int b3 = 4;
int c3 = 6;

// int max = a1;

// if (a1 > max) max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

// System.Console.WriteLine(max);

int Max(int arg1, int arg2, int arg3)
{
    int resuslt = arg1;
    if (arg2 > resuslt) resuslt = arg2;
    if (arg3 > resuslt) resuslt = arg3;
    return resuslt;
}

// int max1 = (Max(a1, b1, c1));
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);

System.Console.WriteLine(Max((Max(a1, b1, c1)), 
                        (Max(a2, b2, c2)), 
                        (Max(a3, b3, c3))));
