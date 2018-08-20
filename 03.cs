float a = 1.2f; // specify. otherwise it's just going to default to a double.
double b = 1.2;

// overflowing
checked
{
    byte a = 255;
    a += 1;
}
// overflow will not happen and an error will throw. but like, will you ever use it?

// scope
{
    byte a = 0;
    {
        byte b = 1;
        {
            byte c = 2;
        }
    }
}