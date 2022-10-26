// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Square mySquare = new Square(3);
Square mySquare2 = new Square(6);
Circle myCircle = new Circle(3);

int x = myCircle.GetRadius();
x = 10;

Console.WriteLine(MathHelper.PI);

Display display = new Display();

display.printArea(mySquare);
display.printArea(myCircle);



MyList<string> stringList = new MyList<string>();
stringList.AddElement("first");
stringList.AddElement("second");


MyList<int> intList = new MyList<int>();
intList.AddElement(0);
//intList.AddElement("two");

