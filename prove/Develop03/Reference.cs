// ===============================
//           Reference
// -------------------------------
//     - List<string> _reference
// -------------------------------
//     + GetReference(int) : string
// ===============================

public class Reference {

    private List<string> _reference = new List<string> {
        "Moses 1:39",
        "Moses 7:18",
        "Genesis 2:24",
        "Genesis 39:9",
        "Joshua 24:15",
        "Isaiah 1:18",
        "Isaiah 5:20",
        "Amos 3:7",
        "John 3:5",
        "John 3:16",
        "John 7:17",
        "John 17:3",
        "1 Corinthians 11:11",
        "Ephesians 1:10",
        "Hebrews 12:9",
        "1 Peter 4:6",
        "Revelation 20:12",
        "1 Nephi 3:7",
        "2 Nephi 2:25",
        "2 Nephi 2:27",
        "2 Nephi 26:33",
        "2 Nephi 28:30",
        "Proverbs 3:5-6"};


    public string GetReference(int index) {
        return _reference[index];
    }

}