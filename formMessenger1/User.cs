using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formMessenger1
{
    internal class User
    {
        public string Username { get; set; }
        public string IP { get; set; }
        public List<string> Messeges = new List<string>();

        public void addMessege (string messege)
        {
            Messeges.Add (messege);
        }
    }
}
