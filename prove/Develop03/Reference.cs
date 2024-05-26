class Reference {
    private static string _book;
    private static int _chapter;
    private static int _verse;
    private static int _endVerse;
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public static string GetDisplayText()
    {
        if (_endVerse > 0)
        {
            string myVerse = $"{_book} {_chapter}:{_verse}";
            return myVerse;
        }
        else
        {
            string myVerse = $"{_book} {_chapter}:{_verse}-{_endVerse}";
            return myVerse;
        }
    }
}