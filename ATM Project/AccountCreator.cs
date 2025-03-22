using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Project
{
    [Serializable]
    internal class AccountCreator
    {
        private String Name, AccNo, Pin, CPin, Fileinf;
        private double Balance;
        public String name
        {
            
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public double balance
        {
            get
            {
                return Balance;
            }
            set
            {
                Balance = value;
            }
        }
        public String accno
        {
            get
            {
                return AccNo;
            }
            set
            {
                AccNo = value;
            }
        }
        public String pin
        {
            get
            {
                return Pin;
            }
            set
            {
                Pin = value;
            }
        }
        public String cpin
        {
            get
            {
                return CPin;
            }
            set
            {
                CPin = value;
            }
        }
        public String fileinf
        {
            get
            {
                return Fileinf;
            }
            set
            {
                Fileinf = value;
            }
        }
    }
}
