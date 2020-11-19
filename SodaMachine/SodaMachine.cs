﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class SodaMachine
    {
        //Member Variables (Has A)
        private List<Coin> _register;
        private List<Can> _inventory;

        //Constructor (Spawner)
        public SodaMachine()
        {
            _register = new List<Coin>();
            _inventory = new List<Can>();
            FillInventory();
            FillRegister();
        }

        //Member Methods (Can Do)

        //A method to fill the soda machine's register with coin objects.
        public void FillRegister()
        {
            for (int i = 0; i < 20; i++)
            {
                Quarter quarter = new Quarter();
                _register.Add(quarter);
            }
            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                _register.Add(dime);
            }
            for (int i = 0; i < 20; i++)
            {
                Nickel nickel = new Nickel();
                _register.Add(nickel);
            }
            for (int i = 0; i < 50; i++)
            {
                Penny penny = new Penny();
                _register.Add(penny);
            }


        }
        //A method to fill the soda machine's inventory with soda can objects.
        public void FillInventory()
        {
            for (int i = 0; i < 5; i++)
            {
                Cola cola = new Cola();
                _inventory.Add(cola);
            }
            for (int i = 0; i < 5; i++)
            {
                OrangeSoda orangeSoda = new OrangeSoda();
                _inventory.Add(orangeSoda);
            }
            for (int i = 0; i < 5; i++)
            {
                RootBeer rootBeer = new RootBeer();
                _inventory.Add(rootBeer);
            }
        }
            
        
        //Method to be called to start a transaction.
        //Takes in a customer which can be passed freely to which ever method needs it.
        public void BeginTransaction(Customer customer)
        {
            bool willProceed = UserInterface.DisplayWelcomeInstructions(_inventory);
            if (willProceed)
            {
                Transaction(customer);
            }
        }
        
        //This is the main transaction logic think of it like "runGame".  This is where the user will be prompted for the desired soda.
        //grab the desired soda from the inventory.
        //get payment from the user.
        //pass payment to the calculate transaction method to finish up the transaction based on the results.
        private void Transaction(Customer customer)   //would a tuple be appropriate in this instance since we  
                                                     //are we able to use the UserInterface methods when appropriate? There is relevant methods in that Class that can provide logic here.
        {
            string desiredSoda = UserInterface.SodaSelection(_inventory);   //prompted for desired soda
            Can canProduct = GetSodaFromInventory(desiredSoda);       //(from below)  CalculateTransaction(List<Coin> payment, Can chosenSoda, Customer customer)


        }
        //Gets a soda from the inventory based on the name of the soda.
        private Can GetSodaFromInventory(string nameOfSoda)   //this can be a foreach loop. If the name of the soda matches the soda selected, remove a soda from the inventory.
        {
            foreach (Can can in _inventory)
            {
                if(can.Name == nameOfSoda)
                {
                    _inventory.Remove(can);

                    return can;

                }
                else
                {
                    return null;
                }

                                                        
            }
          
        }

        //This is the main method for calculating the result of the transaction.
        //It takes in the payment from the customer, the soda object they selected, and the customer who is purchasing the soda.
        //This is the method that will determine the following:
        //If the payment is greater than the price of the soda, and if the sodamachine has enough change to return: Dispense soda, and change to the customer.
        //If the payment is greater than the cost of the soda, but the machine does not have ample change: Dispense payment back to the customer.
        //If the payment is exact to the cost of the soda:  Dispense soda.
        //If the payment does not meet the cost of the soda: dispense payment back to the customer.
        private void CalculateTransaction(List<Coin> payment, Can chosenSoda, Customer customer)
        {
            if (//payment is greater than price of soda, if sodamachine has enough change, dispense soda and change to cust)
            {

            }
            else if (//payment is greater than cost of soda, but machine does not have enough change, give payment back to cust)
            {
                   
            }
            else if (//payment is exactly the cost of the item, then dispense soda to customer)
            {

            }
            else if (//payment does not meet total cost of soda, give coins back to the customer)

            

        }
        //Takes in the value of the amount of change needed.
        //Attempts to gather all the required coins from the sodamachine's register to make change.
        //Returns the list of coins as change to dispense.
        //If the change cannot be made, return null.
        private List<Coin> GatherChange(double changeValue)
        {
            List<Coin> changeCoins = new List<Coin>();
            while (changeValue > 0)
            {
                if (changeValue > 0.25)
                {
                    Coin quarter = GetCoinFromRegister("Quarter");
                    changeCoins.Add(quarter);
                    changeValue -= .25;
                }
                else if (changeValue >= .10)
                {
                    Coin dime = GetCoinFromRegister("Dime");
                    changeCoins.Add(dime);
                    changeValue -= .10;
                }
                else if (changeValue >= .05)
                {
                    Coin nickel = GetCoinFromRegister("Nickel");
                    changeCoins.Add(nickel);
                    changeValue -= .05;
                }
                else if (changeValue >= 0)
                {
                    Coin penny = GetCoinFromRegister("Penny");
                    changeCoins.Add(penny);
                    changeValue -= .01;
                }
                //////Do I need an "else" statement to end this loop and then the logic inside would just be "return null"?

                return changeCoins;
            }

            
        }
        //Reusable method to check if the register has a coin of that name.
        //If it does have one, return true.  Else, false.
        private bool RegisterHasCoin(string name)
        {
           
        }
        //Reusable method to return a coin from the register.
        //Returns null if no coin can be found of that name.
        private Coin GetCoinFromRegister(string name)
        {
            
        }
        //Takes in the total payment amount and the price of can to return the change amount.
        private double DetermineChange(double totalPayment, double canPrice)
        {
            double returnedChange;
            returnedChange = totalPayment - canPrice;

            return returnedChange;
        }
        //Takes in a list of coins to return the total value of the coins as a double.
        private double TotalCoinValue(List<Coin> payment)
        {
            double totalValue = 0;
            foreach (Coin coin in payment)
            {
                totalValue += coin.Value;
            }
            return totalValue;

           
        }
        //Puts a list of coins into the soda machine's register.
        private void DepositCoinsIntoRegister(List<Coin> coins)
        {
            foreach(Coin coin in coins)
            {
                _register.Add(coin);
            }




           
        }
    }
}
