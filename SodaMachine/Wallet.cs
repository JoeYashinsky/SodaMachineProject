﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Wallet
    {
        //Member Variables (Has A)
        public List<Coin> Coins;
        //Constructor (Spawner)
        public Wallet()
        {
            Coins = new List<Coin>();
            FillRegister();
        }
        //Member Methods (Can Do)
        //Fills wallet with starting money
        private void FillRegister()           //Wallet will begin with $4 in quarters, $1 in dimes, $1 in nickels, $0.25 in pennies. Total = $6.25
        {
            for (int i = 0; i < 16; i++)
            {
                Quarter quarter = new Quarter();
                Coins.Add(quarter);
            }
            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                Coins.Add(dime);
            }
            for (int i = 0; i < 20; i++)
            {
                Nickel nickel = new Nickel();
                Coins.Add(nickel);
            }
            for (int i = 0; i < 25; i++)
            {
                Penny penny = new Penny();
                Coins.Add(penny);
            }

          
        }
    }
}
