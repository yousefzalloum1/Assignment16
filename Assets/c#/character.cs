using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{
    public class Character : MonoBehaviour
    {
      
        public string Name = "No name";
        
        
        private int health = 100;

        
        protected Position position = new Position(0, 0, 0);

       
        public int Health
        {
            get { return health; }
            set { health = Mathf.Clamp(value, 0, 100); }
        }

       
        public void Start()
        {
            
            Health = health; 
            DisplayInfo(); 
        }

        
        public virtual void DisplayInfo()
        {
            Debug.Log("Name: " + Name + ", Health: " + Health);
            position.PrintPosition();
        }
    }
}
