a way to access elelments in a class that represents a list of values

var array = new int[5];
array[0] = 1; //indexer

var list = new List<int>();
list[0] = 1; //indexer

why do we need to define an indexer in a class?

//example
var cookie = new HttpCookie();
cookie.Expire = DateTime.Today.AddDays(5);

cookie["name"] = "Scott"; // indexer
cookie.SetItem("name", "Scott"); // without indexer we have to do this

var name = cookie["name"]; // with indexer
var name = cookie.GetItem("name"); // without, we need to write methods.
