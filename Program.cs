int productCount = 2000;
string[,] products = new string[productCount, 2];

LoadProducts(products, productCount);

for (int i = 0; i < productCount; i++)
{
    string result;
    result = Process1(products, i);

    if (result != "obsolete")
    {
        result = Process2(products, i);
    }
}

bool pauseCode = true;
while (pauseCode == true) ;