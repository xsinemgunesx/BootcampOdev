namespace BootcampOdev;

public abstract class Animal
{
	private string name;
	private string kind;
	private int age;
	public string Name
	{
		get { return name; }
		set { name = value; }
	}
	public string Kind
	{
		get { return kind; }
		set { kind = value; }
	}
	public int Age
	{
		get { return age; }
		set { age = value; }
	}
	public abstract void makeNoise();
	public void zooland()
	{
		Console.WriteLine($"Hayvanin ismi :{Name},\nHayvanin turu : {Kind},\nHayvanin yasi : {Age} ");
	}
}

public class Dog : Animal
{
	public Dog()
	{
		Name = "Köpüş";
		Kind = "Köpek";
		Age = 4;
	}
	public override void makeNoise()
	{
		Console.WriteLine("HAV HAV HAV!!!");
	}
	
}
public class Cat : Animal
{
	public Cat()
	{
		Name = "Miya";
		Kind = "Kedi";
		Age = 2;
	}
	public override void makeNoise()
	{
		Console.WriteLine("Miyav miyav!!!");
	}
}
public class Bird : Animal
{
	public Bird()
	{
		Name = "Mavis";
		Kind = "Kus";
		Age = 1;
	}

	public override void makeNoise()
	{
		Console.WriteLine("Cik cik cik!!!");
	}
}
public class ZOO
{
	static void showAnimal(Animal[] animal)
	{
		for(int i = 0;i < animal.Length; i++)
		{
			animal[i].zooland();
			animal[i].makeNoise();
			Console.WriteLine();
		}

	}
	static void Main(String[] args)
	{
		Animal[] animalList = new Animal[3];
		animalList[0] = new Dog();
		animalList[1] = new Cat();
		animalList[2] = new Bird();
		showAnimal(animalList);
		
	}
}
