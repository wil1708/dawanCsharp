namespace HelloWorld2
{
    internal class Car
    {
        //Field
        private string _name;
        private int _hp;
        private string _color;
        private int _maxspeed;

        public int MaxSpeed
        {
            set
            {
                _maxspeed = value;
            }
        }

        public string Name { 
            get { return _name; }
            set { _name = value; }
        }

        public Car()
        {
            _name = "Car";
            _hp = 0;
            _color = "red";
        }
        
        public Car(string name, int hp = 0)
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _color = "red";
        }

        public Car(string name, int hp, string color)
        {
            _name = name;
            Console.WriteLine(name + " was created");
            _hp = hp;
            _color = color;
        }

        public void Drive()
        {
            Console.WriteLine(_name + " is driving");
        }

        public void Stop()
        {
            Console.WriteLine(_name + " stopped");
        }

        public void Details()
        {
            Console.WriteLine(_name + " has " + _hp + " horse power and is " + _color);

            //je suis un commentaire
        }

    }
}
