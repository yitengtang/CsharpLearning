short shortResults, shortVal = 4;

int integerVal = 67;

long longResult;

float floatVal = 10.5F;

double doubleResult, doubleVal = 99.999;

string stringReslt, stringVal = "17";

bool boolVal = true;

Console.WriteLine("Variable Conversion Example");

doubleResult = floatVal * shortVal;
Console.WriteLine("Implicit, -> double: {0} * {1} -> {2}", floatVal, shortVal, doubleResult);

shortResults = (short)floatVal;
Console.WriteLine("Explicit, -> short: {0} -> {1}", floatVal, shortResults);

stringReslt = Convert.ToString(boolVal) + Convert.ToString(doubleVal);
Console.WriteLine("Explicit, -> string: \"{0}\" + \"{1}\" -> {2}", boolVal, doubleVal, stringReslt);

longResult = integerVal + Convert.ToInt32(stringVal);
Console.WriteLine("Mixed, ->long: {0} + {1} -> {2}", integerVal, stringVal, longResult);

Console.ReadKey();






