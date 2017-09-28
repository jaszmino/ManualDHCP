using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManualDHCP
{
    class IP
    {
        private string _id;
        private string _netzadresse;
        private string _subnetzmaske;
        private int _prefix;
        private int _anzHosts;

        public IP(string id, string netzadresse, string subnetzmaske, int prefix, int anzhosts)
        {
            _id = id;
            _netzadresse = netzadresse;
            _subnetzmaske = subnetzmaske;
            _prefix = prefix;
            _anzHosts = anzHosts;
        }

        public string netzadresse
        {
            get { return _netzadresse; }
            set { _netzadresse = value; }
        }
        public string subnetzmaske
        {
            get { return _subnetzmaske; }
            set { _subnetzmaske = value; }
        }
        public int prefix
        {
            get { return _prefix; }
            set { _prefix = value; }
        }
        public int anzHosts
        {
            get { return _anzHosts; }
            set { _anzHosts = value; }
        }
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
