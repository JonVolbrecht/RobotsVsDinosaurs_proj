﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    public class Dinosaur
    {
        //Member Variables
        public string type;
        public int health;
        public int energy;
        public int attackPow;

        //Constructor
        public Dinosaur(string type, int health, int energy, int attackPow)
        {
            this.type = type;
            this.health = health;
            this.energy = energy;
            this.attackPow = attackPow;

        }

        //Methods
        public void Attack(Robot robot) // what parameter should I pass in here?
        {
            robot.durability = robot.durability - attackPow;
        }
    }










}



