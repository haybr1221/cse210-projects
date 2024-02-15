// ===============================
//           Scripture
// -------------------------------
//     - List<string> _scriptureVerse
// -------------------------------
//     + RandomScriptureIndex() : int
//     + GetScripture(int) : string
// ===============================

public class Scripture {
    private List<string> _scriptureVerse = new List<string> {
        "For behold, this is my work and my glory to bring to pass the immortality and eternal life of man.",
        "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them.",
        "Therefore shall a man leave his father and his mother, and shall cleave unto his wife: and they shall be one flesh.", 
        "There is none greater in this house than I; neither hath he kept back any thing from me but thee, because thou art his wife: how then can I do this great wickedness, and sin against God?",
        "And if it seem evil unto you to serve the Lord, choose you this day whom ye will serve; whether the gods which your fathers served that were on the other side of the flood, or the gods of the Amorites, in whose land ye dwell: but as for me and my house, we will serve the Lord.",
        "Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool.",
        "Woe unto them that call evil good, and good evil; that put darkness for light, and light for darkness; that put bitter for sweet, and sweet for bitter!",
        "Surely the Lord God will do nothing, but he revealeth his secret unto his servants the prophets.",
        "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.",
        "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
        "If any man will do his will, he shall know of the doctrine, whether it be of God, or whether I speak of myself.",
        "And this is life eternal, that they might know thee the only true God, and Jesus Christ, whom thou hast sent.",
        "Nevertheless neither is the man without the woman, neither the woman without the man, in the Lord.",
        "That in the dispensation of the fulness of times he might gather together in one all things in Christ, both which are in heaven, and which are on earth; even in him",
        "Furthermore we have had fathers of our flesh which corrected us, and we gave them reverence: shall we not much rather be in subjection unto the Father of spirits, and live?",
        "For for this cause was the gospel preached also to them that are dead, that they might be judged according to men in the flesh, but live according to God in the spirit.",
        "And I saw the dead, small and great, stand before God; and the books were opened: and another book was opened, which is the book of life: and the dead were judged out of those things which were written in the books, according to their works.",
        "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.",
        "Adam fell that men might be; and men are, that they might have joy.",
        "Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself.",
        "For none of these iniquities come of the Lord; for he doeth that which is good among the children of men; and he doeth nothing save it be plain unto the children of men; and he inviteth them all to come unto him and partake of his goodness; and he denieth none that come unto him, black and white, bond and free, male and female; and he remembereth the heathen; and all are alike unto God, both Jew and Gentile.",
        "For behold, thus saith the Lord God: I will give unto the children of men line upon line, precept upon precept, here a little and there a little; and blessed are those who hearken unto my precepts, and lend an ear unto my counsel, for they shall learn wisdom; for unto him that receiveth I will give more; and from them that shall say, We have enough, from them shall be taken away even that which they have.",
        "Trust in the Lord with all thine heart; and lean not unto thine own understanding. \nIn all thy ways acknowledge him, and he shall direct thy paths."
        };


    public int RandomScriptureIndex() {
        Random random = new Random();
        int i = random.Next(_scriptureVerse.Count);
        return i;
    }


    public string GetScripture(int index) {
        return _scriptureVerse[index];
    }

}