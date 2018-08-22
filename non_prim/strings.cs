string firstName = "Scott";
string name = "Scott" + " " + lastName;

// string format
string name = string.Format("{0} {1}", firstName, lastName); //format is a static method!

var numbers = new int[3] {1, 2, 3};
string list = string.Join(",", numbers) // Join is static


"String"[0] = "S"
Strings are immutable. we can't "CHANGE" the above.
There are methods that manipulate strings, but they all return new strings

"\n" - newline
"\t" - tab
"\\" - backslash
"\'" - single quot mark
"\"" - double quot mark

string path 		= "c:\\projects\\project1\\folder1";
string otherpath	= @"c:\projects\project1\folder1";