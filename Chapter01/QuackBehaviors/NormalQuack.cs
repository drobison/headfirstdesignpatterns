namespace Chapter01.QuackBehaviors
{
    public class NormalQuack : IQuackBehavior
    {
        public void Quack()
        {
            System.Console.WriteLine("Quack");
        }
    }
}