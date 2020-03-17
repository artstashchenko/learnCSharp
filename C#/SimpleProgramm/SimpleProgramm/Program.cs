using System;
using System.Globalization;

namespace SimpleProgramm
{

    class ExceptA : Exception {
        public ExceptA(string str) : base(str) { }

        public override string ToString()
        {
            return Message;
        }
    }

    class ExceptB : ExceptA
    {
        public ExceptB(string str) : base(str) { }
        public override string ToString()
        {
            return Message;
        }
    }

    class OrderMatters {
        static void Main()
        {
            for (int x = 0; x < 3; x++)
            {
                try
                {
                    if (x == 0) throw new ExceptA("Exception get type ExceptA");
                    else if (x == 1) throw new ExceptB("Excepton get type ExceptB");
                    else throw new Exception();
                }
                catch (ExceptB exc)
                {
                    Console.WriteLine(exc);
                }
                catch (ExceptA exc)
                {
                    Console.WriteLine(exc);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc);
                }
            }
        }
    }
    //class ExcDemo3 {
    //    static void Main()
    //    {
    //        int[] numer = { 4, 8, 16, 32, 64, 128 };
    //        int[] denom = { 2, 0, 4, 4, 0, 8 };

    //        for (int i = 0; i < numer.Length; i++)
    //        {
    //            try
    //            {
    //                Console.WriteLine(numer[i] + " / " + denom[i] + "equals" + numer[i] / denom[i]);
    //            }
    //            catch (DivideByZeroException)
    //            {
    //                Console.WriteLine("Devide for zero is restricted");
    //            }
    //        }
    //    }
    //}
    //class ExcTest {
    //    public static void GenException()
    //    {
    //        int[] nums = new int[4];
    //        Console.WriteLine("Before get exception");

    //        for (int i = 0; i < 10; i++)
    //        {
    //            nums[i] = i;
    //            Console.WriteLine("nums [{0}] : {1}", i, nums[i]);
    //        }
    //        Console.WriteLine("Does not relate previous");
    //    }
    //}

    //class ExcDemo2 {
    //    static void Main()
    //    {
    //        try
    //        {
    //            ExcTest.GenException();
    //        }
    //        catch (IndexOutOfRangeException) {
    //            Console.WriteLine("Index was out of range the array");
    //        }
    //        Console.WriteLine("After block");
    //    }
    //}
    //class ExcDemol {
    //    static void Main()
    //    {
    //        int[] nums = new int[4];
    //        try {
    //            Console.WriteLine("Befro exception generating");

    //            for (int i = 0; i < 10; i++)
    //            {
    //                nums[i] = i;
    //                Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
    //            }
    //            Console.WriteLine("There are nothing to show");
    //        }
    //        catch (IndexOutOfRangeException)
    //        {
    //            Console.WriteLine("Index out of range the array");
    //        }
    //        Console.WriteLine("After block get exceptions");
    //    }
    //}
    //class EnumDemo {
    //    enum Apple { J, G, R, W, C, M};

    //    static void Main()
    //    {
    //        string[] color = 
    //        {
    //            "red", "yellow", "red", "red", "red", "red-green"
    //        };

    //        Apple i;
    //        for (i = Apple.J; i <= Apple.M; i++)
    //        {
    //            Console.WriteLine(i + "have a value" + (int)i);
    //        }

    //        Console.WriteLine();

    //        for (i = Apple.J; i <=Apple.M; i++)
    //        {
    //            Console.WriteLine("Color of sort" + i + " - " + color[(int)i]);
    //        }
    //    }
    //}
    //struct PacketHeaderP
    //{
    //    public uint PackNum;
    //    public ushort PackLen;
    //}

    //class Transaction {
    //    static uint transacNum = 0;
    //    PacketHeaderP ph;
    //    string accountNum;
    //    double amount;

    //    public Transaction(string acc, double val)
    //    {
    //        ph.PackNum = transacNum++;
    //        ph.PackLen = 512;

    //        accountNum = acc;
    //        amount = val;
    //    }

    //    public void sendTransaction() {
    //        Console.WriteLine("Package #: " + ph.PackNum + ", Leingth: " + ph.PackLen + ", \n Count #: " + accountNum + ", Summ: {0:C} \n", amount);
    //    }

    //    class PacketDemo
    //    {
    //        static void Main()
    //        {
    //            Transaction t = new Transaction("31243", -100.12);
    //            Transaction t2 = new Transaction("AB4655", 345.25);
    //            Transaction t3 = new Transaction("8475-09", 9800.00);

    //            t.sendTransaction();
    //            t2.sendTransaction();
    //            t3.sendTransaction();
    //        }
    //    }
    //}
    //struct MyStruct {
    //    public int x;
    //}

    //class StructAssignment {
    //    static void Main()
    //    {
    //        MyStruct a;
    //        MyStruct b;

    //        a.x = 10;
    //        b.x = 20;

    //        Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);

    //        a = b;
    //        b.x = 30;

    //        Console.WriteLine("a.x {0}, b.x {1}", a.x, b.x);
    //    }
    //}
    //public interface IMyIF_A {
    //    int Meth(int x);
    //}

    //public interface IMyIF_B {
    //    int Menth(int x);
    //}

    //class MyClass : IMyIF_A, IMyIF_B
    //{
    //    int IMyIF_A.Meth(int x) {
    //        return x + x;
    //    }

    //    int IMyIF_B.Menth(int x) {
    //        return x * x;
    //    }

    //    public int MenthA(int x)
    //    {
    //        IMyIF_A a_ob;
    //        a_ob = this;
    //        return a_ob.Meth(x);
    //    }

    //    public int MenthB(int x)
    //    {
    //        IMyIF_B b_ob;
    //        b_ob = this;
    //        return b_ob.Menth(x);
    //    }
    //}

    //class FQIFNames {
    //    static void Main()
    //    {
    //        MyClass ob = new MyClass();

    //        Console.WriteLine(ob.MenthA(3));
    //        Console.WriteLine(ob.MenthB(3));
    //    }
    //}

    //public interface ISeries {
    //    int GetNext();
    //    void Reset();
    //    void SetStart(int x);
    //}

    //class ByTwos : ISeries {
    //    int start;
    //    int val;
    //    int prev;

    //    public ByTwos()
    //    {
    //        start = 0;
    //        val = 0;
    //        prev = -2;
    //    }

    //    public int GetNext()
    //    {
    //        prev = val;
    //        val += 2;
    //        return val;
    //    }

    //    public void Reset()
    //    {
    //        val = start;
    //        prev = start - 2;
    //    }

    //    public void SetStart(int x)
    //    {
    //        start = x;
    //        val = start;
    //        prev = val - 2;
    //    }

    //    public int GetPrevious()
    //    {
    //        return prev;
    //    }
    //}

    //class SeriesDemoP
    //{

    //    static void Main()
    //    {
    //        ByTwos ob = new ByTwos();

    //        for (int i = 0; i < 5; i++)
    //        {
    //            Console.WriteLine("Next digit is equal:" + ob.GetNext());
    //        }

    //        Console.WriteLine("\nReset");
    //        ob.Reset();

    //        for (int i = 0; i < 5; i++)
    //        {
    //            Console.WriteLine("Next digit equals " + ob.GetNext());
    //        }

    //        Console.WriteLine("\nBegin from digit 100");
    //        ob.SetStart(100);
    //        for (int i = 0; i < 5; i++)
                
    //        {
    //            Console.WriteLine("Next digit is equal " + ob.GetNext());
    //        }
    //    }
    //}
    //class BoxingDemo {
    //    static void Main()
    //    {
    //        int x;
    //        object obj;
    //        x = 10;
    //        obj = x;

    //        int y = (int)obj;
    //        Console.WriteLine(y);
    ////    }
    //}
    //class MyClass {
    //    static int count = 0;
    //    int id;

    //    public MyClass()
    //    {
    //        id = count;
    //        count++;
    //    }

    //    public override string ToString()
    //    {
    //        return "Object #" + id + "type MyClass";
    //    }
    //}

    //class Test {
    //    static void Main()
    //    {
    //        MyClass ob1 = new MyClass();
    //        MyClass ob2 = new MyClass();
    //        MyClass ob3 = new MyClass();

    //        Console.WriteLine(ob1);
    //        Console.WriteLine(ob2);
    //        Console.WriteLine(ob3);

    //    }
    //}
    //class TwoDShape {
    //    double pri_width;
    //    double pri_height;

    //    public TwoDShape()
    //    {
    //        Width = Height = 0.0;
    //        name = "null";
    //    }

    //    public TwoDShape(double w, double h, string n)
    //    {
    //        Width = w;
    //        Height = h;
    //        name = n;
    //    }

    //    public TwoDShape(double x, string n)
    //    {
    //        Width = Height = x;
    //        name = n;
    //    }

    //    public TwoDShape(TwoDShape ob)
    //    {
    //        Width = ob.Width;
    //        Height = ob.Height;
    //        name = ob.name;
    //    }

    //    public double Width
    //    {
    //        get{ return pri_width; }
    //        set{ pri_width = value < 0 ? -value : value; }
    //    }

    //    public double Height
    //    {
    //        get { return pri_height; }
    //        set { pri_height = value < 0 ? -value : value; }
    //    }

    //    public string name { get; set; }

    //    public void ShowDim()
    //    {
    //        Console.WriteLine("Width and Height equals = " + Width + "and" + Height);
    //    }

    //    public virtual double Area()
    //    {
    //        Console.WriteLine("Method Area() need to be override");
    //        return 0.0;
    //    }
        
    //}

    //class Triangle : TwoDShape
    //{
    //    string Style;

    //    public Triangle()
    //    {
    //        Style = "null";
    //    }

    //    public Triangle(string s, double w, double h) : base(w, h, "triangle")
    //    {
    //        Style = s;
    //    }

    //    public Triangle(double x) : base(x, "triangle")
    //    {
    //        Style = "ravnobedrennii";
    //    }

    //    public Triangle(Triangle ob) : base(ob)
    //    {
    //        Style = ob.Style;
    //    }

    //    public override double Area()
    //    {
    //        return Width * Height / 2;
    //    }

    //    public void ShowStyle()
    //    {
    //        Console.WriteLine("Triangle" + Style);
    //    }
    //}

    //class Rectangle : TwoDShape
    //{
    //    public Rectangle(double w, double h) : base(w, h, "pryamougolnik")

    //    { 
            
    //    }

    //    public Rectangle(double x) : base(x, "pryamougolnik") { }

    //    public Rectangle(Rectangle ob) : base(ob) { }

    //    public bool IsSquare()
    //    {
    //        if (Width == Height) return true;
    //        return false;
    //    }

    //    public override double Area()
    //    {
    //        return Width * Height;
    //    }
    //}

    //class DynShapes {
    //    static void Main()
    //    {
    //        TwoDShape[] shapes = new TwoDShape[5];

    //        shapes[0] = new Triangle("", 8.0, 12.0);
    //        shapes[1] = new Rectangle(10);
    //        shapes[2] = new Rectangle(10, 4);
    //        shapes[3] = new Triangle(7.0);
    //        shapes[4] = new TwoDShape(10, 20, "main form");

    //        for (int i = 0; i < shapes.Length; i++)
    //        {
    //            Console.WriteLine("Object -" + shapes[i].name);
    //            Console.WriteLine("Area is equal:" + shapes[i].Area());
    //            Console.WriteLine();
    //        }



    //    }
    //}

    //class A {
    //    public int i = 0;

    //    public void Show()
    //    {
    //        Console.WriteLine("Member i into base class " + i);
    //    }
    //}

    //class B : A {
    //    new int i;

    //    public B(int a, int b)
    //    {
    //        base.i = a;
    //        i = b;
    //    }

    //    new public void Show()
    //    {
    //        base.Show();

    //        Console.WriteLine("Member i into child class: " + i);
    //    }
    //}

    //class UncoverName {
    //    static void Main()
    //    {
    //        B ob = new B(1, 2);
    //        ob.Show();
    //    }
    //}
    //class TwoDShape {
    //    double pri_width;
    //    double pri_height;

    //    public TwoDShape()
    //    {
    //        Width = Height = 0.0;
    //    }

    //    public TwoDShape(double w, double h)
    //    {
    //        Width = w;
    //        Height = h;
    //    }

    //    public TwoDShape(double x)
    //    {
    //        Width = Height = x;
    //    }

    //    public double Width 
    //    {
    //        get { return pri_width; }
    //        set { pri_width = value < 0 ? -value : value; }
    //    }

    //    public double Height 
    //    {
    //        get { return pri_height; }
    //        set { pri_height = value < 0 ? -value : value; }
    //    }

    //    public void ShowDim() {
    //        Console.WriteLine("Width and Height equals " + Width + " and " + Height);
    //    }
    //}

    //class Triangle : TwoDShape {
    //    string Style;

    //    public Triangle()
    //    {
    //        Style = null;
    //    }

    //    public Triangle(string s, double w, double h) : base(w, h)
    //    {
    //        Style = s;
    //    }

    //    public Triangle(double x) : base(x) {
    //        Style = "ravnobedrennii";
    //    }



    //    public double Area()
    //    {
    //        return Width * Height / 2;
    //    }

    //    public void ShowStyle() {
    //        Console.WriteLine("Triangle " + Style);
    //    }
    //}

    //class Shapes4 { 
    //static void Main()
    //    {
    //        Triangle t1 = new Triangle();
    //        Triangle t2 = new Triangle("pryamougolnii", 8.0, 12.0);
    //        Triangle t3 = new Triangle(4.0);

    //        t1 = t2;

    //        Console.WriteLine("Info about object t1: ");
    //        t1.ShowStyle();
    //        t1.ShowDim();
    //        Console.WriteLine("Area equals " + t1.Area());

    //        Console.WriteLine();

    //        Console.WriteLine("Info about object t2: ");
    //        t2.ShowStyle();
    //        t2.ShowDim();
    //        Console.WriteLine("Area equals " + t2.Area());

    //        Console.WriteLine("Info about object t3: ");
    //        t3.ShowStyle();
    //        t3.ShowDim();
    //        Console.WriteLine("Area equals " + t3.Area());
    //    }
    //}
    //class RangeArray {
    //    int[] a;
    //    int lowerBound;
    //    int upperBound;

    //    public int Length { get; private set; }
    //    public bool Error { get; private set; }

    //    public RangeArray(int low, int high)
    //    {
    //        high++;
    //        if (high <= low)
    //        {
    //            Console.WriteLine("Wrong indexes");
    //            high = 1;
    //            low = 0;
    //        }
    //        a = new int[high - low];
    //        Length = high - low;

    //        lowerBound = low;
    //        upperBound = --high;
    //    }

    //        public int this[int index]
    //    {
    //        get
    //        {
    //            if (ok(index))
    //            {
    //                Error = false;
    //                return a[index - lowerBound];

    //            }
    //            else
    //            {
    //                Error = true;
    //                return 0;
    //            }
    //        }
    //        set
    //        {
    //            if (ok(index))
    //            {
    //                a[index - lowerBound] = value;
    //                Error = false;
    //            }
    //            else
    //            {
    //                Error = true;
    //            }

    //        }
    //    }
    //    private bool ok(int index)
    //    {
    //        if (index >= lowerBound & index <= upperBound) return true;
    //        return false;
    //    }

    //}

    //class RangeArrayDemo {
    //    static void Main()
    //    {
    //        RangeArray ra = new RangeArray(-5, 5);
    //        RangeArray ra2 = new RangeArray(1, 10);
    //        RangeArray ra3 = new RangeArray(-20, -12);

    //        Console.WriteLine("Leingh of array ra: " + ra.Length);
    //        for (int i = -5; i <= 5; i++)
    //        {
    //            ra[i] = i;
    //        }
    //        Console.WriteLine("ra include the following: ");
    //        for (int i = -5; i <= 5; i++)
    //        {
    //            Console.WriteLine(ra[i] + " ");
    //            Console.WriteLine("\n");
    //        }

    //        Console.WriteLine("Length of array ra2 is: " + ra2.Length);
    //        for (int i = 1; i <= 10; i++)
    //        {
    //            ra2[i] = i;
    //        }

    //        Console.WriteLine("ra2 include the following: ");
    //        for (int i = 1; i <= 10; i++)
    //            Console.WriteLine(ra2[i] + " ");
    //        Console.WriteLine("\n");

    //        Console.WriteLine("Length of array ra3: " + ra3.Length);
    //        for (int i = -20; i <= -12; i++)
    //            ra3[i] = i;

    //        Console.Write("ra3 include: ");

    //        for (int i = -20; i <= -12; i++)
    //            Console.Write(ra3[i] + " ");

    //        Console.WriteLine("\n");

    //    }
    //}
    //class FailSoftArray {
    //    int[] a;
    //    int len;

    //    public bool ErrFlg;

    //    public FailSoftArray(int size)
    //    {
    //        a = new int[size];
    //        len = size;
    //    }

    //    public int Length1 {
    //        get { return len; }
    //    }

    //    public int this[int index]
    //    {
    //        get { if(ok(index))
    //            { 
    //                ErrFlg = false;
    //                return a[index];
    //            }
    //            else
    //            {
    //                ErrFlg = true;
    //                return 0;
    //            }
    //          }
    //        set {
    //            if (ok(index))
    //            {
    //                a[index] = value;
    //                ErrFlg = false;
    //            }
    //            else ErrFlg = true;
    //        }
    //    }

    //    private bool ok(int index)
    //    {
    //        if (index >= 0 & index < Length1) return true;
    //        return false;
    //    }
    //}

    //class ImprovedFSDemo {
    //    static void Main()
    //    {
    //        FailSoftArray fs = new FailSoftArray(5);
    //        int x;

    //        for (int i = 0; i < fs.Length1; i++)
    //            fs[i] = i * 10;

    //        for (int i = 0; i < fs.Length1; i++)
    //        {
    //            x = fs[i];
    //            if (x != -1) Console.Write(x + " ");
    //        }
    //        Console.WriteLine();            
    //    }
    //}
    //class Thread {
    //    int x, y, z;

    //    public Thread() { x = y = z = 0; }
    //    public Thread(int i, int j, int k) { x = i; y = j;z = k; }

    //    public static Thread operator +(Thread op1, Thread op2)
    //    {
    //        Thread result = new Thread();

    //        result.x = op1.x + op2.x;
    //        result.x = op1.y + op2.y;
    //        result.x = op1.z + op2.z;

    //        return result;

    //    }

    //    public static implicit operator int(Thread op1)
    //    {
    //        return op1.x * op1.y * op1.z;
    //    }

    //    public void Show()
    //    {
    //        Console.WriteLine(x + ", " + y + ", " + z);
    //    }
    //}

    //class ThreadDemo {
    //    static void Main() {
    //        Thread a = new Thread(1,2,3);
    //        Thread b = new Thread(10, 10, 10);
    //        Thread c = new Thread();
    //        int i;

    //        Console.Write("Coordinate dot a: ");
    //        a.Show();
    //        Console.WriteLine();
    //        Console.Write("Coordinate dot b: ");
    //        b.Show();
    //        Console.WriteLine();
            
    //        c = a + b;
    //        Console.WriteLine("a+b result");
    //        c.Show();
    //        Console.WriteLine();

    //        i = a;
    //        Console.WriteLine("Result of i = a: " + i);
    //        Console.WriteLine();

    //        i = a * 2 - b;



    //    }
    //}
    //class RevStr
    //{
    //    public void DisplayRev(string str)
    //    {
    //        if (str.Length > 0)
    //        {
    //            DisplayRev(str.Substring(1, str.Length - 1));
    //        }
    //        else
    //        {
    //            return;
    //        }

    //        Console.Write(str[0]);
    //    }
    //}
    //class RevStrDemoP
    //{

    //    static void Main()
    //    {
    //        string s = "This is a test";
    //        RevStr rsOb = new RevStr();

    //        Console.WriteLine("Current string: " + s);
    //        Console.WriteLine("Current rev string: ");
    //        rsOb.DisplayRev(s);

    //        Console.WriteLine();
    //    }
    //}
    //class Factorial {
    //    public int FactR(int n)
    //    {
    //        int result;

    //        if (n == 1) return 1;
    //        result = FactR(n - 1) * n;
    //        return result;
    //    }
    //        public int FactI(int n) {
    //            int t, result;

    //            result = 1;
    //            for (t = 1; t <= n; t++) result *= t;
    //            return result;
    //        }
    //    }

    //class Recursion {
    //    static void Main() {
    //        Factorial f = new Factorial();
    //        Console.WriteLine("Factorial with recursion method used");
    //        Console.WriteLine("Factorial number 3 equals " + f.FactR(3));
    //        Console.WriteLine("Factorial number 4 equals " + f.FactR(4));
    //        Console.WriteLine("Factorial number 5 equals " + f.FactR(5));
    //        Console.WriteLine();

    //        Console.WriteLine("Factorial with recursion method used");
    //        Console.WriteLine("Factorial number 3 equals " + f.FactI(3));
    //        Console.WriteLine("Factorial number 4 equals " + f.FactI(4));
    //        Console.WriteLine("Factorial number 5 equals " + f.FactI(5));
    //        Console.WriteLine();
    //    }
    //}
 
    //class Cipher {
    //    static void Main(string[] args)
    //    {
    //        if (args.Length < 2)
    //        { 
            
    //        }
    //        Console.WriteLine("There are: ");
    //        for (int i = 0; i < args.Length; i++)
    //        {
    //            Console.WriteLine(args[i]);
    //        }
    //    }
    //}

    //class XYCoord {
    //    public int x, y;

    //    public XYCoord() : this(0, 0)
    //    {
    //        Console.WriteLine("Inside constr XYCoord()");
    //       }

    //    public XYCoord(XYCoord obj) : this(obj.x, obj.y)
    //    {
    //        Console.WriteLine("Inside constr XYCoord(obj)");
    //    } 

    //    public XYCoord(int i, int j)
    //    {
    //        Console.WriteLine("Inside constr XYCoord (int, int)");
    //        x = i;
    //        y = j;
    //    }
    //}

    //class OverloadConsDemo {
    //    static void Main() {
    //        XYCoord t1 = new XYCoord();
    //        XYCoord t2 = new XYCoord(8, 9);
    //        XYCoord t3 = new XYCoord(t2);

    //        Console.WriteLine("t1.x, t1.y: " + t1.x + ", " + t1.y);
    //        Console.WriteLine("t2.x, t2.y: " + t2.x + ", " + t2.y);
    //        Console.WriteLine("t3.x, t3.y: " + t3.x + ", " + t3.y);
    //    }
    //}
    //class MyClass
    //{
    //    int a, b;

    //    public MyClass Factory(int i, int j)
    //    {
    //        MyClass t = new MyClass();
    //        t.a = i;
    //        t.b = j;

    //        return t;
    //    }

    //    public void Show()
    //    {
    //        Console.WriteLine("a and b: " + a + " " + b);
    //    }
    //}

    //class MakeObjects {
    //    static void Main()
    //    {
    //        MyClass ob = new MyClass();
    //        int i, j;

    //        for (i = 0, j = 10; i < 10; i++, j--)
    //        {
    //            MyClass anotherOb = ob.Factory(i, j);
    //            anotherOb.Show();
    //        }
    //        Console.WriteLine();
    //    }
    //}
    //class RefSwap
    //{
    //    int a, b;

    //    public RefSwap(int i, int j)
    //    {
    //        a = i;
    //        b = j;
    //    }

    //    public void Show()
    //    {
    //        Console.WriteLine("a: {0}, b: {1}", a,b);
    //    }

    //    public void Swap(ref RefSwap ob1, ref RefSwap ob2)
    //    {
    //        RefSwap t;

    //        t = ob1;
    //        ob1 = ob2;
    //        ob2 = t;
    //    }
    //}

    //class RefSwapDemo {
    //    static void Main()
    //    {
    //        RefSwap x = new RefSwap(1,2);
    //        RefSwap y = new RefSwap(3, 4);

    //        Console.Write("x before call: ");
    //        x.Show();

    //        Console.Write("y before call: ");
    //        y.Show();

    //        Console.WriteLine();

    //        x.Swap(ref x, ref y);

    //        Console.Write("x before call: ");
    //        x.Show();

    //        Console.Write("y before call: ");
    //        y.Show();
    //    }
    //}
    //class Num {
    //    public bool HasComFactor(int x, int y, out int least, out int greatest)
    //    {
    //        int i;
    //        int max = x < y ? x : y;
    //        bool first = true;

    //        least = 1;
    //        greatest = 1;

    //        for (i = 2; i <= max/2 + 1; i++)
    //        {
    //            if (((y % i) == 0) & ((x % i) == 0))
    //            {
    //                if (first)
    //                {
    //                    least = i;
    //                    first = false;

    //                }
    //                greatest = i;
    //            }
    //        }
    //        if (least != 1) return true;
    //        else return false;
    //      }
    //}

    //class DemoOut
    //{
    //    static void Main()
    //    {
    //        Num ob = new Num();
    //        int lcf, gcf;

    //        if (ob.HasComFactor(231, 105, out lcf, out gcf))
    //        {
    //            Console.WriteLine("Least common factor" + "digits 231 and 105 is: " + lcf);
    //            Console.WriteLine("Greatest common factor" + "digits 231 and 105 is: " + gcf);
    //        }
    //    }
    //}
    //class Decompose {
    //    public int GetParts(double n, out double frac)
    //    {
    //        int whole;
    //        whole = (int)n;
    //        frac = n - whole;
    //        return whole;
    //    }
    //}

    //class UseOut
    //{
    //    static void Main()
    //    {
    //        Decompose ob = new Decompose();
    //        int i;
    //        double f;

    //        i = ob.GetParts(10.125, out f);

    //        Console.WriteLine("Whole part is equal: " + i);
    //        Console.WriteLine("Not whole part is equal: " + f);
    //    }

    //}
    //class RefTest {
    //    public void Sqr(ref int i)
    //    {
    //        i = i * i;
    //    }
    //}

    //class RefDemo {
    //    static void Main()
    //    {
    //        RefTest ob = new RefTest();
    //        int a = 10;

    //        Console.WriteLine("a befor call: " + a);

    //        ob.Sqr(ref a);

    //        Console.WriteLine("a after call: " + a);


    //    }
    //}
    //class Test {
    //    public int a, b;

    //    public Test(int i, int j)
    //    {
    //        a = i;
    //        b = j;
    //    }

    //    public void Change(Test ob)
    //    {
    //        ob.a = ob.a + ob.b;
    //        ob.b = -ob.b;
    //    }
    //}

    //class CallByRef {
    //    static void Main()
    //    {
    //        Test ob = new Test(15,20);

    //        Console.WriteLine("ob.a and ob.b before call: " + ob.a + " " + ob.b);

    //        ob.Change(ob);
            
    //        Console.WriteLine("ob.a and ob.b after call: " + ob.a + " " + ob.b);



    //    }
    //}
