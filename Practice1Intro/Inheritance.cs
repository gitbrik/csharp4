using System;

namespace KMA.ProgrammingInCSharp2019.Practice1.Intro
{
    public class BaseClass
    {
        public void NotVirtualMethod()
        {
            Console.WriteLine("Not Virtual From BaseClass");
        }

        public virtual void VirtualMethod()
        {
            Console.WriteLine("Virtual From BaseClass");
        }
    }

    public class DerivedClassVirtual:BaseClass
    {
        public override void VirtualMethod()
        {
            Console.WriteLine("Virtual From DerivedClassVirtual");
        }
    }

    public class DerivedClass : BaseClass
    {
        public void NotVirtualMethod()
        {
            Console.WriteLine("NotVirtual From DerivedClass");
        }

        public void VirtualMethod()
        {
            Console.WriteLine("Virtual From DerivedClass");
        }
    }

    public class DerivedClassNew : BaseClass
    {
        public new void NotVirtualMethod()
        {
            Console.WriteLine("Not Virtual From DerivedClassNew");
        }

        public new void VirtualMethod()
        {
            Console.WriteLine("Virtual From DerivedClassNew");
        }
    }
}
