namespace Library
{
    public class ExampleDto
    {
        public ExampleDto(int value)
        {
            Value = value;
        }

        public int Value { get; private set; }
    }
}