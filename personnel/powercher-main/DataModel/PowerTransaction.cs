using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataModel
{
    public enum PowerTransactionType
    {
        ENERGY_OFFER_RESPONSE, 
        ENERGY_NEED_RESPONSE, 
        ENERGY_NEED_REQUEST, 
        ENERGY_OFFER_REQUEST
    }
    public class PowerTransaction
    {
        public PowerTransaction(PowerTransactionType type, double price, double amount)
        {
            Type = type;
            Price = price;
            Amount = amount;
        }

        /// <summary>
        /// Identifiant technique 
        /// </summary>
        public string Id { get; init; } = Guid.NewGuid().ToString();
        public PowerTransactionType Type { get; }
        /// <summary>
        /// Quantité de cash 
        /// </summary>
        public double Price { get; }
        /// <summary>
        /// Nombre de kwh
        /// </summary>
        public double Amount { get; }
        public string ToJson()
        {
            return JsonSerializer.Serialize(this);
        }

        public static PowerTransaction? FromJson(string json)
        {
            return JsonSerializer.Deserialize<PowerTransaction>(json);
        }

        public override string ToString()
        {
            return ToJson();
        }

    }
}
