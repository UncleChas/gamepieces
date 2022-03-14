using System;
using System.Collections.Generic;
using System.Text;

namespace GamePieces
{
    public class Card
    {
        public class CardAttribute
        {
            public string Name { get; private set; }
            public object Value { get; private set; }
            public CardAttribute(string name, object value)
            {
                Name = name;
                Value = value;
            }

        }

        protected Dictionary<string, object> Attributes { get; private set; }

        public Card(ICollection<CardAttribute> attributes)
        {
            if (null == attributes)
            {
                Attributes = new Dictionary<string, object>
                {
                    { "Face", "Empty Face" },
                    { "Back", "Empty Back" }
                };
            }
            else
            {
                Attributes = new Dictionary<string, object>();
                foreach (var attribute in attributes)
                {
                    Attributes.Add(attribute.Name, attribute.Value);
                }
                if (!Attributes.ContainsKey("Face"))
                {
                    Attributes.Add("Face", "Empty Face");
                }
                if (!Attributes.ContainsKey("Back"))
                {
                    Attributes.Add("Back", "Empty Back");
                }
            }
        }

        public Card(Dictionary<string, object> attributes)
        {
            if (null == attributes)
            {
                Attributes = new Dictionary<string, object>
                {
                    { "Face", "Empty Face" },
                    { "Back", "Empty Back" }
                };
            }
            else
            {
                Attributes = attributes;
            }
        }

        public Card(object face, object back)
        {
            Attributes = new Dictionary<string, object>
            {
                { "Face", face },
                { "Back", back }
            };
        }

        public Card(object face, Object back, Dictionary<string, object> attributes)
        {
            if (null == attributes)
            {
                Attributes = new Dictionary<string, object>
                {
                    { "Face", face },
                    { "Back", back }
                };
            }
            else
            {
                Attributes = attributes;
                if (!attributes.ContainsKey("Face"))
                {
                    Attributes.Add("Face", face);
                }
                if (!attributes.ContainsKey("Back"))
                {
                    Attributes.Add("Back", back);
                }
            }
        }
        public void AddAttribute(CardAttribute attribute)
        {
            if (!HasAttribute(attribute.Name))
            {
                Attributes.Add(attribute.Name, attribute.Value);
            }
        }

        public bool HasAttribute(string name)
        {
            bool hasAttribute;

            List<string> names = GetAttributeList();
            hasAttribute = names.Contains(name);

            return hasAttribute;
        }

        public object GetAttributeValue(string name)
        {
            object value;
            Attributes.TryGetValue(name, out value);

            return value;
        }

        public List<string> GetAttributeList()
        {
            List<string> names = new List<string>();

            foreach (var name in Attributes.Keys)
            {
                names.Add(name);
            }

            return names;
        }

        public object Back { get { return GetAttributeValue("Back"); } }
        public object Face { get { return GetAttributeValue("Face"); } }
    }
}