//    class Test {
//        public void NoChange(int i, int j)
//        {
//            i = i + j;
//            j = -j;

//        }
//    }

//    class CallByValue
//        {
//    static void Main()
//    {
//        Test ob = new Test();
//        int a = 15, b = 20;

//        Console.WriteLine("a and b before call: " + a + " " + b);

//         ob.NoChange(a,b);

//            Console.WriteLine("a and b after call: " + a + " " + b);
//    }
//}
    //class Test
    //{
    //    public int a, b;

    //    public Test(int i, int j)
    //    {
    //        a = i;
    //        b = j;
    //    }
    //    public void Change(Test ob)
    //    {
    //        ob.a = ob.a + ob.b;
    //        ob.b = -ob.b;
    //    }
    //}
    //class CallByRef
    //{
    //    static void Main()
    //    {
    //        Test ob = new Test(15, 20);
    //        Console.WriteLine("ob.a and ob.b before call: " + ob.a + " " + ob.b);
    //        ob.Change(ob);
    //        Console.WriteLine("ob.a and ob.b after call: " + ob.a + " " + ob.b);


    //    }
    //}

    //class Test
    //{
    //    public void NoChange(int i, int j)
    //    {
    //        i = i + j;
    //        j = -j;

    //    }
    //}

    //class CallByValue {
    //    static void Main()
    //    {
    //        Test ob = new Test();
    //        int a = 15, b = 20;

    //        Console.WriteLine("a and b before call: " + a + "" + b);
    //        ob.NoChange(a, b);
    //        Console.WriteLine("a and b after call: " + a + "" + b);
    //    }
    //}
    //class MyClass{
    //    int alpha, beta;

    //    public MyClass(int i, int j)
    //    {
    //        alpha = i;
    //        beta = j;
    //    }

    //    public bool SameAs(MyClass ob)
    //    {
    //        if ((ob.alpha == alpha) & (ob.beta == beta))
    //            return true;
    //        else return false;
    //    }

    //    //make a copy of object ob
    //    public void Copy(MyClass ob)
    //    {
    //        alpha = ob.alpha;
    //        beta = ob.beta;
    //    }

    //    public void Show()
    //    {
    //        Console.WriteLine("alpha: {0}, beta: {1}", alpha,beta);
    //    }
    //}

    //class PassOb {
    //    static void Main()
    //    {
    //        MyClass ob1 = new MyClass(4,5);
    //        MyClass ob2 = new MyClass(6,7);

    //        Console.Write("ob1: ");
    //        ob1.Show();
            
    //        Console.Write("ob2: ");
    //        ob2.Show();

    //        if (ob1.SameAs(ob2))
    //            Console.WriteLine("ob1 and ob2 are equalent value");
    //        else
    //            Console.WriteLine("ob1 and ob2 have different values");


    //        Console.WriteLine();

    //        ob1.Copy(ob2);
    //        Console.WriteLine("after coped ob1 show");
    //        ob1.Show();

    //        if (ob1.SameAs(ob2))
    //            Console.WriteLine("ob1 and ob2 are equalent values");
    //        else
    //            Console.WriteLine("ob1 and ob2 have different values");

    //    }
    //}
    //class Stack
    //{
    //    char[] stck;
    //    int tos;

    //    public Stack(int size)
    //    {
    //        stck = new char[size];
    //        tos = 0;
    //    }

    //    public void Push(char ch)
    //    {
    //        if (tos == stck.Length)
    //        {
    //            Console.WriteLine(" - Stack fulled");
    //            return;
    //        }

    //        stck[tos] = ch;
    //        tos++;
    //    }

    //    public char Pop()
    //    {
    //        if (tos == 0)
    //        {
    //            Console.WriteLine("- Stack empty");
    //            return (char)0;
    //        }

    //        tos--;
    //        return stck[tos];
    //    }

    //    public bool IsFull()
    //    {
    //        return tos == stck.Length;
    //    }

    //    public bool IsEmpty()
    //    {
    //        return tos == 0;
    //    }

    //    public int Capacity()
    //    {
    //        return stck.Length;
    //    }

    //    public int GetNum() {
    //        return tos;
    //    }

    //}

    //class StackDemo {
    //    static void Main()
    //    {
    //        Stack stk1 = new Stack(10);
    //        Stack stk2 = new Stack(10);
    //        Stack stk3 = new Stack(10);
    //        char ch;
    //        int i;

    //        Console.WriteLine("Put symbols inside of the stack A-J stk1");
    //        for (i = 0; !stk1.IsFull(); i++)
    //            stk1.Push((char)('A' + i));

    //        if (stk1.IsFull()) Console.WriteLine("Stack stk1 is full");

    //        Console.Write("Contains of stack stk1: ");
    //        while (!stk1.IsEmpty())
    //        {
    //            ch = stk1.Pop();
    //            Console.Write(ch);
    //        }

    //        Console.WriteLine();

    //        if (stk1.IsEmpty()) Console.WriteLine("Stack stk1 is empty");
    //        Console.WriteLine("Put symbols into stack A-J again stk1");
    //        for (i = 0; !stk1.IsFull(); i++)
    //            stk1.Push((char)('A' + i));

            
    //        Console.WriteLine("And now pop elements from the stack stk1 and put them into stk2");
    //        while (!stk1.IsEmpty())
    //        {
    //            ch = stk1.Pop();
    //            stk2.Push(ch);
    //        }
    //        Console.WriteLine("Stack stk2 include: ");
    //        while (stk2.IsEmpty())
    //        {
    //            ch = stk2.Pop();
    //            Console.Write(ch);
    //        }

    //        Console.WriteLine("\n");
    //        Console.WriteLine("Put  5 symbols inside of stack");
    //        for (i = 0; i < 5; i++)
    //        {
    //            stk3.Push((char)('A' + i));
    //            Console.WriteLine("Capacity of stk3 is: " + stk3.Capacity());
    //            Console.WriteLine("Objects inside of stk3 is :" + stk3.GetNum());
    //        }
    //    }
    //}

    //class StrOps {
    //    static void Main()
    //    {
    //        string s1 = "Coding in .net much better on C#";
    //        string s2 = "Coding in .net much better on C#";
    //        string s3 = "String in C# more effective";
    //        string strUP, strLow;
    //        int result, idx;

    //        Console.WriteLine("s1: " + s1);
    //        Console.WriteLine("Length s1: "+ s1.Length);

    //        strLow = s1.ToLower(CultureInfo.CurrentCulture);
    //        strUP = s2.ToUpper(CultureInfo.CurrentCulture);
    //        Console.WriteLine(strUP);
    //        Console.WriteLine(strLow);
    //        Console.WriteLine();

    //        for(int i = 0; i< s1.Length; i++)
    //            {
    //            Console.Write(s1[i]);
    //        }
    //        Console.Write("\n");

    //        if (s1 == s2)
    //            Console.WriteLine("s1 == s2");
    //        else
    //        {
    //            Console.WriteLine("s1 != s2");
    //        }

    //        if (s1 == s3)
    //            Console.WriteLine("s1 == s3");
    //        else
    //            Console.WriteLine("s1 != s3");

    //        result = string.Compare(s3, s1, StringComparison.CurrentCulture);
    //        if (result == 0)
    //            Console.WriteLine("s1 and s3 is equal");
    //        else if (result < 0)
    //            Console.WriteLine("s1 < s3");
    //        else
    //            Console.WriteLine("s1 > s3");

    //        Console.WriteLine();
    //        s2 = "One two  three";
    //        idx = s2.IndexOf("One", StringComparison.Ordinal);

    //        Console.WriteLine("First index of substring: {0}", idx);
    //        idx = s2.LastIndexOf("three", StringComparison.Ordinal);
    //        Console.WriteLine("Last index of substring: {0}", idx);
    //    }
    //}

    //class Search {
    //    static void Main() {
    //        int[] nums = new int[10];
    //        int val;
    //        bool found = false;

    //        for (int i = 0; i < 10; i++)
    //            nums[i] = i;

    //        val = 5;
    //        foreach (int x in nums)
    //        {
    //            if (x == val) { found = true; break; }
    //        }
    //        if (found)
    //            Console.WriteLine("Value has been found");
    //    }
    //}
    //class AssignARef {
    //    static void Main()
    //    {
    //        int i;

    //        int[] nums1 = new int[10];
    //        int[] nums2 = new int[10];

    //        for (i = 0; i < 10; i++) nums1[i] = i;

    //        for (i = 0; i < 10; i++) nums2[i] = -i;
    //        Console.WriteLine("Content array nums1: ");
    //        for (i = 0; i < 10; i++)
    //            Console.WriteLine(nums1[i] + " ");
    //        Console.WriteLine();

    //        Console.WriteLine("Content array nums2: ");
    //        for (i = 0; i < 10; i++)
    //            Console.WriteLine(nums2[i] + " ");
    //        Console.WriteLine();

    //        nums2 = nums1;

    //        Console.Write("Content array nums2\n" + "after =: ");
    //        for (i = 0; i < 10; i++)
    //            Console.Write(nums2[i] + " ");
    //        Console.WriteLine();

    //        nums2[3] = 99;

    //        Console.Write("Content array nums1 after changes\n" + "by variable nums2: ");
    //        for (i = 0; i < 10; i++)
    //            Console.Write(nums1[i] + " ");
    //        Console.WriteLine();
    //    }
    //}
    //class Rect {
    //    public int Width;
    //    public int Height;

    //    public Rect(int w, int h)
    //    {
    //        Width = w;
    //        Height = h;
    //    }

    //    public int Area() {
    //        return Width * Height;
    //    }
    //}

    //class UseRect {
    //    static void Main() {
    //        Rect r1 = new Rect(4, 5);
    //        Rect r2 = new Rect(7,9);

    //        Console.WriteLine("Area figure is r1: " + r1.Area());
    //        Console.WriteLine("Area figure is r2: " + r2.Area());
    //    }
    //}
    //class Building {

    //    public int Floors;
    //    public int Area;
    //    public int Occupants;

    //    public Building(int f, int a, int o)
    //    {
    //        Floors = f;
    //        Area = a;
    //        Occupants = o;
    //    }
    //    public int AreaPerPerson()
    //    {
    //        return Area / Occupants;
    //    }

    //    public int MaxOccupant(int minArea)
    //    {
    //        return Area / minArea;
    //    }

    //    class BuildingDemo {
    //    static void Main() {
    //        Building house = new Building(2, 2500, 4);
    //        Building office = new Building(3, 4200, 25);

            
                
            
    //        Console.WriteLine("MAx people in our house is, \n" + house.MaxOccupant(300));

    //            Console.WriteLine();

    //            Console.WriteLine("MAx people in our house is, \n" + office.MaxOccupant(300));

    //            office.AreaPerPerson();
    //        }
    //}
    //}
    //class BreakNested
    //{
    //    static void Main()
    //    {
    //        for (int i = 0; i < 3; i++)
    //        {
    //            Console.WriteLine("Count external cycle: " + i);
    //            Console.Write("Count internal cycle: ");

    //            int t = 0;
    //            while (t < 100) {
    //                if (t == 10) break;
    //                Console.Write(t + " ");
    //                t++;
    //            }

    //            Console.WriteLine();
    //        }
    //        Console.WriteLine("cycle finish");
    //    }
    //}
    //class DoWhileDemo { 
    //static void Main()
    //    {
    //        int num;
    //        int nextdigit;
    //        num = 198;

    //        Console.WriteLine("Digit: " + num);
    //        Console.Write("Number in reverse mode: ");

    //        do
    //        {
    //            nextdigit = num % 10;
    //            Console.Write(nextdigit);
    //            num = num / 10;
    //        } while (num > 0);
    //        Console.WriteLine();
    //    }
    //}
 //   class Comma {
 //       static void Main()
 //       {
 //           int i, j;
 //           int smallest, largest;
 //           int num;

 //           num = 100;

 //           smallest = largest = 1;

 //           for (i = 2, j = num / 2; (i <= num / 2) & (j >= 2); i++, j--)
 //           {
 //               if ((smallest == 1) &((num % i) == 0))
 //               smallest = i;
 //           if ((largest == 1) & ((num % j) == 0))
 //               largest = j;
 //       }
 //           Console.WriteLine("largest multiplier: " + largest);
 //           Console.WriteLine("smallest multiplier: " + smallest);
 //       }
 //}
   // class FindPrimes {
   //     static void Main()
   //     { 
   //     int num;
   //     int i;
   //     int factor;
   //     bool isprime;

   //     for (num = 2; num<20; num++)
			//{
   //         isprime = true;
   //         factor = 0;
			
   //         for (i = 2; i <= num/2; i++)
   //         {
   //             if ((num % i) == 0) {
   //                 isprime = false;
   //                 factor = i;
   //             }

   //         }
   //         if (isprime)
   //             Console.WriteLine(num + " - simple digit.");
   //         else
   //             Console.WriteLine("biggest * digit" + num + "equals" + factor);
   //     }
   //   }
   // }
    //class SwitchDemo {
    //    static void Main() {
    //        int i;

    //        for (i = 0; i < 10; i++)
    //        switch (i){
    //                case 0:
    //                    Console.WriteLine("i equals zero");
    //                    break;
    //                case 1:
    //                    Console.WriteLine("i equals 1");
    //                    break;
    //                case 2:
    //                    Console.WriteLine("i equals 2");
    //                    break;
    //                case 3:
    //                    Console.WriteLine("i equals 3");
    //                    break;
    //                case 4:
    //                    Console.WriteLine("i equals 4");
    //                    break;
    //                default:
    //                    Console.WriteLine("i equals 5 or greater");
    //                    break;
    //            }
    //    }
    //}
    //class NoZeroDiv { 
    //static void Main() {

    //        for (int i = -5; i < 6; i++)
    //        {
    //            if (i != 0 ? (i % 2 == 0) : false)
    //                Console.WriteLine("100 / " + i + " equals " + 100 / i);
    //        }
    //        //int result;
    //        //for (int i = -5; i < 6; i++)
    //        //{
    //        //    result = i != 0 ? 100 / i : 0;
    //        //    if (i!=0)
    //        //    {
    //        //        Console.WriteLine("100 / " + i + " equals " + result);
    //        //    }
    //        //}
    //    }
    //}
    //class PrePostDemo { 
    //static void Main()
    //    {
    //        int x, y;
    //        int i;

    //        x = 1;
    //        y = 0;
    //        Console.WriteLine("Number of digits received" + "with helping operator y = y + x++;");
    //        for (i = 0; i < 10; i++)
    //        {
    //            y = y + x++;
    //            Console.WriteLine(y + " ");
    //        }
    //        Console.WriteLine();

    //        x = 1;
    //        y = 0;

    //        Console.WriteLine("Number of digits received" + "with helping operator y = y+ ++x;");
    //        for (i = 0; i < 10; i++)
    //            {
    //                y = y + ++x;

    //                Console.WriteLine(y + " ");
    //            }
    //        }
    //    }
    //class CastExpr {
    //    static void Main()
    //    {
    //        double n;

    //        for (n = 1.0; n <= 10; n++)
    //        {
    //            Console.WriteLine("Квадратный корень из {0} равен {1}", n, Math.Sqrt(n));
    //            Console.WriteLine("d: {0}", (int)Math.Sqrt(n));
    //            Console.WriteLine("Дробная часть числа: {0}", Math.Sqrt(n) - (int)Math.Sqrt(n));
    //        }
    //    }
    //}
    //class ScopeDemo {

    //    static void Main() {
    //        int x;
    //        x = 10;
    //        if (x == 10)
    //        {
    //            int y = 20;
    //            x = y * 2;
    //        }
    //        Console.WriteLine("x equals " + x);
    //    }
    //}
    //class DisplayOptions {
    //    static void Main()
    //    {
    //        int i;
    //        Console.WriteLine("Number/Square/Cube");
    //        for (i = 1; i < 10; i++)
    //            Console.WriteLine("{0}\t{1}\t{2}", i, i*i, i*i*i);
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        double radius; //test variable
    //        double area; //test variable

    //        radius = 10.0;
    //        area = radius * radius * 3.1416;

    //        Console.WriteLine("Area is equal: " + area);
    //        Earth();
    //    }

    //    static void Earth()
    //    {
    //        long inches;
    //        long miles;

    //        miles = 93000000;
    //        inches = miles * 5280 * 12;
    //        Console.WriteLine("Distance to sun: " + inches);
    //    }
    //}

    //class Use_byte {
    //    static void Main() 
    //    {
    //        byte x;
    //        int sum;
    //        sum = 0;
    //        for (x = 1; x <= 100; x++)
    //            sum = sum + x;

    //        Console.WriteLine("Sum from 1 to 100 is equal: " + sum);
    //   }
    //}

    //class NestVar
    //{
    //    static void Main()
    //    {
    //        int count;

    //        for (count = 0; count < 10; count = count + 1)
    //        {
    //            Console.WriteLine("Something: " + count);

    //            int count;
    //            for (count = 0; count < 2; count++)
    //                Console.WriteLine("Issue appears here");
    //        }
    //    }
    //}
}