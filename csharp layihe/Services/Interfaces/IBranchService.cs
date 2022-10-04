using layihe1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace layihe1.Services.Interfaces
{
    public interface IBranchService : IBankService<Branch>
    {
        public void HireEmployee(string name, string brchname);
        public void GetProfit(Branch branch, Employee employee);
        public bool TransferMoney(Branch from, Branch to, int amount);
        public void TransferEmployee(Branch from, Branch to, Employee employee);
    }
}