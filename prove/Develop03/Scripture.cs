using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Scripture {
    Reference _reference = new Reference();
    public List<Word> _words = new List<Word>();
    public Scripture(string reference, string text)
    {   
        ScriptureGenerator aScripture = new ScriptureGenerator();
        string myScripture = aScripture.GetRandomScripture();
        foreach (string word in myScripture)
        {
            string[] parts = word.Split(" '");

            string _reference = parts[0];
            string _text = parts[1];
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