namespace indexators;

enum Vendors
{
    Samsung, Asus, LG
};
public class Shop
{
    public Laptop[] laptopArr;

    public Shop(int size)
    {
        laptopArr = new Laptop[size];
    }

    public int Length
    {
        get { return laptopArr.Length; }
    }

    public Laptop this[int index]
    {
        get
        {
            if (index >= 0 && index < laptopArr.Length)
            {
                return laptopArr[index];
            }

            throw new IndexOutOfRangeException();
        }
        set
        {
            laptopArr[index] = value;
        }
    }

    public Laptop this[string name]
    {
        get
        {
            if (Enum.IsDefined(typeof(Vendors), name))
            {
                return laptopArr[(int) Enum.Parse(typeof(Vendors), name)];
            }
            else
            {
                return new Laptop();
            }
        }
        set
        {
            if (Enum.IsDefined(typeof(Vendors), name))
            {
                laptopArr[(int) Enum.Parse(typeof(Vendors), name)] = value;
            }
        }
    }
}