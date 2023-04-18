namespace labo10
{
    class Person
    {
        public string Surname { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public DateTime Birth { get; set; }

        public Person() { Surname = "";Height = 0;
            Weight = 0;
        }
        public Person(string surname, double Height,double Weight, DateTime birth)
        {
            Surname = surname;
            this.Height = Height;
            Birth = birth;
            this.Weight = Weight;
        }
        public Person(Person a)
        {
            Surname = a.Surname;
            Height = a.Height;
            Birth = a.Birth;
            Weight = a.Weight;
        }
        public int Age()
        {
            int a = DateTime.Today.Year - Birth.Year;
            if (Birth.Month > DateTime.Today.Month || (Birth.Month == DateTime.Today.Month && Birth.Day > DateTime.Today.Day))
                a--; return a;
        }
        public override string ToString()
        {
            return Surname + " " + Height + " " + Weight + " " + Age();
        }
    }
}
