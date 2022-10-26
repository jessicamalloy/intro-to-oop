public class MyList<T> {
    private T[] elements;

    public MyList()
    {
        elements = Array.Empty<T>();
    }

    public void AddElement(T element) {
        elements.Append(element);
    }

    public T First()
    {
        return elements[0];
    }


}