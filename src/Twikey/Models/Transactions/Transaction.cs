using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Twikey.Models.Transactions
{
    public class Transaction
    {
        public IEnumerable<TransactionEntry> Entries { get; set;}
    }

    public class TransactionEntry
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }
        [JsonProperty("contractId", NullValueHandling = NullValueHandling.Ignore)]
        public string ContractId { get; set; }
        [JsonProperty("mndtId", NullValueHandling = NullValueHandling.Ignore)]
        public string MandateId { get; set; }
        [JsonProperty("contract", NullValueHandling = NullValueHandling.Ignore)]
        public string Contract { get; set; }
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal Amount { get; set; }
        [JsonProperty("msg", NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }
        [JsonProperty("place", NullValueHandling = NullValueHandling.Ignore)]
        public string Place { get; set; }
        [JsonProperty("ref", NullValueHandling = NullValueHandling.Ignore)]
        public string Reference { get; set; }
        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? Date { get; set; }
    }
}
