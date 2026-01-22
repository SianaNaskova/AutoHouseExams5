using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Autohouse
{
    public abstract class AutoHouse
    {
        protected string name;
        protected string address;
        protected string ownerNumber;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty!");
                name = value;
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Address cannot be empty!");
                address = value;
            }
        }

        public string OwnerNumber
        {
            get { return ownerNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Owner number cannot be empty!");
                ownerNumber = value;
            }
        }

        protected AutoHouse(string name, string address, string ownerNumber)
        {
            Name = name;
            Address = address;
            OwnerNumber = ownerNumber;
        }

        public abstract void Info();
    }

}
