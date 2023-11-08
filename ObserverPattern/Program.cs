using ObserverPattern;

class Program
{
    public static void Main()
    {
        Publisher publisher = new Publisher();

        Observer observerA = new Observer();

        publisher.Attact(observerA);

        publisher.Publish();
    }
}