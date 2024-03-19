namespace MG_Advanced_C_.Advanced_DS_C__
{
    class Dictionary
    {
        public void Dictionariees(string article)
        {
            Dictionary<char, HashSet<string>> keyValuePairs = new Dictionary<char, HashSet<string>>();

            foreach (var word in article.Split())
            {
                HashSet<char> addedChars = new HashSet<char>(); // To keep track of characters already added for the current word
                foreach (var ch in word)
                {
                    if (!addedChars.Contains(ch)) // Check if the character has already been added for the current word
                    {
                        if (!keyValuePairs.ContainsKey(ch))
                        {
                            keyValuePairs.Add(ch, new HashSet<string> { word });
                        }
                        else
                        {
                            keyValuePairs[ch].Add(word);
                        }

                        addedChars.Add(ch); // Add the character to the set of added characters for the current word
                    }
                }
            }

            foreach (var item in keyValuePairs)
            {
                Console.Write($" Key = {item.Key} : \n");
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine($" \t\t{item2} ");
                }
            }
        }

    }
}
