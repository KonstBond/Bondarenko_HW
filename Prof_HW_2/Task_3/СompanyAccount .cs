using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class CompanysAccount : IEnumerable
    {
        Dictionary<long, double> _account;

        public CompanysAccount()
        {
            _account = new Dictionary<long, double>();
        }
        public IEnumerator GetEnumerator()
        {
            return ((IEnumerable)_account).GetEnumerator();
        }

        public void Add(long account, double money)
        {
            _account.Add(account, money);
        }
        public void Remove(long account)
        {
            _account.Remove(account);
        }
        public void ChangeMoney(long account, double money)
        {
            if (_account.ContainsKey(account))
                _account[account] = money;
            else
                throw new ArgumentException($"Not have account: {account}");

        }
    }
}
