using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Scripture {
    Reference _reference = new Reference();
    public List<Word> _words = new List<Word>();
    public Scripture(string myReference, string text)
    {   
        public string myReference = Reference.GetDisplayText();
        public string text;
    }
    public void HideRandomWords()
    {
        public string[] hiddenWords = '';
        hiddenWords.Clear();
        public string[] words = _reference.Text.Split('');
        Random random = new Random();
        public int numberToHide = Random.Next(1, words.Length);
        for (int i = 0; i< numberToHide; i++)
        {
           public int randomIndex = Random.Next(0, words.Length);
            if(!hiddenWords.Contains(words[randomIndex]))
            {
              hiddenWords.Add(HideRandomWords[randomIndex]);
                words[randomIndex] = Word.Hide();
            }
        }
    }
    string GetDisplayText()
    {
        
    }
    bool IsCompletelyHidden()
    {

    }

}    