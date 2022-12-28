using Shared.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChargeTracker.Models
{
    internal class FinanceRecord
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public User PostedBy { get; set; }
        public DateTime Posted { get; set; }
        public SqlMoney Value { get; set; }
    }
    internal class SpendingRecord : FinanceRecord
    {
        public SpendingType SpendingType { get; set; }
    }
    internal class EarningRecord : FinanceRecord
    {
            public EarningType EarningType { get; set; }
    }

    internal enum SpendingType { Housing, BillsAndUtilities, Debt, Food, Entertainment, Clothing }
    internal enum EarningType { Wages, Gift, Loan, SideHustle }
}
