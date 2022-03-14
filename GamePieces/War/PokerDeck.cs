using System;
using System.Collections.Generic;
using System.Text;

namespace GamePieces
{
    class PokerDeck : CardDeck
    {
        private object Back { get; set; }

 #region Allocate Cards
        /** 
         * If these were marked cards, each would have a different back...
         */
        private static PokerCard NewFaceCard(object back, string suit, string name)
        {
            PokerCard card;
            List<Card.CardAttribute> attributes = new List<Card.CardAttribute>();

            attributes.Add(new Card.CardAttribute("Back", back));
            attributes.Add(new Card.CardAttribute("Face", name + " of " +suit));
            attributes.Add(new Card.CardAttribute("Type", "Face"));
            attributes.Add(new Card.CardAttribute("Suit", suit));
            attributes.Add(new Card.CardAttribute("Name", name));
            switch (name)
            {
                case "Ace":
                    attributes.Add(new Card.CardAttribute("Value", 14));
                    attributes.Add(new Card.CardAttribute("Alternate Value", 1));
                    break;
                case "King":
                    attributes.Add(new Card.CardAttribute("Value", 13));
                    break;
                case "Queen":
                    attributes.Add(new Card.CardAttribute("Value", 12));
                    break;
                case "Jack":
                    attributes.Add(new Card.CardAttribute("Value", 11));
                    break;
                default:
                    break;
            }

            card = new PokerCard(attributes);

            return card;
        }
        private static PokerCard NewNumberCard(object back, string suit, int pips)
        {
            PokerCard card;
            List<Card.CardAttribute> attributes = new List<Card.CardAttribute>();
            String name = pips.ToString();

            attributes.Add(new Card.CardAttribute("Back", back));
            attributes.Add(new Card.CardAttribute("Face", name + " of " + suit));
            attributes.Add(new Card.CardAttribute("Type", "Face"));
            attributes.Add(new Card.CardAttribute("Suit", suit));
            attributes.Add(new Card.CardAttribute("Name", name));
            attributes.Add(new Card.CardAttribute("Value", pips));

            card = new PokerCard(attributes);

            return card;

        }
        #endregion

        public PokerDeck(object back)
            : base()
        {
            this.Back = back;
            Add(NewFaceCard(back, "Clubs", "Ace"));
            Add(NewNumberCard(back, "Clubs", 2));
            Add(NewNumberCard(back, "Clubs", 3));
            Add(NewNumberCard(back, "Clubs", 4));
            Add(NewNumberCard(back, "Clubs", 5));
            Add(NewNumberCard(back, "Clubs", 6));
            Add(NewNumberCard(back, "Clubs", 7));
            Add(NewNumberCard(back, "Clubs", 8));
            Add(NewNumberCard(back, "Clubs", 9));
            Add(NewNumberCard(back, "Clubs", 10));
            Add(NewFaceCard(back, "Clubs", "Jack"));
            Add(NewFaceCard(back, "Clubs", "Queen"));
            Add(NewFaceCard(back, "Clubs", "King"));
            
            Add(NewFaceCard(back, "Diamonds", "Ace"));
            Add(NewNumberCard(back, "Diamonds", 2));
            Add(NewNumberCard(back, "Diamonds", 3));
            Add(NewNumberCard(back, "Diamonds", 4));
            Add(NewNumberCard(back, "Diamonds", 5));
            Add(NewNumberCard(back, "Diamonds", 6));
            Add(NewNumberCard(back, "Diamonds", 7));
            Add(NewNumberCard(back, "Diamonds", 8));
            Add(NewNumberCard(back, "Diamonds", 9));
            Add(NewNumberCard(back, "Diamonds", 10));
            Add(NewFaceCard(back, "Diamonds", "Jack"));
            Add(NewFaceCard(back, "Diamonds", "Queen"));
            Add(NewFaceCard(back, "Diamonds", "King"));

            Add(NewFaceCard(back, "Hearts", "Ace"));
            Add(NewNumberCard(back, "Hearts", 2));
            Add(NewNumberCard(back, "Hearts", 3));
            Add(NewNumberCard(back, "Hearts", 4));
            Add(NewNumberCard(back, "Hearts", 5));
            Add(NewNumberCard(back, "Hearts", 6));
            Add(NewNumberCard(back, "Hearts", 7));
            Add(NewNumberCard(back, "Hearts", 8));
            Add(NewNumberCard(back, "Hearts", 9));
            Add(NewNumberCard(back, "Hearts", 10));
            Add(NewFaceCard(back, "Hearts", "Jack"));
            Add(NewFaceCard(back, "Hearts", "Queen"));
            Add(NewFaceCard(back, "Hearts", "King"));

            Add(NewFaceCard(back, "Spades", "Ace"));
            Add(NewNumberCard(back, "Spades", 2));
            Add(NewNumberCard(back, "Spades", 3));
            Add(NewNumberCard(back, "Spades", 4));
            Add(NewNumberCard(back, "Spades", 5));
            Add(NewNumberCard(back, "Spades", 6));
            Add(NewNumberCard(back, "Spades", 7));
            Add(NewNumberCard(back, "Spades", 8));
            Add(NewNumberCard(back, "Spades", 9));
            Add(NewNumberCard(back, "Spades", 10));
            Add(NewFaceCard(back, "Spades", "Jack"));
            Add(NewFaceCard(back, "Spades", "Queen"));
            Add(NewFaceCard(back, "Spades", "King"));
        }

        public PokerDeck(PokerDeck deck)
            : base()
        {
            this.Back = deck.Back;
        }

        override public CardDeck SpawnDeck()
        {
            return new PokerDeck(this);
        }

    }

}
