using System;

namespace KMA.ProgrammingInCSharp2019.Practice1.Intro
{
    class Program
    {
        #region IntByVal
        //static void Main(string[] args)
        //{
        //    int myInt = 5;
        //    MyMethodIntSimple(myInt);
        //    Console.WriteLine(myInt);
        //}

        //public static void MyMethodIntSimple(int myInt)
        //{
        //    myInt = 6;
        //    Console.WriteLine(myInt);
        //}
        #endregion

        #region IntByRef
        //static void Main(string[] args)
        //{
        //    int myInt = 5;
        //    MyMethodIntRef(ref myInt);
        //    Console.WriteLine(myInt);
        //}

        //public static void MyMethodIntRef(ref int myInt)
        //{
        //    myInt = 6;
        //    Console.WriteLine(myInt);
        //}
        #endregion

        #region IntByRefNotInitialized
        //static void Main(string[] args)
        //{
        //    int myInt;
        //    MyMethodIntRef(ref myInt);
        //    Console.WriteLine(myInt);
        //}

        //public static void MyMethodIntRef(ref int myInt)
        //{
        //    myInt = 6;
        //    Console.WriteLine(myInt);
        //}
        #endregion

        #region IntOut
        //static void Main(string[] args)
        //{
        //    int myInt;
        //    MyMethodIntOut(out myInt);
        //    Console.WriteLine(myInt);
        //}

        //public static void MyMethodIntOut(out int myInt)
        //{
        //    myInt = 6;
        //    Console.WriteLine(myInt);
        //}
        #endregion

        #region ObjectByValPropertyChanged
        //public class MyClass
        //{
        //    public int MyProperty { get; set; }
        //}

        //static void Main(string[] args)
        //{
        //    MyClass myObject = new MyClass();
        //    myObject.MyProperty = 5;
        //    MyMethodMyObjectSimple(myObject);
        //    Console.WriteLine(myObject.MyProperty);
        //}

        //public static void MyMethodMyObjectSimple(MyClass myObject)
        //{
        //    myObject.MyProperty = 6;
        //    Console.WriteLine(myObject.MyProperty);
        //}
        #endregion

        #region ObjectByValReinit
        //public class MyClass
        //{
        //    public int MyProperty { get; set; }
        //}

        //static void Main(string[] args)
        //{
        //    MyClass myObject = new MyClass();
        //    myObject.MyProperty = 5;
        //    MyMethodMyObjectSimple(ref myObject);
        //    Console.WriteLine(myObject.MyProperty);
        //}

        //public static void MyMethodMyObjectSimple(ref MyClass myObject)
        //{
        //    myObject = new MyClass();
        //    myObject.MyProperty = 6;
        //    Console.WriteLine(myObject.MyProperty);
        //}
        #endregion

        #region ObjectByRef
        //public class MyClass
        //{
        //    public int MyProperty { get; set; }
        //}

        //static void Main(string[] args)
        //{
        //    MyClass myObject = new MyClass();
        //    myObject.MyProperty = 5;
        //    MyMethodMyClassRef(ref myObject);
        //    Console.WriteLine(myObject.MyProperty);
        //}

        //public static void MyMethodMyClassRef(ref MyClass myObject)
        //{
        //    myObject = new MyClass();
        //    myObject.MyProperty = 6;
        //    Console.WriteLine(myObject.MyProperty);
        //}
        #endregion

        #region ObjectByRefNotInitialized
        //public class MyClass
        //{
        //    public int MyProperty { get; set; }
        //}

        //static void Main(string[] args)
        //{
        //    MyClass myObject;
        //    MyMethodMyClassRef(ref myObject);
        //    Console.WriteLine(myObject.MyProperty);
        //}

        //public static void MyMethodMyClassRef(ref MyClass myObject)
        //{
        //    myObject = new MyClass();
        //    myObject.MyProperty = 6;
        //    Console.WriteLine(myObject.MyProperty);
        //}
        #endregion

        #region ObjectByOut
        //public class MyClass
        //{
        //    public int MyProperty { get; set; }
        //}

        //static void Main(string[] args)
        //{
        //    MyClass myObject;
        //    MyMethodMyClassOut(out myObject);
        //    Console.WriteLine(myObject.MyProperty);
        //}

        //public static void MyMethodMyClassOut(out MyClass myObject)
        //{
        //    myObject = new MyClass();
        //    myObject.MyProperty = 6;
        //    Console.WriteLine(myObject.MyProperty);
        //}
        #endregion

        #region Inheritance

        static void Main(string[] args)
        {
            BaseClass baseObject = new BaseClass();
            DerivedClassVirtual derivedVirtualObject = new DerivedClassVirtual();
            DerivedClass derivedObject = new DerivedClass();
            DerivedClassNew derivedNewObject = new DerivedClassNew();

            Console.WriteLine("Call for baseObject {0}");
            baseObject.NotVirtualMethod();
            baseObject.VirtualMethod();
            Console.WriteLine("Call for derivedVirtualObject {0}");
            derivedVirtualObject.NotVirtualMethod();
            derivedVirtualObject.VirtualMethod();
            Console.WriteLine("Call for derivedObject {0}");
            derivedObject.NotVirtualMethod();
            derivedObject.VirtualMethod();
            Console.WriteLine("Call for derivedNewObject {0}");
            derivedNewObject.NotVirtualMethod();
            derivedNewObject.VirtualMethod();
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Call for baseObject {0}");
            baseObject.NotVirtualMethod();
            baseObject.VirtualMethod();
            Console.WriteLine("Call for casted derivedVirtualObject {0}");
            ((BaseClass)derivedVirtualObject).NotVirtualMethod();
            ((BaseClass)derivedVirtualObject).VirtualMethod();
            Console.WriteLine("Call for casted derivedObject {0}");
            ((BaseClass)derivedObject).NotVirtualMethod();
            ((BaseClass)derivedObject).VirtualMethod();
            Console.WriteLine("Call for casted derivedNewObject {0}");
            ((BaseClass)derivedNewObject).NotVirtualMethod();
            ((BaseClass)derivedNewObject).VirtualMethod();
            Console.ReadKey();
        }
        #endregion
    }
}
