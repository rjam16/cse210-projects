using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;

class Scripture {
    Reference _reference = new Reference();
    public List<Word> _words = new List<Word>();
    public Scripture(string reference, string text)
    {
        _reference = reference;
        public string text;
    }
    public void HideRandomWords(){
        hiddenWords.Clear();
        string[] words = myScripture.Text.Split('');
        Random random = new Random();
        private int numberToHide = Random.Next(1, words.Length);
        for (int i = 0; i< numberToHide; i++)
        {
            int randomIndex = Random.Next(0, words.Length);
            if(!hiddenWords.Contains(words[randomIndex]))
            {
                hiddenWords.Add(HideRandomWords[randomIndex]);
                words[randomIndex] = "*****";
            }
        }
    }
    public string GetDisplayText(){

    }
    public bool IsCompletelyHidden(){

    }
}