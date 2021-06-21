using Newtonsoft.Json;

namespace ToolWheel.EliteDangerours.SuperMarket.EventAPI.Services.Journal.Events
{
    public class BankAccountStatistic
    {
        [JsonProperty("Current_Wealth")]
        public long CurrentWealth { get; internal set; }

        [JsonProperty("Spent_On_Ships")]
        public long SpentOnShips { get; internal set; }

        [JsonProperty("Spent_On_Outfitting")]
        public long SpentOnOutfitting { get; internal set; }

        [JsonProperty("Spent_On_Repairs")]
        public long SpentOnRepairs { get; internal set; }

        [JsonProperty("Spent_On_Fuel")]
        public long SpentOnFuel { get; internal set; }

        [JsonProperty("Spent_On_Ammo_Consumables")]
        public long SpentOnAmmoConsumables { get; internal set; }

        [JsonProperty("Insurance_Claims")]
        public long InsuranceClaims { get; internal set; }

        [JsonProperty("Spent_On_Insurance")]
        public long SpentOnInsurance { get; internal set; }

        [JsonProperty("Owned_Ship_Count")]
        public long OwnedShipCount { get; internal set; }

        [JsonProperty("Spent_On_Suits")]
        public long SpentOnSuits { get; internal set; }

        [JsonProperty("Spent_On_Weapons")]
        public long SpentOnWeapons { get; internal set; }

        [JsonProperty("Spent_On_Suit_Consumables")]
        public long SpentOnSuitConsumables { get; internal set; }

        [JsonProperty("Premium_Stock_Bought")]
        public long PremiumStockBought { get; internal set; }

        [JsonProperty("Spent_On_Premium_Stock")]
        public long SpentOnPremiumStock { get; internal set; }
    }
}