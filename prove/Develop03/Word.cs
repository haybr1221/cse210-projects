// ===============================
//           Word
// -------------------------------
//     - _verse : string
// -------------------------------
//     + VerseToList(string) : void
//     + WordCount() : int
//     + RandomWordIndex() : int
//     + ChangeWord() : string
//     + FormatScripture() : string
// ===============================
using System.Runtime.Serialization;
using System.Text;
public class Word { 

    private List<string> _words;


    public void VerseToList(string text) {
        _words = text.Split(" ").ToList();
    }


    public int WordCount() {
        return _words.Count;
    }


    public int RandomWordIndex() {
        Random random = new Random();
        int i = random.Next(_words.Count);
        return i;
    }


    public string ChangeWord(string word) {
        int len = word.Length;
        string output = "";
        while (len > 0) {
            output += "_";
            len--;
        }
        return output;
    }
    
    
    public string FormatScripture(int numToHide = 3) {
        StringBuilder formattedScripture = new StringBuilder();

        while (numToHide > 0){
            // Get a random word
            int indexOfRandom = RandomWordIndex();
            string randomWord = _words[indexOfRandom];

            // Make sure it hasn't been replaced yet
            if (randomWord.Length > 0 && randomWord[0] == '_') {
                continue;
            }

            // Change the word
            string underscoredWord = ChangeWord(randomWord);

            // Replace the word in the list
            _words[indexOfRandom] = underscoredWord;

            numToHide--;
        }
        foreach (string word in _words) {
            formattedScripture.Append(word);
            formattedScripture.Append(" ");
        }
        return formattedScripture.ToString();
    }
}