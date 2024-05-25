using System;
using System.Collections.Generic;
class ScriptureGenerator
{
    public static string[] input = {"Moroni 1:33 'And Christ hath said if ye will have faith in me ye shall have power to do whatsoever thing is expedient in me.'","3 Nephi 27:29 'Therefore, ask, and ye shall receive, knock, and it shall be opened unto you; for he that asketh, receiveth; and unto him that knocketh, it shall be opened.'","Moroni 9:15 'God has not ceased to be a God of miracles.'","Moroni 8:17-18 'And I am filled with charity, which is everlasting love; wherefore, all children are alike unto me; wherefore, I love little children with a perfect love; and they are all alike and partakers of salvation. For I know that God is not a partial God, neither a changeable being; but he is unchangeable from all eternity to all eternity.'"};
    public static List<string> _scriptures = new List<string>(input);
    public static string GetRandomScripture()
    {
        var random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}