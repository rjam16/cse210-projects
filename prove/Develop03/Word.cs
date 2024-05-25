class Word {
    private string _text;
    public bool _isHidden;
    public void Text(string Word)
    {
        _text = Word;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return "_____";
        }
        else
        {
            return _text;
        }
    }
}