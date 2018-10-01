namespace Human
{
    public class Human{
        public string Name;
        public int Health;
        public int strength;
        public int intelligence;
        public int dexterity;
        public int attack;

        public Human(string name){
            Name = name;
            Health = 100;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
        }
        public Human(string name, int H = 100, int S = 3, int I = 3, int D = 3 ){
            Name = name;
            Health = H;
            strength = S;
            intelligence = I;
            dexterity = D;
        }

        public void Attack(string att_name, int att_health ){
            Name = att_name;
            attack = 5 * strength;
            att_health -= attack;
            System.Console.WriteLine("attacked " + Name + " loss " + attack + "remain health " + att_health);
        }

    }
}