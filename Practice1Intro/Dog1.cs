namespace KMA.ProgrammingInCSharp2019.Practice1.Intro
{
    public partial class Dog
    {
        private int _age;
        public string Name { get; set; }

        public int Age
        {
            get { return _age; }
            private set { _age = value; }
        }


        private void Foo()
        { }

        internal void Bar()
        { }

        protected void Gas()
        { }

        protected internal void Far()
        { }

        public void Talk(string value)
        { }

        public void Talk(int times, string value = "bark", bool sit = false)
        { }
    }

    public class Poodle : Dog
    {
        void X()
        {
            Talk("woof");
            Talk(3, "woof");
            Talk(3, sit: true);
        }
    }


}
