Formatting

ToLower()
ToUpper()
Trim() - gets rid of white space around string

IndexOf('a')
LastIndexOf("Hello") - index of first or last occurence of string

Substring(StartIndex)
Substring(StartIndex, length)

Replace('a', '!')
Replace("Scott", "Scott Burton")

String.IsNullOrEmpty(str)
String.IsNullOrWhiteSpace(str)

str.Split(' ')

string s = "1234";

// get a string representation of a number
int i = int.Parse(s);                   
int j = Convert.ToInt32(s); <- prefer, returns 0 

int i = 1234
string s = i.ToString();
string t = i.ToString("C"); $1234
string t = i.ToString("C0";) $1234
c or C currency
d or D decimal 
e or E Exponential
f or F Fixed Point
h or H Hexadecimal
