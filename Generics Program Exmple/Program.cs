using System;

namespace Generics_Program_Exmple
{
    // A derived class can add its own type parameters.
    class MyGen<T>
    {
        T ob;
        public MyGen(T a)
        {
            ob = a;
        }
        public T Getob()
        {
            return ob;
        }
    }
    class MyGen1<T, V> : MyGen<T>
    {
        V obj;
        public MyGen1(T a,V b):base(a)
            {
            obj =b;
            }
        public V Getobj()
        {
            return obj;
        }
    }
    class MyGen2<T,V,K>: MyGen1<T,V>
    {
        K obj1;
        public MyGen2(T a, V b, K c):base(a,b)
        {
            obj1 = c;
        }
        public K Gatobj1()
        {
            return obj1;
        }
    }
    class GenDerivedDemo
    {
        public static void Main()
        {
            MyGen2<string,int , double> x = new MyGen2<string, int, double>("Emp Id Number is :",100014,30000.00);
            Console.Write(x.Getob());
            Console.WriteLine(x.Getobj());
            Console.Write(x.Gatobj1());
        }
    }

}
