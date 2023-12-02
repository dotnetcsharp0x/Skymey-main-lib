using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skymey_main_lib.Models.Blockchain.Chia.Mempool
{
    public class ChiaMempoolItems
    {
        public class ChiaMempoolItemsHash
        {
            public List<ChiaMempoolItemsAddition> additions { get; set; }
            public int cost { get; set; }
            public int fee { get; set; }
            public ChiaMempoolItemsNpcResult npc_result { get; set; }
            public List<ChiaMempoolItemsRemoval> removals { get; set; }
            public ChiaMempoolItemsSpendBundle spend_bundle { get; set; }
            public string spend_bundle_name { get; set; }
        }

        public class ChiaMempoolItemsAddition
        {
            public object amount { get; set; }
            public string parent_coin_info { get; set; }
            public string puzzle_hash { get; set; }
        }

        public class ChiaMempoolItemsHash2
        {
            public List<ChiaMempoolItemsAddition> additions { get; set; }
            public long cost { get; set; }
            public int fee { get; set; }
            public ChiaMempoolItemsNpcResult npc_result { get; set; }
            public List<ChiaMempoolItemsRemoval> removals { get; set; }
            public ChiaMempoolItemsSpendBundle spend_bundle { get; set; }
            public string spend_bundle_name { get; set; }
        }

        public class ChiaMempoolItemsCoin
        {
            public object amount { get; set; }
            public string parent_coin_info { get; set; }
            public string puzzle_hash { get; set; }
        }

        public class ChiaMempoolItemsCoinSpend
        {
            public ChiaMempoolItemsCoin coin { get; set; }
            public string puzzle_reveal { get; set; }
            public string solution { get; set; }
        }

        public class ChiaMempoolItemsConds
        {
            public long addition_amount { get; set; }
            public List<object> agg_sig_unsafe { get; set; }
            public object before_height_absolute { get; set; }
            public object before_seconds_absolute { get; set; }
            public int cost { get; set; }
            public int height_absolute { get; set; }
            public long removal_amount { get; set; }
            public int reserve_fee { get; set; }
            public int seconds_absolute { get; set; }
            public List<ChiaMempoolItemsSpend> spends { get; set; }
        }

        public class ChiaMempoolItemsMempoolItems
        {
            public ChiaMempoolItemsHash ChiaMempoolItemsHash { get; set; }
            public ChiaMempoolItemsHash2 ChiaMempoolItemsHash2 { get; set; }
        }

        public class ChiaMempoolItemsNpcResult
        {
            public ChiaMempoolItemsConds conds { get; set; }
            public int cost { get; set; }
            public object error { get; set; }
        }

        public class ChiaMempoolItemsRemoval
        {
            public object amount { get; set; }
            public string parent_coin_info { get; set; }
            public string puzzle_hash { get; set; }
        }

        public class ChiaMempoolItemsItems
        {
            public ChiaMempoolItemsMempoolItems mempool_items { get; set; }
            public bool success { get; set; }
        }

        public class ChiaMempoolItemsSpend
        {
            public List<object> agg_sig_amount { get; set; }
            public List<List<string>> agg_sig_me { get; set; }
            public List<object> agg_sig_parent { get; set; }
            public List<object> agg_sig_parent_amount { get; set; }
            public List<object> agg_sig_parent_puzzle { get; set; }
            public List<object> agg_sig_puzzle { get; set; }
            public List<object> agg_sig_puzzle_amount { get; set; }
            public object before_height_relative { get; set; }
            public object before_seconds_relative { get; set; }
            public object birth_height { get; set; }
            public object birth_seconds { get; set; }
            public object coin_amount { get; set; }
            public string coin_id { get; set; }
            public List<List<object>> create_coin { get; set; }
            public int flags { get; set; }
            public object height_relative { get; set; }
            public string parent_id { get; set; }
            public string puzzle_hash { get; set; }
            public object seconds_relative { get; set; }
        }

        public class ChiaMempoolItemsSpendBundle
        {
            public string aggregated_signature { get; set; }
            public List<ChiaMempoolItemsCoinSpend> coin_spends { get; set; }
        }
    }
}
