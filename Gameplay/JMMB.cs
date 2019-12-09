using RPGM.Core;
using RPGM.Gameplay;
using RPGM.UI;
using UnityEngine;

namespace RPGM.Gameplay
{
    /// <summary>
    /// Clone B of NPCController
    /// </summary>
    public class JMMB : NPCController
    {
        public ConversationScript[] conversations;

        Quest activeQuest = null;

        Quest[] quests;

        GameModel model = Schedule.GetModel<GameModel>();

        void OnEnable()
        {
            quests = gameObject.GetComponentsInChildren<Quest>();
        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            var c = GetConversation();
            if (c != null)
            {
                var ev = Schedule.Add<Events.ShowConversation>();
                ev.conversation = c;
                ev.npc = this;
                ev.gameObject = gameObject;
                ev.conversationItemKey = "";
            }
        }

        public void CompleteQuest(Quest q)
        {
            if (activeQuest != q) throw new System.Exception("Completed quest is not the active quest.");
            foreach (var i in activeQuest.requiredItems)
            {
                model.RemoveInventoryItem(i.item, i.count);
                MessageBar.Show($"Vous avez rendu son objet a {i.item.name} ! Bravo !");
            }
            activeQuest.RewardItemsToPlayer();
            activeQuest.OnFinishQuest();
            activeQuest = null;
        }

        public void StartQuest(Quest q)
        {
            if (activeQuest != null) throw new System.Exception("Only one quest should be active.");
            activeQuest = q;
        }

        ConversationScript GetConversation()
        {
            if (activeQuest == null)
                return conversations[0];
            foreach (var q in quests)
            {
                if (q == activeQuest)
                {
                    if (q.IsQuestComplete())
                    {
                        CompleteQuest(q);
                        return q.questCompletedConversation;
                    }
                    return q.questInProgressConversation;
                }
            }
            return null;
        }

        public NPCController clone()
        {
            return this;
        }
    }
}