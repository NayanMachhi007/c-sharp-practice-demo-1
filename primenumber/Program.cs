using System.ComponentModel.Design;

Console.WriteLine("Please Enter Any Value");
int a = Convert.ToInt32(Console.ReadLine());

int b = 2;

if(b < a)
{
    for (int i = 0; i < a; i++)
    {
        if(i % b == 0)
        {
            Console.WriteLine("This Number is not prime  !!" + i);
        }


    }

}

  