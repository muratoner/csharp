using System;
using static System.Console;

namespace MHG.CSharp7
{
	public class Program
	{
		static void Main(string[] args)
		{
            #region Binary Literal
                int[] numbers = { 0b1, 0b100, 0b1000, 0b1_000, 0b10_0000 };
            #endregion

            #region Pattern Matching
                //WriteStars(null);
                //WriteStars("abc");
                //WriteStars("12");
            #endregion

            #region Ref Returns And Locals
                //int[] array = { 1, 15, -39, 0, 7, 14, -12 };
                //ref int place = ref Find(7, array); // aliases 7's place in the array
                //place = 9; // replaces 7 with 9 in the array
                //WriteLine(array[4]); // prints 9
            #endregion

            #region Switch Case Features
                //GetInfo(new Circle());
                //GetInfo(new Rectangle { Height = 50, Length = 50 } );
                //GetInfo(new Rectangle { Height = 25, Length = 50 } );
            #endregion

            #region Tuples
                //var res = GetItem();
                //WriteLine($"Ad: {res.FullName}");
                //WriteLine($"Doğum Yılı: {res.Year}");
            #endregion
        }
        #region Pattern Matching
            public static void WriteStars(object o)
            {
                if (o is null) return;

                if (!(o is int i)) return;

                WriteLine(new string('*', i));
            }
        #endregion

        #region Ref Returns And Locals
            public static ref int Find(int number, int[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == number)
                    {
                        return ref numbers[i]; // return the storage location, not the value
                    }
                }
                throw new IndexOutOfRangeException($"{nameof(number)} not found");
            }
        #endregion

        #region Swith Case Features
            public class Shape
            {

            }

            public class Circle : Shape
            {
                public double Radius { get; set; }
            }

            public class Rectangle : Shape
            {
                public int Length { get; set; }
                public int Height { get; set; }
            }

            public static void GetInfo(Shape shape)
            {
                switch (shape)
                {
                    case Circle c:
                        WriteLine($"circle with radius {c.Radius}");
                        break;
                    case Rectangle s when (s.Length == s.Height):
                        WriteLine($"{s.Length} x {s.Height} square");
                        break;
                    case Rectangle r:
                        WriteLine($"{r.Length} x {r.Height} rectangle");
                        break;
                    default:
                        WriteLine("<unknown shape>");
                        break;
                    case null:
                        throw new ArgumentNullException(nameof(shape));
                }
            }
        #endregion

        #region Tuples
            static (string FullName, int Year) GetItem()
                => ("Murat ÖNER", 1989);
        #endregion
    }
}