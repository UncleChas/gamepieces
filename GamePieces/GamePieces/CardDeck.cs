using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Text;

namespace GamePieces 
{
    class CardDeck : Collection<Card>
    { 
        public Random Rand
        {
            get
            {
                if (null == Rand)
                {
                    Rand = new Random();
                }
                return Rand;
            }
            private set { Rand = value; }
        }
        public CardDeck () : base () { }

        public CardDeck(CardDeck deck) : base() { }

        public virtual CardDeck SpawnDeck()
        {
            return new CardDeck(this);
        }

        private Card TopCard
        {
            get
            {
                return Items[0];
            }
        }
        private Card BottomCard
        {
            get
            {
                return Items[Count - 1];
            }
        }

        public virtual Card Deal()
        {
            Card card;
            if (!IsEmpty())
            {
                Card topCard = TopCard;
                Remove(topCard);
                card = topCard;
            }
            else
            {
                throw new IndexOutOfRangeException("The card deck is empty.");
            }
            return card;
        }

        public virtual Card DealFromBottom()
        {
            Card card;
            if (!IsEmpty())
            {
                int index = Count - 1;
                Card bottomCard = Items[index];
                RemoveAt(index);
                card = bottomCard;
            }
            else
            {
                throw new IndexOutOfRangeException("The card deck is empty.");
            }
            return card;
        }

        public bool IsEmpty()
        {
            return Count <= 0;
        }

        public virtual void Cut(int cutPoint)
        {
            for (int count = 0; count < cutPoint; count++)
            {
                Card card = Items[0];
                Remove(card);
                Add(card);
            }
        }

        /**
         * Rifling a deck is a common way of mixing the cards
         * split the deck into two similar sized decks
         * release a small number of cards from the bottom of one 
         * than the other until the deck is rebuilt again with all the cards
         * Theory is that if you do this 8 times, perfectly alternating 1 card from each half you will have the cards back in the original order
         * but if you do it imperfectly 7 times you will be quite sufficiently random
         * So, the implementation of "imperfect" is not something that computers do well..
         * To start with I will "roll a 6 sided die" on a 1 I'll do 1 card, a 2 or 3, will be 2 cards, a 4 or 5 will be 3 cards and a 6 will be 4 cards.
         * 
         */
        public virtual void Rifle(int interations)
        {
            Rifle(interations - 1);

            int cutPoint = GetImperfectMidPoint(Count);
            CardDeck leftDeck;
            CardDeck rightDeck;
            int originalCount = Count;

            SplitDeck(cutPoint, out leftDeck, out rightDeck);

            while (Count < originalCount)
            {
                if (leftDeck.Count > 0)
                {
                    int numCards = GetImperfectMidPoint(Math.Min(4, leftDeck.Count));
                    for (int count = 0; count < numCards; count++)
                    {
                        Card card = leftDeck.DealFromBottom();
                        InsertItem(0, card);
                    }
                }
                if (rightDeck.Count > 0)
                {
                    int numCards = GetImperfectMidPoint(Math.Min(4, rightDeck.Count));
                    for (int count = 0; count < numCards; count++)
                    {
                        Card card = rightDeck.DealFromBottom();
                        InsertItem(0, card);
                    }
                }
            }
        }

        public void SplitDeck(int cutPoint, out CardDeck leftDeck, out CardDeck rightDeck)
        {
            leftDeck = SpawnDeck();
            rightDeck = SpawnDeck();
            for (int count = 0; count < cutPoint; count++)
            {
                leftDeck.Add(Items[count]);
            }
            for (int count = cutPoint; count < Count; count++)
            {
                rightDeck.Add(Items[count]);
            }
            ClearItems();
        }

        /**
         * So Python has a nice gaussian function in it's random number generator, but we don't have that unless I reimplement it
         * instead, I'm going to generate N random numbers in the valid range then average them. Results should be a bell curve 
         * centered on the middle of the range
         */
        private int GetImperfectMidPoint(int maxNumber)
        {
            int bellCurveAttempts = 10;

            int cutPoint = 1 + (int)Math.Round(Rand.CurvedNextDouble(bellCurveAttempts) * (maxNumber-1) + 0.5);
            
            return cutPoint;
        }

        public override string ToString()
        {
            Card topCard = TopCard;
            string output = $"{topCard.Back.ToString()} ({Count}) cards";

            return output;
        }
        
        public object Top()
        {
            return TopCard.Back;
        }
        public object Bottom()
        {
            return BottomCard.Face;
        }
    }

}
