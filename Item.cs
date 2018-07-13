namespace Groceryapp
{
    public class Item
    {
        public Item(string name, int count)
        {
            Name = name;
            count = count;
        }

        public string Name { get; set; }
        public int Count { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

}