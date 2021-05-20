using System;


namespace CannibalGame
{
    public abstract class CGame
    {
        public void TemplateMethod()
        {
            Sleep();
            Eat();
            Converse();
            Catch();
        }

        public abstract void Sleep();
        public abstract void Eat();
        public abstract void Converse();
        public abstract void Catch();
        public abstract void Cook();
    }

    public sealed class FirstCannibal : CGame
    {
        public override void Catch()
        {

            Console.WriteLine("Catch "); ;
        }

        public override void Converse()
        {
            Console.WriteLine("Talk ");
        }

        public override void Cook()
        {
            Console.WriteLine("Cook ");
        }

        public override void Eat()
        {
            Console.WriteLine("Eat ");
        }

        public override void Sleep()
        {
            Console.WriteLine("Sleep ");

        }
    }

    public enum Week 
    {
        WorkingDay,
        OffDay 
    }
    public sealed class SecondCannibal : CGame
    {
        Week day;
        public SecondCannibal(Week day)
        {
            this.day = day;
        }
        public override void Catch()
        {
            throw new NotImplementedException();
            //Console.WriteLine("Catch");
        }

        public override void Converse()
        {
            Console.WriteLine("Talk ");
        }

        public override void Cook()
        {
           if (day == Week.WorkingDay)
            {
                Console.WriteLine("grill ");
            }
            else Console.WriteLine("cook");

        }

        public override void Eat()
        {
            Console.WriteLine("eat ");
            throw new NotImplementedException();
        }

        public override void Sleep()
        {
            Console.WriteLine("Sleep ");
            //throw new NotImplementedException();
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            CGame FirstCannibal = new FirstCannibal();
            FirstCannibal.TemplateMethod();
            //CGame SecondCannibal = new SecondCannibal(Week.OffDay);
           //SecondCannibal.TemplateMethod();
        }
        
    }
}
