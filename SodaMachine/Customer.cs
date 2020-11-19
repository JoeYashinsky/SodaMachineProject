using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachine
{
    class Customer
    {
        //Member Variables (Has A)
        public Wallet Wallet;
        public Backpack Backpack;

        //Constructor (Spawner)
        public Customer()
        {
            Wallet = new Wallet();
            Backpack = new Backpack();
        }
        //Member Methods (Can Do)

        //This method will be the main logic for a customer to retrieve coins from their wallet.
        //Takes in the selected can for price reference.
        //Will need to get user input for coins they would like to add.
        //When all is said and done, this method will return a list of coin objects that the customer will use as payment for their soda.
        public List<Coin> GatherCoinsFromWallet(Can selectedCan)  
        {
            //possibly look at CoinSelection(Can selectedCan, List<Coin> paymnet) from UserInterface
            double 

        }
        //Returns a coin object from the wallet based on the name passed into it.
        //Returns null if no coin can be found
        public Coin GetCoinFromWallet(string coinName)   //same logic as GetSodaFromInventory. If coin object matches coin selected by customer, retrieve the Coin and remove assoc value from Wallet.
        {
            foreach (Coin coinObject in Wallet.Coins)
            {
                if (coinObject.Name == coinName)
                {
                    Wallet.Coins.Remove(coinObject);
                    return coinObject;
                }
                else
                {
                    return null;
                }

            }
            
        }
        //Takes in a list of coin objects to add into the customers wallet.
        public void AddCoinsIntoWallet(List<Coin> coinsToAdd)
        {
            foreach(Coin addedCoins in coinsToAdd)
            {
                Wallet.Coins.Add(addedCoins);
            }
            
        }
        //Takes in a can object to add to the customers backpack.
        public void AddCanToBackpack(Can purchasedCan)
        {
            Backpack.cans.Add(purchasedCan);
        }

    }
}
