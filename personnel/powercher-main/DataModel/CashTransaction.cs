using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataModel
{
    public enum CashTransactionType { DEBIT, CREDIT }
    public class CashTransaction(CashTransactionType type, double amount)
    {
        public string Id { get; init; } = Guid.NewGuid().ToString();
        public CashTransactionType Type { get; init; } = type;
        public double Amount { get; init; } = amount;
        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public static CashTransaction? FromJson(string json)
        {
            return JsonSerializer.Deserialize<CashTransaction>(json);
        }

        public override string ToString()
        {
            return ToJson();
        }

    }
}
