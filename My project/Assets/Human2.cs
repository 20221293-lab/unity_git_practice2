using UnityEngine;

public class Human2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Adult john = new Adult("john", 28, 173);
        Baby lisa = new Baby("lisa", 3, 95);
        Debug.Log(john.age);
        lisa.Sleep();

    }

    class Adult : Human
    { 
    public Adult(string _name, int _age, float _height) : base(_name, _age, _height) { }   
    }
    class Baby : Human
    {
        public Baby(string _name, int _age, float _height) : base(_name, _age, _height) { }
    }

    // Update is called once per frame

    class Human
    {
        public string name;
        public int age;
        public float height;
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
        { }

        public Human(string _name, int _age, float _height)
        {
            name = _name;
            age = _age;
            height = _height;
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

    //Human john = new Human(); // new = 메모리에 인간 john 객체 을 할당하십시오.
    //Human Alice = new Human("alice", 213, 160);

}





