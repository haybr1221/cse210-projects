using System;
// To exceed requirements, I made sure only words that haven't been changed yet
// were changed, instead of having the posibility of repeatedly hidding already
// hidden words. 
class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Reference reference = new Reference();
        Word word = new Word();
        

        int _index = scripture.RandomScriptureIndex();
        int _timesThrough = 0;

        string _text = scripture.GetScripture(_index);
        string givenReference = reference.GetReference(_index);
        word.VerseToList(_text);

        int _textLen = word.WordCount();


        while (_textLen > 0) {
            Console.Clear();
            Console.WriteLine($"{givenReference}");
            if (_timesThrough == 0) {
                // First time running code
                Console.WriteLine($"{_text}");
            }
            else {
                // Code as been through at least once, take away words
                if (_textLen >= 3) {
                    string withHiddenWords = word.FormatScripture();
                    Console.WriteLine(withHiddenWords);
                    _textLen -= 3;
                }
                else if (_textLen == 2) {
                    // In case there is just two words left
                    string withHiddenWords = word.FormatScripture(2);
                    Console.WriteLine(withHiddenWords);
                    _textLen -= 2;

                }
                else if (_textLen == 1) {
                    // In case there is just one word left
                    string withHiddenWords = word.FormatScripture(1);
                    Console.WriteLine(withHiddenWords);
                    _textLen -= 1;
                }
            }
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string _input = Console.ReadLine();
            if (_input == "quit") {
                break;
            }
            _timesThrough++;
        }
        
    }
}