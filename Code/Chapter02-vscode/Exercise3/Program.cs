using static System.Console;

WriteLine("----------------------------------------------------------------------------------------------");

WriteLine("{0, -10} {1, -21} {2, 29} {3, 30}",
"Type",
"Byte(s) of memory",
"Min",
"Max");

WriteLine("----------------------------------------------------------------------------------------------");

// sbyte
WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}",
"sbyte",
sizeof(sbyte),
sbyte.MinValue,
sbyte.MaxValue);

// byte
WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}",
"byte",
sizeof(byte),
byte.MinValue,
byte.MaxValue);

// short
WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}",
"short",
sizeof(short),
short.MinValue,
short.MaxValue);

// ushort
WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}",
"ushort",
sizeof(ushort),
ushort.MinValue,
ushort.MaxValue);

// int
WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}",
"int",
sizeof(int),
int.MinValue,
int.MaxValue);

// uint
WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}",
"uint",
sizeof(uint),
uint.MinValue,
uint.MaxValue);

// long
WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}",
"long",
sizeof(long),
long.MinValue,
long.MaxValue);

// ulong
WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}",
"ulong",
sizeof(ulong),
ulong.MinValue,
ulong.MaxValue);

// float
WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}",
"float",
sizeof(float),
float.MinValue,
float.MaxValue);

// double
WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}",
"double",
sizeof(double),
double.MinValue,
double.MaxValue);

// decimal
WriteLine("{0, -10} {1, -20} {2, 30} {3, 30}",
"decimal",
sizeof(decimal),
decimal.MinValue,
decimal.MaxValue);


