using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factory
{
    internal static class QuestFactory
    {
        private static readonly List<Quest> _quests = new List<Quest>();

        //use a static constructor to create the quests
        static QuestFactory()
        {
            //Declare the items needed to complete the quest
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            itemsToComplete.Add(new ItemQuantity(9001, 5));

            //Declare the items that the player will receive as a reward
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();
            rewardItems.Add(new ItemQuantity(1002, 1));

            //Create the quest
            _quests.Add(new Quest(1,
                "Clear the herb garden",
                "Defeat the snakes in the Herbalist's garden",
                itemsToComplete,
                25, 10,
                rewardItems));
        }
        internal static Quest GetQuestByID(int id)
        {
            return _quests.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
