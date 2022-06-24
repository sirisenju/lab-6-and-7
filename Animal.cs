namespace labWork
{
    public class Animal
    {
        public String? name;
        public String? gender;
        public int age;
        public virtual void AnimalSound(){
            Console.WriteLine("This animal makes: ");
        }
    }
    class Dog: Animal{
        public Dog(String? name, String? gender, int age){
            this.name = name;
            this.gender = gender;
            this.age = age;
        }
        public override void AnimalSound()
        {
            Console.WriteLine("And the Dog goes woff woff!");
        }

    }
    class Frog: Animal{
        public Frog(String? name, String? gender, int age){
            this.name = name;
            this.gender = gender;
            this.age = age;
        }
        public override void AnimalSound()
        {
            Console.WriteLine("And the frog goes crock crock!");
        }

    }
    class Cat: Animal{
        public Cat(String? name, String? gender, int age){
            this.name = name;
            this.gender = gender;
            this.age = age;
        }
        public override void AnimalSound()
        {
            Console.WriteLine("And the Cat goes meowwwwwwwwww!");
        }
        

    }
    class Kitten: Animal{
        public Kitten(String? name, String? gender, int age){
            this.name = name;
            this.gender = gender;
            this.age = age;
        }
        public override void AnimalSound()
        {
            Console.WriteLine("And the Kitten goes meowww meowww!");
        }
    

    }
}