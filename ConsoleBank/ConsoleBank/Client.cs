using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBank
{
    class Client
    {
        private int id;
        private string name;
        private string dateJoined;

        public Client()
        {

        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string DateJoined { get => dateJoined; set => dateJoined = value; }

        public void clientName(string _name)
        {
            name = _name;
        }

    }
}
