public abstract class Animal  // it wasn't abstact initially but in the course made it so to learn. . .
{
    private string name;
    private string favouriteFood;

    public string FavouriteFood
    {
        get { return favouriteFood; }
        set { favouriteFood = value; }
    }

    public string Name
    {
        get { return this.name; }
        set { name = value; }
    }


    public virtual string ExplainMyself()
    {
        return $"I am {this.Name} and my favourite food is {this.FavouriteFood}";
    }
}
