using UnityEngine;

public class Human2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // Update is called once per frame


 
    void Start()
    {

        //Adult john = new Adult("john", 28, 173);
        //Baby lisa = new Baby("lisa", 3, 95);
        //Debug.Log(john.age);
        //lisa.Sleep();

        Adult maria = new Adult("Alice", 26, 165.5f);

        maria.Age = 10;
        maria.SetBaseAge(2);
        Debug.Log(maria.Age);
        Debug.Log(maria.GetBaseAge());

        //Human jason = maria;
        //Debug.Log(jason.GetAge());

        //Human Bob = new Human("bob", 26, 165.5f);
        //Adult tmpA = (Adult)Bob;

    }

    class Human
    {
        protected string name;
        protected int age;
        protected float height;
        protected string address;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public float Height
        {
            get { return height; }
            set { height = value; }
        }
        public int GetAge()
        { return age; }
        public void SetAge(int _age)
        {
            age = _age;
        }
        public Human()
        { 
        
        }

        public Human(string _name, int _age, float _height)
        {
            this.name = name;
            this.age = age;
            this.height = height;
        }

        public void Eat()
        {
            Debug.Log("eat");
        }
        public void Walk()
        {
            Debug.Log("walk");
        }
        public void Sleep()
        {
            Debug.Log("sleep");
        }

  
        //void Start()
        //{
        //    float result = Half(4);
        //    Debug.Log(result);
        //}
        //float Half(float num)
        //{
        //    return num / 2;
        //}
    }

    class Adult : Human
    {

        public Adult()
        {

        }
        public Adult(string _name, int _age, float _height) : base(_name, _age, _height)
        {
            Age = _age;
        }

        public void PrintAddress()
        {
            Debug.Log(address);
        }
        public int Age;
        public void SetBaseAge(int age)
        {
            base.age = age;
        }
        public int GetBaseAge()
        {
            return base.age;
        }
    }



    class Baby : Human
    {
        public Baby(string _name, int _age, float _height) : base(_name, _age, _height) { }
    }
    //Human john = new Human(); // new = 메모리에 인간 john 객체 을 할당하십시오.
    //Human Alice = new Human("alice", 213, 160);

}





