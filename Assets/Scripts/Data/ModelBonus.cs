
namespace ShipMaker.Data
{
    [System.Serializable]
    public class ModelBonus
    {
        public string bonusName;
        public string bonusValue;

        public ModelBonus()
        {
        }

        public ModelBonus(string newName, string newValue)
        {
            this.bonusName = newName;
            this.bonusValue = newValue;
        }
    }
}